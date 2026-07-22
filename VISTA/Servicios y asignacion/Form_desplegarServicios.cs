using MODELO;
using MODELO.State;
using System;
using System.Collections;
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
    public partial class Form_desplegarServicios : Form
    {
        CONTROLADORA.Controladora_Servicios contro_ser = new CONTROLADORA.Controladora_Servicios();
        CONTROLADORA.Controladora_AsignacionesServicio contro_asig = new CONTROLADORA.Controladora_AsignacionesServicio();
        private List<Servicio> listaServiciosFiltro = new List<Servicio>();
        private bool formCargado = false;
        public Form_desplegarServicios()
        {
            InitializeComponent();

        }

        private void Form_desplegarServicios_Load(object sender, EventArgs e)
        {
            formCargado = false;

            ARMAR();

            dtp_fechaSeleccionada.Value = DateTime.Today;
            horaPicker.Value = DateTime.Today.AddHours(10);
            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;

            formCargado = true;
        }

        private void ARMAR()
        {
            var todosLosServicios = contro_ser.ListarServicios().ToList();
            CargarServicios(todosLosServicios);
        }

        private void LIMPIAR()
        {
            txt_nombreFiltro.Clear();
            txt_importeFiltro.Clear();

            dtp_fechaSeleccionada.Value = DateTime.Today;
            horaPicker.Value = DateTime.Today.AddHours(10);
        }

        private void CargarServicios(List<Servicio> lista)
        {
            flp_servicios.Controls.Clear();

            foreach (var servicio in lista)
            {
                var tarjeta = new UC_Servicio();
                tarjeta.ServicioNombre = servicio.Nombre;
                tarjeta.DatosServicio = servicio;

                var imagenes = servicio.Imagenes.Select(i => i.Imagen).ToList();

                tarjeta.Configurar(servicio.Nombre, servicio.Importe, servicio.Descripcion, imagenes);

                tarjeta.SetAbrirFormulario(form =>
                {
                    if (this.ParentForm is Form_principal fPrincipal)
                    {
                        form.FormClosed += (s, ev) =>
                        {
                            if (form is Form_asignarServicio fra)
                            {

                            }
                            else
                            {
                                fPrincipal.AbrirForms(new Form_desplegarServicios());
                            }
                        };

                        form.Owner = fPrincipal;
                        fPrincipal.AbrirForms(form);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el formulario principal.");
                    }
                });

                flp_servicios.Controls.Add(tarjeta);
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_quitarFiltro_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            ARMAR();
            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;
        }

        private void ServiciosFiltro()
        {
            string nombreFiltro = txt_nombreFiltro.Text.Trim().ToLower();
            bool filtrarImporte = decimal.TryParse(txt_importeFiltro.Text, out decimal importeFiltro);

            DateTime fechaSeleccionada = dtp_fechaSeleccionada.Value.Date;
            TimeSpan horaSeleccionada = horaPicker.Value.TimeOfDay;

            var serviciosOcupados = contro_asig.ListarAsignaciones()
                .Where(a => a.EstadoActual is not EstadoAsignacionCancelada && a.Fecha.Date == fechaSeleccionada && a.Hora == horaSeleccionada)
                .Select(a => a.ServicioId)
                .ToHashSet();

            listaServiciosFiltro = contro_ser.ListarServicios()
                .Where(s =>
                    (string.IsNullOrEmpty(nombreFiltro) || s.Nombre.ToLower().Contains(nombreFiltro)) &&
                    (!filtrarImporte || s.Importe <= importeFiltro) &&
                    !serviciosOcupados.Contains(s.ServicioId)
                ).ToList();

            CargarServicios(listaServiciosFiltro);

        }

        private void txt_nombreFiltro_TextChanged(object sender, EventArgs e)
        {
            ServiciosFiltro();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
        }

        private void txt_precioNocheFiltro_TextChanged(object sender, EventArgs e)
        {
            ServiciosFiltro();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
        }

        private void dtp_fechaSeleccionada_ValueChanged(object sender, EventArgs e)
        {
            if (!formCargado) return;

            ServiciosFiltro();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
        }

        private void horaPicker_ValueChanged(object sender, EventArgs e)
        {
            if (!formCargado) return;

            ServiciosFiltro();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
        }
    }
}
