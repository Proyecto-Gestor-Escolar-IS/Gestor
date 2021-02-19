
namespace SistemaGestorEscolar.Modulos_de_Registro_y_Vista_de_Notas
{
    partial class Cuadro_de_Notas
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
            this.dgvNotaAlumnos = new System.Windows.Forms.DataGridView();
            this.txtBuscarAlumno = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notas de los Alumnos:";
            // 
            // dgvNotaAlumnos
            // 
            this.dgvNotaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotaAlumnos.Location = new System.Drawing.Point(-1, 125);
            this.dgvNotaAlumnos.Name = "dgvNotaAlumnos";
            this.dgvNotaAlumnos.RowHeadersWidth = 51;
            this.dgvNotaAlumnos.RowTemplate.Height = 24;
            this.dgvNotaAlumnos.Size = new System.Drawing.Size(1637, 913);
            this.dgvNotaAlumnos.TabIndex = 1;
            // 
            // txtBuscarAlumno
            // 
            this.txtBuscarAlumno.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarAlumno.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtBuscarAlumno.Location = new System.Drawing.Point(1285, 64);
            this.txtBuscarAlumno.Name = "txtBuscarAlumno";
            this.txtBuscarAlumno.Size = new System.Drawing.Size(206, 33);
            this.txtBuscarAlumno.TabIndex = 2;
            this.txtBuscarAlumno.Text = "Buscar un Alumno";
            this.txtBuscarAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Linen;
            this.btnSearch.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.search2_32px;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(1251, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // Cuadro_de_Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1635, 1035);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBuscarAlumno);
            this.Controls.Add(this.dgvNotaAlumnos);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cuadro_de_Notas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNotaAlumnos;
        private System.Windows.Forms.TextBox txtBuscarAlumno;
        private System.Windows.Forms.Button btnSearch;
    }
}