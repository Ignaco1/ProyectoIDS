using CAPA_COMUN.Cache;
using Microsoft.IdentityModel.Tokens;
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

namespace VISTA.ABM
{
    public partial class Form_cabañas_abm : Form
    {
        CONTROLADORA.Controladora_cabañas contro_caba = new CONTROLADORA.Controladora_cabañas();
        private List<byte[]> imagenesBytes = new List<byte[]>();
        private string vari;
        private int indice;
        private List<Cabaña> listaCabañasFiltro = new List<Cabaña>();
        private List<int> imagenesAEliminar = new List<int>();
        private string variF = "";  
        private PictureBox imagenSeleccionada = null;

        public Form_cabañas_abm()
        {
            InitializeComponent();
            ARMA_GRILLA();
            MODO_LISTA();
            btn_quitarFiltro.Enabled = false;
        }

        private void Form_cabañas_abm_Load(object sender, EventArgs e)
        {
            txt_descripcion.Multiline = true;
            txt_descripcion.ScrollBars = ScrollBars.Vertical;
            txt_descripcion.WordWrap = true;
            txt_descripcion.Height = 100;
        }

        private void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;

            var cabaña = contro_caba.ListarCabañas()
                .Select(c => new
                {
                    c.CabañaId,
                    c.Nombre,
                    c.Capacidad,
                    c.PrecioPorNoche,
                    c.Descripcion
                }).ToList();

            dataGridView1.DataSource = cabaña;
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
            txt_nombre.Text = "";
            txt_capacidad.Text = "";
            txt_precioNoche.Text = "";
            txt_descripcion.Text = "";
            imagenesBytes.Clear();
            flowLayoutPanel_imagenes.Controls.Clear();
            pictureBox_imagenes.Image = null;
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
                MessageBox.Show("Seleccione una cabaña.", "Error");
                return;
            }

            vari = "M";
            MODELO.Cabaña cabaña;

            if (variF == "F")
            {
                cabaña = listaCabañasFiltro[indice];
            }
            else
            {
                cabaña = contro_caba.ListarCabañas()[indice];
            }

            txt_nombre.Text = cabaña.Nombre;
            txt_capacidad.Text = cabaña.Capacidad.ToString();
            txt_precioNoche.Text = cabaña.PrecioPorNoche.ToString();
            txt_descripcion.Text = cabaña.Descripcion;

            imagenesBytes.Clear();
            imagenesAEliminar.Clear();
            flowLayoutPanel_imagenes.Controls.Clear();
            pictureBox_imagenes.Image = null;

            foreach (var img in cabaña.Imagenes)
            {
                imagenesBytes.Add(img.Imagen);
                var pb = CrearMiniatura(img.Imagen);
                flowLayoutPanel_imagenes.Controls.Add(pb);
            }

            if (imagenesBytes.Count > 0)
            {
                using (MemoryStream ms = new MemoryStream(imagenesBytes[0]))
                {
                    pictureBox_imagenes.Image = Image.FromStream(ms);
                }
            }

            MODO_CARGA();

        }

        private Image ByteArrayToImage(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cabaña.", "Error");
                return;
            }

            MODELO.Cabaña cabaña;

            if (variF == "F")
            {
                cabaña = listaCabañasFiltro[indice];
            }
            else
            {
                cabaña = contro_caba.ListarCabañas()[indice];
            }


            DialogResult resultado = MessageBox.Show($"Está seguro que desea eliminar la cabaña:\n\nNombre: {cabaña.Nombre}\n\nCapacidad: {cabaña.Capacidad}\n\nPrecio por noche: {cabaña.PrecioPorNoche}\n\nDescripción: {cabaña.Descripcion}", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    string respuesta = contro_caba.EliminarCabaña(cabaña);
                    MessageBox.Show(respuesta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la cabaña:  " + ex.Message, "Error");
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

        private void btn_activarDesactivar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cabaña.", "Error");
                return;
            }


        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MODELO.Cabaña cabaña = null;

            #region VALIDACIONES

            if (string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                MessageBox.Show("Ingrese el nombre de la cabaña.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_capacidad.Text))
            {
                MessageBox.Show("Ingrese la capacidad de la cabaña.", "Error");
                return;
            }

            if (!int.TryParse(txt_capacidad.Text, out int capacidad))
            {
                MessageBox.Show("Capacidad debe ser un número entero.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_precioNoche.Text))
            {
                MessageBox.Show("Ingrese el precio por noche de la cabaña.", "Error");
                return;
            }

            if (!decimal.TryParse(txt_precioNoche.Text, out decimal precio))
            {
                MessageBox.Show("Precio debe ser un número válido.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_descripcion.Text))
            {
                MessageBox.Show("Ingrese la descripción de la cabaña.", "Error");
                return;
            }

            if (imagenesBytes.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos una imagen para la cabaña.", "Error");
                return;
            }

            #endregion

            if (vari == "A")
            {
                if (!contro_caba.ValidaCabaña(txt_nombre.Text, 0))
                {
                    cabaña = contro_caba.CrearCabaña(txt_nombre.Text, capacidad, precio, txt_descripcion.Text, true, imagenesBytes);

                    try
                    {
                        string resultado = contro_caba.AgregarCabaña(cabaña);
                        MessageBox.Show(resultado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar la cabaña:  " + ex.Message, "ERROR");
                    }

                }
                else
                {
                    MessageBox.Show("Esta cabaña ya existe\n\nIntente con otro nombre", "AVISO");
                    return;
                }
            }

            if (vari == "M")
            {
                if (variF == "F")
                {
                    cabaña = listaCabañasFiltro[indice];
                }
                else
                {
                    cabaña = contro_caba.ListarCabañas()[indice];
                }

                if (!contro_caba.ValidaCabaña(txt_nombre.Text, cabaña.CabañaId))
                {
                    cabaña.Nombre = txt_nombre.Text;
                    cabaña.Capacidad = capacidad;
                    cabaña.PrecioPorNoche = precio;
                    cabaña.Descripcion = txt_descripcion.Text;

                    cabaña.Imagenes.Clear();
                    foreach (var img in imagenesBytes)
                    {
                        cabaña.Imagenes.Add(new ImagenCabaña
                        {
                            Imagen = img
                        });
                    }

                    try
                    {
                        string resultado = contro_caba.ModificarCabaña(cabaña, imagenesAEliminar);
                        MessageBox.Show(resultado);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar la cabaña:  " + ex.Message, "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Esta cabaña ya existe\n\nIntente con otro nombre", "AVISO");
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
            LIMPIAR();
            MODO_LISTA();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            MODO_LISTA();
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
                pb.Image = Image.FromStream(ms);
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

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            variF = "F";

            btn_quitarFiltro.Enabled = true;

            FILTRAR();
        }

        private void btn_quitarFiltro_Click(object sender, EventArgs e)
        {
            txt_nombreFiltro.Clear();
            txt_capacidadFiltro.Clear();
            txt_precioNocheFiltro.Clear();

            ARMA_GRILLA();

            variF = "";

            btn_quitarFiltro.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cabaña.", "Error");
                return;
            }

            indice = dataGridView1.CurrentRow.Index;
        }

        private void FILTRAR()
        {
            dataGridView1.DataSource = null;

            string nombreFiltro = txt_nombreFiltro.Text.Trim().ToLower();
            bool filtrarCapacidad = int.TryParse(txt_capacidadFiltro.Text, out int capacidadFiltro);
            bool filtrarPrecio = decimal.TryParse(txt_precioNocheFiltro.Text, out decimal precioFiltro);

            listaCabañasFiltro = contro_caba.ListarCabañas()
                .Where(c =>
                    (string.IsNullOrEmpty(nombreFiltro) || c.Nombre.ToLower().Contains(nombreFiltro)) &&
                    (!filtrarCapacidad || c.Capacidad == capacidadFiltro) &&
                    (!filtrarPrecio || c.PrecioPorNoche == precioFiltro)
                )
                .ToList();

            var datosAmostrar = listaCabañasFiltro
            .Select(c => new
            {
                c.CabañaId,
                c.Nombre,
                c.Capacidad,
                c.PrecioPorNoche,
                c.Descripcion

            }).ToList();

            dataGridView1.DataSource = datosAmostrar;

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (pictureBox_imagenes.Image == null)
            {
                MessageBox.Show("No hay imagenes seleccionadas para eliminar.", "Aviso");
                return;
            }

            int index = flowLayoutPanel_imagenes.Controls.IndexOf(imagenSeleccionada);

            if (vari == "M")
            {
                if (index >= 0 && index < imagenesBytes.Count)
                {
                    var cabaña = (variF == "F") ? listaCabañasFiltro[indice] : contro_caba.ListarCabañas()[indice];
                    var imgOriginal = cabaña.Imagenes.ElementAtOrDefault(index);
                    if (imgOriginal != null)
                    {
                        imagenesAEliminar.Add(imgOriginal.ImagenCabañaId);
                    }
                }
            }

            imagenesBytes.RemoveAt(index);
            flowLayoutPanel_imagenes.Controls.RemoveAt(index);
            imagenSeleccionada = null;
            pictureBox_imagenes.Image = null;
        }
    }
}
