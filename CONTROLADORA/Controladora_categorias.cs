using MODELO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Controladora_categorias
    {
        private static Controladora_categorias instancia;
        public static Controladora_categorias Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Controladora_categorias();
                }
                return instancia;
            }
        }

        public Controladora_categorias()
        {

        }

        public ReadOnlyCollection<Categoria> ListarCategorias()
        {
            using (var context = new Context())
            {
                return context.Categorias.ToList().AsReadOnly();
            }

        }
    }
}
