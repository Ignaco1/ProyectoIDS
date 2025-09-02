namespace VISTA.Cabañas_y_alquiler
{
    partial class Form_verReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            gb_carga = new GroupBox();
            btn_seleccionarCabaña = new Button();
            mc_reservas = new MonthCalendar();
            cb_cliente = new ComboBox();
            cb_cabaña = new ComboBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            panel2 = new Panel();
            gb_grilla = new GroupBox();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            btn_cancelarReserva = new Button();
            btn_cerrar = new Button();
            btn_eliminar = new Button();
            btn_modificar = new Button();
            panel3 = new Panel();
            dtp_entradaFiltro = new DateTimePicker();
            txt_nombreCabañaFiltro = new TextBox();
            cb_estado = new ComboBox();
            dtp_salidaFiltro = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            btn_quitarFiltro = new Button();
            label9 = new Label();
            txt_nombreClienteFiltro = new TextBox();
            label8 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            gb_carga.SuspendLayout();
            panel2.SuspendLayout();
            gb_grilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(gb_carga);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(891, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 754);
            panel1.TabIndex = 0;
            // 
            // gb_carga
            // 
            gb_carga.Controls.Add(btn_seleccionarCabaña);
            gb_carga.Controls.Add(mc_reservas);
            gb_carga.Controls.Add(cb_cliente);
            gb_carga.Controls.Add(cb_cabaña);
            gb_carga.Controls.Add(label7);
            gb_carga.Controls.Add(label5);
            gb_carga.Controls.Add(label4);
            gb_carga.Controls.Add(btn_cancelar);
            gb_carga.Controls.Add(btn_guardar);
            gb_carga.Dock = DockStyle.Fill;
            gb_carga.ForeColor = Color.White;
            gb_carga.Location = new Point(0, 0);
            gb_carga.Name = "gb_carga";
            gb_carga.Size = new Size(273, 754);
            gb_carga.TabIndex = 0;
            gb_carga.TabStop = false;
            gb_carga.Text = "Carga de datos";
            // 
            // btn_seleccionarCabaña
            // 
            btn_seleccionarCabaña.BackColor = Color.FromArgb(0, 84, 168);
            btn_seleccionarCabaña.FlatAppearance.BorderSize = 0;
            btn_seleccionarCabaña.FlatStyle = FlatStyle.Flat;
            btn_seleccionarCabaña.Location = new Point(43, 62);
            btn_seleccionarCabaña.Name = "btn_seleccionarCabaña";
            btn_seleccionarCabaña.Size = new Size(193, 23);
            btn_seleccionarCabaña.TabIndex = 34;
            btn_seleccionarCabaña.Text = "Seleccionar cabaña";
            btn_seleccionarCabaña.UseVisualStyleBackColor = false;
            btn_seleccionarCabaña.Click += btn_seleccionarCabaña_Click;
            // 
            // mc_reservas
            // 
            mc_reservas.Location = new Point(16, 282);
            mc_reservas.Margin = new Padding(9, 10, 9, 10);
            mc_reservas.Name = "mc_reservas";
            mc_reservas.TabIndex = 33;
            // 
            // cb_cliente
            // 
            cb_cliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_cliente.FormattingEnabled = true;
            cb_cliente.Location = new Point(76, 180);
            cb_cliente.Name = "cb_cliente";
            cb_cliente.Size = new Size(185, 25);
            cb_cliente.TabIndex = 32;
            // 
            // cb_cabaña
            // 
            cb_cabaña.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_cabaña.FormattingEnabled = true;
            cb_cabaña.Location = new Point(76, 125);
            cb_cabaña.Name = "cb_cabaña";
            cb_cabaña.Size = new Size(185, 25);
            cb_cabaña.TabIndex = 31;
            cb_cabaña.SelectedIndexChanged += cb_cabaña_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 184);
            label7.Name = "label7";
            label7.Size = new Size(54, 17);
            label7.TabIndex = 30;
            label7.Text = "Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 255);
            label5.Name = "label5";
            label5.Size = new Size(53, 17);
            label5.TabIndex = 28;
            label5.Text = "Fechas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 128);
            label4.Name = "label4";
            label4.Size = new Size(59, 17);
            label4.TabIndex = 27;
            label4.Text = "Cabaña:";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Location = new Point(175, 725);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(92, 23);
            btn_cancelar.TabIndex = 26;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_guardar.BackColor = Color.FromArgb(0, 84, 168);
            btn_guardar.FlatAppearance.BorderSize = 0;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Location = new Point(6, 725);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(92, 23);
            btn_guardar.TabIndex = 25;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(gb_grilla);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(891, 754);
            panel2.TabIndex = 1;
            // 
            // gb_grilla
            // 
            gb_grilla.Controls.Add(dataGridView1);
            gb_grilla.Controls.Add(panel4);
            gb_grilla.Controls.Add(panel3);
            gb_grilla.Dock = DockStyle.Fill;
            gb_grilla.ForeColor = Color.White;
            gb_grilla.Location = new Point(0, 0);
            gb_grilla.Name = "gb_grilla";
            gb_grilla.Size = new Size(891, 754);
            gb_grilla.TabIndex = 0;
            gb_grilla.TabStop = false;
            gb_grilla.Text = "Lista de reservas";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 27;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ControlDark;
            dataGridView1.Location = new Point(3, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 84, 168);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(885, 559);
            dataGridView1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_cancelarReserva);
            panel4.Controls.Add(btn_cerrar);
            panel4.Controls.Add(btn_eliminar);
            panel4.Controls.Add(btn_modificar);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 677);
            panel4.Name = "panel4";
            panel4.Size = new Size(885, 74);
            panel4.TabIndex = 1;
            // 
            // btn_cancelarReserva
            // 
            btn_cancelarReserva.BackColor = Color.FromArgb(0, 84, 168);
            btn_cancelarReserva.FlatAppearance.BorderSize = 0;
            btn_cancelarReserva.FlatStyle = FlatStyle.Flat;
            btn_cancelarReserva.Location = new Point(296, 6);
            btn_cancelarReserva.Name = "btn_cancelarReserva";
            btn_cancelarReserva.Size = new Size(128, 23);
            btn_cancelarReserva.TabIndex = 10;
            btn_cancelarReserva.Text = "Cancelar reserva";
            btn_cancelarReserva.UseVisualStyleBackColor = false;
            btn_cancelarReserva.Click += btn_cancelarReserva_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Location = new Point(779, 48);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(103, 23);
            btn_cerrar.TabIndex = 9;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(0, 84, 168);
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Location = new Point(148, 6);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(128, 23);
            btn_eliminar.TabIndex = 8;
            btn_eliminar.Text = "Eliminar reserva";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.FromArgb(0, 84, 168);
            btn_modificar.FlatAppearance.BorderSize = 0;
            btn_modificar.FlatStyle = FlatStyle.Flat;
            btn_modificar.Location = new Point(3, 6);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(128, 23);
            btn_modificar.TabIndex = 7;
            btn_modificar.Text = "Modificar reserva";
            btn_modificar.UseVisualStyleBackColor = false;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtp_entradaFiltro);
            panel3.Controls.Add(txt_nombreCabañaFiltro);
            panel3.Controls.Add(cb_estado);
            panel3.Controls.Add(dtp_salidaFiltro);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btn_quitarFiltro);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txt_nombreClienteFiltro);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(885, 100);
            panel3.TabIndex = 0;
            // 
            // dtp_entradaFiltro
            // 
            dtp_entradaFiltro.Format = DateTimePickerFormat.Short;
            dtp_entradaFiltro.Location = new Point(187, 66);
            dtp_entradaFiltro.Name = "dtp_entradaFiltro";
            dtp_entradaFiltro.Size = new Size(200, 22);
            dtp_entradaFiltro.TabIndex = 60;
            dtp_entradaFiltro.ValueChanged += dtp_salidaFiltro_ValueChanged;
            // 
            // txt_nombreCabañaFiltro
            // 
            txt_nombreCabañaFiltro.Location = new Point(136, 16);
            txt_nombreCabañaFiltro.Name = "txt_nombreCabañaFiltro";
            txt_nombreCabañaFiltro.Size = new Size(130, 22);
            txt_nombreCabañaFiltro.TabIndex = 59;
            txt_nombreCabañaFiltro.TextChanged += txt_nombreCabañaFiltro_TextChanged;
            // 
            // cb_estado
            // 
            cb_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_estado.FormattingEnabled = true;
            cb_estado.Location = new Point(692, 16);
            cb_estado.Name = "cb_estado";
            cb_estado.Size = new Size(121, 25);
            cb_estado.TabIndex = 58;
            cb_estado.SelectedIndexChanged += cb_estado_SelectedIndexChanged;
            // 
            // dtp_salidaFiltro
            // 
            dtp_salidaFiltro.Format = DateTimePickerFormat.Short;
            dtp_salidaFiltro.Location = new Point(523, 66);
            dtp_salidaFiltro.Name = "dtp_salidaFiltro";
            dtp_salidaFiltro.Size = new Size(200, 22);
            dtp_salidaFiltro.TabIndex = 57;
            dtp_salidaFiltro.ValueChanged += dtp_salidaFiltro_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(410, 71);
            label3.Name = "label3";
            label3.Size = new Size(107, 17);
            label3.TabIndex = 55;
            label3.Text = "Fecha de Salida:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 71);
            label2.Name = "label2";
            label2.Size = new Size(118, 17);
            label2.TabIndex = 54;
            label2.Text = "Fecha de entrada:";
            // 
            // btn_quitarFiltro
            // 
            btn_quitarFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_quitarFiltro.BackColor = Color.FromArgb(0, 84, 168);
            btn_quitarFiltro.FlatAppearance.BorderSize = 0;
            btn_quitarFiltro.FlatStyle = FlatStyle.Flat;
            btn_quitarFiltro.Location = new Point(770, 65);
            btn_quitarFiltro.Name = "btn_quitarFiltro";
            btn_quitarFiltro.Size = new Size(103, 23);
            btn_quitarFiltro.TabIndex = 53;
            btn_quitarFiltro.Text = "Limpiar filtro";
            btn_quitarFiltro.UseVisualStyleBackColor = false;
            btn_quitarFiltro.Click += btn_quitarFiltro_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(568, 19);
            label9.Name = "label9";
            label9.Size = new Size(118, 17);
            label9.TabIndex = 49;
            label9.Text = "Estado de reserva:";
            // 
            // txt_nombreClienteFiltro
            // 
            txt_nombreClienteFiltro.Location = new Point(415, 16);
            txt_nombreClienteFiltro.Name = "txt_nombreClienteFiltro";
            txt_nombreClienteFiltro.Size = new Size(132, 22);
            txt_nombreClienteFiltro.TabIndex = 48;
            txt_nombreClienteFiltro.TextChanged += txt_nombreClienteFiltro_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(286, 19);
            label8.Name = "label8";
            label8.Size = new Size(123, 17);
            label8.TabIndex = 47;
            label8.Text = "Nombre de cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 19);
            label1.Name = "label1";
            label1.Size = new Size(128, 17);
            label1.TabIndex = 46;
            label1.Text = "Nombre de cabaña:";
            // 
            // Form_verReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1164, 754);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_verReservas";
            Text = "Form_verReservas";
            Load += Form_verReservas_Load;
            panel1.ResumeLayout(false);
            gb_carga.ResumeLayout(false);
            gb_carga.PerformLayout();
            panel2.ResumeLayout(false);
            gb_grilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox gb_carga;
        private Panel panel2;
        private GroupBox gb_grilla;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Panel panel3;
        private TextBox txt_nombreFiltro;
        private TextBox txt_precioNocheFiltro;
        private Label label9;
        private TextBox txt_nombreClienteFiltro;
        private Label label8;
        private Label label1;
        private Button btn_quitarFiltro;
        private ComboBox cb_estado;
        private DateTimePicker dtp_salidaFiltro;
        private Label label3;
        private Label label2;
        private Button btn_eliminar;
        private Button btn_modificar;
        private Button btn_cerrar;
        private Button btn_cancelar;
        private Button btn_guardar;
        private TextBox txt_nombreCabañaFiltro;
        private ComboBox cb_cliente;
        private ComboBox cb_cabaña;
        private Label label7;
        private Label label5;
        private Label label4;
        private MonthCalendar mc_reservas;
        private Button btn_cancelarReserva;
        private DateTimePicker dtp_entradaFiltro;
        private Button btn_seleccionarCabaña;
    }
}