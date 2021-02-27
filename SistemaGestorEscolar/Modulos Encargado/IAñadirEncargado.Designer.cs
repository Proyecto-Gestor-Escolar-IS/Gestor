
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
            this.PanregistroEncargado = new System.Windows.Forms.Panel();
            this.txtprimerTelefono = new System.Windows.Forms.TextBox();
            this.txtsegundoTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtcorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtprimerApellido = new System.Windows.Forms.TextBox();
            this.txtsegundoApellido = new System.Windows.Forms.TextBox();
            this.txtprimerNombre = new System.Windows.Forms.TextBox();
            this.txtsegundoNombre = new System.Windows.Forms.TextBox();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblfechaNacimiento = new System.Windows.Forms.Label();
            this.lbltelefonos = new System.Windows.Forms.Label();
            this.lblcorreoElectronico = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblnombres = new System.Windows.Forms.Label();
            this.lblnumeroIdentidad = new System.Windows.Forms.Label();
            this.btnrealizarOperacion = new System.Windows.Forms.Button();
            this.gbOperaciones = new System.Windows.Forms.GroupBox();
            this.chkeliminarEncargado = new System.Windows.Forms.CheckBox();
            this.chkbuscarEncargado = new System.Windows.Forms.CheckBox();
            this.chkactualizarEncargado = new System.Windows.Forms.CheckBox();
            this.chkregistrarEncargado = new System.Windows.Forms.CheckBox();
            this.lblSeleccionarOperacion = new System.Windows.Forms.Label();
            this.lblregistroEncargado = new System.Windows.Forms.Label();
            this.errorIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtfechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.PanregistroEncargado.SuspendLayout();
            this.gbOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentidad)).BeginInit();
            this.SuspendLayout();
            // 
            // PanregistroEncargado
            // 
            this.PanregistroEncargado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.PanregistroEncargado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanregistroEncargado.Controls.Add(this.txtfechaNacimiento);
            this.PanregistroEncargado.Controls.Add(this.txtprimerTelefono);
            this.PanregistroEncargado.Controls.Add(this.txtsegundoTelefono);
            this.PanregistroEncargado.Controls.Add(this.txtDireccion);
            this.PanregistroEncargado.Controls.Add(this.txtcorreoElectronico);
            this.PanregistroEncargado.Controls.Add(this.txtprimerApellido);
            this.PanregistroEncargado.Controls.Add(this.txtsegundoApellido);
            this.PanregistroEncargado.Controls.Add(this.txtprimerNombre);
            this.PanregistroEncargado.Controls.Add(this.txtsegundoNombre);
            this.PanregistroEncargado.Controls.Add(this.txtIdentidad);
            this.PanregistroEncargado.Controls.Add(this.lbldireccion);
            this.PanregistroEncargado.Controls.Add(this.lblfechaNacimiento);
            this.PanregistroEncargado.Controls.Add(this.lbltelefonos);
            this.PanregistroEncargado.Controls.Add(this.lblcorreoElectronico);
            this.PanregistroEncargado.Controls.Add(this.lblApellidos);
            this.PanregistroEncargado.Controls.Add(this.lblnombres);
            this.PanregistroEncargado.Controls.Add(this.lblnumeroIdentidad);
            this.PanregistroEncargado.Controls.Add(this.btnrealizarOperacion);
            this.PanregistroEncargado.Controls.Add(this.gbOperaciones);
            this.PanregistroEncargado.Font = new System.Drawing.Font("Balsamiq Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanregistroEncargado.Location = new System.Drawing.Point(9, 94);
            this.PanregistroEncargado.Margin = new System.Windows.Forms.Padding(2);
            this.PanregistroEncargado.Name = "PanregistroEncargado";
            this.PanregistroEncargado.Size = new System.Drawing.Size(1615, 919);
            this.PanregistroEncargado.TabIndex = 0;
            // 
            // txtprimerTelefono
            // 
            this.txtprimerTelefono.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprimerTelefono.Location = new System.Drawing.Point(1245, 223);
            this.txtprimerTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtprimerTelefono.Multiline = true;
            this.txtprimerTelefono.Name = "txtprimerTelefono";
            this.txtprimerTelefono.Size = new System.Drawing.Size(140, 32);
            this.txtprimerTelefono.TabIndex = 21;
            this.txtprimerTelefono.TextChanged += new System.EventHandler(this.txtprimerTelefono_TextChanged);
            this.txtprimerTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprimerTelefono_KeyPress);
            // 
            // txtsegundoTelefono
            // 
            this.txtsegundoTelefono.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsegundoTelefono.Location = new System.Drawing.Point(1400, 223);
            this.txtsegundoTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtsegundoTelefono.Multiline = true;
            this.txtsegundoTelefono.Name = "txtsegundoTelefono";
            this.txtsegundoTelefono.Size = new System.Drawing.Size(140, 32);
            this.txtsegundoTelefono.TabIndex = 20;
            this.txtsegundoTelefono.TextChanged += new System.EventHandler(this.txtsegundoTelefono_TextChanged);
            this.txtsegundoTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsegundoTelefono_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(1246, 397);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(302, 153);
            this.txtDireccion.TabIndex = 19;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtcorreoElectronico
            // 
            this.txtcorreoElectronico.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreoElectronico.Location = new System.Drawing.Point(1246, 137);
            this.txtcorreoElectronico.Margin = new System.Windows.Forms.Padding(2);
            this.txtcorreoElectronico.Multiline = true;
            this.txtcorreoElectronico.Name = "txtcorreoElectronico";
            this.txtcorreoElectronico.Size = new System.Drawing.Size(283, 32);
            this.txtcorreoElectronico.TabIndex = 16;
            this.txtcorreoElectronico.TextChanged += new System.EventHandler(this.txtcorreoElectronico_TextChanged);
            // 
            // txtprimerApellido
            // 
            this.txtprimerApellido.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprimerApellido.Location = new System.Drawing.Point(280, 478);
            this.txtprimerApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtprimerApellido.Multiline = true;
            this.txtprimerApellido.Name = "txtprimerApellido";
            this.txtprimerApellido.Size = new System.Drawing.Size(140, 32);
            this.txtprimerApellido.TabIndex = 15;
            this.txtprimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprimerApellido_KeyPress);
            // 
            // txtsegundoApellido
            // 
            this.txtsegundoApellido.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsegundoApellido.Location = new System.Drawing.Point(433, 478);
            this.txtsegundoApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtsegundoApellido.Multiline = true;
            this.txtsegundoApellido.Name = "txtsegundoApellido";
            this.txtsegundoApellido.Size = new System.Drawing.Size(140, 32);
            this.txtsegundoApellido.TabIndex = 14;
            this.txtsegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsegundoApellido_KeyPress);
            // 
            // txtprimerNombre
            // 
            this.txtprimerNombre.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprimerNombre.Location = new System.Drawing.Point(280, 400);
            this.txtprimerNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtprimerNombre.Multiline = true;
            this.txtprimerNombre.Name = "txtprimerNombre";
            this.txtprimerNombre.Size = new System.Drawing.Size(140, 32);
            this.txtprimerNombre.TabIndex = 13;
            this.txtprimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprimerNombre_KeyPress);
            // 
            // txtsegundoNombre
            // 
            this.txtsegundoNombre.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsegundoNombre.Location = new System.Drawing.Point(433, 399);
            this.txtsegundoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtsegundoNombre.Multiline = true;
            this.txtsegundoNombre.Name = "txtsegundoNombre";
            this.txtsegundoNombre.Size = new System.Drawing.Size(140, 32);
            this.txtsegundoNombre.TabIndex = 12;
            this.txtsegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoNombre_KeyPress);
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidad.Location = new System.Drawing.Point(353, 321);
            this.txtIdentidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentidad.MaxLength = 13;
            this.txtIdentidad.Multiline = true;
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(283, 32);
            this.txtIdentidad.TabIndex = 10;
            this.txtIdentidad.TextChanged += new System.EventHandler(this.txtIdentidad_TextChanged);
            this.txtIdentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentidad_KeyPress);
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(975, 398);
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
            this.lblfechaNacimiento.Location = new System.Drawing.Point(975, 312);
            this.lblfechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfechaNacimiento.Name = "lblfechaNacimiento";
            this.lblfechaNacimiento.Size = new System.Drawing.Size(248, 35);
            this.lblfechaNacimiento.TabIndex = 8;
            this.lblfechaNacimiento.Text = "Fecha Nacimiento";
            this.lblfechaNacimiento.Click += new System.EventHandler(this.lblfechaNacimiento_Click);
            // 
            // lbltelefonos
            // 
            this.lbltelefonos.AutoSize = true;
            this.lbltelefonos.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefonos.Location = new System.Drawing.Point(975, 223);
            this.lbltelefonos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltelefonos.Name = "lbltelefonos";
            this.lbltelefonos.Size = new System.Drawing.Size(145, 35);
            this.lbltelefonos.TabIndex = 7;
            this.lbltelefonos.Text = "Teléfonos";
            this.lbltelefonos.Click += new System.EventHandler(this.lbltelefonos_Click);
            // 
            // lblcorreoElectronico
            // 
            this.lblcorreoElectronico.AutoSize = true;
            this.lblcorreoElectronico.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorreoElectronico.Location = new System.Drawing.Point(975, 139);
            this.lblcorreoElectronico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcorreoElectronico.Name = "lblcorreoElectronico";
            this.lblcorreoElectronico.Size = new System.Drawing.Size(261, 35);
            this.lblcorreoElectronico.TabIndex = 6;
            this.lblcorreoElectronico.Text = "Correo Electrónico";
            this.lblcorreoElectronico.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(91, 480);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(131, 35);
            this.lblApellidos.TabIndex = 5;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombres.Location = new System.Drawing.Point(91, 399);
            this.lblnombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(134, 35);
            this.lblnombres.TabIndex = 4;
            this.lblnombres.Text = "Nombres";
            // 
            // lblnumeroIdentidad
            // 
            this.lblnumeroIdentidad.AutoSize = true;
            this.lblnumeroIdentidad.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeroIdentidad.Location = new System.Drawing.Point(91, 323);
            this.lblnumeroIdentidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnumeroIdentidad.Name = "lblnumeroIdentidad";
            this.lblnumeroIdentidad.Size = new System.Drawing.Size(248, 35);
            this.lblnumeroIdentidad.TabIndex = 3;
            this.lblnumeroIdentidad.Text = "Numero Identidad";
            // 
            // btnrealizarOperacion
            // 
            this.btnrealizarOperacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnrealizarOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrealizarOperacion.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrealizarOperacion.Location = new System.Drawing.Point(585, 709);
            this.btnrealizarOperacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnrealizarOperacion.Name = "btnrealizarOperacion";
            this.btnrealizarOperacion.Size = new System.Drawing.Size(525, 104);
            this.btnrealizarOperacion.TabIndex = 1;
            this.btnrealizarOperacion.Text = "Realizar Operación";
            this.btnrealizarOperacion.UseVisualStyleBackColor = false;
            this.btnrealizarOperacion.Click += new System.EventHandler(this.btnrealizarOperacion_Click);
            // 
            // gbOperaciones
            // 
            this.gbOperaciones.Controls.Add(this.chkeliminarEncargado);
            this.gbOperaciones.Controls.Add(this.chkbuscarEncargado);
            this.gbOperaciones.Controls.Add(this.chkactualizarEncargado);
            this.gbOperaciones.Controls.Add(this.chkregistrarEncargado);
            this.gbOperaciones.Controls.Add(this.lblSeleccionarOperacion);
            this.gbOperaciones.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gbOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOperaciones.Location = new System.Drawing.Point(79, 17);
            this.gbOperaciones.Margin = new System.Windows.Forms.Padding(2);
            this.gbOperaciones.Name = "gbOperaciones";
            this.gbOperaciones.Padding = new System.Windows.Forms.Padding(2);
            this.gbOperaciones.Size = new System.Drawing.Size(642, 184);
            this.gbOperaciones.TabIndex = 0;
            this.gbOperaciones.TabStop = false;
            // 
            // chkeliminarEncargado
            // 
            this.chkeliminarEncargado.AutoSize = true;
            this.chkeliminarEncargado.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkeliminarEncargado.Location = new System.Drawing.Point(354, 136);
            this.chkeliminarEncargado.Margin = new System.Windows.Forms.Padding(2);
            this.chkeliminarEncargado.Name = "chkeliminarEncargado";
            this.chkeliminarEncargado.Size = new System.Drawing.Size(251, 35);
            this.chkeliminarEncargado.TabIndex = 6;
            this.chkeliminarEncargado.Text = "Eliminar Encargado";
            this.chkeliminarEncargado.UseVisualStyleBackColor = true;
            this.chkeliminarEncargado.CheckedChanged += new System.EventHandler(this.chkeliminarEncargado_CheckedChanged);
            // 
            // chkbuscarEncargado
            // 
            this.chkbuscarEncargado.AutoSize = true;
            this.chkbuscarEncargado.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbuscarEncargado.Location = new System.Drawing.Point(354, 82);
            this.chkbuscarEncargado.Margin = new System.Windows.Forms.Padding(2);
            this.chkbuscarEncargado.Name = "chkbuscarEncargado";
            this.chkbuscarEncargado.Size = new System.Drawing.Size(245, 35);
            this.chkbuscarEncargado.TabIndex = 5;
            this.chkbuscarEncargado.Text = "Buscar Encargado";
            this.chkbuscarEncargado.UseVisualStyleBackColor = true;
            this.chkbuscarEncargado.CheckedChanged += new System.EventHandler(this.chkbuscarEncargado_CheckedChanged);
            // 
            // chkactualizarEncargado
            // 
            this.chkactualizarEncargado.AutoSize = true;
            this.chkactualizarEncargado.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkactualizarEncargado.Location = new System.Drawing.Point(25, 136);
            this.chkactualizarEncargado.Margin = new System.Windows.Forms.Padding(2);
            this.chkactualizarEncargado.Name = "chkactualizarEncargado";
            this.chkactualizarEncargado.Size = new System.Drawing.Size(280, 35);
            this.chkactualizarEncargado.TabIndex = 4;
            this.chkactualizarEncargado.Text = "Actualizar Encargado";
            this.chkactualizarEncargado.UseVisualStyleBackColor = true;
            this.chkactualizarEncargado.CheckedChanged += new System.EventHandler(this.chkactualizarEncargado_CheckedChanged);
            // 
            // chkregistrarEncargado
            // 
            this.chkregistrarEncargado.AutoSize = true;
            this.chkregistrarEncargado.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkregistrarEncargado.Location = new System.Drawing.Point(25, 82);
            this.chkregistrarEncargado.Margin = new System.Windows.Forms.Padding(2);
            this.chkregistrarEncargado.Name = "chkregistrarEncargado";
            this.chkregistrarEncargado.Size = new System.Drawing.Size(272, 35);
            this.chkregistrarEncargado.TabIndex = 3;
            this.chkregistrarEncargado.Text = "Registrar Encargado";
            this.chkregistrarEncargado.UseVisualStyleBackColor = true;
            this.chkregistrarEncargado.Click += new System.EventHandler(this.chkregistrarEncargado_Click);
            // 
            // lblSeleccionarOperacion
            // 
            this.lblSeleccionarOperacion.AutoSize = true;
            this.lblSeleccionarOperacion.Font = new System.Drawing.Font("Balsamiq Sans", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarOperacion.Location = new System.Drawing.Point(97, 16);
            this.lblSeleccionarOperacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionarOperacion.Name = "lblSeleccionarOperacion";
            this.lblSeleccionarOperacion.Size = new System.Drawing.Size(392, 38);
            this.lblSeleccionarOperacion.TabIndex = 2;
            this.lblSeleccionarOperacion.Text = "Seleccione una operación";
            // 
            // lblregistroEncargado
            // 
            this.lblregistroEncargado.AutoSize = true;
            this.lblregistroEncargado.Font = new System.Drawing.Font("Balsamiq Sans", 24F);
            this.lblregistroEncargado.Location = new System.Drawing.Point(715, 29);
            this.lblregistroEncargado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblregistroEncargado.Name = "lblregistroEncargado";
            this.lblregistroEncargado.Size = new System.Drawing.Size(325, 41);
            this.lblregistroEncargado.TabIndex = 1;
            this.lblregistroEncargado.Text = "Registro Encargado";
            // 
            // errorIdentidad
            // 
            this.errorIdentidad.ContainerControl = this;
            // 
            // txtfechaNacimiento
            // 
            this.txtfechaNacimiento.Font = new System.Drawing.Font("Balsamiq Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechaNacimiento.Location = new System.Drawing.Point(1256, 312);
            this.txtfechaNacimiento.Mask = "00/00/0000";
            this.txtfechaNacimiento.Name = "txtfechaNacimiento";
            this.txtfechaNacimiento.Size = new System.Drawing.Size(163, 41);
            this.txtfechaNacimiento.TabIndex = 22;
            this.txtfechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // IAñadirEncargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1635, 1035);
            this.Controls.Add(this.lblregistroEncargado);
            this.Controls.Add(this.PanregistroEncargado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IAñadirEncargado";
            this.Text = "IAñadirEncargado";
            this.PanregistroEncargado.ResumeLayout(false);
            this.PanregistroEncargado.PerformLayout();
            this.gbOperaciones.ResumeLayout(false);
            this.gbOperaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanregistroEncargado;
        private System.Windows.Forms.Label lblregistroEncargado;
        private System.Windows.Forms.GroupBox gbOperaciones;
        private System.Windows.Forms.Label lblSeleccionarOperacion;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblfechaNacimiento;
        private System.Windows.Forms.Label lbltelefonos;
        private System.Windows.Forms.Label lblcorreoElectronico;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.Label lblnumeroIdentidad;
        private System.Windows.Forms.Button btnrealizarOperacion;
        private System.Windows.Forms.TextBox txtprimerNombre;
        private System.Windows.Forms.TextBox txtsegundoNombre;
        private System.Windows.Forms.TextBox txtIdentidad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtcorreoElectronico;
        private System.Windows.Forms.TextBox txtprimerApellido;
        private System.Windows.Forms.TextBox txtsegundoApellido;
        private System.Windows.Forms.CheckBox chkbuscarEncargado;
        private System.Windows.Forms.CheckBox chkactualizarEncargado;
        private System.Windows.Forms.CheckBox chkregistrarEncargado;
        private System.Windows.Forms.TextBox txtprimerTelefono;
        private System.Windows.Forms.TextBox txtsegundoTelefono;
        private System.Windows.Forms.CheckBox chkeliminarEncargado;
        private System.Windows.Forms.ErrorProvider errorIdentidad;
        private System.Windows.Forms.MaskedTextBox txtfechaNacimiento;
    }
}