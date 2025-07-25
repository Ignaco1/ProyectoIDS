using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [Table("Reservas")]
    public class Reserva
    {
        public int ReservaId { get; set; }
        public int IdCliente { get; set; }
        public int IdCabaña { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public virtual Cabaña Cabaña { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
