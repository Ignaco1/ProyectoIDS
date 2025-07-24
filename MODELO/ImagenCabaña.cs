using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [Table("ImagenesCabaña")]
    public class ImagenCabaña
    {
        public int ImagenCabañaId { get; set; }
        public byte[] Imagen { get; set; }
        public int CabañaId { get; set; }

        [ForeignKey("CabañaId")]
        public virtual Cabaña Cabaña { get; set; }
    }
}
