using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class UC_Cabaña : UserControl
    {
        public string CabañaNombre { get; set; }
        private List<byte[]> imagenes = new List<byte[]>();
        private int indiceImagenActual = 0;

        public UC_Cabaña()
        {
            InitializeComponent();

            this.Click += UC_Cabaña_Click;
            foreach (Control c in this.Controls)
            {
                c.Click += UC_Cabaña_Click;
            }

            btn_siguiente.Click += btn_siguiente_Click;
            btn_anterior.Click += btn_anterior_Click;
        }

        private void UC_Cabaña_Load(object sender, EventArgs e)
        {
            btn_siguiente.FlatStyle = FlatStyle.Flat;
            btn_siguiente.FlatAppearance.BorderSize = 0;
            btn_siguiente.BackColor = Color.Transparent;
            btn_siguiente.TabStop = false;
            btn_siguiente.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_siguiente.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        public void Configurar(string nombre, int capacidad, decimal precio, string descripcion, List<byte[]> imagenesBytes)
        {
            CabañaNombre = nombre;
            lb_nombre.Text = nombre;
            lb_capacidad.Text = $"Capacidad: {capacidad}";
            lb_precio.Text = $"Precio por noche: ${precio}";
            lb_descripcion.Text = $"Precio por noche: ${descripcion}";

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

        private void UC_Cabaña_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Abrir formulario para alquilar la cabaña nombre: {CabañaNombre}");
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
