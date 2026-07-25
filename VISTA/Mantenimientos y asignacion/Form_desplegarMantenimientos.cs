using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.Cabañas_y_alquiler
{
    public partial class Form_desplegarMantenimientos : Form
    {
        CONTROLADORA.Controladora_mantenimientos contro_mant = new CONTROLADORA.Controladora_mantenimientos();
        private List<Mantenimiento> listaMantenimientosFiltro = new List<Mantenimiento>();
        private bool formCargado = false;

        public Form_desplegarMantenimientos()
        {
            InitializeComponent();

        }

        private void Form_desplegarMantenimientos_Load(object sender, EventArgs e)
        {
            formCargado = false;

            ARMAR();

            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;

            formCargado = true;
        }

        private void ARMAR()
        {
            var todosLosMantenimientos = contro_mant.ListarMantenimientos().ToList();
            CargarMantenimientos(todosLosMantenimientos);
        }

        private void LIMPIAR()
        {
            txt_nombreORubroFiltro.Clear();
        }

        private void CargarMantenimientos(List<Mantenimiento> lista)
        {
            flp_mantenimientos.Controls.Clear();

            foreach (var mantenimiento in lista)
            {
                var tarjeta = new UC_Mantenimiento();
                tarjeta.MantenimientoNombre = mantenimiento.Nombre;
                tarjeta.DatosMantenimiento = mantenimiento;

                var imagenes = mantenimiento.Imagenes.Select(i => i.Imagen).ToList();

                tarjeta.Configurar(mantenimiento.Nombre, mantenimiento.Descripcion, imagenes);

                tarjeta.SetAbrirFormulario(form =>
                {
                    if (this.ParentForm is Form_principal fPrincipal)
                    {
                        form.FormClosed += (s, ev) =>
                        {
                            if (form is Form_asignarMantenimiento fra)
                            {

                            }
                            else
                            {
                                fPrincipal.AbrirForms(new Form_desplegarMantenimientos());
                            }
                        };

                        form.Owner = fPrincipal;
                        fPrincipal.AbrirForms(form);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el formulario principal.");
                    }
                });

                flp_mantenimientos.Controls.Add(tarjeta);
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_quitarFiltro_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            ARMAR();
            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;
        }

        private static string QuitarTildes(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return texto;

            string normalizado = texto.Normalize(NormalizationForm.FormD);
            var sinTildes = normalizado.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark);

            return new string(sinTildes.ToArray()).Normalize(NormalizationForm.FormC);
        }

        private void MantenimientosFiltro()
        {
            string nombreFiltro = QuitarTildes(txt_nombreORubroFiltro.Text.Trim().ToLower());

            listaMantenimientosFiltro = contro_mant.ListarMantenimientos()
                .Where(m => string.IsNullOrEmpty(nombreFiltro) || QuitarTildes(m.Nombre.ToLower()).Contains(nombreFiltro))
                .ToList();

            CargarMantenimientos(listaMantenimientosFiltro);
        }

        private void txt_nombreFiltro_TextChanged(object sender, EventArgs e)
        {
            MantenimientosFiltro();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
        }
    }
}
