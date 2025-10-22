using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Auditoria
{
    [Table("Movimientos")]
    public class Movimiento
    {
        public int MovimientoId { get; set; }
        public string NombreMovimiento { get; set; }  
    }
}
