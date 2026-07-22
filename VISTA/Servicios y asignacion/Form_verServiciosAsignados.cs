using MODELO;
using MODELO.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VISTA.ABM;

namespace VISTA.Cabañas_y_alquiler
{
    public partial class Form_verServiciosAsignados : Form
    {
        CONTROLADORA.Controladora_AsignacionesServicio contro_asig = new CONTROLADORA.Controladora_AsignacionesServicio();
        CONTROLADORA.Controladora_reservas contro_reser = new CONTROLADORA.Controladora_reservas();
        private const int LIMITE_ASIGNACIONES_MOSTRADAS = 50;
        private string variF = "";
        private List<AsignacionServicio> asignacionesCompletas = new List<AsignacionServicio>();
        private List<AsignacionServicio> listaAsignacionesFiltro = new List<AsignacionServicio>();
        private bool filtrarPorFecha = false;
        private bool filtrarPorHora = false;
        private Servicio servicioEnEdicion;
        private int asignacionIdEnEdicion;

        public Form_verServiciosAsignados()
        {
            InitializeComponent();
            ARMA_GRILLA();
            MODO_LISTA();
        }

        private void Form_verServiciosAsignados_Load(object sender, EventArgs e)
        {
            cb_estado.Items.Clear();
            cb_estado.Items.AddRange(new string[] { "Pendiente", "Activo", "Finalizado" });
            cb_estado.SelectedIndex = -1;

            dtp_fechaFiltro.Value = DateTime.Today;
            dtp_horaFiltro.Value = DateTime.Today;

            contro_reser.ActualizarEstadosReservas();
            contro_asig.ActualizarEstadosAsignaciones();

            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;

            filtrarPorFecha = false;
            filtrarPorHora = false;
            variF = "";

            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;

            var todasLasAsignaciones = contro_asig.ListarAsignaciones()
                .Where(a => a.EstadoActual is not EstadoAsignacionCancelada)
                .ToList();

            asignacionesCompletas = contro_asig.OrdenarYLimitarAsignaciones(todasLasAsignaciones, LIMITE_ASIGNACIONES_MOSTRADAS);

            dataGridView1.DataSource = ArmarFilas(asignacionesCompletas);
        }

        private List<object> ArmarFilas(List<AsignacionServicio> asignaciones)
        {
            return asignaciones
                .Select(a => new
                {
                    ID = a.AsignacionServicioId,
                    Servicio = a.Servicio?.Nombre ?? "Sin servicio",
                    Reserva = "#" + a.ReservaId,
                    Cabaña = a.Reserva?.Cabaña?.Nombre ?? "Sin cabaña",
                    Cliente = (a.Reserva?.Cliente?.Nombre + " " + a.Reserva?.Cliente?.Apellido)?.Trim(),
                    Fecha = a.Fecha.ToShortDateString(),
                    Horario = a.Hora.ToString(@"hh\:mm"),
                    Importe = a.Servicio?.Importe.ToString("C2"),
                    Estado = a.Estado
                })
                .Cast<object>()
                .ToList();
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
            cb_servicio.Items.Clear();
            cb_reservas.Items.Clear();
            cb_cabaña.Items.Clear();
            cb_cliente.Items.Clear();

            servicioEnEdicion = null;
            asignacionIdEnEdicion = 0;

            dtp_fecha.Value = DateTime.Today;
            tp_hora.Value = DateTime.Today.AddHours(10);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private AsignacionServicio ObtenerAsignacionSeleccionada()
        {
            if (dataGridView1.CurrentRow == null) return null;

            int rowIndex = dataGridView1.CurrentRow.Index;

            if (variF == "F")
            {
                if (rowIndex >= 0 && rowIndex < listaAsignacionesFiltro.Count)
                    return listaAsignacionesFiltro[rowIndex];
            }
            else
            {
                if (rowIndex >= 0 && rowIndex < asignacionesCompletas.Count)
                    return asignacionesCompletas[rowIndex];
            }

            return null;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            AsignacionServicio asignacion = ObtenerAsignacionSeleccionada();

            if (asignacion == null)
            {
                MessageBox.Show("Seleccione un servicio asignado.", "Error");
                return;
            }

            servicioEnEdicion = asignacion.Servicio;
            asignacionIdEnEdicion = asignacion.AsignacionServicioId;

            cb_servicio.Items.Clear();
            cb_servicio.Items.Add(asignacion.Servicio);
            cb_servicio.SelectedItem = asignacion.Servicio;

            cb_reservas.Items.Clear();
            cb_reservas.Items.Add(asignacion.Reserva);
            cb_reservas.SelectedItem = asignacion.Reserva;

            cb_cabaña.Items.Clear();
            cb_cabaña.Items.Add(asignacion.Reserva?.Cabaña);
            cb_cabaña.SelectedItem = asignacion.Reserva?.Cabaña;

            cb_cliente.Items.Clear();
            cb_cliente.Items.Add(asignacion.Reserva?.Cliente);
            cb_cliente.SelectedItem = asignacion.Reserva?.Cliente;

            dtp_fecha.Value = asignacion.Fecha;
            tp_hora.Value = DateTime.Today.Add(asignacion.Hora);

            MODO_CARGA();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            AsignacionServicio asignacion = ObtenerAsignacionSeleccionada();

            if (asignacion == null)
            {
                MessageBox.Show("Seleccione un servicio asignado.", "Error");
                return;
            }

            DialogResult resultado = MessageBox.Show($"Está seguro que desea eliminar el servicio asignado:\n\nServicio: {asignacion.Servicio?.Nombre}\n\nReserva: #{asignacion.ReservaId}\n\nCliente: {asignacion.Reserva?.Cliente?.Nombre} {asignacion.Reserva?.Cliente?.Apellido}", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    string respuesta = contro_asig.EliminarAsignacion(asignacion);
                    MessageBox.Show(respuesta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el servicio asignado:  " + ex.Message, "Error");
                    return;
                }
            }

            if (variF == "")
                ARMA_GRILLA();
            else
                FILTRAR();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (asignacionIdEnEdicion == 0)
            {
                MessageBox.Show("Seleccione un servicio asignado para modificar.", "Error");
                return;
            }

            if (servicioEnEdicion == null)
            {
                MessageBox.Show("Debe seleccionar un servicio.", "Error");
                return;
            }

            DateTime fecha = dtp_fecha.Value.Date;
            TimeSpan hora = tp_hora.Value.TimeOfDay;

            if (!contro_asig.ExisteDisponibilidad(servicioEnEdicion.ServicioId, fecha, hora, asignacionIdEnEdicion))
            {
                MessageBox.Show("El servicio ya se encuentra asignado en esa fecha y horario.", "Error");
                return;
            }

            try
            {
                string resultado = contro_asig.ModificarAsignacion(asignacionIdEnEdicion, servicioEnEdicion.ServicioId, fecha, hora);
                contro_reser.ActualizarEstadosReservas();
                contro_asig.ActualizarEstadosAsignaciones();
                MessageBox.Show(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el servicio asignado:  " + ex.Message, "Error");
                return;
            }

            if (variF == "")
                ARMA_GRILLA();
            else
                FILTRAR();

            LIMPIAR();
            MODO_LISTA();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            MODO_LISTA();
        }

        private void btn_seleccionarServicio_Click(object sender, EventArgs e)
        {
            Form_servicios_abm formServicios = new Form_servicios_abm();
            formServicios.StartPosition = FormStartPosition.CenterScreen;

            formServicios.ModoSeleccion = true;

            if (formServicios.ShowDialog() == DialogResult.OK)
            {
                Servicio servicioSeleccionado = formServicios.ServicioSeleccionado;

                if (servicioSeleccionado != null)
                {
                    servicioEnEdicion = servicioSeleccionado;

                    cb_servicio.Items.Clear();
                    cb_servicio.Items.Add(servicioSeleccionado);
                    cb_servicio.SelectedItem = servicioSeleccionado;
                }
            }
        }

        private void btn_cancelarServicio_Click(object sender, EventArgs e)
        {
            AsignacionServicio asignacion = ObtenerAsignacionSeleccionada();

            if (asignacion == null)
            {
                MessageBox.Show("Seleccione un servicio asignado.", "Error");
                return;
            }

            DialogResult resultado = MessageBox.Show($"Está seguro que desea cancelar el servicio asignado:\n\nServicio: {asignacion.Servicio?.Nombre}\n\nReserva: #{asignacion.ReservaId}\n\nCliente: {asignacion.Reserva?.Cliente?.Nombre} {asignacion.Reserva?.Cliente?.Apellido}", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    var formMotivos = new Form_motivosCancelacionServicio(asignacion);
                    formMotivos.ShowDialog();

                    if (!formMotivos.MotivosAsignadosCorrectamente)
                    {
                        MessageBox.Show("Cancelación abortada. No se guardaron motivos.", "Aviso");
                        return;
                    }

                    contro_asig.CancelarAsignacion(asignacion);

                    MessageBox.Show("Servicio asignado cancelado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cancelar el servicio asignado:  " + ex.Message, "Error");
                    return;
                }
            }

            if (variF == "")
                ARMA_GRILLA();
            else
                FILTRAR();
        }

        private void btn_quitarFiltro_Click(object sender, EventArgs e)
        {
            cb_estado.SelectedIndex = -1;
            txt_nombreCabañaFiltro.Clear();
            txt_nombreClienteFiltro.Clear();
            dtp_fechaFiltro.Value = DateTime.Today;
            dtp_horaFiltro.Value = DateTime.Today;

            filtrarPorFecha = false;
            filtrarPorHora = false;

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

            DateTime fechaFiltro = dtp_fechaFiltro.Value.Date;
            TimeSpan horaFiltro = dtp_horaFiltro.Value.TimeOfDay;

            var asignaciones = contro_asig.ListarAsignaciones();

            listaAsignacionesFiltro = asignaciones
                .Where(a =>
                    a.EstadoActual is not EstadoAsignacionCancelada &&
                    (string.IsNullOrEmpty(nombreCabañaFiltro) || (a.Reserva?.Cabaña?.Nombre ?? "").ToLower().Contains(nombreCabañaFiltro)) &&
                    (string.IsNullOrEmpty(nombreClienteFiltro) ||
                        (a.Reserva?.Cliente?.Nombre ?? "").ToLower().Contains(nombreClienteFiltro) ||
                        (a.Reserva?.Cliente?.Apellido ?? "").ToLower().Contains(nombreClienteFiltro)) &&
                    (string.IsNullOrEmpty(estadoFiltro) || (a.Estado?.Equals(estadoFiltro, StringComparison.OrdinalIgnoreCase) ?? false)) &&
                    (!filtrarPorFecha || a.Fecha.Date == fechaFiltro) &&
                    (!filtrarPorHora || a.Hora == horaFiltro)
                )
                .ToList();

            listaAsignacionesFiltro = contro_asig.OrdenarYLimitarAsignaciones(listaAsignacionesFiltro, LIMITE_ASIGNACIONES_MOSTRADAS);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ArmarFilas(listaAsignacionesFiltro);
        }

        private void txt_nombreCabañaFiltro_TextChanged(object sender, EventArgs e)
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

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
            variF = "F";
        }

        private void dtp_fechaFiltro_ValueChanged(object sender, EventArgs e)
        {
            filtrarPorFecha = true;

            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
            variF = "F";
        }

        private void dtp_horaFiltro_ValueChanged(object sender, EventArgs e)
        {
            filtrarPorHora = true;

            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
            variF = "F";
        }
    }
}
