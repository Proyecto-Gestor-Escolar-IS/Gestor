using System.Windows.Forms;

namespace SistemaGestorEscolar.Registro_y_Vista_de_Notas
{
    public partial class Alumnos_CursoSeccion : Form
    {
        databaseConnection dbConn = new databaseConnection();

        public Alumnos_CursoSeccion()
        {
            InitializeComponent();
        }

        private void dgvAlumnos_CS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dbConn.llenarDGV(dgvAlumnos_CS, "SELECT dbo.datosEstudiante.identidadEstudiante as 'Identidad del Estudiante', " +
                "CONCAT(dbo.datosEstudiante.primerNombre,' ', dbo.datosEstudiante.segundoNombre,' ', dbo.datosEstudiante.primerApellido,' ', dbo.datosEstudiante.segundoApellido) as 'Nobre del Estudiante'" +
                ", dbo.cursos.nombreCurso as Curso, dbo.seccion.nombreSeccion as Sección FROM     dbo.datosEstudiante INNER JOIN" +
                " dbo.matricula ON dbo.datosEstudiante.identidadEstudiante = dbo.matricula.id_Estudiante INNER JOIN" +
                " dbo.detalleMatricula ON dbo.matricula.id_RegistroMatricula = dbo.detalleMatricula.id_RegistroMatricula INNER JOIN" +
                " dbo.cursos ON dbo.detalleMatricula.id_Curso = dbo.cursos.id_Curso INNER JOIN dbo.seccion ON dbo.detalleMatricula.id_Seccion = dbo.seccion.id_Seccion AND" +
                " dbo.cursos.id_Curso = dbo.seccion.id_Curso Where dbo.cursos.nombreCurso = '" + Herencia_de_Variables.CursoG + "' and dbo.seccion.nombreSeccion = '" + Herencia_de_Variables.SeccionG + "'");


        }
    }
}
