using Microsoft.EntityFrameworkCore;
using MODELO;
using MODELO.Auditoria;
using System.Collections.ObjectModel;
using System.Linq;

namespace CONTROLADORA
{
    public class Controladora_auditoria
    {
        private static Controladora_auditoria instancia;
        public static Controladora_auditoria Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora_auditoria();
                }
                return instancia;
            }
        }

        public Controladora_auditoria()
        {

        }

        public ReadOnlyCollection<UsuarioAuditoria> ListarAuditoriaUsuarios()
        {
            using (var context = new Context())
            {
                return context.UsuariosAuditoria
                    .Include(a => a.Usuario).ThenInclude(u => u.Grupo)
                    .Include(a => a.Movimiento)
                    .OrderByDescending(a => a.FechaLogin)
                    .ToList()
                    .AsReadOnly();
            }
        }

        public ReadOnlyCollection<ClienteAuditoria> ListarAuditoriaClientes()
        {
            using (var context = new Context())
            {
                return context.ClientesAuditoria
                    .Include(a => a.Usuario)
                    .Include(a => a.Movimiento)
                    .OrderByDescending(a => a.FechaMovimiento)
                    .ToList()
                    .AsReadOnly();
            }
        }
    }
}
