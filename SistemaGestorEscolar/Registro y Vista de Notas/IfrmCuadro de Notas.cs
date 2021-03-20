using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Modulos_de_Registro_y_Vista_de_Notas
{
    public partial class Cuadro_de_Notas : Form
    {
        databaseConnection dbConn = new databaseConnection();

        public Cuadro_de_Notas()
        {
            InitializeComponent();
        }

        private void Cuadro_de_Notas_Load(object sender, EventArgs e)
        {

            dbConn.llenarDGV(dgvNotaAlumnos, "SELECT CONCAT(dbo.datosEstudiante.primerNombre,' ',dbo.datosEstudiante.segundoNombre,' ',dbo.datosEstudiante.primerApellido,' ',dbo.datosEstudiante.segundoApellido) as 'Nombre del Estudiante'," +
                " dbo.datosEstudiante.identidadEstudiante as 'Identidad', dbo.cursos.nombreCurso as 'Curso', dbo.seccion.nombreSeccion as 'Sección', " +
                "dbo.detalleNotas.nota1erParcial as 'Nota Primer Parcial', dbo.detalleNotas.nota2doParcial as 'Segundo Parcial', dbo.detalleNotas.nota3erParcial as 'Tercer Parcial', " +
                "dbo.detalleNotas.nota4toParcial as 'Cuarto Parcial', dbo.detalleNotas.notaFinal as 'Nota Final', dbo.datosEstudiante.estado as 'Estado'" +
                " FROM     dbo.seccion INNER JOIN dbo.cursos ON dbo.seccion.id_Curso = dbo.cursos.id_Curso INNER JOIN dbo.detalleMatricula ON dbo.seccion.id_Seccion = dbo.detalleMatricula.id_Seccion " +
                "AND dbo.cursos.id_Curso = dbo.detalleMatricula.id_Curso INNER JOIN dbo.detalleNotas ON dbo.detalleMatricula.id_DetalleMatricula = dbo.detalleNotas.id_DetalleMatricula INNER JOIN " +
                "dbo.matricula ON dbo.detalleMatricula.id_RegistroMatricula = dbo.matricula.id_RegistroMatricula INNER JOIN dbo.datosEstudiante ON dbo.matricula.id_Estudiante = dbo.datosEstudiante.identidadEstudiante " +
                "and dbo.detalleNotas.estado = dbo.datosEstudiante.estado");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
