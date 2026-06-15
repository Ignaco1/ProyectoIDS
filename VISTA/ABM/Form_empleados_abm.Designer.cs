namespace VISTA.ABM
{
    partial class Form_empleados_abm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            groupBox_carga = new GroupBox();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            cb_rol = new ComboBox();
            cb_turno = new ComboBox();
            label2 = new Label();
            label1 = new Label();
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
            panel2 = new Panel();
            groupBox_grilla = new GroupBox();
            dataGridView1 = new DataGridView();
            panel_botones = new Panel();
            btn_darDebaja = new Button();
            btn_modificar = new Button();
            btn_agregar = new Button();
            btn_cerrar = new Button();
            panel_filtro = new Panel();
            cb_rolFiltro = new ComboBox();
            cb_turnoFiltro = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            txt_nombreFiltro = new TextBox();
            label3 = new Label();
            txt_apellidoFiltro = new TextBox();
            label9 = new Label();
            txt_dniFiltro = new TextBox();
            label10 = new Label();
            btn_quitarFiltro = new Button();
            panel1.SuspendLayout();
            groupBox_carga.SuspendLayout();
            panel2.SuspendLayout();
            groupBox_grilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_botones.SuspendLayout();
            panel_filtro.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox_carga);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1488, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 1333);
            panel1.TabIndex = 0;
            // 
            // groupBox_carga
            // 
            groupBox_carga.BackColor = Color.Gray;
            groupBox_carga.Controls.Add(btn_cancelar);
            groupBox_carga.Controls.Add(btn_guardar);
            groupBox_carga.Controls.Add(cb_rol);
            groupBox_carga.Controls.Add(cb_turno);
            groupBox_carga.Controls.Add(label2);
            groupBox_carga.Controls.Add(label1);
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
            groupBox_carga.Dock = DockStyle.Fill;
            groupBox_carga.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox_carga.ForeColor = Color.White;
            groupBox_carga.Location = new Point(0, 0);
            groupBox_carga.Margin = new Padding(3, 4, 3, 4);
            groupBox_carga.Name = "groupBox_carga";
            groupBox_carga.Padding = new Padding(3, 4, 3, 4);
            groupBox_carga.Size = new Size(332, 1333);
            groupBox_carga.TabIndex = 0;
            groupBox_carga.TabStop = false;
            groupBox_carga.Text = "Carga de datos";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_cancelar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Location = new Point(204, 1300);
            btn_cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(122, 27);
            btn_cancelar.TabIndex = 28;
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
            btn_guardar.Size = new Size(122, 27);
            btn_guardar.TabIndex = 27;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // cb_rol
            // 
            cb_rol.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_rol.FormattingEnabled = true;
            cb_rol.Location = new Point(99, 474);
            cb_rol.Margin = new Padding(3, 4, 3, 4);
            cb_rol.Name = "cb_rol";
            cb_rol.Size = new Size(221, 28);
            cb_rol.TabIndex = 26;
            // 
            // cb_turno
            // 
            cb_turno.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_turno.FormattingEnabled = true;
            cb_turno.Location = new Point(99, 414);
            cb_turno.Margin = new Padding(3, 4, 3, 4);
            cb_turno.Name = "cb_turno";
            cb_turno.Size = new Size(204, 28);
            cb_turno.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 418);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 24;
            label2.Text = "Turno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 478);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 23;
            label1.Text = "Rol:";
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(99, 358);
            txt_telefono.Margin = new Padding(3, 4, 3, 4);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(181, 26);
            txt_telefono.TabIndex = 22;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(99, 294);
            txt_email.Margin = new Padding(3, 4, 3, 4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(221, 26);
            txt_email.TabIndex = 21;
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(99, 238);
            txt_dni.Margin = new Padding(3, 4, 3, 4);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(181, 26);
            txt_dni.TabIndex = 20;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(99, 176);
            txt_apellido.Margin = new Padding(3, 4, 3, 4);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(221, 26);
            txt_apellido.TabIndex = 19;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(99, 118);
            txt_nombre.Margin = new Padding(3, 4, 3, 4);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(221, 26);
            txt_nombre.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 362);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 17;
            label8.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 298);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 16;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 242);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 15;
            label6.Text = "DNI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 182);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 14;
            label5.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 124);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 13;
            label4.Text = "Nombre:";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox_grilla);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1488, 1333);
            panel2.TabIndex = 1;
            // 
            // groupBox_grilla
            // 
            groupBox_grilla.BackColor = Color.Gray;
            groupBox_grilla.Controls.Add(dataGridView1);
            groupBox_grilla.Controls.Add(panel_botones);
            groupBox_grilla.Controls.Add(panel_filtro);
            groupBox_grilla.Dock = DockStyle.Fill;
            groupBox_grilla.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox_grilla.ForeColor = Color.White;
            groupBox_grilla.Location = new Point(0, 0);
            groupBox_grilla.Margin = new Padding(3, 4, 3, 4);
            groupBox_grilla.Name = "groupBox_grilla";
            groupBox_grilla.Padding = new Padding(3, 4, 3, 4);
            groupBox_grilla.Size = new Size(1488, 1333);
            groupBox_grilla.TabIndex = 0;
            groupBox_grilla.TabStop = false;
            groupBox_grilla.Text = "Lista de empleados";
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
            dataGridView1.Location = new Point(3, 137);
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
            dataGridView1.Size = new Size(1482, 1090);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel_botones
            // 
            panel_botones.BackColor = Color.Gray;
            panel_botones.Controls.Add(btn_darDebaja);
            panel_botones.Controls.Add(btn_modificar);
            panel_botones.Controls.Add(btn_agregar);
            panel_botones.Controls.Add(btn_cerrar);
            panel_botones.Dock = DockStyle.Bottom;
            panel_botones.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel_botones.ForeColor = Color.White;
            panel_botones.Location = new Point(3, 1227);
            panel_botones.Margin = new Padding(3, 4, 3, 4);
            panel_botones.Name = "panel_botones";
            panel_botones.Size = new Size(1482, 102);
            panel_botones.TabIndex = 1;
            // 
            // btn_darDebaja
            // 
            btn_darDebaja.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_darDebaja.BackColor = Color.FromArgb(0, 84, 168);
            btn_darDebaja.FlatAppearance.BorderSize = 0;
            btn_darDebaja.FlatStyle = FlatStyle.Flat;
            btn_darDebaja.Location = new Point(395, 8);
            btn_darDebaja.Margin = new Padding(3, 4, 3, 4);
            btn_darDebaja.Name = "btn_darDebaja";
            btn_darDebaja.Size = new Size(174, 27);
            btn_darDebaja.TabIndex = 31;
            btn_darDebaja.Text = "Dar de baja";
            btn_darDebaja.UseVisualStyleBackColor = false;
            btn_darDebaja.Click += btn_darDebaja_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_modificar.BackColor = Color.FromArgb(0, 84, 168);
            btn_modificar.FlatAppearance.BorderSize = 0;
            btn_modificar.FlatStyle = FlatStyle.Flat;
            btn_modificar.Location = new Point(200, 8);
            btn_modificar.Margin = new Padding(3, 4, 3, 4);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(174, 27);
            btn_modificar.TabIndex = 30;
            btn_modificar.Text = "Modificar empleado";
            btn_modificar.UseVisualStyleBackColor = false;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_agregar.BackColor = Color.FromArgb(0, 84, 168);
            btn_agregar.FlatAppearance.BorderSize = 0;
            btn_agregar.FlatStyle = FlatStyle.Flat;
            btn_agregar.Location = new Point(3, 8);
            btn_agregar.Margin = new Padding(3, 4, 3, 4);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(174, 27);
            btn_agregar.TabIndex = 29;
            btn_agregar.Text = "Agregar empleado";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_cerrar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Location = new Point(1357, 73);
            btn_cerrar.Margin = new Padding(3, 4, 3, 4);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(122, 27);
            btn_cerrar.TabIndex = 28;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // panel_filtro
            // 
            panel_filtro.BackColor = Color.Gray;
            panel_filtro.Controls.Add(cb_rolFiltro);
            panel_filtro.Controls.Add(cb_turnoFiltro);
            panel_filtro.Controls.Add(label12);
            panel_filtro.Controls.Add(label11);
            panel_filtro.Controls.Add(txt_nombreFiltro);
            panel_filtro.Controls.Add(label3);
            panel_filtro.Controls.Add(txt_apellidoFiltro);
            panel_filtro.Controls.Add(label9);
            panel_filtro.Controls.Add(txt_dniFiltro);
            panel_filtro.Controls.Add(label10);
            panel_filtro.Controls.Add(btn_quitarFiltro);
            panel_filtro.Dock = DockStyle.Top;
            panel_filtro.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel_filtro.ForeColor = Color.White;
            panel_filtro.Location = new Point(3, 23);
            panel_filtro.Margin = new Padding(3, 4, 3, 4);
            panel_filtro.Name = "panel_filtro";
            panel_filtro.Size = new Size(1482, 114);
            panel_filtro.TabIndex = 0;
            // 
            // cb_rolFiltro
            // 
            cb_rolFiltro.FormattingEnabled = true;
            cb_rolFiltro.Location = new Point(421, 69);
            cb_rolFiltro.Margin = new Padding(3, 4, 3, 4);
            cb_rolFiltro.Name = "cb_rolFiltro";
            cb_rolFiltro.Size = new Size(218, 28);
            cb_rolFiltro.TabIndex = 41;
            cb_rolFiltro.SelectedIndexChanged += cb_rolFiltro_SelectedIndexChanged;
            // 
            // cb_turnoFiltro
            // 
            cb_turnoFiltro.FormattingEnabled = true;
            cb_turnoFiltro.Location = new Point(831, 69);
            cb_turnoFiltro.Margin = new Padding(3, 4, 3, 4);
            cb_turnoFiltro.Name = "cb_turnoFiltro";
            cb_turnoFiltro.Size = new Size(194, 28);
            cb_turnoFiltro.TabIndex = 40;
            cb_turnoFiltro.SelectedIndexChanged += cb_turnoFiltro_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(774, 72);
            label12.Name = "label12";
            label12.Size = new Size(51, 20);
            label12.TabIndex = 38;
            label12.Text = "Turno:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(380, 72);
            label11.Name = "label11";
            label11.Size = new Size(35, 20);
            label11.TabIndex = 36;
            label11.Text = "Rol:";
            // 
            // txt_nombreFiltro
            // 
            txt_nombreFiltro.Location = new Point(625, 11);
            txt_nombreFiltro.Margin = new Padding(3, 4, 3, 4);
            txt_nombreFiltro.Name = "txt_nombreFiltro";
            txt_nombreFiltro.Size = new Size(219, 26);
            txt_nombreFiltro.TabIndex = 30;
            txt_nombreFiltro.TextChanged += txt_nombreFiltro_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(547, 14);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 35;
            label3.Text = "Nombre:";
            // 
            // txt_apellidoFiltro
            // 
            txt_apellidoFiltro.Location = new Point(996, 8);
            txt_apellidoFiltro.Margin = new Padding(3, 4, 3, 4);
            txt_apellidoFiltro.Name = "txt_apellidoFiltro";
            txt_apellidoFiltro.Size = new Size(208, 26);
            txt_apellidoFiltro.TabIndex = 34;
            txt_apellidoFiltro.TextChanged += txt_apellidoFiltro_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(917, 12);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 33;
            label9.Text = "Apellido:";
            // 
            // txt_dniFiltro
            // 
            txt_dniFiltro.Location = new Point(274, 10);
            txt_dniFiltro.Margin = new Padding(3, 4, 3, 4);
            txt_dniFiltro.Name = "txt_dniFiltro";
            txt_dniFiltro.Size = new Size(192, 26);
            txt_dniFiltro.TabIndex = 32;
            txt_dniFiltro.TextChanged += txt_dniFiltro_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(228, 14);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 31;
            label10.Text = "DNI:";
            // 
            // btn_quitarFiltro
            // 
            btn_quitarFiltro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_quitarFiltro.BackColor = Color.FromArgb(0, 84, 168);
            btn_quitarFiltro.FlatAppearance.BorderSize = 0;
            btn_quitarFiltro.FlatStyle = FlatStyle.Flat;
            btn_quitarFiltro.Location = new Point(1301, 51);
            btn_quitarFiltro.Margin = new Padding(3, 4, 3, 4);
            btn_quitarFiltro.Name = "btn_quitarFiltro";
            btn_quitarFiltro.Size = new Size(161, 27);
            btn_quitarFiltro.TabIndex = 29;
            btn_quitarFiltro.Text = "Limpiar filtro";
            btn_quitarFiltro.UseVisualStyleBackColor = false;
            btn_quitarFiltro.Click += btn_quitarFiltro_Click;
            // 
            // Form_empleados_abm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 1333);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_empleados_abm";
            Text = "Form_empleados_abm";
            Load += Form_empleados_abm_Load;
            panel1.ResumeLayout(false);
            groupBox_carga.ResumeLayout(false);
            groupBox_carga.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox_grilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_botones.ResumeLayout(false);
            panel_filtro.ResumeLayout(false);
            panel_filtro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox_carga;
        private Panel panel2;
        private GroupBox groupBox_grilla;
        private Panel panel_filtro;
        private Panel panel_botones;
        private DataGridView dataGridView1;
        private TextBox txt_telefono;
        private TextBox txt_email;
        private TextBox txt_dni;
        private TextBox txt_apellido;
        private TextBox txt_nombre;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cb_rol;
        private ComboBox cb_turno;
        private Label label2;
        private Label label1;
        private Button btn_guardar;
        private Button btn_cancelar;
        private Button btn_darDebaja;
        private Button btn_modificar;
        private Button btn_agregar;
        private Button btn_cerrar;
        private Button btn_quitarFiltro;
        private Label label12;
        private Label label11;
        private TextBox txt_nombreFiltro;
        private Label label3;
        private TextBox txt_apellidoFiltro;
        private Label label9;
        private TextBox txt_dniFiltro;
        private Label label10;
        private ComboBox cb_rolFiltro;
        private ComboBox cb_turnoFiltro;
    }
}