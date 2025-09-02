namespace VISTA.Cabañas_y_alquiler
{
    partial class Form_duracionDesactivacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_duracionDesactivacion));
            numericUpDown_dias = new NumericUpDown();
            label1 = new Label();
            btn_guardar = new Button();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_dias).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown_dias
            // 
            numericUpDown_dias.Location = new Point(79, 106);
            numericUpDown_dias.Name = "numericUpDown_dias";
            numericUpDown_dias.Size = new Size(137, 22);
            numericUpDown_dias.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F);
            label1.Location = new Point(62, 39);
            label1.Name = "label1";
            label1.Size = new Size(173, 17);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el numero de días";
            // 
            // btn_guardar
            // 
            btn_guardar.FlatAppearance.BorderColor = Color.FromArgb(0, 86, 172);
            btn_guardar.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btn_guardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 85, 85);
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Location = new Point(98, 160);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(101, 43);
            btn_guardar.TabIndex = 2;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 82, 164);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 30);
            panel1.TabIndex = 3;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 9);
            label3.Name = "label3";
            label3.Size = new Size(212, 21);
            label3.TabIndex = 13;
            label3.Text = "Duración Desactivación";
            label3.MouseDown += label3_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(270, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 86, 172);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(290, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 193);
            panel2.TabIndex = 4;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 86, 172);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 193);
            panel3.TabIndex = 5;
            panel3.MouseDown += panel3_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F);
            label2.Location = new Point(79, 56);
            label2.Name = "label2";
            label2.Size = new Size(137, 17);
            label2.TabIndex = 6;
            label2.Text = "de la desactivación";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 86, 172);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(10, 213);
            panel4.Name = "panel4";
            panel4.Size = new Size(280, 10);
            panel4.TabIndex = 7;
            // 
            // Form_duracionDesactivacion
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(300, 223);
            Controls.Add(panel4);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_guardar);
            Controls.Add(label1);
            Controls.Add(numericUpDown_dias);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_duracionDesactivacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Duracion de desactivación";
            Load += Form_duracionDesactivacion_Load;
            MouseDown += Form_duracionDesactivacion_MouseDown;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_dias).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown_dias;
        private Label label1;
        private Button btn_guardar;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel4;
    }
}