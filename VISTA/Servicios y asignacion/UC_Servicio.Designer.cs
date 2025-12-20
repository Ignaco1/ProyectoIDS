namespace VISTA.Servicios_y_asignacion
{
    partial class UC_Servicio
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
            lb_categoria = new Label();
            lb_nombre = new Label();
            pb_imagenes = new PictureBox();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_imagenes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_anterior);
            panel1.Controls.Add(btn_siguiente);
            panel1.Controls.Add(lb_descripcion);
            panel1.Controls.Add(lb_precio);
            panel1.Controls.Add(lb_categoria);
            panel1.Controls.Add(lb_nombre);
            panel1.Controls.Add(pb_imagenes);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Century Gothic", 9F);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(513, 262);
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
            btn_anterior.Location = new Point(14, 47);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(14, 176);
            btn_anterior.TabIndex = 21;
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
            btn_siguiente.Location = new Point(178, 47);
            btn_siguiente.Name = "btn_siguiente";
            btn_siguiente.Size = new Size(14, 176);
            btn_siguiente.TabIndex = 20;
            btn_siguiente.TabStop = false;
            btn_siguiente.Text = ">";
            btn_siguiente.UseVisualStyleBackColor = false;
            btn_siguiente.Click += btn_siguiente_Click;
            // 
            // lb_descripcion
            // 
            lb_descripcion.AutoSize = true;
            lb_descripcion.Font = new Font("Century Gothic", 9F);
            lb_descripcion.Location = new Point(198, 177);
            lb_descripcion.Name = "lb_descripcion";
            lb_descripcion.Size = new Size(117, 21);
            lb_descripcion.TabIndex = 19;
            lb_descripcion.Text = "Descripción:";
            // 
            // lb_precio
            // 
            lb_precio.AutoSize = true;
            lb_precio.Font = new Font("Century Gothic", 9F);
            lb_precio.Location = new Point(198, 127);
            lb_precio.Name = "lb_precio";
            lb_precio.Size = new Size(85, 21);
            lb_precio.TabIndex = 18;
            lb_precio.Text = "Importe:";
            // 
            // lb_categoria
            // 
            lb_categoria.AutoSize = true;
            lb_categoria.Font = new Font("Century Gothic", 9F);
            lb_categoria.Location = new Point(198, 80);
            lb_categoria.Name = "lb_categoria";
            lb_categoria.Size = new Size(105, 21);
            lb_categoria.TabIndex = 17;
            lb_categoria.Text = "Categoria:";
            // 
            // lb_nombre
            // 
            lb_nombre.AutoSize = true;
            lb_nombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_nombre.Location = new Point(77, 17);
            lb_nombre.Name = "lb_nombre";
            lb_nombre.Size = new Size(70, 23);
            lb_nombre.TabIndex = 16;
            lb_nombre.Text = "label1";
            // 
            // pb_imagenes
            // 
            pb_imagenes.Location = new Point(14, 47);
            pb_imagenes.Name = "pb_imagenes";
            pb_imagenes.Size = new Size(178, 177);
            pb_imagenes.SizeMode = PictureBoxSizeMode.Zoom;
            pb_imagenes.TabIndex = 15;
            pb_imagenes.TabStop = false;
            // 
            // UC_Servicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_Servicio";
            Size = new Size(513, 262);
            Load += UC_Servicio_Load;
            Click += UC_Servicio_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_imagenes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_anterior;
        private Button btn_siguiente;
        private Label lb_descripcion;
        private Label lb_precio;
        private Label lb_categoria;
        private Label lb_nombre;
        private PictureBox pb_imagenes;
        private ToolTip toolTip1;
    }
}
