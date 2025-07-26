using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [Table("Clientes")]
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni {  get; set; }
        public string Email {  get; set; }
        public string Telefono { get; set; }

        public override string ToString()
        {
            return Nombre + " " + Apellido + " - " + " (DNI: " + Dni + ")";
        }

        public override bool Equals(object obj)
        {
            if (obj is Cliente otro)
                return this.ClienteId == otro.ClienteId;

            return false;
        }

        public override int GetHashCode()
        {
            return this.ClienteId.GetHashCode();
        }


    }
}
