
namespace SistemaGestorEscolar.Report_Notas
{
    partial class ReporteNotas
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
            this.DataSetNotas = new SistemaGestorEscolar.Report_Notas.DataSetNotas();
            this.Tabla_NotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tabla_NotasTableAdapter = new SistemaGestorEscolar.Report_Notas.DataSetNotasTableAdapters.Tabla_NotasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_NotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Tabla_NotasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaGestorEscolar.Report Notas.ReportNotas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1033, 500);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetNotas
            // 
            this.DataSetNotas.DataSetName = "DataSetNotas";
            this.DataSetNotas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tabla_NotasBindingSource
            // 
            this.Tabla_NotasBindingSource.DataMember = "Tabla Notas";
            this.Tabla_NotasBindingSource.DataSource = this.DataSetNotas;
            // 
            // Tabla_NotasTableAdapter
            // 
            this.Tabla_NotasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 500);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteNotas";
            this.Text = "ReporteNotas";
            this.Load += new System.EventHandler(this.ReporteNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_NotasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tabla_NotasBindingSource;
        private DataSetNotas DataSetNotas;
        private DataSetNotasTableAdapters.Tabla_NotasTableAdapter Tabla_NotasTableAdapter;
    }
}