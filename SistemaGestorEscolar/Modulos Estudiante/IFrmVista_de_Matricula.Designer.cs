﻿
namespace SistemaGestorEscolar.Modulos_Estudiante
{
    partial class IFrmVista_de_Matricula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpSeleccionCS = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.abContinuar = new AltoControls.AltoButton();
            this.gpVistaM = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvVistaMatricula = new System.Windows.Forms.DataGridView();
            this.gpSeleccionCS.SuspendLayout();
            this.gpVistaM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaMatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // gpSeleccionCS
            // 
            this.gpSeleccionCS.Controls.Add(this.abContinuar);
            this.gpSeleccionCS.Controls.Add(this.cmbSeccion);
            this.gpSeleccionCS.Controls.Add(this.cmbCurso);
            this.gpSeleccionCS.Controls.Add(this.label2);
            this.gpSeleccionCS.Controls.Add(this.label1);
            this.gpSeleccionCS.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSeleccionCS.Location = new System.Drawing.Point(12, 23);
            this.gpSeleccionCS.Name = "gpSeleccionCS";
            this.gpSeleccionCS.Size = new System.Drawing.Size(1611, 1000);
            this.gpSeleccionCS.TabIndex = 0;
            this.gpSeleccionCS.TabStop = false;
            this.gpSeleccionCS.Text = "Selección de Curso y Sección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(642, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vista de Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Balsamiq Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(570, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione un Curso y una Sección:";
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Items.AddRange(new object[] {
            "Nursery",
            "Pre-Kinder",
            "Kinder",
            "Primer Grado"});
            this.cmbCurso.Location = new System.Drawing.Point(716, 459);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(185, 34);
            this.cmbCurso.TabIndex = 2;
            this.cmbCurso.Text = "CURSO";
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Location = new System.Drawing.Point(716, 555);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(185, 34);
            this.cmbSeccion.TabIndex = 3;
            this.cmbSeccion.Text = "SECCIÓN";
            this.cmbSeccion.SelectedIndexChanged += new System.EventHandler(this.cmbSeccion_SelectedIndexChanged);
            // 
            // abContinuar
            // 
            this.abContinuar.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.abContinuar.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.abContinuar.BackColor = System.Drawing.Color.Transparent;
            this.abContinuar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.abContinuar.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abContinuar.ForeColor = System.Drawing.Color.Black;
            this.abContinuar.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.abContinuar.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.abContinuar.Location = new System.Drawing.Point(692, 685);
            this.abContinuar.Name = "abContinuar";
            this.abContinuar.Radius = 10;
            this.abContinuar.Size = new System.Drawing.Size(243, 56);
            this.abContinuar.Stroke = false;
            this.abContinuar.StrokeColor = System.Drawing.Color.Gray;
            this.abContinuar.TabIndex = 4;
            this.abContinuar.Text = "Continuar";
            this.abContinuar.Transparency = false;
            this.abContinuar.Click += new System.EventHandler(this.abContinuar_Click_1);
            // 
            // gpVistaM
            // 
            this.gpVistaM.Controls.Add(this.dgvVistaMatricula);
            this.gpVistaM.Controls.Add(this.label3);
            this.gpVistaM.Controls.Add(this.pictureBox1);
            this.gpVistaM.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpVistaM.Location = new System.Drawing.Point(18, 23);
            this.gpVistaM.Name = "gpVistaM";
            this.gpVistaM.Size = new System.Drawing.Size(1605, 1000);
            this.gpVistaM.TabIndex = 5;
            this.gpVistaM.TabStop = false;
            this.gpVistaM.Text = "Vista de Matrícula:";
            this.gpVistaM.VisibleChanged += new System.EventHandler(this.gpVistaM_VisibleChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SistemaGestorEscolar.Properties.Resources.iconBackResized;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(247, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 35);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Balsamiq Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(668, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "Alumnos Matriculados:";
            // 
            // dgvVistaMatricula
            // 
            this.dgvVistaMatricula.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVistaMatricula.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvVistaMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVistaMatricula.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvVistaMatricula.Location = new System.Drawing.Point(6, 270);
            this.dgvVistaMatricula.Name = "dgvVistaMatricula";
            this.dgvVistaMatricula.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVistaMatricula.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvVistaMatricula.Size = new System.Drawing.Size(1593, 724);
            this.dgvVistaMatricula.TabIndex = 3;
            // 
            // IFrmVista_de_Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1635, 1035);
            this.Controls.Add(this.gpSeleccionCS);
            this.Controls.Add(this.gpVistaM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IFrmVista_de_Matricula";
            this.Text = "IFrmVista_de_Matricula";
            this.Load += new System.EventHandler(this.IFrmVista_de_Matricula_Load);
            this.gpSeleccionCS.ResumeLayout(false);
            this.gpSeleccionCS.PerformLayout();
            this.gpVistaM.ResumeLayout(false);
            this.gpVistaM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaMatricula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpSeleccionCS;
        private AltoControls.AltoButton abContinuar;
        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpVistaM;
        private System.Windows.Forms.DataGridView dgvVistaMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}