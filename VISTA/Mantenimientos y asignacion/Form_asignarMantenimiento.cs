using iTextSharp.text;
using iTextSharp.text.pdf;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VISTA.ABM;

namespace VISTA.Cabañas_y_alquiler
{
    public partial class Form_asignarMantenimiento : Form
    {
        private List<byte[]> imagenes = new List<byte[]>();
        private int indiceImagenActual = 0;
        CONTROLADORA.Controladora_cabañas contro_caba = new CONTROLADORA.Controladora_cabañas();
        CONTROLADORA.Controladora_reservas contro_reser = new CONTROLADORA.Controladora_reservas();
        CONTROLADORA.Controladora_AsignacionesMantenimiento contro_asig = new CONTROLADORA.Controladora_AsignacionesMantenimiento();
        private int idMantenimientoSeleccionado;
        private Cabaña cabañaSeleccionada;
        private Empleado empleadoSeleccionado;
        DateTime fechaPDF = DateTime.Now;
        int numPDF = 0;

        public Form_asignarMantenimiento()
        {
            InitializeComponent();
        }

        private void Form_asignarMantenimiento_Load(object sender, EventArgs e)
        {
            cabañaSeleccionada = null;
            empleadoSeleccionado = null;
            radioButton_no.Checked = true;

            ActualizarLabelFechas();
        }

        private void mc_fechas_DateChanged(object sender, DateRangeEventArgs e)
        {
            ActualizarLabelFechas();
        }

        private void ActualizarLabelFechas()
        {
            lb_fecha_inicio.Text = $"{mc_fechas.SelectionRange.Start:dd/MM/yyyy}";
            lb_fecha_fin.Text = $"{mc_fechas.SelectionRange.End:dd/MM/yyyy}";
        }

        private void btn_seleccionarCabaña_Click(object sender, EventArgs e)
        {
            Form_cabañas_abm formCabañas = new Form_cabañas_abm();
            formCabañas.StartPosition = FormStartPosition.CenterScreen;

            formCabañas.ModoSeleccion = true;

            if (formCabañas.ShowDialog() == DialogResult.OK)
            {
                Cabaña cabaña = formCabañas.CabañaSeleccionada;

                if (cabaña != null)
                {
                    cabañaSeleccionada = cabaña;
                    label_cabaña.Text = $"Cabaña: {cabaña.Nombre}";
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
                Empleado empleado = formEmpleados.EmpleadoSeleccionado;

                if (empleado != null)
                {
                    empleadoSeleccionado = empleado;
                    label_empleado.Text = $"Empleado: {empleado.Nombre} {empleado.Apellido} - {empleado.RolEmpleado?.Nombre}";
                }
            }
        }

        private void btn_asignarMantenimiento_Click(object sender, EventArgs e)
        {
            if (cabañaSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una cabaña antes de asignar el mantenimiento.", "Error");
                return;
            }

            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un empleado antes de asignar el mantenimiento.", "Error");
                return;
            }

            string textoImporte = txt_importe.Text.Replace("$", "").Replace(".", "").Replace(",", "").Trim();

            if (!decimal.TryParse(textoImporte, out decimal importe))
            {
                MessageBox.Show("Ingrese un importe válido para el mantenimiento.", "Error");
                return;
            }

            DateTime fechaInicio = mc_fechas.SelectionRange.Start.Date;
            DateTime fechaFin = mc_fechas.SelectionRange.End.Date;

            bool desactivaCabaña = radioButton_si.Checked;

            var asignacion = contro_asig.CrearAsignacion(idMantenimientoSeleccionado, cabañaSeleccionada.CabañaId, empleadoSeleccionado.EmpleadoId, fechaInicio, fechaFin, importe, desactivaCabaña);

            try
            {
                string respuesta = contro_asig.AgregarAsignacion(asignacion);
                MessageBox.Show(respuesta);

                RecalcularEstadoCabaña(cabañaSeleccionada.CabañaId);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar el mantenimiento:  " + ex.Message, "Error");
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
            if (this.Owner is Form_principal fPrincipal)
            {
                fPrincipal.AbrirForms(new Form_desplegarMantenimientos());
            }

            this.Close();
        }

        public void Configurar(string nombre, string descripcion, List<byte[]> imagenesBytes, int mantenimientoId)
        {
            lb_nombre.Text = $"{nombre}";

            string descripcionFormateada = FormatearDescripcion(descripcion, 7);
            lb_descripcion.Text = $"{descripcionFormateada}";

            imagenes = imagenesBytes;

            idMantenimientoSeleccionado = mantenimientoId;

            if (imagenes.Count > 0)
            {
                indiceImagenActual = 0;
                MostrarImagenActual();
            }
        }

        private string FormatearDescripcion(string descripcion, int palabrasPorLinea)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                return "";

            var palabras = descripcion.Split(' ');
            var resultado = new StringBuilder();

            for (int i = 0; i < palabras.Length; i++)
            {
                resultado.Append(palabras[i]);
                resultado.Append(" ");

                if ((i + 1) % palabrasPorLinea == 0)
                {
                    resultado.AppendLine();
                }
            }

            return resultado.ToString().Trim();
        }

        private void MostrarImagenActual()
        {
            if (imagenes.Count == 0) return;

            using (var ms = new MemoryStream(imagenes[indiceImagenActual]))
            {
                pb_imagenes.Image = System.Drawing.Image.FromStream(ms);
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (imagenes.Count == 0) return;

            indiceImagenActual = (indiceImagenActual + 1) % imagenes.Count;
            MostrarImagenActual();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (imagenes.Count == 0) return;

            indiceImagenActual = (indiceImagenActual - 1 + imagenes.Count) % imagenes.Count;
            MostrarImagenActual();
        }
    }
}
