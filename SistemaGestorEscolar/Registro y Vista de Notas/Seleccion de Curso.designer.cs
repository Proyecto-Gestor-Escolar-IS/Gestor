
namespace SistemaGestorEscolar.Modulos_de_Registro_y_Vista_de_Notas
{
    partial class Seleccion_de_Curso
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCursos = new System.Windows.Forms.ComboBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1055, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el curso y la seccion que desea consultar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Balsamiq Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(894, 204);
            this.label2.TabIndex = 1;
            this.label2.Text = "REGISTRO DE NOTAS\r\n   DE LOS ALUMNOS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbCursos
            // 
            this.cmbCursos.Font = new System.Drawing.Font("Balsamiq Sans", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCursos.FormattingEnabled = true;
            this.cmbCursos.Items.AddRange(new object[] {
            "Babies",
            "Infants",
            "Toodlers",
            "Nursery",
            "Pre Kinder",
            "Kinder",
            "Primer Grado"});
            this.cmbCursos.Location = new System.Drawing.Point(733, 573);
            this.cmbCursos.Name = "cmbCursos";
            this.cmbCursos.Size = new System.Drawing.Size(306, 55);
            this.cmbCursos.TabIndex = 2;
            this.cmbCursos.Text = "CURSO";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnContinuar.FlatAppearance.BorderSize = 0;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Balsamiq Sans", 21.2F, System.Drawing.FontStyle.Bold);
            this.btnContinuar.Location = new System.Drawing.Point(760, 882);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(250, 70);
            this.btnContinuar.TabIndex = 3;
            this.btnContinuar.Text = "CONTINUAR";
            this.btnContinuar.UseVisualStyleBackColor = false;
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.Font = new System.Drawing.Font("Balsamiq Sans", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K"});
            this.cmbSeccion.Location = new System.Drawing.Point(733, 727);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(306, 55);
            this.cmbSeccion.TabIndex = 4;
            this.cmbSeccion.Text = "SECCION";
            // 
            // Seleccion_de_Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1635, 1035);
            this.Controls.Add(this.cmbSeccion);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.cmbCursos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seleccion_de_Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCursos;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.ComboBox cmbSeccion;
    }
}