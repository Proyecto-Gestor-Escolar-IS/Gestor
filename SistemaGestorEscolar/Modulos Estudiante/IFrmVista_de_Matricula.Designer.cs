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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpSeleccionCS = new System.Windows.Forms.GroupBox();
            this.abContinuar = new AltoControls.AltoButton();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpVistaM = new System.Windows.Forms.GroupBox();
            this.dgvVistaMatricula = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSecciones = new System.Windows.Forms.DataGridView();
            this.btnAtras = new AltoControls.AltoButton();
            this.btnImprimir = new AltoControls.AltoButton();
            this.gpSeleccionCS.SuspendLayout();
            this.gpVistaM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaMatricula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecciones)).BeginInit();
            this.SuspendLayout();
            // 
            // gpSeleccionCS
            // 
            this.gpSeleccionCS.Controls.Add(this.dgvSecciones);
            this.gpSeleccionCS.Controls.Add(this.abContinuar);
            this.gpSeleccionCS.Controls.Add(this.cmbCurso);
            this.gpSeleccionCS.Controls.Add(this.label2);
            this.gpSeleccionCS.Controls.Add(this.label1);
            this.gpSeleccionCS.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSeleccionCS.Location = new System.Drawing.Point(18, 23);
            this.gpSeleccionCS.Name = "gpSeleccionCS";
            this.gpSeleccionCS.Size = new System.Drawing.Size(1605, 1000);
            this.gpSeleccionCS.TabIndex = 0;
            this.gpSeleccionCS.TabStop = false;
            this.gpSeleccionCS.Text = "Selección de Curso y Sección";
            this.gpSeleccionCS.Enter += new System.EventHandler(this.gpSeleccionCS_Enter);
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
            this.abContinuar.Location = new System.Drawing.Point(736, 871);
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
            // cmbCurso
            // 
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(747, 163);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(207, 31);
            this.cmbCurso.TabIndex = 2;
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Balsamiq Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(706, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione un Curso ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Balsamiq Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(685, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vista de Matrícula";
            // 
            // gpVistaM
            // 
            this.gpVistaM.Controls.Add(this.dgvVistaMatricula);
            this.gpVistaM.Controls.Add(this.label3);
            this.gpVistaM.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpVistaM.Location = new System.Drawing.Point(18, 23);
            this.gpVistaM.Name = "gpVistaM";
            this.gpVistaM.Size = new System.Drawing.Size(1605, 883);
            this.gpVistaM.TabIndex = 5;
            this.gpVistaM.TabStop = false;
            this.gpVistaM.Text = "Vista de Matrícula:";
            this.gpVistaM.VisibleChanged += new System.EventHandler(this.gpVistaM_VisibleChanged);
            this.gpVistaM.Enter += new System.EventHandler(this.gpVistaM_Enter);
            // 
            // dgvVistaMatricula
            // 
            this.dgvVistaMatricula.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVistaMatricula.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVistaMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVistaMatricula.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvVistaMatricula.Location = new System.Drawing.Point(6, 126);
            this.dgvVistaMatricula.Name = "dgvVistaMatricula";
            this.dgvVistaMatricula.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVistaMatricula.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvVistaMatricula.RowHeadersWidth = 51;
            this.dgvVistaMatricula.Size = new System.Drawing.Size(1593, 739);
            this.dgvVistaMatricula.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Balsamiq Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(617, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "DATOS DE LOS ALUMNOS";
            // 
            // dgvSecciones
            // 
            this.dgvSecciones.AllowUserToAddRows = false;
            this.dgvSecciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSecciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Balsamiq Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSecciones.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSecciones.Location = new System.Drawing.Point(85, 247);
            this.dgvSecciones.Name = "dgvSecciones";
            this.dgvSecciones.ReadOnly = true;
            this.dgvSecciones.Size = new System.Drawing.Size(1460, 584);
            this.dgvSecciones.TabIndex = 42;
            this.dgvSecciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSecciones_CellClick);
            // 
            // btnAtras
            // 
            this.btnAtras.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnAtras.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAtras.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.btnAtras.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnAtras.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnAtras.Location = new System.Drawing.Point(24, 946);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Radius = 20;
            this.btnAtras.Size = new System.Drawing.Size(205, 53);
            this.btnAtras.Stroke = true;
            this.btnAtras.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.btnAtras.TabIndex = 47;
            this.btnAtras.Text = "ATRAS";
            this.btnAtras.Transparency = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnImprimir.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(82)))));
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnImprimir.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
            this.btnImprimir.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnImprimir.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(72)))));
            this.btnImprimir.Location = new System.Drawing.Point(730, 928);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Radius = 20;
            this.btnImprimir.Size = new System.Drawing.Size(290, 71);
            this.btnImprimir.Stroke = true;
            this.btnImprimir.StrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.btnImprimir.TabIndex = 48;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.Transparency = false;
            // 
            // IFrmVista_de_Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(141)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1635, 1035);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAtras);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaMatricula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpSeleccionCS;
        private AltoControls.AltoButton abContinuar;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpVistaM;
        private System.Windows.Forms.DataGridView dgvVistaMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSecciones;
        private AltoControls.AltoButton btnAtras;
        private AltoControls.AltoButton btnImprimir;
    }
}