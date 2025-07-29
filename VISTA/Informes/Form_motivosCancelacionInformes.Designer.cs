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
            panel_grafico = new Panel();
            panel_datos = new Panel();
            SuspendLayout();
            // 
            // panel_grafico
            // 
            panel_grafico.Dock = DockStyle.Right;
            panel_grafico.Location = new Point(688, 0);
            panel_grafico.Name = "panel_grafico";
            panel_grafico.Size = new Size(476, 665);
            panel_grafico.TabIndex = 0;
            // 
            // panel_datos
            // 
            panel_datos.Dock = DockStyle.Fill;
            panel_datos.Location = new Point(0, 0);
            panel_datos.Name = "panel_datos";
            panel_datos.Size = new Size(688, 665);
            panel_datos.TabIndex = 1;
            // 
            // Form_motivosCancelacionInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 665);
            Controls.Add(panel_datos);
            Controls.Add(panel_grafico);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_motivosCancelacionInformes";
            Text = "Form_motivosCancelacion";
            Load += Form_motivosCancelacionInformes_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_grafico;
        private Panel panel_datos;
    }
}