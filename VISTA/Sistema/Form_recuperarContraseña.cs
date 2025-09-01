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

namespace VISTA
{
    public partial class Form_recuperarContraseña : Form
    {
        CONTROLADORA.Controladora_usuarios contro_usu = new CONTROLADORA.Controladora_usuarios();
        public Form_recuperarContraseña()
        {
            InitializeComponent();
        }

        #region Mover form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form_recuperarContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel_imagen_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void Form_recuperarContraseña_Load_1(object sender, EventArgs e)
        {
            label_error.Visible = false;
            pictureBox_error.Visible = false;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private async void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_usuario.Text) && string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MostrarError("Por favor, complete ambos campos.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_usuario.Text))
            {
                MostrarError("Por favor, ingrese el nombre de usuario.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_email.Text))
            {
                MostrarError("Por favor, ingrese el email del usuario.");
                return;
            }

            if (contro_usu.ValidarUsuarioRecuperacion(txt_email.Text.Trim(), txt_usuario.Text.Trim()))
            {
                string email = txt_email.Text.Trim();
                string usuario = txt_usuario.Text.Trim();
                string resultado = await contro_usu.RecuperarContraseña(usuario, email);
                MessageBox.Show(resultado, "Recuperar Contraseña");

                this.Close();
            }
            else
            {
                MostrarError("El usuario o el email ingresado no son válidos.");
                return;
            }


        }

        private void MostrarError(string msj)
        {
            label_error.Text = msj;
            label_error.Visible = true;
            pictureBox_error.Visible = true;
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "USUARIO")
            {
                txt_usuario.Text = "";
            }
        }

        private void txt_usuario_Leave(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                txt_usuario.Text = "USUARIO";
            }
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if (txt_email.Text == "EMAIL")
            {
                txt_email.Text = "";
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                txt_email.Text = "EMAIL";
            }
        }

    }
}
