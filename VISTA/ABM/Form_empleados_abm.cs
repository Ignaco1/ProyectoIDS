using CAPA_COMUN.Cache;
using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using Microsoft.EntityFrameworkCore;
using MODELO;
using MODELO.Auditoria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.ABM
{
    public partial class Form_empleados_abm : Form
    {
        CONTROLADORA.Controladora_empleados contro_emp = new CONTROLADORA.Controladora_empleados();
        CONTROLADORA.Controladora_grupos contro_grup = new CONTROLADORA.Controladora_grupos();
        string vari;
        int indice;
        string variF = "";
        private List<Empleado> listaEmpleadosFiltro = new List<Empleado>();

        public Form_empleados_abm()
        {
            InitializeComponent();
            ARMA_GRILLA();
            MODO_LISTA();

        }

        private void CargarCombos(bool esModificacion = false, string grupoActual = "")
        {
            cb_rol.Items.Clear();
            cb_rolFiltro.Items.Clear();

            var grupos = contro_grup.ListarGrupos();
            bool esSuperAdmin = UsuarioCache.UsuarioGrupoNombre.Equals("SuperAdministrador", StringComparison.OrdinalIgnoreCase);

            foreach (var grupo in grupos)
            {
                if (!grupo.Nombre.Equals("SuperAdministrador", StringComparison.OrdinalIgnoreCase))
                {
                    cb_rol.Items.Add(grupo.Nombre);
                }

                if (esSuperAdmin || !grupo.Nombre.Equals("SuperAdministrador", StringComparison.OrdinalIgnoreCase))
                {
                    cb_rolFiltro.Items.Add(grupo.Nombre);
                }
            }

            cb_rol.Items.AddRange(new object[] { "Mantenimiento", "Limpieza", "Seguridad" });
            cb_rolFiltro.Items.AddRange(new object[] { "Mantenimiento", "Limpieza", "Seguridad" });

            cb_turno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cb_turnoFiltro.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
        }

        private void Form_empleados_abm_Load(object sender, EventArgs e)
        {
            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;
            CargarCombos();
        }

        private void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;

            var empleado = contro_emp.ListarEmpleados()
                .Where(e => e.Activo)
                .Select(e => new
                {
                    ID = e.EmpleadoId,
                    Nombre = e.Nombre + " " + e.Apellido,
                    DNI = e.Dni,
                    e.Email,
                    e.Telefono,
                    e.Rol,
                    e.Turno
                }).ToList();

            dataGridView1.DataSource = empleado;

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
            txt_apellido.Text = "";
            txt_dni.Text = "";
            txt_email.Text = "";
            txt_telefono.Text = "";
            cb_rolFiltro.Text = "";
            cb_turnoFiltro.Text = "";
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un empleado.", "Error");
                return;
            }

            indice = dataGridView1.CurrentRow.Index;
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
                MessageBox.Show("Seleccione un empleado.", "Error");
                return;
            }

            vari = "M";
            MODELO.Empleado empleado;


            if (variF == "")
            {
                empleado = contro_emp.ListarEmpleados()[indice];
            }
            else
            {
                empleado = listaEmpleadosFiltro[indice];
            }

            txt_nombre.Text = empleado.Nombre;
            txt_apellido.Text = empleado.Apellido;
            txt_dni.Text = empleado.Dni;
            txt_email.Text = empleado.Email;
            txt_telefono.Text = empleado.Telefono;
            cb_rol.Text = empleado.Rol;
            cb_turno.Text = empleado.Turno;

            MODO_CARGA();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MODELO.Empleado empleado = null;

            #region VALIDACIONES


            if (string.IsNullOrWhiteSpace(txt_nombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del empleado.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_apellido.Text))
            {
                MessageBox.Show("Ingrese el apellido del empleado.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_dni.Text))
            {
                MessageBox.Show("Ingrese el DNI del empleado.", "Error");
                return;
            }

            if (!ValidaDni(txt_dni.Text))
            {
                MessageBox.Show("El DNI debe contener entre 7 y 8 dígitos.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MessageBox.Show("Ingrese el email del empleado.", "Error");
                return;
            }

            if (!ValidaEmial(txt_email.Text))
            {
                MessageBox.Show("El email ingresado no es válido. Ingrese un email valido\n\nEjemplo: Ignaciocarignano@gmail.com", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_telefono.Text))
            {
                MessageBox.Show("Ingrese el numero de telefono del empleado.", "Error");
                return;
            }

            if (!ValidaTelefono(txt_telefono.Text))
            {
                MessageBox.Show("El número de teléfono debe contener solo números y tener entre 6 y 15 dígitos.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(cb_rol.Text))
            {
                MessageBox.Show("Seleccione el rol del empleado.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(cb_turno.Text))
            {
                MessageBox.Show("Seleccione el turno del empleado.", "Error");
                return;
            }


            #endregion

            if (vari == "A")
            {
                if (!contro_emp.ValidaEmpleado(txt_dni.Text, txt_email.Text, 0))
                {
                    empleado = contro_emp.CrearEmpleado(txt_nombre.Text, txt_apellido.Text, txt_dni.Text, txt_email.Text, txt_telefono.Text, cb_rol.Text, cb_turno.Text);

                    try
                    {
                        string resultado = contro_emp.AgregarEmpleado(empleado);
                        MessageBox.Show(resultado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar el empleado: " + (ex.InnerException?.Message ?? ex.Message), "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Este empleado ya existe\n\nIntente con otro email o numero de DNI", "AVISO");
                    return;
                }
            }

            if (vari == "M")
            {

                if (variF == "")
                {
                    empleado = contro_emp.ListarEmpleados()[indice];
                }
                else
                {
                    empleado = listaEmpleadosFiltro[indice];
                }

                if (!contro_emp.ValidaEmpleado(txt_dni.Text, txt_email.Text, empleado.EmpleadoId))
                {
                    empleado.Nombre = txt_nombre.Text;
                    empleado.Apellido = txt_apellido.Text;
                    empleado.Dni = txt_dni.Text;
                    empleado.Email = txt_email.Text;
                    empleado.Telefono = txt_telefono.Text;
                    empleado.Rol = cb_rol.Text;
                    empleado.Turno = cb_turno.Text;

                    try
                    {
                        string resultado = contro_emp.ModificarEmpleado(empleado);
                        MessageBox.Show(resultado);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar el empleado:  " + ex.Message, "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Este empleado ya existe\n\nIntente con otro email o numero de DNI", "AVISO");
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
            MODO_LISTA();
            LIMPIAR();
        }

        private void btn_darDebaja_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un empleado.", "Error");
                return;
            }

            MODELO.Empleado empleado;

            if (variF == "")
            {
                empleado = contro_emp.ListarEmpleados()[indice];
            }
            else
            {
                empleado = listaEmpleadosFiltro[indice];
            }

            DialogResult resultado = MessageBox.Show($"Está seguro que desea dar de baja al empleado:\n\nNombre: {empleado.Nombre + " " + empleado.Apellido}\n\nDNI: {empleado.Dni}\n\nEmail: {empleado.Email}\n\nTelefono: {empleado.Telefono}\n\nTurno: {empleado.Turno}\n\nRol: {empleado.Rol}", "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    empleado.Activo = false;
                    string respuesta = contro_emp.ModificarEmpleado(empleado);
                    MessageBox.Show(respuesta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al dar de baja el empleado:  " + ex.Message, "ERROR");
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

        private void btn_quitarFiltro_Click(object sender, EventArgs e)
        {
            txt_dniFiltro.Clear();
            txt_nombreFiltro.Clear();
            txt_apellidoFiltro.Clear();
            cb_rolFiltro.SelectedIndex = -1;
            cb_turnoFiltro.SelectedIndex = -1;

            ARMA_GRILLA();

            variF = "";

            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;
        }

        private bool ValidaEmial(string email)
        {
            if (email.IndexOf('@') == -1 || email.IndexOf('@') != email.LastIndexOf('@'))
                return false;

            string[] partes = email.Split('@');

            if (partes.Length != 2)
                return false;

            string empleado = partes[0];
            string dominio = partes[1];

            if (string.IsNullOrWhiteSpace(empleado) || empleado.Contains(" "))
                return false;

            if (!Regex.IsMatch(empleado, @"^[a-zA-Z0-9._-]+$"))
                return false;

            if (!dominio.Contains('.'))
                return false;

            return true;
        }

        private bool ValidaTelefono(string telefono)
        {
            string limpio = telefono.Replace(" ", "").Replace("-", "");

            return Regex.IsMatch(limpio, @"^\d{6,15}$");
        }

        private bool ValidaDni(string dni)
        {

            return Regex.IsMatch(dni, @"^\d{7,8}$");
        }

        private void FILTRAR()
        {
            dataGridView1.DataSource = null;

            string dniFiltro = txt_dniFiltro.Text;
            string nombreFiltro = txt_nombreFiltro.Text.Trim().ToLower();
            string apellidoFiltro = txt_apellidoFiltro.Text.Trim().ToLower();
            string rolFiltro = cb_rolFiltro.Text;
            string turnoFiltro = cb_turnoFiltro.Text;

            listaEmpleadosFiltro = contro_emp.ListarEmpleados()
                .Where(c =>
                (string.IsNullOrEmpty(dniFiltro) || c.Dni.Contains(dniFiltro)) &&
                (string.IsNullOrEmpty(nombreFiltro) || c.Nombre.ToLower().Contains(nombreFiltro)) &&
                (string.IsNullOrEmpty(apellidoFiltro) || c.Apellido.ToLower().Contains(apellidoFiltro)) &&
                (string.IsNullOrEmpty(rolFiltro) || c.Rol.Contains(rolFiltro)) &&
                (string.IsNullOrEmpty(turnoFiltro) || c.Turno.Contains(turnoFiltro))
                ).ToList();

            var datosAmostrar = listaEmpleadosFiltro
                .Where(e => e.Activo)
                .Select(e => new
                {
                    ID = e.EmpleadoId,
                    Nombre = e.Nombre + " " + e.Apellido,
                    DNI = e.Dni,
                    e.Email,
                    e.Telefono,
                    e.Rol,
                    e.Turno
                }).ToList();

            dataGridView1.DataSource = datosAmostrar;

        }

        private void txt_dniFiltro_TextChanged(object sender, EventArgs e)
        {
            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
            variF = "F";
        }

        private void txt_nombreFiltro_TextChanged(object sender, EventArgs e)
        {
            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
            variF = "F";
        }

        private void txt_apellidoFiltro_TextChanged(object sender, EventArgs e)
        {
            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
            variF = "F";
        }

        private void cb_rolFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
            variF = "F";
        }

        private void cb_turnoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
            variF = "F";
        }
    }
}
