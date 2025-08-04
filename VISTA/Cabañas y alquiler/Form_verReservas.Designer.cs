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
            panel1 = new Panel();
            gb_carga = new GroupBox();
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
            btn_seleccionarCabaña = new Button();
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
            panel1.Size = new Size(273, 665);
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
            gb_carga.Location = new Point(0, 0);
            gb_carga.Name = "gb_carga";
            gb_carga.Size = new Size(273, 665);
            gb_carga.TabIndex = 0;
            gb_carga.TabStop = false;
            gb_carga.Text = "Carga de datos";
            // 
            // mc_reservas
            // 
            mc_reservas.Location = new Point(16, 249);
            mc_reservas.Name = "mc_reservas";
            mc_reservas.TabIndex = 33;
            // 
            // cb_cliente
            // 
            cb_cliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_cliente.FormattingEnabled = true;
            cb_cliente.Location = new Point(76, 159);
            cb_cliente.Name = "cb_cliente";
            cb_cliente.Size = new Size(185, 23);
            cb_cliente.TabIndex = 32;
            // 
            // cb_cabaña
            // 
            cb_cabaña.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_cabaña.FormattingEnabled = true;
            cb_cabaña.Location = new Point(76, 110);
            cb_cabaña.Name = "cb_cabaña";
            cb_cabaña.Size = new Size(185, 23);
            cb_cabaña.TabIndex = 31;
            cb_cabaña.SelectedIndexChanged += cb_cabaña_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 162);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 30;
            label7.Text = "Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 225);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 28;
            label5.Text = "Fechas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 113);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 27;
            label4.Text = "Cabaña:";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.Location = new Point(165, 630);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(102, 23);
            btn_cancelar.TabIndex = 26;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_guardar.Location = new Point(6, 630);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(102, 23);
            btn_guardar.TabIndex = 25;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(gb_grilla);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(891, 665);
            panel2.TabIndex = 1;
            // 
            // gb_grilla
            // 
            gb_grilla.Controls.Add(dataGridView1);
            gb_grilla.Controls.Add(panel4);
            gb_grilla.Controls.Add(panel3);
            gb_grilla.Dock = DockStyle.Fill;
            gb_grilla.Location = new Point(0, 0);
            gb_grilla.Name = "gb_grilla";
            gb_grilla.Size = new Size(891, 665);
            gb_grilla.TabIndex = 0;
            gb_grilla.TabStop = false;
            gb_grilla.Text = "Lista de reservas";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(885, 476);
            dataGridView1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_cancelarReserva);
            panel4.Controls.Add(btn_cerrar);
            panel4.Controls.Add(btn_eliminar);
            panel4.Controls.Add(btn_modificar);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 597);
            panel4.Name = "panel4";
            panel4.Size = new Size(885, 65);
            panel4.TabIndex = 1;
            // 
            // btn_cancelarReserva
            // 
            btn_cancelarReserva.Location = new Point(253, 6);
            btn_cancelarReserva.Name = "btn_cancelarReserva";
            btn_cancelarReserva.Size = new Size(102, 23);
            btn_cancelarReserva.TabIndex = 10;
            btn_cancelarReserva.Text = "Cancelar reserva";
            btn_cancelarReserva.UseVisualStyleBackColor = true;
            btn_cancelarReserva.Click += btn_cancelarReserva_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.Location = new Point(780, 33);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(102, 23);
            btn_cerrar.TabIndex = 9;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(136, 6);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(102, 23);
            btn_eliminar.TabIndex = 8;
            btn_eliminar.Text = "Eliminar reserva";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(9, 6);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(110, 23);
            btn_modificar.TabIndex = 7;
            btn_modificar.Text = "Modificar reserva";
            btn_modificar.UseVisualStyleBackColor = true;
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
            panel3.Location = new Point(3, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(885, 102);
            panel3.TabIndex = 0;
            // 
            // dtp_entradaFiltro
            // 
            dtp_entradaFiltro.Format = DateTimePickerFormat.Short;
            dtp_entradaFiltro.Location = new Point(185, 56);
            dtp_entradaFiltro.Name = "dtp_entradaFiltro";
            dtp_entradaFiltro.Size = new Size(200, 23);
            dtp_entradaFiltro.TabIndex = 60;
            dtp_entradaFiltro.ValueChanged += dtp_salidaFiltro_ValueChanged;
            // 
            // txt_nombreCabañaFiltro
            // 
            txt_nombreCabañaFiltro.Location = new Point(130, 14);
            txt_nombreCabañaFiltro.Name = "txt_nombreCabañaFiltro";
            txt_nombreCabañaFiltro.Size = new Size(130, 23);
            txt_nombreCabañaFiltro.TabIndex = 59;
            txt_nombreCabañaFiltro.TextChanged += txt_nombreCabañaFiltro_TextChanged;
            // 
            // cb_estado
            // 
            cb_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_estado.FormattingEnabled = true;
            cb_estado.Location = new Point(646, 14);
            cb_estado.Name = "cb_estado";
            cb_estado.Size = new Size(121, 23);
            cb_estado.TabIndex = 58;
            cb_estado.SelectedIndexChanged += cb_estado_SelectedIndexChanged;
            // 
            // dtp_salidaFiltro
            // 
            dtp_salidaFiltro.Format = DateTimePickerFormat.Short;
            dtp_salidaFiltro.Location = new Point(523, 56);
            dtp_salidaFiltro.Name = "dtp_salidaFiltro";
            dtp_salidaFiltro.Size = new Size(200, 23);
            dtp_salidaFiltro.TabIndex = 57;
            dtp_salidaFiltro.ValueChanged += dtp_salidaFiltro_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(426, 62);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 55;
            label3.Text = "Fecha de Salida:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 62);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 54;
            label2.Text = "Fecha de entrada:";
            // 
            // btn_quitarFiltro
            // 
            btn_quitarFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_quitarFiltro.Location = new Point(780, 43);
            btn_quitarFiltro.Name = "btn_quitarFiltro";
            btn_quitarFiltro.Size = new Size(102, 23);
            btn_quitarFiltro.TabIndex = 53;
            btn_quitarFiltro.Text = "Limpiar filtro";
            btn_quitarFiltro.UseVisualStyleBackColor = true;
            btn_quitarFiltro.Click += btn_quitarFiltro_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(539, 17);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 49;
            label9.Text = "Estado de reserva:";
            // 
            // txt_nombreClienteFiltro
            // 
            txt_nombreClienteFiltro.Location = new Point(385, 14);
            txt_nombreClienteFiltro.Name = "txt_nombreClienteFiltro";
            txt_nombreClienteFiltro.Size = new Size(132, 23);
            txt_nombreClienteFiltro.TabIndex = 48;
            txt_nombreClienteFiltro.TextChanged += txt_nombreClienteFiltro_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(275, 17);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 47;
            label8.Text = "Nombre de cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 17);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 46;
            label1.Text = "Nombre de cabaña:";
            // 
            // btn_seleccionarCabaña
            // 
            btn_seleccionarCabaña.Location = new Point(76, 50);
            btn_seleccionarCabaña.Name = "btn_seleccionarCabaña";
            btn_seleccionarCabaña.Size = new Size(123, 23);
            btn_seleccionarCabaña.TabIndex = 34;
            btn_seleccionarCabaña.Text = "Seleccionar cabaña";
            btn_seleccionarCabaña.UseVisualStyleBackColor = true;
            btn_seleccionarCabaña.Click += btn_seleccionarCabaña_Click;
            // 
            // Form_verReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 665);
            Controls.Add(panel2);
            Controls.Add(panel1);
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