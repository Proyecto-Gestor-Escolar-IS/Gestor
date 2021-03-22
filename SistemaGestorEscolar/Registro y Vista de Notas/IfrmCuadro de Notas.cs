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
        Registro_Datos_Notas notas = new Registro_Datos_Notas();
        public string identidad2;
        public string nombre2;
        public string Clase;
        public float Nota1;
        public float Nota2;
        public float Nota3;
        public float Nota4;


        public Cuadro_de_Notas()
        {
            InitializeComponent();
        }

        private void Cuadro_de_Notas_Load(object sender, EventArgs e)
        {

            dbConn.llenarDGV(dgvNotaAlumnos, "SELECT dbo.datosEstudiante.identidadEstudiante as 'Identidad del Estudiante', CONCAT(dbo.datosEstudiante.primerNombre,' ', dbo.datosEstudiante.segundoNombre,' ', dbo.datosEstudiante.primerApellido,' ', dbo.datosEstudiante.segundoApellido) as 'Nombre Estudiante', " +
                "dbo.clasesCurso.nombreClase as 'Clase', dbo.cursos.nombreCurso as 'Curso', dbo.seccion.nombreSeccion as 'Sección', dbo.detalleNotas.nota1erParcial as 'Nota Primer Parcial'," +
                " dbo.detalleNotas.nota2doParcial as 'Segundo Parcial', dbo.detalleNotas.nota3erParcial as 'Tercer Parcial', dbo.detalleNotas.nota4toParcial as 'Cuarto Parcial'," +
                " dbo.detalleNotas.notaFinal as 'Nota Promedio' FROM     dbo.seccion INNER JOIN dbo.cursos ON dbo.seccion.id_Curso = dbo.cursos.id_Curso INNER JOIN dbo.clasesCurso ON " +
                "dbo.cursos.id_Curso = dbo.clasesCurso.id_Curso INNER JOIN dbo.detalleNotas ON dbo.clasesCurso.id_Clase = dbo.detalleNotas.id_Clase INNER JOIN dbo.detalleMatricula ON" +
                " dbo.seccion.id_Seccion = dbo.detalleMatricula.id_Seccion AND dbo.cursos.id_Curso = dbo.detalleMatricula.id_Curso AND " +
                "dbo.detalleNotas.id_DetalleMatricula = dbo.detalleMatricula.id_DetalleMatricula INNER JOIN dbo.matricula ON " +
                "dbo.detalleMatricula.id_RegistroMatricula = dbo.matricula.id_RegistroMatricula INNER JOIN dbo.datosEstudiante ON " +
                "dbo.matricula.id_Estudiante = dbo.datosEstudiante.identidadEstudiante");

        }

        private void pbRegresar_Click(object sender, EventArgs e)
        {

            this.Hide();
            Registro_Datos_Notas form = new Registro_Datos_Notas();
            form.Show(this);

        }

        private void dgvNotaAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            identidad2 = dgvNotaAlumnos.CurrentRow.Cells[0].Value.ToString();
            nombre2 = dgvNotaAlumnos.CurrentRow.Cells[1].Value.ToString();
            //Clase = dgvNotaAlumnos.CurrentRow.Cells[3].Value.ToString();
            Nota1 = float.Parse(dgvNotaAlumnos.CurrentRow.Cells[5].Value.ToString());
            Nota2 = float.Parse(dgvNotaAlumnos.CurrentRow.Cells[6].Value.ToString());
            Nota3 = float.Parse(dgvNotaAlumnos.CurrentRow.Cells[7].Value.ToString());
            Nota4 = float.Parse(dgvNotaAlumnos.CurrentRow.Cells[8].Value.ToString());


            Registro_y_Vista_de_Notas.Herencia_de_Variables.identidadG2 = identidad2;
            Registro_y_Vista_de_Notas.Herencia_de_Variables.nombreG2 = nombre2;
            Registro_y_Vista_de_Notas.Herencia_de_Variables.clase = Clase;
            Registro_y_Vista_de_Notas.Herencia_de_Variables.nota1G2 = Nota1;
            Registro_y_Vista_de_Notas.Herencia_de_Variables.nota2G2 = Nota2;
            Registro_y_Vista_de_Notas.Herencia_de_Variables.nota3G2 = Nota3;
            Registro_y_Vista_de_Notas.Herencia_de_Variables.nota4G2 = Nota4;


            //DataGridViewRow llenar = DataGrid.Rows[e.RowIndex];

            notas.txtIdentidad.Text = identidad2;
            notas.txtNombreAlumno.Text = nombre2;
            notas.txtNota1.Text = Nota1.ToString();
            notas.txtNota2.Text = Nota3.ToString();
            notas.txtNota3.Text = Nota3.ToString();
            notas.txtNota4.Text = Nota4.ToString();

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            this.Hide();
            Registro_Datos_Notas form = new Registro_Datos_Notas();
            form.Show(this);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}