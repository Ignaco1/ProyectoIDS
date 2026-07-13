using MODELO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Controladora_Roles_Empleados
    {
        private static Controladora_Roles_Empleados instancia;
        public static Controladora_Roles_Empleados Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora_Roles_Empleados();
                }
                return instancia;
            }
        }

        public Controladora_Roles_Empleados()
        {

        }

        public ReadOnlyCollection<RolEmpleado> ListarRoles()
        {
            using (var context = new Context())
            {
                return context.RolesEmpleados.ToList().AsReadOnly();
            }
        }

        public ReadOnlyCollection<RolEmpleado> ListarRolesOperativos()
        {
            using (var context = new Context())
            {
                return context.RolesEmpleados
                    .Where(r => r.EsOperativo && r.Activo)
                    .ToList()
                    .AsReadOnly();
            }
        }

        public RolEmpleado ObtenerRolPorNombre(string nombre)
        {
            using (var context = new Context())
            {
                return context.RolesEmpleados.FirstOrDefault(r => r.Nombre == nombre);
            }
        }
    }
}
