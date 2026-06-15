namespace VISTA.Cabañas_y_alquiler
{
    partial class Form_reservaCabaña
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
            btn_realizarReserva = new Button();
            panel_picture = new Panel();
            label5 = new Label();
            lb_descripcion = new Label();
            lb_precio = new Label();
            lb_capacidad = new Label();
            lb3 = new Label();
            lb_nombre = new Label();
            lb2 = new Label();
            lb1 = new Label();
            btn_anterior = new Button();
            btn_siguiente = new Button();
            pb_imagenes = new PictureBox();
            panel8 = new Panel();
            label = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel10 = new Panel();
            label_fechas = new Label();
            label7 = new Label();
            panel9 = new Panel();
            label3 = new Label();
            label4 = new Label();
            mc_fechas = new MonthCalendar();
            panel7 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            label_cliente = new Label();
            panel6 = new Panel();
            label2 = new Label();
            btn_seleccionarCliente = new Button();
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
            panel_butones.Controls.Add(btn_realizarReserva);
            panel_butones.Dock = DockStyle.Bottom;
            panel_butones.Location = new Point(0, 1235);
            panel_butones.Margin = new Padding(2, 2, 2, 2);
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
            // btn_realizarReserva
            // 
            btn_realizarReserva.Anchor = AnchorStyles.Bottom;
            btn_realizarReserva.BackColor = Color.FromArgb(0, 84, 168);
            btn_realizarReserva.FlatAppearance.BorderSize = 0;
            btn_realizarReserva.FlatStyle = FlatStyle.Flat;
            btn_realizarReserva.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_realizarReserva.ForeColor = Color.White;
            btn_realizarReserva.Location = new Point(606, 27);
            btn_realizarReserva.Margin = new Padding(3, 4, 3, 4);
            btn_realizarReserva.Name = "btn_realizarReserva";
            btn_realizarReserva.Size = new Size(204, 58);
            btn_realizarReserva.TabIndex = 26;
            btn_realizarReserva.Text = "Realizar reserva";
            btn_realizarReserva.UseVisualStyleBackColor = false;
            btn_realizarReserva.Click += btn_realizarReserva_Click;
            // 
            // panel_picture
            // 
            panel_picture.Controls.Add(label5);
            panel_picture.Controls.Add(lb_descripcion);
            panel_picture.Controls.Add(lb_precio);
            panel_picture.Controls.Add(lb_capacidad);
            panel_picture.Controls.Add(lb3);
            panel_picture.Controls.Add(lb_nombre);
            panel_picture.Controls.Add(lb2);
            panel_picture.Controls.Add(lb1);
            panel_picture.Controls.Add(btn_anterior);
            panel_picture.Controls.Add(btn_siguiente);
            panel_picture.Controls.Add(pb_imagenes);
            panel_picture.Controls.Add(panel8);
            panel_picture.Controls.Add(label);
            panel_picture.Controls.Add(panel1);
            panel_picture.Dock = DockStyle.Left;
            panel_picture.Location = new Point(0, 0);
            panel_picture.Margin = new Padding(2, 2, 2, 2);
            panel_picture.Name = "panel_picture";
            panel_picture.Size = new Size(781, 1235);
            panel_picture.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(224, 98);
            label5.Name = "label5";
            label5.Size = new Size(234, 23);
            label5.TabIndex = 47;
            label5.Text = "Nombre de la cabaña:";
            // 
            // lb_descripcion
            // 
            lb_descripcion.Anchor = AnchorStyles.Left;
            lb_descripcion.AutoSize = true;
            lb_descripcion.Font = new Font("Microsoft Sans Serif", 12F);
            lb_descripcion.ForeColor = Color.White;
            lb_descripcion.Location = new Point(152, 938);
            lb_descripcion.Name = "lb_descripcion";
            lb_descripcion.Size = new Size(16, 25);
            lb_descripcion.TabIndex = 46;
            lb_descripcion.Text = "l";
            // 
            // lb_precio
            // 
            lb_precio.Anchor = AnchorStyles.Left;
            lb_precio.AutoSize = true;
            lb_precio.Font = new Font("Microsoft Sans Serif", 12F);
            lb_precio.ForeColor = Color.White;
            lb_precio.Location = new Point(201, 846);
            lb_precio.Name = "lb_precio";
            lb_precio.Size = new Size(16, 25);
            lb_precio.TabIndex = 45;
            lb_precio.Text = "l";
            // 
            // lb_capacidad
            // 
            lb_capacidad.Anchor = AnchorStyles.Left;
            lb_capacidad.AutoSize = true;
            lb_capacidad.Font = new Font("Microsoft Sans Serif", 12F);
            lb_capacidad.ForeColor = Color.White;
            lb_capacidad.Location = new Point(141, 748);
            lb_capacidad.Name = "lb_capacidad";
            lb_capacidad.Size = new Size(16, 25);
            lb_capacidad.TabIndex = 44;
            lb_capacidad.Text = "l";
            // 
            // lb3
            // 
            lb3.Anchor = AnchorStyles.Left;
            lb3.AutoSize = true;
            lb3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lb3.ForeColor = Color.White;
            lb3.Location = new Point(18, 938);
            lb3.Name = "lb3";
            lb3.Size = new Size(132, 25);
            lb3.TabIndex = 43;
            lb3.Text = "Descripcion:";
            // 
            // lb_nombre
            // 
            lb_nombre.AutoSize = true;
            lb_nombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nombre.ForeColor = Color.White;
            lb_nombre.Location = new Point(455, 97);
            lb_nombre.Name = "lb_nombre";
            lb_nombre.Size = new Size(90, 23);
            lb_nombre.TabIndex = 42;
            lb_nombre.Text = "Nombre";
            // 
            // lb2
            // 
            lb2.Anchor = AnchorStyles.Left;
            lb2.AutoSize = true;
            lb2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lb2.ForeColor = Color.White;
            lb2.Location = new Point(18, 846);
            lb2.Name = "lb2";
            lb2.Size = new Size(182, 25);
            lb2.TabIndex = 41;
            lb2.Text = "Precio por noche:";
            // 
            // lb1
            // 
            lb1.Anchor = AnchorStyles.Left;
            lb1.AutoSize = true;
            lb1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lb1.ForeColor = Color.White;
            lb1.Location = new Point(18, 748);
            lb1.Name = "lb1";
            lb1.Size = new Size(123, 25);
            lb1.TabIndex = 40;
            lb1.Text = "Capacidad:";
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
            btn_anterior.Location = new Point(61, 147);
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
            btn_siguiente.Location = new Point(646, 147);
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
            pb_imagenes.Location = new Point(91, 181);
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
            label.Size = new Size(123, 32);
            label.TabIndex = 35;
            label.Text = "Cabaña";
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
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(label_fechas);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(mc_fechas);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(781, 0);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1039, 774);
            panel2.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Enabled = false;
            panel10.Location = new Point(321, 594);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(224, 2);
            panel10.TabIndex = 45;
            // 
            // label_fechas
            // 
            label_fechas.AutoSize = true;
            label_fechas.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_fechas.ForeColor = Color.White;
            label_fechas.Location = new Point(556, 572);
            label_fechas.Margin = new Padding(2, 0, 2, 0);
            label_fechas.Name = "label_fechas";
            label_fechas.Size = new Size(209, 23);
            label_fechas.TabIndex = 44;
            label_fechas.Text = "24/12/25 al 30/12/25";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(321, 572);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(236, 23);
            label7.TabIndex = 42;
            label7.Text = "Fechas seleccionadas:";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Enabled = false;
            panel9.Location = new Point(358, 124);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(376, 2);
            panel9.TabIndex = 41;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(442, 97);
            label3.Name = "label3";
            label3.Size = new Size(301, 23);
            label3.TabIndex = 40;
            label3.Text = "Dias ocupados de la cabaña.";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(358, 97);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 39;
            label4.Text = "Negrita:";
            // 
            // mc_fechas
            // 
            mc_fechas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mc_fechas.Location = new Point(415, 241);
            mc_fechas.Margin = new Padding(10, 12, 10, 12);
            mc_fechas.MaxSelectionCount = 30;
            mc_fechas.Name = "mc_fechas";
            mc_fechas.TabIndex = 38;
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
            label1.Location = new Point(487, 6);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 36;
            label1.Text = "Fechas";
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
            panel5.Controls.Add(label_cliente);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(btn_seleccionarCliente);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(781, 774);
            panel5.Margin = new Padding(2, 2, 2, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1039, 461);
            panel5.TabIndex = 4;
            // 
            // label_cliente
            // 
            label_cliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_cliente.AutoSize = true;
            label_cliente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_cliente.ForeColor = Color.White;
            label_cliente.Location = new Point(102, 248);
            label_cliente.Name = "label_cliente";
            label_cliente.Size = new Size(92, 23);
            label_cliente.TabIndex = 38;
            label_cliente.Text = "Clientes:";
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
            label2.Location = new Point(487, 2);
            label2.Name = "label2";
            label2.Size = new Size(105, 32);
            label2.TabIndex = 36;
            label2.Text = "Cliente";
            // 
            // btn_seleccionarCliente
            // 
            btn_seleccionarCliente.BackColor = Color.FromArgb(0, 84, 168);
            btn_seleccionarCliente.FlatAppearance.BorderSize = 0;
            btn_seleccionarCliente.FlatStyle = FlatStyle.Flat;
            btn_seleccionarCliente.Font = new Font("Century Gothic", 9F);
            btn_seleccionarCliente.ForeColor = Color.White;
            btn_seleccionarCliente.Location = new Point(18, 78);
            btn_seleccionarCliente.Margin = new Padding(3, 4, 3, 4);
            btn_seleccionarCliente.Name = "btn_seleccionarCliente";
            btn_seleccionarCliente.Size = new Size(159, 27);
            btn_seleccionarCliente.TabIndex = 33;
            btn_seleccionarCliente.Text = "Seleccionar cliente";
            btn_seleccionarCliente.UseVisualStyleBackColor = false;
            btn_seleccionarCliente.Click += btn_seleccionarCliente_Click;
            // 
            // Form_reservaCabaña
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form_reservaCabaña";
            Text = "Form_reservaCabaña";
            Load += Form_reservaCabaña_Load;
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
        private Button btn_cerrar;
        private Panel panel2;
        private Button btn_realizarReserva;
        private Button btn_cancelar;
        private Panel panel3;
        private Panel panel4;
        private Panel panel_butones;
        private Panel panel_picture;
        private Panel panel5;
        private Button btn_seleccionarCliente;
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
        private Label lb1;
        private Label lb_nombre;
        private Label lb3;
        private MonthCalendar mc_fechas;
        private Label label3;
        private Label label4;
        private Panel panel9;
        private Label label_cliente;
        private Label lb_capacidad;
        private Label lb_descripcion;
        private Label lb_precio;
        private Label label5;
        private Label label_fecha;
        private Panel panel10;
        private Label label_fechas;
        private Label label6;
        private Label label7;
    }
}