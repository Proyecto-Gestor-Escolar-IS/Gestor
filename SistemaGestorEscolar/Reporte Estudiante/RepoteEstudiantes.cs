using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Reporte_Estudiante
{
    public partial class RepoteEstudiantes : Form
    {
        public RepoteEstudiantes()
        {
            InitializeComponent();
        }

        private void RepoteEstudiantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetEstudiantes.datosEstudiante' Puede moverla o quitarla según sea necesario.
            this.datosEstudianteTableAdapter.Fill(this.DataSetEstudiantes.datosEstudiante);

            this.reportViewer1.RefreshReport();
        }
    }
}
