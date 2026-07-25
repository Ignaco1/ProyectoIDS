using System;

namespace MODELO.State
{
    public sealed class EstadoAsignacionMantenimientoCancelada : EstadoAsignacionMantenimientoBase
    {
        public static readonly EstadoAsignacionMantenimientoCancelada Instancia = new EstadoAsignacionMantenimientoCancelada();

        private EstadoAsignacionMantenimientoCancelada() { }

        public override string Nombre => "Cancelado";

        public override IEstadoAsignacionMantenimiento ActualizarSegunFecha(DateTime fechaInicio, DateTime fechaFin, DateTime ahora)
            => this;

        public override IEstadoAsignacionMantenimiento Cancelar() => this;
    }
}
