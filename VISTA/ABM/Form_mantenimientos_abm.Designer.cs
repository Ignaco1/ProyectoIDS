namespace VISTA.ABM
{
    partial class Form_mantenimientos_abm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_mantenimientos_abm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            groupBox_carga = new GroupBox();
            pictureBox_imagenes = new PictureBox();
            btn_borrar = new PictureBox();
            flowLayoutPanel_imagenes = new FlowLayoutPanel();
            btn_imagenes = new Button();
            label1 = new Label();
            txt_descripcion = new TextBox();
            txt_nombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            panel2 = new Panel();
            groupBox_grilla = new GroupBox();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            btn_eliminar = new Button();
            btn_modificar = new Button();
            btn_agregar = new Button();
            btn_cerrar = new Button();
            panel3 = new Panel();
            btn_quitarFiltro = new Button();
            txt_nombreFiltro = new TextBox();
            label10 = new Label();
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
            panel1.Location = new Point(1464, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 1570);
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
            groupBox_carga.Controls.Add(txt_descripcion);
            groupBox_carga.Controls.Add(txt_nombre);
            groupBox_carga.Controls.Add(label5);
            groupBox_carga.Controls.Add(label4);
            groupBox_carga.Controls.Add(btn_cancelar);
            groupBox_carga.Controls.Add(btn_guardar);
            groupBox_carga.Dock = DockStyle.Fill;
            groupBox_carga.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox_carga.ForeColor = Color.White;
            groupBox_carga.Location = new Point(0, 0);
            groupBox_carga.Margin = new Padding(4, 5, 4, 5);
            groupBox_carga.Name = "groupBox_carga";
            groupBox_carga.Padding = new Padding(4, 5, 4, 5);
            groupBox_carga.Size = new Size(419, 1570);
            groupBox_carga.TabIndex = 0;
            groupBox_carga.TabStop = false;
            groupBox_carga.Text = "Carga de datos";
            // 
            // pictureBox_imagenes
            // 
            pictureBox_imagenes.Location = new Point(74, 962);
            pictureBox_imagenes.Margin = new Padding(4, 5, 4, 5);
            pictureBox_imagenes.MaximumSize = new Size(281, 298);
            pictureBox_imagenes.Name = "pictureBox_imagenes";
            pictureBox_imagenes.Size = new Size(281, 298);
            pictureBox_imagenes.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_imagenes.TabIndex = 41;
            pictureBox_imagenes.TabStop = false;
            // 
            // btn_borrar
            // 
            btn_borrar.Image = (Image)resources.GetObject("btn_borrar.Image");
            btn_borrar.Location = new Point(345, 662);
            btn_borrar.Margin = new Padding(4, 5, 4, 5);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(63, 95);
            btn_borrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_borrar.TabIndex = 43;
            btn_borrar.TabStop = false;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // flowLayoutPanel_imagenes
            // 
            flowLayoutPanel_imagenes.Location = new Point(15, 767);
            flowLayoutPanel_imagenes.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel_imagenes.Name = "flowLayoutPanel_imagenes";
            flowLayoutPanel_imagenes.Size = new Size(389, 172);
            flowLayoutPanel_imagenes.TabIndex = 42;
            // 
            // btn_imagenes
            // 
            btn_imagenes.BackColor = Color.FromArgb(0, 84, 168);
            btn_imagenes.FlatAppearance.BorderSize = 0;
            btn_imagenes.FlatStyle = FlatStyle.Flat;
            btn_imagenes.Location = new Point(187, 678);
            btn_imagenes.Margin = new Padding(4, 5, 4, 5);
            btn_imagenes.Name = "btn_imagenes";
            btn_imagenes.Size = new Size(67, 53);
            btn_imagenes.TabIndex = 39;
            btn_imagenes.Text = "...";
            btn_imagenes.UseVisualStyleBackColor = false;
            btn_imagenes.Click += btn_imagenes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 694);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 40;
            label1.Text = "Imagenés:";
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(136, 281);
            txt_descripcion.Margin = new Padding(4, 5, 4, 5);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(270, 30);
            txt_descripcion.TabIndex = 37;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(136, 197);
            txt_nombre.Margin = new Padding(4, 5, 4, 5);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(270, 30);
            txt_nombre.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 286);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 21);
            label5.TabIndex = 35;
            label5.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 202);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 34;
            label4.Text = "Nombre:";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Location = new Point(275, 1529);
            btn_cancelar.Margin = new Padding(4, 5, 4, 5);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(131, 31);
            btn_cancelar.TabIndex = 33;
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
            btn_guardar.Location = new Point(17, 1529);
            btn_guardar.Margin = new Padding(4, 5, 4, 5);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(131, 31);
            btn_guardar.TabIndex = 32;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox_grilla);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1464, 1570);
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
            groupBox_grilla.Margin = new Padding(4, 5, 4, 5);
            groupBox_grilla.Name = "groupBox_grilla";
            groupBox_grilla.Padding = new Padding(4, 5, 4, 5);
            groupBox_grilla.Size = new Size(1464, 1570);
            groupBox_grilla.TabIndex = 0;
            groupBox_grilla.TabStop = false;
            groupBox_grilla.Text = "Lista de mantenimientos";
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
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ControlDark;
            dataGridView1.Location = new Point(4, 141);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 84, 168);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1456, 1257);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Controls.Add(btn_eliminar);
            panel4.Controls.Add(btn_modificar);
            panel4.Controls.Add(btn_agregar);
            panel4.Controls.Add(btn_cerrar);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(4, 1398);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1456, 167);
            panel4.TabIndex = 1;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_eliminar.BackColor = Color.FromArgb(0, 84, 168);
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Location = new Point(533, 10);
            btn_eliminar.Margin = new Padding(4, 5, 4, 5);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(241, 31);
            btn_eliminar.TabIndex = 39;
            btn_eliminar.Text = "Eliminar mantenimiento";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_modificar.BackColor = Color.FromArgb(0, 84, 168);
            btn_modificar.FlatAppearance.BorderSize = 0;
            btn_modificar.FlatStyle = FlatStyle.Flat;
            btn_modificar.Location = new Point(270, 10);
            btn_modificar.Margin = new Padding(4, 5, 4, 5);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(241, 31);
            btn_modificar.TabIndex = 38;
            btn_modificar.Text = "Modificar mantenimiento";
            btn_modificar.UseVisualStyleBackColor = false;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_agregar.BackColor = Color.FromArgb(0, 84, 168);
            btn_agregar.FlatAppearance.BorderSize = 0;
            btn_agregar.FlatStyle = FlatStyle.Flat;
            btn_agregar.Location = new Point(6, 10);
            btn_agregar.Margin = new Padding(4, 5, 4, 5);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(241, 31);
            btn_agregar.TabIndex = 37;
            btn_agregar.Text = "Agregar mantenimiento";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Location = new Point(1321, 131);
            btn_cerrar.Margin = new Padding(4, 5, 4, 5);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(131, 31);
            btn_cerrar.TabIndex = 36;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(btn_quitarFiltro);
            panel3.Controls.Add(txt_nombreFiltro);
            panel3.Controls.Add(label10);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(4, 28);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1456, 113);
            panel3.TabIndex = 0;
            // 
            // btn_quitarFiltro
            // 
            btn_quitarFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_quitarFiltro.BackColor = Color.FromArgb(0, 84, 168);
            btn_quitarFiltro.FlatAppearance.BorderSize = 0;
            btn_quitarFiltro.FlatStyle = FlatStyle.Flat;
            btn_quitarFiltro.Location = new Point(1284, 38);
            btn_quitarFiltro.Margin = new Padding(4, 5, 4, 5);
            btn_quitarFiltro.Name = "btn_quitarFiltro";
            btn_quitarFiltro.Size = new Size(147, 31);
            btn_quitarFiltro.TabIndex = 43;
            btn_quitarFiltro.Text = "Limpiar filtro";
            btn_quitarFiltro.UseVisualStyleBackColor = false;
            btn_quitarFiltro.Click += btn_quitarFiltro_Click;
            // 
            // txt_nombreFiltro
            // 
            txt_nombreFiltro.Location = new Point(629, 40);
            txt_nombreFiltro.Margin = new Padding(4, 5, 4, 5);
            txt_nombreFiltro.Name = "txt_nombreFiltro";
            txt_nombreFiltro.Size = new Size(288, 30);
            txt_nombreFiltro.TabIndex = 40;
            txt_nombreFiltro.TextChanged += txt_nombreFiltro_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(536, 45);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(86, 21);
            label10.TabIndex = 39;
            label10.Text = "Nombre:";
            // 
            // Form_mantenimientos_abm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1883, 1570);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form_mantenimientos_abm";
            Text = "Form_mantenimientos_abm";
            Load += Form_mantenimientos_abm_Load;
            panel1.ResumeLayout(false);
            groupBox_carga.ResumeLayout(false);
            groupBox_carga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_imagenes).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_borrar).EndInit();
            panel2.ResumeLayout(false);
            groupBox_grilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox_carga;
        private GroupBox groupBox_grilla;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Panel panel3;
        private Button btn_cancelar;
        private Button btn_guardar;
        private TextBox txt_descripcion;
        private TextBox txt_nombre;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox_imagenes;
        private PictureBox btn_borrar;
        private FlowLayoutPanel flowLayoutPanel_imagenes;
        private Button btn_imagenes;
        private Label label1;
        private TextBox txt_nombreFiltro;
        private Label label10;
        private Button btn_quitarFiltro;
        private Button btn_eliminar;
        private Button btn_modificar;
        private Button btn_agregar;
        private Button btn_cerrar;
    }
}