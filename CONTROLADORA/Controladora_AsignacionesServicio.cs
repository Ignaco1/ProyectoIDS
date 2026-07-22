using Microsoft.EntityFrameworkCore;
using MODELO;
using MODELO.State;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CONTROLADORA
{
    public class Controladora_AsignacionesServicio
    {
        public AsignacionServicio CrearAsignacion(int servicioId, int reservaId, DateTime fecha, TimeSpan hora)
        {
            AsignacionServicio asignacion = new AsignacionServicio();

            asignacion.ServicioId = servicioId;
            asignacion.ReservaId = reservaId;
            asignacion.Fecha = fecha.Date;
            asignacion.Hora = hora;

            return asignacion;
        }

        public string AgregarAsignacion(AsignacionServicio nuevaAsignacion)
        {
            using (var context = new Context())
            {
                try
                {
                    context.Add(nuevaAsignacion);
                    context.SaveChanges();
                    return "Servicio asignado con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }
        }

        public bool ExisteDisponibilidad(int servicioId, DateTime fecha, TimeSpan hora, int? asignacionIdExcluir = null)
        {
            using (var context = new Context())
            {
                return !context.AsignacionesServicio
                    .Any(a => a.ServicioId == servicioId && a.Fecha.Date == fecha.Date && a.Hora == hora
                        && a.Estado != EstadoAsignacionCancelada.Instancia.Nombre
                        && (!asignacionIdExcluir.HasValue || a.AsignacionServicioId != asignacionIdExcluir.Value));
            }
        }

        public ReadOnlyCollection<AsignacionServicio> ListarAsignaciones()
        {
            using (var context = new Context())
            {
                return context.AsignacionesServicio
                    .Include(a => a.Servicio)
                    .Include(a => a.Reserva).ThenInclude(r => r.Cliente)
                    .Include(a => a.Reserva).ThenInclude(r => r.Cabaña)
                    .Include(a => a.MotivosCancelacion)
                    .AsNoTracking()
                    .ToList()
                    .AsReadOnly();
            }
        }

        public AsignacionServicio ObtenerAsignacionId(int id)
        {
            using (var context = new Context())
            {
                return context.AsignacionesServicio
                    .Include(a => a.Servicio)
                    .Include(a => a.Reserva).ThenInclude(r => r.Cliente)
                    .Include(a => a.Reserva).ThenInclude(r => r.Cabaña)
                    .Include(a => a.MotivosCancelacion)
                    .FirstOrDefault(a => a.AsignacionServicioId == id);
            }
        }

        public string ModificarAsignacion(int asignacionId, int servicioId, DateTime fecha, TimeSpan hora)
        {
            using (var context = new Context())
            {
                try
                {
                    var asignacionDb = context.AsignacionesServicio.FirstOrDefault(a => a.AsignacionServicioId == asignacionId);

                    if (asignacionDb == null)
                        return "Servicio asignado no encontrado.";

                    asignacionDb.ServicioId = servicioId;
                    asignacionDb.Fecha = fecha.Date;
                    asignacionDb.Hora = hora;

                    context.SaveChanges();
                    return "Servicio asignado modificado con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }
        }

        public string EliminarAsignacion(AsignacionServicio asignacion)
        {
            using (var context = new Context())
            {
                try
                {
                    context.Remove(asignacion);
                    context.SaveChanges();
                    return "Servicio asignado eliminado con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }
        }

        public string CancelarAsignacion(AsignacionServicio asignacion)
        {
            using (var context = new Context())
            {
                try
                {
                    var asignacionDb = context.AsignacionesServicio.FirstOrDefault(a => a.AsignacionServicioId == asignacion.AsignacionServicioId);

                    if (asignacionDb == null)
                        return "Servicio asignado no encontrado.";

                    asignacionDb.Cancelar();
                    context.SaveChanges();
                    return "Servicio asignado cancelado con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }
        }

        public List<AsignacionServicio> OrdenarYLimitarAsignaciones(List<AsignacionServicio> asignaciones, int limite)
        {
            var masRecientes = asignaciones
                .OrderByDescending(a => a.Fecha)
                .ThenByDescending(a => a.Hora)
                .Take(limite)
                .ToList();

            var activas = masRecientes.Where(a => a.EstadoActual is EstadoAsignacionActiva).OrderBy(a => a.Fecha).ThenBy(a => a.Hora).ToList();
            var pendientes = masRecientes.Where(a => a.EstadoActual is EstadoAsignacionPendiente).OrderBy(a => a.Fecha).ThenBy(a => a.Hora).ToList();
            var finalizadas = masRecientes.Where(a => a.EstadoActual is EstadoAsignacionFinalizada).OrderByDescending(a => a.Fecha).ThenByDescending(a => a.Hora).ToList();
            var otras = masRecientes.Where(a => a.EstadoActual is not (EstadoAsignacionActiva or EstadoAsignacionPendiente or EstadoAsignacionFinalizada)).ToList();

            var resultado = new List<AsignacionServicio>();
            resultado.AddRange(activas);
            resultado.AddRange(pendientes);
            resultado.AddRange(finalizadas);
            resultado.AddRange(otras);

            return resultado;
        }

        public void ActualizarEstadosAsignaciones()
        {
            using (var context = new Context())
            {
                var asignaciones = context.AsignacionesServicio.ToList();

                DateTime ahora = DateTime.Now;

                foreach (var asignacion in asignaciones)
                {
                    asignacion.ActualizarEstadoSegunFecha(ahora);
                }

                context.SaveChanges();
            }
        }

        public string AgregarMotivoACancelacion(int asignacionId, List<MotivoCancelacionServicio> motivosSeleccionados)
        {
            using (var context = new Context())
            {
                try
                {
                    var asignacion = context.AsignacionesServicio.Include(a => a.MotivosCancelacion).FirstOrDefault(a => a.AsignacionServicioId == asignacionId);

                    if (asignacion == null)
                        return "Servicio asignado no encontrado.";

                    asignacion.MotivosCancelacion.Clear();

                    var idsSeleccionados = motivosSeleccionados.Select(m => m.MotivoCancelacionServicioId).ToList();

                    var motivosDesdeDb = context.MotivosCancelacionServicio
                        .Where(m => idsSeleccionados.Contains(m.MotivoCancelacionServicioId))
                        .ToList();

                    foreach (var motivo in motivosDesdeDb)
                    {
                        asignacion.MotivosCancelacion.Add(motivo);
                    }

                    context.SaveChanges();
                    return "motivos agregados correctamente.";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }
        }
    }
}
