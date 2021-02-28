using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Modulos_Estudiante
{
    public partial class IMatriculaPrematriculaEstudiante : Form
    {
        public IMatriculaPrematriculaEstudiante()
        {
            InitializeComponent();
        }
        private databaseConnection dbConn = new databaseConnection();

        private void IMatriculaPrematriculaEstudiante_Load(object sender, EventArgs e)
        {
            dbConn.llenarComboBox(cmbCurso, "SELECT nombreCurso FROM cursos");
        }

        private void btnmatricular_Click(object sender, EventArgs e)
        {

        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
