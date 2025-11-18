using MODELO.Imagenes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [Table("Mantenimientos")]
    public class Mantenimiento
    {
        public int MantenimientoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<ImagenMantenimiento> Imagenes { get; set; } = new List<ImagenMantenimiento>();
    }
}
