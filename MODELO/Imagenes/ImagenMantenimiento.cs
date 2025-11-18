using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Imagenes
{
    [Table("ImagenesMantenimiento")]
    public class ImagenMantenimiento
    {
        public int ImagenMantenimientoId { get; set; }
        public byte[] Imagen { get; set; }
        public int MantenimientoId { get; set; }

        [ForeignKey("MantenimientoId")]
        public virtual Mantenimiento Mantenimiento { get; set; }
    }
}
