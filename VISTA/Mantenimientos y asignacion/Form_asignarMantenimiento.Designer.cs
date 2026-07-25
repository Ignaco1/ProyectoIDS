namespace VISTA.Cabañas_y_alquiler
{
    partial class Form_asignarMantenimiento
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
            panel_butones = new Panel();
            panel3 = new Panel();
            btn_cancelar = new Button();
            btn_asignarMantenimiento = new Button();
            panel_picture = new Panel();
            lb_descripcion = new Label();
            lb3 = new Label();
            btn_anterior = new Button();
            btn_siguiente = new Button();
            pb_imagenes = new PictureBox();
            panel8 = new Panel();
            label = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel9 = new Panel();
            label3 = new Label();
            lb_fecha_fin = new Label();
            mc_fechas = new MonthCalendar();
            panel10 = new Panel();
            label7 = new Label();
            lb_fecha_inicio = new Label();
            panel7 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            panel18 = new Panel();
            panel17 = new Panel();
            txt_importe = new TextBox();
            panel15 = new Panel();
            label5 = new Label();
            label10 = new Label();
            panel16 = new Panel();
            label9 = new Label();
            radioButton_no = new RadioButton();
            label12 = new Label();
            radioButton_si = new RadioButton();
            label6 = new Label();
            panel13 = new Panel();
            panel14 = new Panel();
            label8 = new Label();
            label_empleado = new Label();
            label_cabaña = new Label();
            btn_seleccionarEmpleado = new Button();
            btn_seleccionarCabaña = new Button();
            panel12 = new Panel();
            panel11 = new Panel();
            label4 = new Label();
            panel6 = new Panel();
            label2 = new Label();
            lb_nombre = new Label();
            panel_butones.SuspendLayout();
            panel_picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_imagenes).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel_butones
            // 
            panel_butones.Controls.Add(panel3);
            panel_butones.Controls.Add(btn_cancelar);
            panel_butones.Controls.Add(btn_asignarMantenimiento);
            panel_butones.Dock = DockStyle.Bottom;
            panel_butones.Location = new Point(0, 1235);
            panel_butones.Margin = new Padding(2);
            panel_butones.Name = "panel_butones";
            panel_butones.Size = new Size(1820, 98);
            panel_butones.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Enabled = false;
            panel3.Location = new Point(3, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1840, 2);
            panel3.TabIndex = 34;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Bottom;
            btn_cancelar.BackColor = Color.FromArgb(0, 84, 168);
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.Location = new Point(1028, 27);
            btn_cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(257, 58);
            btn_cancelar.TabIndex = 27;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_asignarMantenimiento
            // 
            btn_asignarMantenimiento.Anchor = AnchorStyles.Bottom;
            btn_asignarMantenimiento.BackColor = Color.FromArgb(0, 84, 168);
            btn_asignarMantenimiento.FlatAppearance.BorderSize = 0;
            btn_asignarMantenimiento.FlatStyle = FlatStyle.Flat;
            btn_asignarMantenimiento.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_asignarMantenimiento.ForeColor = Color.White;
            btn_asignarMantenimiento.Location = new Point(564, 27);
            btn_asignarMantenimiento.Margin = new Padding(3, 4, 3, 4);
            btn_asignarMantenimiento.Name = "btn_asignarMantenimiento";
            btn_asignarMantenimiento.Size = new Size(257, 58);
            btn_asignarMantenimiento.TabIndex = 26;
            btn_asignarMantenimiento.Text = "Asignar mantenimiento";
            btn_asignarMantenimiento.UseVisualStyleBackColor = false;
            btn_asignarMantenimiento.Click += btn_asignarMantenimiento_Click;
            // 
            // panel_picture
            // 
            panel_picture.Controls.Add(lb_nombre);
            panel_picture.Controls.Add(lb_descripcion);
            panel_picture.Controls.Add(lb3);
            panel_picture.Controls.Add(btn_anterior);
            panel_picture.Controls.Add(btn_siguiente);
            panel_picture.Controls.Add(pb_imagenes);
            panel_picture.Controls.Add(panel8);
            panel_picture.Controls.Add(label);
            panel_picture.Controls.Add(panel1);
            panel_picture.Dock = DockStyle.Left;
            panel_picture.Location = new Point(0, 0);
            panel_picture.Margin = new Padding(2);
            panel_picture.Name = "panel_picture";
            panel_picture.Size = new Size(781, 1235);
            panel_picture.TabIndex = 2;
            // 
            // lb_descripcion
            // 
            lb_descripcion.Anchor = AnchorStyles.Left;
            lb_descripcion.AutoSize = true;
            lb_descripcion.Font = new Font("Century Gothic", 12F);
            lb_descripcion.ForeColor = Color.White;
            lb_descripcion.Location = new Point(170, 823);
            lb_descripcion.Name = "lb_descripcion";
            lb_descripcion.Size = new Size(15, 23);
            lb_descripcion.TabIndex = 46;
            lb_descripcion.Text = "l";
            // 
            // lb3
            // 
            lb3.Anchor = AnchorStyles.Left;
            lb3.AutoSize = true;
            lb3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lb3.ForeColor = Color.White;
            lb3.Location = new Point(36, 823);
            lb3.Name = "lb3";
            lb3.Size = new Size(132, 23);
            lb3.TabIndex = 43;
            lb3.Text = "Descripcion:";
            // 
            // btn_anterior
            // 
            btn_anterior.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btn_anterior.BackColor = Color.Transparent;
            btn_anterior.FlatAppearance.BorderSize = 0;
            btn_anterior.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_anterior.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_anterior.FlatStyle = FlatStyle.Flat;
            btn_anterior.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_anterior.ForeColor = Color.White;
            btn_anterior.Location = new Point(70, 179);
            btn_anterior.Margin = new Padding(3, 4, 3, 4);
            btn_anterior.Name = "btn_anterior";
            btn_anterior.Size = new Size(31, 543);
            btn_anterior.TabIndex = 39;
            btn_anterior.TabStop = false;
            btn_anterior.Text = "<";
            btn_anterior.UseVisualStyleBackColor = false;
            btn_anterior.Click += btn_anterior_Click;
            // 
            // btn_siguiente
            // 
            btn_siguiente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btn_siguiente.BackColor = Color.Transparent;
            btn_siguiente.FlatAppearance.BorderSize = 0;
            btn_siguiente.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_siguiente.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_siguiente.FlatStyle = FlatStyle.Flat;
            btn_siguiente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_siguiente.ForeColor = Color.White;
            btn_siguiente.Location = new Point(655, 179);
            btn_siguiente.Margin = new Padding(3, 4, 3, 4);
            btn_siguiente.Name = "btn_siguiente";
            btn_siguiente.Size = new Size(31, 543);
            btn_siguiente.TabIndex = 38;
            btn_siguiente.TabStop = false;
            btn_siguiente.Text = ">";
            btn_siguiente.UseVisualStyleBackColor = false;
            btn_siguiente.Click += btn_siguiente_Click;
            // 
            // pb_imagenes
            // 
            pb_imagenes.Anchor = AnchorStyles.Left;
            pb_imagenes.Location = new Point(100, 213);
            pb_imagenes.Margin = new Padding(3, 4, 3, 4);
            pb_imagenes.Name = "pb_imagenes";
            pb_imagenes.Size = new Size(557, 474);
            pb_imagenes.SizeMode = PictureBoxSizeMode.Zoom;
            pb_imagenes.TabIndex = 37;
            pb_imagenes.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Silver;
            panel8.Enabled = false;
            panel8.Location = new Point(3, 42);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(770, 2);
            panel8.TabIndex = 36;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(256, 6);
            label.Name = "label";
            label.Size = new Size(208, 32);
            label.TabIndex = 35;
            label.Text = "Mantenimiento";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Enabled = false;
            panel1.Location = new Point(771, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 1235);
            panel1.TabIndex = 34;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lb_fecha_fin);
            panel2.Controls.Add(mc_fechas);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lb_fecha_inicio);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(781, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1039, 428);
            panel2.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Enabled = false;
            panel9.Font = new Font("Century Gothic", 13.8F);
            panel9.Location = new Point(575, 398);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(120, 2);
            panel9.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(575, 373);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 27);
            label3.TabIndex = 50;
            label3.Text = "Fecha Fin:";
            // 
            // lb_fecha_fin
            // 
            lb_fecha_fin.AutoSize = true;
            lb_fecha_fin.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_fecha_fin.ForeColor = Color.White;
            lb_fecha_fin.Location = new Point(705, 372);
            lb_fecha_fin.Name = "lb_fecha_fin";
            lb_fecha_fin.Size = new Size(182, 27);
            lb_fecha_fin.TabIndex = 49;
            lb_fecha_fin.Text = "Sin seleccionar";
            // 
            // mc_fechas
            // 
            mc_fechas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mc_fechas.Location = new Point(396, 103);
            mc_fechas.Margin = new Padding(10, 12, 10, 12);
            mc_fechas.MaxSelectionCount = 30;
            mc_fechas.Name = "mc_fechas";
            mc_fechas.TabIndex = 48;
            mc_fechas.DateChanged += mc_fechas_DateChanged;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Enabled = false;
            panel10.Font = new Font("Century Gothic", 13.8F);
            panel10.Location = new Point(188, 398);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(150, 2);
            panel10.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(188, 373);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(156, 27);
            label7.TabIndex = 46;
            label7.Text = "Fecha Inicio:";
            // 
            // lb_fecha_inicio
            // 
            lb_fecha_inicio.AutoSize = true;
            lb_fecha_inicio.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_fecha_inicio.ForeColor = Color.White;
            lb_fecha_inicio.Location = new Point(349, 373);
            lb_fecha_inicio.Name = "lb_fecha_inicio";
            lb_fecha_inicio.Size = new Size(182, 27);
            lb_fecha_inicio.TabIndex = 43;
            lb_fecha_inicio.Text = "Sin seleccionar";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Silver;
            panel7.Enabled = false;
            panel7.Location = new Point(1, 42);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(1200, 2);
            panel7.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(474, 6);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 36;
            label1.Text = "Duración";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Enabled = false;
            panel4.Location = new Point(0, 773);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1200, 2);
            panel4.TabIndex = 34;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel18);
            panel5.Controls.Add(panel17);
            panel5.Controls.Add(txt_importe);
            panel5.Controls.Add(panel15);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(panel16);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(radioButton_no);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(radioButton_si);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(panel13);
            panel5.Controls.Add(panel14);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label_empleado);
            panel5.Controls.Add(label_cabaña);
            panel5.Controls.Add(btn_seleccionarEmpleado);
            panel5.Controls.Add(btn_seleccionarCabaña);
            panel5.Controls.Add(panel12);
            panel5.Controls.Add(panel11);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(781, 428);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1039, 807);
            panel5.TabIndex = 4;
            // 
            // panel18
            // 
            panel18.BackColor = Color.Black;
            panel18.Enabled = false;
            panel18.Location = new Point(0, 0);
            panel18.Margin = new Padding(3, 4, 3, 4);
            panel18.Name = "panel18";
            panel18.Size = new Size(1200, 2);
            panel18.TabIndex = 55;
            // 
            // panel17
            // 
            panel17.BackColor = Color.Black;
            panel17.Enabled = false;
            panel17.Location = new Point(-8, 193);
            panel17.Margin = new Padding(3, 4, 3, 4);
            panel17.Name = "panel17";
            panel17.Size = new Size(1208, 2);
            panel17.TabIndex = 55;
            // 
            // txt_importe
            // 
            txt_importe.Location = new Point(379, 542);
            txt_importe.Name = "txt_importe";
            txt_importe.Size = new Size(304, 27);
            txt_importe.TabIndex = 54;
            txt_importe.Text = "$ ";
            // 
            // panel15
            // 
            panel15.BackColor = Color.Silver;
            panel15.Enabled = false;
            panel15.Location = new Point(1, -2);
            panel15.Margin = new Padding(3, 4, 3, 4);
            panel15.Name = "panel15";
            panel15.Size = new Size(1200, 2);
            panel15.TabIndex = 55;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 542);
            label5.Name = "label5";
            label5.Size = new Size(331, 27);
            label5.TabIndex = 53;
            label5.Text = "Importe del mantenimiento:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(568, 715);
            label10.Name = "label10";
            label10.Size = new Size(29, 27);
            label10.TabIndex = 52;
            label10.Text = "SI";
            // 
            // panel16
            // 
            panel16.BackColor = Color.Black;
            panel16.Enabled = false;
            panel16.Location = new Point(-7, 40);
            panel16.Margin = new Padding(3, 4, 3, 4);
            panel16.Name = "panel16";
            panel16.Size = new Size(1208, 2);
            panel16.TabIndex = 54;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(688, 715);
            label9.Name = "label9";
            label9.Size = new Size(49, 27);
            label9.TabIndex = 51;
            label9.Text = "NO";
            // 
            // radioButton_no
            // 
            radioButton_no.AutoSize = true;
            radioButton_no.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton_no.Location = new Point(705, 745);
            radioButton_no.Name = "radioButton_no";
            radioButton_no.Size = new Size(17, 16);
            radioButton_no.TabIndex = 50;
            radioButton_no.TabStop = true;
            radioButton_no.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(474, 4);
            label12.Name = "label12";
            label12.Size = new Size(123, 32);
            label12.TabIndex = 53;
            label12.Text = "Cabaña";
            // 
            // radioButton_si
            // 
            radioButton_si.AutoSize = true;
            radioButton_si.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton_si.Location = new Point(574, 745);
            radioButton_si.Name = "radioButton_si";
            radioButton_si.Size = new Size(17, 16);
            radioButton_si.TabIndex = 49;
            radioButton_si.TabStop = true;
            radioButton_si.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 728);
            label6.Name = "label6";
            label6.Size = new Size(466, 27);
            label6.TabIndex = 48;
            label6.Text = "Desactivar cabaña por mantenimeinto:";
            // 
            // panel13
            // 
            panel13.BackColor = Color.Black;
            panel13.Enabled = false;
            panel13.Location = new Point(0, 634);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Size = new Size(1200, 2);
            panel13.TabIndex = 46;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Black;
            panel14.Enabled = false;
            panel14.Location = new Point(1, 676);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Size = new Size(1200, 2);
            panel14.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(445, 640);
            label8.Name = "label8";
            label8.Size = new Size(200, 32);
            label8.TabIndex = 44;
            label8.Text = "Desactivación";
            // 
            // label_empleado
            // 
            label_empleado.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_empleado.AutoSize = true;
            label_empleado.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_empleado.ForeColor = Color.White;
            label_empleado.Location = new Point(217, 351);
            label_empleado.Name = "label_empleado";
            label_empleado.Size = new Size(328, 27);
            label_empleado.TabIndex = 43;
            label_empleado.Text = "Empleado no seleccionado";
            // 
            // label_cabaña
            // 
            label_cabaña.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_cabaña.AutoSize = true;
            label_cabaña.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_cabaña.ForeColor = Color.White;
            label_cabaña.Location = new Point(217, 130);
            label_cabaña.Name = "label_cabaña";
            label_cabaña.Size = new Size(308, 27);
            label_cabaña.TabIndex = 38;
            label_cabaña.Text = "Cabaña no seleccionada";
            // 
            // btn_seleccionarEmpleado
            // 
            btn_seleccionarEmpleado.BackColor = Color.FromArgb(0, 84, 168);
            btn_seleccionarEmpleado.FlatAppearance.BorderSize = 0;
            btn_seleccionarEmpleado.FlatStyle = FlatStyle.Flat;
            btn_seleccionarEmpleado.Font = new Font("Century Gothic", 9F);
            btn_seleccionarEmpleado.ForeColor = Color.White;
            btn_seleccionarEmpleado.Location = new Point(20, 286);
            btn_seleccionarEmpleado.Margin = new Padding(3, 4, 3, 4);
            btn_seleccionarEmpleado.Name = "btn_seleccionarEmpleado";
            btn_seleccionarEmpleado.Size = new Size(159, 27);
            btn_seleccionarEmpleado.TabIndex = 42;
            btn_seleccionarEmpleado.Text = "Seleccionar empleado";
            btn_seleccionarEmpleado.UseVisualStyleBackColor = false;
            btn_seleccionarEmpleado.Click += btn_seleccionarEmpleado_Click;
            // 
            // btn_seleccionarCabaña
            // 
            btn_seleccionarCabaña.BackColor = Color.FromArgb(0, 84, 168);
            btn_seleccionarCabaña.FlatAppearance.BorderSize = 0;
            btn_seleccionarCabaña.FlatStyle = FlatStyle.Flat;
            btn_seleccionarCabaña.Font = new Font("Century Gothic", 9F);
            btn_seleccionarCabaña.ForeColor = Color.White;
            btn_seleccionarCabaña.Location = new Point(20, 79);
            btn_seleccionarCabaña.Margin = new Padding(3, 4, 3, 4);
            btn_seleccionarCabaña.Name = "btn_seleccionarCabaña";
            btn_seleccionarCabaña.Size = new Size(159, 27);
            btn_seleccionarCabaña.TabIndex = 33;
            btn_seleccionarCabaña.Text = "Seleccionar cabaña";
            btn_seleccionarCabaña.UseVisualStyleBackColor = false;
            btn_seleccionarCabaña.Click += btn_seleccionarCabaña_Click;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Black;
            panel12.Enabled = false;
            panel12.Location = new Point(0, 429);
            panel12.Margin = new Padding(3, 4, 3, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(1200, 2);
            panel12.TabIndex = 41;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Black;
            panel11.Enabled = false;
            panel11.Location = new Point(0, 471);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(1200, 2);
            panel11.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(481, 435);
            label4.Name = "label4";
            label4.Size = new Size(116, 32);
            label4.TabIndex = 39;
            label4.Text = "Importe";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Enabled = false;
            panel6.Location = new Point(-8, 243);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(1209, 2);
            panel6.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(459, 207);
            label2.Name = "label2";
            label2.Size = new Size(147, 32);
            label2.TabIndex = 36;
            label2.Text = "Empleado";
            // 
            // lb_nombre
            // 
            lb_nombre.AutoSize = true;
            lb_nombre.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nombre.ForeColor = Color.White;
            lb_nombre.Location = new Point(256, 138);
            lb_nombre.Name = "lb_nombre";
            lb_nombre.Size = new Size(104, 27);
            lb_nombre.TabIndex = 42;
            lb_nombre.Text = "Nombre";
            lb_nombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_asignarMantenimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1820, 1333);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel_picture);
            Controls.Add(panel_butones);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Form_asignarMantenimiento";
            Text = "Form_asignarMantenimiento";
            Load += Form_asignarMantenimiento_Load;
            panel_butones.ResumeLayout(false);
            panel_picture.ResumeLayout(false);
            panel_picture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_imagenes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_asignarMantenimiento;
        private Button btn_cancelar;
        private Panel panel3;
        private Panel panel4;
        private Panel panel_butones;
        private Panel panel_picture;
        private Panel panel5;
        private Button btn_seleccionarCabaña;
        private Label label;
        private Label label1;
        private Label label2;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private PictureBox pb_imagenes;
        private Button btn_siguiente;
        private Button btn_anterior;
        private Label lb3;
        private Label label_cabaña;
        private Label lb_descripcion;
        private Label lb_fecha_inicio;
        private Panel panel10;
        private Label label7;
        private Panel panel12;
        private Panel panel11;
        private Label label4;
        private Label label6;
        private Panel panel13;
        private Panel panel14;
        private Label label8;
        private Label label_empleado;
        private Button btn_seleccionarEmpleado;
        private Label label9;
        private RadioButton radioButton_no;
        private RadioButton radioButton_si;
        private Label label10;
        private MonthCalendar mc_fechas;
        private Panel panel9;
        private Label label3;
        private Label lb_fecha_fin;
        private Panel panel15;
        private Panel panel16;
        private Label label12;
        private Label label5;
        private Panel panel17;
        private TextBox txt_importe;
        private Panel panel18;
        private Label lb_nombre;
    }
}
