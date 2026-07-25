using System;
using CAPA_COMUN.State;

namespace MODELO.State
{
    public interface IEstadoAsignacionMantenimiento : IEstado<AsignacionMantenimiento>
    {
        IEstadoAsignacionMantenimiento ActualizarSegunFecha(DateTime fechaInicio, DateTime fechaFin, DateTime ahora);
        IEstadoAsignacionMantenimiento Cancelar();
    }
}
