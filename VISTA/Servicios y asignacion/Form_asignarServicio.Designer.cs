namespace VISTA.Cabañas_y_alquiler
{
    partial class Form_asignarServicio
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
            panel_butones = new Panel();
            panel3 = new Panel();
            btn_cancelar = new Button();
            btn_asignarServicio = new Button();
            panel_picture = new Panel();
            lb_descripcion = new Label();
            lb_precio = new Label();
            lb3 = new Label();
            lb_nombre = new Label();
            lb2 = new Label();
            btn_anterior = new Button();
            btn_siguiente = new Button();
            pb_imagenes = new PictureBox();
            panel8 = new Panel();
            label = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel9 = new Panel();
            label3 = new Label();
            panel10 = new Panel();
            label7 = new Label();
            label_fecha = new Label();
            label_hora = new Label();
            dtp_fecha = new DateTimePicker();
            tp_hora = new DateTimePicker();
            label_fechas = new Label();
            label_horaSeleccionada = new Label();
            panel7 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            label_reserva = new Label();
            panel6 = new Panel();
            label2 = new Label();
            btn_seleccionarReserva = new Button();
            panel_butones.SuspendLayout();
            panel_picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_imagenes).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel_butones
            // 
            panel_butones.Controls.Add(panel3);
            panel_butones.Controls.Add(btn_cancelar);
            panel_butones.Controls.Add(btn_asignarServicio);
            panel_butones.Dock = DockStyle.Bottom;
            panel_butones.Location = new Point(0, 1235);
            panel_butones.Margin = new Padding(2);
            panel_butones.Name = "panel_butones";
            panel_butones.Size = new Size(1820, 98);
            panel_butones.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Enabled = false;
            panel3.Location = new Point(3, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1840, 2);
            panel3.TabIndex = 34;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom;
            btn_cancelar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.Location = new Point(1070, 27);
            btn_cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(204, 58);
            btn_cancelar.TabIndex = 27;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_asignarServicio
            // 
            btn_asignarServicio.Anchor = AnchorStyles.Bottom;
            btn_asignarServicio.BackColor = Color.FromArgb(0, 84, 168);
            btn_asignarServicio.FlatAppearance.BorderSize = 0;
            btn_asignarServicio.FlatStyle = FlatStyle.Flat;
            btn_asignarServicio.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_asignarServicio.ForeColor = Color.White;
            btn_asignarServicio.Location = new Point(606, 27);
            btn_asignarServicio.Margin = new Padding(3, 4, 3, 4);
            btn_asignarServicio.Name = "btn_asignarServicio";
            btn_asignarServicio.Size = new Size(204, 58);
            btn_asignarServicio.TabIndex = 26;
            btn_asignarServicio.Text = "Asignar servicio";
            btn_asignarServicio.UseVisualStyleBackColor = false;
            btn_asignarServicio.Click += btn_asignarServicio_Click;
            // 
            // panel_picture
            // 
            panel_picture.Controls.Add(lb_descripcion);
            panel_picture.Controls.Add(lb_precio);
            panel_picture.Controls.Add(lb3);
            panel_picture.Controls.Add(lb_nombre);
            panel_picture.Controls.Add(lb2);
            panel_picture.Controls.Add(btn_anterior);
            panel_picture.Controls.Add(btn_siguiente);
            panel_picture.Controls.Add(pb_imagenes);
            panel_picture.Controls.Add(panel8);
            panel_picture.Controls.Add(label);
            panel_picture.Controls.Add(panel1);
            panel_picture.Dock = DockStyle.Left;
            panel_picture.Location = new Point(0, 0);
            panel_picture.Margin = new Padding(2);
            panel_picture.Name = "panel_picture";
            panel_picture.Size = new Size(781, 1235);
            panel_picture.TabIndex = 2;
            // 
            // lb_descripcion
            // 
            lb_descripcion.Anchor = AnchorStyles.Left;
            lb_descripcion.AutoSize = true;
            lb_descripcion.Font = new Font("Century Gothic", 12F);
            lb_descripcion.ForeColor = Color.White;
            lb_descripcion.Location = new Point(162, 1019);
            lb_descripcion.Name = "lb_descripcion";
            lb_descripcion.Size = new Size(15, 23);
            lb_descripcion.TabIndex = 46;
            lb_descripcion.Text = "l";
            // 
            // lb_precio
            // 
            lb_precio.Anchor = AnchorStyles.Left;
            lb_precio.AutoSize = true;
            lb_precio.Font = new Font("Century Gothic", 12F);
            lb_precio.ForeColor = Color.White;
            lb_precio.Location = new Point(126, 927);
            lb_precio.Name = "lb_precio";
            lb_precio.Size = new Size(15, 23);
            lb_precio.TabIndex = 45;
            lb_precio.Text = "l";
            // 
            // lb3
            // 
            lb3.Anchor = AnchorStyles.Left;
            lb3.AutoSize = true;
            lb3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lb3.ForeColor = Color.White;
            lb3.Location = new Point(28, 1019);
            lb3.Name = "lb3";
            lb3.Size = new Size(132, 23);
            lb3.TabIndex = 43;
            lb3.Text = "Descripcion:";
            // 
            // lb_nombre
            // 
            lb_nombre.AutoSize = true;
            lb_nombre.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nombre.ForeColor = Color.White;
            lb_nombre.Location = new Point(283, 142);
            lb_nombre.Name = "lb_nombre";
            lb_nombre.Size = new Size(104, 27);
            lb_nombre.TabIndex = 42;
            lb_nombre.Text = "Nombre";
            // 
            // lb2
            // 
            lb2.Anchor = AnchorStyles.Left;
            lb2.AutoSize = true;
            lb2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lb2.ForeColor = Color.White;
            lb2.Location = new Point(28, 927);
            lb2.Name = "lb2";
            lb2.Size = new Size(92, 23);
            lb2.TabIndex = 41;
            lb2.Text = "Importe:";
            // 
            // btn_anterior
            // 
            btn_anterior.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btn_anterior.BackColor = Color.Transparent;
            btn_anterior.FlatAppearance.BorderSize = 0;
            btn_anterior.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_anterior.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_anterior.FlatStyle = FlatStyle.Flat;
            btn_anterior.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_anterior.ForeColor = Color.White;
            btn_anterior.Location = new Point(70, 179);
            btn_anterior.Margin = new Padding(3, 4, 3, 4);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(31, 543);
            btn_anterior.TabIndex = 39;
            btn_anterior.TabStop = false;
            btn_anterior.Text = "<";
            btn_anterior.UseVisualStyleBackColor = false;
            btn_anterior.Click += btn_anterior_Click;
            // 
            // btn_siguiente
            // 
            btn_siguiente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btn_siguiente.BackColor = Color.Transparent;
            btn_siguiente.FlatAppearance.BorderSize = 0;
            btn_siguiente.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_siguiente.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_siguiente.FlatStyle = FlatStyle.Flat;
            btn_siguiente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_siguiente.ForeColor = Color.White;
            btn_siguiente.Location = new Point(655, 179);
            btn_siguiente.Margin = new Padding(3, 4, 3, 4);
            btn_siguiente.Name = "btn_siguiente";
            btn_siguiente.Size = new Size(31, 543);
            btn_siguiente.TabIndex = 38;
            btn_siguiente.TabStop = false;
            btn_siguiente.Text = ">";
            btn_siguiente.UseVisualStyleBackColor = false;
            btn_siguiente.Click += btn_siguiente_Click;
            // 
            // pb_imagenes
            // 
            pb_imagenes.Anchor = AnchorStyles.Left;
            pb_imagenes.Location = new Point(100, 213);
            pb_imagenes.Margin = new Padding(3, 4, 3, 4);
            pb_imagenes.Name = "pb_imagenes";
            pb_imagenes.Size = new Size(557, 474);
            pb_imagenes.SizeMode = PictureBoxSizeMode.Zoom;
            pb_imagenes.TabIndex = 37;
            pb_imagenes.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Silver;
            panel8.Enabled = false;
            panel8.Location = new Point(0, 42);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(778, 2);
            panel8.TabIndex = 36;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(320, 6);
            label.Name = "label";
            label.Size = new Size(115, 32);
            label.TabIndex = 35;
            label.Text = "Servicio";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Enabled = false;
            panel1.Location = new Point(771, 6);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 1231);
            panel1.TabIndex = 34;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label_fecha);
            panel2.Controls.Add(label_hora);
            panel2.Controls.Add(dtp_fecha);
            panel2.Controls.Add(tp_hora);
            panel2.Controls.Add(label_fechas);
            panel2.Controls.Add(label_horaSeleccionada);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(781, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1039, 774);
            panel2.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Enabled = false;
            panel9.Font = new Font("Century Gothic", 13.8F);
            panel9.Location = new Point(576, 598);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(68, 2);
            panel9.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(576, 573);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 27);
            label3.TabIndex = 48;
            label3.Text = "Hora:";
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Enabled = false;
            panel10.Font = new Font("Century Gothic", 13.8F);
            panel10.Location = new Point(260, 597);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(87, 2);
            panel10.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(260, 572);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 27);
            label7.TabIndex = 46;
            label7.Text = "Fecha:";
            // 
            // label_fecha
            // 
            label_fecha.AutoSize = true;
            label_fecha.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_fecha.ForeColor = Color.White;
            label_fecha.Location = new Point(284, 250);
            label_fecha.Name = "label_fecha";
            label_fecha.Size = new Size(88, 27);
            label_fecha.TabIndex = 39;
            label_fecha.Text = "Fecha:";
            // 
            // label_hora
            // 
            label_hora.AutoSize = true;
            label_hora.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_hora.ForeColor = Color.White;
            label_hora.Location = new Point(284, 376);
            label_hora.Name = "label_hora";
            label_hora.Size = new Size(71, 27);
            label_hora.TabIndex = 40;
            label_hora.Text = "Hora:";
            // 
            // dtp_fecha
            // 
            dtp_fecha.Format = DateTimePickerFormat.Short;
            dtp_fecha.Location = new Point(560, 245);
            dtp_fecha.Name = "dtp_fecha";
            dtp_fecha.Size = new Size(220, 27);
            dtp_fecha.TabIndex = 41;
            // 
            // tp_hora
            // 
            tp_hora.Format = DateTimePickerFormat.Time;
            tp_hora.Location = new Point(560, 371);
            tp_hora.Name = "tp_hora";
            tp_hora.ShowUpDown = true;
            tp_hora.Size = new Size(220, 27);
            tp_hora.TabIndex = 42;
            // 
            // label_fechas
            // 
            label_fechas.AutoSize = true;
            label_fechas.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_fechas.ForeColor = Color.White;
            label_fechas.Location = new Point(353, 571);
            label_fechas.Name = "label_fechas";
            label_fechas.Size = new Size(182, 27);
            label_fechas.TabIndex = 43;
            label_fechas.Text = "Sin seleccionar";
            // 
            // label_horaSeleccionada
            // 
            label_horaSeleccionada.AutoSize = true;
            label_horaSeleccionada.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_horaSeleccionada.ForeColor = Color.White;
            label_horaSeleccionada.Location = new Point(652, 572);
            label_horaSeleccionada.Name = "label_horaSeleccionada";
            label_horaSeleccionada.Size = new Size(182, 27);
            label_horaSeleccionada.TabIndex = 44;
            label_horaSeleccionada.Text = "Sin seleccionar";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Silver;
            panel7.Enabled = false;
            panel7.Location = new Point(1, 42);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(1200, 2);
            panel7.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(400, 6);
            label1.Name = "label1";
            label1.Size = new Size(187, 32);
            label1.TabIndex = 36;
            label1.Text = "Fecha y hora";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Enabled = false;
            panel4.Location = new Point(0, 773);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1200, 2);
            panel4.TabIndex = 34;
            // 
            // panel5
            // 
            panel5.Controls.Add(label_reserva);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(btn_seleccionarReserva);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(781, 774);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1039, 461);
            panel5.TabIndex = 4;
            // 
            // label_reserva
            // 
            label_reserva.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_reserva.AutoSize = true;
            label_reserva.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_reserva.ForeColor = Color.White;
            label_reserva.Location = new Point(214, 245);
            label_reserva.Name = "label_reserva";
            label_reserva.Size = new Size(302, 27);
            label_reserva.TabIndex = 38;
            label_reserva.Text = "Reserva no seleccionada";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.Enabled = false;
            panel6.Location = new Point(1, 37);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(1200, 2);
            panel6.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(474, 2);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 36;
            label2.Text = "Reserva";
            // 
            // btn_seleccionarReserva
            // 
            btn_seleccionarReserva.BackColor = Color.FromArgb(0, 84, 168);
            btn_seleccionarReserva.FlatAppearance.BorderSize = 0;
            btn_seleccionarReserva.FlatStyle = FlatStyle.Flat;
            btn_seleccionarReserva.Font = new Font("Century Gothic", 9F);
            btn_seleccionarReserva.ForeColor = Color.White;
            btn_seleccionarReserva.Location = new Point(18, 78);
            btn_seleccionarReserva.Margin = new Padding(3, 4, 3, 4);
            btn_seleccionarReserva.Name = "btn_seleccionarReserva";
            btn_seleccionarReserva.Size = new Size(159, 27);
            btn_seleccionarReserva.TabIndex = 33;
            btn_seleccionarReserva.Text = "Seleccionar reserva";
            btn_seleccionarReserva.UseVisualStyleBackColor = false;
            btn_seleccionarReserva.Click += btn_seleccionarReserva_Click;
            // 
            // Form_asignarServicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1820, 1333);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel_picture);
            Controls.Add(panel_butones);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Form_asignarServicio";
            Text = "Form_asignarServicio";
            Load += Form_asignarServicio_Load;
            panel_butones.ResumeLayout(false);
            panel_picture.ResumeLayout(false);
            panel_picture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_imagenes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_asignarServicio;
        private Button btn_cancelar;
        private Panel panel3;
        private Panel panel4;
        private Panel panel_butones;
        private Panel panel_picture;
        private Panel panel5;
        private Button btn_seleccionarReserva;
        private Label label;
        private Label label1;
        private Label label2;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private PictureBox pb_imagenes;
        private Button btn_siguiente;
        private Button btn_anterior;
        private Label lb2;
        private Label lb_nombre;
        private Label lb3;
        private Label label_reserva;
        private Label lb_descripcion;
        private Label lb_precio;
        private Label label_fecha;
        private Label label_hora;
        private DateTimePicker dtp_fecha;
        private DateTimePicker tp_hora;
        private Label label_fechas;
        private Label label_horaSeleccionada;
        private Panel panel9;
        private Label label3;
        private Panel panel10;
        private Label label7;
    }
}
