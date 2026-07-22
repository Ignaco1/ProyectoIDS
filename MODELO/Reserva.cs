using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO.State;

namespace MODELO
{
    [Table("Reservas")]
    public class Reserva
    {
        public int ReservaId { get; set; }
        public int IdCliente { get; set; }
        public int IdCabaña { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public decimal Precio {  get; set; }

        [NotMapped]
        public IEstadoReserva? EstadoActual { get; private set; }

        public string? Estado
        {
            get => EstadoActual?.Nombre;
            set => EstadoActual = EstadoReservaFactory.Crear(value);
        }

        [ForeignKey("IdCabaña")]
        public virtual Cabaña Cabaña { get; set; }
        [ForeignKey("IdCliente")]
        public virtual Cliente Cliente { get; set; }

        public ICollection<MotivoCancelacion> MotivosCancelacion { get; set; }

        public void ActualizarEstadoSegunFecha(DateTime hoy)
            => EstadoActual = (EstadoActual ?? EstadoReservaFactory.ObtenerSegunFecha(FechaEntrada, FechaSalida, hoy))
                .ActualizarSegunFecha(FechaEntrada, FechaSalida, hoy);

        public void Cancelar()
            => EstadoActual = (EstadoActual ?? EstadoReservaFactory.ObtenerSegunFecha(FechaEntrada, FechaSalida, DateTime.Today))
                .Cancelar();

        public override string ToString()
        {
            return $"Reserva #{ReservaId} - {Cliente?.Nombre} {Cliente?.Apellido} - {Cabaña?.Nombre}";
        }
    }
}
