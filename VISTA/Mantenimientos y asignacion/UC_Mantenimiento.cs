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
    public partial class UC_Mantenimiento : UserControl
    {
        public string MantenimientoNombre { get; set; }
        private List<byte[]> imagenes = new List<byte[]>();
        private int indiceImagenActual = 0;
        private Action<Form> abrirFormulario;
        public Mantenimiento DatosMantenimiento { get; set; }

        public UC_Mantenimiento()
        {
            InitializeComponent();

            this.Click += UC_Mantenimiento_Click;
            foreach (Control c in this.Controls)
            {
                c.Click += UC_Mantenimiento_Click;
            }

        }

        private void UC_Mantenimiento_Load(object sender, EventArgs e)
        {

        }

        public void Configurar(string nombre, string descripcion, List<byte[]> imagenesBytes)
        {
            MantenimientoNombre = nombre;
            lb_nombre.Text = nombre;

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

        private void UC_Mantenimiento_Click(object sender, EventArgs e)
        {
            LlamadaForm();
        }

        private void LlamadaForm()
        {

            var formAsignarMantenimiento = new Form_asignarMantenimiento();
            var s = DatosMantenimiento;

            DialogResult resultado = MessageBox.Show($"Abrir formulario para asignar el mantenimiento: {MantenimientoNombre}", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    formAsignarMantenimiento.Configurar(s.Nombre, s.Descripcion, imagenes, s.MantenimientoId);

                    abrirFormulario?.Invoke(formAsignarMantenimiento);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir el formulario del mantenimiento: {MantenimientoNombre}  " + ex.Message, "Error");
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
            toolTip1.SetToolTip(panel1, "Presione para asignar el mantenimiento");
            toolTip1.SetToolTip(lb_descripcion, "Presione para asignar el mantenimiento");
            toolTip1.SetToolTip(pb_imagenes, "Presione para asignar el mantenimiento");
            toolTip1.SetToolTip(lb_nombre, "Presione para asignar el mantenimiento");
        }

        private void lb_descripcion_Click(object sender, EventArgs e)
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
