using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Modulo_de_Cursos
{
    public partial class IGestionCursos : Form
    {
        public IGestionCursos()
        {
            InitializeComponent();
        }

        databaseConnection dbConn = new databaseConnection();

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvCursos, "select [id_Curso] as 'Id Curso', [nombreCurso] as 'Nombre Curso', [precioCompleto] as 'Precio' from [dbo].[cursos]");
        }

        private void IGestionCursos_Load(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvCursos, "select [id_Curso] as 'Id Curso', [nombreCurso] as 'Nombre Curso', [precioCompleto] as 'Precio' from [dbo].[cursos]");
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            int idCurso, codigoOP;
            String nombreCurso;
            double precioCurso;

            codigoOP = 1;
            nombreCurso = txtNombreCurso.Text;
            precioCurso = double.Parse(txtPrecio.Text);            

            //dbConn.PARegistroActualizacionCursos();
        }

        private void btnActualización_Click(object sender, EventArgs e)
        {

        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
