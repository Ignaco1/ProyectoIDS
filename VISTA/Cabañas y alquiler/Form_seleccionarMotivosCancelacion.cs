using MODELO;
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
    }
}
