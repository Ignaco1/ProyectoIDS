using System;
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
    public partial class Form_verReservas : Form
    {
        CONTROLADORA.Controladora_reservas contro_reser = new CONTROLADORA.Controladora_reservas();
        CONTROLADORA.Controladora_clientes contro_cli = new CONTROLADORA.Controladora_clientes();
        CONTROLADORA.Controladora_cabañas contro_caba = new CONTROLADORA.Controladora_cabañas();
        public Form_verReservas()
        {
            InitializeComponent();
            ARMA_GRILLA();
            MODO_LISTA();
            btn_quitarFiltro.Enabled = false;
        }

        private void Form_verReservas_Load(object sender, EventArgs e)
        {
            var clientes = contro_cli.ListarClientes();

            foreach (var cliente in clientes)
            {
                cb_cliente.Items.Add(cliente);
            }

            var cabañas = contro_caba.ListarCabañas();

            foreach (var cabaña in clientes)
            {
                cb_cabaña.Items.Add(cabaña);
            }
        }

        private void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;

            var reserva = contro_reser.ListarReservas()
                .Select(r => new
                {
                    r.ReservaId,
                    Cabaña = r.Cabaña?.Nombre ?? "Sin cabaña",
                    Cliente = r.Cliente?.Nombre ?? "Sin cliente",
                    Fecha_de_entrada = r.FechaEntrada,
                    Fecha_de_salida = r.FechaSalida,
                    r.Precio,
                    r.Estado

                }).ToList();

            dataGridView1.DataSource = reserva;
        }

        private void MODO_LISTA()
        {
            gb_carga.Enabled = false;
            gb_grilla.Enabled = true;
        }

        private void MODO_CARGA()
        {
            gb_carga.Enabled = true;
            gb_grilla.Enabled = false;
        }

        private void LIMPIAR()
        {
            cb_cabaña.SelectedIndex = -1;
            cb_cliente.SelectedIndex = -1;

            dtp_entrada.Value = DateTime.Today;
            dtp_salida.Value = DateTime.Today;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {

        }

        private void btn_quitarFiltro_Click(object sender, EventArgs e)
        {

        }
    }
}
