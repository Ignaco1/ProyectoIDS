using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [Table("Servicios")]
    public class Servicio
    {
        public int ServicioId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Importe { get; set; }
        public bool Activo { get; set; }
        public virtual ICollection<ImagenServicio> Imagenes { get; set; } = new List<ImagenServicio>();

        public virtual ICollection<Categoria> Categorias { get; set; }
    }
}
