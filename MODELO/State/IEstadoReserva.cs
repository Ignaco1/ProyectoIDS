using System;
using CAPA_COMUN.State;

namespace MODELO.State
{
    public interface IEstadoReserva : IEstado<Reserva>
    {
        IEstadoReserva ActualizarSegunFecha(DateTime fechaEntrada, DateTime fechaSalida, DateTime hoy);
        IEstadoReserva Cancelar();
    }
}
