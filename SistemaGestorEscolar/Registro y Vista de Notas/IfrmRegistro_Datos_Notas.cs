using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Modulos_de_Registro_y_Vista_de_Notas
{

    public partial class Registro_Datos_Notas : Form
    {
        databaseConnection dbConn = new databaseConnection();

        public int id_detalleMatricula;
        public string id_detalleMatriculaTemp;
        public string identidad;
        public int Id_Clase;
        public string curso;
        public string seccion;
        public string nombreAlumno;
        public float nota1, nota2, nota3, nota4, notaFinal, estado;

        public Registro_Datos_Notas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtIdentidad_TextChanged(object sender, EventArgs e)
        {

        }   

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Datos_Notas_Load(object sender, EventArgs e)
        {
            txtCurso.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.CursoG;
            txtSeccion.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.SeccionG;
        }


        //Validaciones 

        private void txtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombreAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Char.IsLetter(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else if (Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }

        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtIdClase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnMostarCuadroN_Click(object sender, EventArgs e)
        {
            //dbConn.llenarDGV(dgvNotaAlumnos, "SELECT CONCAT(dbo.datosEstudiante.primerNombre,' ',dbo.datosEstudiante.segundoNombre,' ',dbo.datosEstudiante.primerApellido,' ',dbo.datosEstudiante.segundoApellido) as 'Nombre del Estudiante', dbo.datosEstudiante.identidadEstudiante as 'Identidad del Estudiante', dbo.cursos.nombreCurso as 'Curso', " +
            //    "dbo.seccion.nombreSeccion as 'Sección', dbo.detalleNotas.nota1erParcial as 'Nota Primer Parcial', dbo.detalleNotas.nota2doParcial as 'Segundo Parcial', dbo.detalleNotas.nota3erParcial as 'Tercer Parcial', dbo.detalleNotas.nota4toParcial as 'Cuarto Parcial', dbo.detalleNotas.notaFinal as 'Nota Final'" +
            //     "FROM     dbo.seccion INNER JOIN" +
            //     "dbo.cursos ON dbo.seccion.id_Curso = dbo.cursos.id_Curso INNER JOIN" +
            //     "dbo.detalleMatricula ON dbo.seccion.id_Seccion = dbo.detalleMatricula.id_Seccion AND dbo.cursos.id_Curso = dbo.detalleMatricula.id_Curso INNER JOIN" +
            //     "dbo.detalleNotas ON dbo.detalleMatricula.id_DetalleMatricula = dbo.detalleNotas.id_DetalleMatricula INNER JOIN" +
            //     "dbo.matricula ON dbo.detalleMatricula.id_RegistroMatricula = dbo.matricula.id_RegistroMatricula INNER JOIN" +
            //      "dbo.datosEstudiante ON dbo.matricula.id_Estudiante = dbo.datosEstudiante.identidadEstudiante");

            this.Hide();
            Cuadro_de_Notas form = new Cuadro_de_Notas();
            form.Show(this);

        }

        private void txtNota3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNota4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNotaProm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        //Metodos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdentidad.ResetText();
            txtNombreAlumno.ResetText();
            txtCurso.ResetText();
            txtSeccion.ResetText();
            txtNota1.ResetText();
            txtNota2.ResetText();
            txtNota3.ResetText();
            txtNota4.ResetText();
            txtNotaProm.ResetText();
            txtIdClase.ResetText();

        }

        private void btnAgregarNota_Click(object sender, EventArgs e)
        {
            
            identidad = txtIdentidad.Text;
            Id_Clase = Int16.Parse(txtIdClase.Text);
            curso = txtCurso.Text;
            seccion = txtSeccion.Text;
            nombreAlumno = txtNombreAlumno.Text;
            nota1 = float.Parse(txtNota1.Text);
            nota2 = float.Parse(txtNota2.Text);
            nota3 = float.Parse(txtNota3.Text);
            nota4 = float.Parse(txtNota4.Text);
            notaFinal = float.Parse(txtNotaProm.Text);

            /*string comando = ("SELECT dbo.detalleMatricula.id_DetalleMatricula FROM dbo.datosEstudiante INNER JOIN" +
            "dbo.matricula ON dbo.datosEstudiante.identidadEstudiante = dbo.matricula.id_Estudiante INNER JOIN" +
            "dbo.detalleMatricula ON dbo.matricula.id_RegistroMatricula = dbo.detalleMatricula.id_RegistroMatricula inner join" +
            "dbo.cursos on dbo.detalleMatricula.id_Curso = dbo.cursos.id_Curso inner join" +
            "dbo.seccion on dbo.detalleMatricula.id_Seccion = dbo.seccion.id_Seccion" +
            "where dbo.datosEstudiante.identidadEstudiante = '"+identidad+"' and dbo.cursos.nombreCurso = '"+curso+"' and dbo.seccion.nombreSeccion = '"+seccion+"'");*/


            /*
             SELECT dbo.detalleMatricula.id_DetalleMatricula
FROM     dbo.datosEstudiante INNER JOIN
                  dbo.matricula ON dbo.datosEstudiante.identidadEstudiante = dbo.matricula.id_Estudiante INNER JOIN
                  dbo.detalleMatricula ON dbo.matricula.id_RegistroMatricula = dbo.detalleMatricula.id_RegistroMatricula inner join
				  dbo.cursos on dbo.detalleMatricula.id_Curso = dbo.cursos.id_Curso inner join 
				  dbo.seccion on dbo.detalleMatricula.id_Seccion = dbo.seccion.id_Seccion
where dbo.datosEstudiante.identidadEstudiante = '1002201000251' and dbo.cursos.nombreCurso = 'Kinder' and dbo.seccion.nombreSeccion = 'B'


             */
            id_detalleMatricula = dbConn.obtenerVariableEntera("SELECT dbo.detalleMatricula.id_DetalleMatricula FROM     dbo.datosEstudiante INNER JOIN dbo.matricula ON dbo.datosEstudiante.identidadEstudiante = dbo.matricula.id_Estudiante INNER JOIN dbo.detalleMatricula ON dbo.matricula.id_RegistroMatricula = dbo.detalleMatricula.id_RegistroMatricula " +
                "inner join dbo.cursos on dbo.detalleMatricula.id_Curso = dbo.cursos.id_Curso inner join dbo.seccion on dbo.detalleMatricula.id_Seccion = dbo.seccion.id_Seccion where dbo.datosEstudiante.identidadEstudiante = '" + txtIdentidad.Text + "' and dbo.cursos.nombreCurso = '" + txtCurso.Text + "' and dbo.seccion.nombreSeccion = '" + txtSeccion.Text + "' ");
                  
                MessageBox.Show("Shit" + id_detalleMatricula);

               if (dbConn.PAAgregarNota(id_detalleMatricula, Id_Clase, nota1, nota2, nota3, nota4, notaFinal))
                {
                MessageBox.Show("Las Notas del Alumno se ingresaron correctamente", "Nota Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               else
                {
                MessageBox.Show("Se produjo un error al ingresar los datos!", "Nota Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        
        }
    }
}
