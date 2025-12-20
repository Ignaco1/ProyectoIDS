namespace VISTA.Cabañas_y_alquiler
{
    partial class Form_realizarAlquiler
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
            btn_cerrar = new Button();
            panel2 = new Panel();
            lb_descripcion = new Label();
            panel3 = new Panel();
            btn_seleccionarCliente = new Button();
            label3 = new Label();
            label2 = new Label();
            label_cliente = new Label();
            lb_nombre = new Label();
            btn_cancelar = new Button();
            btn_realizarReserva = new Button();
            mc_fechas = new MonthCalendar();
            btn_anterior = new Button();
            btn_siguiente = new Button();
            lb_precio = new Label();
            lb_capacidad = new Label();
            pb_imagenes = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_imagenes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_cerrar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 1505);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1883, 75);
            panel1.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Font = new Font("Century Gothic", 9F);
            btn_cerrar.ForeColor = Color.White;
            btn_cerrar.Location = new Point(1718, 15);
            btn_cerrar.Margin = new Padding(4, 5, 4, 5);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(146, 38);
            btn_cerrar.TabIndex = 9;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lb_descripcion);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btn_seleccionarCliente);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label_cliente);
            panel2.Controls.Add(lb_nombre);
            panel2.Controls.Add(btn_cancelar);
            panel2.Controls.Add(btn_realizarReserva);
            panel2.Controls.Add(mc_fechas);
            panel2.Controls.Add(btn_anterior);
            panel2.Controls.Add(btn_siguiente);
            panel2.Controls.Add(lb_precio);
            panel2.Controls.Add(lb_capacidad);
            panel2.Controls.Add(pb_imagenes);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1883, 1505);
            panel2.TabIndex = 1;
            // 
            // lb_descripcion
            // 
            lb_descripcion.Anchor = AnchorStyles.Left;
            lb_descripcion.AutoSize = true;
            lb_descripcion.Font = new Font("Century Gothic", 9.75F);
            lb_descripcion.ForeColor = Color.White;
            lb_descripcion.Location = new Point(644, 214);
            lb_descripcion.Margin = new Padding(4, 0, 4, 0);
            lb_descripcion.Name = "lb_descripcion";
            lb_descripcion.Size = new Size(128, 23);
            lb_descripcion.TabIndex = 34;
            lb_descripcion.Text = "Descripcion:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Enabled = false;
            panel3.Location = new Point(1404, 505);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(443, 2);
            panel3.TabIndex = 33;
            // 
            // btn_seleccionarCliente
            // 
            btn_seleccionarCliente.BackColor = Color.FromArgb(0, 84, 168);
            btn_seleccionarCliente.FlatAppearance.BorderSize = 0;
            btn_seleccionarCliente.FlatStyle = FlatStyle.Flat;
            btn_seleccionarCliente.Font = new Font("Century Gothic", 9F);
            btn_seleccionarCliente.ForeColor = Color.White;
            btn_seleccionarCliente.Location = new Point(1294, 827);
            btn_seleccionarCliente.Margin = new Padding(4, 5, 4, 5);
            btn_seleccionarCliente.Name = "btn_seleccionarCliente";
            btn_seleccionarCliente.Size = new Size(170, 38);
            btn_seleccionarCliente.TabIndex = 32;
            btn_seleccionarCliente.Text = "Seleccionar cliene";
            btn_seleccionarCliente.UseVisualStyleBackColor = false;
            btn_seleccionarCliente.Click += btn_seleccionarCliente_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1438, 472);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(361, 28);
            label3.TabIndex = 31;
            label3.Text = "Dias ocupados de la cabaña.";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1340, 472);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 30;
            label2.Text = "Negrita:";
            // 
            // label_cliente
            // 
            label_cliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_cliente.AutoSize = true;
            label_cliente.Font = new Font("Century Gothic", 9.75F);
            label_cliente.ForeColor = Color.White;
            label_cliente.Location = new Point(1336, 931);
            label_cliente.Margin = new Padding(4, 0, 4, 0);
            label_cliente.Name = "label_cliente";
            label_cliente.Size = new Size(92, 23);
            label_cliente.TabIndex = 28;
            label_cliente.Text = "Clientes:";
            // 
            // lb_nombre
            // 
            lb_nombre.AutoSize = true;
            lb_nombre.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_nombre.ForeColor = Color.White;
            lb_nombre.Location = new Point(317, 111);
            lb_nombre.Margin = new Padding(4, 0, 4, 0);
            lb_nombre.Name = "lb_nombre";
            lb_nombre.Size = new Size(107, 28);
            lb_nombre.TabIndex = 27;
            lb_nombre.Text = "Nombre";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom;
            btn_cancelar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.Location = new Point(1066, 1367);
            btn_cancelar.Margin = new Padding(4, 5, 4, 5);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(189, 72);
            btn_cancelar.TabIndex = 26;
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
            btn_realizarReserva.Location = new Point(679, 1367);
            btn_realizarReserva.Margin = new Padding(4, 5, 4, 5);
            btn_realizarReserva.Name = "btn_realizarReserva";
            btn_realizarReserva.Size = new Size(189, 72);
            btn_realizarReserva.TabIndex = 25;
            btn_realizarReserva.Text = "Realizar reserva";
            btn_realizarReserva.UseVisualStyleBackColor = false;
            btn_realizarReserva.Click += btn_realizarReserva_Click;
            // 
            // mc_fechas
            // 
            mc_fechas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mc_fechas.Location = new Point(1395, 128);
            mc_fechas.Margin = new Padding(13, 15, 13, 15);
            mc_fechas.MaxSelectionCount = 30;
            mc_fechas.Name = "mc_fechas";
            mc_fechas.TabIndex = 22;
            mc_fechas.DateSelected += mc_fechas_DateSelected;
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
            btn_anterior.Location = new Point(130, 186);
            btn_anterior.Margin = new Padding(4, 5, 4, 5);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(23, 487);
            btn_anterior.TabIndex = 21;
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
            btn_siguiente.Location = new Point(584, 186);
            btn_siguiente.Margin = new Padding(4, 5, 4, 5);
            btn_siguiente.Name = "btn_siguiente";
            btn_siguiente.Size = new Size(23, 487);
            btn_siguiente.TabIndex = 20;
            btn_siguiente.TabStop = false;
            btn_siguiente.Text = ">";
            btn_siguiente.UseVisualStyleBackColor = false;
            btn_siguiente.Click += btn_siguiente_Click;
            // 
            // lb_precio
            // 
            lb_precio.Anchor = AnchorStyles.Left;
            lb_precio.AutoSize = true;
            lb_precio.Font = new Font("Century Gothic", 9.75F);
            lb_precio.ForeColor = Color.White;
            lb_precio.Location = new Point(197, 791);
            lb_precio.Margin = new Padding(4, 0, 4, 0);
            lb_precio.Name = "lb_precio";
            lb_precio.Size = new Size(183, 23);
            lb_precio.TabIndex = 18;
            lb_precio.Text = "Precio por noche:";
            // 
            // lb_capacidad
            // 
            lb_capacidad.Anchor = AnchorStyles.Left;
            lb_capacidad.AutoSize = true;
            lb_capacidad.Font = new Font("Century Gothic", 9.75F);
            lb_capacidad.ForeColor = Color.White;
            lb_capacidad.Location = new Point(197, 708);
            lb_capacidad.Margin = new Padding(4, 0, 4, 0);
            lb_capacidad.Name = "lb_capacidad";
            lb_capacidad.Size = new Size(131, 23);
            lb_capacidad.TabIndex = 17;
            lb_capacidad.Text = "Capacidad:";
            // 
            // pb_imagenes
            // 
            pb_imagenes.Anchor = AnchorStyles.Left;
            pb_imagenes.Location = new Point(130, 184);
            pb_imagenes.Margin = new Padding(4, 5, 4, 5);
            pb_imagenes.Name = "pb_imagenes";
            pb_imagenes.Size = new Size(477, 487);
            pb_imagenes.SizeMode = PictureBoxSizeMode.Zoom;
            pb_imagenes.TabIndex = 15;
            pb_imagenes.TabStop = false;
            // 
            // Form_realizarAlquiler
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1883, 1580);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form_realizarAlquiler";
            Text = "Form_realizarAlquiler";
            Load += Form_realizarAlquiler_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_imagenes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_cerrar;
        private Panel panel2;
        private Button btn_cancelar;
        private Button btn_realizarReserva;
        private ComboBox cb_clientes;
        private MonthCalendar mc_fechas;
        private Button btn_anterior;
        private Button btn_siguiente;
        private Label lb_precio;
        private Label lb_capacidad;
        private PictureBox pb_imagenes;
        private Label label_cliente;
        private Label lb_nombre;
        private Label label3;
        private Label label2;
        private Button btn_seleccionarCliente;
        private Panel panel3;
        private Label lb_descripcion;
    }
}