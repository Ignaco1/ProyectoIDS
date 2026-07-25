using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [Table("RolesEmpleados")]
    public class RolEmpleado
    {
        public int RolEmpleadoId { get; set; }
        public string Nombre { get; set; }
        public bool EsOperativo { get; set; }
        public bool EsMantenimiento { get; set; }
        public bool Activo { get; set; } = true;

        public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

        public override string ToString() => Nombre;   
    }
}
