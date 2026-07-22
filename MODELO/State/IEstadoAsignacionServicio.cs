using System;
using CAPA_COMUN.State;

namespace MODELO.State
{
    public interface IEstadoAsignacionServicio : IEstado<AsignacionServicio>
    {
        IEstadoAsignacionServicio ActualizarSegunFecha(DateTime fecha, TimeSpan hora, DateTime ahora);
        IEstadoAsignacionServicio Cancelar();
    }
}
