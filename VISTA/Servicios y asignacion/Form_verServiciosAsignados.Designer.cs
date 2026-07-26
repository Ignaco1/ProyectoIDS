namespace VISTA.Cabañas_y_alquiler
{
    partial class Form_verServiciosAsignados
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
            cb_reservas = new ComboBox();
            cb_servicio = new ComboBox();
            tp_hora = new DateTimePicker();
            btn_seleccionarServicio = new Button();
            dtp_fecha = new DateTimePicker();
            cb_cliente = new ComboBox();
            cb_cabaña = new ComboBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label10 = new Label();
            label11 = new Label();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            panel2 = new Panel();
            gb_grilla = new GroupBox();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            btn_cancelarServicio = new Button();
            btn_cerrar = new Button();
            btn_eliminar = new Button();
            btn_modificar = new Button();
            panel3 = new Panel();
            dtp_fechaFiltro = new DateTimePicker();
            txt_nombreCabañaFiltro = new TextBox();
            cb_estado = new ComboBox();
            dtp_horaFiltro = new DateTimePicker();
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
            panel1.Location = new Point(1468, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 1333);
            panel1.TabIndex = 0;
            // 
            // gb_carga
            // 
            gb_carga.Controls.Add(cb_reservas);
            gb_carga.Controls.Add(cb_servicio);
            gb_carga.Controls.Add(tp_hora);
            gb_carga.Controls.Add(btn_seleccionarServicio);
            gb_carga.Controls.Add(dtp_fecha);
            gb_carga.Controls.Add(cb_cliente);
            gb_carga.Controls.Add(cb_cabaña);
            gb_carga.Controls.Add(label7);
            gb_carga.Controls.Add(label5);
            gb_carga.Controls.Add(label4);
            gb_carga.Controls.Add(label6);
            gb_carga.Controls.Add(label10);
            gb_carga.Controls.Add(label11);
            gb_carga.Controls.Add(btn_cancelar);
            gb_carga.Controls.Add(btn_guardar);
            gb_carga.Dock = DockStyle.Fill;
            gb_carga.ForeColor = Color.White;
            gb_carga.Location = new Point(0, 0);
            gb_carga.Name = "gb_carga";
            gb_carga.Size = new Size(352, 1333);
            gb_carga.TabIndex = 0;
            gb_carga.TabStop = false;
            gb_carga.Text = "Modificar servicio asignado";
            // 
            // cb_reservas
            // 
            cb_reservas.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_reservas.Enabled = false;
            cb_reservas.FormattingEnabled = true;
            cb_reservas.Location = new Point(88, 275);
            cb_reservas.Name = "cb_reservas";
            cb_reservas.Size = new Size(222, 28);
            cb_reservas.TabIndex = 37;
            // 
            // cb_servicio
            // 
            cb_servicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_servicio.Enabled = false;
            cb_servicio.FormattingEnabled = true;
            cb_servicio.Location = new Point(88, 197);
            cb_servicio.Name = "cb_servicio";
            cb_servicio.Size = new Size(258, 28);
            cb_servicio.TabIndex = 36;
            // 
            // tp_hora
            // 
            tp_hora.Format = DateTimePickerFormat.Time;
            tp_hora.Location = new Point(88, 587);
            tp_hora.Name = "tp_hora";
            tp_hora.ShowUpDown = true;
            tp_hora.Size = new Size(120, 26);
            tp_hora.TabIndex = 35;
            // 
            // btn_seleccionarServicio
            // 
            btn_seleccionarServicio.BackColor = Color.FromArgb(0, 84, 168);
            btn_seleccionarServicio.FlatAppearance.BorderSize = 0;
            btn_seleccionarServicio.FlatStyle = FlatStyle.Flat;
            btn_seleccionarServicio.Location = new Point(88, 70);
            btn_seleccionarServicio.Name = "btn_seleccionarServicio";
            btn_seleccionarServicio.Size = new Size(193, 27);
            btn_seleccionarServicio.TabIndex = 34;
            btn_seleccionarServicio.Text = "Seleccionar servicio";
            btn_seleccionarServicio.UseVisualStyleBackColor = false;
            btn_seleccionarServicio.Click += btn_seleccionarServicio_Click;
            // 
            // dtp_fecha
            // 
            dtp_fecha.Format = DateTimePickerFormat.Short;
            dtp_fecha.Location = new Point(88, 511);
            dtp_fecha.Name = "dtp_fecha";
            dtp_fecha.Size = new Size(157, 26);
            dtp_fecha.TabIndex = 33;
            // 
            // cb_cliente
            // 
            cb_cliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_cliente.Enabled = false;
            cb_cliente.FormattingEnabled = true;
            cb_cliente.Location = new Point(88, 432);
            cb_cliente.Name = "cb_cliente";
            cb_cliente.Size = new Size(258, 28);
            cb_cliente.TabIndex = 32;
            // 
            // cb_cabaña
            // 
            cb_cabaña.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_cabaña.Enabled = false;
            cb_cabaña.FormattingEnabled = true;
            cb_cabaña.Location = new Point(88, 351);
            cb_cabaña.Name = "cb_cabaña";
            cb_cabaña.Size = new Size(222, 28);
            cb_cabaña.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 435);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 30;
            label7.Text = "Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 516);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 28;
            label5.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 354);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 27;
            label4.Text = "Cabaña:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 592);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 38;
            label6.Text = "Hora:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 200);
            label10.Name = "label10";
            label10.Size = new Size(71, 20);
            label10.TabIndex = 39;
            label10.Text = "Servicio:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 275);
            label11.Name = "label11";
            label11.Size = new Size(73, 20);
            label11.TabIndex = 40;
            label11.Text = "Reserva:";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Location = new Point(226, 1300);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(120, 27);
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
            btn_guardar.Location = new Point(6, 1300);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(120, 27);
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
            panel2.Size = new Size(1468, 1333);
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
            gb_grilla.Size = new Size(1468, 1333);
            gb_grilla.TabIndex = 0;
            gb_grilla.TabStop = false;
            gb_grilla.Text = "Servicios asignados";
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
            dataGridView1.Location = new Point(3, 131);
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
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 84, 168);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1462, 1125);
            dataGridView1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_cancelarServicio);
            panel4.Controls.Add(btn_cerrar);
            panel4.Controls.Add(btn_eliminar);
            panel4.Controls.Add(btn_modificar);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 1256);
            panel4.Name = "panel4";
            panel4.Size = new Size(1462, 74);
            panel4.TabIndex = 1;
            // 
            // btn_cancelarServicio
            // 
            btn_cancelarServicio.BackColor = Color.FromArgb(0, 84, 168);
            btn_cancelarServicio.FlatAppearance.BorderSize = 0;
            btn_cancelarServicio.FlatStyle = FlatStyle.Flat;
            btn_cancelarServicio.Location = new Point(216, 6);
            btn_cancelarServicio.Name = "btn_cancelarServicio";
            btn_cancelarServicio.Size = new Size(190, 27);
            btn_cancelarServicio.TabIndex = 10;
            btn_cancelarServicio.Tag = "Cancelar servicio";
            btn_cancelarServicio.Text = "Cancelar servicio";
            btn_cancelarServicio.UseVisualStyleBackColor = false;
            btn_cancelarServicio.Click += btn_cancelarServicio_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Location = new Point(1339, 44);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(120, 27);
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
            btn_eliminar.Location = new Point(429, 6);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(190, 27);
            btn_eliminar.TabIndex = 8;
            btn_eliminar.Tag = "Eliminar servicio asignado";
            btn_eliminar.Text = "Eliminar servicio asignado";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.FromArgb(0, 84, 168);
            btn_modificar.FlatAppearance.BorderSize = 0;
            btn_modificar.FlatStyle = FlatStyle.Flat;
            btn_modificar.Location = new Point(6, 6);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(190, 27);
            btn_modificar.TabIndex = 7;
            btn_modificar.Tag = "Modificar servicio asignado";
            btn_modificar.Text = "Modificar servicio asignado";
            btn_modificar.UseVisualStyleBackColor = false;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtp_fechaFiltro);
            panel3.Controls.Add(txt_nombreCabañaFiltro);
            panel3.Controls.Add(cb_estado);
            panel3.Controls.Add(dtp_horaFiltro);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btn_quitarFiltro);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txt_nombreClienteFiltro);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(1462, 109);
            panel3.TabIndex = 0;
            // 
            // dtp_fechaFiltro
            // 
            dtp_fechaFiltro.Format = DateTimePickerFormat.Short;
            dtp_fechaFiltro.Location = new Point(474, 64);
            dtp_fechaFiltro.Name = "dtp_fechaFiltro";
            dtp_fechaFiltro.Size = new Size(221, 26);
            dtp_fechaFiltro.TabIndex = 60;
            dtp_fechaFiltro.ValueChanged += dtp_fechaFiltro_ValueChanged;
            // 
            // txt_nombreCabañaFiltro
            // 
            txt_nombreCabañaFiltro.Location = new Point(308, 15);
            txt_nombreCabañaFiltro.Name = "txt_nombreCabañaFiltro";
            txt_nombreCabañaFiltro.Size = new Size(185, 26);
            txt_nombreCabañaFiltro.TabIndex = 59;
            txt_nombreCabañaFiltro.TextChanged += txt_nombreCabañaFiltro_TextChanged;
            // 
            // cb_estado
            // 
            cb_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_estado.FormattingEnabled = true;
            cb_estado.Location = new Point(1036, 15);
            cb_estado.Name = "cb_estado";
            cb_estado.Size = new Size(169, 28);
            cb_estado.TabIndex = 58;
            cb_estado.SelectedIndexChanged += cb_estado_SelectedIndexChanged;
            // 
            // dtp_horaFiltro
            // 
            dtp_horaFiltro.Format = DateTimePickerFormat.Time;
            dtp_horaFiltro.Location = new Point(843, 64);
            dtp_horaFiltro.Name = "dtp_horaFiltro";
            dtp_horaFiltro.ShowUpDown = true;
            dtp_horaFiltro.Size = new Size(169, 26);
            dtp_horaFiltro.TabIndex = 57;
            dtp_horaFiltro.ValueChanged += dtp_horaFiltro_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(789, 69);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 55;
            label3.Text = "Hora:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 69);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 54;
            label2.Text = "Fecha seleccionada:";
            // 
            // btn_quitarFiltro
            // 
            btn_quitarFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_quitarFiltro.BackColor = Color.FromArgb(0, 84, 168);
            btn_quitarFiltro.FlatAppearance.BorderSize = 0;
            btn_quitarFiltro.FlatStyle = FlatStyle.Flat;
            btn_quitarFiltro.Location = new Point(1282, 48);
            btn_quitarFiltro.Name = "btn_quitarFiltro";
            btn_quitarFiltro.Size = new Size(161, 27);
            btn_quitarFiltro.TabIndex = 53;
            btn_quitarFiltro.Text = "Limpiar filtro";
            btn_quitarFiltro.UseVisualStyleBackColor = false;
            btn_quitarFiltro.Click += btn_quitarFiltro_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(884, 18);
            label9.Name = "label9";
            label9.Size = new Size(150, 20);
            label9.TabIndex = 49;
            label9.Text = "Estado del servicio:";
            // 
            // txt_nombreClienteFiltro
            // 
            txt_nombreClienteFiltro.Location = new Point(672, 15);
            txt_nombreClienteFiltro.Name = "txt_nombreClienteFiltro";
            txt_nombreClienteFiltro.Size = new Size(186, 26);
            txt_nombreClienteFiltro.TabIndex = 48;
            txt_nombreClienteFiltro.TextChanged += txt_nombreClienteFiltro_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(516, 18);
            label8.Name = "label8";
            label8.Size = new Size(150, 20);
            label8.TabIndex = 47;
            label8.Text = "Nombre de cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 18);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 46;
            label1.Text = "Nombre de cabaña:";
            // 
            // Form_verServiciosAsignados
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1820, 1333);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_verServiciosAsignados";
            Text = "Form_verServiciosAsignados";
            Load += Form_verServiciosAsignados_Load;
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
        private Label label9;
        private TextBox txt_nombreClienteFiltro;
        private Label label8;
        private Label label1;
        private Button btn_quitarFiltro;
        private ComboBox cb_estado;
        private DateTimePicker dtp_horaFiltro;
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
        private Label label6;
        private Label label10;
        private Label label11;
        private DateTimePicker dtp_fecha;
        private Button btn_cancelarServicio;
        private DateTimePicker dtp_fechaFiltro;
        private Button btn_seleccionarServicio;
        private DateTimePicker tp_hora;
        private ComboBox cb_servicio;
        private ComboBox cb_reservas;
    }
}
