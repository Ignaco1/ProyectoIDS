using Microsoft.EntityFrameworkCore;
using MODELO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Controladora_informes
    {
        private static Controladora_informes instancia;
        public static Controladora_informes Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora_informes();
                }
                return instancia;
            }
        }

        public Controladora_informes()
        {

        }

        public Dictionary<string, int> ObtenerMotivosCancelacion()
        {
            using (var context = new Context())
            {
                var motivos = context.MotivosCancelacion
                    .Include(m => m.Reservas)
                    .ToList();

                return motivos.ToDictionary(
                    m => m.Descripcion,
                    m => m.Reservas.Count);
            }
        }




    }
}
