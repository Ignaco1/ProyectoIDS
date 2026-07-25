using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MODELO
{
    [Table("MotivosCancelacionMantenimiento")]
    public class MotivoCancelacionMantenimiento
    {
        public int MotivoCancelacionMantenimientoId { get; set; }
        public string Descripcion { get; set; }

        public ICollection<AsignacionMantenimiento> AsignacionesMantenimiento { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
