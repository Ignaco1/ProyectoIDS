namespace VISTA.Cabañas_y_alquiler
{
    partial class Form_desplegarServicios
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
            horaPicker = new DateTimePicker();
            dtp_fechaSeleccionada = new DateTimePicker();
            label2 = new Label();
            txt_nombreFiltro = new TextBox();
            txt_importeFiltro = new TextBox();
            label9 = new Label();
            label1 = new Label();
            btn_quitarFiltro = new Button();
            panel2 = new Panel();
            btn_cerrar = new Button();
            panel3 = new Panel();
            flp_servicios = new FlowLayoutPanel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(horaPicker);
            panel1.Controls.Add(dtp_fechaSeleccionada);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_nombreFiltro);
            panel1.Controls.Add(txt_importeFiltro);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_quitarFiltro);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1820, 93);
            panel1.TabIndex = 0;
            // 
            // horaPicker
            // 
            horaPicker.Format = DateTimePickerFormat.Time;
            horaPicker.Location = new Point(1432, 40);
            horaPicker.Name = "horaPicker";
            horaPicker.ShowUpDown = true;
            horaPicker.Size = new Size(123, 26);
            horaPicker.TabIndex = 49;
            horaPicker.Value = new DateTime(2026, 7, 20, 23, 2, 28, 0);
            horaPicker.ValueChanged += horaPicker_ValueChanged;
            // 
            // dtp_fechaSeleccionada
            // 
            dtp_fechaSeleccionada.Format = DateTimePickerFormat.Short;
            dtp_fechaSeleccionada.Location = new Point(1032, 40);
            dtp_fechaSeleccionada.Name = "dtp_fechaSeleccionada";
            dtp_fechaSeleccionada.Size = new Size(272, 26);
            dtp_fechaSeleccionada.TabIndex = 48;
            dtp_fechaSeleccionada.Value = new DateTime(2025, 7, 25, 18, 57, 0, 0);
            dtp_fechaSeleccionada.ValueChanged += dtp_fechaSeleccionada_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(862, 44);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 46;
            label2.Text = "Fecha seleccionada:";
            // 
            // txt_nombreFiltro
            // 
            txt_nombreFiltro.Location = new Point(158, 42);
            txt_nombreFiltro.Name = "txt_nombreFiltro";
            txt_nombreFiltro.Size = new Size(239, 26);
            txt_nombreFiltro.TabIndex = 45;
            txt_nombreFiltro.TextChanged += txt_nombreFiltro_TextChanged;
            // 
            // txt_importeFiltro
            // 
            txt_importeFiltro.Location = new Point(570, 40);
            txt_importeFiltro.Name = "txt_importeFiltro";
            txt_importeFiltro.Size = new Size(217, 26);
            txt_importeFiltro.TabIndex = 44;
            txt_importeFiltro.TextChanged += txt_precioNocheFiltro_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(493, 42);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 43;
            label9.Text = "Importe:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 44);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 40;
            label1.Text = "Nombre:";
            // 
            // btn_quitarFiltro
            // 
            btn_quitarFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_quitarFiltro.BackColor = Color.FromArgb(0, 84, 168);
            btn_quitarFiltro.FlatAppearance.BorderSize = 0;
            btn_quitarFiltro.FlatStyle = FlatStyle.Flat;
            btn_quitarFiltro.Location = new Point(1646, 39);
            btn_quitarFiltro.Name = "btn_quitarFiltro";
            btn_quitarFiltro.Size = new Size(161, 27);
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
            panel2.Location = new Point(0, 1275);
            panel2.Name = "panel2";
            panel2.Size = new Size(1820, 58);
            panel2.TabIndex = 1;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Location = new Point(1646, 18);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(161, 27);
            btn_cerrar.TabIndex = 8;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(flp_servicios);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(1820, 1182);
            panel3.TabIndex = 2;
            // 
            // flp_servicios
            // 
            flp_servicios.AutoScroll = true;
            flp_servicios.Dock = DockStyle.Fill;
            flp_servicios.Location = new Point(0, 0);
            flp_servicios.Name = "flp_servicios";
            flp_servicios.Size = new Size(1820, 1182);
            flp_servicios.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1378, 43);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 50;
            label3.Text = "Hora:";
            // 
            // Form_desplegarServicios
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1820, 1333);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_desplegarServicios";
            Text = "Form_desplegarServicios";
            Load += Form_desplegarServicios_Load;
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
        private DateTimePicker dtp_fechaSeleccionada;
        private Label label2;
        private TextBox txt_nombreFiltro;
        private TextBox txt_importeFiltro;
        private Label label9;
        private Label label1;
        private Button btn_cerrar;
        private FlowLayoutPanel flp_servicios;
        private DateTimePicker horaPicker;
        private Label label3;
    }
}