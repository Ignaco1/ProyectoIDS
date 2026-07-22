using System;

namespace MODELO.State
{
    public sealed class EstadoAsignacionCancelada : EstadoAsignacionServicioBase
    {
        public static readonly EstadoAsignacionCancelada Instancia = new EstadoAsignacionCancelada();

        private EstadoAsignacionCancelada() { }

        public override string Nombre => "Cancelado";

        public override IEstadoAsignacionServicio ActualizarSegunFecha(DateTime fecha, TimeSpan hora, DateTime ahora)
            => this;

        public override IEstadoAsignacionServicio Cancelar() => this;
    }
}
