
namespace SistemaGestorEscolar.Modulos_Estudiante
{
    partial class Ficha_Encargados_del_Estudiante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.btnmatricular = new System.Windows.Forms.Button();
            this.panSuperior = new System.Windows.Forms.Panel();
            this.panLateral = new System.Windows.Forms.Panel();
            this.btnMenuPersonal = new System.Windows.Forms.Button();
            this.btnMenuRegistroPago = new System.Windows.Forms.Button();
            this.btnMenuIngresoNotas = new System.Windows.Forms.Button();
            this.btnMenuCursosDisponibles = new System.Windows.Forms.Button();
            this.btnMenuVistaMatricula = new System.Windows.Forms.Button();
            this.btnMenuMatriculaEstudiante = new System.Windows.Forms.Button();
            this.btnMenuAtras = new System.Windows.Forms.Button();
            this.picImagotipo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrarPrograma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panSuperior.SuspendLayout();
            this.panLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(773, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ficha del Estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(818, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Encargados Estudiante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre estudiante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID estudiante";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Encargado,
            this.Identidad,
            this.Telefono,
            this.correo,
            this.direccion});
            this.dataGridView1.Location = new System.Drawing.Point(369, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1167, 636);
            this.dataGridView1.TabIndex = 9;
            // 
            // Encargado
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Encargado.DefaultCellStyle = dataGridViewCellStyle1;
            this.Encargado.HeaderText = "Encargado";
            this.Encargado.Name = "Encargado";
            this.Encargado.Width = 350;
            // 
            // Identidad
            // 
            this.Identidad.HeaderText = "Identidad";
            this.Identidad.Name = "Identidad";
            this.Identidad.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 120;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo Electrónico";
            this.correo.Name = "correo";
            this.correo.Width = 200;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.Width = 300;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1387, 936);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 40);
            this.button2.TabIndex = 17;
            this.button2.Text = "Siguiente";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnmatricular
            // 
            this.btnmatricular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnmatricular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmatricular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmatricular.Location = new System.Drawing.Point(337, 936);
            this.btnmatricular.Margin = new System.Windows.Forms.Padding(2);
            this.btnmatricular.Name = "btnmatricular";
            this.btnmatricular.Size = new System.Drawing.Size(162, 40);
            this.btnmatricular.TabIndex = 16;
            this.btnmatricular.Text = "Regresar";
            this.btnmatricular.UseVisualStyleBackColor = false;
            // 
            // panSuperior
            // 
            this.panSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(169)))));
            this.panSuperior.Controls.Add(this.button1);
            this.panSuperior.Controls.Add(this.button6);
            this.panSuperior.Controls.Add(this.button7);
            this.panSuperior.Controls.Add(this.btnMinimizar);
            this.panSuperior.Controls.Add(this.btnMaximizar);
            this.panSuperior.Controls.Add(this.btnCerrarPrograma);
            this.panSuperior.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSuperior.Location = new System.Drawing.Point(0, 0);
            this.panSuperior.Name = "panSuperior";
            this.panSuperior.Size = new System.Drawing.Size(1635, 45);
            this.panSuperior.TabIndex = 21;
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
            this.panLateral.Controls.Add(this.picImagotipo);
            this.panLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLateral.Location = new System.Drawing.Point(0, 45);
            this.panLateral.Name = "panLateral";
            this.panLateral.Size = new System.Drawing.Size(285, 990);
            this.panLateral.TabIndex = 22;
            // 
            // btnMenuPersonal
            // 
            this.btnMenuPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuPersonal.FlatAppearance.BorderSize = 0;
            this.btnMenuPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPersonal.ForeColor = System.Drawing.Color.Black;
            this.btnMenuPersonal.Location = new System.Drawing.Point(0, 556);
            this.btnMenuPersonal.Name = "btnMenuPersonal";
            this.btnMenuPersonal.Size = new System.Drawing.Size(285, 48);
            this.btnMenuPersonal.TabIndex = 7;
            this.btnMenuPersonal.Text = "PERSONAL";
            this.btnMenuPersonal.UseVisualStyleBackColor = false;
            // 
            // btnMenuRegistroPago
            // 
            this.btnMenuRegistroPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnMenuRegistroPago.FlatAppearance.BorderSize = 0;
            this.btnMenuRegistroPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuRegistroPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuRegistroPago.ForeColor = System.Drawing.Color.Black;
            this.btnMenuRegistroPago.Location = new System.Drawing.Point(0, 502);
            this.btnMenuRegistroPago.Name = "btnMenuRegistroPago";
            this.btnMenuRegistroPago.Size = new System.Drawing.Size(285, 48);
            this.btnMenuRegistroPago.TabIndex = 6;
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
            this.btnMenuIngresoNotas.Location = new System.Drawing.Point(0, 448);
            this.btnMenuIngresoNotas.Name = "btnMenuIngresoNotas";
            this.btnMenuIngresoNotas.Size = new System.Drawing.Size(285, 48);
            this.btnMenuIngresoNotas.TabIndex = 5;
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
            this.btnMenuCursosDisponibles.Location = new System.Drawing.Point(0, 394);
            this.btnMenuCursosDisponibles.Name = "btnMenuCursosDisponibles";
            this.btnMenuCursosDisponibles.Size = new System.Drawing.Size(285, 48);
            this.btnMenuCursosDisponibles.TabIndex = 4;
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
            this.btnMenuVistaMatricula.Location = new System.Drawing.Point(0, 340);
            this.btnMenuVistaMatricula.Name = "btnMenuVistaMatricula";
            this.btnMenuVistaMatricula.Size = new System.Drawing.Size(285, 48);
            this.btnMenuVistaMatricula.TabIndex = 3;
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
            this.btnMenuMatriculaEstudiante.Location = new System.Drawing.Point(0, 286);
            this.btnMenuMatriculaEstudiante.Name = "btnMenuMatriculaEstudiante";
            this.btnMenuMatriculaEstudiante.Size = new System.Drawing.Size(285, 48);
            this.btnMenuMatriculaEstudiante.TabIndex = 2;
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
            this.btnMenuAtras.Location = new System.Drawing.Point(0, 209);
            this.btnMenuAtras.Name = "btnMenuAtras";
            this.btnMenuAtras.Size = new System.Drawing.Size(285, 44);
            this.btnMenuAtras.TabIndex = 1;
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
            this.picImagotipo.TabIndex = 0;
            this.picImagotipo.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.minimize;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1501, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 5;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.maximize;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(1545, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 34);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.exitButton;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(1587, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 36);
            this.button7.TabIndex = 3;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.minimize;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(1786, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 35);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.maximize;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(1830, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(34, 34);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // btnCerrarPrograma
            // 
            this.btnCerrarPrograma.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.exitButton;
            this.btnCerrarPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarPrograma.FlatAppearance.BorderSize = 0;
            this.btnCerrarPrograma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPrograma.Location = new System.Drawing.Point(1872, 3);
            this.btnCerrarPrograma.Name = "btnCerrarPrograma";
            this.btnCerrarPrograma.Size = new System.Drawing.Size(36, 36);
            this.btnCerrarPrograma.TabIndex = 0;
            this.btnCerrarPrograma.UseVisualStyleBackColor = true;
            // 
            // Ficha_Encargados_del_Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1635, 1035);
            this.Controls.Add(this.panLateral);
            this.Controls.Add(this.panSuperior);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnmatricular);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ficha_Encargados_del_Estudiante";
            this.ShowInTaskbar = false;
            this.Text = "Ficha_Encargados_del_Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panSuperior.ResumeLayout(false);
            this.panLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagotipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnmatricular;
        private System.Windows.Forms.Panel panSuperior;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrarPrograma;
        private System.Windows.Forms.Panel panLateral;
        private System.Windows.Forms.Button btnMenuPersonal;
        private System.Windows.Forms.Button btnMenuRegistroPago;
        private System.Windows.Forms.Button btnMenuIngresoNotas;
        private System.Windows.Forms.Button btnMenuCursosDisponibles;
        private System.Windows.Forms.Button btnMenuVistaMatricula;
        private System.Windows.Forms.Button btnMenuMatriculaEstudiante;
        private System.Windows.Forms.Button btnMenuAtras;
        private System.Windows.Forms.PictureBox picImagotipo;
    }
}