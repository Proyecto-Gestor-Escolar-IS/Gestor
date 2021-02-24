
namespace SistemaGestorEscolar.Modulos_Estudiante
{
    partial class ICrudEstudiante
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
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.PanregistroEncargado = new System.Windows.Forms.Panel();
            this.txtprimerApellido = new System.Windows.Forms.TextBox();
            this.txtsegundoApellido = new System.Windows.Forms.TextBox();
            this.txtprimerNombre = new System.Windows.Forms.TextBox();
            this.txtsegundoNombre = new System.Windows.Forms.TextBox();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblnombres = new System.Windows.Forms.Label();
            this.lblnumeroIdentidad = new System.Windows.Forms.Label();
            this.btnrealizarOperacion = new System.Windows.Forms.Button();
            this.gbOperaciones = new System.Windows.Forms.GroupBox();
            this.chkbuscarEstudiante = new System.Windows.Forms.CheckBox();
            this.chkeliminarEstudiante = new System.Windows.Forms.CheckBox();
            this.chkmodificarEstudiante = new System.Windows.Forms.CheckBox();
            this.lblSeleccionarOperacion = new System.Windows.Forms.Label();
            this.cmbgeneroEstudiante = new System.Windows.Forms.ComboBox();
            this.lblgenero = new System.Windows.Forms.Label();
            this.txtfechaNacimientoEstudiante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanregistroEncargado.SuspendLayout();
            this.gbOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 24F);
            this.lblEstudiante.Location = new System.Drawing.Point(716, 42);
            this.lblEstudiante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(202, 41);
            this.lblEstudiante.TabIndex = 46;
            this.lblEstudiante.Text = "Estudiantes";
            // 
            // PanregistroEncargado
            // 
            this.PanregistroEncargado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.PanregistroEncargado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanregistroEncargado.Controls.Add(this.cmbgeneroEstudiante);
            this.PanregistroEncargado.Controls.Add(this.lblgenero);
            this.PanregistroEncargado.Controls.Add(this.txtfechaNacimientoEstudiante);
            this.PanregistroEncargado.Controls.Add(this.label1);
            this.PanregistroEncargado.Controls.Add(this.txtprimerApellido);
            this.PanregistroEncargado.Controls.Add(this.txtsegundoApellido);
            this.PanregistroEncargado.Controls.Add(this.txtprimerNombre);
            this.PanregistroEncargado.Controls.Add(this.txtsegundoNombre);
            this.PanregistroEncargado.Controls.Add(this.txtIdentidad);
            this.PanregistroEncargado.Controls.Add(this.lblApellidos);
            this.PanregistroEncargado.Controls.Add(this.lblnombres);
            this.PanregistroEncargado.Controls.Add(this.lblnumeroIdentidad);
            this.PanregistroEncargado.Controls.Add(this.btnrealizarOperacion);
            this.PanregistroEncargado.Controls.Add(this.gbOperaciones);
            this.PanregistroEncargado.Font = new System.Drawing.Font("Balsamiq Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanregistroEncargado.Location = new System.Drawing.Point(9, 105);
            this.PanregistroEncargado.Margin = new System.Windows.Forms.Padding(2);
            this.PanregistroEncargado.Name = "PanregistroEncargado";
            this.PanregistroEncargado.Size = new System.Drawing.Size(1615, 919);
            this.PanregistroEncargado.TabIndex = 47;
            // 
            // txtprimerApellido
            // 
            this.txtprimerApellido.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprimerApellido.Location = new System.Drawing.Point(333, 463);
            this.txtprimerApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtprimerApellido.Multiline = true;
            this.txtprimerApellido.Name = "txtprimerApellido";
            this.txtprimerApellido.Size = new System.Drawing.Size(176, 32);
            this.txtprimerApellido.TabIndex = 15;
            // 
            // txtsegundoApellido
            // 
            this.txtsegundoApellido.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsegundoApellido.Location = new System.Drawing.Point(513, 463);
            this.txtsegundoApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtsegundoApellido.Multiline = true;
            this.txtsegundoApellido.Name = "txtsegundoApellido";
            this.txtsegundoApellido.Size = new System.Drawing.Size(168, 32);
            this.txtsegundoApellido.TabIndex = 14;
            // 
            // txtprimerNombre
            // 
            this.txtprimerNombre.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprimerNombre.Location = new System.Drawing.Point(333, 384);
            this.txtprimerNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtprimerNombre.Multiline = true;
            this.txtprimerNombre.Name = "txtprimerNombre";
            this.txtprimerNombre.Size = new System.Drawing.Size(176, 32);
            this.txtprimerNombre.TabIndex = 13;
            // 
            // txtsegundoNombre
            // 
            this.txtsegundoNombre.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsegundoNombre.Location = new System.Drawing.Point(513, 384);
            this.txtsegundoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtsegundoNombre.Multiline = true;
            this.txtsegundoNombre.Name = "txtsegundoNombre";
            this.txtsegundoNombre.Size = new System.Drawing.Size(168, 32);
            this.txtsegundoNombre.TabIndex = 12;
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidad.Location = new System.Drawing.Point(333, 306);
            this.txtIdentidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentidad.Multiline = true;
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(348, 32);
            this.txtIdentidad.TabIndex = 10;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(81, 465);
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
            this.lblnombres.Location = new System.Drawing.Point(81, 384);
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
            this.lblnumeroIdentidad.Location = new System.Drawing.Point(81, 308);
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
            // 
            // gbOperaciones
            // 
            this.gbOperaciones.Controls.Add(this.chkbuscarEstudiante);
            this.gbOperaciones.Controls.Add(this.chkeliminarEstudiante);
            this.gbOperaciones.Controls.Add(this.chkmodificarEstudiante);
            this.gbOperaciones.Controls.Add(this.lblSeleccionarOperacion);
            this.gbOperaciones.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gbOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOperaciones.Location = new System.Drawing.Point(319, 29);
            this.gbOperaciones.Margin = new System.Windows.Forms.Padding(2);
            this.gbOperaciones.Name = "gbOperaciones";
            this.gbOperaciones.Padding = new System.Windows.Forms.Padding(2);
            this.gbOperaciones.Size = new System.Drawing.Size(974, 184);
            this.gbOperaciones.TabIndex = 0;
            this.gbOperaciones.TabStop = false;
            // 
            // chkbuscarEstudiante
            // 
            this.chkbuscarEstudiante.AutoSize = true;
            this.chkbuscarEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbuscarEstudiante.Location = new System.Drawing.Point(375, 82);
            this.chkbuscarEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.chkbuscarEstudiante.Name = "chkbuscarEstudiante";
            this.chkbuscarEstudiante.Size = new System.Drawing.Size(244, 35);
            this.chkbuscarEstudiante.TabIndex = 5;
            this.chkbuscarEstudiante.Text = "Buscar Estudiante";
            this.chkbuscarEstudiante.UseVisualStyleBackColor = true;
            // 
            // chkeliminarEstudiante
            // 
            this.chkeliminarEstudiante.AutoSize = true;
            this.chkeliminarEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkeliminarEstudiante.Location = new System.Drawing.Point(706, 82);
            this.chkeliminarEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.chkeliminarEstudiante.Name = "chkeliminarEstudiante";
            this.chkeliminarEstudiante.Size = new System.Drawing.Size(250, 35);
            this.chkeliminarEstudiante.TabIndex = 4;
            this.chkeliminarEstudiante.Text = "Eliminar Estudiante";
            this.chkeliminarEstudiante.UseVisualStyleBackColor = true;
            // 
            // chkmodificarEstudiante
            // 
            this.chkmodificarEstudiante.AutoSize = true;
            this.chkmodificarEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkmodificarEstudiante.Location = new System.Drawing.Point(25, 82);
            this.chkmodificarEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.chkmodificarEstudiante.Name = "chkmodificarEstudiante";
            this.chkmodificarEstudiante.Size = new System.Drawing.Size(269, 35);
            this.chkmodificarEstudiante.TabIndex = 3;
            this.chkmodificarEstudiante.Text = "Modificar Estudiante";
            this.chkmodificarEstudiante.UseVisualStyleBackColor = true;
            // 
            // lblSeleccionarOperacion
            // 
            this.lblSeleccionarOperacion.AutoSize = true;
            this.lblSeleccionarOperacion.Font = new System.Drawing.Font("Balsamiq Sans", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarOperacion.Location = new System.Drawing.Point(323, 16);
            this.lblSeleccionarOperacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionarOperacion.Name = "lblSeleccionarOperacion";
            this.lblSeleccionarOperacion.Size = new System.Drawing.Size(392, 38);
            this.lblSeleccionarOperacion.TabIndex = 2;
            this.lblSeleccionarOperacion.Text = "Seleccione una operación";
            // 
            // cmbgeneroEstudiante
            // 
            this.cmbgeneroEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgeneroEstudiante.FormattingEnabled = true;
            this.cmbgeneroEstudiante.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbgeneroEstudiante.Location = new System.Drawing.Point(1237, 386);
            this.cmbgeneroEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.cmbgeneroEstudiante.Name = "cmbgeneroEstudiante";
            this.cmbgeneroEstudiante.Size = new System.Drawing.Size(283, 39);
            this.cmbgeneroEstudiante.TabIndex = 31;
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Font = new System.Drawing.Font("Balsamiq Sans", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenero.Location = new System.Drawing.Point(892, 385);
            this.lblgenero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(120, 37);
            this.lblgenero.TabIndex = 30;
            this.lblgenero.Text = "Género";
            // 
            // txtfechaNacimientoEstudiante
            // 
            this.txtfechaNacimientoEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechaNacimientoEstudiante.Location = new System.Drawing.Point(1237, 311);
            this.txtfechaNacimientoEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.txtfechaNacimientoEstudiante.Multiline = true;
            this.txtfechaNacimientoEstudiante.Name = "txtfechaNacimientoEstudiante";
            this.txtfechaNacimientoEstudiante.Size = new System.Drawing.Size(283, 32);
            this.txtfechaNacimientoEstudiante.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(892, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "Fecha Nacimiento";
            // 
            // ICrudEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1635, 1035);
            this.Controls.Add(this.PanregistroEncargado);
            this.Controls.Add(this.lblEstudiante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ICrudEstudiante";
            this.Text = "ICrudEstudiante";
            this.PanregistroEncargado.ResumeLayout(false);
            this.PanregistroEncargado.PerformLayout();
            this.gbOperaciones.ResumeLayout(false);
            this.gbOperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Panel PanregistroEncargado;
        private System.Windows.Forms.TextBox txtprimerApellido;
        private System.Windows.Forms.TextBox txtsegundoApellido;
        private System.Windows.Forms.TextBox txtprimerNombre;
        private System.Windows.Forms.TextBox txtsegundoNombre;
        private System.Windows.Forms.TextBox txtIdentidad;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.Label lblnumeroIdentidad;
        private System.Windows.Forms.Button btnrealizarOperacion;
        private System.Windows.Forms.GroupBox gbOperaciones;
        private System.Windows.Forms.CheckBox chkbuscarEstudiante;
        private System.Windows.Forms.CheckBox chkeliminarEstudiante;
        private System.Windows.Forms.CheckBox chkmodificarEstudiante;
        private System.Windows.Forms.Label lblSeleccionarOperacion;
        private System.Windows.Forms.ComboBox cmbgeneroEstudiante;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.TextBox txtfechaNacimientoEstudiante;
        private System.Windows.Forms.Label label1;
    }
}