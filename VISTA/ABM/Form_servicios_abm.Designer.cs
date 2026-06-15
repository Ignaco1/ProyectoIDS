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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            groupBox_carga = new GroupBox();
            label2 = new Label();
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
            panel1.Location = new Point(1447, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 1333);
            panel1.TabIndex = 0;
            // 
            // groupBox_carga
            // 
            groupBox_carga.BackColor = Color.Gray;
            groupBox_carga.Controls.Add(label2);
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
            groupBox_carga.Margin = new Padding(3, 4, 3, 4);
            groupBox_carga.Name = "groupBox_carga";
            groupBox_carga.Padding = new Padding(3, 4, 3, 4);
            groupBox_carga.Size = new Size(373, 1333);
            groupBox_carga.TabIndex = 0;
            groupBox_carga.TabStop = false;
            groupBox_carga.Text = "Carga de datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 355);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(21, 22);
            label2.TabIndex = 39;
            label2.Text = "$";
            // 
            // pictureBox_imagenes
            // 
            pictureBox_imagenes.Location = new Point(68, 988);
            pictureBox_imagenes.Margin = new Padding(3, 4, 3, 4);
            pictureBox_imagenes.Name = "pictureBox_imagenes";
            pictureBox_imagenes.Size = new Size(252, 199);
            pictureBox_imagenes.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_imagenes.TabIndex = 36;
            pictureBox_imagenes.TabStop = false;
            // 
            // btn_borrar
            // 
            btn_borrar.Image = (Image)resources.GetObject("btn_borrar.Image");
            btn_borrar.Location = new Point(307, 765);
            btn_borrar.Margin = new Padding(3, 4, 3, 4);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(63, 63);
            btn_borrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_borrar.TabIndex = 38;
            btn_borrar.TabStop = false;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // flowLayoutPanel_imagenes
            // 
            flowLayoutPanel_imagenes.Location = new Point(17, 846);
            flowLayoutPanel_imagenes.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel_imagenes.Name = "flowLayoutPanel_imagenes";
            flowLayoutPanel_imagenes.Size = new Size(350, 122);
            flowLayoutPanel_imagenes.TabIndex = 37;
            // 
            // btn_imagenes
            // 
            btn_imagenes.BackColor = Color.FromArgb(0, 84, 168);
            btn_imagenes.FlatAppearance.BorderSize = 0;
            btn_imagenes.FlatStyle = FlatStyle.Flat;
            btn_imagenes.Location = new Point(169, 777);
            btn_imagenes.Margin = new Padding(3, 4, 3, 4);
            btn_imagenes.Name = "btn_imagenes";
            btn_imagenes.Size = new Size(76, 39);
            btn_imagenes.TabIndex = 34;
            btn_imagenes.Text = "...";
            btn_imagenes.UseVisualStyleBackColor = false;
            btn_imagenes.Click += btn_imagenes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 786);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 35;
            label1.Text = "Imagenés:";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_cancelar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Location = new Point(206, 1302);
            btn_cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(129, 27);
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
            btn_guardar.Location = new Point(6, 1300);
            btn_guardar.Margin = new Padding(3, 4, 3, 4);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(129, 27);
            btn_guardar.TabIndex = 30;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // check_listaCategorias
            // 
            check_listaCategorias.FormattingEnabled = true;
            check_listaCategorias.Location = new Point(103, 416);
            check_listaCategorias.Margin = new Padding(3, 4, 3, 4);
            check_listaCategorias.Name = "check_listaCategorias";
            check_listaCategorias.Size = new Size(258, 319);
            check_listaCategorias.TabIndex = 29;
            // 
            // txt_importe
            // 
            txt_importe.Location = new Point(103, 354);
            txt_importe.Margin = new Padding(3, 4, 3, 4);
            txt_importe.Name = "txt_importe";
            txt_importe.Size = new Size(258, 26);
            txt_importe.TabIndex = 28;
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(102, 129);
            txt_descripcion.Margin = new Padding(3, 4, 3, 4);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(259, 26);
            txt_descripcion.TabIndex = 27;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(102, 71);
            txt_nombre.Margin = new Padding(3, 4, 3, 4);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(259, 26);
            txt_nombre.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 416);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 25;
            label7.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 358);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 24;
            label6.Text = "Importe:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 133);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 23;
            label5.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 75);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 22;
            label4.Text = "Nombre:";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox_grilla);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1447, 1333);
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
            groupBox_grilla.Margin = new Padding(3, 4, 3, 4);
            groupBox_grilla.Name = "groupBox_grilla";
            groupBox_grilla.Padding = new Padding(3, 4, 3, 4);
            groupBox_grilla.Size = new Size(1447, 1333);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ControlDark;
            dataGridView1.Location = new Point(3, 97);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle4.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(0, 84, 168);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1441, 1130);
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
            panel4.Location = new Point(3, 23);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1441, 74);
            panel4.TabIndex = 1;
            // 
            // cb_categoriasFiltro
            // 
            cb_categoriasFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_categoriasFiltro.FormattingEnabled = true;
            cb_categoriasFiltro.Location = new Point(807, 22);
            cb_categoriasFiltro.Margin = new Padding(3, 4, 3, 4);
            cb_categoriasFiltro.Name = "cb_categoriasFiltro";
            cb_categoriasFiltro.Size = new Size(225, 28);
            cb_categoriasFiltro.TabIndex = 43;
            cb_categoriasFiltro.SelectedIndexChanged += cb_categoriasFiltro_SelectedIndexChanged;
            // 
            // btn_quitarFiltro
            // 
            btn_quitarFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_quitarFiltro.BackColor = Color.FromArgb(0, 84, 168);
            btn_quitarFiltro.FlatAppearance.BorderSize = 0;
            btn_quitarFiltro.FlatStyle = FlatStyle.Flat;
            btn_quitarFiltro.Location = new Point(1272, 22);
            btn_quitarFiltro.Margin = new Padding(3, 4, 3, 4);
            btn_quitarFiltro.Name = "btn_quitarFiltro";
            btn_quitarFiltro.Size = new Size(161, 27);
            btn_quitarFiltro.TabIndex = 42;
            btn_quitarFiltro.Text = "Limpiar filtro";
            btn_quitarFiltro.UseVisualStyleBackColor = false;
            btn_quitarFiltro.Click += btn_quitarFiltro_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(718, 26);
            label9.Name = "label9";
            label9.Size = new Size(88, 20);
            label9.TabIndex = 39;
            label9.Text = "Categoria:";
            // 
            // txt_nombreFiltro
            // 
            txt_nombreFiltro.Location = new Point(468, 21);
            txt_nombreFiltro.Margin = new Padding(3, 4, 3, 4);
            txt_nombreFiltro.Name = "txt_nombreFiltro";
            txt_nombreFiltro.Size = new Size(155, 26);
            txt_nombreFiltro.TabIndex = 38;
            txt_nombreFiltro.TextChanged += txt_nombreFiltro_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(394, 25);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
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
            panel3.Location = new Point(3, 1227);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1441, 102);
            panel3.TabIndex = 0;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_eliminar.BackColor = Color.FromArgb(0, 84, 168);
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Location = new Point(393, 10);
            btn_eliminar.Margin = new Padding(3, 4, 3, 4);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(167, 27);
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
            btn_modificar.Location = new Point(202, 10);
            btn_modificar.Margin = new Padding(3, 4, 3, 4);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(167, 27);
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
            btn_agregar.Location = new Point(13, 10);
            btn_agregar.Margin = new Padding(3, 4, 3, 4);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(167, 27);
            btn_agregar.TabIndex = 33;
            btn_agregar.Text = "Agregar servicio";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Location = new Point(1309, 73);
            btn_cerrar.Margin = new Padding(3, 4, 3, 4);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(129, 27);
            btn_cerrar.TabIndex = 32;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // Form_servicios_abm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 1333);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label2;
    }
}