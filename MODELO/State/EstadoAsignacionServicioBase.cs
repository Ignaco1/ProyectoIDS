using System;

namespace MODELO.State
{
    public abstract class EstadoAsignacionServicioBase : IEstadoAsignacionServicio
    {
        public abstract string Nombre { get; }

        public virtual IEstadoAsignacionServicio ActualizarSegunFecha(DateTime fecha, TimeSpan hora, DateTime ahora)
            => EstadoAsignacionServicioFactory.ObtenerSegunFecha(fecha, hora, ahora);

        public virtual IEstadoAsignacionServicio Cancelar() => EstadoAsignacionCancelada.Instancia;
    }
}
