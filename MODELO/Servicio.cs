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
        public decimal Importe { get; set; }
        public bool Activo { get; set; }

        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }
    }
}
