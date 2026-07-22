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
using VISTA.Cabañas_y_alquiler;

namespace VISTA
{
    public partial class UC_Servicio : UserControl
    {
        public string ServicioNombre { get; set; }
        private List<byte[]> imagenes = new List<byte[]>();
        private int indiceImagenActual = 0;
        private Action<Form> abrirFormulario;
        public Servicio DatosServicio { get; set; }

        public UC_Servicio()
        {
            InitializeComponent();

            this.Click += UC_Servicio_Click;
            foreach (Control c in this.Controls)
            {
                c.Click += UC_Servicio_Click;
            }

        }

        private void UC_Servicio_Load(object sender, EventArgs e)
        {

        }

        public void Configurar(string nombre, decimal importe, string descripcion, List<byte[]> imagenesBytes)
        {
            ServicioNombre = nombre;
            lb_nombre.Text = nombre;
            lb_importe.Text = $"Importe del servicio: ${importe}";

            string descripcionFormateada = FormatearDescripcion(descripcion, 2);
            lb_descripcion.Text = $"Descripción: {descripcionFormateada}";

            imagenes = imagenesBytes;

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

        private void UC_Servicio_Click(object sender, EventArgs e)
        {
            LlamadaForm();
        }

        private void LlamadaForm()
        {

            var formAsignarServicio = new Form_asignarServicio();
            var s = DatosServicio;

            DialogResult resultado = MessageBox.Show($"Abrir formulario para asignar el servicio: {ServicioNombre}", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    formAsignarServicio.Configurar(s.Nombre, s.Importe, s.Descripcion, imagenes, s.ServicioId);

                    abrirFormulario?.Invoke(formAsignarServicio);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir el formulario del servicio: {ServicioNombre}  " + ex.Message, "Error");
                    return;
                }
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

        public void SetAbrirFormulario(Action<Form> llamadaAlForm)
        {
            abrirFormulario = llamadaAlForm;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(panel1, "Presione para asignar el servicio");
        }

        private void lb_descripcion_Click(object sender, EventArgs e)
        {
            LlamadaForm();
        }

        private void lb_importe_Click(object sender, EventArgs e)
        {
            LlamadaForm();
        }

        private void pb_imagenes_Click(object sender, EventArgs e)
        {
            LlamadaForm();
        }

        private void lb_nombre_Click(object sender, EventArgs e)
        {
            LlamadaForm();
        }
    }
}
