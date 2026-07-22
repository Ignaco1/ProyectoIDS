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
    public partial class Form_asignarServicio : Form
    {
        private List<byte[]> imagenes = new List<byte[]>();
        private int indiceImagenActual = 0;
        CONTROLADORA.Controladora_reservas contro_reser = new CONTROLADORA.Controladora_reservas();
        CONTROLADORA.Controladora_AsignacionesServicio contro_asig = new CONTROLADORA.Controladora_AsignacionesServicio();
        private int idServicioSeleccionado;
        private Reserva reservaActual;

        public Form_asignarServicio()
        {
            InitializeComponent();
        }

        private void Form_asignarServicio_Load(object sender, EventArgs e)
        {
            dtp_fecha.Value = DateTime.Today;
            tp_hora.Value = DateTime.Today.AddHours(10);
            reservaActual = null;
            label_reserva.Text = "Reserva no seleccionada";

            dtp_fecha.ValueChanged += dtp_fecha_ValueChanged;
            tp_hora.ValueChanged += tp_hora_ValueChanged;

            ActualizarLabelFecha();
            ActualizarLabelHora();
        }

        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            ActualizarLabelFecha();
        }

        private void tp_hora_ValueChanged(object sender, EventArgs e)
        {
            ActualizarLabelHora();
        }

        private void ActualizarLabelFecha()
        {
            label_fechas.Text = $"{dtp_fecha.Value:dd/MM/yyyy}";
        }

        private void ActualizarLabelHora()
        {
            label_horaSeleccionada.Text = $"{tp_hora.Value:HH:mm}";
        }

        private void btn_asignarServicio_Click(object sender, EventArgs e)
        {
            if (reservaActual == null)
            {
                MessageBox.Show("Debe seleccionar una reserva antes de asignar el servicio.", "Error");
                return;
            }

            DateTime fecha = dtp_fecha.Value.Date;
            TimeSpan hora = tp_hora.Value.TimeOfDay;

            if (!contro_asig.ExisteDisponibilidad(idServicioSeleccionado, fecha, hora))
            {
                MessageBox.Show("El servicio ya se encuentra asignado en esa fecha y horario.", "Error");
                return;
            }

            var asignacion = contro_asig.CrearAsignacion(idServicioSeleccionado, reservaActual.ReservaId, fecha, hora);

            try
            {
                string respuesta = contro_asig.AgregarAsignacion(asignacion);
                MessageBox.Show(respuesta);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar el servicio:  " + ex.Message, "Error");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (this.Owner is Form_principal fPrincipal)
            {
                fPrincipal.AbrirForms(new Form_desplegarServicios());
            }

            this.Close();
        }

        public void Configurar(string nombre, decimal importe, string descripcion, List<byte[]> imagenesBytes, int servicioId)
        {
            lb_nombre.Text = $"{nombre}";
            lb_precio.Text = $"${importe}";

            string descripcionFormateada = FormatearDescripcion(descripcion, 7);
            lb_descripcion.Text = $"{descripcionFormateada}";

            imagenes = imagenesBytes;

            idServicioSeleccionado = servicioId;

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
                pb_imagenes.Image = Image.FromStream(ms);
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

        private void btn_seleccionarReserva_Click(object sender, EventArgs e)
        {
            Form_verReservas formReservas = new Form_verReservas();
            formReservas.StartPosition = FormStartPosition.CenterScreen;

            formReservas.ModoSeleccion = true;

            if (formReservas.ShowDialog() == DialogResult.OK)
            {
                Reserva reservaSeleccionada = formReservas.ReservaSeleccionada;

                if (reservaSeleccionada != null)
                {
                    this.reservaActual = reservaSeleccionada;

                    label_reserva.Text = $"Reserva #{reservaSeleccionada.ReservaId} - Cliente: {reservaSeleccionada.Cliente.Nombre} {reservaSeleccionada.Cliente.Apellido} - Cabaña: {reservaSeleccionada.Cabaña?.Nombre}";
                }
            }
        }
    }
}
