namespace VISTA.Cabañas_y_alquiler
{
    partial class Form_desplegarMantenimientos
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
            txt_nombreORubroFiltro = new TextBox();
            label1 = new Label();
            btn_quitarFiltro = new Button();
            panel2 = new Panel();
            btn_cerrar = new Button();
            panel3 = new Panel();
            flp_mantenimientos = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_nombreORubroFiltro);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_quitarFiltro);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1820, 93);
            panel1.TabIndex = 0;
            // 
            // txt_nombreORubroFiltro
            // 
            txt_nombreORubroFiltro.Location = new Point(809, 39);
            txt_nombreORubroFiltro.Name = "txt_nombreORubroFiltro";
            txt_nombreORubroFiltro.Size = new Size(349, 26);
            txt_nombreORubroFiltro.TabIndex = 45;
            txt_nombreORubroFiltro.TextChanged += txt_nombreFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(594, 42);
            label1.Name = "label1";
            label1.Size = new Size(209, 20);
            label1.TabIndex = 40;
            label1.Text = "Nombre rubro relacionado:";
            // 
            // btn_quitarFiltro
            // 
            btn_quitarFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_quitarFiltro.BackColor = Color.FromArgb(0, 84, 168);
            btn_quitarFiltro.FlatAppearance.BorderSize = 0;
            btn_quitarFiltro.FlatStyle = FlatStyle.Flat;
            btn_quitarFiltro.Location = new Point(1637, 39);
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
            panel3.Controls.Add(flp_mantenimientos);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(1820, 1182);
            panel3.TabIndex = 2;
            // 
            // flp_mantenimientos
            // 
            flp_mantenimientos.AutoScroll = true;
            flp_mantenimientos.Dock = DockStyle.Fill;
            flp_mantenimientos.Location = new Point(0, 0);
            flp_mantenimientos.Name = "flp_mantenimientos";
            flp_mantenimientos.Size = new Size(1820, 1182);
            flp_mantenimientos.TabIndex = 0;
            // 
            // Form_desplegarMantenimientos
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
            Name = "Form_desplegarMantenimientos";
            Text = "Form_desplegarMantenimientos";
            Load += Form_desplegarMantenimientos_Load;
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
        private TextBox txt_nombreORubroFiltro;
        private Label label1;
        private Button btn_cerrar;
        private FlowLayoutPanel flp_mantenimientos;
    }
}