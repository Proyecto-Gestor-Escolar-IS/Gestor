
namespace SistemaGestorEscolar
{
    partial class IRegistroVisitaMedica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoExpediente = new System.Windows.Forms.TextBox();
            this.txtFechaRegistro = new System.Windows.Forms.TextBox();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.txtPosibleEnfermedad = new System.Windows.Forms.TextBox();
            this.txtMedicamentos = new System.Windows.Forms.TextBox();
            this.btnRegistrarVisitaMedica = new System.Windows.Forms.Button();
            this.dgvHistorialMedico = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panSintomas = new System.Windows.Forms.Panel();
            this.panPosibleEnfermedad = new System.Windows.Forms.Panel();
            this.panMedicamentos = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumeroIdentidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMedicos = new System.Windows.Forms.ComboBox();
            this.errorIdentidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(604, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "REGISTRO VISITA MEDICA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del Estudiante";
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Enabled = false;
            this.txtNombreEstudiante.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEstudiante.Location = new System.Drawing.Point(475, 217);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(380, 31);
            this.txtNombreEstudiante.TabIndex = 17;
            this.txtNombreEstudiante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreEstudiante.TextChanged += new System.EventHandler(this.txtNombreEstudiantetxtNombreEstudiante_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Medicamentos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "Posible Enfermedad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1047, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "Expediente No.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "Síntomas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(748, 617);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 31);
            this.label7.TabIndex = 22;
            this.label7.Text = "HISTORIAL";
            // 
            // txtNoExpediente
            // 
            this.txtNoExpediente.Enabled = false;
            this.txtNoExpediente.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoExpediente.Location = new System.Drawing.Point(1267, 156);
            this.txtNoExpediente.Name = "txtNoExpediente";
            this.txtNoExpediente.Size = new System.Drawing.Size(209, 31);
            this.txtNoExpediente.TabIndex = 23;
            this.txtNoExpediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNoExpediente.TextChanged += new System.EventHandler(this.txtNoExpediente_TextChanged);
            // 
            // txtFechaRegistro
            // 
            this.txtFechaRegistro.Enabled = false;
            this.txtFechaRegistro.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaRegistro.Location = new System.Drawing.Point(1267, 217);
            this.txtFechaRegistro.Name = "txtFechaRegistro";
            this.txtFechaRegistro.Size = new System.Drawing.Size(209, 31);
            this.txtFechaRegistro.TabIndex = 24;
            this.txtFechaRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSintomas
            // 
            this.txtSintomas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.txtSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSintomas.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSintomas.Location = new System.Drawing.Point(475, 341);
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(913, 24);
            this.txtSintomas.TabIndex = 25;
            this.txtSintomas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSintomas.TextChanged += new System.EventHandler(this.txtSintomas_TextChanged);
            // 
            // txtPosibleEnfermedad
            // 
            this.txtPosibleEnfermedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.txtPosibleEnfermedad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPosibleEnfermedad.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosibleEnfermedad.Location = new System.Drawing.Point(475, 403);
            this.txtPosibleEnfermedad.Name = "txtPosibleEnfermedad";
            this.txtPosibleEnfermedad.Size = new System.Drawing.Size(605, 24);
            this.txtPosibleEnfermedad.TabIndex = 26;
            this.txtPosibleEnfermedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMedicamentos
            // 
            this.txtMedicamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.txtMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMedicamentos.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicamentos.Location = new System.Drawing.Point(475, 469);
            this.txtMedicamentos.Name = "txtMedicamentos";
            this.txtMedicamentos.Size = new System.Drawing.Size(605, 24);
            this.txtMedicamentos.TabIndex = 27;
            this.txtMedicamentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMedicamentos.TextChanged += new System.EventHandler(this.txtMedicamentos_TextChanged);
            // 
            // btnRegistrarVisitaMedica
            // 
            this.btnRegistrarVisitaMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(197)))), ((int)(((byte)(248)))));
            this.btnRegistrarVisitaMedica.FlatAppearance.BorderSize = 0;
            this.btnRegistrarVisitaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVisitaMedica.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVisitaMedica.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarVisitaMedica.Location = new System.Drawing.Point(1186, 420);
            this.btnRegistrarVisitaMedica.Name = "btnRegistrarVisitaMedica";
            this.btnRegistrarVisitaMedica.Size = new System.Drawing.Size(272, 53);
            this.btnRegistrarVisitaMedica.TabIndex = 28;
            this.btnRegistrarVisitaMedica.Text = "REGISTRAR ";
            this.btnRegistrarVisitaMedica.UseVisualStyleBackColor = false;
            this.btnRegistrarVisitaMedica.Click += new System.EventHandler(this.btnRegistrarVisitaMedica_Click);
            // 
            // dgvHistorialMedico
            // 
            this.dgvHistorialMedico.AllowUserToAddRows = false;
            this.dgvHistorialMedico.AllowUserToDeleteRows = false;
            this.dgvHistorialMedico.AllowUserToOrderColumns = true;
            this.dgvHistorialMedico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHistorialMedico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvHistorialMedico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.dgvHistorialMedico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialMedico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorialMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorialMedico.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistorialMedico.Location = new System.Drawing.Point(76, 665);
            this.dgvHistorialMedico.Name = "dgvHistorialMedico";
            this.dgvHistorialMedico.ReadOnly = true;
            this.dgvHistorialMedico.Size = new System.Drawing.Size(1481, 336);
            this.dgvHistorialMedico.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1047, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 31);
            this.label8.TabIndex = 30;
            this.label8.Text = "Fecha Actual";
            // 
            // panSintomas
            // 
            this.panSintomas.BackColor = System.Drawing.Color.Black;
            this.panSintomas.Location = new System.Drawing.Point(475, 367);
            this.panSintomas.Name = "panSintomas";
            this.panSintomas.Size = new System.Drawing.Size(913, 2);
            this.panSintomas.TabIndex = 31;
            // 
            // panPosibleEnfermedad
            // 
            this.panPosibleEnfermedad.BackColor = System.Drawing.Color.Black;
            this.panPosibleEnfermedad.Location = new System.Drawing.Point(475, 429);
            this.panPosibleEnfermedad.Name = "panPosibleEnfermedad";
            this.panPosibleEnfermedad.Size = new System.Drawing.Size(605, 2);
            this.panPosibleEnfermedad.TabIndex = 32;
            this.panPosibleEnfermedad.Paint += new System.Windows.Forms.PaintEventHandler(this.panPosibleEnfermedad_Paint);
            // 
            // panMedicamentos
            // 
            this.panMedicamentos.BackColor = System.Drawing.Color.Black;
            this.panMedicamentos.Location = new System.Drawing.Point(475, 495);
            this.panMedicamentos.Name = "panMedicamentos";
            this.panMedicamentos.Size = new System.Drawing.Size(605, 2);
            this.panMedicamentos.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(175, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 31);
            this.label9.TabIndex = 34;
            this.label9.Text = "Número de Identidad ";
            // 
            // txtNumeroIdentidad
            // 
            this.txtNumeroIdentidad.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroIdentidad.Location = new System.Drawing.Point(475, 159);
            this.txtNumeroIdentidad.Name = "txtNumeroIdentidad";
            this.txtNumeroIdentidad.Size = new System.Drawing.Size(309, 31);
            this.txtNumeroIdentidad.TabIndex = 35;
            this.txtNumeroIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroIdentidad.TextChanged += new System.EventHandler(this.txtNumeroIdentidad_TextChanged_1);
            this.txtNumeroIdentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroIdentidad_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Balsamiq Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(175, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 31);
            this.label10.TabIndex = 36;
            this.label10.Text = "Médico Encargado";
            // 
            // cmbMedicos
            // 
            this.cmbMedicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicos.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicos.FormattingEnabled = true;
            this.cmbMedicos.Location = new System.Drawing.Point(475, 279);
            this.cmbMedicos.Name = "cmbMedicos";
            this.cmbMedicos.Size = new System.Drawing.Size(309, 32);
            this.cmbMedicos.TabIndex = 37;
            this.cmbMedicos.SelectedIndexChanged += new System.EventHandler(this.cmbMedicos_SelectedIndexChanged);
            // 
            // errorIdentidad
            // 
            this.errorIdentidad.ContainerControl = this;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(236)))), ((int)(((byte)(172)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Balsamiq Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(1186, 529);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(272, 50);
            this.btnLimpiar.TabIndex = 38;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // IRegistroVisitaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1635, 1035);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbMedicos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNumeroIdentidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panMedicamentos);
            this.Controls.Add(this.panPosibleEnfermedad);
            this.Controls.Add(this.panSintomas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvHistorialMedico);
            this.Controls.Add(this.btnRegistrarVisitaMedica);
            this.Controls.Add(this.txtMedicamentos);
            this.Controls.Add(this.txtPosibleEnfermedad);
            this.Controls.Add(this.txtSintomas);
            this.Controls.Add(this.txtFechaRegistro);
            this.Controls.Add(this.txtNoExpediente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreEstudiante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IRegistroVisitaMedica";
            this.Text = "IRegistroVisitaMedica";
            this.Load += new System.EventHandler(this.IRegistroVisitaMedica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoExpediente;
        private System.Windows.Forms.TextBox txtFechaRegistro;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.TextBox txtPosibleEnfermedad;
        private System.Windows.Forms.TextBox txtMedicamentos;
        private System.Windows.Forms.Button btnRegistrarVisitaMedica;
        private System.Windows.Forms.DataGridView dgvHistorialMedico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panSintomas;
        private System.Windows.Forms.Panel panPosibleEnfermedad;
        private System.Windows.Forms.Panel panMedicamentos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumeroIdentidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbMedicos;
        private System.Windows.Forms.ErrorProvider errorIdentidad;
        private System.Windows.Forms.Button btnLimpiar;
    }
}