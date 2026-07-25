using System;

namespace MODELO.State
{
    public abstract class EstadoAsignacionMantenimientoBase : IEstadoAsignacionMantenimiento
    {
        public abstract string Nombre { get; }

        public virtual IEstadoAsignacionMantenimiento ActualizarSegunFecha(DateTime fechaInicio, DateTime fechaFin, DateTime ahora)
            => EstadoAsignacionMantenimientoFactory.ObtenerSegunFecha(fechaInicio, fechaFin, ahora);

        public virtual IEstadoAsignacionMantenimiento Cancelar() => EstadoAsignacionMantenimientoCancelada.Instancia;
    }
}
