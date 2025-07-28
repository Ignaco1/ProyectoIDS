using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MODELO
{
    [Table("MotivosCancelacion")]
    public class MotivoCancelacion
    {
        public int MotivoCancelacionId { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Reserva> Reservas { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
