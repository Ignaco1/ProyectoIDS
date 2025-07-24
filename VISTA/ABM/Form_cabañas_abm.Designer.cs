namespace VISTA.ABM
{
    partial class Form_cabañas_abm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_cabañas_abm));
            panel1 = new Panel();
            gb_carga = new GroupBox();
            btn_borrar = new PictureBox();
            txt_descripcion = new TextBox();
            txt_precioNoche = new TextBox();
            flowLayoutPanel_imagenes = new FlowLayoutPanel();
            btn_imagenes = new Button();
            pictureBox_imagenes = new PictureBox();
            label6 = new Label();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            label2 = new Label();
            txt_capacidad = new TextBox();
            txt_nombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            gb_grilla = new GroupBox();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            btn_activarDesactivar = new Button();
            btn_cerrar = new Button();
            btn_eliminar = new Button();
            btn_modificar = new Button();
            btn_agregar = new Button();
            panel3 = new Panel();
            txt_nombreFiltro = new TextBox();
            btn_quitarFiltro = new Button();
            txt_precioNocheFiltro = new TextBox();
            label9 = new Label();
            txt_capacidadFiltro = new TextBox();
            label8 = new Label();
            label1 = new Label();
            btn_filtrar = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            gb_carga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_borrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_imagenes).BeginInit();
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
            panel1.Location = new Point(880, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 665);
            panel1.TabIndex = 0;
            // 
            // gb_carga
            // 
            gb_carga.Controls.Add(btn_borrar);
            gb_carga.Controls.Add(txt_descripcion);
            gb_carga.Controls.Add(txt_precioNoche);
            gb_carga.Controls.Add(flowLayoutPanel_imagenes);
            gb_carga.Controls.Add(btn_imagenes);
            gb_carga.Controls.Add(pictureBox_imagenes);
            gb_carga.Controls.Add(label6);
            gb_carga.Controls.Add(btn_cancelar);
            gb_carga.Controls.Add(btn_guardar);
            gb_carga.Controls.Add(label2);
            gb_carga.Controls.Add(txt_capacidad);
            gb_carga.Controls.Add(txt_nombre);
            gb_carga.Controls.Add(label5);
            gb_carga.Controls.Add(label4);
            gb_carga.Controls.Add(label3);
            gb_carga.Dock = DockStyle.Fill;
            gb_carga.Location = new Point(0, 0);
            gb_carga.Name = "gb_carga";
            gb_carga.Size = new Size(284, 665);
            gb_carga.TabIndex = 0;
            gb_carga.TabStop = false;
            gb_carga.Text = "Carga de datos";
            // 
            // btn_borrar
            // 
            btn_borrar.Image = (Image)resources.GetObject("btn_borrar.Image");
            btn_borrar.Location = new Point(234, 286);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(44, 50);
            btn_borrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_borrar.TabIndex = 33;
            btn_borrar.TabStop = false;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(121, 177);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(151, 23);
            txt_descripcion.TabIndex = 32;
            // 
            // txt_precioNoche
            // 
            txt_precioNoche.Location = new Point(121, 134);
            txt_precioNoche.Name = "txt_precioNoche";
            txt_precioNoche.Size = new Size(151, 23);
            txt_precioNoche.TabIndex = 31;
            // 
            // flowLayoutPanel_imagenes
            // 
            flowLayoutPanel_imagenes.Location = new Point(6, 342);
            flowLayoutPanel_imagenes.Name = "flowLayoutPanel_imagenes";
            flowLayoutPanel_imagenes.Size = new Size(272, 81);
            flowLayoutPanel_imagenes.TabIndex = 30;
            // 
            // btn_imagenes
            // 
            btn_imagenes.Location = new Point(170, 296);
            btn_imagenes.Name = "btn_imagenes";
            btn_imagenes.Size = new Size(47, 28);
            btn_imagenes.TabIndex = 29;
            btn_imagenes.Text = "...";
            btn_imagenes.UseVisualStyleBackColor = true;
            btn_imagenes.Click += btn_imagenes_Click;
            // 
            // pictureBox_imagenes
            // 
            pictureBox_imagenes.Location = new Point(46, 462);
            pictureBox_imagenes.Name = "pictureBox_imagenes";
            pictureBox_imagenes.Size = new Size(197, 158);
            pictureBox_imagenes.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_imagenes.TabIndex = 28;
            pictureBox_imagenes.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 303);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 27;
            label6.Text = "Imagenés:";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.Location = new Point(179, 630);
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
            btn_guardar.Location = new Point(3, 630);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(102, 23);
            btn_guardar.TabIndex = 25;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 92);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 22;
            label2.Text = "Capacidad:";
            // 
            // txt_capacidad
            // 
            txt_capacidad.Location = new Point(121, 89);
            txt_capacidad.Name = "txt_capacidad";
            txt_capacidad.Size = new Size(151, 23);
            txt_capacidad.TabIndex = 19;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(121, 47);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(151, 23);
            txt_nombre.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 180);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 16;
            label5.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 137);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 15;
            label4.Text = "Precio por noche:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 50);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 14;
            label3.Text = "Nombre:";
            // 
            // panel2
            // 
            panel2.Controls.Add(gb_grilla);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 665);
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
            gb_grilla.Size = new Size(880, 665);
            gb_grilla.TabIndex = 0;
            gb_grilla.TabStop = false;
            gb_grilla.Text = "Lista de cabañas";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(874, 511);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_activarDesactivar);
            panel4.Controls.Add(btn_cerrar);
            panel4.Controls.Add(btn_eliminar);
            panel4.Controls.Add(btn_modificar);
            panel4.Controls.Add(btn_agregar);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 600);
            panel4.Name = "panel4";
            panel4.Size = new Size(874, 62);
            panel4.TabIndex = 1;
            // 
            // btn_activarDesactivar
            // 
            btn_activarDesactivar.Location = new Point(368, 6);
            btn_activarDesactivar.Name = "btn_activarDesactivar";
            btn_activarDesactivar.Size = new Size(161, 23);
            btn_activarDesactivar.TabIndex = 8;
            btn_activarDesactivar.Text = "Activar/Desactivar cabaña";
            btn_activarDesactivar.UseVisualStyleBackColor = true;
            btn_activarDesactivar.Click += btn_activarDesactivar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.Location = new Point(762, 31);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(102, 23);
            btn_cerrar.TabIndex = 7;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(250, 6);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(102, 23);
            btn_eliminar.TabIndex = 6;
            btn_eliminar.Text = "Eliminar cabaña";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(123, 6);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(110, 23);
            btn_modificar.TabIndex = 5;
            btn_modificar.Text = "Modificar cabaña";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(3, 6);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(102, 23);
            btn_agregar.TabIndex = 4;
            btn_agregar.Text = "Agregar cabaña";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txt_nombreFiltro);
            panel3.Controls.Add(btn_quitarFiltro);
            panel3.Controls.Add(txt_precioNocheFiltro);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txt_capacidadFiltro);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btn_filtrar);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(874, 70);
            panel3.TabIndex = 0;
            // 
            // txt_nombreFiltro
            // 
            txt_nombreFiltro.Location = new Point(110, 24);
            txt_nombreFiltro.Name = "txt_nombreFiltro";
            txt_nombreFiltro.Size = new Size(149, 23);
            txt_nombreFiltro.TabIndex = 27;
            // 
            // btn_quitarFiltro
            // 
            btn_quitarFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_quitarFiltro.Location = new Point(769, 37);
            btn_quitarFiltro.Name = "btn_quitarFiltro";
            btn_quitarFiltro.Size = new Size(102, 23);
            btn_quitarFiltro.TabIndex = 26;
            btn_quitarFiltro.Text = "Quitar filtro";
            btn_quitarFiltro.UseVisualStyleBackColor = true;
            btn_quitarFiltro.Click += btn_quitarFiltro_Click;
            // 
            // txt_precioNocheFiltro
            // 
            txt_precioNocheFiltro.Location = new Point(585, 24);
            txt_precioNocheFiltro.Name = "txt_precioNocheFiltro";
            txt_precioNocheFiltro.Size = new Size(118, 23);
            txt_precioNocheFiltro.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(479, 27);
            label9.Name = "label9";
            label9.Size = new Size(100, 15);
            label9.TabIndex = 24;
            label9.Text = "Precio por noche:";
            // 
            // txt_capacidadFiltro
            // 
            txt_capacidadFiltro.Location = new Point(358, 24);
            txt_capacidadFiltro.Name = "txt_capacidadFiltro";
            txt_capacidadFiltro.Size = new Size(89, 23);
            txt_capacidadFiltro.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(286, 27);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 22;
            label8.Text = "Capacidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 27);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 21;
            label1.Text = "Nombre:";
            // 
            // btn_filtrar
            // 
            btn_filtrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_filtrar.Location = new Point(769, 10);
            btn_filtrar.Name = "btn_filtrar";
            btn_filtrar.Size = new Size(102, 23);
            btn_filtrar.TabIndex = 19;
            btn_filtrar.Text = "Filtrar";
            btn_filtrar.UseVisualStyleBackColor = true;
            btn_filtrar.Click += btn_filtrar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Multiselect = true;
            // 
            // Form_cabañas_abm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 665);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_cabañas_abm";
            Text = "Form_cabañas_abm";
            Load += Form_cabañas_abm_Load;
            panel1.ResumeLayout(false);
            gb_carga.ResumeLayout(false);
            gb_carga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_borrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_imagenes).EndInit();
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
        private Panel panel3;
        private Panel panel4;
        private TextBox txt_nombreFiltro;
        private Button btn_quitarFiltro;
        private TextBox txt_precioNocheFiltro;
        private Label label9;
        private TextBox txt_capacidadFiltro;
        private Label label8;
        private Label label1;
        private Button btn_filtrar;
        private Button btn_cerrar;
        private Button btn_eliminar;
        private Button btn_modificar;
        private Button btn_agregar;
        private DataGridView dataGridView1;
        private TextBox txt_email;
        private Label label2;
        private ComboBox cb_tipoUsuario;
        private TextBox txt_usuario;
        private TextBox txt_capacidad;
        private TextBox txt_nombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btn_activarDesactivar;
        private Button btn_cancelar;
        private Button btn_guardar;
        private Button btn_imagenes;
        private PictureBox pictureBox_imagenes;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel_imagenes;
        private TextBox txt_descripcion;
        private TextBox txt_precioNoche;
        private OpenFileDialog openFileDialog1;
        private PictureBox btn_borrar;
    }
}