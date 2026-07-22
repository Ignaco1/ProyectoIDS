using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [Table("MotivosCancelacionServicio")]
    public class MotivoCancelacionServicio
    {
        public int MotivoCancelacionServicioId { get; set; }
        public string Descripcion { get; set; }

        public ICollection<AsignacionServicio> AsignacionesServicio { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
