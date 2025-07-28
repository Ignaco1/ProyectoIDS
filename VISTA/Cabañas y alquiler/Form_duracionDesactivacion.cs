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
    public partial class Form_duracionDesactivacion : Form
    {
        public int Cantidad { get; private set; }

        public Form_duracionDesactivacion()
        {
            InitializeComponent();
        }

        private void Form_duracionDesactivacion_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Cantidad = (int)numericUpDown_dias.Value;

            if (Cantidad <= 0)
            {
                MessageBox.Show("Ingrese una duración válida.");
                return;
            }

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
