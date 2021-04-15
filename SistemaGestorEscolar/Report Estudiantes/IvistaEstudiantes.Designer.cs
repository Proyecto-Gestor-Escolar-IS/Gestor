
namespace SistemaGestorEscolar.Report_Estudiantes
{
    partial class IvistaEstudiantes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reporteEstudiantes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reporteEstudiantes
            // 
            this.reporteEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = null;
            this.reporteEstudiantes.LocalReport.DataSources.Add(reportDataSource3);
            this.reporteEstudiantes.LocalReport.ReportEmbeddedResource = "SistemaGestorEscolar.Report Estudiantes.reporteEstudiante.rdlc";
            this.reporteEstudiantes.Location = new System.Drawing.Point(0, 0);
            this.reporteEstudiantes.Margin = new System.Windows.Forms.Padding(2);
            this.reporteEstudiantes.Name = "reporteEstudiantes";
            this.reporteEstudiantes.ServerReport.BearerToken = null;
            this.reporteEstudiantes.Size = new System.Drawing.Size(1166, 737);
            this.reporteEstudiantes.TabIndex = 1;
            // 
            // IvistaEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 737);
            this.Controls.Add(this.reporteEstudiantes);
            this.Name = "IvistaEstudiantes";
            this.Text = "IvistaEstudiantes";
            this.Load += new System.EventHandler(this.IvistaEstudiantes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporteEstudiantes;
    }
}