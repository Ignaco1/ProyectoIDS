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
        private List<Cabaña> listaCabañasFiltro = new List<Cabaña>();
        public Form_realizarAlquiler()
        {
            InitializeComponent();
            btn_quitarFiltro.Enabled = false;
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
            txt_nombreFiltro.Clear();
            txt_capacidadFiltro.Clear();
            txt_precioNocheFiltro.Clear();
        }
        
        private void CargarCabañas(List<Cabaña> lista)
        {
            flp_cabañas.Controls.Clear();

            foreach (var cabaña in lista)
            {
                UC_Cabaña tarjeta = new UC_Cabaña();
                tarjeta.CabañaNombre = cabaña.Nombre;

                List<byte[]> imagenes = cabaña.Imagenes.Select(i => i.Imagen).ToList();

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
            CabañasFiltro();
            LIMPIAR();
        }

        private void btn_quitarFiltro_Click(object sender, EventArgs e)
        {
            ARMAR();         
        }

        private void CabañasFiltro()
        {
            string nombreFiltro = txt_nombreFiltro.Text.Trim().ToLower();
            bool filtrarCapacidad = int.TryParse(txt_capacidadFiltro.Text, out int capacidadFiltro);
            bool filtrarPrecio = decimal.TryParse(txt_precioNocheFiltro.Text, out decimal precioFiltro);

            DateTime fechaEntradaFiltro = dtp_entrada.Value.Date;
            DateTime fechaSalidaFiltro = dtp_salida.Value.Date;

            bool filtrarPorFechas = fechaEntradaFiltro <= fechaSalidaFiltro;


            listaCabañasFiltro = contro_caba.ListarCabañas()
                .Where(c =>
                    (string.IsNullOrEmpty(nombreFiltro) || c.Nombre.ToLower().Contains(nombreFiltro)) &&
                    (!filtrarCapacidad || c.Capacidad == capacidadFiltro) &&
                    (!filtrarPrecio || c.PrecioPorNoche == precioFiltro) &&
                )
                .ToList();

            var cabañasAmostrar = listaCabañasFiltro
            .Select(c => new
            {
                c.CabañaId,
                c.Nombre,
                c.Capacidad,
                c.PrecioPorNoche,
                c.Descripcion,
                c.Activa

            }).ToList();

            CargarCabañas(cabañasAmostrar);

        }
    }
}
