using CAPA_COMUN.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.ABM
{
    public partial class Form_cabañas_abm : Form
    {
        private List<byte[]> imagenesBytes = new List<byte[]>();
        private string vari;

        public Form_cabañas_abm()
        {
            InitializeComponent();

            MODO_LISTA();
            btn_quitarFiltro.Enabled = false;
        }

        private void Form_cabañas_abm_Load(object sender, EventArgs e)
        {

        }

        private void ARMA_GRILLA()
        {

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

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            vari = "A";
            MODO_CARGA();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_activarDesactivar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void btn_imagenes_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string archivo in ofd.FileNames)
                    {
                        byte[] nuevaImagen = File.ReadAllBytes(archivo);
                        if (imagenesBytes.Any(img => img.SequenceEqual(nuevaImagen)))
                            continue; 

                        imagenesBytes.Add(nuevaImagen);

                        PictureBox pbMini = new PictureBox();
                        pbMini.Image = Image.FromFile(archivo);
                        pbMini.Width = 40;
                        pbMini.Height = 40;
                        pbMini.SizeMode = PictureBoxSizeMode.Zoom;
                        pbMini.Padding = new Padding(4);
                        pbMini.Cursor = Cursors.Hand;

                        pbMini.Click += (s, ev) =>
                        {
                            pictureBox_imagenes.Image = ((PictureBox)s).Image;
                        };

                        flowLayoutPanel_imagenes.Controls.Add(pbMini);
                    }

                    if (imagenesBytes.Count > 0)
                    {
                        using (var ms = new MemoryStream(imagenesBytes.Last()))
                        {
                            pictureBox_imagenes.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {

        }

        private void btn_quitarFiltro_Click(object sender, EventArgs e)
        {

        }
    }
}
