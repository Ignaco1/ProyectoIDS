using CAPA_COMUN.Cache;
using MODELO.Composite;
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
    public partial class Form_gestionarGrupos : Form
    {
        CONTROLADORA.Controladora_grupos contro_grup = new CONTROLADORA.Controladora_grupos();
        string vari;
        List<MODELO.Composite.Grupo> gruposFiltrados;
        int indice = 0;
        string variF = "";
        List<Grupo> listaGruposFiltro = new List<Grupo>();


        public Form_gestionarGrupos()
        {
            InitializeComponent();
            ARMA_GRILLA();
            MODO_GRILLA();
        }


        private void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;

            var grupos = contro_grup.ListarGrupos();


            if (UsuarioCache.UsuarioGrupoNombre != "SuperAdministrador")
            {
                gruposFiltrados = grupos.Where(g => g.Nombre != "SuperAdministrador").ToList();
            }
            else
            {
                gruposFiltrados = grupos.ToList();
            }

            var datosGrilla = gruposFiltrados
                .Select(g => new
                {
                    ID = g.GrupoId,
                    Nombre = g.Nombre
                })
                .ToList();

            dataGridView1.DataSource = datosGrilla;
        }

        private void MODO_GRILLA()
        {
            groupBox_grupos.Enabled = true;
            groupBox_carga.Enabled = false;
        }

        private void MODO_CARGA()
        {
            groupBox_grupos.Enabled = false;
            groupBox_carga.Enabled = true;
        }

        private void LIMPIAR()
        {
            txt_nombre.Text = "";
        }

        private void Form_gestionarGrupos_Load(object sender, EventArgs e)
        {
            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;
        }

        private void btn_crearGrupo_Click(object sender, EventArgs e)
        {
            vari = "C";
            MODO_CARGA();
        }

        private void btn_modificarGrupo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un grupo", "Error");
                return;
            }

            MODELO.Composite.Grupo grupo;
            vari = "M";

            if (variF == "")
            {
                grupo = gruposFiltrados[indice];
            }
            else
            {
                grupo = listaGruposFiltro[indice];
            }

            txt_nombre.Text = grupo.Nombre;

            MODO_CARGA();
        }

        private void btn_eliminarGrupo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un grupo", "Error");
                return;
            }

            MODELO.Composite.Grupo grupo;

            if (variF == "")
            {
                grupo = gruposFiltrados[indice];
            }
            else
            {
                grupo = listaGruposFiltro[indice];
            }

            DialogResult resultado = MessageBox.Show($"Esta seguro que desea eliminar al grupo:\n\nNombre: {grupo.Nombre}", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    string respuesta = contro_grup.EliminarGrupo(grupo);
                    MessageBox.Show(respuesta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el grupo: " + ex.Message, "Error");
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
            MODELO.Composite.Grupo grupo = null;

            if (vari == "C")
            {
                if (!contro_grup.ValidarGrupo(txt_nombre.Text))
                {
                    grupo = contro_grup.CrearGrupos(txt_nombre.Text);

                    try
                    {
                        string respuesta = contro_grup.AgregarGrupo(grupo);
                        MessageBox.Show(respuesta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al crear el grupo: " + ex.Message, "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Este grupo ya existe en el sistema.\n\nIntente con otro nombre de grupo.", "AVISO");
                    return;
                }
            }

            if (vari == "M")
            {
                if (variF == "")
                {
                    grupo = gruposFiltrados[indice];
                }
                else
                {
                    grupo = listaGruposFiltro[indice];
                }

                grupo.Nombre = txt_nombre.Text;

                if (!contro_grup.ValidarGrupoModificado(grupo))
                {

                    try
                    {
                        string respuesta = contro_grup.ModificarGrupo(grupo);
                        MessageBox.Show(respuesta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar el grupo: " + ex.Message, "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Este grupo ya existe en el sistema.\n\nIntente con otro nombre de grupo.", "AVISO");
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

            MODO_GRILLA();
            LIMPIAR();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MODO_GRILLA();
            LIMPIAR();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FILTRAR()
        {
            dataGridView1.DataSource = null;

            string nombreFiltro = txt_nombreFiltro.Text.Trim().ToLower();

            listaGruposFiltro = gruposFiltrados
                .Where(g =>
                (string.IsNullOrEmpty(nombreFiltro) || g.Nombre.ToLower().Contains(nombreFiltro))
                ).ToList();

            var datosAmostrar = listaGruposFiltro
            .Select(g => new
            {
                ID = g.GrupoId,
                Nombre = g.Nombre

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

        private void btn_quitarFiltro_Click(object sender, EventArgs e)
        {
            txt_nombreFiltro.Clear();

            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;

            ARMA_GRILLA();

            variF = "";
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Seleccione un grupo.", "ERROR");
                return;
            }

            indice = dataGridView1.CurrentRow.Index;
        }
    }
}
