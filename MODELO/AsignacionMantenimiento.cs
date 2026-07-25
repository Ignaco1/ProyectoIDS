using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using MODELO.State;

namespace MODELO
{
    [Table("AsignacionesMantenimiento")]
    public class AsignacionMantenimiento
    {
        public int AsignacionMantenimientoId { get; set; }
        public int MantenimientoId { get; set; }
        public int CabañaId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Costo { get; set; }
        public bool DesactivaCabaña { get; set; }

        [NotMapped]
        public IEstadoAsignacionMantenimiento? EstadoActual { get; private set; }

        public string? Estado
        {
            get => EstadoActual?.Nombre;
            set => EstadoActual = EstadoAsignacionMantenimientoFactory.Crear(value);
        }

        [ForeignKey("MantenimientoId")]
        public virtual Mantenimiento Mantenimiento { get; set; }

        [ForeignKey("CabañaId")]
        public virtual Cabaña Cabaña { get; set; }

        [ForeignKey("EmpleadoId")]
        public virtual Empleado Empleado { get; set; }

        public ICollection<MotivoCancelacionMantenimiento> MotivosCancelacion { get; set; } = new List<MotivoCancelacionMantenimiento>();

        public void ActualizarEstadoSegunFecha(DateTime ahora)
            => EstadoActual = (EstadoActual ?? EstadoAsignacionMantenimientoFactory.ObtenerSegunFecha(FechaInicio, FechaFin, ahora))
                .ActualizarSegunFecha(FechaInicio, FechaFin, ahora);

        public void Cancelar()
            => EstadoActual = (EstadoActual ?? EstadoAsignacionMantenimientoFactory.ObtenerSegunFecha(FechaInicio, FechaFin, DateTime.Now))
                .Cancelar();
    }
}
