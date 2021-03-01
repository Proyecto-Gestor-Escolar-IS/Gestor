
namespace SistemaGestorEscolar
{
    partial class InterfazGraficaPrincipal
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
            this.panSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrarPrograma = new System.Windows.Forms.Button();
            this.panLateral = new System.Windows.Forms.Panel();
            this.btnCambioTema = new System.Windows.Forms.Button();
            this.btnMenuPersonal = new System.Windows.Forms.Button();
            this.btnMenuRegistroPago = new System.Windows.Forms.Button();
            this.btnMenuIngresoNotas = new System.Windows.Forms.Button();
            this.btnMenuCursosDisponibles = new System.Windows.Forms.Button();
            this.btnMenuVistaMatricula = new System.Windows.Forms.Button();
            this.btnMenuMatriculaEstudiante = new System.Windows.Forms.Button();
            this.btnMenuAtras = new System.Windows.Forms.Button();
            this.picImagotipo = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panSubMenuEstudiante = new System.Windows.Forms.Panel();
            this.btnFichaEstudiante = new System.Windows.Forms.Button();
            this.btnHistorialCursos = new System.Windows.Forms.Button();
            this.btnRegistrarVisitaMedica = new System.Windows.Forms.Button();
            this.btnHistorialMedico = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMostrador = new System.Windows.Forms.Panel();
            this.panSubMenuPagos = new System.Windows.Forms.Panel();
            this.btnHistorialPagos = new System.Windows.Forms.Button();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.btnIngresarNotas = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.tmrOcultarMenu = new System.Windows.Forms.Timer(this.components);
            this.tmrMostrarMenu = new System.Windows.Forms.Timer(this.components);
            this.btnMatriEstudiante = new BrbVideoManager.Controls.RoundedButton();
            this.btnVistaMatriculas = new BrbVideoManager.Controls.RoundedButton();
            this.panSuperior.SuspendLayout();
            this.panLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagotipo)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.panSubMenuEstudiante.SuspendLayout();
            this.panSubMenuPagos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panSuperior
            // 
            this.panSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(169)))));
            this.panSuperior.Controls.Add(this.btnMinimizar);
            this.panSuperior.Controls.Add(this.btnMaximizar);
            this.panSuperior.Controls.Add(this.btnCerrarPrograma);
            this.panSuperior.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSuperior.Location = new System.Drawing.Point(0, 0);
            this.panSuperior.Name = "panSuperior";
            this.panSuperior.Size = new System.Drawing.Size(1920, 45);
            this.panSuperior.TabIndex = 0;
            this.panSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.panSuperior_Paint);
            this.panSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panSuperior_MouseDown);
            this.panSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panSuperior_MouseMove);
            this.panSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panSuperior_MouseUp);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.minimize;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(1786, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 35);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.maximize;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(1830, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(34, 35);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrarPrograma
            // 
            this.btnCerrarPrograma.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.exitButton;
            this.btnCerrarPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarPrograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarPrograma.FlatAppearance.BorderSize = 0;
            this.btnCerrarPrograma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPrograma.Location = new System.Drawing.Point(1872, 3);
            this.btnCerrarPrograma.Name = "btnCerrarPrograma";
            this.btnCerrarPrograma.Size = new System.Drawing.Size(36, 36);
            this.btnCerrarPrograma.TabIndex = 0;
            this.btnCerrarPrograma.UseVisualStyleBackColor = true;
            this.btnCerrarPrograma.Click += new System.EventHandler(this.btnCerrarPrograma_Click);
            // 
            // panLateral
            // 
            this.panLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(169)))));
            this.panLateral.Controls.Add(this.btnCambioTema);
            this.panLateral.Controls.Add(this.btnMenuPersonal);
            this.panLateral.Controls.Add(this.btnMenuRegistroPago);
            this.panLateral.Controls.Add(this.btnMenuIngresoNotas);
            this.panLateral.Controls.Add(this.btnMenuCursosDisponibles);
            this.panLateral.Controls.Add(this.btnMenuVistaMatricula);
            this.panLateral.Controls.Add(this.btnMenuMatriculaEstudiante);
            this.panLateral.Controls.Add(this.btnMenuAtras);
            this.panLateral.Controls.Add(this.picImagotipo);
            this.panLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLateral.Location = new System.Drawing.Point(0, 45);
            this.panLateral.Name = "panLateral";
            this.panLateral.Size = new System.Drawing.Size(285, 1035);
            this.panLateral.TabIndex = 1;
            this.panLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.panLateral_Paint);
            // 
            // btnCambioTema
            // 
            this.btnCambioTema.BackColor = System.Drawing.Color.Transparent;
            this.btnCambioTema.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources._1033;
            this.btnCambioTema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCambioTema.FlatAppearance.BorderSize = 0;
            this.btnCambioTema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCambioTema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCambioTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambioTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambioTema.ForeColor = System.Drawing.Color.Black;
            this.btnCambioTema.Location = new System.Drawing.Point(3, 991);
            this.btnCambioTema.Name = "btnCambioTema";
            this.btnCambioTema.Size = new System.Drawing.Size(43, 41);
            this.btnCambioTema.TabIndex = 8;
            this.btnCambioTema.UseVisualStyleBackColor = false;
            this.btnCambioTema.Click += new System.EventHandler(this.btnCambioTema_Click);
            // 
            // btnMenuPersonal
            // 
            this.btnMenuPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuPersonal.FlatAppearance.BorderSize = 0;
            this.btnMenuPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPersonal.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPersonal.ForeColor = System.Drawing.Color.Black;
            this.btnMenuPersonal.Location = new System.Drawing.Point(0, 556);
            this.btnMenuPersonal.Name = "btnMenuPersonal";
            this.btnMenuPersonal.Size = new System.Drawing.Size(285, 48);
            this.btnMenuPersonal.TabIndex = 7;
            this.btnMenuPersonal.Text = "PERSONAL";
            this.btnMenuPersonal.UseVisualStyleBackColor = false;
            this.btnMenuPersonal.Click += new System.EventHandler(this.btnMenuPersonal_Click);
            // 
            // btnMenuRegistroPago
            // 
            this.btnMenuRegistroPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuRegistroPago.FlatAppearance.BorderSize = 0;
            this.btnMenuRegistroPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRegistroPago.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRegistroPago.ForeColor = System.Drawing.Color.Black;
            this.btnMenuRegistroPago.Location = new System.Drawing.Point(0, 502);
            this.btnMenuRegistroPago.Name = "btnMenuRegistroPago";
            this.btnMenuRegistroPago.Size = new System.Drawing.Size(285, 48);
            this.btnMenuRegistroPago.TabIndex = 6;
            this.btnMenuRegistroPago.Text = "REGISTRAR PAGO";
            this.btnMenuRegistroPago.UseVisualStyleBackColor = false;
            this.btnMenuRegistroPago.Click += new System.EventHandler(this.btnMenuRegistroPago_Click);
            // 
            // btnMenuIngresoNotas
            // 
            this.btnMenuIngresoNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuIngresoNotas.FlatAppearance.BorderSize = 0;
            this.btnMenuIngresoNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuIngresoNotas.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuIngresoNotas.ForeColor = System.Drawing.Color.Black;
            this.btnMenuIngresoNotas.Location = new System.Drawing.Point(0, 448);
            this.btnMenuIngresoNotas.Name = "btnMenuIngresoNotas";
            this.btnMenuIngresoNotas.Size = new System.Drawing.Size(285, 48);
            this.btnMenuIngresoNotas.TabIndex = 5;
            this.btnMenuIngresoNotas.Text = "INGRESO DE NOTAS";
            this.btnMenuIngresoNotas.UseVisualStyleBackColor = false;
            this.btnMenuIngresoNotas.Click += new System.EventHandler(this.btnMenuIngresoNotas_Click);
            // 
            // btnMenuCursosDisponibles
            // 
            this.btnMenuCursosDisponibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuCursosDisponibles.FlatAppearance.BorderSize = 0;
            this.btnMenuCursosDisponibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCursosDisponibles.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCursosDisponibles.ForeColor = System.Drawing.Color.Black;
            this.btnMenuCursosDisponibles.Location = new System.Drawing.Point(0, 394);
            this.btnMenuCursosDisponibles.Name = "btnMenuCursosDisponibles";
            this.btnMenuCursosDisponibles.Size = new System.Drawing.Size(285, 48);
            this.btnMenuCursosDisponibles.TabIndex = 4;
            this.btnMenuCursosDisponibles.Text = "CURSOS DISPONIBLES";
            this.btnMenuCursosDisponibles.UseVisualStyleBackColor = false;
            this.btnMenuCursosDisponibles.Click += new System.EventHandler(this.btnMenuCursosDisponibles_Click);
            // 
            // btnMenuVistaMatricula
            // 
            this.btnMenuVistaMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuVistaMatricula.FlatAppearance.BorderSize = 0;
            this.btnMenuVistaMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuVistaMatricula.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuVistaMatricula.ForeColor = System.Drawing.Color.Black;
            this.btnMenuVistaMatricula.Location = new System.Drawing.Point(0, 340);
            this.btnMenuVistaMatricula.Name = "btnMenuVistaMatricula";
            this.btnMenuVistaMatricula.Size = new System.Drawing.Size(285, 48);
            this.btnMenuVistaMatricula.TabIndex = 3;
            this.btnMenuVistaMatricula.Text = "VISTA DE MATRICULAS";
            this.btnMenuVistaMatricula.UseVisualStyleBackColor = false;
            this.btnMenuVistaMatricula.Click += new System.EventHandler(this.btnMenuVistaMatricula_Click);
            // 
            // btnMenuMatriculaEstudiante
            // 
            this.btnMenuMatriculaEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuMatriculaEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenuMatriculaEstudiante.FlatAppearance.BorderSize = 0;
            this.btnMenuMatriculaEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMatriculaEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMatriculaEstudiante.ForeColor = System.Drawing.Color.Black;
            this.btnMenuMatriculaEstudiante.Location = new System.Drawing.Point(0, 286);
            this.btnMenuMatriculaEstudiante.Name = "btnMenuMatriculaEstudiante";
            this.btnMenuMatriculaEstudiante.Size = new System.Drawing.Size(285, 48);
            this.btnMenuMatriculaEstudiante.TabIndex = 2;
            this.btnMenuMatriculaEstudiante.Text = "MATRICULAR ESTUDIANTE";
            this.btnMenuMatriculaEstudiante.UseVisualStyleBackColor = false;
            this.btnMenuMatriculaEstudiante.Click += new System.EventHandler(this.btnMenuMatriculaEstudiante_Click);
            // 
            // btnMenuAtras
            // 
            this.btnMenuAtras.BackColor = System.Drawing.Color.Red;
            this.btnMenuAtras.FlatAppearance.BorderSize = 0;
            this.btnMenuAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAtras.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAtras.ForeColor = System.Drawing.Color.White;
            this.btnMenuAtras.Location = new System.Drawing.Point(0, 209);
            this.btnMenuAtras.Name = "btnMenuAtras";
            this.btnMenuAtras.Size = new System.Drawing.Size(285, 44);
            this.btnMenuAtras.TabIndex = 1;
            this.btnMenuAtras.Text = "ATRAS";
            this.btnMenuAtras.UseVisualStyleBackColor = false;
            this.btnMenuAtras.Click += new System.EventHandler(this.btnMenuAtras_Click);
            // 
            // picImagotipo
            // 
            this.picImagotipo.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.Logo_Nazaret;
            this.picImagotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picImagotipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picImagotipo.Location = new System.Drawing.Point(0, 0);
            this.picImagotipo.Name = "picImagotipo";
            this.picImagotipo.Size = new System.Drawing.Size(285, 182);
            this.picImagotipo.TabIndex = 0;
            this.picImagotipo.TabStop = false;
            this.picImagotipo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.panelPrincipal.Controls.Add(this.btnVistaMatriculas);
            this.panelPrincipal.Controls.Add(this.btnMatriEstudiante);
            this.panelPrincipal.Controls.Add(this.panSubMenuEstudiante);
            this.panelPrincipal.Controls.Add(this.panelMostrador);
            this.panelPrincipal.Controls.Add(this.panSubMenuPagos);
            this.panelPrincipal.Controls.Add(this.btnEstudiante);
            this.panelPrincipal.Controls.Add(this.btnIngresarNotas);
            this.panelPrincipal.Controls.Add(this.btnPagos);
            this.panelPrincipal.Controls.Add(this.btnCursos);
            this.panelPrincipal.Controls.Add(this.btnPersonal);
            this.panelPrincipal.Controls.Add(this.lblMenuTitle);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(285, 45);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(145, 3, 3, 3);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1635, 1035);
            this.panelPrincipal.TabIndex = 2;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panSubMenuEstudiante
            // 
            this.panSubMenuEstudiante.Controls.Add(this.btnFichaEstudiante);
            this.panSubMenuEstudiante.Controls.Add(this.btnHistorialCursos);
            this.panSubMenuEstudiante.Controls.Add(this.btnRegistrarVisitaMedica);
            this.panSubMenuEstudiante.Controls.Add(this.btnHistorialMedico);
            this.panSubMenuEstudiante.Controls.Add(this.label2);
            this.panSubMenuEstudiante.Location = new System.Drawing.Point(1124, 370);
            this.panSubMenuEstudiante.Name = "panSubMenuEstudiante";
            this.panSubMenuEstudiante.Size = new System.Drawing.Size(435, 153);
            this.panSubMenuEstudiante.TabIndex = 26;
            // 
            // btnFichaEstudiante
            // 
            this.btnFichaEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnFichaEstudiante.Enabled = false;
            this.btnFichaEstudiante.FlatAppearance.BorderSize = 0;
            this.btnFichaEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFichaEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFichaEstudiante.ForeColor = System.Drawing.Color.Black;
            this.btnFichaEstudiante.Location = new System.Drawing.Point(615, 665);
            this.btnFichaEstudiante.Name = "btnFichaEstudiante";
            this.btnFichaEstudiante.Size = new System.Drawing.Size(407, 200);
            this.btnFichaEstudiante.TabIndex = 30;
            this.btnFichaEstudiante.Text = "FICHA DE ESTUDIANTE";
            this.btnFichaEstudiante.UseVisualStyleBackColor = false;
            // 
            // btnHistorialCursos
            // 
            this.btnHistorialCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnHistorialCursos.Enabled = false;
            this.btnHistorialCursos.FlatAppearance.BorderSize = 0;
            this.btnHistorialCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialCursos.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialCursos.ForeColor = System.Drawing.Color.Black;
            this.btnHistorialCursos.Location = new System.Drawing.Point(1130, 357);
            this.btnHistorialCursos.Name = "btnHistorialCursos";
            this.btnHistorialCursos.Size = new System.Drawing.Size(407, 200);
            this.btnHistorialCursos.TabIndex = 29;
            this.btnHistorialCursos.Text = "HISTORIAL DE CURSOS ";
            this.btnHistorialCursos.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarVisitaMedica
            // 
            this.btnRegistrarVisitaMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnRegistrarVisitaMedica.Enabled = false;
            this.btnRegistrarVisitaMedica.FlatAppearance.BorderSize = 0;
            this.btnRegistrarVisitaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVisitaMedica.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVisitaMedica.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarVisitaMedica.Location = new System.Drawing.Point(615, 357);
            this.btnRegistrarVisitaMedica.Name = "btnRegistrarVisitaMedica";
            this.btnRegistrarVisitaMedica.Size = new System.Drawing.Size(407, 200);
            this.btnRegistrarVisitaMedica.TabIndex = 28;
            this.btnRegistrarVisitaMedica.Text = "REGISTRAR VISITA MEDICA";
            this.btnRegistrarVisitaMedica.UseVisualStyleBackColor = false;
            // 
            // btnHistorialMedico
            // 
            this.btnHistorialMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnHistorialMedico.Enabled = false;
            this.btnHistorialMedico.FlatAppearance.BorderSize = 0;
            this.btnHistorialMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialMedico.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialMedico.ForeColor = System.Drawing.Color.Black;
            this.btnHistorialMedico.Location = new System.Drawing.Point(98, 357);
            this.btnHistorialMedico.Name = "btnHistorialMedico";
            this.btnHistorialMedico.Size = new System.Drawing.Size(407, 200);
            this.btnHistorialMedico.TabIndex = 27;
            this.btnHistorialMedico.Text = "HISTORIAL MEDICO";
            this.btnHistorialMedico.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Balsamiq Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(697, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 36);
            this.label2.TabIndex = 26;
            this.label2.Text = "ESTUDIANTES";
            // 
            // panelMostrador
            // 
            this.panelMostrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.panelMostrador.Location = new System.Drawing.Point(76, 677);
            this.panelMostrador.Name = "panelMostrador";
            this.panelMostrador.Size = new System.Drawing.Size(484, 187);
            this.panelMostrador.TabIndex = 39;
            this.panelMostrador.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMostrador_Paint);
            // 
            // panSubMenuPagos
            // 
            this.panSubMenuPagos.Controls.Add(this.btnHistorialPagos);
            this.panSubMenuPagos.Controls.Add(this.btnRegistrarPago);
            this.panSubMenuPagos.Controls.Add(this.label1);
            this.panSubMenuPagos.Location = new System.Drawing.Point(1144, 729);
            this.panSubMenuPagos.Name = "panSubMenuPagos";
            this.panSubMenuPagos.Size = new System.Drawing.Size(435, 153);
            this.panSubMenuPagos.TabIndex = 0;
            // 
            // btnHistorialPagos
            // 
            this.btnHistorialPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnHistorialPagos.FlatAppearance.BorderSize = 0;
            this.btnHistorialPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialPagos.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialPagos.ForeColor = System.Drawing.Color.Black;
            this.btnHistorialPagos.Location = new System.Drawing.Point(967, 394);
            this.btnHistorialPagos.Name = "btnHistorialPagos";
            this.btnHistorialPagos.Size = new System.Drawing.Size(407, 200);
            this.btnHistorialPagos.TabIndex = 25;
            this.btnHistorialPagos.Text = "HISTORIAL DE PAGOS";
            this.btnHistorialPagos.UseVisualStyleBackColor = false;
            this.btnHistorialPagos.Click += new System.EventHandler(this.btnHistorialPagos_Click);
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnRegistrarPago.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPago.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPago.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarPago.Location = new System.Drawing.Point(248, 407);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(407, 200);
            this.btnRegistrarPago.TabIndex = 24;
            this.btnRegistrarPago.Text = "REGISTRAR PAGO";
            this.btnRegistrarPago.UseVisualStyleBackColor = false;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(742, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = " PAGOS";
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.btnEstudiante.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.button2;
            this.btnEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEstudiante.FlatAppearance.BorderSize = 0;
            this.btnEstudiante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiante.ForeColor = System.Drawing.Color.Black;
            this.btnEstudiante.Location = new System.Drawing.Point(649, 751);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(353, 155);
            this.btnEstudiante.TabIndex = 38;
            this.btnEstudiante.Text = "ESTUDIANTES";
            this.btnEstudiante.UseVisualStyleBackColor = false;
            this.btnEstudiante.Click += new System.EventHandler(this.btnEstudiante_Click);
            // 
            // btnIngresarNotas
            // 
            this.btnIngresarNotas.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresarNotas.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.button2;
            this.btnIngresarNotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIngresarNotas.FlatAppearance.BorderSize = 0;
            this.btnIngresarNotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIngresarNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIngresarNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarNotas.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarNotas.ForeColor = System.Drawing.Color.Black;
            this.btnIngresarNotas.Location = new System.Drawing.Point(1178, 483);
            this.btnIngresarNotas.Name = "btnIngresarNotas";
            this.btnIngresarNotas.Size = new System.Drawing.Size(353, 155);
            this.btnIngresarNotas.TabIndex = 37;
            this.btnIngresarNotas.Text = "INGRESAR NOTAS";
            this.btnIngresarNotas.UseVisualStyleBackColor = false;
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.Transparent;
            this.btnPagos.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.button2;
            this.btnPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.Black;
            this.btnPagos.Location = new System.Drawing.Point(641, 483);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(353, 155);
            this.btnPagos.TabIndex = 36;
            this.btnPagos.Text = "PAGOS";
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.BackColor = System.Drawing.Color.Transparent;
            this.btnCursos.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.button2;
            this.btnCursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCursos.FlatAppearance.BorderSize = 0;
            this.btnCursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.ForeColor = System.Drawing.Color.Black;
            this.btnCursos.Location = new System.Drawing.Point(1178, 209);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(353, 155);
            this.btnCursos.TabIndex = 35;
            this.btnCursos.Text = "CURSOS";
            this.btnCursos.UseVisualStyleBackColor = false;
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonal.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.button2;
            this.btnPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.ForeColor = System.Drawing.Color.Black;
            this.btnPersonal.Location = new System.Drawing.Point(103, 483);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(353, 155);
            this.btnPersonal.TabIndex = 34;
            this.btnPersonal.Text = "PERSONAL";
            this.btnPersonal.UseVisualStyleBackColor = false;
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Balsamiq Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.ForeColor = System.Drawing.Color.White;
            this.lblMenuTitle.Location = new System.Drawing.Point(669, 92);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(299, 36);
            this.lblMenuTitle.TabIndex = 32;
            this.lblMenuTitle.Text = "MENU PRINCIPAL";
            // 
            // tmrOcultarMenu
            // 
            this.tmrOcultarMenu.Interval = 2;
            this.tmrOcultarMenu.Tick += new System.EventHandler(this.tmrOcultarMenu_Tick);
            // 
            // tmrMostrarMenu
            // 
            this.tmrMostrarMenu.Interval = 2;
            this.tmrMostrarMenu.Tick += new System.EventHandler(this.tmrMostrarMenu_Tick);
            // 
            // btnMatriEstudiante
            // 
            this.btnMatriEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMatriEstudiante.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(169)))));
            this.btnMatriEstudiante.BorderDownColor = System.Drawing.Color.Empty;
            this.btnMatriEstudiante.BorderDownWidth = 3F;
            this.btnMatriEstudiante.BorderOverColor = System.Drawing.Color.Empty;
            this.btnMatriEstudiante.BorderOverWidth = 0F;
            this.btnMatriEstudiante.BorderRadius = 30;
            this.btnMatriEstudiante.BorderWidth = 4F;
            this.btnMatriEstudiante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMatriEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(177)))), ((int)(((byte)(223)))));
            this.btnMatriEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMatriEstudiante.Location = new System.Drawing.Point(103, 214);
            this.btnMatriEstudiante.Name = "btnMatriEstudiante";
            this.btnMatriEstudiante.Size = new System.Drawing.Size(353, 146);
            this.btnMatriEstudiante.TabIndex = 41;
            this.btnMatriEstudiante.Text = "MATRICULAR ESTUDIANTE";
            this.btnMatriEstudiante.UseVisualStyleBackColor = false;
            this.btnMatriEstudiante.Click += new System.EventHandler(this.roundedButton1_Click_1);
            this.btnMatriEstudiante.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundedButton1_MouseDown);
            // 
            // btnVistaMatriculas
            // 
            this.btnVistaMatriculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnVistaMatriculas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(169)))));
            this.btnVistaMatriculas.BorderDownColor = System.Drawing.Color.Empty;
            this.btnVistaMatriculas.BorderDownWidth = 3F;
            this.btnVistaMatriculas.BorderOverColor = System.Drawing.Color.Empty;
            this.btnVistaMatriculas.BorderOverWidth = 0F;
            this.btnVistaMatriculas.BorderRadius = 30;
            this.btnVistaMatriculas.BorderWidth = 4F;
            this.btnVistaMatriculas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVistaMatriculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(177)))), ((int)(((byte)(223)))));
            this.btnVistaMatriculas.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnVistaMatriculas.Location = new System.Drawing.Point(641, 209);
            this.btnVistaMatriculas.Name = "btnVistaMatriculas";
            this.btnVistaMatriculas.Size = new System.Drawing.Size(353, 146);
            this.btnVistaMatriculas.TabIndex = 42;
            this.btnVistaMatriculas.Text = "VISTA DE MATRICULAS";
            this.btnVistaMatriculas.UseVisualStyleBackColor = false;
            // 
            // InterfazGraficaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panLateral);
            this.Controls.Add(this.panSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazGraficaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfazGraficaPrincipal";
            this.Load += new System.EventHandler(this.InterfazGraficaPrincipal_Load);
            this.panSuperior.ResumeLayout(false);
            this.panLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagotipo)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.panSubMenuEstudiante.ResumeLayout(false);
            this.panSubMenuEstudiante.PerformLayout();
            this.panSubMenuPagos.ResumeLayout(false);
            this.panSubMenuPagos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSuperior;
        private System.Windows.Forms.Panel panLateral;
        private System.Windows.Forms.PictureBox picImagotipo;
        private System.Windows.Forms.Button btnMenuAtras;
        private System.Windows.Forms.Button btnMenuPersonal;
        private System.Windows.Forms.Button btnMenuRegistroPago;
        private System.Windows.Forms.Button btnMenuIngresoNotas;
        private System.Windows.Forms.Button btnMenuCursosDisponibles;
        private System.Windows.Forms.Button btnMenuVistaMatricula;
        private System.Windows.Forms.Button btnMenuMatriculaEstudiante;
        private System.Windows.Forms.Timer tmrOcultarMenu;
        private System.Windows.Forms.Timer tmrMostrarMenu;
        private System.Windows.Forms.Button btnCerrarPrograma;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        public System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnEstudiante;
        private System.Windows.Forms.Button btnIngresarNotas;
        public System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Panel panelMostrador;
        private System.Windows.Forms.Panel panSubMenuPagos;
        private System.Windows.Forms.Button btnHistorialPagos;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panSubMenuEstudiante;
        private System.Windows.Forms.Button btnFichaEstudiante;
        private System.Windows.Forms.Button btnHistorialCursos;
        private System.Windows.Forms.Button btnRegistrarVisitaMedica;
        private System.Windows.Forms.Button btnHistorialMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCambioTema;
        private BrbVideoManager.Controls.RoundedButton btnMatriEstudiante;
        private BrbVideoManager.Controls.RoundedButton btnVistaMatriculas;
    }
}