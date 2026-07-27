namespace VISTA
{
    partial class Form_auditoriaUsuarios
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
            panel_grilla = new Panel();
            groupBox_grilla = new GroupBox();
            dataGridView1 = new DataGridView();
            panel_botones = new Panel();
            btn_cerrar = new Button();
            btn_consultar = new Button();
            panel_filtro = new Panel();
            cb_movimientoFiltro = new ComboBox();
            dtp_fechaFiltro = new DateTimePicker();
            dtp_horaFiltro = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_nombreUsuarioFiltro = new TextBox();
            label1 = new Label();
            btn_quitarFiltro = new Button();
            panel_grilla.SuspendLayout();
            groupBox_grilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_botones.SuspendLayout();
            panel_filtro.SuspendLayout();
            SuspendLayout();
            // 
            // panel_grilla
            // 
            panel_grilla.Controls.Add(groupBox_grilla);
            panel_grilla.Dock = DockStyle.Fill;
            panel_grilla.Location = new Point(0, 0);
            panel_grilla.Name = "panel_grilla";
            panel_grilla.Size = new Size(1820, 1333);
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
            groupBox_grilla.Size = new Size(1820, 1333);
            groupBox_grilla.TabIndex = 0;
            groupBox_grilla.TabStop = false;
            groupBox_grilla.Text = "Auditoría de usuarios";
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
            dataGridView1.Location = new Point(3, 94);
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
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 84, 168);
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(0, 84, 168);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1814, 1159);
            dataGridView1.TabIndex = 2;
            // 
            // panel_botones
            // 
            panel_botones.Controls.Add(btn_cerrar);
            panel_botones.Controls.Add(btn_consultar);
            panel_botones.Dock = DockStyle.Bottom;
            panel_botones.Location = new Point(3, 1253);
            panel_botones.Name = "panel_botones";
            panel_botones.Size = new Size(1814, 77);
            panel_botones.TabIndex = 1;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Location = new Point(1689, 47);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(122, 27);
            btn_cerrar.TabIndex = 4;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_consultar
            // 
            btn_consultar.BackColor = Color.FromArgb(0, 84, 168);
            btn_consultar.FlatAppearance.BorderSize = 0;
            btn_consultar.FlatStyle = FlatStyle.Flat;
            btn_consultar.Location = new Point(9, 6);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(338, 27);
            btn_consultar.TabIndex = 1;
            btn_consultar.Text = "Consultar detalles movimiento";
            btn_consultar.UseVisualStyleBackColor = false;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // panel_filtro
            // 
            panel_filtro.Controls.Add(cb_movimientoFiltro);
            panel_filtro.Controls.Add(dtp_fechaFiltro);
            panel_filtro.Controls.Add(dtp_horaFiltro);
            panel_filtro.Controls.Add(label4);
            panel_filtro.Controls.Add(label3);
            panel_filtro.Controls.Add(label2);
            panel_filtro.Controls.Add(txt_nombreUsuarioFiltro);
            panel_filtro.Controls.Add(label1);
            panel_filtro.Controls.Add(btn_quitarFiltro);
            panel_filtro.Dock = DockStyle.Top;
            panel_filtro.Location = new Point(3, 22);
            panel_filtro.Name = "panel_filtro";
            panel_filtro.Size = new Size(1814, 72);
            panel_filtro.TabIndex = 0;
            // 
            // cb_movimientoFiltro
            // 
            cb_movimientoFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_movimientoFiltro.FormattingEnabled = true;
            cb_movimientoFiltro.Location = new Point(646, 20);
            cb_movimientoFiltro.Margin = new Padding(3, 4, 3, 4);
            cb_movimientoFiltro.Name = "cb_movimientoFiltro";
            cb_movimientoFiltro.Size = new Size(241, 28);
            cb_movimientoFiltro.TabIndex = 62;
            cb_movimientoFiltro.SelectedIndexChanged += cb_movimientoFiltro_SelectedIndexChanged;
            // 
            // dtp_fechaFiltro
            // 
            dtp_fechaFiltro.Format = DateTimePickerFormat.Short;
            dtp_fechaFiltro.Location = new Point(997, 20);
            dtp_fechaFiltro.Name = "dtp_fechaFiltro";
            dtp_fechaFiltro.Size = new Size(221, 26);
            dtp_fechaFiltro.TabIndex = 61;
            dtp_fechaFiltro.ValueChanged += dtp_fechaFiltro_ValueChanged;
            // 
            // dtp_horaFiltro
            // 
            dtp_horaFiltro.Format = DateTimePickerFormat.Time;
            dtp_horaFiltro.Location = new Point(1320, 21);
            dtp_horaFiltro.Name = "dtp_horaFiltro";
            dtp_horaFiltro.ShowUpDown = true;
            dtp_horaFiltro.Size = new Size(169, 26);
            dtp_horaFiltro.TabIndex = 58;
            dtp_horaFiltro.ValueChanged += dtp_horaFiltro_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1266, 23);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 7;
            label4.Text = "Hora:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(539, 24);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 6;
            label3.Text = "Movimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(932, 22);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 4;
            label2.Text = "Fecha:";
            // 
            // txt_nombreUsuarioFiltro
            // 
            txt_nombreUsuarioFiltro.Location = new Point(299, 21);
            txt_nombreUsuarioFiltro.Name = "txt_nombreUsuarioFiltro";
            txt_nombreUsuarioFiltro.Size = new Size(206, 26);
            txt_nombreUsuarioFiltro.TabIndex = 3;
            txt_nombreUsuarioFiltro.TextChanged += txt_nombreUsuarioFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 24);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre del usuario:";
            // 
            // btn_quitarFiltro
            // 
            btn_quitarFiltro.BackColor = Color.FromArgb(0, 84, 168);
            btn_quitarFiltro.FlatAppearance.BorderSize = 0;
            btn_quitarFiltro.FlatStyle = FlatStyle.Flat;
            btn_quitarFiltro.Location = new Point(1611, 20);
            btn_quitarFiltro.Name = "btn_quitarFiltro";
            btn_quitarFiltro.Size = new Size(161, 27);
            btn_quitarFiltro.TabIndex = 1;
            btn_quitarFiltro.Text = "Limpiar filtro";
            btn_quitarFiltro.UseVisualStyleBackColor = false;
            btn_quitarFiltro.Click += btn_quitarFiltro_Click;
            // 
            // Form_auditoriaUsuarios
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1820, 1333);
            Controls.Add(panel_grilla);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_auditoriaUsuarios";
            Text = "Auditoría de usuarios";
            Load += Form_auditoriaUsuarios_Load;
            panel_grilla.ResumeLayout(false);
            groupBox_grilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_botones.ResumeLayout(false);
            panel_filtro.ResumeLayout(false);
            panel_filtro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_grilla;
        private GroupBox groupBox_grilla;
        private DataGridView dataGridView1;
        private Panel panel_botones;
        private Panel panel_filtro;
        private TextBox txt_nombreUsuarioFiltro;
        private Label label1;
        private Button btn_quitarFiltro;
        private Label label3;
        private Label label2;
        private Button btn_cerrar;
        private Button btn_consultar;
        private Label label4;
        private DateTimePicker dtp_horaFiltro;
        private DateTimePicker dtp_fechaFiltro;
        private ComboBox cb_movimientoFiltro;
    }
}