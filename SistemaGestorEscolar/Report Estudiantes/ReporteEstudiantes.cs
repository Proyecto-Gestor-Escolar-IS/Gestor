using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Report_Estudiantes
{
    public partial class ReporteEstudiantes : Form
    {
        public ReporteEstudiantes()
        {
            InitializeComponent();
        }

        private void ReporteEstudiantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetEstudiantes.Tabla_Estudiante' Puede moverla o quitarla según sea necesario.
            this.Tabla_EstudianteTableAdapter.Fill(this.DataSetEstudiantes.Tabla_Estudiante);

            this.reportViewer1.RefreshReport();
        }
    }
}
