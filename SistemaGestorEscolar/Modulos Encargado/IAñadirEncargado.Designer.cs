
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
            this.PanregistroEncargado = new System.Windows.Forms.Panel();
            this.txtprimerTelefono = new System.Windows.Forms.TextBox();
            this.txtsegundoTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtfechaNacimiento = new System.Windows.Forms.TextBox();
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
            this.chkbuscarEncargado = new System.Windows.Forms.CheckBox();
            this.chkactualizarEncargado = new System.Windows.Forms.CheckBox();
            this.chkregistrarEncargado = new System.Windows.Forms.CheckBox();
            this.lblSeleccionarOperacion = new System.Windows.Forms.Label();
            this.lblregistroEncargado = new System.Windows.Forms.Label();
            this.PanregistroEncargado.SuspendLayout();
            this.gbOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanregistroEncargado
            // 
            this.PanregistroEncargado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.PanregistroEncargado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanregistroEncargado.Controls.Add(this.txtprimerTelefono);
            this.PanregistroEncargado.Controls.Add(this.txtsegundoTelefono);
            this.PanregistroEncargado.Controls.Add(this.txtDireccion);
            this.PanregistroEncargado.Controls.Add(this.txtfechaNacimiento);
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
            this.txtprimerTelefono.Location = new System.Drawing.Point(1242, 170);
            this.txtprimerTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtprimerTelefono.Multiline = true;
            this.txtprimerTelefono.Name = "txtprimerTelefono";
            this.txtprimerTelefono.Size = new System.Drawing.Size(140, 32);
            this.txtprimerTelefono.TabIndex = 21;
            this.txtprimerTelefono.TextChanged += new System.EventHandler(this.txtprimerTelefono_TextChanged);
            // 
            // txtsegundoTelefono
            // 
            this.txtsegundoTelefono.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsegundoTelefono.Location = new System.Drawing.Point(1397, 170);
            this.txtsegundoTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtsegundoTelefono.Multiline = true;
            this.txtsegundoTelefono.Name = "txtsegundoTelefono";
            this.txtsegundoTelefono.Size = new System.Drawing.Size(140, 32);
            this.txtsegundoTelefono.TabIndex = 20;
            this.txtsegundoTelefono.TextChanged += new System.EventHandler(this.txtsegundoTelefono_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(1243, 344);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(302, 153);
            this.txtDireccion.TabIndex = 19;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtfechaNacimiento
            // 
            this.txtfechaNacimiento.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechaNacimiento.Location = new System.Drawing.Point(1242, 259);
            this.txtfechaNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.txtfechaNacimiento.Multiline = true;
            this.txtfechaNacimiento.Name = "txtfechaNacimiento";
            this.txtfechaNacimiento.Size = new System.Drawing.Size(283, 32);
            this.txtfechaNacimiento.TabIndex = 18;
            this.txtfechaNacimiento.TextChanged += new System.EventHandler(this.txtfechaNacimiento_TextChanged);
            // 
            // txtcorreoElectronico
            // 
            this.txtcorreoElectronico.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreoElectronico.Location = new System.Drawing.Point(1243, 84);
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
            this.txtprimerApellido.Location = new System.Drawing.Point(280, 407);
            this.txtprimerApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtprimerApellido.Multiline = true;
            this.txtprimerApellido.Name = "txtprimerApellido";
            this.txtprimerApellido.Size = new System.Drawing.Size(140, 32);
            this.txtprimerApellido.TabIndex = 15;
            // 
            // txtsegundoApellido
            // 
            this.txtsegundoApellido.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsegundoApellido.Location = new System.Drawing.Point(433, 407);
            this.txtsegundoApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtsegundoApellido.Multiline = true;
            this.txtsegundoApellido.Name = "txtsegundoApellido";
            this.txtsegundoApellido.Size = new System.Drawing.Size(140, 32);
            this.txtsegundoApellido.TabIndex = 14;
            // 
            // txtprimerNombre
            // 
            this.txtprimerNombre.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprimerNombre.Location = new System.Drawing.Point(280, 329);
            this.txtprimerNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtprimerNombre.Multiline = true;
            this.txtprimerNombre.Name = "txtprimerNombre";
            this.txtprimerNombre.Size = new System.Drawing.Size(140, 32);
            this.txtprimerNombre.TabIndex = 13;
            // 
            // txtsegundoNombre
            // 
            this.txtsegundoNombre.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsegundoNombre.Location = new System.Drawing.Point(433, 328);
            this.txtsegundoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtsegundoNombre.Multiline = true;
            this.txtsegundoNombre.Name = "txtsegundoNombre";
            this.txtsegundoNombre.Size = new System.Drawing.Size(140, 32);
            this.txtsegundoNombre.TabIndex = 12;
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidad.Location = new System.Drawing.Point(325, 250);
            this.txtIdentidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentidad.Multiline = true;
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(283, 32);
            this.txtIdentidad.TabIndex = 10;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(972, 345);
            this.lbldireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(127, 31);
            this.lbldireccion.TabIndex = 9;
            this.lbldireccion.Text = "Dirección";
            this.lbldireccion.Click += new System.EventHandler(this.lbldireccion_Click);
            // 
            // lblfechaNacimiento
            // 
            this.lblfechaNacimiento.AutoSize = true;
            this.lblfechaNacimiento.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaNacimiento.Location = new System.Drawing.Point(972, 259);
            this.lblfechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfechaNacimiento.Name = "lblfechaNacimiento";
            this.lblfechaNacimiento.Size = new System.Drawing.Size(225, 31);
            this.lblfechaNacimiento.TabIndex = 8;
            this.lblfechaNacimiento.Text = "Fecha Nacimiento";
            this.lblfechaNacimiento.Click += new System.EventHandler(this.lblfechaNacimiento_Click);
            // 
            // lbltelefonos
            // 
            this.lbltelefonos.AutoSize = true;
            this.lbltelefonos.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefonos.Location = new System.Drawing.Point(972, 170);
            this.lbltelefonos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltelefonos.Name = "lbltelefonos";
            this.lbltelefonos.Size = new System.Drawing.Size(138, 31);
            this.lbltelefonos.TabIndex = 7;
            this.lbltelefonos.Text = "Teléfonos";
            this.lbltelefonos.Click += new System.EventHandler(this.lbltelefonos_Click);
            // 
            // lblcorreoElectronico
            // 
            this.lblcorreoElectronico.AutoSize = true;
            this.lblcorreoElectronico.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorreoElectronico.Location = new System.Drawing.Point(972, 86);
            this.lblcorreoElectronico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcorreoElectronico.Name = "lblcorreoElectronico";
            this.lblcorreoElectronico.Size = new System.Drawing.Size(244, 31);
            this.lblcorreoElectronico.TabIndex = 6;
            this.lblcorreoElectronico.Text = "Correo Electrónico";
            this.lblcorreoElectronico.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(91, 409);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(123, 31);
            this.lblApellidos.TabIndex = 5;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombres.Location = new System.Drawing.Point(91, 328);
            this.lblnombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(123, 31);
            this.lblnombres.TabIndex = 4;
            this.lblnombres.Text = "Nombres";
            // 
            // lblnumeroIdentidad
            // 
            this.lblnumeroIdentidad.AutoSize = true;
            this.lblnumeroIdentidad.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeroIdentidad.Location = new System.Drawing.Point(91, 252);
            this.lblnumeroIdentidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnumeroIdentidad.Name = "lblnumeroIdentidad";
            this.lblnumeroIdentidad.Size = new System.Drawing.Size(230, 31);
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
            // 
            // gbOperaciones
            // 
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
            this.gbOperaciones.Size = new System.Drawing.Size(621, 184);
            this.gbOperaciones.TabIndex = 0;
            this.gbOperaciones.TabStop = false;
            // 
            // chkbuscarEncargado
            // 
            this.chkbuscarEncargado.AutoSize = true;
            this.chkbuscarEncargado.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbuscarEncargado.Location = new System.Drawing.Point(354, 82);
            this.chkbuscarEncargado.Margin = new System.Windows.Forms.Padding(2);
            this.chkbuscarEncargado.Name = "chkbuscarEncargado";
            this.chkbuscarEncargado.Size = new System.Drawing.Size(232, 31);
            this.chkbuscarEncargado.TabIndex = 5;
            this.chkbuscarEncargado.Text = "Buscar Encargado";
            this.chkbuscarEncargado.UseVisualStyleBackColor = true;
            // 
            // chkactualizarEncargado
            // 
            this.chkactualizarEncargado.AutoSize = true;
            this.chkactualizarEncargado.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkactualizarEncargado.Location = new System.Drawing.Point(175, 136);
            this.chkactualizarEncargado.Margin = new System.Windows.Forms.Padding(2);
            this.chkactualizarEncargado.Name = "chkactualizarEncargado";
            this.chkactualizarEncargado.Size = new System.Drawing.Size(267, 31);
            this.chkactualizarEncargado.TabIndex = 4;
            this.chkactualizarEncargado.Text = "Actualizar Encargado";
            this.chkactualizarEncargado.UseVisualStyleBackColor = true;
            // 
            // chkregistrarEncargado
            // 
            this.chkregistrarEncargado.AutoSize = true;
            this.chkregistrarEncargado.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkregistrarEncargado.Location = new System.Drawing.Point(25, 82);
            this.chkregistrarEncargado.Margin = new System.Windows.Forms.Padding(2);
            this.chkregistrarEncargado.Name = "chkregistrarEncargado";
            this.chkregistrarEncargado.Size = new System.Drawing.Size(261, 31);
            this.chkregistrarEncargado.TabIndex = 3;
            this.chkregistrarEncargado.Text = "Registrar Encargado";
            this.chkregistrarEncargado.UseVisualStyleBackColor = true;
            // 
            // lblSeleccionarOperacion
            // 
            this.lblSeleccionarOperacion.AutoSize = true;
            this.lblSeleccionarOperacion.Font = new System.Drawing.Font("Balsamiq Sans", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarOperacion.Location = new System.Drawing.Point(97, 16);
            this.lblSeleccionarOperacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionarOperacion.Name = "lblSeleccionarOperacion";
            this.lblSeleccionarOperacion.Size = new System.Drawing.Size(397, 33);
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
            this.lblregistroEncargado.Size = new System.Drawing.Size(312, 36);
            this.lblregistroEncargado.TabIndex = 1;
            this.lblregistroEncargado.Text = "Registro Encargado";
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
        private System.Windows.Forms.TextBox txtfechaNacimiento;
        private System.Windows.Forms.TextBox txtcorreoElectronico;
        private System.Windows.Forms.TextBox txtprimerApellido;
        private System.Windows.Forms.TextBox txtsegundoApellido;
        private System.Windows.Forms.CheckBox chkbuscarEncargado;
        private System.Windows.Forms.CheckBox chkactualizarEncargado;
        private System.Windows.Forms.CheckBox chkregistrarEncargado;
        private System.Windows.Forms.TextBox txtprimerTelefono;
        private System.Windows.Forms.TextBox txtsegundoTelefono;
    }
}