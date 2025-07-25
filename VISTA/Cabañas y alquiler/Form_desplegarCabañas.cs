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
    public partial class Form_desplegarCabañas : Form
    {
        CONTROLADORA.Controladora_cabañas contro_caba = new CONTROLADORA.Controladora_cabañas();
        CONTROLADORA.Controladora_reservas contro_reser = new CONTROLADORA.Controladora_reservas();
        private List<Cabaña> listaCabañasFiltro = new List<Cabaña>();
        public Form_desplegarCabañas()
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
            var todasLasCabañas = contro_caba.ListarCabañas().Where(c => c.Activa).ToList();
            CargarCabañas(todasLasCabañas);
        }

        private void LIMPIAR()
        {
            txt_nombreFiltro.Clear();
            txt_capacidadFiltro.Clear();
            txt_precioNocheFiltro.Clear();

            dtp_entrada.Value = DateTime.Today;
            dtp_salida.Value = DateTime.Today;
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
            if (dtp_entrada.Value.Date > dtp_salida.Value.Date)
            {
                MessageBox.Show("La fecha de entrada no puede ser posterior a la fecha de salida.", "Error");
                return;
            }
            
            CabañasFiltro();
        }

        private void btn_quitarFiltro_Click(object sender, EventArgs e)
        {
            ARMAR();
            LIMPIAR();
        }

        private void CabañasFiltro()
        {
            string nombreFiltro = txt_nombreFiltro.Text.Trim().ToLower();
            bool filtrarCapacidad = int.TryParse(txt_capacidadFiltro.Text, out int capacidadFiltro);
            bool filtrarPrecio = decimal.TryParse(txt_precioNocheFiltro.Text, out decimal precioFiltro);

            DateTime fechaEntradaFiltro = dtp_entrada.Value.Date;
            DateTime fechaSalidaFiltro = dtp_salida.Value.Date;

            bool filtrarPorFechas = fechaEntradaFiltro <= fechaSalidaFiltro;

            var reservas = contro_reser.ListarReservas();

            listaCabañasFiltro = contro_caba.ListarCabañas()
                .Where(c =>
                    c.Activa &&
                    (string.IsNullOrEmpty(nombreFiltro) || c.Nombre.ToLower().Contains(nombreFiltro)) &&
                    (!filtrarCapacidad || c.Capacidad == capacidadFiltro) &&
                    (!filtrarPrecio || c.PrecioPorNoche == precioFiltro) && 
                    (!filtrarPorFechas || !reservas.Any(r =>r.IdCabaña == c.CabañaId && fechaEntradaFiltro <= r.FechaSalida && fechaSalidaFiltro >= r.FechaEntrada))
                ).ToList();

            CargarCabañas(listaCabañasFiltro);

        }
    }
}
