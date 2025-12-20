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
    public partial class UC_Cabaña : UserControl
    {
        public string CabañaNombre { get; set; }
        private List<byte[]> imagenes = new List<byte[]>();
        private int indiceImagenActual = 0;
        private Action<Form> abrirFormulario;
        public Cabaña DatosCabaña { get; set; }

        public UC_Cabaña()
        {
            InitializeComponent();

            this.Click += UC_Cabaña_Click;
            foreach (Control c in this.Controls)
            {
                c.Click += UC_Cabaña_Click;
            }

        }

        private void UC_Cabaña_Load(object sender, EventArgs e)
        {

        }

        public void Configurar(string nombre, int capacidad, decimal precio, string descripcion, List<byte[]> imagenesBytes)
        {
            CabañaNombre = nombre;
            lb_nombre.Text = nombre;
            lb_capacidad.Text = $"Capacidad: {capacidad}";
            lb_precio.Text = $"Precio por noche: ${precio}";

            string descripcionFormateada = FormatearDescripcion(descripcion, 3);
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

        private void UC_Cabaña_Click(object sender, EventArgs e)
        {
            var formAlquiler = new Form_reservaCabaña();
            var c = DatosCabaña;

            DialogResult resultado = MessageBox.Show($"Abrir formulario para alquilar la cabaña: {CabañaNombre}", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    formAlquiler.Configurar(c.Nombre, c.Capacidad, c.PrecioPorNoche, c.Descripcion, imagenes, c.CabañaId);

                    abrirFormulario?.Invoke(formAlquiler);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir el formulario de la cabaña: {CabañaNombre}  " + ex.Message, "Error");
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
            toolTip1.SetToolTip(panel1, "Presione para realizar la reserva");
        }
    }
}
