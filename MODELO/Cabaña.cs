using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [Table("Cabañas")]
    public class Cabaña
    {
        public int CabañaId {  get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public decimal PrecioPorNoche { get; set; }
        public string Descripcion { get; set; }
        public bool Activa { get; set; }
        public DateTime? FechaFinDesactivacion { get; set; }

        public virtual ICollection<ImagenCabaña> Imagenes { get; set; } = new List<ImagenCabaña>();

        public override string ToString()
        {
            return Nombre;
        }

        public override bool Equals(object obj)
        {
            if (obj is Cabaña otra)
                return this.CabañaId == otra.CabañaId;

            return false;
        }

        public override int GetHashCode()
        {
            return this.CabañaId.GetHashCode();
        }

    }
}
