namespace VISTA
{
    partial class Form_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_inicio));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            txt_usuario = new TextBox();
            txt_contra = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            btn_acceder = new Button();
            lbl_contra = new LinkLabel();
            btn_cerrar = new PictureBox();
            btn_minimizar = new PictureBox();
            btn_ver = new PictureBox();
            bnt_dejarVer = new PictureBox();
            label_error = new Label();
            pictureBox_error = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_ver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bnt_dejarVer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_error).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 114, 227);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 546);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 53);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(257, 418);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += pictureBox3_MouseDown;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Enabled = false;
            panel2.Location = new Point(429, 170);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 1);
            panel2.TabIndex = 1;
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = Color.FromArgb(0, 40, 81);
            txt_usuario.BorderStyle = BorderStyle.None;
            txt_usuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_usuario.ForeColor = Color.White;
            txt_usuario.Location = new Point(429, 137);
            txt_usuario.Margin = new Padding(3, 4, 3, 4);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(514, 25);
            txt_usuario.TabIndex = 1;
            txt_usuario.Text = "USUARIO";
            txt_usuario.Enter += txt_usuario_Enter;
            txt_usuario.Leave += txt_usuario_Leave;
            // 
            // txt_contra
            // 
            txt_contra.BackColor = Color.FromArgb(0, 40, 81);
            txt_contra.BorderStyle = BorderStyle.None;
            txt_contra.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_contra.ForeColor = Color.White;
            txt_contra.Location = new Point(429, 223);
            txt_contra.Margin = new Padding(3, 4, 3, 4);
            txt_contra.Name = "txt_contra";
            txt_contra.Size = new Size(514, 25);
            txt_contra.TabIndex = 2;
            txt_contra.Text = "CONTRASEÑA";
            txt_contra.Enter += txt_contra_Enter;
            txt_contra.Leave += txt_contra_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Enabled = false;
            panel3.Location = new Point(429, 258);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(514, 1);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(619, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 40);
            label1.TabIndex = 4;
            label1.Text = "LOGIN";
            label1.MouseDown += label1_MouseDown;
            // 
            // btn_acceder
            // 
            btn_acceder.BackColor = Color.FromArgb(0, 40, 81);
            btn_acceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(65, 65, 65);
            btn_acceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 102, 204);
            btn_acceder.FlatStyle = FlatStyle.Flat;
            btn_acceder.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_acceder.ForeColor = Color.White;
            btn_acceder.Location = new Point(429, 362);
            btn_acceder.Margin = new Padding(3, 4, 3, 4);
            btn_acceder.Name = "btn_acceder";
            btn_acceder.Size = new Size(514, 53);
            btn_acceder.TabIndex = 3;
            btn_acceder.Text = "ACCEDER";
            btn_acceder.UseVisualStyleBackColor = false;
            btn_acceder.Click += btn_acceder_Click;
            // 
            // lbl_contra
            // 
            lbl_contra.ActiveLinkColor = Color.FromArgb(45, 150, 255);
            lbl_contra.AutoSize = true;
            lbl_contra.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_contra.ForeColor = SystemColors.ControlText;
            lbl_contra.LinkColor = Color.White;
            lbl_contra.Location = new Point(567, 442);
            lbl_contra.Name = "lbl_contra";
            lbl_contra.Size = new Size(264, 21);
            lbl_contra.TabIndex = 0;
            lbl_contra.TabStop = true;
            lbl_contra.Text = "¿Has olvidado tu contraseña?";
            lbl_contra.LinkClicked += lbl_contra_LinkClicked;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(1017, 0);
            btn_cerrar.Margin = new Padding(3, 4, 3, 4);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(34, 40);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 7;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_minimizar
            // 
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(986, 0);
            btn_minimizar.Margin = new Padding(3, 4, 3, 4);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(34, 40);
            btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar.TabIndex = 8;
            btn_minimizar.TabStop = false;
            btn_minimizar.Click += btn_minimizar_Click;
            // 
            // btn_ver
            // 
            btn_ver.Image = (Image)resources.GetObject("btn_ver.Image");
            btn_ver.Location = new Point(908, 218);
            btn_ver.Margin = new Padding(3, 4, 3, 4);
            btn_ver.Name = "btn_ver";
            btn_ver.Size = new Size(35, 32);
            btn_ver.SizeMode = PictureBoxSizeMode.Zoom;
            btn_ver.TabIndex = 9;
            btn_ver.TabStop = false;
            btn_ver.Click += btn_ver_Click;
            // 
            // bnt_dejarVer
            // 
            bnt_dejarVer.Image = (Image)resources.GetObject("bnt_dejarVer.Image");
            bnt_dejarVer.Location = new Point(908, 214);
            bnt_dejarVer.Margin = new Padding(3, 4, 3, 4);
            bnt_dejarVer.Name = "bnt_dejarVer";
            bnt_dejarVer.Size = new Size(35, 41);
            bnt_dejarVer.SizeMode = PictureBoxSizeMode.Zoom;
            bnt_dejarVer.TabIndex = 10;
            bnt_dejarVer.TabStop = false;
            bnt_dejarVer.Click += bnt_dejarVer_Click;
            // 
            // label_error
            // 
            label_error.AutoSize = true;
            label_error.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_error.ForeColor = Color.FromArgb(45, 150, 255);
            label_error.Location = new Point(473, 278);
            label_error.Name = "label_error";
            label_error.Size = new Size(123, 21);
            label_error.TabIndex = 11;
            label_error.Text = "Mensaje error";
            // 
            // pictureBox_error
            // 
            pictureBox_error.Image = (Image)resources.GetObject("pictureBox_error.Image");
            pictureBox_error.Location = new Point(429, 267);
            pictureBox_error.Margin = new Padding(3, 4, 3, 4);
            pictureBox_error.Name = "pictureBox_error";
            pictureBox_error.Size = new Size(37, 41);
            pictureBox_error.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_error.TabIndex = 12;
            pictureBox_error.TabStop = false;
            // 
            // Form_inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 40, 81);
            ClientSize = new Size(1051, 546);
            Controls.Add(pictureBox_error);
            Controls.Add(label_error);
            Controls.Add(bnt_dejarVer);
            Controls.Add(btn_ver);
            Controls.Add(btn_minimizar);
            Controls.Add(btn_cerrar);
            Controls.Add(lbl_contra);
            Controls.Add(btn_acceder);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(txt_contra);
            Controls.Add(txt_usuario);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_inicio";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_inicio";
            Load += Form_inicio_Load;
            MouseDown += Form_inicio_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_ver).EndInit();
            ((System.ComponentModel.ISupportInitialize)bnt_dejarVer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_error).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txt_usuario;
        private TextBox txt_contra;
        private Panel panel3;
        private Label label1;
        private Button btn_acceder;
        private LinkLabel lbl_contra;
        private PictureBox btn_cerrar;
        private PictureBox btn_minimizar;
        private PictureBox pictureBox3;
        private PictureBox btn_ver;
        private PictureBox bnt_dejarVer;
        private Label label_error;
        private PictureBox pictureBox_error;
    }
}