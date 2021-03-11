
namespace SistemaGestorEscolar.Modulos_Encargado
{
    partial class IAñadirEncargado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbEncargados = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblregistroEncargado = new System.Windows.Forms.Label();
            this.txtfechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.txtsegundoNombre = new System.Windows.Forms.TextBox();
            this.txtprimerTelefono = new System.Windows.Forms.TextBox();
            this.lblnumeroIdentidad = new System.Windows.Forms.Label();
            this.txtsegundoTelefono = new System.Windows.Forms.TextBox();
            this.lblnombres = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblfechaNacimiento = new System.Windows.Forms.Label();
            this.txtprimerApellido = new System.Windows.Forms.TextBox();
            this.lbltelefonos = new System.Windows.Forms.Label();
            this.txtprimerNombre = new System.Windows.Forms.TextBox();
            this.lblcorreoElectronico = new System.Windows.Forms.Label();
            this.txtsegundoApellido = new System.Windows.Forms.TextBox();
            this.lblGestionEncargadosEstudiantes = new System.Windows.Forms.Label();
            this.gbListadoEncargado = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBusquedaNombreEncargado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBusquedaIdentidadEncargado = new System.Windows.Forms.TextBox();
            this.dgvBusquedaEncargado = new System.Windows.Forms.DataGridView();
            this.txtIdentidad = new System.Windows.Forms.MaskedTextBox();
            this.btnEliminar = new AltoControls.AltoButton();
            this.btnRegresarEncargado = new AltoControls.AltoButton();
            this.btnActualizar = new AltoControls.AltoButton();
            this.btnEncargados = new AltoControls.AltoButton();
            this.btnEstudiantes = new AltoControls.AltoButton();
            this.btnSiguienteEncargado = new AltoControls.AltoButton();
            this.btnRegresar = new AltoControls.AltoButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentidad)).BeginInit();
            this.gbEncargados.SuspendLayout();
            this.gbListadoEncargado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaEncargado)).BeginInit();
            this.SuspendLayout();
            // 
            // errorIdentidad
            // 
            this.errorIdentidad.ContainerControl = this;
            // 
            // gbEncargados
            // 
            this.gbEncargados.Controls.Add(this.txtIdentidad);
            this.gbEncargados.Controls.Add(this.label1);
            this.gbEncargados.Controls.Add(this.txtCorreoElectronico);
            this.gbEncargados.Controls.Add(this.btnEliminar);
            this.gbEncargados.Controls.Add(this.btnRegresarEncargado);
            this.gbEncargados.Controls.Add(this.btnActualizar);
            this.gbEncargados.Controls.Add(this.lblregistroEncargado);
            this.gbEncargados.Controls.Add(this.txtfechaNacimiento);
            this.gbEncargados.Controls.Add(this.txtsegundoNombre);
            this.gbEncargados.Controls.Add(this.txtprimerTelefono);
            this.gbEncargados.Controls.Add(this.lblnumeroIdentidad);
            this.gbEncargados.Controls.Add(this.txtsegundoTelefono);
            this.gbEncargados.Controls.Add(this.lblnombres);
            this.gbEncargados.Controls.Add(this.txtDireccion);
            this.gbEncargados.Controls.Add(this.lblApellidos);
            this.gbEncargados.Controls.Add(this.lbldireccion);
            this.gbEncargados.Controls.Add(this.lblfechaNacimiento);
            this.gbEncargados.Controls.Add(this.txtprimerApellido);
            this.gbEncargados.Controls.Add(this.lbltelefonos);
            this.gbEncargados.Controls.Add(this.txtprimerNombre);
            this.gbEncargados.Controls.Add(this.lblcorreoElectronico);
            this.gbEncargados.Controls.Add(this.txtsegundoApellido);
            this.gbEncargados.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEncargados.Location = new System.Drawing.Point(12, 12);
            this.gbEncargados.Name = "gbEncargados";
            this.gbEncargados.Size = new System.Drawing.Size(1611, 1011);
            this.gbEncargados.TabIndex = 23;
            this.gbEncargados.TabStop = false;
            this.gbEncargados.Text = "Listado Encargados";
            this.gbEncargados.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 629);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 35);
            this.label1.TabIndex = 88;
            this.label1.Text = "Correo Electronico";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoElectronico.Location = new System.Drawing.Point(308, 629);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreoElectronico.MaxLength = 13;
            this.txtCorreoElectronico.Multiline = true;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(283, 35);
            this.txtCorreoElectronico.TabIndex = 89;
            // 
            // lblregistroEncargado
            // 
            this.lblregistroEncargado.AutoSize = true;
            this.lblregistroEncargado.Font = new System.Drawing.Font("Balsamiq Sans", 24F);
            this.lblregistroEncargado.Location = new System.Drawing.Point(638, 55);
            this.lblregistroEncargado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblregistroEncargado.Name = "lblregistroEncargado";
            this.lblregistroEncargado.Size = new System.Drawing.Size(283, 41);
            this.lblregistroEncargado.TabIndex = 1;
            this.lblregistroEncargado.Text = "Datos Encargado";
            // 
            // txtfechaNacimiento
            // 
            this.txtfechaNacimiento.Font = new System.Drawing.Font("Balsamiq Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechaNacimiento.Location = new System.Drawing.Point(1142, 235);
            this.txtfechaNacimiento.Mask = "00/00/0000";
            this.txtfechaNacimiento.Name = "txtfechaNacimiento";
            this.txtfechaNacimiento.ReadOnly = true;
            this.txtfechaNacimiento.Size = new System.Drawing.Size(161, 41);
            this.txtfechaNacimiento.TabIndex = 22;
            this.txtfechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // txtsegundoNombre
            // 
            this.txtsegundoNombre.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsegundoNombre.Location = new System.Drawing.Point(451, 358);
            this.txtsegundoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtsegundoNombre.Multiline = true;
            this.txtsegundoNombre.Name = "txtsegundoNombre";
            this.txtsegundoNombre.Size = new System.Drawing.Size(140, 35);
            this.txtsegundoNombre.TabIndex = 12;
            this.txtsegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoNombre_KeyPress);
            // 
            // txtprimerTelefono
            // 
            this.txtprimerTelefono.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprimerTelefono.Location = new System.Drawing.Point(1142, 353);
            this.txtprimerTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtprimerTelefono.MaxLength = 8;
            this.txtprimerTelefono.Multiline = true;
            this.txtprimerTelefono.Name = "txtprimerTelefono";
            this.txtprimerTelefono.Size = new System.Drawing.Size(161, 32);
            this.txtprimerTelefono.TabIndex = 21;
            this.txtprimerTelefono.TextChanged += new System.EventHandler(this.txtprimerTelefono_TextChanged);
            this.txtprimerTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprimerTelefono_KeyPress);
            // 
            // lblnumeroIdentidad
            // 
            this.lblnumeroIdentidad.AutoSize = true;
            this.lblnumeroIdentidad.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeroIdentidad.Location = new System.Drawing.Point(44, 233);
            this.lblnumeroIdentidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnumeroIdentidad.Name = "lblnumeroIdentidad";
            this.lblnumeroIdentidad.Size = new System.Drawing.Size(248, 35);
            this.lblnumeroIdentidad.TabIndex = 3;
            this.lblnumeroIdentidad.Text = "Numero Identidad";
            // 
            // txtsegundoTelefono
            // 
            this.txtsegundoTelefono.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsegundoTelefono.Location = new System.Drawing.Point(1320, 353);
            this.txtsegundoTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtsegundoTelefono.MaxLength = 8;
            this.txtsegundoTelefono.Multiline = true;
            this.txtsegundoTelefono.Name = "txtsegundoTelefono";
            this.txtsegundoTelefono.Size = new System.Drawing.Size(161, 32);
            this.txtsegundoTelefono.TabIndex = 20;
            this.txtsegundoTelefono.TextChanged += new System.EventHandler(this.txtsegundoTelefono_TextChanged);
            this.txtsegundoTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsegundoTelefono_KeyPress);
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombres.Location = new System.Drawing.Point(44, 360);
            this.lblnombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(134, 35);
            this.lblnombres.TabIndex = 4;
            this.lblnombres.Text = "Nombres";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(1142, 499);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(339, 165);
            this.txtDireccion.TabIndex = 19;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(44, 499);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(131, 35);
            this.lblApellidos.TabIndex = 5;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(871, 499);
            this.lbldireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(138, 35);
            this.lbldireccion.TabIndex = 9;
            this.lbldireccion.Text = "Dirección";
            this.lbldireccion.Click += new System.EventHandler(this.lbldireccion_Click);
            // 
            // lblfechaNacimiento
            // 
            this.lblfechaNacimiento.AutoSize = true;
            this.lblfechaNacimiento.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaNacimiento.Location = new System.Drawing.Point(871, 235);
            this.lblfechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfechaNacimiento.Name = "lblfechaNacimiento";
            this.lblfechaNacimiento.Size = new System.Drawing.Size(248, 35);
            this.lblfechaNacimiento.TabIndex = 8;
            this.lblfechaNacimiento.Text = "Fecha Nacimiento";
            this.lblfechaNacimiento.Click += new System.EventHandler(this.lblfechaNacimiento_Click);
            // 
            // txtprimerApellido
            // 
            this.txtprimerApellido.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprimerApellido.Location = new System.Drawing.Point(308, 497);
            this.txtprimerApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtprimerApellido.Multiline = true;
            this.txtprimerApellido.Name = "txtprimerApellido";
            this.txtprimerApellido.Size = new System.Drawing.Size(130, 35);
            this.txtprimerApellido.TabIndex = 15;
            this.txtprimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprimerApellido_KeyPress);
            // 
            // lbltelefonos
            // 
            this.lbltelefonos.AutoSize = true;
            this.lbltelefonos.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefonos.Location = new System.Drawing.Point(871, 355);
            this.lbltelefonos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltelefonos.Name = "lbltelefonos";
            this.lbltelefonos.Size = new System.Drawing.Size(145, 35);
            this.lbltelefonos.TabIndex = 7;
            this.lbltelefonos.Text = "Teléfonos";
            this.lbltelefonos.Click += new System.EventHandler(this.lbltelefonos_Click);
            // 
            // txtprimerNombre
            // 
            this.txtprimerNombre.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprimerNombre.Location = new System.Drawing.Point(308, 358);
            this.txtprimerNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtprimerNombre.Multiline = true;
            this.txtprimerNombre.Name = "txtprimerNombre";
            this.txtprimerNombre.Size = new System.Drawing.Size(130, 35);
            this.txtprimerNombre.TabIndex = 13;
            this.txtprimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprimerNombre_KeyPress);
            // 
            // lblcorreoElectronico
            // 
            this.lblcorreoElectronico.AutoSize = true;
            this.lblcorreoElectronico.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorreoElectronico.Location = new System.Drawing.Point(292, -105);
            this.lblcorreoElectronico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcorreoElectronico.Name = "lblcorreoElectronico";
            this.lblcorreoElectronico.Size = new System.Drawing.Size(261, 35);
            this.lblcorreoElectronico.TabIndex = 6;
            this.lblcorreoElectronico.Text = "Correo Electrónico";
            this.lblcorreoElectronico.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtsegundoApellido
            // 
            this.txtsegundoApellido.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsegundoApellido.Location = new System.Drawing.Point(451, 497);
            this.txtsegundoApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtsegundoApellido.Multiline = true;
            this.txtsegundoApellido.Name = "txtsegundoApellido";
            this.txtsegundoApellido.Size = new System.Drawing.Size(140, 35);
            this.txtsegundoApellido.TabIndex = 14;
            this.txtsegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsegundoApellido_KeyPress);
            // 
            // lblGestionEncargadosEstudiantes
            // 
            this.lblGestionEncargadosEstudiantes.AutoSize = true;
            this.lblGestionEncargadosEstudiantes.Font = new System.Drawing.Font("Balsamiq Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionEncargadosEstudiantes.Location = new System.Drawing.Point(475, 248);
            this.lblGestionEncargadosEstudiantes.Name = "lblGestionEncargadosEstudiantes";
            this.lblGestionEncargadosEstudiantes.Size = new System.Drawing.Size(714, 41);
            this.lblGestionEncargadosEstudiantes.TabIndex = 86;
            this.lblGestionEncargadosEstudiantes.Text = "GESTION DE ENCARGADOS Y ESTUDIANTES";
            // 
            // gbListadoEncargado
            // 
            this.gbListadoEncargado.Controls.Add(this.label10);
            this.gbListadoEncargado.Controls.Add(this.txtBusquedaNombreEncargado);
            this.gbListadoEncargado.Controls.Add(this.label11);
            this.gbListadoEncargado.Controls.Add(this.txtBusquedaIdentidadEncargado);
            this.gbListadoEncargado.Controls.Add(this.dgvBusquedaEncargado);
            this.gbListadoEncargado.Controls.Add(this.btnSiguienteEncargado);
            this.gbListadoEncargado.Controls.Add(this.btnRegresar);
            this.gbListadoEncargado.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListadoEncargado.Location = new System.Drawing.Point(18, 12);
            this.gbListadoEncargado.Name = "gbListadoEncargado";
            this.gbListadoEncargado.Size = new System.Drawing.Size(1521, 936);
            this.gbListadoEncargado.TabIndex = 108;
            this.gbListadoEncargado.TabStop = false;
            this.gbListadoEncargado.Text = "LISTADO ENCARGADOS";
            this.gbListadoEncargado.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Balsamiq Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1000, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 27);
            this.label10.TabIndex = 90;
            this.label10.Text = "Nombre";
            // 
            // txtBusquedaNombreEncargado
            // 
            this.txtBusquedaNombreEncargado.Location = new System.Drawing.Point(849, 62);
            this.txtBusquedaNombreEncargado.Name = "txtBusquedaNombreEncargado";
            this.txtBusquedaNombreEncargado.Size = new System.Drawing.Size(398, 31);
            this.txtBusquedaNombreEncargado.TabIndex = 89;
            this.txtBusquedaNombreEncargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBusquedaNombreEncargado.TextChanged += new System.EventHandler(this.txtBusquedaNombreEncargado_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Balsamiq Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(330, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 27);
            this.label11.TabIndex = 88;
            this.label11.Text = "Numero de Identidad ";
            // 
            // txtBusquedaIdentidadEncargado
            // 
            this.txtBusquedaIdentidadEncargado.Location = new System.Drawing.Point(249, 62);
            this.txtBusquedaIdentidadEncargado.Name = "txtBusquedaIdentidadEncargado";
            this.txtBusquedaIdentidadEncargado.Size = new System.Drawing.Size(398, 31);
            this.txtBusquedaIdentidadEncargado.TabIndex = 87;
            this.txtBusquedaIdentidadEncargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBusquedaIdentidadEncargado.TextChanged += new System.EventHandler(this.txtBusquedaIdentidadEncargado_TextChanged);
            // 
            // dgvBusquedaEncargado
            // 
            this.dgvBusquedaEncargado.AllowUserToAddRows = false;
            this.dgvBusquedaEncargado.AllowUserToDeleteRows = false;
            this.dgvBusquedaEncargado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusquedaEncargado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBusquedaEncargado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusquedaEncargado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBusquedaEncargado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedaEncargado.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBusquedaEncargado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBusquedaEncargado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.dgvBusquedaEncargado.Location = new System.Drawing.Point(44, 113);
            this.dgvBusquedaEncargado.MultiSelect = false;
            this.dgvBusquedaEncargado.Name = "dgvBusquedaEncargado";
            this.dgvBusquedaEncargado.ReadOnly = true;
            this.dgvBusquedaEncargado.RowHeadersWidth = 20;
            this.dgvBusquedaEncargado.Size = new System.Drawing.Size(1444, 686);
            this.dgvBusquedaEncargado.TabIndex = 86;
            this.dgvBusquedaEncargado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusquedaEncargado_CellContentClick);
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Font = new System.Drawing.Font("Balsamiq Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidad.Location = new System.Drawing.Point(308, 233);
            this.txtIdentidad.Mask = "0000000000000";
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(283, 34);
            this.txtIdentidad.TabIndex = 90;
            this.txtIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdentidad.TextChanged += new System.EventHandler(this.txtIdentidad_TextChanged_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnEliminar.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminar.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.btnEliminar.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnEliminar.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnEliminar.Location = new System.Drawing.Point(635, 859);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Radius = 20;
            this.btnEliminar.Size = new System.Drawing.Size(303, 84);
            this.btnEliminar.Stroke = true;
            this.btnEliminar.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.btnEliminar.TabIndex = 87;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Transparency = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegresarEncargado
            // 
            this.btnRegresarEncargado.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnRegresarEncargado.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnRegresarEncargado.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresarEncargado.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRegresarEncargado.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarEncargado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.btnRegresarEncargado.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnRegresarEncargado.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnRegresarEncargado.Location = new System.Drawing.Point(64, 859);
            this.btnRegresarEncargado.Name = "btnRegresarEncargado";
            this.btnRegresarEncargado.Radius = 20;
            this.btnRegresarEncargado.Size = new System.Drawing.Size(303, 84);
            this.btnRegresarEncargado.Stroke = true;
            this.btnRegresarEncargado.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.btnRegresarEncargado.TabIndex = 86;
            this.btnRegresarEncargado.Text = "Regresar";
            this.btnRegresarEncargado.Transparency = false;
            this.btnRegresarEncargado.Click += new System.EventHandler(this.btnRegresarEncargado_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnActualizar.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnActualizar.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.btnActualizar.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnActualizar.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnActualizar.Location = new System.Drawing.Point(1247, 859);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Radius = 20;
            this.btnActualizar.Size = new System.Drawing.Size(303, 84);
            this.btnActualizar.Stroke = true;
            this.btnActualizar.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.btnActualizar.TabIndex = 85;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Transparency = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEncargados
            // 
            this.btnEncargados.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnEncargados.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnEncargados.BackColor = System.Drawing.Color.Transparent;
            this.btnEncargados.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEncargados.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncargados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.btnEncargados.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnEncargados.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnEncargados.Location = new System.Drawing.Point(175, 464);
            this.btnEncargados.Name = "btnEncargados";
            this.btnEncargados.Radius = 20;
            this.btnEncargados.Size = new System.Drawing.Size(407, 200);
            this.btnEncargados.Stroke = true;
            this.btnEncargados.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.btnEncargados.TabIndex = 87;
            this.btnEncargados.Text = "ENCARGADOS";
            this.btnEncargados.Transparency = false;
            this.btnEncargados.Click += new System.EventHandler(this.btnEncargados_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnEstudiantes.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnEstudiantes.BackColor = System.Drawing.Color.Transparent;
            this.btnEstudiantes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEstudiantes.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.btnEstudiantes.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnEstudiantes.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnEstudiantes.Location = new System.Drawing.Point(1072, 464);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Radius = 20;
            this.btnEstudiantes.Size = new System.Drawing.Size(407, 200);
            this.btnEstudiantes.Stroke = true;
            this.btnEstudiantes.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.btnEstudiantes.TabIndex = 88;
            this.btnEstudiantes.Text = "ESTUDIANTES";
            this.btnEstudiantes.Transparency = false;
            // 
            // btnSiguienteEncargado
            // 
            this.btnSiguienteEncargado.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnSiguienteEncargado.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnSiguienteEncargado.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguienteEncargado.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSiguienteEncargado.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteEncargado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.btnSiguienteEncargado.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnSiguienteEncargado.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnSiguienteEncargado.Location = new System.Drawing.Point(1219, 824);
            this.btnSiguienteEncargado.Name = "btnSiguienteEncargado";
            this.btnSiguienteEncargado.Radius = 20;
            this.btnSiguienteEncargado.Size = new System.Drawing.Size(269, 65);
            this.btnSiguienteEncargado.Stroke = true;
            this.btnSiguienteEncargado.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.btnSiguienteEncargado.TabIndex = 85;
            this.btnSiguienteEncargado.Text = "SIGUIENTE";
            this.btnSiguienteEncargado.Transparency = false;
            this.btnSiguienteEncargado.Click += new System.EventHandler(this.btnSiguienteEncargado_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnRegresar.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRegresar.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.btnRegresar.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnRegresar.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnRegresar.Location = new System.Drawing.Point(37, 824);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Radius = 20;
            this.btnRegresar.Size = new System.Drawing.Size(269, 65);
            this.btnRegresar.Stroke = true;
            this.btnRegresar.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.btnRegresar.TabIndex = 82;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.Transparency = false;
            // 
            // IAñadirEncargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1635, 1035);
            this.Controls.Add(this.gbEncargados);
            this.Controls.Add(this.btnEncargados);
            this.Controls.Add(this.lblGestionEncargadosEstudiantes);
            this.Controls.Add(this.btnEstudiantes);
            this.Controls.Add(this.gbListadoEncargado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IAñadirEncargado";
            this.Text = "IAñadirEncargado";
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentidad)).EndInit();
            this.gbEncargados.ResumeLayout(false);
            this.gbEncargados.PerformLayout();
            this.gbListadoEncargado.ResumeLayout(false);
            this.gbListadoEncargado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaEncargado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorIdentidad;
        private System.Windows.Forms.GroupBox gbEncargados;
        private System.Windows.Forms.Label lblregistroEncargado;
        private System.Windows.Forms.MaskedTextBox txtfechaNacimiento;
        private System.Windows.Forms.TextBox txtsegundoNombre;
        private System.Windows.Forms.TextBox txtprimerTelefono;
        private System.Windows.Forms.Label lblnumeroIdentidad;
        private System.Windows.Forms.TextBox txtsegundoTelefono;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblfechaNacimiento;
        private System.Windows.Forms.TextBox txtprimerApellido;
        private System.Windows.Forms.Label lbltelefonos;
        private System.Windows.Forms.TextBox txtprimerNombre;
        private System.Windows.Forms.Label lblcorreoElectronico;
        private System.Windows.Forms.TextBox txtsegundoApellido;
        private AltoControls.AltoButton btnActualizar;
        private AltoControls.AltoButton btnRegresarEncargado;
        private AltoControls.AltoButton btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private AltoControls.AltoButton btnEstudiantes;
        private AltoControls.AltoButton btnEncargados;
        private System.Windows.Forms.Label lblGestionEncargadosEstudiantes;
        private System.Windows.Forms.GroupBox gbListadoEncargado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBusquedaNombreEncargado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBusquedaIdentidadEncargado;
        private System.Windows.Forms.DataGridView dgvBusquedaEncargado;
        private AltoControls.AltoButton btnSiguienteEncargado;
        private AltoControls.AltoButton btnRegresar;
        private System.Windows.Forms.MaskedTextBox txtIdentidad;
    }
}