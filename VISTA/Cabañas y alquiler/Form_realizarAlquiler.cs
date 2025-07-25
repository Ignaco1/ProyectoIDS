using MODELO;
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
        private List<byte[]> imagenes = new List<byte[]>();
        private int indiceImagenActual = 0;
        CONTROLADORA.Controladora_clientes contro_cli = new CONTROLADORA.Controladora_clientes();
        CONTROLADORA.Controladora_cabañas contro_caba = new CONTROLADORA.Controladora_cabañas();
        CONTROLADORA.Controladora_reservas contro_reser = new CONTROLADORA.Controladora_reservas();
        private int idCabañaSeleccionada;
        public Form_realizarAlquiler()
        {
            InitializeComponent();
        }

        private void Form_realizarAlquiler_Load(object sender, EventArgs e)
        {
            var clientes = contro_cli.ListarClientes();

            foreach (var cliente in clientes)
            {
                cb_clientes.Items.Add(cliente.Nombre + " " + cliente.Apellido + " - " + " (DNI: " + cliente.Dni + ")");
            }
        }

        private void btn_realizarReserva_Click(object sender, EventArgs e)
        {
            DateTime fechaEntrada = mc_fechas.SelectionStart.Date;
            DateTime fechaSalida = mc_fechas.SelectionEnd.Date;

            MessageBox.Show("Alquiler registrado correctamente.");
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

        public void Configurar(string nombre, int capacidad, decimal precio, string descripcion, List<byte[]> imagenesBytes, int idCabaña)
        {
            lb_nombre.Text = nombre;
            lb_capacidad.Text = $"Capacidad: {capacidad}";
            lb_precio.Text = $"Precio por noche: ${precio}";

            string descripcionFormateada = FormatearDescripcion(descripcion, 7); 
            lb_descripcion.Text = $"Descripción:\n\n{descripcionFormateada}";

            imagenes = imagenesBytes;

            idCabañaSeleccionada = idCabaña;

            if (imagenes.Count > 0)
            {
                indiceImagenActual = 0;
                MostrarImagenActual();
            }

            CargarFechasOcupadas();
        }

        private void MostrarImagenActual()
        {
            if (imagenes.Count == 0) return;

            using (var ms = new MemoryStream(imagenes[indiceImagenActual]))
            {
                pb_imagenes.Image = Image.FromStream(ms);
            }
        }

        private void CargarFechasOcupadas()
        {
            var reservas = contro_reser.ListarReservas().Where(r => r.IdCabaña == idCabañaSeleccionada).ToList();

            List<DateTime> fechasOcupadas = new List<DateTime>();

            foreach (var reserva in reservas)
            {
                DateTime fecha = reserva.FechaEntrada.Date;

                while (fecha <= reserva.FechaSalida.Date)
                {
                    fechasOcupadas.Add(fecha);
                    fecha = fecha.AddDays(1);
                }
            }

            mc_fechas.BoldedDates = fechasOcupadas.ToArray();
        }


        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (imagenes.Count == 0) return;

            indiceImagenActual = (indiceImagenActual + 1) % imagenes.Count;
            MostrarImagenActual();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (imagenes.Count == 0) return;

            indiceImagenActual = (indiceImagenActual - 1 + imagenes.Count) % imagenes.Count;
            MostrarImagenActual();
        }

        private string FormatearDescripcion(string descripcion, int palabrasPorLinea)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                return "";

            var palabras = descripcion.Split(' ');
            var resultado = new StringBuilder();

            for (int i = 0; i < palabras.Length; i++)
            {
                resultado.Append(palabras[i]);
                resultado.Append(" ");

                if ((i + 1) % palabrasPorLinea == 0)
                {
                    resultado.AppendLine();
                }
            }

            return resultado.ToString().Trim();
        }
    }
}
