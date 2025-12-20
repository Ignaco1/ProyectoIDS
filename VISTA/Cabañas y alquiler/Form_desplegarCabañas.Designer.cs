namespace VISTA.Cabañas_y_alquiler
{
    partial class Form_desplegarCabañas
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
            panel1 = new Panel();
            dtp_salida = new DateTimePicker();
            dtp_entrada = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            txt_nombreFiltro = new TextBox();
            txt_precioNocheFiltro = new TextBox();
            label9 = new Label();
            txt_capacidadFiltro = new TextBox();
            label8 = new Label();
            label1 = new Label();
            btn_quitarFiltro = new Button();
            panel2 = new Panel();
            btn_cerrar = new Button();
            panel3 = new Panel();
            flp_cabañas = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dtp_salida);
            panel1.Controls.Add(dtp_entrada);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_nombreFiltro);
            panel1.Controls.Add(txt_precioNocheFiltro);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txt_capacidadFiltro);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_quitarFiltro);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1883, 93);
            panel1.TabIndex = 0;
            // 
            // dtp_salida
            // 
            dtp_salida.Format = DateTimePickerFormat.Short;
            dtp_salida.Location = new Point(1406, 56);
            dtp_salida.Name = "dtp_salida";
            dtp_salida.Size = new Size(238, 30);
            dtp_salida.TabIndex = 49;
            dtp_salida.ValueChanged += dtp_salida_ValueChanged;
            // 
            // dtp_entrada
            // 
            dtp_entrada.Format = DateTimePickerFormat.Short;
            dtp_entrada.Location = new Point(1406, 9);
            dtp_entrada.Name = "dtp_entrada";
            dtp_entrada.Size = new Size(238, 30);
            dtp_entrada.TabIndex = 48;
            dtp_entrada.Value = new DateTime(2025, 7, 25, 18, 57, 0, 0);
            dtp_entrada.ValueChanged += dtp_entrada_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1244, 63);
            label3.Name = "label3";
            label3.Size = new Size(156, 21);
            label3.TabIndex = 47;
            label3.Text = "Fecha de Salida:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1224, 16);
            label2.Name = "label2";
            label2.Size = new Size(176, 21);
            label2.TabIndex = 46;
            label2.Text = "Fecha de entrada:";
            // 
            // txt_nombreFiltro
            // 
            txt_nombreFiltro.Location = new Point(175, 33);
            txt_nombreFiltro.Name = "txt_nombreFiltro";
            txt_nombreFiltro.Size = new Size(239, 30);
            txt_nombreFiltro.TabIndex = 45;
            txt_nombreFiltro.TextChanged += txt_nombreFiltro_TextChanged;
            // 
            // txt_precioNocheFiltro
            // 
            txt_precioNocheFiltro.Location = new Point(1000, 33);
            txt_precioNocheFiltro.Name = "txt_precioNocheFiltro";
            txt_precioNocheFiltro.Size = new Size(163, 30);
            txt_precioNocheFiltro.TabIndex = 44;
            txt_precioNocheFiltro.TextChanged += txt_precioNocheFiltro_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(827, 37);
            label9.Name = "label9";
            label9.Size = new Size(167, 21);
            label9.TabIndex = 43;
            label9.Text = "Precio por noche:";
            // 
            // txt_capacidadFiltro
            // 
            txt_capacidadFiltro.Location = new Point(581, 33);
            txt_capacidadFiltro.Name = "txt_capacidadFiltro";
            txt_capacidadFiltro.Size = new Size(141, 30);
            txt_capacidadFiltro.TabIndex = 42;
            txt_capacidadFiltro.TextChanged += txt_capacidadFiltro_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(464, 36);
            label8.Name = "label8";
            label8.Size = new Size(117, 21);
            label8.TabIndex = 41;
            label8.Text = "Capacidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 38);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 40;
            label1.Text = "Nombre:";
            // 
            // btn_quitarFiltro
            // 
            btn_quitarFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_quitarFiltro.BackColor = Color.FromArgb(0, 84, 168);
            btn_quitarFiltro.FlatAppearance.BorderSize = 0;
            btn_quitarFiltro.FlatStyle = FlatStyle.Flat;
            btn_quitarFiltro.Location = new Point(1733, 30);
            btn_quitarFiltro.Name = "btn_quitarFiltro";
            btn_quitarFiltro.Size = new Size(137, 31);
            btn_quitarFiltro.TabIndex = 34;
            btn_quitarFiltro.Text = "Limpiar filtro";
            btn_quitarFiltro.UseVisualStyleBackColor = false;
            btn_quitarFiltro.Click += btn_quitarFiltro_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_cerrar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1512);
            panel2.Name = "panel2";
            panel2.Size = new Size(1883, 58);
            panel2.TabIndex = 1;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Location = new Point(1741, 12);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(137, 33);
            btn_cerrar.TabIndex = 8;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(flp_cabañas);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(1883, 1419);
            panel3.TabIndex = 2;
            // 
            // flp_cabañas
            // 
            flp_cabañas.AutoScroll = true;
            flp_cabañas.Dock = DockStyle.Fill;
            flp_cabañas.Location = new Point(0, 0);
            flp_cabañas.Name = "flp_cabañas";
            flp_cabañas.Size = new Size(1883, 1419);
            flp_cabañas.TabIndex = 0;
            // 
            // Form_desplegarCabañas
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1883, 1570);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_desplegarCabañas";
            Text = "Form_realizarAlquiler";
            Load += Form_realizarAlquiler_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btn_quitarFiltro;
        private DateTimePicker dtp_salida;
        private DateTimePicker dtp_entrada;
        private Label label3;
        private Label label2;
        private TextBox txt_nombreFiltro;
        private TextBox txt_precioNocheFiltro;
        private Label label9;
        private TextBox txt_capacidadFiltro;
        private Label label8;
        private Label label1;
        private Button btn_cerrar;
        private FlowLayoutPanel flp_cabañas;
    }
}