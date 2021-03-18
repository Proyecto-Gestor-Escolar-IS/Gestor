
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
            this.components = new System.ComponentModel.Container();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.PanregistroEncargado = new System.Windows.Forms.Panel();
            this.txtfechaNacimientoEstud = new System.Windows.Forms.TextBox();
            this.cmbgeneroEstudiante = new System.Windows.Forms.ComboBox();
            this.lblgenero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprimerApellidoEstud = new System.Windows.Forms.TextBox();
            this.txtsegundoApellidoEstud = new System.Windows.Forms.TextBox();
            this.txtprimerNombreEstud = new System.Windows.Forms.TextBox();
            this.txtsegundoNombreEstud = new System.Windows.Forms.TextBox();
            this.txtIdentidadEstud = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblnombres = new System.Windows.Forms.Label();
            this.lblnumeroIdentidad = new System.Windows.Forms.Label();
            this.btnrealizarOperacion = new System.Windows.Forms.Button();
            this.errorIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanregistroEncargado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentidad)).BeginInit();
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
            this.PanregistroEncargado.Controls.Add(this.txtfechaNacimientoEstud);
            this.PanregistroEncargado.Controls.Add(this.cmbgeneroEstudiante);
            this.PanregistroEncargado.Controls.Add(this.lblgenero);
            this.PanregistroEncargado.Controls.Add(this.label1);
            this.PanregistroEncargado.Controls.Add(this.txtprimerApellidoEstud);
            this.PanregistroEncargado.Controls.Add(this.txtsegundoApellidoEstud);
            this.PanregistroEncargado.Controls.Add(this.txtprimerNombreEstud);
            this.PanregistroEncargado.Controls.Add(this.txtsegundoNombreEstud);
            this.PanregistroEncargado.Controls.Add(this.txtIdentidadEstud);
            this.PanregistroEncargado.Controls.Add(this.lblApellidos);
            this.PanregistroEncargado.Controls.Add(this.lblnombres);
            this.PanregistroEncargado.Controls.Add(this.lblnumeroIdentidad);
            this.PanregistroEncargado.Controls.Add(this.btnrealizarOperacion);
            this.PanregistroEncargado.Font = new System.Drawing.Font("Balsamiq Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanregistroEncargado.Location = new System.Drawing.Point(59, 80);
            this.PanregistroEncargado.Margin = new System.Windows.Forms.Padding(2);
            this.PanregistroEncargado.Name = "PanregistroEncargado";
            this.PanregistroEncargado.Size = new System.Drawing.Size(1478, 672);
            this.PanregistroEncargado.TabIndex = 47;
            this.PanregistroEncargado.Paint += new System.Windows.Forms.PaintEventHandler(this.PanregistroEncargado_Paint);
            // 
            // txtfechaNacimientoEstud
            // 
            this.txtfechaNacimientoEstud.Font = new System.Drawing.Font("Balsamiq Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechaNacimientoEstud.Location = new System.Drawing.Point(1170, 167);
            this.txtfechaNacimientoEstud.Multiline = true;
            this.txtfechaNacimientoEstud.Name = "txtfechaNacimientoEstud";
            this.txtfechaNacimientoEstud.Size = new System.Drawing.Size(285, 33);
            this.txtfechaNacimientoEstud.TabIndex = 32;
            // 
            // cmbgeneroEstudiante
            // 
            this.cmbgeneroEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgeneroEstudiante.FormattingEnabled = true;
            this.cmbgeneroEstudiante.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cmbgeneroEstudiante.Location = new System.Drawing.Point(1172, 249);
            this.cmbgeneroEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.cmbgeneroEstudiante.Name = "cmbgeneroEstudiante";
            this.cmbgeneroEstudiante.Size = new System.Drawing.Size(283, 39);
            this.cmbgeneroEstudiante.TabIndex = 31;
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Font = new System.Drawing.Font("Balsamiq Sans", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenero.Location = new System.Drawing.Point(827, 248);
            this.lblgenero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(120, 37);
            this.lblgenero.TabIndex = 30;
            this.lblgenero.Text = "Género";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(827, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "Fecha Nacimiento";
            // 
            // txtprimerApellidoEstud
            // 
            this.txtprimerApellidoEstud.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprimerApellidoEstud.Location = new System.Drawing.Point(304, 324);
            this.txtprimerApellidoEstud.Margin = new System.Windows.Forms.Padding(2);
            this.txtprimerApellidoEstud.Multiline = true;
            this.txtprimerApellidoEstud.Name = "txtprimerApellidoEstud";
            this.txtprimerApellidoEstud.Size = new System.Drawing.Size(176, 32);
            this.txtprimerApellidoEstud.TabIndex = 15;
            this.txtprimerApellidoEstud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprimerApellido_KeyPress);
            // 
            // txtsegundoApellidoEstud
            // 
            this.txtsegundoApellidoEstud.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsegundoApellidoEstud.Location = new System.Drawing.Point(484, 324);
            this.txtsegundoApellidoEstud.Margin = new System.Windows.Forms.Padding(2);
            this.txtsegundoApellidoEstud.Multiline = true;
            this.txtsegundoApellidoEstud.Name = "txtsegundoApellidoEstud";
            this.txtsegundoApellidoEstud.Size = new System.Drawing.Size(168, 32);
            this.txtsegundoApellidoEstud.TabIndex = 14;
            this.txtsegundoApellidoEstud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsegundoApellido_KeyPress);
            // 
            // txtprimerNombreEstud
            // 
            this.txtprimerNombreEstud.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprimerNombreEstud.Location = new System.Drawing.Point(304, 245);
            this.txtprimerNombreEstud.Margin = new System.Windows.Forms.Padding(2);
            this.txtprimerNombreEstud.Multiline = true;
            this.txtprimerNombreEstud.Name = "txtprimerNombreEstud";
            this.txtprimerNombreEstud.Size = new System.Drawing.Size(176, 32);
            this.txtprimerNombreEstud.TabIndex = 13;
            this.txtprimerNombreEstud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprimerNombre_KeyPress);
            // 
            // txtsegundoNombreEstud
            // 
            this.txtsegundoNombreEstud.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsegundoNombreEstud.Location = new System.Drawing.Point(484, 245);
            this.txtsegundoNombreEstud.Margin = new System.Windows.Forms.Padding(2);
            this.txtsegundoNombreEstud.Multiline = true;
            this.txtsegundoNombreEstud.Name = "txtsegundoNombreEstud";
            this.txtsegundoNombreEstud.Size = new System.Drawing.Size(168, 32);
            this.txtsegundoNombreEstud.TabIndex = 12;
            this.txtsegundoNombreEstud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsegundoNombre_KeyPress);
            // 
            // txtIdentidadEstud
            // 
            this.txtIdentidadEstud.Font = new System.Drawing.Font("Balsamiq Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidadEstud.Location = new System.Drawing.Point(304, 167);
            this.txtIdentidadEstud.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentidadEstud.Multiline = true;
            this.txtIdentidadEstud.Name = "txtIdentidadEstud";
            this.txtIdentidadEstud.Size = new System.Drawing.Size(348, 32);
            this.txtIdentidadEstud.TabIndex = 10;
            this.txtIdentidadEstud.TextChanged += new System.EventHandler(this.txtIdentidad_TextChanged);
            this.txtIdentidadEstud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentidad_KeyPress);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Balsamiq Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(52, 326);
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
            this.lblnombres.Location = new System.Drawing.Point(52, 245);
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
            this.lblnumeroIdentidad.Location = new System.Drawing.Point(52, 169);
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
            // errorIdentidad
            // 
            this.errorIdentidad.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Panel PanregistroEncargado;
        private System.Windows.Forms.TextBox txtprimerApellidoEstud;
        private System.Windows.Forms.TextBox txtsegundoApellidoEstud;
        private System.Windows.Forms.TextBox txtprimerNombreEstud;
        private System.Windows.Forms.TextBox txtsegundoNombreEstud;
        private System.Windows.Forms.TextBox txtIdentidadEstud;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.Label lblnumeroIdentidad;
        private System.Windows.Forms.Button btnrealizarOperacion;
        private System.Windows.Forms.ComboBox cmbgeneroEstudiante;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorIdentidad;
        private System.Windows.Forms.TextBox txtfechaNacimientoEstud;
    }
}