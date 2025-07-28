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
        public Form_seleccionarMotivosCancelacion()
        {
            InitializeComponent();
        }

        private void Form_seleccionarMotivosCancelacion_Load(object sender, EventArgs e)
        {
            checkedListBox_motivos.Items.Clear();


        }
    }
}
