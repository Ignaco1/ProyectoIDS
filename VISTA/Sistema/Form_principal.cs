using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_COMUN;
using CAPA_COMUN.Cache;
using MODELO;
using VISTA.ABM;
using VISTA.Cabañas_y_alquiler;
using VISTA.Informes;

namespace VISTA
{
    public partial class Form_principal : Form
    {
        CONTROLADORA.Controladora_usuarios contro_us = new CONTROLADORA.Controladora_usuarios();
        private System.Windows.Forms.Timer timerActualizarEstados;
        public Form_principal()
        {
            InitializeComponent();
            OcultarSubmenu();
            btn_restaurar.Visible = false;
        }

        #region Mover form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel_forms_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel_menuLateral_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel_logo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel_menuLateral_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void OcultarSubmenu()
        {
            panel_ABM.Visible = false;
            panel_seguridad.Visible = false;
            panel_reservas.Visible = false;
            panel_informes.Visible = false;
            panel_mantenimientos.Visible = false;
            panel_servicios.Visible = false;

        }


        private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                OcultarSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void HabilitarBotones(Control padres)
        {
            foreach (Control control in padres.Controls)
            {
                if (control is Button boton && boton.Tag != null)
                {
                    string permisos = boton.Tag.ToString();

                    boton.Enabled = UsuarioCache.Permisos.Any(p => p.Equals(permisos, StringComparison.OrdinalIgnoreCase));
                    boton.Visible = UsuarioCache.Permisos.Any(p => p.Equals(permisos, StringComparison.OrdinalIgnoreCase));
                }

                if (control.HasChildren)
                {
                    HabilitarBotones(control);
                }

            }

        }

        private void btn_minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_restaurar.Visible = true;
            btn_maximizar.Visible = false;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }

        private Form formActual = null;
        public void AbrirForms(Form formNuevo)
        {
            if (formActual != null)
            {
                formActual.Close();
            }

            formActual = formNuevo;

            formNuevo.TopLevel = false;
            formNuevo.FormBorderStyle = FormBorderStyle.None;
            formNuevo.Dock = DockStyle.Fill;
            panel_forms.Controls.Add(formNuevo);
            panel_forms.Tag = formNuevo;
            formNuevo.BringToFront();

            formNuevo.Show();
        }

        private void Form_principal_Load(object sender, EventArgs e)
        {
            CargarLabels();
            HabilitarBotones(this);
            IniciarTimerActualizador();
        }

        private void IniciarTimerActualizador()
        {
            timerActualizarEstados = new System.Windows.Forms.Timer();
            timerActualizarEstados.Interval = 10 * 60 * 1000;
            timerActualizarEstados.Tick += TimerActualizarEstados_Tick;
            timerActualizarEstados.Start();
        }

        private void TimerActualizarEstados_Tick(object sender, EventArgs e)
        {
            try
            {
                var contro_reser = new CONTROLADORA.Controladora_reservas();
                contro_reser.ActualizarEstadosReservas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar estados: " + ex.Message);
            }
        }

        private void CargarLabels()
        {
            lb_nombre.Text = UsuarioCache.UsuarioNombre + " " + UsuarioCache.UsuarioApellido;
            lb_email.Text = UsuarioCache.UsuarioEmail;
            lbl_usuario.Text = UsuarioCache.UsuarioNombre_usuario;
            lb_grupo.Text = UsuarioCache.UsuarioGrupoNombre;
        }


        private void btn_ABM_Click(object sender, EventArgs e)
        {
            HabilitarBotones(this);
            MostrarSubmenu(panel_ABM);
        }

        private void btn_cabañas_alquiler_Click(object sender, EventArgs e)
        {
            HabilitarBotones(this);
            MostrarSubmenu(panel_reservas);
        }

        private void btn_informes_Click(object sender, EventArgs e)
        {
            HabilitarBotones(this);
            MostrarSubmenu(panel_informes);
        }


        private void btn_ABM_usuarios_Click(object sender, EventArgs e)
        {
            AbrirForms(new Form_usuarios_abm());
        }

        private void btn_cerrar_Click_1(object sender, EventArgs e)
        {
            var usuario = contro_us.ObtenerUsuarioId(UsuarioCache.UsuarioId);

            if (usuario.PrimerIngreso == true)
            {
                MessageBox.Show("Antes de salir usted debe cambiar su contraseña desde la parte de ajustes.\n\nGracias.", "AVISO");
                return;
            }

            using (var context = new Context())
            {
                var auditoria = context.UsuariosAuditoria
                    .Where(a => a.IdUsuario == UsuarioCache.UsuarioId && a.FechaLogout == null)
                    .OrderByDescending(a => a.FechaLogin)
                    .FirstOrDefault();

                if (auditoria != null)
                {
                    auditoria.FechaLogout = DateTime.Now;
                    auditoria.IdMovimiento = 2;
                    auditoria.TipoMovimiento = "LOGIN/LOGOUT";
                    context.SaveChanges();
                }
            }

            Application.Exit();
        }


        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            var usuario = contro_us.ObtenerUsuarioId(UsuarioCache.UsuarioId);

            if (usuario.PrimerIngreso == true)
            {
                MessageBox.Show("Antes de salir usted debe cambiar su contraseña desde la parte de ajustes.\n\nGracias.", "AVISO");
                return;
            }

            var resultado = MessageBox.Show("Esta seguro que desea cerrar sesión?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                using (var context = new Context())
                {
                    var auditoria = context.UsuariosAuditoria
                        .Where(a => a.IdUsuario == UsuarioCache.UsuarioId && a.FechaLogout == null)
                        .OrderByDescending(a => a.FechaLogin)
                        .FirstOrDefault();

                    if (auditoria != null)
                    {
                        auditoria.FechaLogout = DateTime.Now;
                        auditoria.IdMovimiento = 2;
                        auditoria.TipoMovimiento = "LOGIN/LOGOUT";
                        context.SaveChanges();
                    }
                }

                this.Close();
            }

        }

        private void btn_seguridad_Click(object sender, EventArgs e)
        {
            HabilitarBotones(this);
            MostrarSubmenu(panel_seguridad);
        }

        private void btn_reservas_Click(object sender, EventArgs e)
        {
            AbrirForms(new Form_desplegarCabañas());
        }

        private void btn_gestionar_grupos_Click(object sender, EventArgs e)
        {
            AbrirForms(new Form_gestionarGrupos());
        }

        private void btn_asignarPermisos_Click(object sender, EventArgs e)
        {
            AbrirForms(new Form_asignarPermisos());
        }

        private void btn_gestionar_permisos_Click(object sender, EventArgs e)
        {
            AbrirForms(new Form_gestionarPermisos());
        }

        private void btn_ABM_clientes_Click(object sender, EventArgs e)
        {
            AbrirForms(new Form_clientes_abm());
        }

        private void btn_ajustes_Click(object sender, EventArgs e)
        {
            AbrirForms(new Form_ajustesUsuario());
        }

        private void btn_ABM_cabañas_Click(object sender, EventArgs e)
        {
            AbrirForms(new Form_cabañas_abm());
        }

        private void btn_ver_reservas_Click(object sender, EventArgs e)
        {
            AbrirForms(new Form_verReservas());
        }

        private void btn_motivosCancelacion_Click(object sender, EventArgs e)
        {
            AbrirForms(new Form_motivosCancelacionInformes());
        }

        private void btn_servicios_Click(object sender, EventArgs e)
        {
            HabilitarBotones(this);
            MostrarSubmenu(panel_servicios);
        }

        private void btn_mantenimientos_Click(object sender, EventArgs e)
        {
            HabilitarBotones(this);
            MostrarSubmenu(panel_mantenimientos);
        }

        private void btn_empleados_abm_Click(object sender, EventArgs e)
        {
            AbrirForms(new Form_empleados_abm());
        }

        private void btn_servicios_abm_Click(object sender, EventArgs e)
        {
            AbrirForms(new Form_servicios_abm());
        }
    }
}

