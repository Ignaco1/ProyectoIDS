namespace VISTA
{
    partial class UC_Cabaña
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btn_anterior = new Button();
            btn_siguiente = new Button();
            lb_descripcion = new Label();
            lb_precio = new Label();
            lb_capacidad = new Label();
            lb_nombre = new Label();
            pb_imagenes = new PictureBox();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_imagenes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_anterior);
            panel1.Controls.Add(btn_siguiente);
            panel1.Controls.Add(lb_descripcion);
            panel1.Controls.Add(lb_precio);
            panel1.Controls.Add(lb_capacidad);
            panel1.Controls.Add(lb_nombre);
            panel1.Controls.Add(pb_imagenes);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 237);
            panel1.TabIndex = 0;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // btn_anterior
            // 
            btn_anterior.BackColor = Color.Transparent;
            btn_anterior.FlatAppearance.BorderSize = 0;
            btn_anterior.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_anterior.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_anterior.FlatStyle = FlatStyle.Flat;
            btn_anterior.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_anterior.Location = new Point(12, 41);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(14, 176);
            btn_anterior.TabIndex = 14;
            btn_anterior.TabStop = false;
            btn_anterior.Text = "<";
            btn_anterior.UseVisualStyleBackColor = false;
            btn_anterior.Click += btn_anterior_Click;
            // 
            // btn_siguiente
            // 
            btn_siguiente.BackColor = Color.Transparent;
            btn_siguiente.FlatAppearance.BorderSize = 0;
            btn_siguiente.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_siguiente.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_siguiente.FlatStyle = FlatStyle.Flat;
            btn_siguiente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_siguiente.Location = new Point(176, 41);
            btn_siguiente.Name = "btn_siguiente";
            btn_siguiente.Size = new Size(14, 176);
            btn_siguiente.TabIndex = 13;
            btn_siguiente.TabStop = false;
            btn_siguiente.Text = ">";
            btn_siguiente.UseVisualStyleBackColor = false;
            btn_siguiente.Click += btn_siguiente_Click;
            // 
            // lb_descripcion
            // 
            lb_descripcion.AutoSize = true;
            lb_descripcion.Location = new Point(196, 171);
            lb_descripcion.Name = "lb_descripcion";
            lb_descripcion.Size = new Size(82, 17);
            lb_descripcion.TabIndex = 12;
            lb_descripcion.Text = "Descripción:";
            // 
            // lb_precio
            // 
            lb_precio.AutoSize = true;
            lb_precio.Location = new Point(196, 121);
            lb_precio.Name = "lb_precio";
            lb_precio.Size = new Size(113, 17);
            lb_precio.TabIndex = 11;
            lb_precio.Text = "Precio por noche:";
            // 
            // lb_capacidad
            // 
            lb_capacidad.AutoSize = true;
            lb_capacidad.Location = new Point(196, 74);
            lb_capacidad.Name = "lb_capacidad";
            lb_capacidad.Size = new Size(79, 17);
            lb_capacidad.TabIndex = 10;
            lb_capacidad.Text = "Capacidad:";
            // 
            // lb_nombre
            // 
            lb_nombre.AutoSize = true;
            lb_nombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_nombre.Location = new Point(75, 11);
            lb_nombre.Name = "lb_nombre";
            lb_nombre.Size = new Size(48, 16);
            lb_nombre.TabIndex = 9;
            lb_nombre.Text = "label1";
            // 
            // pb_imagenes
            // 
            pb_imagenes.Location = new Point(12, 41);
            pb_imagenes.Name = "pb_imagenes";
            pb_imagenes.Size = new Size(178, 177);
            pb_imagenes.SizeMode = PictureBoxSizeMode.Zoom;
            pb_imagenes.TabIndex = 8;
            pb_imagenes.TabStop = false;
            // 
            // UC_Cabaña
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Name = "UC_Cabaña";
            Size = new Size(478, 237);
            Load += UC_Cabaña_Load;
            Click += UC_Cabaña_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_imagenes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lb_descripcion;
        private Label lb_precio;
        private Label lb_capacidad;
        private Label lb_nombre;
        private PictureBox pb_imagenes;
        private Button btn_siguiente;
        private Button btn_anterior;
        private ToolTip toolTip1;
    }
}
