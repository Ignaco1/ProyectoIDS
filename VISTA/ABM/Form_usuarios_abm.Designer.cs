namespace VISTA
{
    partial class Form_usuarios_abm
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
            txt_email = new TextBox();
            label2 = new Label();
            cb_tipoUsuario = new ComboBox();
            txt_usuario = new TextBox();
            txt_apellido = new TextBox();
            txt_nombre = new TextBox();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btn_quitarFiltro = new Button();
            panel_grilla = new Panel();
            groupBox_lista = new GroupBox();
            dataGridView = new DataGridView();
            panel_filtro = new Panel();
            txt_apellidoFiltro = new TextBox();
            label9 = new Label();
            txt_nombreFiltro = new TextBox();
            label8 = new Label();
            label1 = new Label();
            cb_tipoFiltro = new ComboBox();
            panel_botones = new Panel();
            btn_cerrar = new Button();
            btn_eliminar = new Button();
            btn_modificar = new Button();
            btn_agregar = new Button();
            panel_carga.SuspendLayout();
            groupBox_carga.SuspendLayout();
            panel_grilla.SuspendLayout();
            groupBox_lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel_filtro.SuspendLayout();
            panel_botones.SuspendLayout();
            SuspendLayout();
            // 
            // panel_carga
            // 
            panel_carga.Controls.Add(groupBox_carga);
            panel_carga.Dock = DockStyle.Right;
            panel_carga.Location = new Point(1496, 0);
            panel_carga.Name = "panel_carga";
            panel_carga.Size = new Size(387, 1570);
            panel_carga.TabIndex = 0;
            // 
            // groupBox_carga
            // 
            groupBox_carga.Controls.Add(txt_email);
            groupBox_carga.Controls.Add(label2);
            groupBox_carga.Controls.Add(cb_tipoUsuario);
            groupBox_carga.Controls.Add(txt_usuario);
            groupBox_carga.Controls.Add(txt_apellido);
            groupBox_carga.Controls.Add(txt_nombre);
            groupBox_carga.Controls.Add(btn_cancelar);
            groupBox_carga.Controls.Add(btn_guardar);
            groupBox_carga.Controls.Add(label6);
            groupBox_carga.Controls.Add(label5);
            groupBox_carga.Controls.Add(label4);
            groupBox_carga.Controls.Add(label3);
            groupBox_carga.Dock = DockStyle.Fill;
            groupBox_carga.ForeColor = Color.White;
            groupBox_carga.Location = new Point(0, 0);
            groupBox_carga.Name = "groupBox_carga";
            groupBox_carga.Size = new Size(387, 1570);
            groupBox_carga.TabIndex = 0;
            groupBox_carga.TabStop = false;
            groupBox_carga.Text = "Carga de datos";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(100, 535);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(275, 30);
            txt_email.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 302);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 12;
            label2.Text = "Nombre:";
            // 
            // cb_tipoUsuario
            // 
            cb_tipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipoUsuario.FormattingEnabled = true;
            cb_tipoUsuario.Location = new Point(157, 221);
            cb_tipoUsuario.Name = "cb_tipoUsuario";
            cb_tipoUsuario.Size = new Size(218, 29);
            cb_tipoUsuario.TabIndex = 11;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(124, 451);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(251, 30);
            txt_usuario.TabIndex = 10;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(124, 372);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(251, 30);
            txt_apellido.TabIndex = 9;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(124, 298);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(251, 30);
            txt_nombre.TabIndex = 8;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Location = new Point(256, 1533);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(128, 31);
            btn_cancelar.TabIndex = 6;
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
            btn_guardar.Location = new Point(6, 1533);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(128, 31);
            btn_guardar.TabIndex = 5;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 538);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 4;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 453);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 3;
            label5.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 376);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 2;
            label4.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 224);
            label3.Name = "label3";
            label3.Size = new Size(145, 21);
            label3.TabIndex = 1;
            label3.Text = "Tipo de usuario:";
            // 
            // btn_quitarFiltro
            // 
            btn_quitarFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_quitarFiltro.BackColor = Color.FromArgb(0, 84, 168);
            btn_quitarFiltro.FlatAppearance.BorderSize = 0;
            btn_quitarFiltro.FlatStyle = FlatStyle.Flat;
            btn_quitarFiltro.Location = new Point(1341, 15);
            btn_quitarFiltro.Name = "btn_quitarFiltro";
            btn_quitarFiltro.Size = new Size(146, 31);
            btn_quitarFiltro.TabIndex = 19;
            btn_quitarFiltro.Text = "Limpiar filtro";
            btn_quitarFiltro.UseVisualStyleBackColor = false;
            btn_quitarFiltro.Click += btn_quitarFiltro_Click;
            // 
            // panel_grilla
            // 
            panel_grilla.Controls.Add(groupBox_lista);
            panel_grilla.Dock = DockStyle.Fill;
            panel_grilla.Location = new Point(0, 0);
            panel_grilla.Name = "panel_grilla";
            panel_grilla.Size = new Size(1496, 1570);
            panel_grilla.TabIndex = 1;
            // 
            // groupBox_lista
            // 
            groupBox_lista.Controls.Add(dataGridView);
            groupBox_lista.Controls.Add(panel_filtro);
            groupBox_lista.Controls.Add(panel_botones);
            groupBox_lista.Dock = DockStyle.Fill;
            groupBox_lista.ForeColor = Color.White;
            groupBox_lista.Location = new Point(0, 0);
            groupBox_lista.Name = "groupBox_lista";
            groupBox_lista.Size = new Size(1496, 1570);
            groupBox_lista.TabIndex = 0;
            groupBox_lista.TabStop = false;
            groupBox_lista.Text = "Lista de usuarios";
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeight = 27;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = SystemColors.ControlDark;
            dataGridView.Location = new Point(3, 89);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 84, 168);
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1490, 1405);
            dataGridView.TabIndex = 2;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // panel_filtro
            // 
            panel_filtro.Controls.Add(btn_quitarFiltro);
            panel_filtro.Controls.Add(txt_apellidoFiltro);
            panel_filtro.Controls.Add(label9);
            panel_filtro.Controls.Add(txt_nombreFiltro);
            panel_filtro.Controls.Add(label8);
            panel_filtro.Controls.Add(label1);
            panel_filtro.Controls.Add(cb_tipoFiltro);
            panel_filtro.Dock = DockStyle.Top;
            panel_filtro.Location = new Point(3, 26);
            panel_filtro.Name = "panel_filtro";
            panel_filtro.Size = new Size(1490, 63);
            panel_filtro.TabIndex = 1;
            // 
            // txt_apellidoFiltro
            // 
            txt_apellidoFiltro.Location = new Point(745, 17);
            txt_apellidoFiltro.Name = "txt_apellidoFiltro";
            txt_apellidoFiltro.Size = new Size(183, 30);
            txt_apellidoFiltro.TabIndex = 17;
            txt_apellidoFiltro.TextChanged += txt_apellidoFiltro_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(652, 20);
            label9.Name = "label9";
            label9.Size = new Size(87, 21);
            label9.TabIndex = 16;
            label9.Text = "Apellido:";
            // 
            // txt_nombreFiltro
            // 
            txt_nombreFiltro.Location = new Point(470, 14);
            txt_nombreFiltro.Name = "txt_nombreFiltro";
            txt_nombreFiltro.Size = new Size(176, 30);
            txt_nombreFiltro.TabIndex = 15;
            txt_nombreFiltro.TextChanged += txt_nombreFiltro_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(378, 18);
            label8.Name = "label8";
            label8.Size = new Size(86, 21);
            label8.TabIndex = 7;
            label8.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 6;
            label1.Text = "Tipo de usuario:";
            // 
            // cb_tipoFiltro
            // 
            cb_tipoFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tipoFiltro.FormattingEnabled = true;
            cb_tipoFiltro.Location = new Point(163, 15);
            cb_tipoFiltro.Name = "cb_tipoFiltro";
            cb_tipoFiltro.Size = new Size(209, 29);
            cb_tipoFiltro.TabIndex = 5;
            cb_tipoFiltro.SelectedIndexChanged += cb_tipoFiltro_SelectedIndexChanged;
            // 
            // panel_botones
            // 
            panel_botones.Controls.Add(btn_cerrar);
            panel_botones.Controls.Add(btn_eliminar);
            panel_botones.Controls.Add(btn_modificar);
            panel_botones.Controls.Add(btn_agregar);
            panel_botones.Dock = DockStyle.Bottom;
            panel_botones.Location = new Point(3, 1494);
            panel_botones.Name = "panel_botones";
            panel_botones.Size = new Size(1490, 73);
            panel_botones.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Location = new Point(1359, 39);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(128, 31);
            btn_cerrar.TabIndex = 3;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(0, 84, 168);
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Location = new Point(411, 6);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(182, 31);
            btn_eliminar.TabIndex = 2;
            btn_eliminar.Text = "Eliminar usuario";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.FromArgb(0, 84, 168);
            btn_modificar.FlatAppearance.BorderSize = 0;
            btn_modificar.FlatStyle = FlatStyle.Flat;
            btn_modificar.Location = new Point(206, 6);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(182, 31);
            btn_modificar.TabIndex = 1;
            btn_modificar.Text = "Modificar usuario";
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
            btn_agregar.Size = new Size(182, 31);
            btn_agregar.TabIndex = 0;
            btn_agregar.Text = "Agregar usuario";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // Form_usuarios_abm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1883, 1570);
            Controls.Add(panel_grilla);
            Controls.Add(panel_carga);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_usuarios_abm";
            Text = "Form_usuarios";
            Load += Form_usuarios_abm_Load;
            panel_carga.ResumeLayout(false);
            groupBox_carga.ResumeLayout(false);
            groupBox_carga.PerformLayout();
            panel_grilla.ResumeLayout(false);
            groupBox_lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel_filtro.ResumeLayout(false);
            panel_filtro.PerformLayout();
            panel_botones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_carga;
        private Panel panel_grilla;
        private GroupBox groupBox_lista;
        private Panel panel_botones;
        private GroupBox groupBox_carga;
        private Panel panel_filtro;
        private Button btn_agregar;
        private DataGridView dataGridView;
        private Button btn_cerrar;
        private Button btn_eliminar;
        private Button btn_modificar;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox cb_tipoFiltro;
        private Button btn_cancelar;
        private Button btn_guardar;
        private Label label6;
        private Label label5;
        private ComboBox cb_tipoUsuario;
        private TextBox txt_usuario;
        private TextBox txt_apellido;
        private TextBox txt_nombre;
        private Label label2;
        private TextBox txt_email;
        private TextBox txt_apellidoFiltro;
        private Label label9;
        private TextBox txt_nombreFiltro;
        private Label label8;
        private Button btn_quitarFiltro;
    }
}