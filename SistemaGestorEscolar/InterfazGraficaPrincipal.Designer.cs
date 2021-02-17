
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
            this.panSuperior = new System.Windows.Forms.Panel();
            this.panLateral = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenuAtras = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenuMatriculaEstudiante = new System.Windows.Forms.Button();
            this.btnMenuVistaMatricula = new System.Windows.Forms.Button();
            this.btnMenuCursosDisponibles = new System.Windows.Forms.Button();
            this.btnMenuIngresoNotas = new System.Windows.Forms.Button();
            this.btnMenuRegistroPago = new System.Windows.Forms.Button();
            this.btnMenuPersonal = new System.Windows.Forms.Button();
            this.panLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panSuperior
            // 
            this.panSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(169)))));
            this.panSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSuperior.Location = new System.Drawing.Point(0, 0);
            this.panSuperior.Name = "panSuperior";
            this.panSuperior.Size = new System.Drawing.Size(1280, 45);
            this.panSuperior.TabIndex = 0;
            // 
            // panLateral
            // 
            this.panLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(169)))));
            this.panLateral.Controls.Add(this.btnMenuPersonal);
            this.panLateral.Controls.Add(this.btnMenuRegistroPago);
            this.panLateral.Controls.Add(this.btnMenuIngresoNotas);
            this.panLateral.Controls.Add(this.btnMenuCursosDisponibles);
            this.panLateral.Controls.Add(this.btnMenuVistaMatricula);
            this.panLateral.Controls.Add(this.btnMenuMatriculaEstudiante);
            this.panLateral.Controls.Add(this.btnMenuAtras);
            this.panLateral.Controls.Add(this.pictureBox1);
            this.panLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLateral.Location = new System.Drawing.Point(0, 45);
            this.panLateral.Name = "panLateral";
            this.panLateral.Size = new System.Drawing.Size(285, 675);
            this.panLateral.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.logohd;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(68, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 159);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenuAtras
            // 
            this.btnMenuAtras.BackColor = System.Drawing.Color.Red;
            this.btnMenuAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAtras.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAtras.ForeColor = System.Drawing.Color.White;
            this.btnMenuAtras.Location = new System.Drawing.Point(0, 209);
            this.btnMenuAtras.Name = "btnMenuAtras";
            this.btnMenuAtras.Size = new System.Drawing.Size(285, 44);
            this.btnMenuAtras.TabIndex = 1;
            this.btnMenuAtras.Text = "ATRAS";
            this.btnMenuAtras.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(285, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 675);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnMenuMatriculaEstudiante
            // 
            this.btnMenuMatriculaEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuMatriculaEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuMatriculaEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMatriculaEstudiante.ForeColor = System.Drawing.Color.Black;
            this.btnMenuMatriculaEstudiante.Location = new System.Drawing.Point(0, 286);
            this.btnMenuMatriculaEstudiante.Name = "btnMenuMatriculaEstudiante";
            this.btnMenuMatriculaEstudiante.Size = new System.Drawing.Size(285, 48);
            this.btnMenuMatriculaEstudiante.TabIndex = 2;
            this.btnMenuMatriculaEstudiante.Text = "MATRICULAR ESTUDIANTE";
            this.btnMenuMatriculaEstudiante.UseVisualStyleBackColor = false;
            // 
            // btnMenuVistaMatricula
            // 
            this.btnMenuVistaMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuVistaMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuVistaMatricula.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuVistaMatricula.ForeColor = System.Drawing.Color.Black;
            this.btnMenuVistaMatricula.Location = new System.Drawing.Point(0, 340);
            this.btnMenuVistaMatricula.Name = "btnMenuVistaMatricula";
            this.btnMenuVistaMatricula.Size = new System.Drawing.Size(285, 48);
            this.btnMenuVistaMatricula.TabIndex = 3;
            this.btnMenuVistaMatricula.Text = "VISTA DE MATRICULAS";
            this.btnMenuVistaMatricula.UseVisualStyleBackColor = false;
            // 
            // btnMenuCursosDisponibles
            // 
            this.btnMenuCursosDisponibles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuCursosDisponibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCursosDisponibles.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCursosDisponibles.ForeColor = System.Drawing.Color.Black;
            this.btnMenuCursosDisponibles.Location = new System.Drawing.Point(0, 394);
            this.btnMenuCursosDisponibles.Name = "btnMenuCursosDisponibles";
            this.btnMenuCursosDisponibles.Size = new System.Drawing.Size(285, 48);
            this.btnMenuCursosDisponibles.TabIndex = 4;
            this.btnMenuCursosDisponibles.Text = "CURSOS DISPONIBLES";
            this.btnMenuCursosDisponibles.UseVisualStyleBackColor = false;
            // 
            // btnMenuIngresoNotas
            // 
            this.btnMenuIngresoNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuIngresoNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuIngresoNotas.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuIngresoNotas.ForeColor = System.Drawing.Color.Black;
            this.btnMenuIngresoNotas.Location = new System.Drawing.Point(0, 448);
            this.btnMenuIngresoNotas.Name = "btnMenuIngresoNotas";
            this.btnMenuIngresoNotas.Size = new System.Drawing.Size(285, 48);
            this.btnMenuIngresoNotas.TabIndex = 5;
            this.btnMenuIngresoNotas.Text = "INGRESO DE NOTAS";
            this.btnMenuIngresoNotas.UseVisualStyleBackColor = false;
            // 
            // btnMenuRegistroPago
            // 
            this.btnMenuRegistroPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuRegistroPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRegistroPago.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRegistroPago.ForeColor = System.Drawing.Color.Black;
            this.btnMenuRegistroPago.Location = new System.Drawing.Point(0, 502);
            this.btnMenuRegistroPago.Name = "btnMenuRegistroPago";
            this.btnMenuRegistroPago.Size = new System.Drawing.Size(285, 48);
            this.btnMenuRegistroPago.TabIndex = 6;
            this.btnMenuRegistroPago.Text = "REGISTRAR PAGO";
            this.btnMenuRegistroPago.UseVisualStyleBackColor = false;
            // 
            // btnMenuPersonal
            // 
            this.btnMenuPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPersonal.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPersonal.ForeColor = System.Drawing.Color.Black;
            this.btnMenuPersonal.Location = new System.Drawing.Point(0, 556);
            this.btnMenuPersonal.Name = "btnMenuPersonal";
            this.btnMenuPersonal.Size = new System.Drawing.Size(285, 48);
            this.btnMenuPersonal.TabIndex = 7;
            this.btnMenuPersonal.Text = "PERSONAL";
            this.btnMenuPersonal.UseVisualStyleBackColor = false;
            // 
            // InterfazGraficaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panLateral);
            this.Controls.Add(this.panSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazGraficaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfazGraficaPrincipal";
            this.Load += new System.EventHandler(this.InterfazGraficaPrincipal_Load);
            this.panLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSuperior;
        private System.Windows.Forms.Panel panLateral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenuAtras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenuPersonal;
        private System.Windows.Forms.Button btnMenuRegistroPago;
        private System.Windows.Forms.Button btnMenuIngresoNotas;
        private System.Windows.Forms.Button btnMenuCursosDisponibles;
        private System.Windows.Forms.Button btnMenuVistaMatricula;
        private System.Windows.Forms.Button btnMenuMatriculaEstudiante;
    }
}