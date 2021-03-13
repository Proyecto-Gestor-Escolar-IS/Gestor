using SistemaGestorEscolar.Modulos_de_Registro_y_Vista_de_Notas;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Registro_y_Vista_de_Notas
{
    public partial class Alumnos_CursoSeccion : Form
    {
        databaseConnection dbConn = new databaseConnection();

        public string identidad;
        public string nombre;

        public Alumnos_CursoSeccion()
        {
            InitializeComponent();
        }

        private void dgvAlumnos_CS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           

        }

        private void dgvAlumnos_CS_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            identidad = dgvAlumnos_CS.CurrentCell.Value.ToString();
            nombre = dgvAlumnos_CS.CurrentCell.Value.ToString();


            Registro_y_Vista_de_Notas.Herencia_de_Variables.identidadG = identidad;
            Registro_y_Vista_de_Notas.Herencia_de_Variables.nombreG = nombre;

        }


        private void Alumnos_CursoSeccion_Load(object sender, System.EventArgs e)
        {

            dbConn.llenarDGV(dgvAlumnos_CS, "SELECT dbo.datosEstudiante.identidadEstudiante as 'Identidad del Estudiante', " +
                "CONCAT(dbo.datosEstudiante.primerNombre,' ', dbo.datosEstudiante.segundoNombre,' ', dbo.datosEstudiante.primerApellido,' ', dbo.datosEstudiante.segundoApellido) as 'Nobre del Estudiante'" +
                ", dbo.cursos.nombreCurso as Curso, dbo.seccion.nombreSeccion as Sección FROM     dbo.datosEstudiante INNER JOIN" +
                " dbo.matricula ON dbo.datosEstudiante.identidadEstudiante = dbo.matricula.id_Estudiante INNER JOIN" +
                " dbo.detalleMatricula ON dbo.matricula.id_RegistroMatricula = dbo.detalleMatricula.id_RegistroMatricula INNER JOIN" +
                " dbo.cursos ON dbo.detalleMatricula.id_Curso = dbo.cursos.id_Curso INNER JOIN dbo.seccion ON dbo.detalleMatricula.id_Seccion = dbo.seccion.id_Seccion AND" +
                " dbo.cursos.id_Curso = dbo.seccion.id_Curso Where dbo.cursos.nombreCurso = '" + Herencia_de_Variables.CursoG + "' and dbo.seccion.nombreSeccion = '" + Herencia_de_Variables.SeccionG + "'");


        }

        private void btnSiguiente_Click(object sender, System.EventArgs e)
        {
            this.Hide();
             Registro_Datos_Notas form = new Registro_Datos_Notas();
            form.Show(this);


        }

        private void pbRegresar_Click(object sender, System.EventArgs e)
        {

            this.Hide();
            Seleccion_de_Curso form = new Seleccion_de_Curso();
            form.Show(this);

        }
    }
}
