using MODELO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MODELO.Composite;
using System.Text.RegularExpressions;

namespace CONTROLADORA
{
    public class Controladora_reservas
    {
        private static Controladora_reservas instancia;
        public static Controladora_reservas Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora_reservas();
                }
                return instancia;
            }
        }

        public Controladora_reservas()
        {

        }

        public ReadOnlyCollection<Reserva> ListarReservas()
        {
            using (var context = new Context())
            {
                return context.Reservas.Include(r => r.MotivosCancelacion).Include(r => r.Cabaña).Include(r => r.Cliente).ToList().AsReadOnly();
            }
        }

        public Reserva CrearReserva(int Idcabaña, int Idcliente, DateTime fecha_entrada, DateTime fecha_salida, decimal precio)
        {
            Reserva reserva = new Reserva();

            reserva.IdCabaña = Idcabaña;
            reserva.IdCliente = Idcliente;
            reserva.FechaEntrada = fecha_entrada;
            reserva.FechaSalida = fecha_salida;
            reserva.Precio = precio;

            return reserva;
        }

        public string AgregarReserva(Reserva nuevaReserva)
        {

            using (var context = new Context())
            {
                try
                {
                    context.Add(nuevaReserva);
                    context.SaveChanges();
                    return $"Nueva reserva agregada al sistema con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }


        }

        public string ModificarReserva(Reserva reserva)
        {
            using (var context = new Context())
            {
                try
                {
                    context.Update(reserva);
                    context.SaveChanges();
                    return $"Reserva modificada con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }

        }


        public string EliminarReserva(Reserva reserva)
        {

            using (var context = new Context())
            {
                try
                {
                    context.Remove(reserva);
                    context.SaveChanges();
                    return $"Reserva eliminada con exito";
                }
                catch (Exception ex)
                {
                    return "Ocurrio un error en el sistema:  " + ex.Message;
                }
            }
        }

        public bool ValidaReserva(Cabaña cabaña, DateTime fecha_entrada, DateTime fecha_salida, int? reservaIdExcluir = null)
        {
            using (var context = new Context())
            {
                var reservas = context.Reservas
                    .Where(r => r.IdCabaña == cabaña.CabañaId && r.Estado != "Cancelada")
                    .ToList();

                if (!cabaña.Activa && cabaña.FechaFinDesactivacion.HasValue)
                {
                    DateTime hoy = DateTime.Today;
                    DateTime fin = cabaña.FechaFinDesactivacion.Value;

                    if (fecha_entrada <= fin && fecha_salida >= hoy)
                    {
                        return false; 
                    }
                }

                foreach (var reserva in reservas)
                {
                    if (reservaIdExcluir.HasValue && reserva.ReservaId == reservaIdExcluir.Value)
                        continue;

                    if (!(fecha_salida < reserva.FechaEntrada || fecha_entrada > reserva.FechaSalida))
                        return false; 
                }

                return true; 
            }
        }

        public void ActualizarEstadosReservas()
        {
            using (var context = new Context())
            {
                var reservas = context.Reservas.ToList();

                DateTime hoy = DateTime.Today;

                foreach (var reserva in reservas)
                {
                    if (reserva.Estado == "Cancelada") continue;

                    if (hoy < reserva.FechaEntrada)
                        reserva.Estado = "Pendiente";
                    else if (hoy >= reserva.FechaEntrada && hoy <= reserva.FechaSalida)
                        reserva.Estado = "Activa";
                    else if (hoy > reserva.FechaSalida)
                        reserva.Estado = "Finalizada";
                }

                context.SaveChanges();
            }
        }

        public List<(Cliente cliente, DateTime fechaEntrada, DateTime fechaSalida)> ObtenerClientesConReservasActivasPorCabaña(int idCabaña)
        {
            using (var context = new Context())
            {
                DateTime hoy = DateTime.Today;

                var cabaña = context.Cabañas.FirstOrDefault(c => c.CabañaId == idCabaña);

                if (cabaña == null || !cabaña.FechaFinDesactivacion.HasValue)
                    return new List<(Cliente, DateTime, DateTime)>();

                DateTime fechaLimite = cabaña.FechaFinDesactivacion.Value;

                var reservas = context.Reservas
                    .Include(r => r.Cliente)
                    .Where(r => r.IdCabaña == idCabaña
                        && r.FechaSalida >= hoy
                        && r.FechaEntrada <= fechaLimite
                        && (r.Estado == "Pendiente" || r.Estado == "Activa"))
                    .ToList();

                var datos = reservas.Select(r => (r.Cliente, r.FechaEntrada, r.FechaSalida)).ToList();

                return datos;
            }
        }


        public Reserva ObtenerReservaId(int id)
        {
            using (var context = new Context())
            {
                var reserva = context.Reservas.Include(r => r.Cliente)
                .Include(r => r.Cabaña)
                .Include(r => r.MotivosCancelacion) 
                .FirstOrDefault(r => r.ReservaId == id);

                if (reserva == null)
                    return null;

                return reserva;
            }

        }

        public string AgregarMotivoACancelacion(int reservaId, List<MotivoCancelacion> motivosSeleccionados)
        {
            using (var context = new Context())
            {
                try
                {
                    var reserva = context.Reservas.Include(r => r.MotivosCancelacion).FirstOrDefault(r => r.ReservaId == reservaId);

                    if (reserva == null)
                        return "Reserva no encontrada.";

                    if (reserva.MotivosCancelacion == null)
                    {
                        return "Error: la colección de motivos no se cargó.";
                    }

                    reserva.MotivosCancelacion.Clear();

                    var idsSeleccionados = motivosSeleccionados.Select(m => m.MotivoCancelacionId).ToList();

                    var motivosDesdeDb = context.MotivosCancelacion
                    .Where(m => idsSeleccionados.Contains(m.MotivoCancelacionId))
                    .ToList();

                    foreach (var motivo in motivosDesdeDb)
                    {
                        reserva.MotivosCancelacion.Add(motivo);
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

