
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaAlumnos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notas de los Alumnos:";
            // 
            // dgvNotaAlumnos
            // 
            this.dgvNotaAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotaAlumnos.Location = new System.Drawing.Point(6, 20);
            this.dgvNotaAlumnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNotaAlumnos.Name = "dgvNotaAlumnos";
            this.dgvNotaAlumnos.RowHeadersWidth = 51;
            this.dgvNotaAlumnos.RowTemplate.Height = 24;
            this.dgvNotaAlumnos.Size = new System.Drawing.Size(1545, 754);
            this.dgvNotaAlumnos.TabIndex = 1;
            // 
            // txtBuscarAlumno
            // 
            this.txtBuscarAlumno.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarAlumno.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtBuscarAlumno.Location = new System.Drawing.Point(1235, 53);
            this.txtBuscarAlumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarAlumno.Name = "txtBuscarAlumno";
            this.txtBuscarAlumno.Size = new System.Drawing.Size(207, 33);
            this.txtBuscarAlumno.TabIndex = 2;
            this.txtBuscarAlumno.Text = "Buscar un Alumno";
            this.txtBuscarAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Linen;
            this.btnSearch.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.buscarIcono;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(1206, 54);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNotaAlumnos);
            this.groupBox1.Font = new System.Drawing.Font("Balsamiq Sans", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1557, 793);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Cuadro_de_Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBuscarAlumno);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cuadro_de_Notas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Cuadro_de_Notas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaAlumnos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNotaAlumnos;
        private System.Windows.Forms.TextBox txtBuscarAlumno;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}