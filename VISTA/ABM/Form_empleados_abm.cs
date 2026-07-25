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
        CONTROLADORA.Controladora_Roles_Empleados contro_rol = new CONTROLADORA.Controladora_Roles_Empleados();
        CONTROLADORA.Controladora_usuarios contro_us = new CONTROLADORA.Controladora_usuarios();
        string vari;
        int indice;
        string variF = "";
        private bool _actualizandoCheck = false;
        private List<Empleado> listaEmpleadosFiltro = new List<Empleado>();

        public Empleado EmpleadoSeleccionado { get; private set; }
        public bool ModoSeleccion { get; set; } = false;
        public bool SoloRolesMantenimiento { get; set; } = false;

        public Form_empleados_abm()
        {
            InitializeComponent();
            check_listaRoles.ItemCheck += check_listaRoles_ItemCheck;
            ARMA_GRILLA();
            MODO_LISTA();

        }

        private bool EsRolDeMantenimiento(RolEmpleado rol) => rol.EsOperativo && rol.EsMantenimiento;

        private void CargarCombos(bool esModificacion = false, string grupoActual = "")
        {
            cb_rolFiltro.Items.Clear();
            check_listaRoles.Items.Clear();


            var roles = contro_rol.ListarRoles().Where(r => r.Activo).ToList();

            if (SoloRolesMantenimiento)
            {
                roles = roles.Where(EsRolDeMantenimiento).ToList();
                panel_barra_roles.Visible = false;
            }

            foreach (var rol in roles)
            {
                cb_rolFiltro.Items.Add(rol);
                check_listaRoles.Items.Add(rol, false);
            }

            cb_turno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cb_turnoFiltro.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
        }

        private void Form_empleados_abm_Load(object sender, EventArgs e)
        {
            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;
            CargarCombos();
            ARMA_GRILLA();
        }

        private void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;

            var empleado = contro_emp.ListarEmpleados()
                .Where(e => e.Activo)
                .Where(e => !SoloRolesMantenimiento || EsRolDeMantenimiento(e.RolEmpleado))
                .Select(e => new
                {
                    ID = e.EmpleadoId,
                    Nombre = e.Nombre + " " + e.Apellido,
                    DNI = e.Dni,
                    e.Email,
                    e.Telefono,
                    Rol = e.RolEmpleado.Nombre,
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

            for (int i = 0; i < check_listaRoles.Items.Count; i++)
            {
                check_listaRoles.SetItemChecked(i, false);
            }
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
            cb_turno.Text = empleado.Turno;

            check_listaRoles.Items.Clear();

            var todosLosRoles = contro_rol.ListarRoles().Where(r => r.Activo).ToList();

            foreach (var rol in todosLosRoles)
            {
                bool estaAsignado = rol.RolEmpleadoId == empleado.RolEmpleadoId;
                check_listaRoles.Items.Add(rol, estaAsignado);
            }

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

            var roles = check_listaRoles.CheckedItems.OfType<RolEmpleado>().ToList();

            if (roles.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un rol para el empleado.", "Error");
                return;
            }

            if (roles.Count > 1)
            {
                MessageBox.Show("Solo debe seleccionar un rol para el empleado, no más de eso.", "Error");
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
                    var rolSel = roles[0];
                    empleado = contro_emp.CrearEmpleado(txt_nombre.Text, txt_apellido.Text, txt_dni.Text, txt_email.Text, txt_telefono.Text, rolSel.RolEmpleadoId, cb_turno.Text);

                    bool guardadoExitoso = false;
                    try
                    {
                        string resultado = contro_emp.AgregarEmpleado(empleado);
                        MessageBox.Show(resultado);
                        guardadoExitoso = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar el empleado: " + (ex.InnerException?.Message ?? ex.Message), "ERROR");
                    }

                    if (guardadoExitoso && !rolSel.EsOperativo)
                    {
                        var formUsuarios = new VISTA.Form_usuarios_abm(txt_nombre.Text, txt_apellido.Text, txt_email.Text, rolSel.Nombre);
                        formUsuarios.StartPosition = FormStartPosition.CenterScreen;
                        formUsuarios.ShowDialog();
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
                    var rolAnterior = empleado.RolEmpleado;
                    var rolNuevo = roles[0];

                    empleado.Nombre = txt_nombre.Text;
                    empleado.Apellido = txt_apellido.Text;
                    empleado.Dni = txt_dni.Text;
                    empleado.Email = txt_email.Text;
                    empleado.Telefono = txt_telefono.Text;
                    empleado.Turno = cb_turno.Text;

                    try
                    {
                        string resultado = contro_emp.ModificarEmpleado(empleado);
                        contro_emp.AsignarRolAEmpleado(empleado.EmpleadoId, roles);
                        MessageBox.Show(resultado);

                        ManejarCambioDeRolUsuario(rolAnterior, rolNuevo, empleado);
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

            DialogResult resultado = MessageBox.Show($"Está seguro que desea dar de baja al empleado:\n\nNombre: {empleado.Nombre + " " + empleado.Apellido}\n\nDNI: {empleado.Dni}\n\nEmail: {empleado.Email}\n\nTelefono: {empleado.Telefono}\n\nTurno: {empleado.Turno}\n\nRol: {empleado.RolEmpleado?.Nombre}", "AVISO", MessageBoxButtons.YesNo);

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
            var rolFiltroSel = cb_rolFiltro.SelectedItem as RolEmpleado;
            string turnoFiltro = cb_turnoFiltro.Text;

            listaEmpleadosFiltro = contro_emp.ListarEmpleados()
                .Where(c =>
                (string.IsNullOrEmpty(dniFiltro) || c.Dni.Contains(dniFiltro)) &&
                (string.IsNullOrEmpty(nombreFiltro) || c.Nombre.ToLower().Contains(nombreFiltro)) &&
                (string.IsNullOrEmpty(apellidoFiltro) || c.Apellido.ToLower().Contains(apellidoFiltro)) &&
                (rolFiltroSel == null || c.RolEmpleadoId == rolFiltroSel.RolEmpleadoId) &&
                (string.IsNullOrEmpty(turnoFiltro) || c.Turno.Contains(turnoFiltro)) &&
                (!SoloRolesMantenimiento || EsRolDeMantenimiento(c.RolEmpleado))
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
                    Rol = e.RolEmpleado.Nombre,
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!ModoSeleccion)
                return;

            if (dataGridView1.CurrentRow != null)
            {
                Empleado empleado;

                if (variF == "")
                    empleado = contro_emp.ListarEmpleados()
                        .Where(x => x.Activo)
                        .Where(x => !SoloRolesMantenimiento || EsRolDeMantenimiento(x.RolEmpleado))
                        .ToList()[dataGridView1.CurrentRow.Index];
                else
                    empleado = listaEmpleadosFiltro
                        .Where(x => x.Activo)
                        .ToList()[dataGridView1.CurrentRow.Index];

                EmpleadoSeleccionado = empleado;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void check_listaRoles_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_actualizandoCheck) return;
            if (e.NewValue == CheckState.Checked)
            {
                _actualizandoCheck = true;
                for (int i = 0; i < check_listaRoles.Items.Count; i++)
                {
                    if (i != e.Index)
                        check_listaRoles.SetItemChecked(i, false);
                }
                _actualizandoCheck = false;
            }
        }

        private void ManejarCambioDeRolUsuario(RolEmpleado rolAnterior, RolEmpleado rolNuevo, MODELO.Empleado empleado)
        {
            if (rolAnterior == null || rolNuevo == null) return;
            if (rolAnterior.RolEmpleadoId == rolNuevo.RolEmpleadoId) return;

            if (!rolAnterior.EsOperativo && rolNuevo.EsOperativo)
            {
                MessageBox.Show($"El empleado {empleado.Nombre} {empleado.Apellido} (DNI: {empleado.Dni}) ya no es un usuario del sistema.", "AVISO");

                var formUsuarios = new VISTA.Form_usuarios_abm();
                formUsuarios.StartPosition = FormStartPosition.CenterScreen;
                formUsuarios.ShowDialog();
                return;
            }

            if (!rolAnterior.EsOperativo && !rolNuevo.EsOperativo)
            {
                var usuarioExistente = contro_us.ListarUsuarios()
                    .FirstOrDefault(u => u.Email.Equals(empleado.Email, StringComparison.OrdinalIgnoreCase));

                if (usuarioExistente == null)
                {
                    MessageBox.Show($"No se encontró el usuario del sistema asociado al empleado {empleado.Nombre} {empleado.Apellido}. Verifique manualmente.", "AVISO");
                    return;
                }

                var formUsuarios = new VISTA.Form_usuarios_abm(usuarioExistente, rolNuevo.Nombre);
                formUsuarios.StartPosition = FormStartPosition.CenterScreen;
                formUsuarios.ShowDialog();
                return;
            }

            if (rolAnterior.EsOperativo && !rolNuevo.EsOperativo)
            {
                var formUsuarios = new VISTA.Form_usuarios_abm(empleado.Nombre, empleado.Apellido, empleado.Email, rolNuevo.Nombre);
                formUsuarios.StartPosition = FormStartPosition.CenterScreen;
                formUsuarios.ShowDialog();
                return;
            }
        }
    }
}
