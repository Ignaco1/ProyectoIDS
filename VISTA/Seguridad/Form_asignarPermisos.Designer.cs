namespace VISTA
{
    partial class Form_asignarPermisos
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
            label2 = new Label();
            check_listaPermisos = new CheckedListBox();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            txt_nombre = new TextBox();
            label1 = new Label();
            panel_lista_permisos = new Panel();
            groupBox_grupos = new GroupBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            txt_nombreGrupoFiltro = new TextBox();
            label4 = new Label();
            btn_quitarFiltro = new Button();
            txt_nombrePermisoFiltro = new TextBox();
            label3 = new Label();
            panel_botones = new Panel();
            btn_modificarPermisos = new Button();
            btn_cerrar = new Button();
            btn_asignarPermisos = new Button();
            panel_carga.SuspendLayout();
            groupBox_carga.SuspendLayout();
            panel_lista_permisos.SuspendLayout();
            groupBox_grupos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel_botones.SuspendLayout();
            SuspendLayout();
            // 
            // panel_carga
            // 
            panel_carga.Controls.Add(groupBox_carga);
            panel_carga.Dock = DockStyle.Right;
            panel_carga.Location = new Point(916, 0);
            panel_carga.Name = "panel_carga";
            panel_carga.Size = new Size(259, 729);
            panel_carga.TabIndex = 2;
            // 
            // groupBox_carga
            // 
            groupBox_carga.Controls.Add(label2);
            groupBox_carga.Controls.Add(check_listaPermisos);
            groupBox_carga.Controls.Add(btn_cancelar);
            groupBox_carga.Controls.Add(btn_guardar);
            groupBox_carga.Controls.Add(txt_nombre);
            groupBox_carga.Controls.Add(label1);
            groupBox_carga.Dock = DockStyle.Fill;
            groupBox_carga.ForeColor = Color.White;
            groupBox_carga.Location = new Point(0, 0);
            groupBox_carga.Name = "groupBox_carga";
            groupBox_carga.Size = new Size(259, 729);
            groupBox_carga.TabIndex = 0;
            groupBox_carga.TabStop = false;
            groupBox_carga.Text = "Carga de datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 131);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 11;
            label2.Text = "Permisos:";
            // 
            // check_listaPermisos
            // 
            check_listaPermisos.FormattingEnabled = true;
            check_listaPermisos.Location = new Point(74, 131);
            check_listaPermisos.Name = "check_listaPermisos";
            check_listaPermisos.Size = new Size(179, 446);
            check_listaPermisos.TabIndex = 10;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Location = new Point(164, 700);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(92, 23);
            btn_cancelar.TabIndex = 9;
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
            btn_guardar.Location = new Point(6, 700);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(92, 23);
            btn_guardar.TabIndex = 8;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(107, 76);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(146, 22);
            txt_nombre.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 79);
            label1.Name = "label1";
            label1.Size = new Size(97, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre grupo:";
            // 
            // panel_lista_permisos
            // 
            panel_lista_permisos.Controls.Add(groupBox_grupos);
            panel_lista_permisos.Dock = DockStyle.Fill;
            panel_lista_permisos.Location = new Point(0, 0);
            panel_lista_permisos.Name = "panel_lista_permisos";
            panel_lista_permisos.Size = new Size(916, 729);
            panel_lista_permisos.TabIndex = 3;
            // 
            // groupBox_grupos
            // 
            groupBox_grupos.BackColor = Color.Gray;
            groupBox_grupos.Controls.Add(dataGridView1);
            groupBox_grupos.Controls.Add(panel1);
            groupBox_grupos.Controls.Add(panel_botones);
            groupBox_grupos.Dock = DockStyle.Fill;
            groupBox_grupos.ForeColor = Color.White;
            groupBox_grupos.Location = new Point(0, 0);
            groupBox_grupos.Name = "groupBox_grupos";
            groupBox_grupos.Size = new Size(916, 729);
            groupBox_grupos.TabIndex = 0;
            groupBox_grupos.TabStop = false;
            groupBox_grupos.Text = "Lista de grupos";
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
            dataGridView1.ColumnHeadersHeight = 27;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ControlDark;
            dataGridView1.Location = new Point(3, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 84, 168);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(910, 587);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_nombreGrupoFiltro);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btn_quitarFiltro);
            panel1.Controls.Add(txt_nombrePermisoFiltro);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 63);
            panel1.TabIndex = 1;
            // 
            // txt_nombreGrupoFiltro
            // 
            txt_nombreGrupoFiltro.Location = new Point(146, 18);
            txt_nombreGrupoFiltro.Name = "txt_nombreGrupoFiltro";
            txt_nombreGrupoFiltro.Size = new Size(215, 22);
            txt_nombreGrupoFiltro.TabIndex = 7;
            txt_nombreGrupoFiltro.TextChanged += txt_nombreGrupoFiltro_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 23);
            label4.Name = "label4";
            label4.Size = new Size(116, 17);
            label4.TabIndex = 6;
            label4.Text = "Nombre de grupo:";
            // 
            // btn_quitarFiltro
            // 
            btn_quitarFiltro.BackColor = Color.FromArgb(0, 84, 168);
            btn_quitarFiltro.FlatAppearance.BorderSize = 0;
            btn_quitarFiltro.FlatStyle = FlatStyle.Flat;
            btn_quitarFiltro.Location = new Point(754, 17);
            btn_quitarFiltro.Name = "btn_quitarFiltro";
            btn_quitarFiltro.Size = new Size(103, 23);
            btn_quitarFiltro.TabIndex = 5;
            btn_quitarFiltro.Text = "Limpiar filtro";
            btn_quitarFiltro.UseVisualStyleBackColor = false;
            btn_quitarFiltro.Click += btn_quitarFiltro_Click;
            // 
            // txt_nombrePermisoFiltro
            // 
            txt_nombrePermisoFiltro.Location = new Point(513, 18);
            txt_nombrePermisoFiltro.Name = "txt_nombrePermisoFiltro";
            txt_nombrePermisoFiltro.Size = new Size(215, 22);
            txt_nombrePermisoFiltro.TabIndex = 4;
            txt_nombrePermisoFiltro.TextChanged += txt_nombrePermisoFiltro_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(379, 23);
            label3.Name = "label3";
            label3.Size = new Size(128, 17);
            label3.TabIndex = 3;
            label3.Text = "Nombre de permiso:";
            // 
            // panel_botones
            // 
            panel_botones.Controls.Add(btn_modificarPermisos);
            panel_botones.Controls.Add(btn_cerrar);
            panel_botones.Controls.Add(btn_asignarPermisos);
            panel_botones.Dock = DockStyle.Bottom;
            panel_botones.Location = new Point(3, 668);
            panel_botones.Name = "panel_botones";
            panel_botones.Size = new Size(910, 58);
            panel_botones.TabIndex = 0;
            // 
            // btn_modificarPermisos
            // 
            btn_modificarPermisos.BackColor = Color.FromArgb(0, 84, 168);
            btn_modificarPermisos.FlatAppearance.BorderSize = 0;
            btn_modificarPermisos.FlatStyle = FlatStyle.Flat;
            btn_modificarPermisos.ForeColor = Color.White;
            btn_modificarPermisos.Location = new Point(150, 3);
            btn_modificarPermisos.Name = "btn_modificarPermisos";
            btn_modificarPermisos.Size = new Size(128, 23);
            btn_modificarPermisos.TabIndex = 6;
            btn_modificarPermisos.Text = "Modificar permisos";
            btn_modificarPermisos.UseVisualStyleBackColor = false;
            btn_modificarPermisos.Click += btn_modificarPermisos_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.ForeColor = Color.White;
            btn_cerrar.Location = new Point(804, 32);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(103, 23);
            btn_cerrar.TabIndex = 5;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_asignarPermisos
            // 
            btn_asignarPermisos.BackColor = Color.FromArgb(0, 84, 168);
            btn_asignarPermisos.FlatAppearance.BorderSize = 0;
            btn_asignarPermisos.FlatStyle = FlatStyle.Flat;
            btn_asignarPermisos.ForeColor = Color.White;
            btn_asignarPermisos.Location = new Point(3, 3);
            btn_asignarPermisos.Name = "btn_asignarPermisos";
            btn_asignarPermisos.Size = new Size(128, 23);
            btn_asignarPermisos.TabIndex = 0;
            btn_asignarPermisos.Text = "Asignar permisos";
            btn_asignarPermisos.UseVisualStyleBackColor = false;
            btn_asignarPermisos.Click += btn_asignarPermisos_Click;
            // 
            // Form_asignarPermisos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1175, 729);
            Controls.Add(panel_lista_permisos);
            Controls.Add(panel_carga);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_asignarPermisos";
            Text = "Form_asignarPermisos";
            Load += Form_asignarPermisos_Load;
            panel_carga.ResumeLayout(false);
            groupBox_carga.ResumeLayout(false);
            groupBox_carga.PerformLayout();
            panel_lista_permisos.ResumeLayout(false);
            groupBox_grupos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_botones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_carga;
        private GroupBox groupBox_carga;
        private TextBox txt_nombre;
        private Label label1;
        private Panel panel_lista_permisos;
        private GroupBox groupBox_grupos;
        private Panel panel_botones;
        private Button btn_eliminarGrupo;
        private Button btn_modificarGrupo;
        private Button btn_asignarPermisos;
        private Button btn_cerrar;
        private Button btn_guardar;
        private Button btn_cancelar;
        private CheckedListBox check_listaPermisos;
        private Label label2;
        private Button btn_modificarPermisos;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btn_quitarFiltro;
        private TextBox txt_nombrePermisoFiltro;
        private Label label3;
        private TextBox txt_nombreGrupoFiltro;
        private Label label4;
    }
}