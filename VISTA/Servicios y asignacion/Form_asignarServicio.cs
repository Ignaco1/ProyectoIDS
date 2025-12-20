using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.Servicios_y_asignacion
{
    public partial class Form_asignarServicio : Form
    {
        public Form_asignarServicio()
        {
            InitializeComponent();
        }

        private void Form_asignarServicio_Load(object sender, EventArgs e)
        {

        }

        //public void Configurar(string nombre, int capacidad, decimal precio, string descripcion, List<byte[]> imagenesBytes, int idCabaña)
        //{
        //    lb_nombre.Text = nombre;
        //    lb_capacidad.Text = $"Capacidad: {capacidad}";
        //    lb_precio.Text = $"Precio por noche: ${precio}";

        //    string descripcionFormateada = FormatearDescripcion(descripcion, 7);
        //    lb_descripcion.Text = $"Descripción:\n\n{descripcionFormateada}";

        //    imagenes = imagenesBytes;

        //    idCabañaSeleccionada = idCabaña;

        //    if (imagenes.Count > 0)
        //    {
        //        indiceImagenActual = 0;
        //        MostrarImagenActual();
        //    }

        //    CargarFechasOcupadas();
        //}
    }
}
