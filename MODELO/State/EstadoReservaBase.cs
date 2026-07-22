using System;

namespace MODELO.State
{
    public abstract class EstadoReservaBase : IEstadoReserva
    {
        public abstract string Nombre { get; }

        public virtual IEstadoReserva ActualizarSegunFecha(DateTime fechaEntrada, DateTime fechaSalida, DateTime hoy)
            => EstadoReservaFactory.ObtenerSegunFecha(fechaEntrada, fechaSalida, hoy);

        public virtual IEstadoReserva Cancelar() => EstadoCancelada.Instancia;
    }
}
