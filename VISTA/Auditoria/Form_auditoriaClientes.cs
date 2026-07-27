using MODELO.Auditoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VISTA
{
    public partial class Form_auditoriaClientes : Form
    {
        CONTROLADORA.Controladora_auditoria contro_aud = new CONTROLADORA.Controladora_auditoria();
        private const int LIMITE_MOVIMIENTOS_MOSTRADOS = 100;

        private List<ClienteAuditoria> auditoriaCompleta = new List<ClienteAuditoria>();
        private List<ClienteAuditoria> auditoriaMostrada = new List<ClienteAuditoria>();

        private bool filtrarPorFecha = false;
        private bool filtrarPorHora = false;

        public Form_auditoriaClientes()
        {
            InitializeComponent();
            ARMA_GRILLA();
        }

        private void Form_auditoriaClientes_Load(object sender, EventArgs e)
        {
            cb_movimientoFiltro.Items.Clear();
            cb_movimientoFiltro.Items.AddRange(new string[] { "ALTA", "MODIFICACIÓN", "BAJA" });
            cb_movimientoFiltro.SelectedIndex = -1;

            dtp_fechaFiltro.Value = DateTime.Today;
            dtp_horaFiltro.Value = DateTime.Today;

            filtrarPorFecha = false;
            filtrarPorHora = false;

            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;

            ARMA_GRILLA();
            AccesoUI.AplicarPermisos(this);
        }

        private void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;

            auditoriaCompleta = contro_aud.ListarAuditoriaClientes().ToList();
            auditoriaMostrada = auditoriaCompleta.Take(LIMITE_MOVIMIENTOS_MOSTRADOS).ToList();

            dataGridView1.DataSource = ArmarFilas(auditoriaMostrada);
        }

        private List<object> ArmarFilas(List<ClienteAuditoria> auditorias)
        {
            return auditorias
                .Select(a => new
                {
                    ID_Movimiento = a.ClienteAuditoriaId,
                    ID_Cliente = a.IdCliente,
                    Nombre = a.Nombre,
                    Apellido = a.Apellido,
                    DNI = a.Dni,
                    a.Email,
                    a.Telefono,
                    ID_Usuario = a.IdUsuario,
                    Usuario = a.Usuario?.Nombre_usuario ?? a.NombreUsuario,
                    Fecha_Movimiento = a.FechaMovimiento.ToString("dd/MM/yyyy"),
                    Hora_Movimiento = a.FechaMovimiento.ToString("HH:mm:ss"),
                    Movimiento = a.TipoMovimiento
                })
                .Cast<object>()
                .ToList();
        }

        private void FILTRAR()
        {
            string usuarioFiltro = txt_nombreUsuarioFiltro.Text.Trim().ToLower();
            string movimientoFiltro = cb_movimientoFiltro.Text.Trim();

            DateTime fechaFiltro = dtp_fechaFiltro.Value.Date;
            int horaFiltro = dtp_horaFiltro.Value.Hour;

            auditoriaMostrada = auditoriaCompleta
                .Where(a =>
                    (string.IsNullOrEmpty(usuarioFiltro) || (a.Usuario?.Nombre_usuario ?? a.NombreUsuario).ToLower().Contains(usuarioFiltro)) &&
                    (string.IsNullOrEmpty(movimientoFiltro) || (a.TipoMovimiento ?? "").Equals(movimientoFiltro, StringComparison.OrdinalIgnoreCase)) &&
                    (!filtrarPorFecha || a.FechaMovimiento.Date == fechaFiltro) &&
                    (!filtrarPorHora || a.FechaMovimiento.Hour == horaFiltro)
                )
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ArmarFilas(auditoriaMostrada);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un movimiento.", "Error");
                return;
            }

            int indice = dataGridView1.CurrentRow.Index;
            ClienteAuditoria auditoria = auditoriaMostrada[indice];

            string nombreUsuario = auditoria.Usuario?.Nombre_usuario ?? auditoria.NombreUsuario;
            string nombreApellidoUsuario = auditoria.Usuario != null
                ? $"{auditoria.Usuario.Nombre} {auditoria.Usuario.Apellido}"
                : auditoria.NombreUsuario;

            MessageBox.Show(
                $"Datos de movimiento:\n\n\n" +
                $"ID de movimiento: {auditoria.ClienteAuditoriaId}\n\n\n" +
                $"ID de cliente: {auditoria.IdCliente}\n\n" +
                $"Nombre y apellido: {auditoria.Nombre} {auditoria.Apellido}\n\n" +
                $"DNI: {auditoria.Dni}\n\n" +
                $"Email: {auditoria.Email}\n\n" +
                $"Teléfono: {auditoria.Telefono}\n\n\n" +
                $"ID de usuario: {auditoria.IdUsuario}\n\n" +
                $"Nombre de usuario: {nombreUsuario}\n\n" +
                $"Nombre y apellido: {nombreApellidoUsuario}\n\n\n" +
                $"Fecha y hora del movimiento: {auditoria.FechaMovimiento:dd/MM/yyyy HH:mm:ss}\n\n\n" +
                $"Movimiento realizado: {auditoria.TipoMovimiento}",
                "Detalle de auditoría");
        }

        private void btn_quitarFiltro_Click(object sender, EventArgs e)
        {
            txt_nombreUsuarioFiltro.Clear();
            cb_movimientoFiltro.SelectedIndex = -1;
            dtp_fechaFiltro.Value = DateTime.Today;
            dtp_horaFiltro.Value = DateTime.Today;

            filtrarPorFecha = false;
            filtrarPorHora = false;

            ARMA_GRILLA();

            btn_quitarFiltro.Enabled = false;
            btn_quitarFiltro.Visible = false;
        }

        private void txt_nombreUsuarioFiltro_TextChanged(object sender, EventArgs e)
        {
            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
        }

        private void cb_movimientoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
        }

        private void dtp_fechaFiltro_ValueChanged(object sender, EventArgs e)
        {
            filtrarPorFecha = true;

            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
        }

        private void dtp_horaFiltro_ValueChanged(object sender, EventArgs e)
        {
            filtrarPorHora = true;

            FILTRAR();
            btn_quitarFiltro.Enabled = true;
            btn_quitarFiltro.Visible = true;
        }
    }
}
