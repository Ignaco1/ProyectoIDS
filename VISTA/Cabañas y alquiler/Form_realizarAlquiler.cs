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
                cb_clientes.Items.Add(cliente);
            }
            CargarFechasOcupadas();

        }

        private void btn_realizarReserva_Click(object sender, EventArgs e)
        {
            MODELO.Reserva reserva = null;

            #region VALIDACIONES

            if (string.IsNullOrWhiteSpace(cb_clientes.Text))
            {
                MessageBox.Show("Seleccione a un cliente para realizar la reserva.", "Error");
                return;
            }

            DateTime fechaEntrada = mc_fechas.SelectionStart.Date;
            DateTime fechaSalida = mc_fechas.SelectionEnd.Date;

            if (mc_fechas.SelectionStart == mc_fechas.SelectionEnd)
            {
                MessageBox.Show("Debe seleccionar un rango de fechas para la reserva (entrada y salida).", "Error");
                return;
            }

            if (fechaEntrada > fechaSalida)
            {
                MessageBox.Show("La fecha de entrada no puede ser posterior a la de salida.", "Error");
                return;
            }

            Cabaña cabaña = contro_caba.ObtenerCabañaId(idCabañaSeleccionada);

            if (cabaña == null)
            {
                MessageBox.Show("No se pudo encontrar la cabaña seleccionada.", "Error");
                return;
            }

            #endregion


            Cliente cliente = cb_clientes.SelectedItem as Cliente;

            decimal precioTotal = ObtenerPrecioTotal(cabaña, fechaEntrada, fechaSalida);

            reserva = contro_reser.CrearReserva(idCabañaSeleccionada, cliente.ClienteId, fechaEntrada, fechaSalida, precioTotal);

            bool esValida = contro_reser.ValidaReserva(cabaña, fechaEntrada, fechaSalida, reserva.ReservaId);

            if (!esValida)
            {
                MessageBox.Show("Ya existe una reserva para esta cabaña en el rango de fechas seleccionado. O la cabaña se encuentra en reparación", "Error");
                return;
            }

            try
            {
                string respuesta = contro_reser.AgregarReserva(reserva);
                contro_reser.ActualizarEstadosReservas();
                MessageBox.Show(respuesta);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la reserva:  " + ex.Message, "Error");
            }

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
            List<DateTime> fechasOcupadas = new List<DateTime>();

            var cabaña = contro_caba.ObtenerCabañaId(idCabañaSeleccionada);

            if (cabaña == null)
                return;

            var reservas = contro_reser.ListarReservas()
                .Where(r => r.IdCabaña == idCabañaSeleccionada && r.Estado != "Cancelada")
                .ToList();

            DateTime hoy = DateTime.Today;


            foreach (var reserva in reservas)
            {

                if (!cabaña.Activa && cabaña.FechaFinDesactivacion.HasValue &&
                    reserva.FechaEntrada <= cabaña.FechaFinDesactivacion.Value)
                {
                    continue; 
                }

                DateTime fecha = reserva.FechaEntrada.Date;

                while (fecha <= reserva.FechaSalida.Date)
                {
                    fechasOcupadas.Add(fecha);
                    fecha = fecha.AddDays(1);
                }
            }

            if (!cabaña.Activa && cabaña.FechaFinDesactivacion.HasValue)
            {
                DateTime fin = cabaña.FechaFinDesactivacion.Value;

                if (hoy <= fin)
                {
                    for (DateTime fecha = hoy; fecha <= fin; fecha = fecha.AddDays(1))
                    {
                        fechasOcupadas.Add(fecha);
                    }
                }
            }

            mc_fechas.BoldedDates = fechasOcupadas.Distinct().OrderBy(d => d).ToArray();
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

        private decimal ObtenerPrecioTotal(Cabaña cabaña, DateTime fecha_entrada, DateTime fecha_salida)
        {
            int cantidadNoches = (fecha_salida - fecha_entrada).Days + 1;

            if (cantidadNoches <= 0)
                return 0;

            return cantidadNoches * cabaña.PrecioPorNoche;
        }

        private void mc_fechas_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (mc_fechas.BoldedDates.Contains(e.Start))
            {
                MessageBox.Show("No se puede seleccionar esta fecha. La cabaña ya está ocupada o está desactivada.", "Error");
                return;
            }
        }
    }
}
