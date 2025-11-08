namespace VISTA
{
    partial class Form_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_principal));
            panel1 = new Panel();
            label1 = new Label();
            btn_restaurar = new PictureBox();
            btn_maximizar = new PictureBox();
            btn_minimizar = new PictureBox();
            btn_cerrar = new PictureBox();
            pictureBox2 = new PictureBox();
            panel_menuLateral = new Panel();
            panel_informes = new Panel();
            button14 = new Button();
            btn_motivosCancelacion = new Button();
            btn_informes = new Button();
            panel_mantenimientos = new Panel();
            button11 = new Button();
            button12 = new Button();
            btn_mantenimientos = new Button();
            panel_servicios = new Panel();
            button8 = new Button();
            button9 = new Button();
            btn_servicios = new Button();
            panel_reservas = new Panel();
            button6 = new Button();
            btn_realizar_alquilar = new Button();
            btn_cabañas_alquiler = new Button();
            label3 = new Label();
            label2 = new Label();
            btn_cerrarSesion = new PictureBox();
            btn_ajustes = new PictureBox();
            panel_ABM = new Panel();
            button1 = new Button();
            button2 = new Button();
            btn_empleados_abm = new Button();
            btn_ABM_cabañas = new Button();
            btn_ABM_clientes = new Button();
            btn_ABM_usuarios = new Button();
            btn_ABM = new Button();
            panel_seguridad = new Panel();
            btn_asignarPermisos = new Button();
            btn_gestionar_grupos = new Button();
            btn_gestionar_permisos = new Button();
            btn_seguridad = new Button();
            panel_logo = new Panel();
            lbl_usuario = new Label();
            lb_nombre = new Label();
            lb_email = new Label();
            lb_grupo = new Label();
            pictureBox1 = new PictureBox();
            panel_forms = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_restaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_maximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_menuLateral.SuspendLayout();
            panel_informes.SuspendLayout();
            panel_mantenimientos.SuspendLayout();
            panel_servicios.SuspendLayout();
            panel_reservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_cerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_ajustes).BeginInit();
            panel_ABM.SuspendLayout();
            panel_seguridad.SuspendLayout();
            panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_forms.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 86, 172);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_restaurar);
            panel1.Controls.Add(btn_maximizar);
            panel1.Controls.Add(btn_minimizar);
            panel1.Controls.Add(btn_cerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1639, 37);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 12;
            label1.Text = "Menu Principal";
            // 
            // btn_restaurar
            // 
            btn_restaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_restaurar.Image = (Image)resources.GetObject("btn_restaurar.Image");
            btn_restaurar.Location = new Point(1570, 4);
            btn_restaurar.Name = "btn_restaurar";
            btn_restaurar.Size = new Size(30, 30);
            btn_restaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_restaurar.TabIndex = 11;
            btn_restaurar.TabStop = false;
            btn_restaurar.Click += btn_restaurar_Click;
            // 
            // btn_maximizar
            // 
            btn_maximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_maximizar.Image = (Image)resources.GetObject("btn_maximizar.Image");
            btn_maximizar.Location = new Point(1570, 4);
            btn_maximizar.Name = "btn_maximizar";
            btn_maximizar.Size = new Size(30, 30);
            btn_maximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_maximizar.TabIndex = 10;
            btn_maximizar.TabStop = false;
            btn_maximizar.Click += btn_maximizar_Click;
            // 
            // btn_minimizar
            // 
            btn_minimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_minimizar.Image = (Image)resources.GetObject("btn_minimizar.Image");
            btn_minimizar.Location = new Point(1534, 3);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(30, 30);
            btn_minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar.TabIndex = 9;
            btn_minimizar.TabStop = false;
            btn_minimizar.Click += btn_minimizar_Click_1;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_cerrar.Image = (Image)resources.GetObject("btn_cerrar.Image");
            btn_cerrar.Location = new Point(1606, 3);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(30, 30);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 8;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(762, 329);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(363, 262);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.MouseDown += pictureBox2_MouseDown;
            // 
            // panel_menuLateral
            // 
            panel_menuLateral.AutoScroll = true;
            panel_menuLateral.BackColor = Color.FromArgb(0, 40, 81);
            panel_menuLateral.Controls.Add(panel_informes);
            panel_menuLateral.Controls.Add(btn_informes);
            panel_menuLateral.Controls.Add(panel_mantenimientos);
            panel_menuLateral.Controls.Add(btn_mantenimientos);
            panel_menuLateral.Controls.Add(panel_servicios);
            panel_menuLateral.Controls.Add(btn_servicios);
            panel_menuLateral.Controls.Add(panel_reservas);
            panel_menuLateral.Controls.Add(btn_cabañas_alquiler);
            panel_menuLateral.Controls.Add(label3);
            panel_menuLateral.Controls.Add(label2);
            panel_menuLateral.Controls.Add(btn_cerrarSesion);
            panel_menuLateral.Controls.Add(btn_ajustes);
            panel_menuLateral.Controls.Add(panel_ABM);
            panel_menuLateral.Controls.Add(btn_ABM);
            panel_menuLateral.Controls.Add(panel_seguridad);
            panel_menuLateral.Controls.Add(btn_seguridad);
            panel_menuLateral.Controls.Add(panel_logo);
            panel_menuLateral.Dock = DockStyle.Left;
            panel_menuLateral.Location = new Point(0, 0);
            panel_menuLateral.Name = "panel_menuLateral";
            panel_menuLateral.Size = new Size(321, 948);
            panel_menuLateral.TabIndex = 1;
            panel_menuLateral.MouseDown += panel_menuLateral_MouseDown_1;
            // 
            // panel_informes
            // 
            panel_informes.BackColor = Color.FromArgb(40, 40, 40);
            panel_informes.Controls.Add(button14);
            panel_informes.Controls.Add(btn_motivosCancelacion);
            panel_informes.Dock = DockStyle.Top;
            panel_informes.Location = new Point(0, 774);
            panel_informes.Name = "panel_informes";
            panel_informes.Size = new Size(321, 60);
            panel_informes.TabIndex = 36;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(65, 65, 65);
            button14.Dock = DockStyle.Top;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Century Gothic", 9.75F);
            button14.ForeColor = Color.White;
            button14.Location = new Point(0, 30);
            button14.Name = "button14";
            button14.Padding = new Padding(35, 0, 0, 0);
            button14.Size = new Size(321, 30);
            button14.TabIndex = 12;
            button14.Tag = "Principales servicios";
            button14.Text = "Principales servicios";
            button14.TextAlign = ContentAlignment.MiddleLeft;
            button14.UseVisualStyleBackColor = false;
            // 
            // btn_motivosCancelacion
            // 
            btn_motivosCancelacion.BackColor = Color.FromArgb(65, 65, 65);
            btn_motivosCancelacion.Dock = DockStyle.Top;
            btn_motivosCancelacion.FlatAppearance.BorderSize = 0;
            btn_motivosCancelacion.FlatStyle = FlatStyle.Flat;
            btn_motivosCancelacion.Font = new Font("Century Gothic", 9.75F);
            btn_motivosCancelacion.ForeColor = Color.White;
            btn_motivosCancelacion.Location = new Point(0, 0);
            btn_motivosCancelacion.Name = "btn_motivosCancelacion";
            btn_motivosCancelacion.Padding = new Padding(35, 0, 0, 0);
            btn_motivosCancelacion.Size = new Size(321, 30);
            btn_motivosCancelacion.TabIndex = 11;
            btn_motivosCancelacion.Tag = "Motivos principales de cancelación";
            btn_motivosCancelacion.Text = "Motivos principales de cancelación";
            btn_motivosCancelacion.TextAlign = ContentAlignment.MiddleLeft;
            btn_motivosCancelacion.UseVisualStyleBackColor = false;
            btn_motivosCancelacion.Click += btn_motivosCancelacion_Click;
            // 
            // btn_informes
            // 
            btn_informes.BackColor = Color.FromArgb(0, 40, 81);
            btn_informes.Dock = DockStyle.Top;
            btn_informes.FlatAppearance.BorderSize = 0;
            btn_informes.FlatStyle = FlatStyle.Flat;
            btn_informes.Font = new Font("Century Gothic", 9.75F);
            btn_informes.ForeColor = Color.White;
            btn_informes.Location = new Point(0, 744);
            btn_informes.Name = "btn_informes";
            btn_informes.Padding = new Padding(10, 0, 0, 0);
            btn_informes.Size = new Size(321, 30);
            btn_informes.TabIndex = 35;
            btn_informes.Tag = "Informes";
            btn_informes.Text = "Informes";
            btn_informes.TextAlign = ContentAlignment.MiddleLeft;
            btn_informes.UseVisualStyleBackColor = false;
            btn_informes.Click += btn_informes_Click;
            // 
            // panel_mantenimientos
            // 
            panel_mantenimientos.BackColor = Color.FromArgb(40, 40, 40);
            panel_mantenimientos.Controls.Add(button11);
            panel_mantenimientos.Controls.Add(button12);
            panel_mantenimientos.Dock = DockStyle.Top;
            panel_mantenimientos.Location = new Point(0, 684);
            panel_mantenimientos.Name = "panel_mantenimientos";
            panel_mantenimientos.Size = new Size(321, 60);
            panel_mantenimientos.TabIndex = 33;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(65, 65, 65);
            button11.Dock = DockStyle.Top;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Century Gothic", 9.75F);
            button11.ForeColor = Color.White;
            button11.Location = new Point(0, 30);
            button11.Name = "button11";
            button11.Padding = new Padding(35, 0, 0, 0);
            button11.Size = new Size(321, 30);
            button11.TabIndex = 10;
            button11.Tag = "Ver mantenimientos";
            button11.Text = "Ver mantenimientos";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(65, 65, 65);
            button12.Dock = DockStyle.Top;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Century Gothic", 9.75F);
            button12.ForeColor = Color.White;
            button12.Location = new Point(0, 0);
            button12.Name = "button12";
            button12.Padding = new Padding(35, 0, 0, 0);
            button12.Size = new Size(321, 30);
            button12.TabIndex = 9;
            button12.Tag = "Asignar mantenimientos";
            button12.Text = "Asignar mantenimientos";
            button12.TextAlign = ContentAlignment.MiddleLeft;
            button12.UseVisualStyleBackColor = false;
            // 
            // btn_mantenimientos
            // 
            btn_mantenimientos.BackColor = Color.FromArgb(0, 40, 81);
            btn_mantenimientos.Dock = DockStyle.Top;
            btn_mantenimientos.FlatAppearance.BorderSize = 0;
            btn_mantenimientos.FlatStyle = FlatStyle.Flat;
            btn_mantenimientos.Font = new Font("Century Gothic", 9.75F);
            btn_mantenimientos.ForeColor = Color.White;
            btn_mantenimientos.Location = new Point(0, 654);
            btn_mantenimientos.Name = "btn_mantenimientos";
            btn_mantenimientos.Padding = new Padding(10, 0, 0, 0);
            btn_mantenimientos.Size = new Size(321, 30);
            btn_mantenimientos.TabIndex = 32;
            btn_mantenimientos.Tag = "Cabañas y alquiler";
            btn_mantenimientos.Text = "Mantenimientos";
            btn_mantenimientos.TextAlign = ContentAlignment.MiddleLeft;
            btn_mantenimientos.UseVisualStyleBackColor = false;
            btn_mantenimientos.Click += btn_mantenimientos_Click;
            // 
            // panel_servicios
            // 
            panel_servicios.BackColor = Color.FromArgb(40, 40, 40);
            panel_servicios.Controls.Add(button8);
            panel_servicios.Controls.Add(button9);
            panel_servicios.Dock = DockStyle.Top;
            panel_servicios.Location = new Point(0, 594);
            panel_servicios.Name = "panel_servicios";
            panel_servicios.Size = new Size(321, 60);
            panel_servicios.TabIndex = 31;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(65, 65, 65);
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Century Gothic", 9.75F);
            button8.ForeColor = Color.White;
            button8.Location = new Point(0, 30);
            button8.Name = "button8";
            button8.Padding = new Padding(35, 0, 0, 0);
            button8.Size = new Size(321, 30);
            button8.TabIndex = 8;
            button8.Tag = "Ver servicios";
            button8.Text = "Ver servicios";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(65, 65, 65);
            button9.Dock = DockStyle.Top;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Century Gothic", 9.75F);
            button9.ForeColor = Color.White;
            button9.Location = new Point(0, 0);
            button9.Name = "button9";
            button9.Padding = new Padding(35, 0, 0, 0);
            button9.Size = new Size(321, 30);
            button9.TabIndex = 7;
            button9.Tag = "Asignar servicios";
            button9.Text = "Asignar servicios";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            // 
            // btn_servicios
            // 
            btn_servicios.BackColor = Color.FromArgb(0, 40, 81);
            btn_servicios.Dock = DockStyle.Top;
            btn_servicios.FlatAppearance.BorderSize = 0;
            btn_servicios.FlatStyle = FlatStyle.Flat;
            btn_servicios.Font = new Font("Century Gothic", 9.75F);
            btn_servicios.ForeColor = Color.White;
            btn_servicios.Location = new Point(0, 564);
            btn_servicios.Name = "btn_servicios";
            btn_servicios.Padding = new Padding(10, 0, 0, 0);
            btn_servicios.Size = new Size(321, 30);
            btn_servicios.TabIndex = 30;
            btn_servicios.Tag = "Cabañas y alquiler";
            btn_servicios.Text = "Servicios";
            btn_servicios.TextAlign = ContentAlignment.MiddleLeft;
            btn_servicios.UseVisualStyleBackColor = false;
            btn_servicios.Click += btn_servicios_Click;
            // 
            // panel_reservas
            // 
            panel_reservas.BackColor = Color.FromArgb(40, 40, 40);
            panel_reservas.Controls.Add(button6);
            panel_reservas.Controls.Add(btn_realizar_alquilar);
            panel_reservas.Dock = DockStyle.Top;
            panel_reservas.Location = new Point(0, 504);
            panel_reservas.Name = "panel_reservas";
            panel_reservas.Size = new Size(321, 60);
            panel_reservas.TabIndex = 29;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(65, 65, 65);
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 9.75F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(0, 30);
            button6.Name = "button6";
            button6.Padding = new Padding(35, 0, 0, 0);
            button6.Size = new Size(321, 30);
            button6.TabIndex = 6;
            button6.Tag = "Ver reservas";
            button6.Text = "Ver reservas";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += btn_ver_reservas_Click;
            // 
            // btn_realizar_alquilar
            // 
            btn_realizar_alquilar.BackColor = Color.FromArgb(65, 65, 65);
            btn_realizar_alquilar.Dock = DockStyle.Top;
            btn_realizar_alquilar.FlatAppearance.BorderSize = 0;
            btn_realizar_alquilar.FlatStyle = FlatStyle.Flat;
            btn_realizar_alquilar.Font = new Font("Century Gothic", 9.75F);
            btn_realizar_alquilar.ForeColor = Color.White;
            btn_realizar_alquilar.Location = new Point(0, 0);
            btn_realizar_alquilar.Name = "btn_realizar_alquilar";
            btn_realizar_alquilar.Padding = new Padding(35, 0, 0, 0);
            btn_realizar_alquilar.Size = new Size(321, 30);
            btn_realizar_alquilar.TabIndex = 5;
            btn_realizar_alquilar.Tag = "Realizar alquiler";
            btn_realizar_alquilar.Text = "Realizar alquiler";
            btn_realizar_alquilar.TextAlign = ContentAlignment.MiddleLeft;
            btn_realizar_alquilar.UseVisualStyleBackColor = false;
            btn_realizar_alquilar.Click += btn_reservas_Click;
            // 
            // btn_cabañas_alquiler
            // 
            btn_cabañas_alquiler.BackColor = Color.FromArgb(0, 40, 81);
            btn_cabañas_alquiler.Dock = DockStyle.Top;
            btn_cabañas_alquiler.FlatAppearance.BorderSize = 0;
            btn_cabañas_alquiler.FlatStyle = FlatStyle.Flat;
            btn_cabañas_alquiler.Font = new Font("Century Gothic", 9.75F);
            btn_cabañas_alquiler.ForeColor = Color.White;
            btn_cabañas_alquiler.Location = new Point(0, 474);
            btn_cabañas_alquiler.Name = "btn_cabañas_alquiler";
            btn_cabañas_alquiler.Padding = new Padding(10, 0, 0, 0);
            btn_cabañas_alquiler.Size = new Size(321, 30);
            btn_cabañas_alquiler.TabIndex = 28;
            btn_cabañas_alquiler.Tag = "Cabañas y alquiler";
            btn_cabañas_alquiler.Text = "Cabañas y alquiler";
            btn_cabañas_alquiler.TextAlign = ContentAlignment.MiddleLeft;
            btn_cabañas_alquiler.UseVisualStyleBackColor = false;
            btn_cabañas_alquiler.Click += btn_cabañas_alquiler_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 863);
            label3.Name = "label3";
            label3.Size = new Size(73, 22);
            label3.TabIndex = 26;
            label3.Text = "Ajustes";
            label3.Click += btn_ajustes_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 908);
            label2.Name = "label2";
            label2.Size = new Size(85, 22);
            label2.TabIndex = 25;
            label2.Text = "Log Out";
            label2.Click += btn_cerrarSesion_Click;
            // 
            // btn_cerrarSesion
            // 
            btn_cerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_cerrarSesion.Image = (Image)resources.GetObject("btn_cerrarSesion.Image");
            btn_cerrarSesion.Location = new Point(-2, 897);
            btn_cerrarSesion.Name = "btn_cerrarSesion";
            btn_cerrarSesion.Size = new Size(108, 47);
            btn_cerrarSesion.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrarSesion.TabIndex = 24;
            btn_cerrarSesion.TabStop = false;
            btn_cerrarSesion.Click += btn_cerrarSesion_Click;
            // 
            // btn_ajustes
            // 
            btn_ajustes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_ajustes.Image = (Image)resources.GetObject("btn_ajustes.Image");
            btn_ajustes.Location = new Point(-12, 851);
            btn_ajustes.Name = "btn_ajustes";
            btn_ajustes.Size = new Size(117, 45);
            btn_ajustes.SizeMode = PictureBoxSizeMode.Zoom;
            btn_ajustes.TabIndex = 23;
            btn_ajustes.TabStop = false;
            btn_ajustes.Click += btn_ajustes_Click;
            // 
            // panel_ABM
            // 
            panel_ABM.BackColor = Color.FromArgb(40, 40, 40);
            panel_ABM.Controls.Add(button1);
            panel_ABM.Controls.Add(button2);
            panel_ABM.Controls.Add(btn_empleados_abm);
            panel_ABM.Controls.Add(btn_ABM_cabañas);
            panel_ABM.Controls.Add(btn_ABM_clientes);
            panel_ABM.Controls.Add(btn_ABM_usuarios);
            panel_ABM.Dock = DockStyle.Top;
            panel_ABM.Location = new Point(0, 294);
            panel_ABM.Name = "panel_ABM";
            panel_ABM.Size = new Size(321, 180);
            panel_ABM.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(65, 65, 65);
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 150);
            button1.Name = "button1";
            button1.Padding = new Padding(35, 0, 0, 0);
            button1.Size = new Size(321, 30);
            button1.TabIndex = 5;
            button1.Tag = "ABM de Mantenimientos";
            button1.Text = "ABM de Mantenimientos";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(65, 65, 65);
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 120);
            button2.Name = "button2";
            button2.Padding = new Padding(35, 0, 0, 0);
            button2.Size = new Size(321, 30);
            button2.TabIndex = 4;
            button2.Tag = "ABM de Servicios";
            button2.Text = "ABM de Servicios";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_empleados_abm
            // 
            btn_empleados_abm.BackColor = Color.FromArgb(65, 65, 65);
            btn_empleados_abm.Dock = DockStyle.Top;
            btn_empleados_abm.FlatAppearance.BorderSize = 0;
            btn_empleados_abm.FlatStyle = FlatStyle.Flat;
            btn_empleados_abm.Font = new Font("Century Gothic", 9.75F);
            btn_empleados_abm.ForeColor = Color.White;
            btn_empleados_abm.Location = new Point(0, 90);
            btn_empleados_abm.Name = "btn_empleados_abm";
            btn_empleados_abm.Padding = new Padding(35, 0, 0, 0);
            btn_empleados_abm.Size = new Size(321, 30);
            btn_empleados_abm.TabIndex = 3;
            btn_empleados_abm.Tag = "ABM de Empleados";
            btn_empleados_abm.Text = "ABM de Empleados";
            btn_empleados_abm.TextAlign = ContentAlignment.MiddleLeft;
            btn_empleados_abm.UseVisualStyleBackColor = false;
            btn_empleados_abm.Click += btn_empleados_abm_Click;
            // 
            // btn_ABM_cabañas
            // 
            btn_ABM_cabañas.BackColor = Color.FromArgb(65, 65, 65);
            btn_ABM_cabañas.Dock = DockStyle.Top;
            btn_ABM_cabañas.FlatAppearance.BorderSize = 0;
            btn_ABM_cabañas.FlatStyle = FlatStyle.Flat;
            btn_ABM_cabañas.Font = new Font("Century Gothic", 9.75F);
            btn_ABM_cabañas.ForeColor = Color.White;
            btn_ABM_cabañas.Location = new Point(0, 60);
            btn_ABM_cabañas.Name = "btn_ABM_cabañas";
            btn_ABM_cabañas.Padding = new Padding(35, 0, 0, 0);
            btn_ABM_cabañas.Size = new Size(321, 30);
            btn_ABM_cabañas.TabIndex = 2;
            btn_ABM_cabañas.Tag = "ABM de Cabañas";
            btn_ABM_cabañas.Text = "ABM de Cabañas";
            btn_ABM_cabañas.TextAlign = ContentAlignment.MiddleLeft;
            btn_ABM_cabañas.UseVisualStyleBackColor = false;
            btn_ABM_cabañas.Click += btn_ABM_cabañas_Click;
            // 
            // btn_ABM_clientes
            // 
            btn_ABM_clientes.BackColor = Color.FromArgb(65, 65, 65);
            btn_ABM_clientes.Dock = DockStyle.Top;
            btn_ABM_clientes.FlatAppearance.BorderSize = 0;
            btn_ABM_clientes.FlatStyle = FlatStyle.Flat;
            btn_ABM_clientes.Font = new Font("Century Gothic", 9.75F);
            btn_ABM_clientes.ForeColor = Color.White;
            btn_ABM_clientes.Location = new Point(0, 30);
            btn_ABM_clientes.Name = "btn_ABM_clientes";
            btn_ABM_clientes.Padding = new Padding(35, 0, 0, 0);
            btn_ABM_clientes.Size = new Size(321, 30);
            btn_ABM_clientes.TabIndex = 1;
            btn_ABM_clientes.Tag = "ABM de Clientes";
            btn_ABM_clientes.Text = "ABM de Clientes";
            btn_ABM_clientes.TextAlign = ContentAlignment.MiddleLeft;
            btn_ABM_clientes.UseVisualStyleBackColor = false;
            btn_ABM_clientes.Click += btn_ABM_clientes_Click;
            // 
            // btn_ABM_usuarios
            // 
            btn_ABM_usuarios.BackColor = Color.FromArgb(65, 65, 65);
            btn_ABM_usuarios.Dock = DockStyle.Top;
            btn_ABM_usuarios.FlatAppearance.BorderSize = 0;
            btn_ABM_usuarios.FlatStyle = FlatStyle.Flat;
            btn_ABM_usuarios.Font = new Font("Century Gothic", 9.75F);
            btn_ABM_usuarios.ForeColor = Color.White;
            btn_ABM_usuarios.Location = new Point(0, 0);
            btn_ABM_usuarios.Name = "btn_ABM_usuarios";
            btn_ABM_usuarios.Padding = new Padding(35, 0, 0, 0);
            btn_ABM_usuarios.Size = new Size(321, 30);
            btn_ABM_usuarios.TabIndex = 0;
            btn_ABM_usuarios.Tag = "ABM de Usuarios";
            btn_ABM_usuarios.Text = "ABM de Usuarios";
            btn_ABM_usuarios.TextAlign = ContentAlignment.MiddleLeft;
            btn_ABM_usuarios.UseVisualStyleBackColor = false;
            btn_ABM_usuarios.Click += btn_ABM_usuarios_Click;
            // 
            // btn_ABM
            // 
            btn_ABM.BackColor = Color.FromArgb(0, 40, 81);
            btn_ABM.Dock = DockStyle.Top;
            btn_ABM.FlatAppearance.BorderSize = 0;
            btn_ABM.FlatStyle = FlatStyle.Flat;
            btn_ABM.Font = new Font("Century Gothic", 9.75F);
            btn_ABM.ForeColor = Color.White;
            btn_ABM.Location = new Point(0, 264);
            btn_ABM.Name = "btn_ABM";
            btn_ABM.Padding = new Padding(10, 0, 0, 0);
            btn_ABM.Size = new Size(321, 30);
            btn_ABM.TabIndex = 16;
            btn_ABM.Tag = "ABM";
            btn_ABM.Text = "ABM";
            btn_ABM.TextAlign = ContentAlignment.MiddleLeft;
            btn_ABM.UseVisualStyleBackColor = false;
            btn_ABM.Click += btn_ABM_Click;
            // 
            // panel_seguridad
            // 
            panel_seguridad.BackColor = Color.FromArgb(35, 32, 39);
            panel_seguridad.Controls.Add(btn_asignarPermisos);
            panel_seguridad.Controls.Add(btn_gestionar_grupos);
            panel_seguridad.Controls.Add(btn_gestionar_permisos);
            panel_seguridad.Dock = DockStyle.Top;
            panel_seguridad.Location = new Point(0, 174);
            panel_seguridad.Name = "panel_seguridad";
            panel_seguridad.Size = new Size(321, 90);
            panel_seguridad.TabIndex = 7;
            // 
            // btn_asignarPermisos
            // 
            btn_asignarPermisos.BackColor = Color.FromArgb(65, 65, 65);
            btn_asignarPermisos.Dock = DockStyle.Top;
            btn_asignarPermisos.FlatAppearance.BorderSize = 0;
            btn_asignarPermisos.FlatStyle = FlatStyle.Flat;
            btn_asignarPermisos.Font = new Font("Century Gothic", 9.75F);
            btn_asignarPermisos.ForeColor = Color.White;
            btn_asignarPermisos.Location = new Point(0, 60);
            btn_asignarPermisos.Name = "btn_asignarPermisos";
            btn_asignarPermisos.Padding = new Padding(35, 0, 0, 0);
            btn_asignarPermisos.Size = new Size(321, 30);
            btn_asignarPermisos.TabIndex = 2;
            btn_asignarPermisos.Tag = "Asignar permisos";
            btn_asignarPermisos.Text = "Asignar permisos";
            btn_asignarPermisos.TextAlign = ContentAlignment.MiddleLeft;
            btn_asignarPermisos.UseVisualStyleBackColor = false;
            btn_asignarPermisos.Click += btn_asignarPermisos_Click;
            // 
            // btn_gestionar_grupos
            // 
            btn_gestionar_grupos.BackColor = Color.FromArgb(65, 65, 65);
            btn_gestionar_grupos.Dock = DockStyle.Top;
            btn_gestionar_grupos.FlatAppearance.BorderSize = 0;
            btn_gestionar_grupos.FlatStyle = FlatStyle.Flat;
            btn_gestionar_grupos.Font = new Font("Century Gothic", 9.75F);
            btn_gestionar_grupos.ForeColor = Color.White;
            btn_gestionar_grupos.Location = new Point(0, 30);
            btn_gestionar_grupos.Name = "btn_gestionar_grupos";
            btn_gestionar_grupos.Padding = new Padding(35, 0, 0, 0);
            btn_gestionar_grupos.Size = new Size(321, 30);
            btn_gestionar_grupos.TabIndex = 1;
            btn_gestionar_grupos.Tag = "Gestionar grupos";
            btn_gestionar_grupos.Text = "Gestionar grupos";
            btn_gestionar_grupos.TextAlign = ContentAlignment.MiddleLeft;
            btn_gestionar_grupos.UseVisualStyleBackColor = false;
            btn_gestionar_grupos.Click += btn_gestionar_grupos_Click;
            // 
            // btn_gestionar_permisos
            // 
            btn_gestionar_permisos.BackColor = Color.FromArgb(65, 65, 65);
            btn_gestionar_permisos.Dock = DockStyle.Top;
            btn_gestionar_permisos.FlatAppearance.BorderSize = 0;
            btn_gestionar_permisos.FlatStyle = FlatStyle.Flat;
            btn_gestionar_permisos.Font = new Font("Century Gothic", 9.75F);
            btn_gestionar_permisos.ForeColor = Color.White;
            btn_gestionar_permisos.Location = new Point(0, 0);
            btn_gestionar_permisos.Name = "btn_gestionar_permisos";
            btn_gestionar_permisos.Padding = new Padding(35, 0, 0, 0);
            btn_gestionar_permisos.Size = new Size(321, 30);
            btn_gestionar_permisos.TabIndex = 0;
            btn_gestionar_permisos.Tag = "Gestionar permisos";
            btn_gestionar_permisos.Text = "Gestionar permisos";
            btn_gestionar_permisos.TextAlign = ContentAlignment.MiddleLeft;
            btn_gestionar_permisos.UseVisualStyleBackColor = false;
            btn_gestionar_permisos.Click += btn_gestionar_permisos_Click;
            // 
            // btn_seguridad
            // 
            btn_seguridad.BackColor = Color.FromArgb(0, 40, 81);
            btn_seguridad.Dock = DockStyle.Top;
            btn_seguridad.FlatAppearance.BorderSize = 0;
            btn_seguridad.FlatStyle = FlatStyle.Flat;
            btn_seguridad.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_seguridad.ForeColor = Color.White;
            btn_seguridad.Location = new Point(0, 144);
            btn_seguridad.Name = "btn_seguridad";
            btn_seguridad.Padding = new Padding(10, 0, 0, 0);
            btn_seguridad.Size = new Size(321, 30);
            btn_seguridad.TabIndex = 6;
            btn_seguridad.Tag = "Seguridad";
            btn_seguridad.Text = "Seguridad";
            btn_seguridad.TextAlign = ContentAlignment.MiddleLeft;
            btn_seguridad.UseVisualStyleBackColor = false;
            btn_seguridad.Click += btn_seguridad_Click;
            // 
            // panel_logo
            // 
            panel_logo.Controls.Add(lbl_usuario);
            panel_logo.Controls.Add(lb_nombre);
            panel_logo.Controls.Add(lb_email);
            panel_logo.Controls.Add(lb_grupo);
            panel_logo.Controls.Add(pictureBox1);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(321, 144);
            panel_logo.TabIndex = 0;
            panel_logo.MouseDown += panel_logo_MouseDown;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.FlatStyle = FlatStyle.Flat;
            lbl_usuario.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_usuario.ForeColor = Color.White;
            lbl_usuario.Location = new Point(95, 67);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(54, 17);
            lbl_usuario.TabIndex = 4;
            lbl_usuario.Text = "Usuario";
            // 
            // lb_nombre
            // 
            lb_nombre.AutoSize = true;
            lb_nombre.FlatStyle = FlatStyle.Flat;
            lb_nombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nombre.ForeColor = Color.White;
            lb_nombre.Location = new Point(95, 10);
            lb_nombre.Name = "lb_nombre";
            lb_nombre.Size = new Size(61, 17);
            lb_nombre.TabIndex = 3;
            lb_nombre.Text = "Nombre";
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.FlatStyle = FlatStyle.Flat;
            lb_email.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_email.ForeColor = Color.White;
            lb_email.Location = new Point(95, 94);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(43, 17);
            lb_email.TabIndex = 2;
            lb_email.Text = "Email";
            // 
            // lb_grupo
            // 
            lb_grupo.AutoSize = true;
            lb_grupo.FlatStyle = FlatStyle.Flat;
            lb_grupo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_grupo.ForeColor = Color.White;
            lb_grupo.Location = new Point(95, 38);
            lb_grupo.Name = "lb_grupo";
            lb_grupo.Size = new Size(61, 17);
            lb_grupo.TabIndex = 1;
            lb_grupo.Text = "Posicion";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // panel_forms
            // 
            panel_forms.BackColor = Color.White;
            panel_forms.Controls.Add(panel_menuLateral);
            panel_forms.Controls.Add(pictureBox2);
            panel_forms.Dock = DockStyle.Fill;
            panel_forms.Location = new Point(0, 37);
            panel_forms.Name = "panel_forms";
            panel_forms.Size = new Size(1639, 948);
            panel_forms.TabIndex = 2;
            panel_forms.MouseDown += panel_forms_MouseDown;
            // 
            // Form_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 985);
            Controls.Add(panel_forms);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_principal";
            Load += Form_principal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_restaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_maximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_menuLateral.ResumeLayout(false);
            panel_menuLateral.PerformLayout();
            panel_informes.ResumeLayout(false);
            panel_mantenimientos.ResumeLayout(false);
            panel_servicios.ResumeLayout(false);
            panel_reservas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_cerrarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_ajustes).EndInit();
            panel_ABM.ResumeLayout(false);
            panel_seguridad.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_forms.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox btn_cerrar;
        private PictureBox btn_minimizar;
        private PictureBox btn_maximizar;
        private PictureBox btn_restaurar;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel_menuLateral;
        private Label label3;
        private Label label2;
        private PictureBox btn_cerrarSesion;
        private PictureBox btn_ajustes;
        private Panel panel_ABM;
        private Button btn_ABM_cabañas;
        private Button btn_ABM_clientes;
        private Button btn_ABM_usuarios;
        private Button btn_ABM;
        private Panel panel_seguridad;
        private Button btn_asignarPermisos;
        private Button btn_gestionar_grupos;
        private Button btn_gestionar_permisos;
        private Button btn_seguridad;
        private Panel panel_logo;
        private Label lbl_usuario;
        private Label lb_nombre;
        private Label lb_email;
        private Label lb_grupo;
        private PictureBox pictureBox1;
        public Panel panel_forms;
        private Panel panel_reservas;
        private Button btn_ver_reservas;
        private Button btn_realizar_alquilar;
        private Button btn_cabañas_alquiler;
        private Panel panel_informes;
        private Button btn_motivosCancelacion;
        private Button btn_informes;
        private Button button1;
        private Button button2;
        private Button btn_empleados_abm;
        private Button button6;
        private Panel panel_servicios;
        private Button button8;
        private Button button9;
        private Button btn_servicios;
        private Panel panel5;
        private Button button14;
        private Button button15;
        private Panel panel_mantenimientos;
        private Button button11;
        private Button button12;
        private Button btn_mantenimientos;
    }
}