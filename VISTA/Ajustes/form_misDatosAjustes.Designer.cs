namespace VISTA
{
    partial class form_misDatosAjustes
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
            btn_cancelar = new Button();
            btn_guardar = new Button();
            panel2 = new Panel();
            listbox_permisos = new ListBox();
            txt_email = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txt_grupo = new TextBox();
            label4 = new Label();
            txt_usuario = new TextBox();
            label3 = new Label();
            txt_apellido = new TextBox();
            label2 = new Label();
            txt_nombre = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom;
            btn_cancelar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancelar.Location = new Point(649, 420);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(132, 43);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Anchor = AnchorStyles.Bottom;
            btn_guardar.BackColor = Color.FromArgb(0, 84, 168);
            btn_guardar.FlatAppearance.BorderSize = 0;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_guardar.Location = new Point(388, 420);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(132, 43);
            btn_guardar.TabIndex = 0;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(btn_cancelar);
            panel2.Controls.Add(listbox_permisos);
            panel2.Controls.Add(btn_guardar);
            panel2.Controls.Add(txt_email);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txt_grupo);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_usuario);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_apellido);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_nombre);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1164, 513);
            panel2.TabIndex = 13;
            // 
            // listbox_permisos
            // 
            listbox_permisos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listbox_permisos.Font = new Font("Century Gothic", 9F);
            listbox_permisos.FormattingEnabled = true;
            listbox_permisos.ItemHeight = 17;
            listbox_permisos.Location = new Point(717, 83);
            listbox_permisos.Name = "listbox_permisos";
            listbox_permisos.Size = new Size(240, 225);
            listbox_permisos.TabIndex = 24;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_email.Font = new Font("Century Gothic", 9F);
            txt_email.Location = new Point(389, 286);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(237, 22);
            txt_email.TabIndex = 23;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F);
            label6.Location = new Point(322, 289);
            label6.Name = "label6";
            label6.Size = new Size(42, 17);
            label6.TabIndex = 22;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F);
            label5.Location = new Point(649, 83);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 20;
            label5.Text = "Permisos:";
            // 
            // txt_grupo
            // 
            txt_grupo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_grupo.Font = new Font("Century Gothic", 9F);
            txt_grupo.Location = new Point(389, 236);
            txt_grupo.Name = "txt_grupo";
            txt_grupo.Size = new Size(183, 22);
            txt_grupo.TabIndex = 19;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F);
            label4.Location = new Point(322, 239);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 18;
            label4.Text = "Grupo:";
            // 
            // txt_usuario
            // 
            txt_usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txt_usuario.Font = new Font("Century Gothic", 9F);
            txt_usuario.Location = new Point(427, 184);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(187, 22);
            txt_usuario.TabIndex = 17;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F);
            label3.Location = new Point(360, 187);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 16;
            label3.Text = "Usuario:";
            // 
            // txt_apellido
            // 
            txt_apellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_apellido.Font = new Font("Century Gothic", 9F);
            txt_apellido.Location = new Point(389, 133);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(210, 22);
            txt_apellido.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F);
            label2.Location = new Point(322, 136);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 14;
            label2.Text = "Apellido:";
            // 
            // txt_nombre
            // 
            txt_nombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_nombre.Font = new Font("Century Gothic", 9F);
            txt_nombre.Location = new Point(389, 83);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(210, 22);
            txt_nombre.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F);
            label1.Location = new Point(322, 86);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 12;
            label1.Text = "Nombre:";
            // 
            // form_misDatosAjustes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 513);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_misDatosAjustes";
            Text = "form_misDatosAjustes";
            Load += form_misDatosAjustes_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private ListBox listbox_permisos;
        private TextBox txt_email;
        private Label label6;
        private Label label5;
        private TextBox txt_grupo;
        private Label label4;
        private TextBox txt_usuario;
        private Label label3;
        private TextBox txt_apellido;
        private Label label2;
        private TextBox txt_nombre;
        private Label label1;
        private Button btn_cancelar;
        private Button btn_guardar;
    }
}