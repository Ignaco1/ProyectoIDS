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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VISTA.Servicios_y_asignacion
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

        public void Configurar(string nombre, string categoria, decimal importe, string descripcion, List<byte[]> imagenesBytes)
        {
            ServicioNombre = nombre;
            lb_nombre.Text = nombre;
            lb_categoria.Text = $"Categoria: {categoria}";
            lb_precio.Text = $"Importe: ${importe}";
            lb_descripcion.Text = $"Descripción: {descripcion}";

            imagenes = imagenesBytes;

            if (imagenes.Count > 0)
            {
                indiceImagenActual = 0;
                MostrarImagenActual();
            }
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
            //var formServicio = new Form_asignarServicio();
            //var c = DatosServicio;

            //DialogResult resultado = MessageBox.Show($"Abrir formulario para asignar el servicio: {ServicioNombre}", "AVISO", MessageBoxButtons.YesNo);

            //if (resultado == DialogResult.Yes)
            //{
            //    try
            //    {
            //        formServicio.Configurar(c.Nombre, c.Categorias, c.Importe, c.Descripcion, imagenes, c.ServicioId);

            //        abrirFormulario?.Invoke(formServicio);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error al abrir el formulario del servicio: {ServicioNombre}  " + ex.Message, "Error");
            //        return;
            //    }
            //}
        }

        public void SetAbrirFormulario(Action<Form> llamadaAlForm)
        {
            abrirFormulario = llamadaAlForm;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(panel1, "Presione para seleccionar el servicio");

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
