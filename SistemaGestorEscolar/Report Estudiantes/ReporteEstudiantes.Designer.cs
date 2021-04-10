
namespace SistemaGestorEscolar
{
    partial class ReporteEstudiantes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Tabla_EstudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetEstudiantes = new SistemaGestorEscolar.Report_Estudiantes.DataSetEstudiantes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Tabla_EstudianteTableAdapter = new SistemaGestorEscolar.Report_Estudiantes.DataSetEstudiantesTableAdapters.Tabla_EstudianteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_EstudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla_EstudianteBindingSource
            // 
            this.Tabla_EstudianteBindingSource.DataMember = "Tabla Estudiante";
            this.Tabla_EstudianteBindingSource.DataSource = this.DataSetEstudiantes;
            // 
            // DataSetEstudiantes
            // 
            this.DataSetEstudiantes.DataSetName = "DataSetEstudiantes";
            this.DataSetEstudiantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Tabla_EstudianteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaGestorEscolar.Report Notas.ReportNotas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(688, 393);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Tabla_EstudianteTableAdapter
            // 
            this.Tabla_EstudianteTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 393);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReporteEstudiantes";
            this.Text = "ReporteEstudiantes";
            this.Load += new System.EventHandler(this.ReporteEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_EstudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tabla_EstudianteBindingSource;
        private Report_Estudiantes.DataSetEstudiantes DataSetEstudiantes;
        private Report_Estudiantes.DataSetEstudiantesTableAdapters.Tabla_EstudianteTableAdapter Tabla_EstudianteTableAdapter;
    }
}