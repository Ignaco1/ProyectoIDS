using MODELO;
using MODELO.Composite;
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
    public partial class Form_servicios_abm : Form
    {
        CONTROLADORA.Controladora_Servicios contro_serv = new CONTROLADORA.Controladora_Servicios();
        CONTROLADORA.Controladora_categorias contro_cate = new CONTROLADORA.Controladora_categorias();
        string vari;
        int indice;
        string variF = "";
        private PictureBox imagenSeleccionada = null;
        private List<Servicio> listaServiciosFiltro = new List<Servicio>();
        private List<byte[]> imagenesBytes = new List<byte[]>();
        private List<int> imagenesAEliminar = new List<int>();

        public Form_servicios_abm()
        {
            InitializeComponent();
            ARMA_GRILLA();
            MODO_LISTA();
        }

        private void Form_servicios_abm_Load(object sender, EventArgs e)
        {
            check_listaCategorias.Items.Clear();

            var categorias = contro_cate.ListarCategorias();

            foreach (var categoria in categorias)
            {
                check_listaCategorias.Items.Add(categoria, false);
                cb_categoriasFiltro.Items.Add(categoria.Nombre);
            }

            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;


            txt_descripcion.Multiline = true;
            txt_descripcion.ScrollBars = ScrollBars.Vertical;
            txt_descripcion.WordWrap = true;
            txt_descripcion.Height = 200;
        }

        private void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;

            var servicios = contro_serv.ListarServicios()
                .Where(e => e.Activo)
                .Select(e => new
                {
                    ID = e.ServicioId,
                    e.Nombre,
                    Descripción = e.Descripcion,
                    e.Importe,
                    Categorías = string.Join(", ", (e.Categorias ?? Enumerable.Empty<Categoria>())
                                        .Select(c => c.Nombre)),
                    e.Activo
                }).ToList();

            dataGridView1.DataSource = servicios;

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
            txt_importe.Text = "";

            for (int i = 0; i < check_listaCategorias.Items.Count; i++)
            {
                check_listaCategorias.SetItemChecked(i, false);
            }

            imagenesBytes.Clear();
            flowLayoutPanel_imagenes.Controls.Clear();
            pictureBox_imagenes.Image = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un servicio.", "Error");
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
                MessageBox.Show("Seleccione un servicio.", "Error");
                return;
            }

            vari = "M";
            MODELO.Servicio servicio;


            if (variF == "")
            {
                servicio = contro_serv.ListarServicios()[indice];
            }
            else
            {
                servicio = listaServiciosFiltro[indice];
            }

            txt_nombre.Text = servicio.Nombre;
            txt_descripcion.Text = servicio.Descripcion;
            txt_importe.Text = servicio.Importe.ToString();

            check_listaCategorias.Items.Clear();

            var todasLasCategorias = contro_cate.ListarCategorias();

            foreach (var categoria in todasLasCategorias)
            {
                bool estaAsignado = servicio.Categorias.Any(p => p.CategoriaId == categoria.CategoriaId);
                check_listaCategorias.Items.Add(categoria, estaAsignado);
            }

            imagenesBytes.Clear();
            imagenesAEliminar.Clear();
            flowLayoutPanel_imagenes.Controls.Clear();
            pictureBox_imagenes.Image = null;

            foreach (var img in servicio.Imagenes)
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
                MessageBox.Show("Seleccione un servicio.", "Error");
                return;
            }

            MODELO.Servicio servicio;

            if (variF == "")
            {
                servicio = contro_serv.ListarServicios()[indice];
            }
            else
            {
                servicio = listaServiciosFiltro[indice];
            }

            DialogResult resultado = MessageBox.Show($"Está seguro que desea eliminar el servicio:\n\nNombre: {servicio.Nombre}\n\nDescripción: {servicio.Descripcion}\n\nImporte: {servicio.Importe}\n\nCategoria: {servicio.Categorias.ToList()}", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    string respuesta = contro_serv.EliminarServicio(servicio);
                    MessageBox.Show(respuesta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el servicio:  " + ex.Message, "ERROR");
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
            MODELO.Servicio servicio = null;

            #region VALIDACIONES


            if (string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del servicio.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_descripcion.Text))
            {
                MessageBox.Show("Ingrese la descripción del servicio.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_importe.Text))
            {
                MessageBox.Show("Ingrese el importe del servicio.", "Error");
                return;
            }

            if (!decimal.TryParse(txt_importe.Text, out decimal importe))
            {
                MessageBox.Show("El importe debe ser un número válido.", "Error");
                return;
            }

            var categorias = check_listaCategorias.CheckedItems.OfType<Categoria>().ToList();

            if (categorias.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una categoria para el servicio.", "Error");
                return;
            }

            if (categorias.Count > 1)
            {
                MessageBox.Show("Solo debe seleccionar una categoria para el servicio, no más de eso.", "Error");
                return;
            }

            if (imagenesBytes.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos una imagen para el servicio.", "Error");
                return;
            }


            #endregion

            if (vari == "A")
            {
                servicio = contro_serv.CrearServicio(txt_nombre.Text, txt_descripcion.Text, importe, imagenesBytes);

                try
                {
                    string resultado = contro_serv.AgregarServicio(servicio);
                    string result = contro_serv.AsignarCategoriaAServicio(servicio.ServicioId, categorias);
                    MessageBox.Show(resultado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el servicio: " + (ex.InnerException?.Message ?? ex.Message), "ERROR");
                }
            }

            if (vari == "M")
            {

                if (variF == "")
                {
                    servicio = contro_serv.ListarServicios()[indice];
                }
                else
                {
                    servicio = listaServiciosFiltro[indice];
                }

                servicio.Nombre = txt_nombre.Text;
                servicio.Descripcion = txt_descripcion.Text;
                servicio.Importe = importe;

                servicio.Imagenes.Clear();
                foreach (var img in imagenesBytes)
                {
                    servicio.Imagenes.Add(new ImagenServicio
                    {
                        Imagen = img
                    });
                }

                try
                {
                    string resultado = contro_serv.ModificarServicio(servicio, imagenesAEliminar);
                    string result = contro_serv.AsignarCategoriaAServicio(servicio.ServicioId, categorias);
                    MessageBox.Show(resultado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el servicio:  " + ex.Message, "ERROR");
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

        private void btn_quitarFiltro_Click(object sender, EventArgs e)
        {
            txt_nombreFiltro.Clear();
            cb_categoriasFiltro.SelectedIndex = -1;

            ARMA_GRILLA();

            variF = "";

            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;
        }

        private void FILTRAR()
        {
            dataGridView1.DataSource = null;

            string nombreFiltro = txt_nombreFiltro.Text.Trim().ToLower();
            string categoriaFiltro = cb_categoriasFiltro.Text;

            int? categoriaIdFiltro = null;
            if (cb_categoriasFiltro.SelectedItem is Categoria catSel)
                categoriaIdFiltro = catSel.CategoriaId;


            listaServiciosFiltro = contro_serv.ListarServicios()
                .Where(c =>
                (string.IsNullOrEmpty(nombreFiltro) || c.Nombre.ToLower().Contains(nombreFiltro)) &&
                ((!categoriaIdFiltro.HasValue && string.IsNullOrWhiteSpace(categoriaFiltro))
                || (categoriaIdFiltro.HasValue && (c.Categorias ?? Enumerable.Empty<Categoria>())
                .Any(cat => cat.CategoriaId == categoriaIdFiltro.Value))
                || (!string.IsNullOrWhiteSpace(categoriaFiltro) && (c.Categorias ?? Enumerable.Empty<Categoria>())
                .Any(cat => (cat.Nombre ?? "")
                .IndexOf(categoriaFiltro, StringComparison.OrdinalIgnoreCase) >= 0))
                )).ToList();

            var datosAmostrar = listaServiciosFiltro
                .Where(e => e.Activo)
                .Select(e => new
                {
                    ID = e.ServicioId,
                    e.Nombre,
                    Descripción = e.Descripcion,
                    e.Importe,
                    Categorías = string.Join(", ", (e.Categorias ?? Enumerable.Empty<Categoria>())
                                        .Select(c => c.Nombre)),
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

        private void cb_categoriasFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
            variF = "F";
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

            if (vari == "M")
            {
                if (index >= 0 && index < imagenesBytes.Count)
                {
                    var servicio = (variF == "F") ? listaServiciosFiltro[indice] : contro_serv.ListarServicios()[indice];
                    var imgOriginal = servicio.Imagenes.ElementAtOrDefault(index);
                    if (imgOriginal != null)
                    {
                        imagenesAEliminar.Add(imgOriginal.ImagenServicioId);
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
