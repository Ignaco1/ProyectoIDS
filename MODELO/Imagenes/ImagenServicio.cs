using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Imagenes
{
    [Table("ImagenesServicio")]
    public class ImagenServicio
    {
        public int ImagenServicioId { get; set; }
        public byte[] Imagen { get; set; }
        public int ServicioId { get; set; }

        [ForeignKey("ServicioId")]
        public virtual Servicio Servicio { get; set; }
    }
}
