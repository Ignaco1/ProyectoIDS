using MODELO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Controladora_motivosCancelacionServicios
    {
        private static Controladora_motivosCancelacionServicios instancia;
        public static Controladora_motivosCancelacionServicios Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora_motivosCancelacionServicios();
                }
                return instancia;
            }
        }

        public Controladora_motivosCancelacionServicios()
        {

        }

        public ReadOnlyCollection<MotivoCancelacionServicio> ListarMotivos()
        {
            using (var context = new Context())
            {
                return context.MotivosCancelacionServicio.ToList().AsReadOnly();
            }

        }
    }
}
