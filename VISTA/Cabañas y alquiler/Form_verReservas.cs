using CAPA_COMUN.Cache;
using MODELO;
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
        private List<Reserva> listaReservasFiltro = new List<Reserva>();
        private List<Reserva> reservasActuales = new List<Reserva>();
        private string variF = "";
        int indice;
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

            foreach (var cabaña in cabañas)
            {
                cb_cabaña.Items.Add(cabaña);
            }

            cb_estado.Items.Clear();
            cb_estado.Items.Add("Pendiente");
            cb_estado.Items.Add("Activa");
            cb_estado.Items.Add("Finalizada");
            cb_estado.SelectedIndex = -1;


            ActualizarEstadosReservas();

        }

        private void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;

            reservasActuales = contro_reser.ListarReservas().ToList();

            var reserva = contro_reser.ListarReservas()
                .Select(r => new
                {
                    r.ReservaId,
                    Cabaña = r.Cabaña?.Nombre ?? "Sin cabaña",
                    Cliente = r.Cliente?.Nombre + " " + r.Cliente?.Apellido?? "Sin cliente",
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
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una reserva.", "Error");
                return;
            }


            MODELO.Reserva reserva;

            if (variF == "F")
            {
                reserva = listaReservasFiltro[indice];
            }
            else
            {
                reserva = contro_reser.ListarReservas()[indice];
            }

            cb_cabaña.SelectedItem = reserva.Cabaña;
            cb_cliente.SelectedItem = reserva.Cliente;
            dtp_entrada.Value = reserva.FechaEntrada;
            dtp_salida.Value = reserva.FechaSalida;


            MODO_CARGA();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una reserva.", "Error");
                return;
            }

            MODELO.Reserva reserva;

            if (variF == "F")
            {
                reserva = listaReservasFiltro[indice];
            }
            else
            {
                reserva = contro_reser.ListarReservas()[indice];
            }

            DialogResult result = MessageBox.Show($"Está seguro que desea eliminar la reserva:\n\nCabaña: {reserva.Cabaña.Nombre}\n\nCliente: {reserva.Cliente.Nombre + " " + reserva.Cliente.Apellido}\n\nFecha de entrada: {reserva.FechaEntrada}\n\nFecha de salida: {reserva.FechaSalida}", "AVISO", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string respuesta = contro_reser.EliminarReserva(reserva);
                    MessageBox.Show(respuesta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la reserva:  " + ex.Message, "Error");
                    return;
                }
            }

            if (variF == "")
            {
                ARMA_GRILLA();
            }
            else
            {
                FILTRAR();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MODELO.Reserva reserva = null;

            #region VALIDACIONES

            Cabaña cabaña = cb_cabaña.SelectedItem as Cabaña;

            if (string.IsNullOrWhiteSpace(cb_cabaña.Text))
            {
                MessageBox.Show("Seleccione a una cabaña para realizar la reserva.", "Error");
                return;
            }

            Cliente cliente = cb_cliente.SelectedItem as Cliente;

            if (string.IsNullOrWhiteSpace(cb_cliente.Text))
            {
                MessageBox.Show("Seleccione a un cliente para realizar la reserva.", "Error");
                return;
            }

            DateTime fechaEntrada = dtp_entrada.Value.Date;
            DateTime fechaSalida = dtp_salida.Value.Date;

            if (fechaEntrada == fechaSalida)
            {
                MessageBox.Show("Debe seleccionar un rango de fechas para la reserva (entrada y salida).", "Error");
                return;
            }

            if (fechaEntrada > fechaSalida)
            {
                MessageBox.Show("La fecha de entrada no puede ser posterior a la de salida.", "Error");
                return;
            }

            #endregion

            if (variF == "F")
            {
                reserva = listaReservasFiltro[indice];
            }
            else
            {
                reserva = contro_reser.ListarReservas()[indice];
            }

            if (!contro_reser.ValidaReserva(cabaña, fechaEntrada, fechaSalida, reserva.ReservaId))
            {
                reserva.IdCabaña = cabaña.CabañaId;
                reserva.Cabaña = cabaña;
                reserva.IdCliente = cliente.ClienteId;
                reserva.Cliente= cliente;
                reserva.FechaEntrada = fechaEntrada;
                reserva.FechaSalida = fechaSalida;

                decimal precioTotal = ObtenerPrecioTotal(cabaña, fechaEntrada, fechaSalida);
                reserva.Precio = precioTotal;

                try
                {
                    string resultado = contro_reser.ModificarReserva(reserva);
                    MessageBox.Show(resultado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar la reserva:  " + ex.Message, "Error");
                    return;
                }

            }
            else
            {
                MessageBox.Show("La cabaña ya tiene reservas para esa fecha\n\nIntente con otras fechas", "AVISO");
                return;
            }

            if (variF == "")
            {
                ARMA_GRILLA();
            }
            else
            {
                FILTRAR();
            }
            MODO_LISTA();
            LIMPIAR();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MODO_LISTA();
            LIMPIAR();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            if (dtp_entradaFiltro.Value.Date > dtp_entradaFiltro.Value.Date)
            {
                MessageBox.Show("La fecha de entrada no puede ser posterior a la fecha de salida.", "Error");
                return;
            }

            variF = "F";

            FILTRAR();
            btn_quitarFiltro.Enabled = true;
        }

        private void btn_quitarFiltro_Click(object sender, EventArgs e)
        {
            cb_estado.SelectedIndex = -1;
            txt_nombreCabañaFiltro.Clear();
            txt_nombreClienteFiltro.Clear();
            dtp_entradaFiltro.Value = DateTime.Today;
            dtp_salidaFiltro.Value = DateTime.Today;

            ARMA_GRILLA();

            btn_quitarFiltro.Enabled = false;

            variF = "";
        }

        private void FILTRAR()
        {
            dataGridView1.DataSource = null;

            var reservas = contro_reser.ListarReservas();

            string nombreCabañaFiltro = txt_nombreCabañaFiltro.Text.Trim().ToLower();
            string nombreClienteFiltro = txt_nombreClienteFiltro.Text.Trim().ToLower();
            string estadoFiltro = cb_estado.Text;

            DateTime fechaEntradaFiltro = dtp_entradaFiltro.Value.Date;
            DateTime fechaSalidaFiltro = dtp_salidaFiltro.Value.Date;

            bool filtrarPorFechas = fechaEntradaFiltro <= fechaSalidaFiltro;


            listaReservasFiltro = reservas
            .Where(r =>
                (string.IsNullOrEmpty(nombreCabañaFiltro) || r.Cabaña.Nombre.ToLower().Contains(nombreCabañaFiltro)) &&
                (string.IsNullOrEmpty(nombreClienteFiltro) || (r.Cliente.Nombre + " " + r.Cliente.Apellido).ToLower().Contains(nombreClienteFiltro)) &&
                (string.IsNullOrEmpty(estadoFiltro) || r.Estado.Equals(estadoFiltro, StringComparison.OrdinalIgnoreCase)) &&
                (!filtrarPorFechas || (r.FechaEntrada <= fechaSalidaFiltro && r.FechaSalida >= fechaEntradaFiltro))
            )
            .ToList();

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = listaReservasFiltro
            .Select(r => new
            {
                r.ReservaId,
                Cabaña = r.Cabaña.Nombre,
                Cliente = r.Cliente.Nombre + " " + r.Cliente.Apellido,
                Fecha_de_entrada = r.FechaEntrada,
                Fecha_de_salida = r.FechaSalida,
                r.Precio,
                r.Estado
            }).ToList();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Seleccione una reserva.", "Error");
                return;
            }

            indice = dataGridView1.CurrentRow.Index;
        }

        private decimal ObtenerPrecioTotal(Cabaña cabaña, DateTime fecha_entrada, DateTime fecha_salida)
        {
            int cantidadNoches = (fecha_salida - fecha_entrada).Days + 1;

            if (cantidadNoches <= 0)
                return 0;

            return cantidadNoches * cabaña.PrecioPorNoche;
        }

        private void ActualizarEstadosReservas()
        {
            var reservas = contro_reser.ListarReservas();

            bool huboCambios = false;

            foreach (var reserva in reservas)
            {
                var hoy = DateTime.Today;
                string nuevoEstado = reserva.Estado;

                if (hoy >= reserva.FechaEntrada && hoy <= reserva.FechaSalida)
                {
                    nuevoEstado = "Activa";
                }
                else if (hoy > reserva.FechaSalida)
                {
                    nuevoEstado = "Finalizada";
                }

                if (nuevoEstado != reserva.Estado)
                {
                    reserva.Estado = nuevoEstado;
                    contro_reser.ModificarReserva(reserva);
                    huboCambios = true;
                }
            }

            if (huboCambios)
            {
                ARMA_GRILLA();
            }
        }
    }
}
