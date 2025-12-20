namespace VISTA.Cabañas_y_alquiler
{
    partial class Form_seleccionarMotivosCancelacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_seleccionarMotivosCancelacion));
            checkedListBox_motivos = new CheckedListBox();
            btn_guardar = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btn_cerrar = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            SuspendLayout();
            // 
            // checkedListBox_motivos
            // 
            checkedListBox_motivos.FormattingEnabled = true;
            checkedListBox_motivos.Location = new Point(16, 54);
            checkedListBox_motivos.Name = "checkedListBox_motivos";
            checkedListBox_motivos.Size = new Size(306, 382);
            checkedListBox_motivos.TabIndex = 0;
            // 
            // btn_guardar
            // 
            btn_guardar.FlatAppearance.BorderColor = Color.FromArgb(0, 86, 172);
            btn_guardar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btn_guardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 85, 85);
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Location = new Point(114, 453);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(100, 40);
            btn_guardar.TabIndex = 2;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 82, 164);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_cerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 34);
            panel1.TabIndex = 3;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 2);
            label1.Name = "label1";
            label1.Size = new Size(245, 32);
            label1.TabIndex = 13;
            label1.Text = "Selección Motivos";
            label1.MouseDown += label1_MouseDown;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(306, 1);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(32, 33);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 1;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 86, 172);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(328, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 488);
            panel2.TabIndex = 4;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 86, 172);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 488);
            panel3.TabIndex = 5;
            panel3.MouseDown += panel3_MouseDown;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 86, 172);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(10, 512);
            panel4.Name = "panel4";
            panel4.Size = new Size(318, 10);
            panel4.TabIndex = 6;
            panel4.MouseDown += panel4_MouseDown;
            // 
            // Form_seleccionarMotivosCancelacion
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(338, 522);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_guardar);
            Controls.Add(checkedListBox_motivos);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_seleccionarMotivosCancelacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleccion de motivos de cancelacion";
            Load += Form_seleccionarMotivosCancelacion_Load;
            MouseDown += Form_seleccionarMotivosCancelacion_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBox_motivos;
        private Button btn_guardar;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox btn_cerrar;
        private Label label1;
        private Panel panel4;
    }
}