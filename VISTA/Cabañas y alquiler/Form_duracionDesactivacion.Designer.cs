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
            numericUpDown_dias = new NumericUpDown();
            label1 = new Label();
            btn_guardar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_dias).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown_dias
            // 
            numericUpDown_dias.Location = new Point(81, 104);
            numericUpDown_dias.Name = "numericUpDown_dias";
            numericUpDown_dias.Size = new Size(137, 23);
            numericUpDown_dias.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(276, 17);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el numero de dias de la desactivación";
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(101, 190);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(101, 38);
            btn_guardar.TabIndex = 2;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // Form_duracionDesactivacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 250);
            Controls.Add(btn_guardar);
            Controls.Add(label1);
            Controls.Add(numericUpDown_dias);
            Name = "Form_duracionDesactivacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Duracion de desactivación";
            Load += Form_duracionDesactivacion_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_dias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown_dias;
        private Label label1;
        private Button btn_guardar;
    }
}