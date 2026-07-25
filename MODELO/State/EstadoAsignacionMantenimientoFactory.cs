using System;
using System.Collections.Generic;

namespace MODELO.State
{
    public static class EstadoAsignacionMantenimientoFactory
    {
        private static readonly Dictionary<string, IEstadoAsignacionMantenimiento> _porNombre =
            new Dictionary<string, IEstadoAsignacionMantenimiento>(StringComparer.OrdinalIgnoreCase)
            {
                [EstadoAsignacionMantenimientoPendiente.Instancia.Nombre] = EstadoAsignacionMantenimientoPendiente.Instancia,
                [EstadoAsignacionMantenimientoActiva.Instancia.Nombre] = EstadoAsignacionMantenimientoActiva.Instancia,
                [EstadoAsignacionMantenimientoFinalizada.Instancia.Nombre] = EstadoAsignacionMantenimientoFinalizada.Instancia,
                [EstadoAsignacionMantenimientoCancelada.Instancia.Nombre] = EstadoAsignacionMantenimientoCancelada.Instancia,
            };

        public static IEstadoAsignacionMantenimiento? Crear(string? nombre)
            => nombre != null && _porNombre.TryGetValue(nombre, out var estado) ? estado : null;

        public static IEstadoAsignacionMantenimiento ObtenerSegunFecha(DateTime fechaInicio, DateTime fechaFin, DateTime ahora)
        {
            if (ahora.Date < fechaInicio.Date) return EstadoAsignacionMantenimientoPendiente.Instancia;
            if (ahora.Date <= fechaFin.Date) return EstadoAsignacionMantenimientoActiva.Instancia;
            return EstadoAsignacionMantenimientoFinalizada.Instancia;
        }
    }
}
