using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Auditoria
{
    [Table("ClientesAuditoria")]
    public class ClienteAuditoria
    {
        public int ClienteAuditoriaId { get; set; }
        public int IdCliente { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; } 

        public DateTime FechaMovimiento { get; set; }
        public int IdMovimiento { get; set; }

        [ForeignKey("IdMovimiento")]
        public Movimiento Movimiento { get; set; }
        public String TipoMovimiento { get; set; }
    }
}
