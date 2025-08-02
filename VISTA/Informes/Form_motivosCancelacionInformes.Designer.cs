namespace VISTA.Informes
{
    partial class Form_motivosCancelacionInformes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_motivosCancelacionInformes));
            panel_botones = new Panel();
            btn_exportarPDF = new PictureBox();
            btn_cerrar = new Button();
            btn_exportarExcel = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            dtp_hasta = new DateTimePicker();
            dtp_desde = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel_grafico = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            label_nroCabañas = new Label();
            flowLayoutPanel_datos = new FlowLayoutPanel();
            panel_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_exportarPDF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_exportarExcel).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel_botones
            // 
            panel_botones.BorderStyle = BorderStyle.FixedSingle;
            panel_botones.Controls.Add(btn_exportarPDF);
            panel_botones.Controls.Add(btn_cerrar);
            panel_botones.Controls.Add(btn_exportarExcel);
            panel_botones.Dock = DockStyle.Bottom;
            panel_botones.Location = new Point(0, 590);
            panel_botones.Name = "panel_botones";
            panel_botones.Size = new Size(1164, 75);
            panel_botones.TabIndex = 0;
            // 
            // btn_exportarPDF
            // 
            btn_exportarPDF.Image = (Image)resources.GetObject("btn_exportarPDF.Image");
            btn_exportarPDF.Location = new Point(12, 12);
            btn_exportarPDF.Name = "btn_exportarPDF";
            btn_exportarPDF.Size = new Size(61, 51);
            btn_exportarPDF.SizeMode = PictureBoxSizeMode.Zoom;
            btn_exportarPDF.TabIndex = 9;
            btn_exportarPDF.TabStop = false;
            btn_exportarPDF.Click += btn_exportarPDF_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.Location = new Point(1048, 38);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(102, 23);
            btn_cerrar.TabIndex = 8;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_exportarExcel
            // 
            btn_exportarExcel.Image = (Image)resources.GetObject("btn_exportarExcel.Image");
            btn_exportarExcel.Location = new Point(92, 12);
            btn_exportarExcel.Name = "btn_exportarExcel";
            btn_exportarExcel.Size = new Size(62, 51);
            btn_exportarExcel.SizeMode = PictureBoxSizeMode.Zoom;
            btn_exportarExcel.TabIndex = 0;
            btn_exportarExcel.TabStop = false;
            btn_exportarExcel.Click += btn_exportarExcel_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1107, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(57, 590);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtp_hasta);
            panel2.Controls.Add(dtp_desde);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1107, 101);
            panel2.TabIndex = 3;
            // 
            // dtp_hasta
            // 
            dtp_hasta.Format = DateTimePickerFormat.Short;
            dtp_hasta.Location = new Point(624, 66);
            dtp_hasta.Name = "dtp_hasta";
            dtp_hasta.Size = new Size(200, 23);
            dtp_hasta.TabIndex = 4;
            dtp_hasta.ValueChanged += dtp_hasta_ValueChanged;
            // 
            // dtp_desde
            // 
            dtp_desde.Format = DateTimePickerFormat.Short;
            dtp_desde.Location = new Point(340, 66);
            dtp_desde.Name = "dtp_desde";
            dtp_desde.Size = new Size(200, 23);
            dtp_desde.TabIndex = 3;
            dtp_desde.ValueChanged += dtp_desde_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(578, 72);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Hasta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 69);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Desde:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(437, 28);
            label1.Name = "label1";
            label1.Size = new Size(265, 20);
            label1.TabIndex = 0;
            label1.Text = "Porcentaje de motivos de cancelación";
            // 
            // panel_grafico
            // 
            panel_grafico.Dock = DockStyle.Right;
            panel_grafico.Location = new Point(622, 101);
            panel_grafico.Name = "panel_grafico";
            panel_grafico.Size = new Size(485, 489);
            panel_grafico.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 101);
            panel4.Name = "panel4";
            panel4.Size = new Size(104, 489);
            panel4.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(label_nroCabañas);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(104, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(518, 120);
            panel3.TabIndex = 8;
            // 
            // label_nroCabañas
            // 
            label_nroCabañas.AutoSize = true;
            label_nroCabañas.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_nroCabañas.Location = new Point(6, 60);
            label_nroCabañas.Name = "label_nroCabañas";
            label_nroCabañas.Size = new Size(11, 17);
            label_nroCabañas.TabIndex = 0;
            label_nroCabañas.Text = "l";
            // 
            // flowLayoutPanel_datos
            // 
            flowLayoutPanel_datos.Dock = DockStyle.Fill;
            flowLayoutPanel_datos.Location = new Point(104, 221);
            flowLayoutPanel_datos.Name = "flowLayoutPanel_datos";
            flowLayoutPanel_datos.Size = new Size(518, 369);
            flowLayoutPanel_datos.TabIndex = 9;
            // 
            // Form_motivosCancelacionInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 665);
            Controls.Add(flowLayoutPanel_datos);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel_grafico);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel_botones);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_motivosCancelacionInformes";
            Text = "Form_motivosCancelacion";
            Load += Form_motivosCancelacionInformes_Load;
            panel_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_exportarPDF).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_exportarExcel).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_botones;
        private Panel panel1;
        private PictureBox btn_exportarExcel;
        private Button btn_cerrar;
        private PictureBox btn_exportarPDF;
        private Panel panel2;
        private Label label1;
        private Panel panel_grafico;
        private Panel panel4;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel_datos;
        private Label label_nroCabañas;
        private DateTimePicker dtp_hasta;
        private DateTimePicker dtp_desde;
        private Label label3;
        private Label label2;
    }
}