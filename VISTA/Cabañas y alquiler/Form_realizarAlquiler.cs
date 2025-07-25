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
    public partial class Form_realizarAlquiler : Form
    {
        public bool AlquilerConfirmado { get; private set; } = false;

        public Form_realizarAlquiler()
        {
            InitializeComponent();
        }

        private void Form_realizarAlquiler_Load(object sender, EventArgs e)
        {
            if (this.Owner == null)
            {
                MessageBox.Show("El Owner no fue seteado.");
            }
        }

        private void btn_realizarReserva_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alquiler registrado correctamente.");
            AlquilerConfirmado = true;
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (this.Owner is Form_principal fPrincipal)
            {
                fPrincipal.AbrirForms(new Form_desplegarCabañas());
            }

            this.Close();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            if (this.Owner is Form_principal fPrincipal)
            {
                fPrincipal.AbrirForms(new Form_desplegarCabañas());
            }

            this.Close();
        }
    }
}
