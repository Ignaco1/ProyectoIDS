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
using VISTA.ABM;

namespace VISTA.Cabañas_y_alquiler
{
    public partial class Form_verReservas : Form
    {

        CONTROLADORA.Controladora_reservas contro_reser = new CONTROLADORA.Controladora_reservas();
        CONTROLADORA.Controladora_clientes contro_cli = new CONTROLADORA.Controladora_clientes();
        CONTROLADORA.Controladora_cabañas contro_caba = new CONTROLADORA.Controladora_cabañas();
        private List<Reserva> listaReservasFiltro = new List<Reserva>();
        private string variF = "";
        private List<MODELO.Reserva> reservasCompletas = new List<MODELO.Reserva>();
        private Cabaña cabañaActual;

        public Form_verReservas()
        {
            InitializeComponent();
            ARMA_GRILLA();
            MODO_LISTA();

        }

        private void Form_verReservas_Load(object sender, EventArgs e)
        {
            var clientes = contro_cli.ListarClientes();

            foreach (var cliente in clientes)
            {
                cb_cliente.Items.Add(cliente);
            }

            cb_cabaña.Items.Clear();

            var cabañasActivas = contro_caba.ListarCabañas().ToList();

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

            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;
            cb_cliente.Enabled = false;
            cb_cabaña.Enabled = false;
            cabañaActual = null;

            ResaltarReservasEnCabañasDesactivadas();
        }

        private void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;

            reservasCompletas = contro_reser.ListarReservas()
            .Where(r => r.Estado != "Cancelada")
            .ToList();

            var reserva = reservasCompletas
                .Select(r => new
                {
                    ID = r.ReservaId,
                    Cabaña = r.Cabaña?.Nombre ?? "Sin cabaña",
                    Cliente = r.Cliente?.Nombre + " " + r.Cliente?.Apellido ?? "Sin cliente",
                    Entrada = r.FechaEntrada,
                    Salida = r.FechaSalida,
                    Precio = r.Precio.ToString("C2"),
                    r.Estado

                }).ToList();

            dataGridView1.DataSource = reserva;

            ResaltarReservasEnCabañasDesactivadas();
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

            if (cabañaActual == null)
            {
                MessageBox.Show("Debe Seleccionar una cabaña para realizar la reserva.", "Error");
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

            if (!cabaña.Activa && cabaña.FechaFinDesactivacion.HasValue)
            {
                DateTime hoy = DateTime.Today;
                DateTime fechaFinDesactivacion = cabaña.FechaFinDesactivacion.Value;

                for (DateTime fecha = fechaEntrada; fecha <= fechaSalida; fecha = fecha.AddDays(1))
                {
                    if (fecha >= hoy && fecha <= fechaFinDesactivacion)
                    {
                        MessageBox.Show("La reserva no puede realizarse en fechas donde la cabaña está desactivada.", "Error");
                        return;
                    }
                }
            }

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

            bool esValida = contro_reser.ValidaReserva(cabaña, fechaEntrada, fechaSalida, reserva.ReservaId);

            if (!esValida)
            {
                MessageBox.Show("Ya existe una reserva para esta cabaña en el rango de fechas seleccionado. O la cabaña se encuentra en reparación", "Error");
                return;
            }

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

        private void btn_quitarFiltro_Click(object sender, EventArgs e)
        {
            cb_estado.SelectedIndex = -1;
            txt_nombreCabañaFiltro.Clear();
            txt_nombreClienteFiltro.Clear();
            dtp_entradaFiltro.Value = DateTime.Today;
            dtp_salidaFiltro.Value = DateTime.Today;

            ARMA_GRILLA();

            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;

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
                ID = r.ReservaId,
                Cabaña = r.Cabaña.Nombre,
                Cliente = r.Cliente.Nombre + " " + r.Cliente.Apellido,
                Entrada = r.FechaEntrada.ToShortDateString(),
                Salida = r.FechaSalida.ToShortDateString(),
                Precio = r.Precio.ToString("C2"),
                r.Estado

            }).ToList();

            ResaltarReservasEnCabañasDesactivadas();
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

            if (!cabaña.Activa && cabaña.FechaFinDesactivacion.HasValue)
            {
                DateTime hoy = DateTime.Today;
                DateTime fin = cabaña.FechaFinDesactivacion.Value;

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

                    var formMotivos = new Form_seleccionarMotivosCancelacion(reservaSeleccionada);
                    formMotivos.ShowDialog();


                    if (!formMotivos.MotivosAsignadosCorrectamente)
                    {
                        MessageBox.Show("Cancelación abortada. No se guardaron motivos.", "Aviso");
                        return;
                    }

                    contro_reser.ModificarReserva(reservaSeleccionada);

                    cabaña = contro_caba.ObtenerCabañaId(reservaSeleccionada.IdCabaña);

                    if (cabaña != null && cabaña.Activa)
                    {
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

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;

            variF = "F";
        }

        private void txt_nombreClienteFiltro_TextChanged(object sender, EventArgs e)
        {
            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;

            variF = "F";
        }

        private void txt_nombreCabañaFiltro_TextChanged(object sender, EventArgs e)
        {
            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;

            variF = "F";

        }

        private void dtp_entradaFiltro_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_entradaFiltro.Value.Date > dtp_salidaFiltro.Value.Date)
            {
                MessageBox.Show("La fecha de entrada no puede ser posterior a la de salida.", "Error");
                return;
            }

            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;

            variF = "F";
        }

        private void dtp_salidaFiltro_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_entradaFiltro.Value.Date > dtp_salidaFiltro.Value.Date)
            {
                MessageBox.Show("La fecha de entrada no puede ser posterior a la de salida.", "Error");
                return;
            }

            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;

            variF = "F";
        }

        private void ResaltarReservasEnCabañasDesactivadas()
        {
            List<MODELO.Reserva> reservasUsar = (variF == "F") ? listaReservasFiltro : reservasCompletas;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var fila = dataGridView1.Rows[i];
                var reserva = reservasUsar[i];

                var cabaña = contro_caba.ObtenerCabañaId(reserva.IdCabaña);

                if (cabaña != null && !cabaña.Activa && cabaña.FechaFinDesactivacion.HasValue)
                {
                    DateTime hoy = DateTime.Today;
                    DateTime fin = cabaña.FechaFinDesactivacion.Value;

                    bool entradaDentro = reserva.FechaEntrada >= hoy && reserva.FechaEntrada <= fin;
                    bool salidaDentro = reserva.FechaSalida >= hoy && reserva.FechaSalida <= fin;

                    if (entradaDentro && salidaDentro)
                    {
                        fila.DefaultCellStyle.BackColor = Color.Red;
                        fila.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void btn_seleccionarCabaña_Click(object sender, EventArgs e)
        {
            Form_cabañas_abm formCabañas = new Form_cabañas_abm();
            formCabañas.StartPosition = FormStartPosition.CenterScreen;

            formCabañas.ModoSeleccion = true;

            if (formCabañas.ShowDialog() == DialogResult.OK)
            {
                Cabaña cabañaSeleccionada = formCabañas.CabañaSeleccionada;

                if (cabañaSeleccionada != null)
                {
                    this.cabañaActual = cabañaSeleccionada;

                    cb_cabaña.SelectedItem = cabañaSeleccionada;
                }
            }
        }
    }
}
