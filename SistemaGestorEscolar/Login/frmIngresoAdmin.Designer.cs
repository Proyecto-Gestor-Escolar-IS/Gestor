﻿namespace SistemaGestorEscolar.Login
{
    partial class frmIngresoAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.lblContraRecuperacion = new System.Windows.Forms.Label();
            this.txtContraseRecuperacion = new System.Windows.Forms.TextBox();
            this.chkVerContraRecuperacion = new System.Windows.Forms.CheckBox();
            this.txtCorreoRecuperacion = new System.Windows.Forms.TextBox();
            this.lblCorreoRecuperacion = new System.Windows.Forms.Label();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.pnlRecuperacion = new System.Windows.Forms.Panel();
            this.txtPuerto = new System.Windows.Forms.MaskedTextBox();
            this.t = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.Label();
            this.btnFinalizar = new AltoControls.AltoButton();
            this.btnAtras = new AltoControls.AltoButton();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSiguiente = new AltoControls.AltoButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentidad = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaNa = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.chkVerContras = new System.Windows.Forms.CheckBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtConfirmContra = new System.Windows.Forms.TextBox();
            this.lblConfiContra = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.cmbCargosSec = new System.Windows.Forms.ComboBox();
            this.lblFechaNa = new System.Windows.Forms.Label();
            this.lblCoreeo = new System.Windows.Forms.Label();
            this.lblTele = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlRecuperacion.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Registro de Administrador";
            // 
            // lblContraRecuperacion
            // 
            this.lblContraRecuperacion.AutoSize = true;
            this.lblContraRecuperacion.Font = new System.Drawing.Font("Balsamiq Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraRecuperacion.Location = new System.Drawing.Point(69, 224);
            this.lblContraRecuperacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraRecuperacion.Name = "lblContraRecuperacion";
            this.lblContraRecuperacion.Size = new System.Drawing.Size(61, 21);
            this.lblContraRecuperacion.TabIndex = 40;
            this.lblContraRecuperacion.Text = "Clave";
            // 
            // txtContraseRecuperacion
            // 
            this.txtContraseRecuperacion.Font = new System.Drawing.Font("Balsamiq Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseRecuperacion.Location = new System.Drawing.Point(154, 226);
            this.txtContraseRecuperacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseRecuperacion.Name = "txtContraseRecuperacion";
            this.txtContraseRecuperacion.PasswordChar = '●';
            this.txtContraseRecuperacion.Size = new System.Drawing.Size(217, 24);
            this.txtContraseRecuperacion.TabIndex = 1;
            this.txtContraseRecuperacion.WordWrap = false;
            // 
            // chkVerContraRecuperacion
            // 
            this.chkVerContraRecuperacion.AutoSize = true;
            this.chkVerContraRecuperacion.Font = new System.Drawing.Font("Balsamiq Sans", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVerContraRecuperacion.Location = new System.Drawing.Point(376, 229);
            this.chkVerContraRecuperacion.Name = "chkVerContraRecuperacion";
            this.chkVerContraRecuperacion.Size = new System.Drawing.Size(92, 18);
            this.chkVerContraRecuperacion.TabIndex = 44;
            this.chkVerContraRecuperacion.Text = "Ver Clave";
            this.chkVerContraRecuperacion.UseVisualStyleBackColor = true;
            this.chkVerContraRecuperacion.CheckedChanged += new System.EventHandler(this.chkVerContraRecuperacion_CheckedChanged);
            // 
            // txtCorreoRecuperacion
            // 
            this.txtCorreoRecuperacion.Font = new System.Drawing.Font("Balsamiq Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoRecuperacion.Location = new System.Drawing.Point(154, 170);
            this.txtCorreoRecuperacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreoRecuperacion.Name = "txtCorreoRecuperacion";
            this.txtCorreoRecuperacion.Size = new System.Drawing.Size(307, 24);
            this.txtCorreoRecuperacion.TabIndex = 0;
            // 
            // lblCorreoRecuperacion
            // 
            this.lblCorreoRecuperacion.AutoSize = true;
            this.lblCorreoRecuperacion.Font = new System.Drawing.Font("Balsamiq Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoRecuperacion.Location = new System.Drawing.Point(55, 170);
            this.lblCorreoRecuperacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreoRecuperacion.Name = "lblCorreoRecuperacion";
            this.lblCorreoRecuperacion.Size = new System.Drawing.Size(76, 21);
            this.lblCorreoRecuperacion.TabIndex = 45;
            this.lblCorreoRecuperacion.Text = "Usuario";
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.Location = new System.Drawing.Point(17, 31);
            this.lblInstruccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(535, 57);
            this.lblInstruccion.TabIndex = 47;
            this.lblInstruccion.Text = "Ingrese las credenciales de acceso para configurar \r\nel correo electrónico de rec" +
    "uperación. \r\n(Desde este correo se enviaran los correos de recuperación).";
            // 
            // pnlRecuperacion
            // 
            this.pnlRecuperacion.Controls.Add(this.txtPuerto);
            this.pnlRecuperacion.Controls.Add(this.t);
            this.pnlRecuperacion.Controls.Add(this.txtHost);
            this.pnlRecuperacion.Controls.Add(this.Host);
            this.pnlRecuperacion.Controls.Add(this.btnFinalizar);
            this.pnlRecuperacion.Controls.Add(this.btnAtras);
            this.pnlRecuperacion.Controls.Add(this.txtCorreoRecuperacion);
            this.pnlRecuperacion.Controls.Add(this.lblInstruccion);
            this.pnlRecuperacion.Controls.Add(this.chkVerContraRecuperacion);
            this.pnlRecuperacion.Controls.Add(this.lblContraRecuperacion);
            this.pnlRecuperacion.Controls.Add(this.lblCorreoRecuperacion);
            this.pnlRecuperacion.Controls.Add(this.txtContraseRecuperacion);
            this.pnlRecuperacion.Location = new System.Drawing.Point(43, 112);
            this.pnlRecuperacion.Name = "pnlRecuperacion";
            this.pnlRecuperacion.Size = new System.Drawing.Size(522, 563);
            this.pnlRecuperacion.TabIndex = 52;
            this.pnlRecuperacion.Visible = false;
            // 
            // txtPuerto
            // 
            this.txtPuerto.Font = new System.Drawing.Font("Balsamiq Sans", 9.749999F, System.Drawing.FontStyle.Bold);
            this.txtPuerto.Location = new System.Drawing.Point(156, 327);
            this.txtPuerto.Mask = "99999";
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(99, 24);
            this.txtPuerto.TabIndex = 3;
            this.txtPuerto.ValidatingType = typeof(int);
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Balsamiq Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(59, 327);
            this.t.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(68, 21);
            this.t.TabIndex = 58;
            this.t.Text = "Puerto";
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Balsamiq Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.Location = new System.Drawing.Point(154, 279);
            this.txtHost.Margin = new System.Windows.Forms.Padding(2);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(307, 24);
            this.txtHost.TabIndex = 2;
            this.txtHost.WordWrap = false;
            // 
            // Host
            // 
            this.Host.AutoSize = true;
            this.Host.Font = new System.Drawing.Font("Balsamiq Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Host.Location = new System.Drawing.Point(79, 279);
            this.Host.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(50, 21);
            this.Host.TabIndex = 56;
            this.Host.Text = "Host";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnFinalizar.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnFinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFinalizar.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.btnFinalizar.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnFinalizar.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnFinalizar.Location = new System.Drawing.Point(388, 521);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Radius = 15;
            this.btnFinalizar.Size = new System.Drawing.Size(134, 41);
            this.btnFinalizar.Stroke = true;
            this.btnFinalizar.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.Transparency = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnAtras.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAtras.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.btnAtras.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnAtras.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnAtras.Location = new System.Drawing.Point(0, 521);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Radius = 15;
            this.btnAtras.Size = new System.Drawing.Size(134, 41);
            this.btnAtras.Stroke = true;
            this.btnAtras.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.btnAtras.TabIndex = 54;
            this.btnAtras.Text = "REGRESAR";
            this.btnAtras.Transparency = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.label3);
            this.pnlPrincipal.Controls.Add(this.btnSiguiente);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Controls.Add(this.txtIdentidad);
            this.pnlPrincipal.Controls.Add(this.txtFechaNa);
            this.pnlPrincipal.Controls.Add(this.txtTel);
            this.pnlPrincipal.Controls.Add(this.txtContra);
            this.pnlPrincipal.Controls.Add(this.chkVerContras);
            this.pnlPrincipal.Controls.Add(this.lblContra);
            this.pnlPrincipal.Controls.Add(this.txtConfirmContra);
            this.pnlPrincipal.Controls.Add(this.lblConfiContra);
            this.pnlPrincipal.Controls.Add(this.txtCorreo);
            this.pnlPrincipal.Controls.Add(this.txtApellido2);
            this.pnlPrincipal.Controls.Add(this.txtApellido1);
            this.pnlPrincipal.Controls.Add(this.txtNombre2);
            this.pnlPrincipal.Controls.Add(this.txtNombre1);
            this.pnlPrincipal.Controls.Add(this.cmbCargosSec);
            this.pnlPrincipal.Controls.Add(this.lblFechaNa);
            this.pnlPrincipal.Controls.Add(this.lblCoreeo);
            this.pnlPrincipal.Controls.Add(this.lblTele);
            this.pnlPrincipal.Controls.Add(this.lblApellidos);
            this.pnlPrincipal.Controls.Add(this.lblNombres);
            this.pnlPrincipal.Controls.Add(this.label4);
            this.pnlPrincipal.Location = new System.Drawing.Point(12, 128);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(582, 555);
            this.pnlPrincipal.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Balsamiq Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 438);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 53;
            this.label3.Text = "Cargo";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnSiguiente.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSiguiente.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.btnSiguiente.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnSiguiente.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnSiguiente.Location = new System.Drawing.Point(408, 505);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Radius = 15;
            this.btnSiguiente.Size = new System.Drawing.Size(134, 41);
            this.btnSiguiente.Stroke = true;
            this.btnSiguiente.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.btnSiguiente.TabIndex = 10;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.Transparency = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Balsamiq Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 392);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "dd/mm/aaaa";
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Font = new System.Drawing.Font("Balsamiq Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidad.Location = new System.Drawing.Point(169, 29);
            this.txtIdentidad.Mask = "0000000000000";
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.ReadOnly = true;
            this.txtIdentidad.Size = new System.Drawing.Size(144, 26);
            this.txtIdentidad.TabIndex = 0;
            // 
            // txtFechaNa
            // 
            this.txtFechaNa.Font = new System.Drawing.Font("Balsamiq Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNa.Location = new System.Drawing.Point(266, 387);
            this.txtFechaNa.Mask = "00/00/0000";
            this.txtFechaNa.Name = "txtFechaNa";
            this.txtFechaNa.Size = new System.Drawing.Size(100, 24);
            this.txtFechaNa.TabIndex = 8;
            this.txtFechaNa.ValidatingType = typeof(System.DateTime);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Balsamiq Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(169, 187);
            this.txtTel.Mask = "00000000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 24);
            this.txtTel.TabIndex = 4;
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Balsamiq Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(169, 291);
            this.txtContra.Margin = new System.Windows.Forms.Padding(2);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '●';
            this.txtContra.Size = new System.Drawing.Size(182, 24);
            this.txtContra.TabIndex = 6;
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            // 
            // chkVerContras
            // 
            this.chkVerContras.AutoSize = true;
            this.chkVerContras.Font = new System.Drawing.Font("Balsamiq Sans", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVerContras.Location = new System.Drawing.Point(366, 294);
            this.chkVerContras.Name = "chkVerContras";
            this.chkVerContras.Size = new System.Drawing.Size(136, 18);
            this.chkVerContras.TabIndex = 51;
            this.chkVerContras.Text = "Ver Contraseñas";
            this.chkVerContras.UseVisualStyleBackColor = true;
            this.chkVerContras.CheckedChanged += new System.EventHandler(this.chkVerContras_CheckedChanged);
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Balsamiq Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.Location = new System.Drawing.Point(45, 291);
            this.lblContra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(114, 21);
            this.lblContra.TabIndex = 49;
            this.lblContra.Text = "Contraseña";
            // 
            // txtConfirmContra
            // 
            this.txtConfirmContra.Font = new System.Drawing.Font("Balsamiq Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmContra.Location = new System.Drawing.Point(266, 340);
            this.txtConfirmContra.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmContra.Name = "txtConfirmContra";
            this.txtConfirmContra.PasswordChar = '●';
            this.txtConfirmContra.Size = new System.Drawing.Size(182, 24);
            this.txtConfirmContra.TabIndex = 7;
            this.txtConfirmContra.TextChanged += new System.EventHandler(this.txtConfirmContra_TextChanged);
            // 
            // lblConfiContra
            // 
            this.lblConfiContra.AutoSize = true;
            this.lblConfiContra.Font = new System.Drawing.Font("Balsamiq Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfiContra.Location = new System.Drawing.Point(45, 338);
            this.lblConfiContra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfiContra.Name = "lblConfiContra";
            this.lblConfiContra.Size = new System.Drawing.Size(208, 21);
            this.lblConfiContra.TabIndex = 42;
            this.lblConfiContra.Text = "Confirmar Contraseña";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Balsamiq Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(169, 239);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(307, 24);
            this.txtCorreo.TabIndex = 5;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Font = new System.Drawing.Font("Balsamiq Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(355, 133);
            this.txtApellido2.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(182, 24);
            this.txtApellido2.TabIndex = 3;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Font = new System.Drawing.Font("Balsamiq Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(169, 133);
            this.txtApellido1.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(182, 24);
            this.txtApellido1.TabIndex = 2;
            // 
            // txtNombre2
            // 
            this.txtNombre2.Font = new System.Drawing.Font("Balsamiq Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre2.Location = new System.Drawing.Point(355, 80);
            this.txtNombre2.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(182, 24);
            this.txtNombre2.TabIndex = 1;
            // 
            // txtNombre1
            // 
            this.txtNombre1.Font = new System.Drawing.Font("Balsamiq Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre1.Location = new System.Drawing.Point(169, 80);
            this.txtNombre1.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(182, 24);
            this.txtNombre1.TabIndex = 0;
            // 
            // cmbCargosSec
            // 
            this.cmbCargosSec.Enabled = false;
            this.cmbCargosSec.Font = new System.Drawing.Font("Balsamiq Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargosSec.FormattingEnabled = true;
            this.cmbCargosSec.Items.AddRange(new object[] {
            "Administrador"});
            this.cmbCargosSec.Location = new System.Drawing.Point(125, 438);
            this.cmbCargosSec.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCargosSec.Name = "cmbCargosSec";
            this.cmbCargosSec.Size = new System.Drawing.Size(183, 23);
            this.cmbCargosSec.TabIndex = 9;
            this.cmbCargosSec.Text = "Administrador";
            // 
            // lblFechaNa
            // 
            this.lblFechaNa.AutoSize = true;
            this.lblFechaNa.Font = new System.Drawing.Font("Balsamiq Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNa.Location = new System.Drawing.Point(45, 387);
            this.lblFechaNa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNa.Name = "lblFechaNa";
            this.lblFechaNa.Size = new System.Drawing.Size(194, 21);
            this.lblFechaNa.TabIndex = 28;
            this.lblFechaNa.Text = "Fecha de Nacimiento";
            // 
            // lblCoreeo
            // 
            this.lblCoreeo.AutoSize = true;
            this.lblCoreeo.Font = new System.Drawing.Font("Balsamiq Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoreeo.Location = new System.Drawing.Point(45, 239);
            this.lblCoreeo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoreeo.Name = "lblCoreeo";
            this.lblCoreeo.Size = new System.Drawing.Size(71, 21);
            this.lblCoreeo.TabIndex = 27;
            this.lblCoreeo.Text = "Correo";
            // 
            // lblTele
            // 
            this.lblTele.AutoSize = true;
            this.lblTele.Font = new System.Drawing.Font("Balsamiq Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTele.Location = new System.Drawing.Point(45, 187);
            this.lblTele.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTele.Name = "lblTele";
            this.lblTele.Size = new System.Drawing.Size(88, 21);
            this.lblTele.TabIndex = 26;
            this.lblTele.Text = "Teléfono";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Balsamiq Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(44, 133);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(88, 21);
            this.lblApellidos.TabIndex = 25;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Balsamiq Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(46, 78);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(88, 21);
            this.lblNombres.TabIndex = 24;
            this.lblNombres.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Balsamiq Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Identidad";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmIngresoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(605, 688);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlRecuperacion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIngresoAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INGRESO DE ADMINISTRADOR";
            this.Load += new System.EventHandler(this.frmIngresoAdmin_Load);
            this.pnlRecuperacion.ResumeLayout(false);
            this.pnlRecuperacion.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContraRecuperacion;
        private System.Windows.Forms.TextBox txtContraseRecuperacion;
        private System.Windows.Forms.CheckBox chkVerContraRecuperacion;
        private System.Windows.Forms.TextBox txtCorreoRecuperacion;
        private System.Windows.Forms.Label lblCorreoRecuperacion;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Panel pnlRecuperacion;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtIdentidad;
        private System.Windows.Forms.MaskedTextBox txtFechaNa;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.CheckBox chkVerContras;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtConfirmContra;
        private System.Windows.Forms.Label lblConfiContra;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.ComboBox cmbCargosSec;
        private System.Windows.Forms.Label lblFechaNa;
        private System.Windows.Forms.Label lblCoreeo;
        private System.Windows.Forms.Label lblTele;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label label4;
        private AltoControls.AltoButton btnSiguiente;
        private AltoControls.AltoButton btnFinalizar;
        private AltoControls.AltoButton btnAtras;
        private System.Windows.Forms.MaskedTextBox txtPuerto;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label Host;
        private System.Windows.Forms.Label label3;
    }
}