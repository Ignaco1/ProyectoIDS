using MODELO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Controladora_motivos
    {
        private static Controladora_motivos instancia;
        //private Context contextClientes;
        public static Controladora_motivos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora_motivos();
                }
                return instancia;
            }
        }

        public Controladora_motivos()
        {

        }

        public ReadOnlyCollection<MotivoCancelacion> ListarMotivos()
        {
            using (var context = new Context())
            {
                return context.MotivosCancelacion.ToList().AsReadOnly();
            }

        }
    }
}
