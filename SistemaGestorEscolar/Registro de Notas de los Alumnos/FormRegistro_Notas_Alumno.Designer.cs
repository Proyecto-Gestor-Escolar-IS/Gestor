
namespace SistemaGestorEscolar
{
    partial class FormRegistro_Notas_Alumno
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMenuRegistroPago = new System.Windows.Forms.Button();
            this.btnMenuIngresoNotas = new System.Windows.Forms.Button();
            this.btnMenuCursosDisponibles = new System.Windows.Forms.Button();
            this.btnMenuVistaMatricula = new System.Windows.Forms.Button();
            this.btnMenuMatriculaEstudiante = new System.Windows.Forms.Button();
            this.btnMenuAtras = new System.Windows.Forms.Button();
            this.picImagotipo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE NOTAS DE LOS ALUMNOS";
            // 
            // cmbCursos
            // 
            this.cmbCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Items.AddRange(new object[] {
            "Babies",
            "Infants",
            "Toodlers",
            "Nursery",
            "Pre Kinder",
            "Kinder",
            "Primer Grado"});
            this.cmbCursos.Location = new System.Drawing.Point(579, 341);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(241, 28);
            this.cmbCursos.TabIndex = 3;
            this.cmbCursos.Text = "CURSOS";
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Items.AddRange(new object[] {
            "Sección: \"A\"",
            "Sección: \"B\""});
            this.cmbSeccion.Location = new System.Drawing.Point(1037, 341);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(241, 28);
            this.cmbSeccion.TabIndex = 4;
            this.cmbSeccion.Text = "SECCION";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.Black;
            this.btnContinuar.Location = new System.Drawing.Point(820, 478);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(219, 48);
            this.btnContinuar.TabIndex = 7;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(169)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1556, 45);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(169)))));
            this.panel2.Controls.Add(this.btnMenuRegistroPago);
            this.panel2.Controls.Add(this.btnMenuIngresoNotas);
            this.panel2.Controls.Add(this.btnMenuCursosDisponibles);
            this.panel2.Controls.Add(this.btnMenuVistaMatricula);
            this.panel2.Controls.Add(this.btnMenuMatriculaEstudiante);
            this.panel2.Controls.Add(this.btnMenuAtras);
            this.panel2.Controls.Add(this.picImagotipo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 839);
            this.panel2.TabIndex = 9;
            // 
            // btnMenuRegistroPago
            // 
            this.btnMenuRegistroPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuRegistroPago.FlatAppearance.BorderSize = 0;
            this.btnMenuRegistroPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRegistroPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRegistroPago.ForeColor = System.Drawing.Color.Black;
            this.btnMenuRegistroPago.Location = new System.Drawing.Point(0, 503);
            this.btnMenuRegistroPago.Name = "btnMenuRegistroPago";
            this.btnMenuRegistroPago.Size = new System.Drawing.Size(285, 48);
            this.btnMenuRegistroPago.TabIndex = 11;
            this.btnMenuRegistroPago.Text = "REGISTRAR PAGO";
            this.btnMenuRegistroPago.UseVisualStyleBackColor = false;
            // 
            // btnMenuIngresoNotas
            // 
            this.btnMenuIngresoNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuIngresoNotas.FlatAppearance.BorderSize = 0;
            this.btnMenuIngresoNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuIngresoNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuIngresoNotas.ForeColor = System.Drawing.Color.Black;
            this.btnMenuIngresoNotas.Location = new System.Drawing.Point(0, 449);
            this.btnMenuIngresoNotas.Name = "btnMenuIngresoNotas";
            this.btnMenuIngresoNotas.Size = new System.Drawing.Size(285, 48);
            this.btnMenuIngresoNotas.TabIndex = 10;
            this.btnMenuIngresoNotas.Text = "INGRESO DE NOTAS";
            this.btnMenuIngresoNotas.UseVisualStyleBackColor = false;
            // 
            // btnMenuCursosDisponibles
            // 
            this.btnMenuCursosDisponibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuCursosDisponibles.FlatAppearance.BorderSize = 0;
            this.btnMenuCursosDisponibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCursosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCursosDisponibles.ForeColor = System.Drawing.Color.Black;
            this.btnMenuCursosDisponibles.Location = new System.Drawing.Point(0, 395);
            this.btnMenuCursosDisponibles.Name = "btnMenuCursosDisponibles";
            this.btnMenuCursosDisponibles.Size = new System.Drawing.Size(285, 48);
            this.btnMenuCursosDisponibles.TabIndex = 9;
            this.btnMenuCursosDisponibles.Text = "CURSOS DISPONIBLES";
            this.btnMenuCursosDisponibles.UseVisualStyleBackColor = false;
            // 
            // btnMenuVistaMatricula
            // 
            this.btnMenuVistaMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuVistaMatricula.FlatAppearance.BorderSize = 0;
            this.btnMenuVistaMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuVistaMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuVistaMatricula.ForeColor = System.Drawing.Color.Black;
            this.btnMenuVistaMatricula.Location = new System.Drawing.Point(0, 341);
            this.btnMenuVistaMatricula.Name = "btnMenuVistaMatricula";
            this.btnMenuVistaMatricula.Size = new System.Drawing.Size(285, 48);
            this.btnMenuVistaMatricula.TabIndex = 8;
            this.btnMenuVistaMatricula.Text = "VISTA DE MATRICULAS";
            this.btnMenuVistaMatricula.UseVisualStyleBackColor = false;
            // 
            // btnMenuMatriculaEstudiante
            // 
            this.btnMenuMatriculaEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuMatriculaEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenuMatriculaEstudiante.FlatAppearance.BorderSize = 0;
            this.btnMenuMatriculaEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMatriculaEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMatriculaEstudiante.ForeColor = System.Drawing.Color.Black;
            this.btnMenuMatriculaEstudiante.Location = new System.Drawing.Point(0, 287);
            this.btnMenuMatriculaEstudiante.Name = "btnMenuMatriculaEstudiante";
            this.btnMenuMatriculaEstudiante.Size = new System.Drawing.Size(285, 48);
            this.btnMenuMatriculaEstudiante.TabIndex = 7;
            this.btnMenuMatriculaEstudiante.Text = "MATRICULAR ESTUDIANTE";
            this.btnMenuMatriculaEstudiante.UseVisualStyleBackColor = false;
            // 
            // btnMenuAtras
            // 
            this.btnMenuAtras.BackColor = System.Drawing.Color.Red;
            this.btnMenuAtras.FlatAppearance.BorderSize = 0;
            this.btnMenuAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAtras.ForeColor = System.Drawing.Color.White;
            this.btnMenuAtras.Location = new System.Drawing.Point(-3, 221);
            this.btnMenuAtras.Name = "btnMenuAtras";
            this.btnMenuAtras.Size = new System.Drawing.Size(285, 44);
            this.btnMenuAtras.TabIndex = 2;
            this.btnMenuAtras.Text = "ATRAS";
            this.btnMenuAtras.UseVisualStyleBackColor = false;
            // 
            // picImagotipo
            // 
            this.picImagotipo.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.Logo_Nazaret;
            this.picImagotipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picImagotipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picImagotipo.Location = new System.Drawing.Point(0, 0);
            this.picImagotipo.Name = "picImagotipo";
            this.picImagotipo.Size = new System.Drawing.Size(285, 182);
            this.picImagotipo.TabIndex = 1;
            this.picImagotipo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(580, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seleccione el curso y la seccion que desea consultar:";
            // 
            // FormRegistro_Notas_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.cmbSeccion);
            this.Controls.Add(this.cmbCursos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRegistro_Notas_Alumno";
            this.Text = "FormRegistro_Notas_Alumno";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagotipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picImagotipo;
        private System.Windows.Forms.Button btnMenuAtras;
        private System.Windows.Forms.Button btnMenuRegistroPago;
        private System.Windows.Forms.Button btnMenuIngresoNotas;
        private System.Windows.Forms.Button btnMenuCursosDisponibles;
        private System.Windows.Forms.Button btnMenuVistaMatricula;
        private System.Windows.Forms.Button btnMenuMatriculaEstudiante;
        private System.Windows.Forms.Label label3;
    }
}