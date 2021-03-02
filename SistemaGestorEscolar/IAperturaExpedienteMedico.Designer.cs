
namespace SistemaGestorEscolar
{
    partial class IAperturaExpedienteMedico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoExpediente = new System.Windows.Forms.TextBox();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.txtFechaCreacion = new System.Windows.Forms.TextBox();
            this.txtAntecedenteMedico = new System.Windows.Forms.TextBox();
            this.btnRegistrarAntecedente = new System.Windows.Forms.Button();
            this.panAntecedentes = new System.Windows.Forms.Panel();
            this.txtNumeroIdentidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(550, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "APERTURA EXPEDIENTE MEDICO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Expediente No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre del Estudiante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(509, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de Creación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(680, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Antecedentes Médicos";
            // 
            // txtNoExpediente
            // 
            this.txtNoExpediente.Enabled = false;
            this.txtNoExpediente.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoExpediente.Location = new System.Drawing.Point(829, 242);
            this.txtNoExpediente.Name = "txtNoExpediente";
            this.txtNoExpediente.Size = new System.Drawing.Size(191, 28);
            this.txtNoExpediente.TabIndex = 16;
            this.txtNoExpediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNoExpediente.TextChanged += new System.EventHandler(this.txtNoExpediente_TextChanged);
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Enabled = false;
            this.txtNombreEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEstudiante.Location = new System.Drawing.Point(830, 392);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(366, 28);
            this.txtNombreEstudiante.TabIndex = 17;
            this.txtNombreEstudiante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreEstudiante.TextChanged += new System.EventHandler(this.txtNombreEstudiante_TextChanged);
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Enabled = false;
            this.txtFechaCreacion.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaCreacion.Location = new System.Drawing.Point(829, 484);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.Size = new System.Drawing.Size(279, 28);
            this.txtFechaCreacion.TabIndex = 18;
            this.txtFechaCreacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAntecedenteMedico
            // 
            this.txtAntecedenteMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.txtAntecedenteMedico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAntecedenteMedico.Enabled = false;
            this.txtAntecedenteMedico.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAntecedenteMedico.Location = new System.Drawing.Point(292, 675);
            this.txtAntecedenteMedico.Multiline = true;
            this.txtAntecedenteMedico.Name = "txtAntecedenteMedico";
            this.txtAntecedenteMedico.Size = new System.Drawing.Size(1053, 58);
            this.txtAntecedenteMedico.TabIndex = 19;
            this.txtAntecedenteMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAntecedenteMedico.TextChanged += new System.EventHandler(this.txtAntecedenteMedico_TextChanged);
            // 
            // btnRegistrarAntecedente
            // 
            this.btnRegistrarAntecedente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnRegistrarAntecedente.Enabled = false;
            this.btnRegistrarAntecedente.FlatAppearance.BorderSize = 0;
            this.btnRegistrarAntecedente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarAntecedente.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAntecedente.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarAntecedente.Location = new System.Drawing.Point(682, 866);
            this.btnRegistrarAntecedente.Name = "btnRegistrarAntecedente";
            this.btnRegistrarAntecedente.Size = new System.Drawing.Size(272, 53);
            this.btnRegistrarAntecedente.TabIndex = 20;
            this.btnRegistrarAntecedente.Text = "REGISTRAR ";
            this.btnRegistrarAntecedente.UseVisualStyleBackColor = false;
            this.btnRegistrarAntecedente.Click += new System.EventHandler(this.btnRegistrarAntecedente_Click);
            // 
            // panAntecedentes
            // 
            this.panAntecedentes.BackColor = System.Drawing.Color.Black;
            this.panAntecedentes.Location = new System.Drawing.Point(292, 728);
            this.panAntecedentes.Name = "panAntecedentes";
            this.panAntecedentes.Size = new System.Drawing.Size(1053, 2);
            this.panAntecedentes.TabIndex = 22;
            // 
            // txtNumeroIdentidad
            // 
            this.txtNumeroIdentidad.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroIdentidad.Location = new System.Drawing.Point(830, 315);
            this.txtNumeroIdentidad.Name = "txtNumeroIdentidad";
            this.txtNumeroIdentidad.Size = new System.Drawing.Size(278, 28);
            this.txtNumeroIdentidad.TabIndex = 37;
            this.txtNumeroIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroIdentidad.TextChanged += new System.EventHandler(this.txtNumeroIdentidad_TextChanged);
            this.txtNumeroIdentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroIdentidad_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(509, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 31);
            this.label9.TabIndex = 36;
            this.label9.Text = "Número de Identidad ";
            // 
            // errorIdentidad
            // 
            this.errorIdentidad.ContainerControl = this;
            // 
            // IAperturaExpedienteMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1635, 1035);
            this.Controls.Add(this.txtNumeroIdentidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panAntecedentes);
            this.Controls.Add(this.btnRegistrarAntecedente);
            this.Controls.Add(this.txtAntecedenteMedico);
            this.Controls.Add(this.txtFechaCreacion);
            this.Controls.Add(this.txtNombreEstudiante);
            this.Controls.Add(this.txtNoExpediente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IAperturaExpedienteMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IAperturaExpedienteMedico";
            this.Load += new System.EventHandler(this.IAperturaExpedienteMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNoExpediente;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.TextBox txtFechaCreacion;
        private System.Windows.Forms.TextBox txtAntecedenteMedico;
        private System.Windows.Forms.Button btnRegistrarAntecedente;
        private System.Windows.Forms.Panel panAntecedentes;
        private System.Windows.Forms.TextBox txtNumeroIdentidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorIdentidad;
    }
}