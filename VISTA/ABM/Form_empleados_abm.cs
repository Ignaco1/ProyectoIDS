using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.ABM
{
    public partial class Form_empleados_abm : Form
    {
        CONTROLADORA.Controladora_empleados contro_emp = new CONTROLADORA.Controladora_empleados();

        public Form_empleados_abm()
        {
            InitializeComponent();
            ARMA_GRILLA();
            MODO_LISTA();

        }

        private void Form_empleados_abm_Load(object sender, EventArgs e)
        {

        }

        private void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;

            var empleado = contro_emp.ListarEmpleados()
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
    }
}
