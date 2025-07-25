using MODELO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.Cabañas_y_alquiler
{
    public partial class Form_realizarAlquiler : Form
    {
        CONTROLADORA.Controladora_cabañas contro_caba = new CONTROLADORA.Controladora_cabañas();
        public Form_realizarAlquiler()
        {
            InitializeComponent();
        }

        private void Form_realizarAlquiler_Load(object sender, EventArgs e)
        {
            ARMAR();
        }

        private void ARMAR()
        {
            var todasLasCabañas = contro_caba.ListarCabañas().ToList();
            CargarCabañas(todasLasCabañas);
        }

        private void LIMPIAR()
        {

        }
        
        private void CargarCabañas(List<Cabaña> lista)
        {
            flp_cabañas.Controls.Clear();

            foreach (var cabaña in lista)
            {
                UC_Cabaña tarjeta = new UC_Cabaña();
                tarjeta.CabañaNombre = cabaña.Nombre;

                List<byte[]> imagenes = cabaña.Imagenes.Select(i => i.Imagen).ToList();

                //if (imagenes.Count == 0)
                //{
                //    imagenes.Add(Properties.Resources.imagen_defecto); 
                //}

                tarjeta.Configurar(cabaña.Nombre, cabaña.Capacidad, cabaña.PrecioPorNoche, cabaña.Descripcion, imagenes);

                flp_cabañas.Controls.Add(tarjeta);
            }
        }
        
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {

        }

        private void btn_quitarFiltro_Click(object sender, EventArgs e)
        {
            ARMAR();
            
        }
    }
}
