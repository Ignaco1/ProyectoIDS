using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Auditoria
{
    [Table("UsuariosAuditoria")]
    public class UsuarioAuditoria
    {
        public int UsuarioAuditoriaId { get; set; }
        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime FechaLogin { get; set; }
        public DateTime? FechaLogout { get; set; }
        public int? IdMovimiento { get; set; }
        
        [ForeignKey("IdMovimiento")]
        public Movimiento Movimiento { get; set; }
        public String TipoMovimiento { get; set; }

    }
}
