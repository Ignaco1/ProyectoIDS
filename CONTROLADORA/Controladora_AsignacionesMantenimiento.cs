using Microsoft.EntityFrameworkCore;
using MODELO;
using MODELO.State;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CONTROLADORA
{
    public class Controladora_AsignacionesMantenimiento
    {
        public AsignacionMantenimiento CrearAsignacion(int mantenimientoId, int cabañaId, int empleadoId, DateTime fechaInicio, DateTime fechaFin, decimal costo, bool desactivaCabaña)
        {
            AsignacionMantenimiento asignacion = new AsignacionMantenimiento();

            asignacion.MantenimientoId = mantenimientoId;
            asignacion.CabañaId = cabañaId;
            asignacion.EmpleadoId = empleadoId;
            asignacion.FechaInicio = fechaInicio.Date;
            asignacion.FechaFin = fechaFin.Date;
            asignacion.Costo = costo;
            asignacion.DesactivaCabaña = desactivaCabaña;
            asignacion.Estado = "Pendiente";

            return asignacion;
        }

        public string AgregarAsignacion(AsignacionMantenimiento nuevaAsignacion)
        {
            using (var context = new Context())
            {
                try
                {
                    context.Add(nuevaAsignacion);
                    context.SaveChanges();
                    return "Mantenimiento asignado con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }
        }

        public ReadOnlyCollection<AsignacionMantenimiento> ListarAsignaciones()
        {
            using (var context = new Context())
            {
                return context.AsignacionesMantenimiento
                    .Include(a => a.Mantenimiento)
                    .Include(a => a.Cabaña)
                    .Include(a => a.Empleado)
                    .Include(a => a.MotivosCancelacion)
                    .AsNoTracking()
                    .ToList()
                    .AsReadOnly();
            }
        }

        public AsignacionMantenimiento ObtenerAsignacionId(int id)
        {
            using (var context = new Context())
            {
                return context.AsignacionesMantenimiento
                    .Include(a => a.Mantenimiento)
                    .Include(a => a.Cabaña)
                    .Include(a => a.Empleado)
                    .Include(a => a.MotivosCancelacion)
                    .FirstOrDefault(a => a.AsignacionMantenimientoId == id);
            }
        }

        public string ModificarAsignacion(int asignacionId, int mantenimientoId, int cabañaId, int empleadoId, DateTime fechaInicio, DateTime fechaFin, decimal costo, bool desactivaCabaña)
        {
            using (var context = new Context())
            {
                try
                {
                    var asignacionDb = context.AsignacionesMantenimiento.FirstOrDefault(a => a.AsignacionMantenimientoId == asignacionId);

                    if (asignacionDb == null)
                        return "Mantenimiento asignado no encontrado.";

                    asignacionDb.MantenimientoId = mantenimientoId;
                    asignacionDb.CabañaId = cabañaId;
                    asignacionDb.EmpleadoId = empleadoId;
                    asignacionDb.FechaInicio = fechaInicio.Date;
                    asignacionDb.FechaFin = fechaFin.Date;
                    asignacionDb.Costo = costo;
                    asignacionDb.DesactivaCabaña = desactivaCabaña;

                    context.SaveChanges();
                    return "Mantenimiento asignado modificado con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }
        }

        public List<AsignacionMantenimiento> ListarAsignacionesQueDesactivanCabaña(int cabañaId)
        {
            using (var context = new Context())
            {
                return context.AsignacionesMantenimiento
                    .Where(a => a.CabañaId == cabañaId
                        && a.DesactivaCabaña
                        && (a.Estado == EstadoAsignacionMantenimientoPendiente.Instancia.Nombre
                            || a.Estado == EstadoAsignacionMantenimientoActiva.Instancia.Nombre))
                    .ToList();
            }
        }

        public string EliminarAsignacion(AsignacionMantenimiento asignacion)
        {
            using (var context = new Context())
            {
                try
                {
                    context.Remove(asignacion);
                    context.SaveChanges();
                    return "Mantenimiento asignado eliminado con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }
        }

        public string CancelarAsignacion(AsignacionMantenimiento asignacion)
        {
            using (var context = new Context())
            {
                try
                {
                    var asignacionDb = context.AsignacionesMantenimiento.FirstOrDefault(a => a.AsignacionMantenimientoId == asignacion.AsignacionMantenimientoId);

                    if (asignacionDb == null)
                        return "Mantenimiento asignado no encontrado.";

                    asignacionDb.Cancelar();
                    context.SaveChanges();
                    return "Mantenimiento asignado cancelado con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }
        }

        public List<AsignacionMantenimiento> OrdenarYLimitarAsignaciones(List<AsignacionMantenimiento> asignaciones, int limite)
        {
            var masRecientes = asignaciones
                .OrderByDescending(a => a.FechaInicio)
                .Take(limite)
                .ToList();

            var activas = masRecientes.Where(a => a.EstadoActual is EstadoAsignacionMantenimientoActiva).OrderBy(a => a.FechaInicio).ToList();
            var pendientes = masRecientes.Where(a => a.EstadoActual is EstadoAsignacionMantenimientoPendiente).OrderBy(a => a.FechaInicio).ToList();
            var finalizadas = masRecientes.Where(a => a.EstadoActual is EstadoAsignacionMantenimientoFinalizada).OrderByDescending(a => a.FechaInicio).ToList();
            var otras = masRecientes.Where(a => a.EstadoActual is not (EstadoAsignacionMantenimientoActiva or EstadoAsignacionMantenimientoPendiente or EstadoAsignacionMantenimientoFinalizada)).ToList();

            var resultado = new List<AsignacionMantenimiento>();
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
                var asignaciones = context.AsignacionesMantenimiento.ToList();

                DateTime ahora = DateTime.Now;

                foreach (var asignacion in asignaciones)
                {
                    asignacion.ActualizarEstadoSegunFecha(ahora);
                }

                context.SaveChanges();
            }
        }

        public string AgregarMotivoACancelacion(int asignacionId, List<MotivoCancelacionMantenimiento> motivosSeleccionados)
        {
            using (var context = new Context())
            {
                try
                {
                    var asignacion = context.AsignacionesMantenimiento.Include(a => a.MotivosCancelacion).FirstOrDefault(a => a.AsignacionMantenimientoId == asignacionId);

                    if (asignacion == null)
                        return "Mantenimiento asignado no encontrado.";

                    asignacion.MotivosCancelacion.Clear();

                    var idsSeleccionados = motivosSeleccionados.Select(m => m.MotivoCancelacionMantenimientoId).ToList();

                    var motivosDesdeDb = context.MotivosCancelacionMantenimiento
                        .Where(m => idsSeleccionados.Contains(m.MotivoCancelacionMantenimientoId))
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
