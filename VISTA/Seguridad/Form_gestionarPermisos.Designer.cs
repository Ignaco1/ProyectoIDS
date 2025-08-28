namespace VISTA
{
    partial class Form_gestionarPermisos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel_carga = new Panel();
            groupBox_carga = new GroupBox();
            txt_nombre = new TextBox();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            label1 = new Label();
            panel_lista_permisos = new Panel();
            groupBox_permisos = new GroupBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btn_quitarFiltro = new Button();
            txt_nombreFiltro = new TextBox();
            label2 = new Label();
            panel_botones = new Panel();
            btn_cerrar = new Button();
            btn_eliminarPermiso = new Button();
            btn_modificarPermiso = new Button();
            btn_crearPermiso = new Button();
            panel_carga.SuspendLayout();
            groupBox_carga.SuspendLayout();
            panel_lista_permisos.SuspendLayout();
            groupBox_permisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel_botones.SuspendLayout();
            SuspendLayout();
            // 
            // panel_carga
            // 
            panel_carga.Controls.Add(groupBox_carga);
            panel_carga.Dock = DockStyle.Right;
            panel_carga.Location = new Point(852, 0);
            panel_carga.Name = "panel_carga";
            panel_carga.Size = new Size(259, 454);
            panel_carga.TabIndex = 0;
            // 
            // groupBox_carga
            // 
            groupBox_carga.BackColor = Color.FromArgb(32, 30, 45);
            groupBox_carga.Controls.Add(txt_nombre);
            groupBox_carga.Controls.Add(btn_cancelar);
            groupBox_carga.Controls.Add(btn_guardar);
            groupBox_carga.Controls.Add(label1);
            groupBox_carga.Dock = DockStyle.Fill;
            groupBox_carga.ForeColor = Color.White;
            groupBox_carga.Location = new Point(0, 0);
            groupBox_carga.Name = "groupBox_carga";
            groupBox_carga.Size = new Size(259, 454);
            groupBox_carga.TabIndex = 0;
            groupBox_carga.TabStop = false;
            groupBox_carga.Text = "Carga de datos";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(66, 89);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(181, 23);
            txt_nombre.TabIndex = 7;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.SlateBlue;
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Location = new Point(161, 419);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(92, 23);
            btn_cancelar.TabIndex = 6;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_guardar.BackColor = Color.SlateBlue;
            btn_guardar.FlatAppearance.BorderSize = 0;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Location = new Point(6, 419);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(92, 23);
            btn_guardar.TabIndex = 5;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(6, 92);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // panel_lista_permisos
            // 
            panel_lista_permisos.BackColor = Color.FromArgb(80, 80, 80);
            panel_lista_permisos.Controls.Add(groupBox_permisos);
            panel_lista_permisos.Dock = DockStyle.Fill;
            panel_lista_permisos.Location = new Point(0, 0);
            panel_lista_permisos.Name = "panel_lista_permisos";
            panel_lista_permisos.Size = new Size(852, 454);
            panel_lista_permisos.TabIndex = 1;
            // 
            // groupBox_permisos
            // 
            groupBox_permisos.BackColor = Color.FromArgb(32, 30, 45);
            groupBox_permisos.Controls.Add(dataGridView1);
            groupBox_permisos.Controls.Add(panel1);
            groupBox_permisos.Controls.Add(panel_botones);
            groupBox_permisos.Dock = DockStyle.Fill;
            groupBox_permisos.ForeColor = Color.White;
            groupBox_permisos.Location = new Point(0, 0);
            groupBox_permisos.Name = "groupBox_permisos";
            groupBox_permisos.Size = new Size(852, 454);
            groupBox_permisos.TabIndex = 0;
            groupBox_permisos.TabStop = false;
            groupBox_permisos.Text = "Lista de permisos";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(80, 80, 80);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(42, 42, 42);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(42, 42, 42);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 27;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(95, 95, 95);
            dataGridView1.Location = new Point(3, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(177, 44, 120);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(80, 80, 80);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(159, 40, 108);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(846, 326);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 30, 45);
            panel1.Controls.Add(btn_quitarFiltro);
            panel1.Controls.Add(txt_nombreFiltro);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 55);
            panel1.TabIndex = 1;
            // 
            // btn_quitarFiltro
            // 
            btn_quitarFiltro.BackColor = Color.SlateBlue;
            btn_quitarFiltro.FlatAppearance.BorderSize = 0;
            btn_quitarFiltro.FlatStyle = FlatStyle.Flat;
            btn_quitarFiltro.ForeColor = Color.White;
            btn_quitarFiltro.Location = new Point(748, 16);
            btn_quitarFiltro.Name = "btn_quitarFiltro";
            btn_quitarFiltro.Size = new Size(95, 23);
            btn_quitarFiltro.TabIndex = 2;
            btn_quitarFiltro.Text = "Limpiar filtro";
            btn_quitarFiltro.UseVisualStyleBackColor = false;
            btn_quitarFiltro.Click += btn_quitarFiltro_Click;
            // 
            // txt_nombreFiltro
            // 
            txt_nombreFiltro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_nombreFiltro.Location = new Point(257, 17);
            txt_nombreFiltro.Name = "txt_nombreFiltro";
            txt_nombreFiltro.Size = new Size(215, 25);
            txt_nombreFiltro.TabIndex = 1;
            txt_nombreFiltro.TextChanged += txt_nombreFiltro_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(135, 20);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre de permiso:";
            // 
            // panel_botones
            // 
            panel_botones.BackColor = Color.FromArgb(32, 30, 45);
            panel_botones.Controls.Add(btn_cerrar);
            panel_botones.Controls.Add(btn_eliminarPermiso);
            panel_botones.Controls.Add(btn_modificarPermiso);
            panel_botones.Controls.Add(btn_crearPermiso);
            panel_botones.Dock = DockStyle.Bottom;
            panel_botones.Location = new Point(3, 400);
            panel_botones.Name = "panel_botones";
            panel_botones.Size = new Size(846, 51);
            panel_botones.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.BackColor = Color.SlateBlue;
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.ForeColor = Color.White;
            btn_cerrar.Location = new Point(751, 19);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(92, 23);
            btn_cerrar.TabIndex = 4;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_eliminarPermiso
            // 
            btn_eliminarPermiso.BackColor = Color.SlateBlue;
            btn_eliminarPermiso.FlatAppearance.BorderSize = 0;
            btn_eliminarPermiso.FlatStyle = FlatStyle.Flat;
            btn_eliminarPermiso.ForeColor = Color.White;
            btn_eliminarPermiso.Location = new Point(242, 6);
            btn_eliminarPermiso.Name = "btn_eliminarPermiso";
            btn_eliminarPermiso.Size = new Size(114, 23);
            btn_eliminarPermiso.TabIndex = 2;
            btn_eliminarPermiso.Text = "Eliminar permiso";
            btn_eliminarPermiso.UseVisualStyleBackColor = false;
            btn_eliminarPermiso.Click += btn_eliminarPermiso_Click;
            // 
            // btn_modificarPermiso
            // 
            btn_modificarPermiso.BackColor = Color.SlateBlue;
            btn_modificarPermiso.FlatAppearance.BorderSize = 0;
            btn_modificarPermiso.FlatStyle = FlatStyle.Flat;
            btn_modificarPermiso.ForeColor = SystemColors.Window;
            btn_modificarPermiso.Location = new Point(112, 6);
            btn_modificarPermiso.Name = "btn_modificarPermiso";
            btn_modificarPermiso.Size = new Size(113, 23);
            btn_modificarPermiso.TabIndex = 1;
            btn_modificarPermiso.Text = "Modificar permiso";
            btn_modificarPermiso.UseVisualStyleBackColor = false;
            btn_modificarPermiso.Click += btn_modificarPermiso_Click;
            // 
            // btn_crearPermiso
            // 
            btn_crearPermiso.BackColor = Color.SlateBlue;
            btn_crearPermiso.FlatAppearance.BorderSize = 0;
            btn_crearPermiso.FlatStyle = FlatStyle.Flat;
            btn_crearPermiso.ForeColor = Color.White;
            btn_crearPermiso.Location = new Point(3, 6);
            btn_crearPermiso.Name = "btn_crearPermiso";
            btn_crearPermiso.Size = new Size(92, 23);
            btn_crearPermiso.TabIndex = 0;
            btn_crearPermiso.Text = "Crear permiso";
            btn_crearPermiso.UseVisualStyleBackColor = false;
            btn_crearPermiso.Click += btn_crearPermiso_Click;
            // 
            // Form_gestionarPermisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1111, 454);
            Controls.Add(panel_lista_permisos);
            Controls.Add(panel_carga);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_gestionarPermisos";
            Text = "Form_gestionarPermisos";
            Load += Form_gestionarPermisos_Load;
            panel_carga.ResumeLayout(false);
            groupBox_carga.ResumeLayout(false);
            groupBox_carga.PerformLayout();
            panel_lista_permisos.ResumeLayout(false);
            groupBox_permisos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_botones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_carga;
        private GroupBox groupBox_carga;
        private Panel panel_lista_permisos;
        private GroupBox groupBox_permisos;
        private Label label1;
        private TextBox txt_nombre;
        private Button btn_cancelar;
        private Button btn_guardar;
        private Panel panel_botones;
        private Button btn_cerrar;
        private Button btn_eliminarPermiso;
        private Button btn_modificarPermiso;
        private Button btn_crearPermiso;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btn_quitarFiltro;
        private TextBox txt_nombreFiltro;
        private Label label2;
    }
}