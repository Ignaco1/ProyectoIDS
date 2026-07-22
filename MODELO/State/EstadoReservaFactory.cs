using System;
using System.Collections.Generic;

namespace MODELO.State
{
    public static class EstadoReservaFactory
    {
        private static readonly Dictionary<string, IEstadoReserva> _porNombre =
            new Dictionary<string, IEstadoReserva>(StringComparer.OrdinalIgnoreCase)
            {
                [EstadoPendiente.Instancia.Nombre] = EstadoPendiente.Instancia,
                [EstadoActiva.Instancia.Nombre] = EstadoActiva.Instancia,
                [EstadoFinalizada.Instancia.Nombre] = EstadoFinalizada.Instancia,
                [EstadoCancelada.Instancia.Nombre] = EstadoCancelada.Instancia,
            };

        public static IEstadoReserva? Crear(string? nombre)
            => nombre != null && _porNombre.TryGetValue(nombre, out var estado) ? estado : null;

        public static IEstadoReserva ObtenerSegunFecha(DateTime fechaEntrada, DateTime fechaSalida, DateTime hoy)
        {
            if (hoy < fechaEntrada) return EstadoPendiente.Instancia;
            if (hoy <= fechaSalida) return EstadoActiva.Instancia;
            return EstadoFinalizada.Instancia;
        }
    }
}
