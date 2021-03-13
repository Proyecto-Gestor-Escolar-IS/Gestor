
namespace SistemaGestorEscolar.Registro_y_Vista_de_Notas
{
    partial class Alumnos_CursoSeccion
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
            this.gbAlumnos_CursoSeccion = new System.Windows.Forms.GroupBox();
            this.dgvAlumnos_CS = new System.Windows.Forms.DataGridView();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pbRegresar = new System.Windows.Forms.PictureBox();
            this.gbAlumnos_CursoSeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos_CS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAlumnos_CursoSeccion
            // 
            this.gbAlumnos_CursoSeccion.Controls.Add(this.dgvAlumnos_CS);
            this.gbAlumnos_CursoSeccion.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlumnos_CursoSeccion.Location = new System.Drawing.Point(135, 114);
            this.gbAlumnos_CursoSeccion.Name = "gbAlumnos_CursoSeccion";
            this.gbAlumnos_CursoSeccion.Size = new System.Drawing.Size(892, 485);
            this.gbAlumnos_CursoSeccion.TabIndex = 0;
            this.gbAlumnos_CursoSeccion.TabStop = false;
            this.gbAlumnos_CursoSeccion.Text = "Alumnos del Curso y Sección seleccionados:";
            // 
            // dgvAlumnos_CS
            // 
            this.dgvAlumnos_CS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnos_CS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos_CS.Location = new System.Drawing.Point(6, 30);
            this.dgvAlumnos_CS.Name = "dgvAlumnos_CS";
            this.dgvAlumnos_CS.Size = new System.Drawing.Size(880, 449);
            this.dgvAlumnos_CS.TabIndex = 0;
            this.dgvAlumnos_CS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CS_CellClick);
            this.dgvAlumnos_CS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CS_CellContentClick);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Balsamiq Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(521, 629);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(193, 47);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // pbRegresar
            // 
            this.pbRegresar.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.iconBackResized;
            this.pbRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRegresar.Location = new System.Drawing.Point(38, 32);
            this.pbRegresar.Name = "pbRegresar";
            this.pbRegresar.Size = new System.Drawing.Size(38, 32);
            this.pbRegresar.TabIndex = 2;
            this.pbRegresar.TabStop = false;
            this.pbRegresar.Click += new System.EventHandler(this.pbRegresar_Click);
            // 
            // Alumnos_CursoSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1167, 718);
            this.Controls.Add(this.pbRegresar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.gbAlumnos_CursoSeccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alumnos_CursoSeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos_CursoSeccion";
            this.Load += new System.EventHandler(this.Alumnos_CursoSeccion_Load);
            this.gbAlumnos_CursoSeccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos_CS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAlumnos_CursoSeccion;
        private System.Windows.Forms.DataGridView dgvAlumnos_CS;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.PictureBox pbRegresar;
    }
}