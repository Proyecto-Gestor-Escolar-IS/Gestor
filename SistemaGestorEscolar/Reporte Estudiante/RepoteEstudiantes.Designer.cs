
namespace SistemaGestorEscolar.Reporte_Estudiante
{
    partial class RepoteEstudiantes
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetEstudiantes = new SistemaGestorEscolar.Reporte_Estudiante.DataSetEstudiantes();
            this.datosEstudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosEstudianteTableAdapter = new SistemaGestorEscolar.Reporte_Estudiante.DataSetEstudiantesTableAdapters.datosEstudianteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosEstudianteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.datosEstudianteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaGestorEscolar.Reporte Estudiante.ReportEstudiante.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(844, 462);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetEstudiantes
            // 
            this.DataSetEstudiantes.DataSetName = "DataSetEstudiantes";
            this.DataSetEstudiantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosEstudianteBindingSource
            // 
            this.datosEstudianteBindingSource.DataMember = "datosEstudiante";
            this.datosEstudianteBindingSource.DataSource = this.DataSetEstudiantes;
            // 
            // datosEstudianteTableAdapter
            // 
            this.datosEstudianteTableAdapter.ClearBeforeFill = true;
            // 
            // RepoteEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 462);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepoteEstudiantes";
            this.Text = "RepoteEstudiantes";
            this.Load += new System.EventHandler(this.RepoteEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosEstudianteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource datosEstudianteBindingSource;
        private DataSetEstudiantes DataSetEstudiantes;
        private DataSetEstudiantesTableAdapters.datosEstudianteTableAdapter datosEstudianteTableAdapter;
    }
}