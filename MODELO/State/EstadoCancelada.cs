using System;

namespace MODELO.State
{
    public sealed class EstadoCancelada : EstadoReservaBase
    {
        public static readonly EstadoCancelada Instancia = new EstadoCancelada();

        private EstadoCancelada() { }

        public override string Nombre => "Cancelada";

        public override IEstadoReserva ActualizarSegunFecha(DateTime fechaEntrada, DateTime fechaSalida, DateTime hoy)
            => this;

        public override IEstadoReserva Cancelar() => this;
    }
}
