using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [Table("MotivosCancelacion")]
    public class MotivoCancelacion
    {
        public int MotivoCancelacionId { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Reserva> Reservas { get; set; }
    }
}
