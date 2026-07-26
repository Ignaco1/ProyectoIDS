namespace VISTA.Informes
{
    partial class Form_gastosMantenimientosInforme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_gastosMantenimientosInforme));
            panel_botones = new Panel();
            btn_exportarPDF = new PictureBox();
            btn_cerrar = new Button();
            btn_exportarExcel = new PictureBox();
            panel1 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            panel_btnGenerar = new Panel();
            btn_generar = new Button();
            panel_seleccionTopCabañas = new Panel();
            label5 = new Label();
            label3 = new Label();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            btn_rankingCabañas = new Button();
            panel6 = new Panel();
            panel_seleccionRangoFechas = new Panel();
            label2 = new Label();
            label4 = new Label();
            dtp_hasta = new DateTimePicker();
            dtp_desde = new DateTimePicker();
            label1 = new Label();
            panel17 = new Panel();
            panel18 = new Panel();
            panel19 = new Panel();
            panel20 = new Panel();
            btn_gastoPorRango = new Button();
            panel3 = new Panel();
            panel_seleccionMes = new Panel();
            label6 = new Label();
            label = new Label();
            panel21 = new Panel();
            panel22 = new Panel();
            panel23 = new Panel();
            panel24 = new Panel();
            btn_gastoMes = new Button();
            panel5 = new Panel();
            panel_titulo = new Panel();
            label_titulo = new Label();
            panel_datosGrafico = new Panel();
            label_datosGrafico = new Label();
            panel_grafico = new Panel();
            label7 = new Label();
            panel7 = new Panel();
            panel_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_exportarPDF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_exportarExcel).BeginInit();
            panel2.SuspendLayout();
            panel_btnGenerar.SuspendLayout();
            panel_seleccionTopCabañas.SuspendLayout();
            panel_seleccionRangoFechas.SuspendLayout();
            panel_seleccionMes.SuspendLayout();
            panel_titulo.SuspendLayout();
            panel_datosGrafico.SuspendLayout();
            SuspendLayout();
            // 
            // panel_botones
            // 
            panel_botones.BorderStyle = BorderStyle.FixedSingle;
            panel_botones.Controls.Add(btn_exportarPDF);
            panel_botones.Controls.Add(btn_cerrar);
            panel_botones.Controls.Add(btn_exportarExcel);
            panel_botones.Dock = DockStyle.Bottom;
            panel_botones.Location = new Point(0, 1248);
            panel_botones.Name = "panel_botones";
            panel_botones.Size = new Size(1820, 85);
            panel_botones.TabIndex = 0;
            // 
            // btn_exportarPDF
            // 
            btn_exportarPDF.Image = (Image)resources.GetObject("btn_exportarPDF.Image");
            btn_exportarPDF.Location = new Point(11, 5);
            btn_exportarPDF.Name = "btn_exportarPDF";
            btn_exportarPDF.Size = new Size(83, 75);
            btn_exportarPDF.SizeMode = PictureBoxSizeMode.Zoom;
            btn_exportarPDF.TabIndex = 9;
            btn_exportarPDF.TabStop = false;
            btn_exportarPDF.Click += btn_exportarPDF_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Location = new Point(1654, 51);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(161, 27);
            btn_cerrar.TabIndex = 8;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_exportarExcel
            // 
            btn_exportarExcel.Image = (Image)resources.GetObject("btn_exportarExcel.Image");
            btn_exportarExcel.Location = new Point(109, 5);
            btn_exportarExcel.Name = "btn_exportarExcel";
            btn_exportarExcel.Size = new Size(83, 75);
            btn_exportarExcel.SizeMode = PictureBoxSizeMode.Zoom;
            btn_exportarExcel.TabIndex = 0;
            btn_exportarExcel.TabStop = false;
            btn_exportarExcel.Click += btn_exportarExcel_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1799, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(21, 1248);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(21, 1248);
            panel4.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel_btnGenerar);
            panel2.Controls.Add(panel_seleccionTopCabañas);
            panel2.Controls.Add(panel_seleccionRangoFechas);
            panel2.Controls.Add(panel_seleccionMes);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(21, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1778, 296);
            panel2.TabIndex = 8;
            // 
            // panel_btnGenerar
            // 
            panel_btnGenerar.BorderStyle = BorderStyle.FixedSingle;
            panel_btnGenerar.Controls.Add(btn_generar);
            panel_btnGenerar.Dock = DockStyle.Fill;
            panel_btnGenerar.Location = new Point(1332, 0);
            panel_btnGenerar.Name = "panel_btnGenerar";
            panel_btnGenerar.Size = new Size(446, 296);
            panel_btnGenerar.TabIndex = 9;
            // 
            // btn_generar
            // 
            btn_generar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_generar.BackColor = Color.FromArgb(0, 84, 168);
            btn_generar.FlatAppearance.BorderSize = 0;
            btn_generar.FlatStyle = FlatStyle.Flat;
            btn_generar.Location = new Point(96, 103);
            btn_generar.Name = "btn_generar";
            btn_generar.Size = new Size(252, 83);
            btn_generar.TabIndex = 6;
            btn_generar.Text = "Generar informe";
            btn_generar.UseVisualStyleBackColor = false;
            btn_generar.Click += btn_generar_Click;
            // 
            // panel_seleccionTopCabañas
            // 
            panel_seleccionTopCabañas.BorderStyle = BorderStyle.FixedSingle;
            panel_seleccionTopCabañas.Controls.Add(label5);
            panel_seleccionTopCabañas.Controls.Add(label3);
            panel_seleccionTopCabañas.Controls.Add(panel13);
            panel_seleccionTopCabañas.Controls.Add(panel14);
            panel_seleccionTopCabañas.Controls.Add(panel15);
            panel_seleccionTopCabañas.Controls.Add(panel16);
            panel_seleccionTopCabañas.Controls.Add(btn_rankingCabañas);
            panel_seleccionTopCabañas.Controls.Add(panel6);
            panel_seleccionTopCabañas.Dock = DockStyle.Left;
            panel_seleccionTopCabañas.Location = new Point(888, 0);
            panel_seleccionTopCabañas.Name = "panel_seleccionTopCabañas";
            panel_seleccionTopCabañas.Size = new Size(444, 296);
            panel_seleccionTopCabañas.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(47, 189);
            label5.Name = "label5";
            label5.Size = new Size(367, 27);
            label5.TabIndex = 51;
            label5.Text = "en mantenimiento de cabañas";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(72, 138);
            label3.Name = "label3";
            label3.Size = new Size(302, 27);
            label3.TabIndex = 50;
            label3.Text = "Mostrar ranking de gastos";
            // 
            // panel13
            // 
            panel13.BackColor = Color.Black;
            panel13.Enabled = false;
            panel13.Location = new Point(110, 11);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(220, 2);
            panel13.TabIndex = 48;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Black;
            panel14.Enabled = false;
            panel14.Location = new Point(328, 11);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Size = new Size(2, 50);
            panel14.TabIndex = 47;
            // 
            // panel15
            // 
            panel15.BackColor = Color.Black;
            panel15.Enabled = false;
            panel15.Location = new Point(108, 11);
            panel15.Margin = new Padding(3, 4, 3, 4);
            panel15.Name = "panel15";
            panel15.Size = new Size(2, 50);
            panel15.TabIndex = 46;
            // 
            // panel16
            // 
            panel16.BackColor = Color.Black;
            panel16.Enabled = false;
            panel16.Location = new Point(108, 61);
            panel16.Margin = new Padding(3, 4, 3, 4);
            panel16.Name = "panel16";
            panel16.Size = new Size(222, 2);
            panel16.TabIndex = 45;
            // 
            // btn_rankingCabañas
            // 
            btn_rankingCabañas.BackColor = Color.Gray;
            btn_rankingCabañas.FlatAppearance.BorderSize = 0;
            btn_rankingCabañas.FlatStyle = FlatStyle.Flat;
            btn_rankingCabañas.ForeColor = Color.White;
            btn_rankingCabañas.Location = new Point(110, 11);
            btn_rankingCabañas.Name = "btn_rankingCabañas";
            btn_rankingCabañas.Size = new Size(218, 52);
            btn_rankingCabañas.TabIndex = 44;
            btn_rankingCabañas.Text = "Generar informe";
            btn_rankingCabañas.UseVisualStyleBackColor = false;
            btn_rankingCabañas.Click += btn_rankingCabañas_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Enabled = false;
            panel6.Location = new Point(0, 70);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(500, 2);
            panel6.TabIndex = 38;
            // 
            // panel_seleccionRangoFechas
            // 
            panel_seleccionRangoFechas.BorderStyle = BorderStyle.FixedSingle;
            panel_seleccionRangoFechas.Controls.Add(label2);
            panel_seleccionRangoFechas.Controls.Add(label4);
            panel_seleccionRangoFechas.Controls.Add(dtp_hasta);
            panel_seleccionRangoFechas.Controls.Add(dtp_desde);
            panel_seleccionRangoFechas.Controls.Add(label1);
            panel_seleccionRangoFechas.Controls.Add(panel17);
            panel_seleccionRangoFechas.Controls.Add(panel18);
            panel_seleccionRangoFechas.Controls.Add(panel19);
            panel_seleccionRangoFechas.Controls.Add(panel20);
            panel_seleccionRangoFechas.Controls.Add(btn_gastoPorRango);
            panel_seleccionRangoFechas.Controls.Add(panel3);
            panel_seleccionRangoFechas.Dock = DockStyle.Left;
            panel_seleccionRangoFechas.Location = new Point(444, 0);
            panel_seleccionRangoFechas.Name = "panel_seleccionRangoFechas";
            panel_seleccionRangoFechas.Size = new Size(444, 296);
            panel_seleccionRangoFechas.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(69, 231);
            label2.Name = "label2";
            label2.Size = new Size(83, 27);
            label2.TabIndex = 56;
            label2.Text = "Hasta:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(62, 158);
            label4.Name = "label4";
            label4.Size = new Size(90, 27);
            label4.TabIndex = 55;
            label4.Text = "Desde:";
            // 
            // dtp_hasta
            // 
            dtp_hasta.Format = DateTimePickerFormat.Short;
            dtp_hasta.Location = new Point(158, 233);
            dtp_hasta.Name = "dtp_hasta";
            dtp_hasta.Size = new Size(200, 26);
            dtp_hasta.TabIndex = 54;
            // 
            // dtp_desde
            // 
            dtp_desde.Format = DateTimePickerFormat.Short;
            dtp_desde.Location = new Point(158, 160);
            dtp_desde.Name = "dtp_desde";
            dtp_desde.Size = new Size(200, 26);
            dtp_desde.TabIndex = 52;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 90);
            label1.Name = "label1";
            label1.Size = new Size(411, 27);
            label1.TabIndex = 50;
            label1.Text = "Mostrar gastos por rango de fechas";
            // 
            // panel17
            // 
            panel17.BackColor = Color.Black;
            panel17.Enabled = false;
            panel17.Location = new Point(109, 11);
            panel17.Margin = new Padding(3, 4, 3, 4);
            panel17.Name = "panel17";
            panel17.Size = new Size(220, 2);
            panel17.TabIndex = 48;
            // 
            // panel18
            // 
            panel18.BackColor = Color.Black;
            panel18.Enabled = false;
            panel18.Location = new Point(327, 11);
            panel18.Margin = new Padding(3, 4, 3, 4);
            panel18.Name = "panel18";
            panel18.Size = new Size(2, 50);
            panel18.TabIndex = 47;
            // 
            // panel19
            // 
            panel19.BackColor = Color.Black;
            panel19.Enabled = false;
            panel19.Location = new Point(107, 11);
            panel19.Margin = new Padding(3, 4, 3, 4);
            panel19.Name = "panel19";
            panel19.Size = new Size(2, 50);
            panel19.TabIndex = 46;
            // 
            // panel20
            // 
            panel20.BackColor = Color.Black;
            panel20.Enabled = false;
            panel20.Location = new Point(107, 61);
            panel20.Margin = new Padding(3, 4, 3, 4);
            panel20.Name = "panel20";
            panel20.Size = new Size(222, 2);
            panel20.TabIndex = 45;
            // 
            // btn_gastoPorRango
            // 
            btn_gastoPorRango.BackColor = Color.Gray;
            btn_gastoPorRango.FlatAppearance.BorderSize = 0;
            btn_gastoPorRango.FlatStyle = FlatStyle.Flat;
            btn_gastoPorRango.ForeColor = Color.White;
            btn_gastoPorRango.Location = new Point(109, 11);
            btn_gastoPorRango.Name = "btn_gastoPorRango";
            btn_gastoPorRango.Size = new Size(218, 52);
            btn_gastoPorRango.TabIndex = 44;
            btn_gastoPorRango.Text = "Generar informe";
            btn_gastoPorRango.UseVisualStyleBackColor = false;
            btn_gastoPorRango.Click += btn_gastoPorRango_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Enabled = false;
            panel3.Location = new Point(0, 70);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 2);
            panel3.TabIndex = 39;
            // 
            // panel_seleccionMes
            // 
            panel_seleccionMes.BorderStyle = BorderStyle.FixedSingle;
            panel_seleccionMes.Controls.Add(label6);
            panel_seleccionMes.Controls.Add(label);
            panel_seleccionMes.Controls.Add(panel21);
            panel_seleccionMes.Controls.Add(panel22);
            panel_seleccionMes.Controls.Add(panel23);
            panel_seleccionMes.Controls.Add(panel24);
            panel_seleccionMes.Controls.Add(btn_gastoMes);
            panel_seleccionMes.Controls.Add(panel5);
            panel_seleccionMes.Dock = DockStyle.Left;
            panel_seleccionMes.Location = new Point(0, 0);
            panel_seleccionMes.Name = "panel_seleccionMes";
            panel_seleccionMes.Size = new Size(444, 296);
            panel_seleccionMes.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(129, 189);
            label6.Name = "label6";
            label6.Size = new Size(182, 27);
            label6.TabIndex = 52;
            label6.Text = "del mes actual";
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label.AutoSize = true;
            label.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(21, 145);
            label.Name = "label";
            label.Size = new Size(400, 27);
            label.TabIndex = 49;
            label.Text = "Mostrar gastos en mantenimientos";
            // 
            // panel21
            // 
            panel21.BackColor = Color.Black;
            panel21.Enabled = false;
            panel21.Location = new Point(107, 11);
            panel21.Margin = new Padding(3, 4, 3, 4);
            panel21.Name = "panel21";
            panel21.Size = new Size(220, 2);
            panel21.TabIndex = 48;
            // 
            // panel22
            // 
            panel22.BackColor = Color.Black;
            panel22.Enabled = false;
            panel22.Location = new Point(325, 11);
            panel22.Margin = new Padding(3, 4, 3, 4);
            panel22.Name = "panel22";
            panel22.Size = new Size(2, 50);
            panel22.TabIndex = 47;
            // 
            // panel23
            // 
            panel23.BackColor = Color.Black;
            panel23.Enabled = false;
            panel23.Location = new Point(105, 11);
            panel23.Margin = new Padding(3, 4, 3, 4);
            panel23.Name = "panel23";
            panel23.Size = new Size(2, 50);
            panel23.TabIndex = 46;
            // 
            // panel24
            // 
            panel24.BackColor = Color.Black;
            panel24.Enabled = false;
            panel24.Location = new Point(105, 61);
            panel24.Margin = new Padding(3, 4, 3, 4);
            panel24.Name = "panel24";
            panel24.Size = new Size(222, 2);
            panel24.TabIndex = 45;
            // 
            // btn_gastoMes
            // 
            btn_gastoMes.BackColor = Color.Gray;
            btn_gastoMes.FlatAppearance.BorderSize = 0;
            btn_gastoMes.FlatStyle = FlatStyle.Flat;
            btn_gastoMes.ForeColor = Color.White;
            btn_gastoMes.Location = new Point(107, 11);
            btn_gastoMes.Name = "btn_gastoMes";
            btn_gastoMes.Size = new Size(218, 52);
            btn_gastoMes.TabIndex = 44;
            btn_gastoMes.Text = "Generar informe";
            btn_gastoMes.UseVisualStyleBackColor = false;
            btn_gastoMes.Click += btn_gastoMes_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Enabled = false;
            panel5.Location = new Point(0, 70);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(500, 2);
            panel5.TabIndex = 39;
            // 
            // panel_titulo
            // 
            panel_titulo.BorderStyle = BorderStyle.FixedSingle;
            panel_titulo.Controls.Add(label_titulo);
            panel_titulo.Dock = DockStyle.Top;
            panel_titulo.Location = new Point(21, 296);
            panel_titulo.Name = "panel_titulo";
            panel_titulo.Size = new Size(1778, 116);
            panel_titulo.TabIndex = 9;
            // 
            // label_titulo
            // 
            label_titulo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_titulo.AutoSize = true;
            label_titulo.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_titulo.ForeColor = Color.White;
            label_titulo.Location = new Point(21, 47);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new Size(93, 27);
            label_titulo.TabIndex = 50;
            label_titulo.Text = "TITULO:";
            label_titulo.Visible = false;
            // 
            // panel_datosGrafico
            // 
            panel_datosGrafico.BorderStyle = BorderStyle.FixedSingle;
            panel_datosGrafico.Controls.Add(panel7);
            panel_datosGrafico.Controls.Add(label7);
            panel_datosGrafico.Controls.Add(label_datosGrafico);
            panel_datosGrafico.Dock = DockStyle.Left;
            panel_datosGrafico.Location = new Point(21, 412);
            panel_datosGrafico.Name = "panel_datosGrafico";
            panel_datosGrafico.Size = new Size(491, 836);
            panel_datosGrafico.TabIndex = 10;
            // 
            // label_datosGrafico
            //
            label_datosGrafico.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            label_datosGrafico.AutoSize = true;
            label_datosGrafico.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_datosGrafico.ForeColor = Color.White;
            label_datosGrafico.Location = new Point(13, 104);
            label_datosGrafico.MaximumSize = new Size(460, 0);
            label_datosGrafico.Name = "label_datosGrafico";
            label_datosGrafico.Size = new Size(94, 27);
            label_datosGrafico.TabIndex = 51;
            label_datosGrafico.Text = "DATOS:";
            label_datosGrafico.Visible = false;
            // 
            // panel_grafico
            // 
            panel_grafico.BorderStyle = BorderStyle.FixedSingle;
            panel_grafico.Dock = DockStyle.Fill;
            panel_grafico.Location = new Point(512, 412);
            panel_grafico.Name = "panel_grafico";
            panel_grafico.Size = new Size(1287, 836);
            panel_grafico.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 46);
            label7.Name = "label7";
            label7.Size = new Size(94, 27);
            label7.TabIndex = 52;
            label7.Text = "DATOS:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Enabled = false;
            panel7.Location = new Point(13, 71);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(90, 2);
            panel7.TabIndex = 53;
            // 
            // Form_gastosMantenimientosInforme
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1820, 1333);
            Controls.Add(panel_grafico);
            Controls.Add(panel_datosGrafico);
            Controls.Add(panel_titulo);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel_botones);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_gastosMantenimientosInforme";
            Text = "Form_gastosMantenimientosInforme";
            Load += Form_gastosMantenimientosInforme_Load;
            panel_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_exportarPDF).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_exportarExcel).EndInit();
            panel2.ResumeLayout(false);
            panel_btnGenerar.ResumeLayout(false);
            panel_seleccionTopCabañas.ResumeLayout(false);
            panel_seleccionTopCabañas.PerformLayout();
            panel_seleccionRangoFechas.ResumeLayout(false);
            panel_seleccionRangoFechas.PerformLayout();
            panel_seleccionMes.ResumeLayout(false);
            panel_seleccionMes.PerformLayout();
            panel_titulo.ResumeLayout(false);
            panel_titulo.PerformLayout();
            panel_datosGrafico.ResumeLayout(false);
            panel_datosGrafico.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_botones;
        private Panel panel1;
        private PictureBox btn_exportarExcel;
        private Button btn_cerrar;
        private PictureBox btn_exportarPDF;
        private Panel panel4;
        private Panel panel2;
        private Panel panel_seleccionTopCabañas;
        private Panel panel_seleccionRangoFechas;
        private Panel panel_seleccionMes;
        private Panel panel_titulo;
        private Panel panel_btnGenerar;
        private Button btn_generar;
        private Panel panel6;
        private Panel panel3;
        private Panel panel5;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Button btn_rankingCabañas;
        private Panel panel17;
        private Panel panel18;
        private Panel panel19;
        private Panel panel20;
        private Button btn_gastoPorRango;
        private Panel panel21;
        private Panel panel22;
        private Panel panel23;
        private Panel panel24;
        private Button btn_gastoMes;
        private Label label;
        private Label label1;
        private DateTimePicker dtp_desde;
        private DateTimePicker dtp_hasta;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label_titulo;
        private Panel panel_datosGrafico;
        private Label label_datosGrafico;
        private Panel panel_grafico;
        private Label label7;
        private Panel panel7;
    }
}