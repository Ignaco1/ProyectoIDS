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
            label1 = new Label();
            lb_nombre = new Label();
            btn_cancelar = new Button();
            btn_realizarReserva = new Button();
            cb_clientes = new ComboBox();
            mc_fechas = new MonthCalendar();
            btn_anterior = new Button();
            btn_siguiente = new Button();
            lb_descripcion = new Label();
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
            panel1.Location = new Point(0, 619);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 46);
            panel1.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.Location = new Point(1048, 9);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(102, 23);
            btn_cerrar.TabIndex = 9;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lb_nombre);
            panel2.Controls.Add(btn_cancelar);
            panel2.Controls.Add(btn_realizarReserva);
            panel2.Controls.Add(cb_clientes);
            panel2.Controls.Add(mc_fechas);
            panel2.Controls.Add(btn_anterior);
            panel2.Controls.Add(btn_siguiente);
            panel2.Controls.Add(lb_descripcion);
            panel2.Controls.Add(lb_precio);
            panel2.Controls.Add(lb_capacidad);
            panel2.Controls.Add(pb_imagenes);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1164, 619);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(698, 341);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 28;
            label1.Text = "Clientes:";
            // 
            // lb_nombre
            // 
            lb_nombre.AutoSize = true;
            lb_nombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_nombre.Location = new Point(178, 23);
            lb_nombre.Name = "lb_nombre";
            lb_nombre.Size = new Size(71, 21);
            lb_nombre.TabIndex = 27;
            lb_nombre.Text = "Nombre";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancelar.Location = new Point(656, 484);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(132, 43);
            btn_cancelar.TabIndex = 26;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_realizarReserva
            // 
            btn_realizarReserva.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_realizarReserva.Location = new Point(385, 484);
            btn_realizarReserva.Name = "btn_realizarReserva";
            btn_realizarReserva.Size = new Size(132, 43);
            btn_realizarReserva.TabIndex = 25;
            btn_realizarReserva.Text = "Realizar reserva";
            btn_realizarReserva.UseVisualStyleBackColor = true;
            btn_realizarReserva.Click += btn_realizarReserva_Click;
            // 
            // cb_clientes
            // 
            cb_clientes.FormattingEnabled = true;
            cb_clientes.Location = new Point(760, 340);
            cb_clientes.Name = "cb_clientes";
            cb_clientes.Size = new Size(179, 23);
            cb_clientes.TabIndex = 24;
            // 
            // mc_fechas
            // 
            mc_fechas.Location = new Point(708, 42);
            mc_fechas.Name = "mc_fechas";
            mc_fechas.TabIndex = 22;
            // 
            // btn_anterior
            // 
            btn_anterior.BackColor = Color.Transparent;
            btn_anterior.FlatAppearance.BorderSize = 0;
            btn_anterior.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_anterior.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_anterior.FlatStyle = FlatStyle.Flat;
            btn_anterior.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_anterior.Location = new Point(87, 61);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(16, 227);
            btn_anterior.TabIndex = 21;
            btn_anterior.TabStop = false;
            btn_anterior.Text = "<";
            btn_anterior.UseVisualStyleBackColor = false;
            // 
            // btn_siguiente
            // 
            btn_siguiente.BackColor = Color.Transparent;
            btn_siguiente.FlatAppearance.BorderSize = 0;
            btn_siguiente.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_siguiente.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_siguiente.FlatStyle = FlatStyle.Flat;
            btn_siguiente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_siguiente.Location = new Point(326, 61);
            btn_siguiente.Name = "btn_siguiente";
            btn_siguiente.Size = new Size(16, 227);
            btn_siguiente.TabIndex = 20;
            btn_siguiente.TabStop = false;
            btn_siguiente.Text = ">";
            btn_siguiente.UseVisualStyleBackColor = false;
            // 
            // lb_descripcion
            // 
            lb_descripcion.AutoSize = true;
            lb_descripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_descripcion.Location = new Point(363, 73);
            lb_descripcion.Name = "lb_descripcion";
            lb_descripcion.Size = new Size(79, 17);
            lb_descripcion.TabIndex = 19;
            lb_descripcion.Text = "Descripción:";
            // 
            // lb_precio
            // 
            lb_precio.AutoSize = true;
            lb_precio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_precio.Location = new Point(116, 373);
            lb_precio.Name = "lb_precio";
            lb_precio.Size = new Size(111, 17);
            lb_precio.TabIndex = 18;
            lb_precio.Text = "Precio por noche:";
            // 
            // lb_capacidad
            // 
            lb_capacidad.AutoSize = true;
            lb_capacidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_capacidad.Location = new Point(116, 323);
            lb_capacidad.Name = "lb_capacidad";
            lb_capacidad.Size = new Size(73, 17);
            lb_capacidad.TabIndex = 17;
            lb_capacidad.Text = "Capacidad:";
            // 
            // pb_imagenes
            // 
            pb_imagenes.Location = new Point(87, 61);
            pb_imagenes.Name = "pb_imagenes";
            pb_imagenes.Size = new Size(255, 227);
            pb_imagenes.SizeMode = PictureBoxSizeMode.Zoom;
            pb_imagenes.TabIndex = 15;
            pb_imagenes.TabStop = false;
            // 
            // Form_realizarAlquiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 665);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label lb_descripcion;
        private Label lb_precio;
        private Label lb_capacidad;
        private PictureBox pb_imagenes;
        private Label label1;
        private Label lb_nombre;
    }
}