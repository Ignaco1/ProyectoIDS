namespace VISTA
{
    partial class Form_clientes_abm
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
            txt_telefono = new TextBox();
            txt_email = new TextBox();
            txt_dni = new TextBox();
            txt_apellido = new TextBox();
            txt_nombre = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            panel_grilla = new Panel();
            groupBox_grilla = new GroupBox();
            dataGridView1 = new DataGridView();
            panel_botones = new Panel();
            btn_cerrar = new Button();
            btn_eliminar = new Button();
            btn_mod = new Button();
            btn_agregar = new Button();
            panel_filtro = new Panel();
            txt_nombreFiltro = new TextBox();
            label3 = new Label();
            txt_apellidoFiltro = new TextBox();
            label2 = new Label();
            txt_dniFiltro = new TextBox();
            label1 = new Label();
            btn_quitarFiltro = new Button();
            panel_carga.SuspendLayout();
            groupBox_carga.SuspendLayout();
            panel_grilla.SuspendLayout();
            groupBox_grilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_botones.SuspendLayout();
            panel_filtro.SuspendLayout();
            SuspendLayout();
            // 
            // panel_carga
            // 
            panel_carga.Controls.Add(groupBox_carga);
            panel_carga.Dock = DockStyle.Right;
            panel_carga.Location = new Point(910, 0);
            panel_carga.Name = "panel_carga";
            panel_carga.Size = new Size(262, 754);
            panel_carga.TabIndex = 0;
            // 
            // groupBox_carga
            // 
            groupBox_carga.Controls.Add(txt_telefono);
            groupBox_carga.Controls.Add(txt_email);
            groupBox_carga.Controls.Add(txt_dni);
            groupBox_carga.Controls.Add(txt_apellido);
            groupBox_carga.Controls.Add(txt_nombre);
            groupBox_carga.Controls.Add(label8);
            groupBox_carga.Controls.Add(label7);
            groupBox_carga.Controls.Add(label6);
            groupBox_carga.Controls.Add(label5);
            groupBox_carga.Controls.Add(label4);
            groupBox_carga.Controls.Add(btn_cancelar);
            groupBox_carga.Controls.Add(btn_guardar);
            groupBox_carga.Dock = DockStyle.Fill;
            groupBox_carga.ForeColor = Color.White;
            groupBox_carga.Location = new Point(0, 0);
            groupBox_carga.Name = "groupBox_carga";
            groupBox_carga.Size = new Size(262, 754);
            groupBox_carga.TabIndex = 0;
            groupBox_carga.TabStop = false;
            groupBox_carga.Text = "Carga de datos";
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(91, 284);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(159, 22);
            txt_telefono.TabIndex = 12;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(91, 237);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(159, 22);
            txt_email.TabIndex = 11;
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(91, 194);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(136, 22);
            txt_dni.TabIndex = 10;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(91, 148);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(159, 22);
            txt_apellido.TabIndex = 9;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(91, 105);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(159, 22);
            txt_nombre.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 288);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 7;
            label8.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 240);
            label7.Name = "label7";
            label7.Size = new Size(42, 17);
            label7.TabIndex = 6;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 197);
            label6.Name = "label6";
            label6.Size = new Size(32, 17);
            label6.TabIndex = 5;
            label6.Text = "DNI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 152);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 4;
            label5.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 109);
            label4.Name = "label4";
            label4.Size = new Size(59, 17);
            label4.TabIndex = 3;
            label4.Text = "Nombre:";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancelar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Location = new Point(164, 725);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(92, 23);
            btn_cancelar.TabIndex = 2;
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
            btn_guardar.Location = new Point(6, 725);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(92, 23);
            btn_guardar.TabIndex = 1;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // panel_grilla
            // 
            panel_grilla.Controls.Add(groupBox_grilla);
            panel_grilla.Dock = DockStyle.Fill;
            panel_grilla.Location = new Point(0, 0);
            panel_grilla.Name = "panel_grilla";
            panel_grilla.Size = new Size(910, 754);
            panel_grilla.TabIndex = 1;
            // 
            // groupBox_grilla
            // 
            groupBox_grilla.Controls.Add(dataGridView1);
            groupBox_grilla.Controls.Add(panel_botones);
            groupBox_grilla.Controls.Add(panel_filtro);
            groupBox_grilla.Dock = DockStyle.Fill;
            groupBox_grilla.ForeColor = Color.White;
            groupBox_grilla.Location = new Point(0, 0);
            groupBox_grilla.Name = "groupBox_grilla";
            groupBox_grilla.Size = new Size(910, 754);
            groupBox_grilla.TabIndex = 0;
            groupBox_grilla.TabStop = false;
            groupBox_grilla.Text = "Listar clientes";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
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
            dataGridView1.Location = new Point(3, 76);
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
            dataGridView1.Size = new Size(904, 598);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // panel_botones
            // 
            panel_botones.Controls.Add(btn_cerrar);
            panel_botones.Controls.Add(btn_eliminar);
            panel_botones.Controls.Add(btn_mod);
            panel_botones.Controls.Add(btn_agregar);
            panel_botones.Dock = DockStyle.Bottom;
            panel_botones.Location = new Point(3, 674);
            panel_botones.Name = "panel_botones";
            panel_botones.Size = new Size(904, 77);
            panel_botones.TabIndex = 1;
            // 
            // btn_cerrar
            // 
            btn_cerrar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Location = new Point(752, 51);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(103, 23);
            btn_cerrar.TabIndex = 4;
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
            btn_eliminar.TabIndex = 3;
            btn_eliminar.Text = "Eliminar cliente";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_mod
            // 
            btn_mod.BackColor = Color.FromArgb(0, 84, 168);
            btn_mod.FlatAppearance.BorderSize = 0;
            btn_mod.FlatStyle = FlatStyle.Flat;
            btn_mod.Location = new Point(151, 6);
            btn_mod.Name = "btn_mod";
            btn_mod.Size = new Size(128, 23);
            btn_mod.TabIndex = 2;
            btn_mod.Text = "Modificar cliente";
            btn_mod.UseVisualStyleBackColor = false;
            btn_mod.Click += btn_mod_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.FromArgb(0, 84, 168);
            btn_agregar.FlatAppearance.BorderSize = 0;
            btn_agregar.FlatStyle = FlatStyle.Flat;
            btn_agregar.Location = new Point(3, 6);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(128, 23);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar cliente";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // panel_filtro
            // 
            panel_filtro.Controls.Add(txt_nombreFiltro);
            panel_filtro.Controls.Add(label3);
            panel_filtro.Controls.Add(txt_apellidoFiltro);
            panel_filtro.Controls.Add(label2);
            panel_filtro.Controls.Add(txt_dniFiltro);
            panel_filtro.Controls.Add(label1);
            panel_filtro.Controls.Add(btn_quitarFiltro);
            panel_filtro.Dock = DockStyle.Top;
            panel_filtro.Location = new Point(3, 18);
            panel_filtro.Name = "panel_filtro";
            panel_filtro.Size = new Size(904, 58);
            panel_filtro.TabIndex = 0;
            // 
            // txt_nombreFiltro
            // 
            txt_nombreFiltro.Location = new Point(305, 19);
            txt_nombreFiltro.Name = "txt_nombreFiltro";
            txt_nombreFiltro.Size = new Size(136, 22);
            txt_nombreFiltro.TabIndex = 0;
            txt_nombreFiltro.TextChanged += txt_nombreFiltro_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(245, 22);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 6;
            label3.Text = "Nombre:";
            // 
            // txt_apellidoFiltro
            // 
            txt_apellidoFiltro.Location = new Point(539, 19);
            txt_apellidoFiltro.Name = "txt_apellidoFiltro";
            txt_apellidoFiltro.Size = new Size(136, 22);
            txt_apellidoFiltro.TabIndex = 5;
            txt_apellidoFiltro.TextChanged += txt_apellidoFiltro_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 22);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 4;
            label2.Text = "Apellido:";
            // 
            // txt_dniFiltro
            // 
            txt_dniFiltro.Location = new Point(70, 19);
            txt_dniFiltro.Name = "txt_dniFiltro";
            txt_dniFiltro.Size = new Size(136, 22);
            txt_dniFiltro.TabIndex = 3;
            txt_dniFiltro.TextChanged += txt_dniFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 22);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 2;
            label1.Text = "DNI:";
            // 
            // btn_quitarFiltro
            // 
            btn_quitarFiltro.BackColor = Color.FromArgb(0, 84, 168);
            btn_quitarFiltro.FlatAppearance.BorderSize = 0;
            btn_quitarFiltro.FlatStyle = FlatStyle.Flat;
            btn_quitarFiltro.Location = new Point(742, 16);
            btn_quitarFiltro.Name = "btn_quitarFiltro";
            btn_quitarFiltro.Size = new Size(103, 23);
            btn_quitarFiltro.TabIndex = 1;
            btn_quitarFiltro.Text = "Limpiar filtro";
            btn_quitarFiltro.UseVisualStyleBackColor = false;
            btn_quitarFiltro.Click += btn_quitarFiltro_Click;
            // 
            // Form_clientes_abm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1172, 754);
            Controls.Add(panel_grilla);
            Controls.Add(panel_carga);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_clientes_abm";
            Text = "Form_clientes_abm";
            Load += Form_clientes_abm_Load;
            panel_carga.ResumeLayout(false);
            groupBox_carga.ResumeLayout(false);
            groupBox_carga.PerformLayout();
            panel_grilla.ResumeLayout(false);
            groupBox_grilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_botones.ResumeLayout(false);
            panel_filtro.ResumeLayout(false);
            panel_filtro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_carga;
        private Panel panel_grilla;
        private GroupBox groupBox_carga;
        private GroupBox groupBox_grilla;
        private DataGridView dataGridView1;
        private Panel panel_botones;
        private Panel panel_filtro;
        private TextBox txt_dniFiltro;
        private Label label1;
        private Button btn_quitarFiltro;
        private TextBox txt_nombreFiltro;
        private Label label3;
        private TextBox txt_apellidoFiltro;
        private Label label2;
        private Button btn_cancelar;
        private Button btn_guardar;
        private Button btn_cerrar;
        private Button btn_eliminar;
        private Button btn_mod;
        private Button btn_agregar;
        private Label label4;
        private TextBox txt_telefono;
        private TextBox txt_email;
        private TextBox txt_dni;
        private TextBox txt_apellido;
        private TextBox txt_nombre;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}