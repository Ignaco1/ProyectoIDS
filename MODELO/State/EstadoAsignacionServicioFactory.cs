using System;
using System.Collections.Generic;

namespace MODELO.State
{
    public static class EstadoAsignacionServicioFactory
    {
        private static readonly Dictionary<string, IEstadoAsignacionServicio> _porNombre =
            new Dictionary<string, IEstadoAsignacionServicio>(StringComparer.OrdinalIgnoreCase)
            {
                [EstadoAsignacionPendiente.Instancia.Nombre] = EstadoAsignacionPendiente.Instancia,
                [EstadoAsignacionActiva.Instancia.Nombre] = EstadoAsignacionActiva.Instancia,
                [EstadoAsignacionFinalizada.Instancia.Nombre] = EstadoAsignacionFinalizada.Instancia,
                [EstadoAsignacionCancelada.Instancia.Nombre] = EstadoAsignacionCancelada.Instancia,
            };

        public static IEstadoAsignacionServicio? Crear(string? nombre)
            => nombre != null && _porNombre.TryGetValue(nombre, out var estado) ? estado : null;

        public static IEstadoAsignacionServicio ObtenerSegunFecha(DateTime fecha, TimeSpan hora, DateTime ahora)
        {
            DateTime fechaHora = fecha.Date + hora;

            if (ahora < fechaHora) return EstadoAsignacionPendiente.Instancia;
            if (fecha.Date == ahora.Date) return EstadoAsignacionActiva.Instancia;
            return EstadoAsignacionFinalizada.Instancia;
        }
    }
}
