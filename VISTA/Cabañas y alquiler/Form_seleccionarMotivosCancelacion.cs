using MODELO;
using MODELO.Composite;
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

namespace VISTA.Cabañas_y_alquiler
{
    public partial class Form_seleccionarMotivosCancelacion : Form
    {
        CONTROLADORA.Controladora_motivos contro_moti = new CONTROLADORA.Controladora_motivos();
        CONTROLADORA.Controladora_reservas contro_reserv = new CONTROLADORA.Controladora_reservas();
        private Reserva reserva;
        public bool MotivosAsignadosCorrectamente { get; private set; } = false;

        public Form_seleccionarMotivosCancelacion(Reserva reservaSeleccionada)
        {
            InitializeComponent();
            reserva = reservaSeleccionada;
        }

        private void Form_seleccionarMotivosCancelacion_Load(object sender, EventArgs e)
        {
            checkedListBox_motivos.Items.Clear();

            var motivos = contro_moti.ListarMotivos();

            foreach (var motivo in motivos)
            {
                checkedListBox_motivos.Items.Add(motivo, false);
            }
        }

        #region Mover form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form_seleccionarMotivosCancelacion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            var motivosSeleccionados = checkedListBox_motivos.CheckedItems.OfType<MotivoCancelacion>().ToList();

            if (motivosSeleccionados.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un motivo.", "Error");
                return;
            }

            try
            {

                string respuesta = contro_reserv.AgregarMotivoACancelacion(reserva.ReservaId, motivosSeleccionados);
                MessageBox.Show(respuesta);
                MotivosAsignadosCorrectamente = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los motivos: " + ex.Message);
            }

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
