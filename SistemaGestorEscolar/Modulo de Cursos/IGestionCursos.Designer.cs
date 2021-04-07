
namespace SistemaGestorEscolar.Modulo_de_Cursos
{
    partial class IGestionCursos
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
            this.grbPrincipal = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCursos = new System.Windows.Forms.Label();
            this.grbDgv = new System.Windows.Forms.GroupBox();
            this.dgvCursosInactivos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.grbSeccionesCont = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.cmbDocentes = new System.Windows.Forms.ComboBox();
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.lblSecciones = new System.Windows.Forms.Label();
            this.dgvSecciones = new System.Windows.Forms.DataGridView();
            this.grbDgvSecciones = new System.Windows.Forms.GroupBox();
            this.dgvSeccionesInac = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdSeccion = new System.Windows.Forms.TextBox();
            this.txtNombreDoce = new System.Windows.Forms.TextBox();
            this.btnVerSeccAct = new AltoControls.AltoButton();
            this.btnVerSeccIna = new AltoControls.AltoButton();
            this.btnActualizarSecc = new AltoControls.AltoButton();
            this.btnRegistrarSecc = new AltoControls.AltoButton();
            this.btnRegresar = new AltoControls.AltoButton();
            this.btnActivos = new AltoControls.AltoButton();
            this.btnInactivos = new AltoControls.AltoButton();
            this.btnAgregarSeccion = new AltoControls.AltoButton();
            this.btnEliminar = new AltoControls.AltoButton();
            this.btnActualizarCurso = new AltoControls.AltoButton();
            this.btnRegistrarCurso = new AltoControls.AltoButton();
            this.grbPrincipal.SuspendLayout();
            this.grbDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosInactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.grbSeccionesCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecciones)).BeginInit();
            this.grbDgvSecciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccionesInac)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPrincipal
            // 
            this.grbPrincipal.Controls.Add(this.btnAgregarSeccion);
            this.grbPrincipal.Controls.Add(this.label5);
            this.grbPrincipal.Controls.Add(this.txtIdCurso);
            this.grbPrincipal.Controls.Add(this.btnEliminar);
            this.grbPrincipal.Controls.Add(this.btnActualizarCurso);
            this.grbPrincipal.Controls.Add(this.btnRegistrarCurso);
            this.grbPrincipal.Controls.Add(this.txtNombreCurso);
            this.grbPrincipal.Controls.Add(this.label4);
            this.grbPrincipal.Controls.Add(this.txtPrecio);
            this.grbPrincipal.Controls.Add(this.label3);
            this.grbPrincipal.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPrincipal.Location = new System.Drawing.Point(32, 140);
            this.grbPrincipal.Name = "grbPrincipal";
            this.grbPrincipal.Size = new System.Drawing.Size(861, 840);
            this.grbPrincipal.TabIndex = 0;
            this.grbPrincipal.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Curso";
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Location = new System.Drawing.Point(226, 290);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.ReadOnly = true;
            this.txtIdCurso.Size = new System.Drawing.Size(100, 31);
            this.txtIdCurso.TabIndex = 11;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(226, 386);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(232, 31);
            this.txtNombreCurso.TabIndex = 6;
            this.txtNombreCurso.TextChanged += new System.EventHandler(this.txtNombreCurso_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre curso";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(226, 484);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(232, 31);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.Font = new System.Drawing.Font("Balsamiq Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursos.Location = new System.Drawing.Point(626, 54);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(360, 41);
            this.lblCursos.TabIndex = 1;
            this.lblCursos.Text = "GESTIÓN DE CURSOS";
            this.lblCursos.Visible = false;
            // 
            // grbDgv
            // 
            this.grbDgv.Controls.Add(this.btnActivos);
            this.grbDgv.Controls.Add(this.btnInactivos);
            this.grbDgv.Controls.Add(this.dgvCursosInactivos);
            this.grbDgv.Controls.Add(this.label2);
            this.grbDgv.Controls.Add(this.dgvCursos);
            this.grbDgv.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDgv.Location = new System.Drawing.Point(908, 140);
            this.grbDgv.Name = "grbDgv";
            this.grbDgv.Size = new System.Drawing.Size(715, 840);
            this.grbDgv.TabIndex = 3;
            this.grbDgv.TabStop = false;
            // 
            // dgvCursosInactivos
            // 
            this.dgvCursosInactivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursosInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursosInactivos.Location = new System.Drawing.Point(50, 184);
            this.dgvCursosInactivos.Name = "dgvCursosInactivos";
            this.dgvCursosInactivos.ReadOnly = true;
            this.dgvCursosInactivos.Size = new System.Drawing.Size(629, 628);
            this.dgvCursosInactivos.TabIndex = 5;
            this.dgvCursosInactivos.Visible = false;
            this.dgvCursosInactivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursosInactivos_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Balsamiq Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cursos";
            // 
            // dgvCursos
            // 
            this.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(50, 184);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.Size = new System.Drawing.Size(629, 628);
            this.dgvCursos.TabIndex = 0;
            this.dgvCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellClick);
            // 
            // grbSeccionesCont
            // 
            this.grbSeccionesCont.Controls.Add(this.txtNombreDoce);
            this.grbSeccionesCont.Controls.Add(this.txtIdSeccion);
            this.grbSeccionesCont.Controls.Add(this.label8);
            this.grbSeccionesCont.Controls.Add(this.label7);
            this.grbSeccionesCont.Controls.Add(this.label6);
            this.grbSeccionesCont.Controls.Add(this.label1);
            this.grbSeccionesCont.Controls.Add(this.btnActualizarSecc);
            this.grbSeccionesCont.Controls.Add(this.btnRegistrarSecc);
            this.grbSeccionesCont.Controls.Add(this.txtSeccion);
            this.grbSeccionesCont.Controls.Add(this.cmbDocentes);
            this.grbSeccionesCont.Controls.Add(this.cmbCursos);
            this.grbSeccionesCont.Controls.Add(this.btnRegresar);
            this.grbSeccionesCont.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSeccionesCont.Location = new System.Drawing.Point(32, 139);
            this.grbSeccionesCont.Name = "grbSeccionesCont";
            this.grbSeccionesCont.Size = new System.Drawing.Size(861, 884);
            this.grbSeccionesCont.TabIndex = 4;
            this.grbSeccionesCont.TabStop = false;
            this.grbSeccionesCont.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Docentes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cursos:";
            // 
            // txtSeccion
            // 
            this.txtSeccion.Location = new System.Drawing.Point(164, 302);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(209, 33);
            this.txtSeccion.TabIndex = 4;
            this.txtSeccion.TextChanged += new System.EventHandler(this.txtSeccion_TextChanged);
            // 
            // cmbDocentes
            // 
            this.cmbDocentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocentes.FormattingEnabled = true;
            this.cmbDocentes.Location = new System.Drawing.Point(164, 499);
            this.cmbDocentes.Name = "cmbDocentes";
            this.cmbDocentes.Size = new System.Drawing.Size(266, 34);
            this.cmbDocentes.TabIndex = 3;
            this.cmbDocentes.SelectedIndexChanged += new System.EventHandler(this.cmbDocentes_SelectedIndexChanged);
            // 
            // cmbCursos
            // 
            this.cmbCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Location = new System.Drawing.Point(164, 399);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(266, 34);
            this.cmbCursos.TabIndex = 1;
            // 
            // lblSecciones
            // 
            this.lblSecciones.AutoSize = true;
            this.lblSecciones.Font = new System.Drawing.Font("Balsamiq Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecciones.Location = new System.Drawing.Point(592, 54);
            this.lblSecciones.Name = "lblSecciones";
            this.lblSecciones.Size = new System.Drawing.Size(412, 41);
            this.lblSecciones.TabIndex = 5;
            this.lblSecciones.Text = "GESTIÓN DE SECCIONES";
            this.lblSecciones.Visible = false;
            // 
            // dgvSecciones
            // 
            this.dgvSecciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecciones.Location = new System.Drawing.Point(71, 161);
            this.dgvSecciones.Name = "dgvSecciones";
            this.dgvSecciones.ReadOnly = true;
            this.dgvSecciones.Size = new System.Drawing.Size(585, 551);
            this.dgvSecciones.TabIndex = 2;
            this.dgvSecciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSecciones_CellClick);
            // 
            // grbDgvSecciones
            // 
            this.grbDgvSecciones.Controls.Add(this.dgvSeccionesInac);
            this.grbDgvSecciones.Controls.Add(this.btnVerSeccAct);
            this.grbDgvSecciones.Controls.Add(this.btnVerSeccIna);
            this.grbDgvSecciones.Controls.Add(this.dgvSecciones);
            this.grbDgvSecciones.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDgvSecciones.Location = new System.Drawing.Point(908, 139);
            this.grbDgvSecciones.Name = "grbDgvSecciones";
            this.grbDgvSecciones.Size = new System.Drawing.Size(715, 884);
            this.grbDgvSecciones.TabIndex = 6;
            this.grbDgvSecciones.TabStop = false;
            this.grbDgvSecciones.Visible = false;
            // 
            // dgvSeccionesInac
            // 
            this.dgvSeccionesInac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeccionesInac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeccionesInac.Location = new System.Drawing.Point(71, 161);
            this.dgvSeccionesInac.Name = "dgvSeccionesInac";
            this.dgvSeccionesInac.ReadOnly = true;
            this.dgvSeccionesInac.Size = new System.Drawing.Size(585, 551);
            this.dgvSeccionesInac.TabIndex = 5;
            this.dgvSeccionesInac.Visible = false;
            this.dgvSeccionesInac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeccionesInac_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 26);
            this.label8.TabIndex = 10;
            this.label8.Text = "Id sección:";
            // 
            // txtIdSeccion
            // 
            this.txtIdSeccion.Location = new System.Drawing.Point(164, 224);
            this.txtIdSeccion.Name = "txtIdSeccion";
            this.txtIdSeccion.ReadOnly = true;
            this.txtIdSeccion.Size = new System.Drawing.Size(114, 33);
            this.txtIdSeccion.TabIndex = 11;
            // 
            // txtNombreDoce
            // 
            this.txtNombreDoce.Location = new System.Drawing.Point(446, 500);
            this.txtNombreDoce.Name = "txtNombreDoce";
            this.txtNombreDoce.ReadOnly = true;
            this.txtNombreDoce.Size = new System.Drawing.Size(290, 33);
            this.txtNombreDoce.TabIndex = 12;
            // 
            // btnVerSeccAct
            // 
            this.btnVerSeccAct.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnVerSeccAct.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnVerSeccAct.BackColor = System.Drawing.Color.Transparent;
            this.btnVerSeccAct.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVerSeccAct.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSeccAct.ForeColor = System.Drawing.Color.Black;
            this.btnVerSeccAct.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btnVerSeccAct.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btnVerSeccAct.Location = new System.Drawing.Point(499, 109);
            this.btnVerSeccAct.Name = "btnVerSeccAct";
            this.btnVerSeccAct.Radius = 10;
            this.btnVerSeccAct.Size = new System.Drawing.Size(157, 46);
            this.btnVerSeccAct.Stroke = false;
            this.btnVerSeccAct.StrokeColor = System.Drawing.Color.Gray;
            this.btnVerSeccAct.TabIndex = 4;
            this.btnVerSeccAct.Text = "Ver activas";
            this.btnVerSeccAct.Transparency = false;
            this.btnVerSeccAct.Click += new System.EventHandler(this.btnVerSeccAct_Click);
            // 
            // btnVerSeccIna
            // 
            this.btnVerSeccIna.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnVerSeccIna.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnVerSeccIna.BackColor = System.Drawing.Color.Transparent;
            this.btnVerSeccIna.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVerSeccIna.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSeccIna.ForeColor = System.Drawing.Color.Black;
            this.btnVerSeccIna.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btnVerSeccIna.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btnVerSeccIna.Location = new System.Drawing.Point(499, 109);
            this.btnVerSeccIna.Name = "btnVerSeccIna";
            this.btnVerSeccIna.Radius = 10;
            this.btnVerSeccIna.Size = new System.Drawing.Size(157, 46);
            this.btnVerSeccIna.Stroke = false;
            this.btnVerSeccIna.StrokeColor = System.Drawing.Color.Gray;
            this.btnVerSeccIna.TabIndex = 3;
            this.btnVerSeccIna.Text = "Ver inactivas";
            this.btnVerSeccIna.Transparency = false;
            this.btnVerSeccIna.Visible = false;
            this.btnVerSeccIna.Click += new System.EventHandler(this.btnVerSeccIna_Click);
            // 
            // btnActualizarSecc
            // 
            this.btnActualizarSecc.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnActualizarSecc.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnActualizarSecc.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarSecc.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnActualizarSecc.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarSecc.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarSecc.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btnActualizarSecc.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btnActualizarSecc.Location = new System.Drawing.Point(611, 332);
            this.btnActualizarSecc.Name = "btnActualizarSecc";
            this.btnActualizarSecc.Radius = 10;
            this.btnActualizarSecc.Size = new System.Drawing.Size(197, 58);
            this.btnActualizarSecc.Stroke = false;
            this.btnActualizarSecc.StrokeColor = System.Drawing.Color.Gray;
            this.btnActualizarSecc.TabIndex = 6;
            this.btnActualizarSecc.Text = "ACTUALIZAR";
            this.btnActualizarSecc.Transparency = false;
            this.btnActualizarSecc.Click += new System.EventHandler(this.btnActualizarSecc_Click);
            // 
            // btnRegistrarSecc
            // 
            this.btnRegistrarSecc.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnRegistrarSecc.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnRegistrarSecc.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarSecc.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRegistrarSecc.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarSecc.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarSecc.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btnRegistrarSecc.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btnRegistrarSecc.Location = new System.Drawing.Point(611, 211);
            this.btnRegistrarSecc.Name = "btnRegistrarSecc";
            this.btnRegistrarSecc.Radius = 10;
            this.btnRegistrarSecc.Size = new System.Drawing.Size(197, 58);
            this.btnRegistrarSecc.Stroke = false;
            this.btnRegistrarSecc.StrokeColor = System.Drawing.Color.Gray;
            this.btnRegistrarSecc.TabIndex = 5;
            this.btnRegistrarSecc.Text = "REGISTRAR";
            this.btnRegistrarSecc.Transparency = false;
            this.btnRegistrarSecc.Click += new System.EventHandler(this.btnRegistrarSecc_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnRegresar.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRegresar.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.Black;
            this.btnRegresar.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btnRegresar.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btnRegresar.Location = new System.Drawing.Point(36, 801);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Radius = 10;
            this.btnRegresar.Size = new System.Drawing.Size(198, 54);
            this.btnRegresar.Stroke = false;
            this.btnRegresar.StrokeColor = System.Drawing.Color.Gray;
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Transparency = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnActivos
            // 
            this.btnActivos.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnActivos.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnActivos.BackColor = System.Drawing.Color.Transparent;
            this.btnActivos.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnActivos.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivos.ForeColor = System.Drawing.Color.Black;
            this.btnActivos.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btnActivos.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btnActivos.Location = new System.Drawing.Point(507, 132);
            this.btnActivos.Name = "btnActivos";
            this.btnActivos.Radius = 10;
            this.btnActivos.Size = new System.Drawing.Size(172, 46);
            this.btnActivos.Stroke = false;
            this.btnActivos.StrokeColor = System.Drawing.Color.Gray;
            this.btnActivos.TabIndex = 8;
            this.btnActivos.Text = "Ver Activos";
            this.btnActivos.Transparency = false;
            this.btnActivos.Visible = false;
            this.btnActivos.Click += new System.EventHandler(this.btnActivos_Click);
            // 
            // btnInactivos
            // 
            this.btnInactivos.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnInactivos.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnInactivos.BackColor = System.Drawing.Color.Transparent;
            this.btnInactivos.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInactivos.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactivos.ForeColor = System.Drawing.Color.Black;
            this.btnInactivos.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btnInactivos.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btnInactivos.Location = new System.Drawing.Point(507, 132);
            this.btnInactivos.Name = "btnInactivos";
            this.btnInactivos.Radius = 10;
            this.btnInactivos.Size = new System.Drawing.Size(172, 46);
            this.btnInactivos.Stroke = false;
            this.btnInactivos.StrokeColor = System.Drawing.Color.Gray;
            this.btnInactivos.TabIndex = 7;
            this.btnInactivos.Text = "Ver Inactivos";
            this.btnInactivos.Transparency = false;
            this.btnInactivos.Click += new System.EventHandler(this.btnInactivos_Click);
            // 
            // btnAgregarSeccion
            // 
            this.btnAgregarSeccion.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnAgregarSeccion.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnAgregarSeccion.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarSeccion.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarSeccion.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSeccion.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarSeccion.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btnAgregarSeccion.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btnAgregarSeccion.Location = new System.Drawing.Point(140, 617);
            this.btnAgregarSeccion.Name = "btnAgregarSeccion";
            this.btnAgregarSeccion.Radius = 10;
            this.btnAgregarSeccion.Size = new System.Drawing.Size(258, 45);
            this.btnAgregarSeccion.Stroke = false;
            this.btnAgregarSeccion.StrokeColor = System.Drawing.Color.Gray;
            this.btnAgregarSeccion.TabIndex = 13;
            this.btnAgregarSeccion.Text = "Agregar sección";
            this.btnAgregarSeccion.Transparency = false;
            this.btnAgregarSeccion.Click += new System.EventHandler(this.btnAgregarSeccion_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnEliminar.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminar.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btnEliminar.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btnEliminar.Location = new System.Drawing.Point(567, 491);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Radius = 10;
            this.btnEliminar.Size = new System.Drawing.Size(241, 58);
            this.btnEliminar.Stroke = false;
            this.btnEliminar.StrokeColor = System.Drawing.Color.Gray;
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Transparency = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizarCurso
            // 
            this.btnActualizarCurso.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnActualizarCurso.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnActualizarCurso.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarCurso.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnActualizarCurso.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCurso.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarCurso.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btnActualizarCurso.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btnActualizarCurso.Location = new System.Drawing.Point(567, 376);
            this.btnActualizarCurso.Name = "btnActualizarCurso";
            this.btnActualizarCurso.Radius = 10;
            this.btnActualizarCurso.Size = new System.Drawing.Size(241, 58);
            this.btnActualizarCurso.Stroke = false;
            this.btnActualizarCurso.StrokeColor = System.Drawing.Color.Gray;
            this.btnActualizarCurso.TabIndex = 9;
            this.btnActualizarCurso.Text = "Actualizar";
            this.btnActualizarCurso.Transparency = false;
            this.btnActualizarCurso.Click += new System.EventHandler(this.btnActualizarCurso_Click);
            // 
            // btnRegistrarCurso
            // 
            this.btnRegistrarCurso.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.btnRegistrarCurso.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.btnRegistrarCurso.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarCurso.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRegistrarCurso.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCurso.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarCurso.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.btnRegistrarCurso.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.btnRegistrarCurso.Location = new System.Drawing.Point(567, 263);
            this.btnRegistrarCurso.Name = "btnRegistrarCurso";
            this.btnRegistrarCurso.Radius = 10;
            this.btnRegistrarCurso.Size = new System.Drawing.Size(241, 58);
            this.btnRegistrarCurso.Stroke = false;
            this.btnRegistrarCurso.StrokeColor = System.Drawing.Color.Gray;
            this.btnRegistrarCurso.TabIndex = 8;
            this.btnRegistrarCurso.Text = "Registrar";
            this.btnRegistrarCurso.Transparency = false;
            this.btnRegistrarCurso.Click += new System.EventHandler(this.btnRegistrarCurso_Click);
            // 
            // IGestionCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1635, 1035);
            this.Controls.Add(this.grbDgvSecciones);
            this.Controls.Add(this.lblSecciones);
            this.Controls.Add(this.grbSeccionesCont);
            this.Controls.Add(this.grbDgv);
            this.Controls.Add(this.grbPrincipal);
            this.Controls.Add(this.lblCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IGestionCursos";
            this.Text = "IGestionCursos";
            this.Load += new System.EventHandler(this.IGestionCursos_Load);
            this.grbPrincipal.ResumeLayout(false);
            this.grbPrincipal.PerformLayout();
            this.grbDgv.ResumeLayout(false);
            this.grbDgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosInactivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.grbSeccionesCont.ResumeLayout(false);
            this.grbSeccionesCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecciones)).EndInit();
            this.grbDgvSecciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeccionesInac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPrincipal;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.GroupBox grbDgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCursos;
        private AltoControls.AltoButton btnEliminar;
        private AltoControls.AltoButton btnActualizarCurso;
        private AltoControls.AltoButton btnRegistrarCurso;
        private System.Windows.Forms.DataGridView dgvCursosInactivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdCurso;
        private AltoControls.AltoButton btnInactivos;
        private AltoControls.AltoButton btnActivos;
        private System.Windows.Forms.GroupBox grbSeccionesCont;
        private AltoControls.AltoButton btnAgregarSeccion;
        private System.Windows.Forms.Label lblSecciones;
        private AltoControls.AltoButton btnRegresar;
        private System.Windows.Forms.DataGridView dgvSecciones;
        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.ComboBox cmbDocentes;
        private AltoControls.AltoButton btnRegistrarSecc;
        private System.Windows.Forms.GroupBox grbDgvSecciones;
        private AltoControls.AltoButton btnActualizarSecc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private AltoControls.AltoButton btnVerSeccAct;
        private AltoControls.AltoButton btnVerSeccIna;
        private System.Windows.Forms.DataGridView dgvSeccionesInac;
        private System.Windows.Forms.TextBox txtIdSeccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreDoce;
    }
}