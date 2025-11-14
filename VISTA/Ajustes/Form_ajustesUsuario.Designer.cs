namespace VISTA
{
    partial class Form_ajustesUsuario
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
            panel_botones = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            btn_cambiarContra = new Button();
            btn_datos = new Button();
            panel1 = new Panel();
            btn_cerrar = new Button();
            panel_forms = new Panel();
            panel_botones.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_botones
            // 
            panel_botones.BackColor = Color.Gray;
            panel_botones.BorderStyle = BorderStyle.FixedSingle;
            panel_botones.Controls.Add(panel3);
            panel_botones.Controls.Add(panel2);
            panel_botones.Controls.Add(btn_cambiarContra);
            panel_botones.Controls.Add(btn_datos);
            panel_botones.Dock = DockStyle.Top;
            panel_botones.Location = new Point(0, 0);
            panel_botones.Name = "panel_botones";
            panel_botones.Size = new Size(1318, 101);
            panel_botones.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1105, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(211, 99);
            panel3.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 99);
            panel2.TabIndex = 6;
            // 
            // btn_cambiarContra
            // 
            btn_cambiarContra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_cambiarContra.BackColor = Color.FromArgb(0, 84, 168);
            btn_cambiarContra.FlatAppearance.BorderSize = 0;
            btn_cambiarContra.FlatStyle = FlatStyle.Flat;
            btn_cambiarContra.Font = new Font("Century Gothic", 9F);
            btn_cambiarContra.ForeColor = Color.White;
            btn_cambiarContra.Location = new Point(959, 32);
            btn_cambiarContra.Name = "btn_cambiarContra";
            btn_cambiarContra.Size = new Size(142, 37);
            btn_cambiarContra.TabIndex = 5;
            btn_cambiarContra.Text = "Cambiar contraseña";
            btn_cambiarContra.UseVisualStyleBackColor = false;
            btn_cambiarContra.Click += btn_cambiarContra_Click;
            // 
            // btn_datos
            // 
            btn_datos.BackColor = Color.FromArgb(0, 84, 168);
            btn_datos.FlatAppearance.BorderSize = 0;
            btn_datos.FlatStyle = FlatStyle.Flat;
            btn_datos.Font = new Font("Century Gothic", 9F);
            btn_datos.ForeColor = Color.White;
            btn_datos.Location = new Point(217, 32);
            btn_datos.Name = "btn_datos";
            btn_datos.Size = new Size(142, 37);
            btn_datos.TabIndex = 4;
            btn_datos.Text = "Mis datos";
            btn_datos.UseVisualStyleBackColor = false;
            btn_datos.Click += btn_datos_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_cerrar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 897);
            panel1.Name = "panel1";
            panel1.Size = new Size(1318, 51);
            panel1.TabIndex = 1;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cerrar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Font = new Font("Century Gothic", 9F);
            btn_cerrar.ForeColor = Color.White;
            btn_cerrar.Location = new Point(1211, 23);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(102, 23);
            btn_cerrar.TabIndex = 1;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click_1;
            // 
            // panel_forms
            // 
            panel_forms.Dock = DockStyle.Fill;
            panel_forms.Location = new Point(0, 101);
            panel_forms.Name = "panel_forms";
            panel_forms.Size = new Size(1318, 796);
            panel_forms.TabIndex = 2;
            // 
            // Form_ajustesUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1318, 948);
            Controls.Add(panel_forms);
            Controls.Add(panel1);
            Controls.Add(panel_botones);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_ajustesUsuario";
            Text = "Form_ajustesUsuario";
            Load += Form_ajustesUsuario_Load;
            panel_botones.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_botones;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button btn_cambiarContra;
        private Button btn_datos;
        private Button btn_cerrar;
        private Panel panel_forms;
    }
}