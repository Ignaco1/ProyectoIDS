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
            checkedListBox_motivos = new CheckedListBox();
            btn_guardar = new Button();
            SuspendLayout();
            // 
            // checkedListBox_motivos
            // 
            checkedListBox_motivos.FormattingEnabled = true;
            checkedListBox_motivos.Location = new Point(69, 12);
            checkedListBox_motivos.Name = "checkedListBox_motivos";
            checkedListBox_motivos.Size = new Size(204, 94);
            checkedListBox_motivos.TabIndex = 0;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(116, 366);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(100, 35);
            btn_guardar.TabIndex = 2;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Form_seleccionarMotivosCancelacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 425);
            Controls.Add(btn_guardar);
            Controls.Add(checkedListBox_motivos);
            Name = "Form_seleccionarMotivosCancelacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleccion de motivos de cancelacion";
            Load += Form_seleccionarMotivosCancelacion_Load;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBox_motivos;
        private Button btn_guardar;
    }
}