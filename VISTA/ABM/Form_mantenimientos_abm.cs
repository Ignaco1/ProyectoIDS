using MODELO;
using MODELO.Imagenes;
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
    public partial class Form_mantenimientos_abm : Form
    {
        CONTROLADORA.Controladora_mantenimientos contro_mant = new CONTROLADORA.Controladora_mantenimientos();
        string vari;
        int indice;
        string variF = "";
        private PictureBox imagenSeleccionada = null;
        private List<Mantenimiento> listaMantenimientosFiltro = new List<Mantenimiento>();
        private List<byte[]> imagenesBytes = new List<byte[]>();
        private List<int> imagenesAEliminar = new List<int>();

        public Form_mantenimientos_abm()
        {
            InitializeComponent();
            ARMA_GRILLA();
            MODO_LISTA();
        }

        private void Form_mantenimientos_abm_Load(object sender, EventArgs e)
        {
            txt_descripcion.Multiline = true;
            txt_descripcion.ScrollBars = ScrollBars.Vertical;
            txt_descripcion.WordWrap = true;
            txt_descripcion.Height = 100;

            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;
        }

        private void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;

            var mantenimientos = contro_mant.ListarMantenimientos()
                .Where(e => e.Activo)
                .Select(e => new
                {
                    ID = e.MantenimientoId,
                    e.Nombre,
                    Descripción = e.Descripcion,
                    e.Activo
                }).ToList();

            dataGridView1.DataSource = mantenimientos;

        }

        private void MODO_LISTA()
        {
            groupBox_carga.Enabled = false;
            groupBox_grilla.Enabled = true;
        }

        private void MODO_CARGA()
        {
            groupBox_carga.Enabled = true;
            groupBox_grilla.Enabled = false;
        }

        private void LIMPIAR()
        {
            txt_nombre.Text = "";
            txt_descripcion.Text = "";

            imagenesBytes.Clear();
            flowLayoutPanel_imagenes.Controls.Clear();
            pictureBox_imagenes.Image = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un mantenimiento.", "Error");
                return;
            }

            indice = dataGridView1.CurrentRow.Index;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            vari = "A";

            MODO_CARGA();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un mantenimiento.", "Error");
                return;
            }

            vari = "M";
            MODELO.Mantenimiento mantenimiento;


            if (variF == "")
            {
                mantenimiento = contro_mant.ListarMantenimientos()[indice];
            }
            else
            {
                mantenimiento = listaMantenimientosFiltro[indice];
            }

            txt_nombre.Text = mantenimiento.Nombre;
            txt_descripcion.Text = mantenimiento.Descripcion;

            imagenesBytes.Clear();
            imagenesAEliminar.Clear();
            flowLayoutPanel_imagenes.Controls.Clear();
            pictureBox_imagenes.Image = null;

            foreach (var img in mantenimiento.Imagenes)
            {
                imagenesBytes.Add(img.Imagen);
                var pb = CrearMiniatura(img.Imagen);
                flowLayoutPanel_imagenes.Controls.Add(pb);
            }

            if (imagenesBytes.Count > 0)
            {
                using (MemoryStream ms = new MemoryStream(imagenesBytes[0]))
                {
                    pictureBox_imagenes.Image = System.Drawing.Image.FromStream(ms);
                }
            }

            MODO_CARGA();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un mantenimiento.", "Error");
                return;
            }

            MODELO.Mantenimiento mantenimiento;

            if (variF == "")
            {
                mantenimiento = contro_mant.ListarMantenimientos()[indice];
            }
            else
            {
                mantenimiento = listaMantenimientosFiltro[indice];
            }

            DialogResult resultado = MessageBox.Show($"Está seguro que desea eliminar el mantenimiento:\n\nNombre: {mantenimiento.Nombre}\n\nDescripción: {mantenimiento.Descripcion}", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    string respuesta = contro_mant.EliminarMantenimiento(mantenimiento);
                    MessageBox.Show(respuesta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el mantenimiento:  " + ex.Message, "ERROR");
                    return;
                }
            }

            if (variF == "")
            {
                ARMA_GRILLA();
            }
            else
            {
                FILTRAR();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MODELO.Mantenimiento mantenimiento = null;

            #region VALIDACIONES


            if (string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del mantenimiento.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_descripcion.Text))
            {
                MessageBox.Show("Ingrese la descripción del mantenimiento.", "Error");
                return;
            }

            if (imagenesBytes.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos una imagen para el mantenimiento.", "Error");
                return;
            }


            #endregion

            if (vari == "A")
            {
                mantenimiento = contro_mant.CrearMantenimiento(txt_nombre.Text, txt_descripcion.Text, imagenesBytes);

                try
                {
                    string resultado = contro_mant.AgregarMantenimiento(mantenimiento);
                    MessageBox.Show(resultado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el mantenimiento: " + (ex.InnerException?.Message ?? ex.Message), "ERROR");
                }
            }

            if (vari == "M")
            {

                if (variF == "")
                {
                    mantenimiento = contro_mant.ListarMantenimientos()[indice];
                }
                else
                {
                    mantenimiento = listaMantenimientosFiltro[indice];
                }

                mantenimiento.Nombre = txt_nombre.Text;
                mantenimiento.Descripcion = txt_descripcion.Text;

                mantenimiento.Imagenes.Clear();
                foreach (var img in imagenesBytes)
                {
                    mantenimiento.Imagenes.Add(new ImagenMantenimiento
                    {
                        Imagen = img
                    });
                }

                try
                {
                    string resultado = contro_mant.ModificarMantenimiento(mantenimiento, imagenesAEliminar);
                    MessageBox.Show(resultado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el mantenimiento:  " + ex.Message, "ERROR");
                }
            }

            if (variF == "")
            {
                ARMA_GRILLA();
            }
            else
            {
                FILTRAR();
            }
            LIMPIAR();
            MODO_LISTA();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MODO_LISTA();
            LIMPIAR();
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

                        PictureBox pbMini = CrearMiniatura(nuevaImagen);
                        flowLayoutPanel_imagenes.Controls.Add(pbMini);

                        if (imagenesBytes.Count == 1)
                            pictureBox_imagenes.Image = pbMini.Image;
                    }
                }
            }
        }

        private PictureBox CrearMiniatura(byte[] imagen)
        {
            PictureBox pb = new PictureBox();
            using (MemoryStream ms = new MemoryStream(imagen))
            {
                pb.Image = System.Drawing.Image.FromStream(ms);
            }
            pb.Width = 40;
            pb.Height = 40;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Padding = new Padding(4);
            pb.Cursor = Cursors.Hand;
            pb.Click += (s, ev) =>
            {
                imagenSeleccionada = (PictureBox)s;
                pictureBox_imagenes.Image = imagenSeleccionada.Image;
            };
            return pb;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (pictureBox_imagenes.Image == null)
            {
                MessageBox.Show("No hay imagenes seleccionadas para eliminar.", "AVISO");
                return;
            }

            int index = flowLayoutPanel_imagenes.Controls.IndexOf(imagenSeleccionada);

            if (index < 0 || index >= imagenesBytes.Count)
            {
                MessageBox.Show("Índice de imagen inválido.", "Error");
                return;
            }

            if (vari == "M")
            {
                if (index >= 0 && index < imagenesBytes.Count)
                {
                    var servicio = (variF == "F") ? listaMantenimientosFiltro[indice] : contro_mant.ListarMantenimientos()[indice];
                    var imgOriginal = servicio.Imagenes.ElementAtOrDefault(index);
                    if (imgOriginal != null)
                    {
                        imagenesAEliminar.Add(imgOriginal.ImagenMantenimientoId);
                    }
                }
            }

            imagenesBytes.RemoveAt(index);
            flowLayoutPanel_imagenes.Controls.RemoveAt(index);
            imagenSeleccionada = null;
            pictureBox_imagenes.Image = null;
        }

        private void btn_quitarFiltro_Click(object sender, EventArgs e)
        {
            txt_nombreFiltro.Clear();

            ARMA_GRILLA();

            variF = "";

            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;
        }

        private void FILTRAR()
        {
            dataGridView1.DataSource = null;

            string nombreFiltro = txt_nombreFiltro.Text.Trim().ToLower();

            listaMantenimientosFiltro = contro_mant.ListarMantenimientos()
                .Where(c =>
                (string.IsNullOrEmpty(nombreFiltro) || c.Nombre.ToLower().Contains(nombreFiltro))).ToList();

            var datosAmostrar = listaMantenimientosFiltro
                .Where(e => e.Activo)
                .Select(e => new
                {
                    ID = e.MantenimientoId,
                    e.Nombre,
                    Descripción = e.Descripcion,
                    e.Activo
                }).ToList();

            dataGridView1.DataSource = datosAmostrar;

        }

        private void txt_nombreFiltro_TextChanged(object sender, EventArgs e)
        {
            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
            variF = "F";
        }
    }
}
