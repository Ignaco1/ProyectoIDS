namespace VISTA.ABM
{
    partial class Form_servicios_abm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_servicios_abm));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            groupBox_carga = new GroupBox();
            pictureBox_imagenes = new PictureBox();
            btn_borrar = new PictureBox();
            flowLayoutPanel_imagenes = new FlowLayoutPanel();
            btn_imagenes = new Button();
            label1 = new Label();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            check_listaCategorias = new CheckedListBox();
            txt_importe = new TextBox();
            txt_descripcion = new TextBox();
            txt_nombre = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            groupBox_grilla = new GroupBox();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            cb_categoriasFiltro = new ComboBox();
            btn_quitarFiltro = new Button();
            label9 = new Label();
            txt_nombreFiltro = new TextBox();
            label10 = new Label();
            panel3 = new Panel();
            btn_eliminar = new Button();
            btn_modificar = new Button();
            btn_agregar = new Button();
            btn_cerrar = new Button();
            panel1.SuspendLayout();
            groupBox_carga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_imagenes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_borrar).BeginInit();
            panel2.SuspendLayout();
            groupBox_grilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox_carga);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1025, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 948);
            panel1.TabIndex = 0;
            // 
            // groupBox_carga
            // 
            groupBox_carga.BackColor = Color.Gray;
            groupBox_carga.Controls.Add(pictureBox_imagenes);
            groupBox_carga.Controls.Add(btn_borrar);
            groupBox_carga.Controls.Add(flowLayoutPanel_imagenes);
            groupBox_carga.Controls.Add(btn_imagenes);
            groupBox_carga.Controls.Add(label1);
            groupBox_carga.Controls.Add(btn_cancelar);
            groupBox_carga.Controls.Add(btn_guardar);
            groupBox_carga.Controls.Add(check_listaCategorias);
            groupBox_carga.Controls.Add(txt_importe);
            groupBox_carga.Controls.Add(txt_descripcion);
            groupBox_carga.Controls.Add(txt_nombre);
            groupBox_carga.Controls.Add(label7);
            groupBox_carga.Controls.Add(label6);
            groupBox_carga.Controls.Add(label5);
            groupBox_carga.Controls.Add(label4);
            groupBox_carga.Dock = DockStyle.Fill;
            groupBox_carga.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox_carga.ForeColor = Color.White;
            groupBox_carga.Location = new Point(0, 0);
            groupBox_carga.Name = "groupBox_carga";
            groupBox_carga.Size = new Size(293, 948);
            groupBox_carga.TabIndex = 0;
            groupBox_carga.TabStop = false;
            groupBox_carga.Text = "Carga de datos";
            // 
            // pictureBox_imagenes
            // 
            pictureBox_imagenes.Location = new Point(70, 732);
            pictureBox_imagenes.MaximumSize = new Size(197, 179);
            pictureBox_imagenes.Name = "pictureBox_imagenes";
            pictureBox_imagenes.Size = new Size(159, 149);
            pictureBox_imagenes.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_imagenes.TabIndex = 36;
            pictureBox_imagenes.TabStop = false;
            // 
            // btn_borrar
            // 
            btn_borrar.Image = (Image)resources.GetObject("btn_borrar.Image");
            btn_borrar.Location = new Point(246, 571);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(44, 57);
            btn_borrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_borrar.TabIndex = 38;
            btn_borrar.TabStop = false;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // flowLayoutPanel_imagenes
            // 
            flowLayoutPanel_imagenes.Location = new Point(15, 634);
            flowLayoutPanel_imagenes.Name = "flowLayoutPanel_imagenes";
            flowLayoutPanel_imagenes.Size = new Size(272, 92);
            flowLayoutPanel_imagenes.TabIndex = 37;
            // 
            // btn_imagenes
            // 
            btn_imagenes.BackColor = Color.FromArgb(0, 84, 168);
            btn_imagenes.FlatAppearance.BorderSize = 0;
            btn_imagenes.FlatStyle = FlatStyle.Flat;
            btn_imagenes.Location = new Point(182, 582);
            btn_imagenes.Name = "btn_imagenes";
            btn_imagenes.Size = new Size(47, 32);
            btn_imagenes.TabIndex = 34;
            btn_imagenes.Text = "...";
            btn_imagenes.UseVisualStyleBackColor = false;
            btn_imagenes.Click += btn_imagenes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 590);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 35;
            label1.Text = "Imagenés:";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_cancelar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Location = new Point(198, 919);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(92, 23);
            btn_cancelar.TabIndex = 31;
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
            btn_guardar.Location = new Point(3, 919);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(92, 23);
            btn_guardar.TabIndex = 30;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // check_listaCategorias
            // 
            check_listaCategorias.FormattingEnabled = true;
            check_listaCategorias.Location = new Point(89, 316);
            check_listaCategorias.Name = "check_listaCategorias";
            check_listaCategorias.Size = new Size(198, 242);
            check_listaCategorias.TabIndex = 29;
            // 
            // txt_importe
            // 
            txt_importe.Location = new Point(89, 270);
            txt_importe.Name = "txt_importe";
            txt_importe.Size = new Size(155, 22);
            txt_importe.TabIndex = 28;
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(89, 148);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(190, 22);
            txt_descripcion.TabIndex = 27;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(89, 105);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(190, 22);
            txt_nombre.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 316);
            label7.Name = "label7";
            label7.Size = new Size(72, 17);
            label7.TabIndex = 25;
            label7.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 273);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 24;
            label6.Text = "Importe:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 151);
            label5.Name = "label5";
            label5.Size = new Size(82, 17);
            label5.TabIndex = 23;
            label5.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 108);
            label4.Name = "label4";
            label4.Size = new Size(59, 17);
            label4.TabIndex = 22;
            label4.Text = "Nombre:";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox_grilla);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1025, 948);
            panel2.TabIndex = 1;
            // 
            // groupBox_grilla
            // 
            groupBox_grilla.BackColor = Color.Gray;
            groupBox_grilla.Controls.Add(dataGridView1);
            groupBox_grilla.Controls.Add(panel4);
            groupBox_grilla.Controls.Add(panel3);
            groupBox_grilla.Dock = DockStyle.Fill;
            groupBox_grilla.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox_grilla.ForeColor = Color.White;
            groupBox_grilla.Location = new Point(0, 0);
            groupBox_grilla.Name = "groupBox_grilla";
            groupBox_grilla.Size = new Size(1025, 948);
            groupBox_grilla.TabIndex = 0;
            groupBox_grilla.TabStop = false;
            groupBox_grilla.Text = "Lista de servicios";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ControlDark;
            dataGridView1.Location = new Point(3, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle7.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle8.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(0, 84, 168);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1019, 794);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(cb_categoriasFiltro);
            panel4.Controls.Add(btn_quitarFiltro);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(txt_nombreFiltro);
            panel4.Controls.Add(label10);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(1019, 56);
            panel4.TabIndex = 1;
            // 
            // cb_categoriasFiltro
            // 
            cb_categoriasFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_categoriasFiltro.FormattingEnabled = true;
            cb_categoriasFiltro.Location = new Point(572, 17);
            cb_categoriasFiltro.Name = "cb_categoriasFiltro";
            cb_categoriasFiltro.Size = new Size(197, 25);
            cb_categoriasFiltro.TabIndex = 43;
            cb_categoriasFiltro.SelectedIndexChanged += cb_categoriasFiltro_SelectedIndexChanged;
            // 
            // btn_quitarFiltro
            // 
            btn_quitarFiltro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_quitarFiltro.BackColor = Color.FromArgb(0, 84, 168);
            btn_quitarFiltro.FlatAppearance.BorderSize = 0;
            btn_quitarFiltro.FlatStyle = FlatStyle.Flat;
            btn_quitarFiltro.Location = new Point(909, 17);
            btn_quitarFiltro.Name = "btn_quitarFiltro";
            btn_quitarFiltro.Size = new Size(103, 23);
            btn_quitarFiltro.TabIndex = 42;
            btn_quitarFiltro.Text = "Limpiar filtro";
            btn_quitarFiltro.UseVisualStyleBackColor = false;
            btn_quitarFiltro.Click += btn_quitarFiltro_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(494, 20);
            label9.Name = "label9";
            label9.Size = new Size(72, 17);
            label9.TabIndex = 39;
            label9.Text = "Categoria:";
            // 
            // txt_nombreFiltro
            // 
            txt_nombreFiltro.Location = new Point(253, 17);
            txt_nombreFiltro.Name = "txt_nombreFiltro";
            txt_nombreFiltro.Size = new Size(136, 22);
            txt_nombreFiltro.TabIndex = 38;
            txt_nombreFiltro.TextChanged += txt_nombreFiltro_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(188, 20);
            label10.Name = "label10";
            label10.Size = new Size(59, 17);
            label10.TabIndex = 37;
            label10.Text = "Nombre:";
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_eliminar);
            panel3.Controls.Add(btn_modificar);
            panel3.Controls.Add(btn_agregar);
            panel3.Controls.Add(btn_cerrar);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 868);
            panel3.Name = "panel3";
            panel3.Size = new Size(1019, 77);
            panel3.TabIndex = 0;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_eliminar.BackColor = Color.FromArgb(0, 84, 168);
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Location = new Point(344, 7);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(146, 23);
            btn_eliminar.TabIndex = 35;
            btn_eliminar.Text = "Eliminar servicio";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_modificar.BackColor = Color.FromArgb(0, 84, 168);
            btn_modificar.FlatAppearance.BorderSize = 0;
            btn_modificar.FlatStyle = FlatStyle.Flat;
            btn_modificar.Location = new Point(177, 7);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(146, 23);
            btn_modificar.TabIndex = 34;
            btn_modificar.Text = "Modificar servicio";
            btn_modificar.UseVisualStyleBackColor = false;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_agregar.BackColor = Color.FromArgb(0, 84, 168);
            btn_agregar.FlatAppearance.BorderSize = 0;
            btn_agregar.FlatStyle = FlatStyle.Flat;
            btn_agregar.Location = new Point(11, 7);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(146, 23);
            btn_agregar.TabIndex = 33;
            btn_agregar.Text = "Agregar servicio";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_cerrar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Location = new Point(924, 51);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(92, 23);
            btn_cerrar.TabIndex = 32;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // Form_servicios_abm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 948);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_servicios_abm";
            Text = "Form_servicios_abm";
            Load += Form_servicios_abm_Load;
            panel1.ResumeLayout(false);
            groupBox_carga.ResumeLayout(false);
            groupBox_carga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_imagenes).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_borrar).EndInit();
            panel2.ResumeLayout(false);
            groupBox_grilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox_grilla;
        private GroupBox groupBox_carga;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Panel panel3;
        private TextBox txt_importe;
        private TextBox txt_descripcion;
        private TextBox txt_nombre;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private CheckedListBox check_listaCategorias;
        private Button btn_cancelar;
        private Button btn_guardar;
        private Button btn_eliminar;
        private Button btn_modificar;
        private Button btn_agregar;
        private Button btn_cerrar;
        private Label label9;
        private TextBox txt_nombreFiltro;
        private Label label10;
        private Button btn_quitarFiltro;
        private ComboBox cb_categoriasFiltro;
        private PictureBox pictureBox_imagenes;
        private PictureBox btn_borrar;
        private FlowLayoutPanel flowLayoutPanel_imagenes;
        private Button btn_imagenes;
        private Label label1;
    }
}