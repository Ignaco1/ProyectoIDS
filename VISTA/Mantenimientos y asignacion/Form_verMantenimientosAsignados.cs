using iTextSharp.text;
using iTextSharp.text.pdf;
using MODELO;
using MODELO.State;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VISTA.ABM;

namespace VISTA.Cabañas_y_alquiler
{
    public partial class Form_verMantenimientosAsignados : Form
    {
        CONTROLADORA.Controladora_AsignacionesMantenimiento contro_asig = new CONTROLADORA.Controladora_AsignacionesMantenimiento();
        CONTROLADORA.Controladora_reservas contro_reser = new CONTROLADORA.Controladora_reservas();
        CONTROLADORA.Controladora_cabañas contro_caba = new CONTROLADORA.Controladora_cabañas();
        private const int LIMITE_ASIGNACIONES_MOSTRADAS = 50;
        private string variF = "";
        private List<AsignacionMantenimiento> asignacionesCompletas = new List<AsignacionMantenimiento>();
        private List<AsignacionMantenimiento> listaAsignacionesFiltro = new List<AsignacionMantenimiento>();
        private bool filtrarPorFechaInicio = false;
        private bool filtrarPorFechaFin = false;

        private Mantenimiento mantenimientoEnEdicion;
        private Empleado empleadoEnEdicion;
        private int asignacionIdEnEdicion;
        private int cabañaIdOriginalEnEdicion;
        DateTime fechaPDF = DateTime.Now;
        int numPDF = 0;

        public Form_verMantenimientosAsignados()
        {
            InitializeComponent();
            ARMA_GRILLA();
            MODO_LISTA();
        }

        private void Form_verMantenimientosAsignados_Load(object sender, EventArgs e)
        {
            cb_estado.Items.Clear();
            cb_estado.Items.AddRange(new string[] { "Pendiente", "Activo", "Finalizado" });
            cb_estado.SelectedIndex = -1;

            dtp_fechaInicioFiltro.Value = DateTime.Today;
            dtp_fechaFinFiltro.Value = DateTime.Today;

            contro_reser.ActualizarEstadosReservas();
            contro_asig.ActualizarEstadosAsignaciones();
            ReactivarCabañasSinAsignacionesQueLasDesactiven();

            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;

            filtrarPorFechaInicio = false;
            filtrarPorFechaFin = false;
            variF = "";

            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;

            var todasLasAsignaciones = contro_asig.ListarAsignaciones()
                .Where(a => a.EstadoActual is not EstadoAsignacionMantenimientoCancelada)
                .ToList();

            asignacionesCompletas = contro_asig.OrdenarYLimitarAsignaciones(todasLasAsignaciones, LIMITE_ASIGNACIONES_MOSTRADAS);

            dataGridView1.DataSource = ArmarFilas(asignacionesCompletas);
        }

        private List<object> ArmarFilas(List<AsignacionMantenimiento> asignaciones)
        {
            return asignaciones
                .Select(a => new
                {
                    ID = a.AsignacionMantenimientoId,
                    Mantenimiento = a.Mantenimiento?.Nombre ?? "Sin mantenimiento",
                    Cabaña = a.Cabaña?.Nombre ?? "Sin cabaña",
                    Empleado = (a.Empleado?.Nombre + " " + a.Empleado?.Apellido)?.Trim(),
                    FechaInicio = a.FechaInicio.ToShortDateString(),
                    FechaFin = a.FechaFin.ToShortDateString(),
                    Importe = a.Costo.ToString("C2"),
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
            cb_mantenimiento.Items.Clear();
            cb_empleado.Items.Clear();
            cb_cabañas.Items.Clear();

            mantenimientoEnEdicion = null;
            empleadoEnEdicion = null;
            asignacionIdEnEdicion = 0;

            dtp_fechaInicio.Value = DateTime.Today;
            dtp_fechaFin.Value = DateTime.Today;

            radioButton_no.Checked = true;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private AsignacionMantenimiento ObtenerAsignacionSeleccionada()
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
            AsignacionMantenimiento asignacion = ObtenerAsignacionSeleccionada();

            if (asignacion == null)
            {
                MessageBox.Show("Seleccione un mantenimiento asignado.", "Error");
                return;
            }

            mantenimientoEnEdicion = asignacion.Mantenimiento;
            empleadoEnEdicion = asignacion.Empleado;
            asignacionIdEnEdicion = asignacion.AsignacionMantenimientoId;
            cabañaIdOriginalEnEdicion = asignacion.CabañaId;

            cb_mantenimiento.Items.Clear();
            cb_mantenimiento.Items.Add(asignacion.Mantenimiento);
            cb_mantenimiento.SelectedItem = asignacion.Mantenimiento;

            cb_empleado.Items.Clear();
            cb_empleado.Items.Add(asignacion.Empleado);
            cb_empleado.SelectedItem = asignacion.Empleado;

            cb_cabañas.Items.Clear();
            foreach (var cabaña in contro_caba.ListarCabañas())
            {
                cb_cabañas.Items.Add(cabaña);
            }
            cb_cabañas.SelectedItem = cb_cabañas.Items.Cast<Cabaña>().FirstOrDefault(c => c.CabañaId == asignacion.CabañaId);

            dtp_fechaInicio.Value = asignacion.FechaInicio;
            dtp_fechaFin.Value = asignacion.FechaFin;

            radioButton_si.Checked = asignacion.DesactivaCabaña;
            radioButton_no.Checked = !asignacion.DesactivaCabaña;

            MODO_CARGA();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            AsignacionMantenimiento asignacion = ObtenerAsignacionSeleccionada();

            if (asignacion == null)
            {
                MessageBox.Show("Seleccione un mantenimiento asignado.", "Error");
                return;
            }

            DialogResult resultado = MessageBox.Show($"Está seguro que desea eliminar el mantenimiento asignado:\n\nMantenimiento: {asignacion.Mantenimiento?.Nombre}\n\nCabaña: {asignacion.Cabaña?.Nombre}\n\nEmpleado: {asignacion.Empleado?.Nombre} {asignacion.Empleado?.Apellido}", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    string respuesta = contro_asig.EliminarAsignacion(asignacion);
                    RecalcularEstadoCabaña(asignacion.CabañaId);
                    MessageBox.Show(respuesta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el mantenimiento asignado:  " + ex.Message, "Error");
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
                MessageBox.Show("Seleccione un mantenimiento asignado para modificar.", "Error");
                return;
            }

            if (mantenimientoEnEdicion == null)
            {
                MessageBox.Show("Debe seleccionar un mantenimiento.", "Error");
                return;
            }

            if (empleadoEnEdicion == null)
            {
                MessageBox.Show("Debe seleccionar un empleado.", "Error");
                return;
            }

            Cabaña cabañaSeleccionada = cb_cabañas.SelectedItem as Cabaña;

            if (cabañaSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una cabaña.", "Error");
                return;
            }

            DateTime fechaInicio = dtp_fechaInicio.Value.Date;
            DateTime fechaFin = dtp_fechaFin.Value.Date;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.", "Error");
                return;
            }

            var asignacionActual = contro_asig.ObtenerAsignacionId(asignacionIdEnEdicion);

            if (asignacionActual == null)
            {
                MessageBox.Show("El mantenimiento asignado ya no existe.", "Error");
                return;
            }

            bool desactivarNueva = radioButton_si.Checked;
            int cabañaIdOriginal = cabañaIdOriginalEnEdicion;

            try
            {
                string resultado = contro_asig.ModificarAsignacion(asignacionIdEnEdicion, mantenimientoEnEdicion.MantenimientoId, cabañaSeleccionada.CabañaId, empleadoEnEdicion.EmpleadoId, fechaInicio, fechaFin, asignacionActual.Costo, desactivarNueva);

                RecalcularEstadoCabaña(cabañaIdOriginal);

                if (cabañaSeleccionada.CabañaId != cabañaIdOriginal)
                {
                    RecalcularEstadoCabaña(cabañaSeleccionada.CabañaId);
                }

                contro_reser.ActualizarEstadosReservas();
                contro_asig.ActualizarEstadosAsignaciones();
                ReactivarCabañasSinAsignacionesQueLasDesactiven();

                MessageBox.Show(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el mantenimiento asignado:  " + ex.Message, "Error");
                return;
            }

            if (variF == "")
                ARMA_GRILLA();
            else
                FILTRAR();

            LIMPIAR();
            MODO_LISTA();
        }

        private void ReactivarCabañasSinAsignacionesQueLasDesactiven()
        {
            var cabañasInactivas = contro_caba.ListarCabañas().Where(c => !c.Activa).ToList();

            foreach (var cabaña in cabañasInactivas)
            {
                RecalcularEstadoCabaña(cabaña.CabañaId);
            }
        }

        private void RecalcularEstadoCabaña(int cabañaId)
        {
            var cabaña = contro_caba.ObtenerCabañaId(cabañaId);

            if (cabaña == null) return;

            var desactivantes = contro_asig.ListarAsignacionesQueDesactivanCabaña(cabañaId);

            if (desactivantes.Any())
            {
                DateTime nuevaFechaFinDesactivacion = desactivantes.Max(a => a.FechaFin);

                var clientesAntes = !cabaña.Activa
                    ? contro_reser.ObtenerClientesConReservasActivasPorCabaña(cabaña.CabañaId)
                    : new List<(Cliente cliente, DateTime fechaEntrada, DateTime fechaSalida)>();

                cabaña.Activa = false;
                cabaña.FechaFinDesactivacion = nuevaFechaFinDesactivacion;
                contro_caba.ModificarActividadCabaña(cabaña);

                var clientesDespues = contro_reser.ObtenerClientesConReservasActivasPorCabaña(cabaña.CabañaId);

                var clientesNuevos = clientesDespues
                    .Where(d => !clientesAntes.Any(a => a.cliente.ClienteId == d.cliente.ClienteId && a.fechaEntrada == d.fechaEntrada && a.fechaSalida == d.fechaSalida))
                    .ToList();

                if (clientesNuevos.Any())
                {
                    GenerarPDFClientes(clientesNuevos, cabaña.Nombre);
                }
            }
            else if (!cabaña.Activa)
            {
                cabaña.Activa = true;
                cabaña.FechaFinDesactivacion = null;
                contro_caba.ModificarActividadCabaña(cabaña);
            }
        }

        private void GenerarPDFClientes(List<(Cliente cliente, DateTime fechaEntrada, DateTime fechaSalida)> reservas, string nombreCabaña)
        {
            if (reservas == null || reservas.Count == 0)
            {
                MessageBox.Show("No hay reservas afectadas para generar el PDF.", "Aviso");
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PDF Files|*.pdf";
            numPDF = numPDF + 1;
            var fecha = fechaPDF.Date.ToString("dd-MM-yyyy");
            var hora = fechaPDF.ToString("HHHH-mm-ss");
            saveFile.FileName = $"ClientesAfectados_{nombreCabaña}_{fecha}_{hora}_{numPDF}.pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFile.FileName, FileMode.Create, FileAccess.Write))
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document();
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);

                    doc.Open();

                    doc.Add(new Paragraph($"Clientes afectados por desactivación de la cabaña: {nombreCabaña}"));
                    doc.Add(new Paragraph(" "));
                    doc.Add(new Paragraph($"Fecha: {DateTime.Today:dd/MM/yyyy}"));
                    doc.Add(new Paragraph(" "));
                    doc.Add(new Paragraph(" "));

                    for (int i = 0; i < reservas.Count; i++)
                    {
                        var reserva = reservas[i];

                        Paragraph clienteParrafo = new Paragraph(
                            $"Entrada: {reserva.fechaEntrada:dd/MM/yyyy} - " +
                            $"Salida: {reserva.fechaSalida:dd/MM/yyyy} - " +
                            $"Nombre: {reserva.cliente.Nombre} {reserva.cliente.Apellido} - " +
                            $"Email: {reserva.cliente.Email} - Teléfono: {reserva.cliente.Telefono}\n\n\n"
                        );

                        clienteParrafo.SpacingBefore = 10f;
                        clienteParrafo.SpacingAfter = 5f;

                        doc.Add(clienteParrafo);
                    }

                    doc.Close();
                }

                MessageBox.Show("PDF generado correctamente.", "Éxito");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            MODO_LISTA();
        }

        private void btn_seleccionarMantenimiento_Click(object sender, EventArgs e)
        {
            Form_mantenimientos_abm formMantenimientos = new Form_mantenimientos_abm();
            formMantenimientos.StartPosition = FormStartPosition.CenterScreen;

            formMantenimientos.ModoSeleccion = true;

            if (formMantenimientos.ShowDialog() == DialogResult.OK)
            {
                Mantenimiento mantenimientoSeleccionado = formMantenimientos.MantenimientoSeleccionado;

                if (mantenimientoSeleccionado != null)
                {
                    mantenimientoEnEdicion = mantenimientoSeleccionado;

                    cb_mantenimiento.Items.Clear();
                    cb_mantenimiento.Items.Add(mantenimientoSeleccionado);
                    cb_mantenimiento.SelectedItem = mantenimientoSeleccionado;
                }
            }
        }

        private void btn_seleccionarEmpleado_Click(object sender, EventArgs e)
        {
            Form_empleados_abm formEmpleados = new Form_empleados_abm();
            formEmpleados.StartPosition = FormStartPosition.CenterScreen;

            formEmpleados.ModoSeleccion = true;
            formEmpleados.SoloRolesMantenimiento = true;

            if (formEmpleados.ShowDialog() == DialogResult.OK)
            {
                Empleado empleadoSeleccionado = formEmpleados.EmpleadoSeleccionado;

                if (empleadoSeleccionado != null)
                {
                    empleadoEnEdicion = empleadoSeleccionado;

                    cb_empleado.Items.Clear();
                    cb_empleado.Items.Add(empleadoSeleccionado);
                    cb_empleado.SelectedItem = empleadoSeleccionado;
                }
            }
        }

        private void btn_cancelarMantenimiento_Click(object sender, EventArgs e)
        {
            AsignacionMantenimiento asignacion = ObtenerAsignacionSeleccionada();

            if (asignacion == null)
            {
                MessageBox.Show("Seleccione un mantenimiento asignado.", "Error");
                return;
            }

            DialogResult resultado = MessageBox.Show($"Está seguro que desea cancelar el mantenimiento asignado:\n\nMantenimiento: {asignacion.Mantenimiento?.Nombre}\n\nCabaña: {asignacion.Cabaña?.Nombre}\n\nEmpleado: {asignacion.Empleado?.Nombre} {asignacion.Empleado?.Apellido}", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    var formMotivos = new Form_motivosCancelacionMantenimiento(asignacion);
                    formMotivos.ShowDialog();

                    if (!formMotivos.MotivosAsignadosCorrectamente)
                    {
                        MessageBox.Show("Cancelación abortada. No se guardaron motivos.", "Aviso");
                        return;
                    }

                    contro_asig.CancelarAsignacion(asignacion);
                    RecalcularEstadoCabaña(asignacion.CabañaId);

                    MessageBox.Show("Mantenimiento asignado cancelado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cancelar el mantenimiento asignado:  " + ex.Message, "Error");
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
            txt_nombreEmpleadoFiltro.Clear();
            dtp_fechaInicioFiltro.Value = DateTime.Today;
            dtp_fechaFinFiltro.Value = DateTime.Today;

            filtrarPorFechaInicio = false;
            filtrarPorFechaFin = false;

            ARMA_GRILLA();

            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;

            variF = "";
        }

        private void FILTRAR()
        {
            string nombreCabañaFiltro = txt_nombreCabañaFiltro.Text.Trim().ToLower();
            string nombreEmpleadoFiltro = txt_nombreEmpleadoFiltro.Text.Trim().ToLower();
            string estadoFiltro = cb_estado.Text.Trim();

            DateTime fechaInicioFiltro = dtp_fechaInicioFiltro.Value.Date;
            DateTime fechaFinFiltro = dtp_fechaFinFiltro.Value.Date;

            var asignaciones = contro_asig.ListarAsignaciones();

            listaAsignacionesFiltro = asignaciones
                .Where(a =>
                    a.EstadoActual is not EstadoAsignacionMantenimientoCancelada &&
                    (string.IsNullOrEmpty(nombreCabañaFiltro) || (a.Cabaña?.Nombre ?? "").ToLower().Contains(nombreCabañaFiltro)) &&
                    (string.IsNullOrEmpty(nombreEmpleadoFiltro) ||
                        (a.Empleado?.Nombre ?? "").ToLower().Contains(nombreEmpleadoFiltro) ||
                        (a.Empleado?.Apellido ?? "").ToLower().Contains(nombreEmpleadoFiltro)) &&
                    (string.IsNullOrEmpty(estadoFiltro) || (a.Estado?.Equals(estadoFiltro, StringComparison.OrdinalIgnoreCase) ?? false)) &&
                    (!filtrarPorFechaInicio || a.FechaInicio.Date == fechaInicioFiltro) &&
                    (!filtrarPorFechaFin || a.FechaFin.Date == fechaFinFiltro)
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

        private void txt_nombreEmpleadoFiltro_TextChanged(object sender, EventArgs e)
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

        private void dtp_fechaInicioFiltro_ValueChanged(object sender, EventArgs e)
        {
            filtrarPorFechaInicio = true;

            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
            variF = "F";
        }

        private void dtp_fechaFinFiltro_ValueChanged(object sender, EventArgs e)
        {
            filtrarPorFechaFin = true;

            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
            variF = "F";
        }
    }
}
