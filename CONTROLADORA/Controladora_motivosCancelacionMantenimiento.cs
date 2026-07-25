using MODELO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CONTROLADORA
{
    public class Controladora_motivosCancelacionMantenimiento
    {
        private static Controladora_motivosCancelacionMantenimiento instancia;
        public static Controladora_motivosCancelacionMantenimiento Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora_motivosCancelacionMantenimiento();
                }
                return instancia;
            }
        }

        public Controladora_motivosCancelacionMantenimiento()
        {

        }

        public ReadOnlyCollection<MotivoCancelacionMantenimiento> ListarMotivos()
        {
            using (var context = new Context())
            {
                return context.MotivosCancelacionMantenimiento.ToList().AsReadOnly();
            }
        }
    }
}
