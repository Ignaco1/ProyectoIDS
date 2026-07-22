using System;
using System.ComponentModel.DataAnnotations.Schema;
using MODELO.State;

namespace MODELO
{
    [Table("AsignacionesServicio")]
    public class AsignacionServicio
    {
        public int AsignacionServicioId { get; set; }
        public int ServicioId { get; set; }
        public int ReservaId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }

        [NotMapped]
        public IEstadoAsignacionServicio? EstadoActual { get; private set; }

        public string? Estado
        {
            get => EstadoActual?.Nombre;
            set => EstadoActual = EstadoAsignacionServicioFactory.Crear(value);
        }

        [ForeignKey("ServicioId")]
        public virtual Servicio Servicio { get; set; }

        [ForeignKey("ReservaId")]
        public virtual Reserva Reserva { get; set; }

        public ICollection<MotivoCancelacionServicio> MotivosCancelacion { get; set; } = new List<MotivoCancelacionServicio>();

        public void ActualizarEstadoSegunFecha(DateTime ahora)
            => EstadoActual = (EstadoActual ?? EstadoAsignacionServicioFactory.ObtenerSegunFecha(Fecha, Hora, ahora))
                .ActualizarSegunFecha(Fecha, Hora, ahora);

        public void Cancelar()
            => EstadoActual = (EstadoActual ?? EstadoAsignacionServicioFactory.ObtenerSegunFecha(Fecha, Hora, DateTime.Now))
                .Cancelar();
    }
}
