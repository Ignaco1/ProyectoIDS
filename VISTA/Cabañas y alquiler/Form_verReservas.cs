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
        private string variF = "";
        public Form_verReservas()
        {
            InitializeComponent();
            ARMA_GRILLA();
            MODO_LISTA();
            btn_quitarFiltro.Enabled = false;
            cb_cliente.Enabled = false;
        }

        private void Form_verReservas_Load(object sender, EventArgs e)
        {
            var clientes = contro_cli.ListarClientes();

            foreach (var cliente in clientes)
            {
                cb_cliente.Items.Add(cliente);
            }

            cb_cabaña.Items.Clear();

            var cabañasActivas = contro_caba.ListarCabañas().Where(c => c.Activa).ToList();

            foreach (var cabaña in cabañasActivas)
            {
                cb_cabaña.Items.Add(cabaña);
            }

            cb_estado.Items.Clear();
            cb_estado.Items.AddRange(new string[] { "Pendiente", "Activa", "Finalizada" });
            cb_estado.SelectedIndex = -1;


            dtp_entradaFiltro.Value = DateTime.Today;
            dtp_salidaFiltro.Value = DateTime.Today;

            contro_reser.ActualizarEstadosReservas();

        }

        private void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;

            var reserva = contro_reser.ListarReservas().Where(r => r.Estado != "Cancelada")
                .Select(r => new
                {
                    r.ReservaId,
                    Cabaña = r.Cabaña?.Nombre ?? "Sin cabaña",
                    Cliente = r.Cliente?.Nombre + " " + r.Cliente?.Apellido ?? "Sin cliente",
                    Fecha_de_entrada = r.FechaEntrada,
                    Fecha_de_salida = r.FechaSalida,
                    Precio = r.Precio.ToString("C2"),
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

            mc_reservas.SelectionStart = DateTime.Today;
            mc_reservas.SelectionEnd = DateTime.Today;
            mc_reservas.BoldedDates = Array.Empty<DateTime>();
            mc_reservas.UpdateBoldedDates();
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

            reserva = ObtenerReservaSeleccionada();

            cb_cabaña.SelectedItem = reserva.Cabaña;
            cb_cliente.SelectedItem = reserva.Cliente;

            MarcarFechasOcupadas(reserva.Cabaña);

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

            reserva = ObtenerReservaSeleccionada();

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

            DateTime fechaEntrada = mc_reservas.SelectionStart.Date;
            DateTime fechaSalida = mc_reservas.SelectionEnd.Date;

            if (mc_reservas.SelectionStart == mc_reservas.SelectionEnd)
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

            reserva = ObtenerReservaSeleccionada();

            if (contro_reser.ValidaReserva(cabaña, fechaEntrada, fechaSalida, reserva.ReservaId))
            {
                reserva.IdCabaña = cabaña.CabañaId;
                reserva.Cabaña = cabaña;
                reserva.IdCliente = cliente.ClienteId;
                reserva.Cliente = cliente;
                reserva.FechaEntrada = fechaEntrada;
                reserva.FechaSalida = fechaSalida;

                decimal precioTotal = ObtenerPrecioTotal(cabaña, fechaEntrada, fechaSalida);
                reserva.Precio = precioTotal;

                try
                {
                    string resultado = contro_reser.ModificarReserva(reserva);
                    contro_reser.ActualizarEstadosReservas();
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
            LIMPIAR();
            MODO_LISTA();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            MODO_LISTA();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            if (dtp_entradaFiltro.Value.Date > dtp_salidaFiltro.Value.Date)
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

            string nombreCabañaFiltro = txt_nombreCabañaFiltro.Text.Trim().ToLower();
            string nombreClienteFiltro = txt_nombreClienteFiltro.Text.Trim().ToLower();
            string estadoFiltro = cb_estado.Text.Trim();

            DateTime fechaEntradaFiltro = dtp_entradaFiltro.Value.Date;
            DateTime fechaSalidaFiltro = dtp_salidaFiltro.Value.Date;

            bool filtrarPorFechas = fechaEntradaFiltro != fechaSalidaFiltro;

            var reservas = contro_reser.ListarReservas();

            listaReservasFiltro = reservas
            .Where(r =>
                r.Estado != "Cancelada" &&
                (string.IsNullOrEmpty(nombreCabañaFiltro) || r.Cabaña.Nombre.ToLower().Contains(nombreCabañaFiltro)) &&
                (string.IsNullOrEmpty(nombreClienteFiltro) || r.Cliente.Nombre.ToLower().Contains(nombreClienteFiltro) ||
                r.Cliente.Apellido.ToLower().Contains(nombreClienteFiltro)) &&
                (string.IsNullOrEmpty(estadoFiltro) || r.Estado.Equals(estadoFiltro, StringComparison.OrdinalIgnoreCase)) &&
                (!filtrarPorFechas || (r.FechaEntrada >= fechaEntradaFiltro && r.FechaSalida <= fechaSalidaFiltro))
            )
            .ToList();

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = listaReservasFiltro
            .Select(r => new
            {
                r.ReservaId,
                Cabaña = r.Cabaña.Nombre,
                Cliente = r.Cliente.Nombre + " " + r.Cliente.Apellido,
                Fecha_de_entrada = r.FechaEntrada.ToShortDateString(),
                Fecha_de_salida = r.FechaSalida.ToShortDateString(),
                Precio = r.Precio.ToString("C2"),
                r.Estado

            }).ToList();

        }

        private decimal ObtenerPrecioTotal(Cabaña cabaña, DateTime fecha_entrada, DateTime fecha_salida)
        {
            int cantidadNoches = (fecha_salida - fecha_entrada).Days + 1;

            if (cantidadNoches <= 0)
                return 0;

            return cantidadNoches * cabaña.PrecioPorNoche;
        }

        private void MarcarFechasOcupadas(Cabaña cabaña)
        {
            mc_reservas.RemoveAllBoldedDates();

            if (cabaña == null)
                return;

            var reservas = contro_reser.ListarReservas()
            .Where(r => r.IdCabaña == cabaña.CabañaId && r.Estado != "Cancelada")
            .ToList();

            foreach (var reserva in reservas)
            {
                DateTime fecha = reserva.FechaEntrada.Date;
                while (fecha <= reserva.FechaSalida.Date)
                {
                    mc_reservas.AddBoldedDate(fecha);
                    fecha = fecha.AddDays(1);
                }
            }

            if (!cabaña.Activa)
            {
                DateTime hoy = DateTime.Today;
                DateTime fin = hoy.AddMonths(1);

                for (DateTime fecha = hoy; fecha <= fin; fecha = fecha.AddDays(1))
                {
                    mc_reservas.AddBoldedDate(fecha);
                }
            }

            mc_reservas.UpdateBoldedDates();
        }

        private void cb_cabaña_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cabaña cabañaSeleccionada = cb_cabaña.SelectedItem as Cabaña;

            if (cabañaSeleccionada != null)
            {
                MarcarFechasOcupadas(cabañaSeleccionada);
            }
        }

        private void btn_cancelarReserva_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una reserva.", "Error");
                return;
            }

            MODELO.Reserva reserva;
            MODELO.Cabaña cabaña;

            reserva = ObtenerReservaSeleccionada();

            Reserva reservaSeleccionada = contro_reser.ObtenerReservaId(reserva.ReservaId);

            DialogResult result = MessageBox.Show($"Está seguro que desea cancelar la reserva:\n\nCabaña: {reservaSeleccionada.Cabaña.Nombre}\n\nCliente: {reservaSeleccionada.Cliente.Nombre + " " + reservaSeleccionada.Cliente.Apellido}\n\nFecha de entrada: {reservaSeleccionada.FechaEntrada}\n\nFecha de salida: {reservaSeleccionada.FechaSalida}", "AVISO", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    reservaSeleccionada.Estado = "Cancelada";

                    contro_reser.ModificarReserva(reservaSeleccionada);

                    cabaña = contro_caba.ObtenerCabañaId(reservaSeleccionada.IdCabaña);

                    if (cabaña != null && cabaña.Activa)
                    {
                        //DateTime fecha = reservaSeleccionada.FechaEntrada.Date;
                        //while (fecha <= reservaSeleccionada.FechaSalida.Date)
                        //{
                        //    mc_reservas.RemoveBoldedDate(fecha);
                        //    fecha = fecha.AddDays(1);
                        //}

                        //mc_reservas.UpdateBoldedDates();
                        MarcarFechasOcupadas(cabaña);
                    }

                    MessageBox.Show("Reserva cancelada correctamente.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cancelar la reserva:  " + ex.Message, "Error");
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

        private void mc_reservas_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (mc_reservas.BoldedDates.Contains(e.Start))
            {
                MessageBox.Show("No se puede seleccionar esta fecha. La cabaña ya está ocupada o está desactivada.", "Error");
                return;
            }
        }

        private Reserva ObtenerReservaSeleccionada()
        {
            if (dataGridView1.CurrentRow == null) return null;

            int rowIndex = dataGridView1.CurrentRow.Index;

            if (variF == "F")
            {
                if (rowIndex >= 0 && rowIndex < listaReservasFiltro.Count)
                    return listaReservasFiltro[rowIndex];
            }
            else
            {
                var reservas = contro_reser.ListarReservas().Where(r => r.Estado != "Cancelada").ToList();
                if (rowIndex >= 0 && rowIndex < reservas.Count)
                    return reservas[rowIndex];
            }

            return null;
        }
    }
}
