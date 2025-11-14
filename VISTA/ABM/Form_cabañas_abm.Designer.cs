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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
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
            cb_estado = new ComboBox();
            label7 = new Label();
            txt_nombreFiltro = new TextBox();
            btn_quitarFiltro = new Button();
            txt_precioNocheFiltro = new TextBox();
            label9 = new Label();
            txt_capacidadFiltro = new TextBox();
            label8 = new Label();
            label1 = new Label();
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
            panel1.Location = new Point(1034, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 948);
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
            gb_carga.ForeColor = Color.White;
            gb_carga.Location = new Point(0, 0);
            gb_carga.Name = "gb_carga";
            gb_carga.Size = new Size(284, 948);
            gb_carga.TabIndex = 0;
            gb_carga.TabStop = false;
            gb_carga.Text = "Carga de datos";
            // 
            // btn_borrar
            // 
            btn_borrar.Image = (Image)resources.GetObject("btn_borrar.Image");
            btn_borrar.Location = new Point(234, 287);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(44, 57);
            btn_borrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_borrar.TabIndex = 33;
            btn_borrar.TabStop = false;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(121, 178);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(151, 22);
            txt_descripcion.TabIndex = 21;
            // 
            // txt_precioNoche
            // 
            txt_precioNoche.Location = new Point(121, 129);
            txt_precioNoche.Name = "txt_precioNoche";
            txt_precioNoche.Size = new Size(151, 22);
            txt_precioNoche.TabIndex = 20;
            // 
            // flowLayoutPanel_imagenes
            // 
            flowLayoutPanel_imagenes.Location = new Point(9, 350);
            flowLayoutPanel_imagenes.Name = "flowLayoutPanel_imagenes";
            flowLayoutPanel_imagenes.Size = new Size(272, 92);
            flowLayoutPanel_imagenes.TabIndex = 30;
            // 
            // btn_imagenes
            // 
            btn_imagenes.BackColor = Color.FromArgb(0, 84, 168);
            btn_imagenes.FlatAppearance.BorderSize = 0;
            btn_imagenes.FlatStyle = FlatStyle.Flat;
            btn_imagenes.Location = new Point(170, 298);
            btn_imagenes.Name = "btn_imagenes";
            btn_imagenes.Size = new Size(47, 32);
            btn_imagenes.TabIndex = 22;
            btn_imagenes.Text = "...";
            btn_imagenes.UseVisualStyleBackColor = false;
            btn_imagenes.Click += btn_imagenes_Click;
            // 
            // pictureBox_imagenes
            // 
            pictureBox_imagenes.Location = new Point(49, 448);
            pictureBox_imagenes.MaximumSize = new Size(197, 179);
            pictureBox_imagenes.Name = "pictureBox_imagenes";
            pictureBox_imagenes.Size = new Size(197, 179);
            pictureBox_imagenes.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_imagenes.TabIndex = 28;
            pictureBox_imagenes.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 306);
            label6.Name = "label6";
            label6.Size = new Size(69, 17);
            label6.TabIndex = 27;
            label6.Text = "Imagenés:";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Location = new Point(186, 919);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(92, 23);
            btn_cancelar.TabIndex = 24;
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
            btn_guardar.Location = new Point(6, 919);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(92, 23);
            btn_guardar.TabIndex = 23;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 81);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 22;
            label2.Text = "Capacidad:";
            // 
            // txt_capacidad
            // 
            txt_capacidad.Location = new Point(121, 78);
            txt_capacidad.Name = "txt_capacidad";
            txt_capacidad.Size = new Size(151, 22);
            txt_capacidad.TabIndex = 19;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(121, 30);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(151, 22);
            txt_nombre.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 181);
            label5.Name = "label5";
            label5.Size = new Size(82, 17);
            label5.TabIndex = 16;
            label5.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 132);
            label4.Name = "label4";
            label4.Size = new Size(113, 17);
            label4.TabIndex = 15;
            label4.Text = "Precio por noche:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 34);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 14;
            label3.Text = "Nombre:";
            // 
            // panel2
            // 
            panel2.Controls.Add(gb_grilla);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1034, 948);
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
            gb_grilla.Size = new Size(1034, 948);
            gb_grilla.TabIndex = 0;
            gb_grilla.TabStop = false;
            gb_grilla.Text = "Lista de cabañas";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeight = 27;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ControlDark;
            dataGridView1.Location = new Point(3, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle8.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle9.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(0, 84, 168);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1028, 763);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_activarDesactivar);
            panel4.Controls.Add(btn_cerrar);
            panel4.Controls.Add(btn_eliminar);
            panel4.Controls.Add(btn_modificar);
            panel4.Controls.Add(btn_agregar);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 875);
            panel4.Name = "panel4";
            panel4.Size = new Size(1028, 70);
            panel4.TabIndex = 1;
            // 
            // btn_activarDesactivar
            // 
            btn_activarDesactivar.BackColor = Color.FromArgb(0, 84, 168);
            btn_activarDesactivar.FlatAppearance.BorderSize = 0;
            btn_activarDesactivar.FlatStyle = FlatStyle.Flat;
            btn_activarDesactivar.Location = new Point(449, 6);
            btn_activarDesactivar.Name = "btn_activarDesactivar";
            btn_activarDesactivar.Size = new Size(193, 23);
            btn_activarDesactivar.TabIndex = 8;
            btn_activarDesactivar.Text = "Activar/Desactivar cabaña";
            btn_activarDesactivar.UseVisualStyleBackColor = false;
            btn_activarDesactivar.Click += btn_activarDesactivar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Location = new Point(922, 44);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(103, 23);
            btn_cerrar.TabIndex = 7;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(0, 84, 168);
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Location = new Point(298, 6);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(128, 23);
            btn_eliminar.TabIndex = 6;
            btn_eliminar.Text = "Eliminar cabaña";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.FromArgb(0, 84, 168);
            btn_modificar.FlatAppearance.BorderSize = 0;
            btn_modificar.FlatStyle = FlatStyle.Flat;
            btn_modificar.Location = new Point(150, 6);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(128, 23);
            btn_modificar.TabIndex = 5;
            btn_modificar.Text = "Modificar cabaña";
            btn_modificar.UseVisualStyleBackColor = false;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.FromArgb(0, 84, 168);
            btn_agregar.FlatAppearance.BorderSize = 0;
            btn_agregar.FlatStyle = FlatStyle.Flat;
            btn_agregar.Location = new Point(3, 6);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(128, 23);
            btn_agregar.TabIndex = 4;
            btn_agregar.Text = "Agregar cabaña";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(cb_estado);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txt_nombreFiltro);
            panel3.Controls.Add(btn_quitarFiltro);
            panel3.Controls.Add(txt_precioNocheFiltro);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txt_capacidadFiltro);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(1028, 94);
            panel3.TabIndex = 0;
            // 
            // cb_estado
            // 
            cb_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_estado.FormattingEnabled = true;
            cb_estado.Location = new Point(429, 60);
            cb_estado.Name = "cb_estado";
            cb_estado.Size = new Size(137, 25);
            cb_estado.TabIndex = 29;
            cb_estado.SelectedIndexChanged += cb_estado_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(372, 63);
            label7.Name = "label7";
            label7.Size = new Size(51, 17);
            label7.TabIndex = 28;
            label7.Text = "Estado:";
            // 
            // txt_nombreFiltro
            // 
            txt_nombreFiltro.Location = new Point(216, 14);
            txt_nombreFiltro.Name = "txt_nombreFiltro";
            txt_nombreFiltro.Size = new Size(149, 22);
            txt_nombreFiltro.TabIndex = 27;
            txt_nombreFiltro.TextChanged += txt_nombreFiltro_TextChanged;
            // 
            // btn_quitarFiltro
            // 
            btn_quitarFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_quitarFiltro.BackColor = Color.FromArgb(0, 84, 168);
            btn_quitarFiltro.FlatAppearance.BorderSize = 0;
            btn_quitarFiltro.FlatStyle = FlatStyle.Flat;
            btn_quitarFiltro.Location = new Point(913, 38);
            btn_quitarFiltro.Name = "btn_quitarFiltro";
            btn_quitarFiltro.Size = new Size(103, 23);
            btn_quitarFiltro.TabIndex = 26;
            btn_quitarFiltro.Text = "Limpiar filtro";
            btn_quitarFiltro.UseVisualStyleBackColor = false;
            btn_quitarFiltro.Click += btn_quitarFiltro_Click;
            // 
            // txt_precioNocheFiltro
            // 
            txt_precioNocheFiltro.Location = new Point(699, 14);
            txt_precioNocheFiltro.Name = "txt_precioNocheFiltro";
            txt_precioNocheFiltro.Size = new Size(118, 22);
            txt_precioNocheFiltro.TabIndex = 25;
            txt_precioNocheFiltro.TextChanged += txt_precioNocheFiltro_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(580, 17);
            label9.Name = "label9";
            label9.Size = new Size(113, 17);
            label9.TabIndex = 24;
            label9.Text = "Precio por noche:";
            // 
            // txt_capacidadFiltro
            // 
            txt_capacidadFiltro.Location = new Point(472, 14);
            txt_capacidadFiltro.Name = "txt_capacidadFiltro";
            txt_capacidadFiltro.Size = new Size(94, 22);
            txt_capacidadFiltro.TabIndex = 23;
            txt_capacidadFiltro.TextChanged += txt_capacidadFiltro_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(387, 17);
            label8.Name = "label8";
            label8.Size = new Size(79, 17);
            label8.TabIndex = 22;
            label8.Text = "Capacidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 17);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 21;
            label1.Text = "Nombre:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Multiselect = true;
            // 
            // Form_cabañas_abm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1318, 948);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
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
        private Label label1;
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
        private ComboBox cb_estado;
        private Label label7;
        private Label label8;
        private Button btn_activarDesactivar;
    }
}