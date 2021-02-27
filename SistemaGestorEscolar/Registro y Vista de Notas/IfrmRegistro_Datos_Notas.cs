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

        public string id_detalleMatricula;
        public string identidad;
        public string curso;
        public string seccion;
        public string nombreAlumno;
        public string nota1, nota2, nota3, nota4, notaFinal, estado;

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
            if (Char.IsLetter(e.KeyChar))
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

        }

        private void btnAgregarNota_Click(object sender, EventArgs e)
        {
            
            identidad = txtIdentidad.Text;
            curso = txtCurso.Text;
            seccion = txtSeccion.Text;
            nombreAlumno = txtNombreAlumno.Text;
            nota1 = txtNota1.Text;
            nota2 = txtNota2.Text;
            nota3 = txtNota3.Text;
            nota4 = txtNota4.Text;
            notaFinal = txtNotaProm.Text;

                id_detalleMatricula = ("SELECT dbo.detalleMatricula.id_DetalleMatricula FROM dbo.datosEstudiante INNER JOIN" +
                "dbo.matricula ON dbo.datosEstudiante.identidadEstudiante = dbo.matricula.id_Estudiante INNER JOIN" +
                "dbo.detalleMatricula ON dbo.matricula.id_RegistroMatricula = dbo.detalleMatricula.id_RegistroMatricula inner join" +
                "dbo.cursos on dbo.detalleMatricula.id_Curso = dbo.cursos.id_Curso inner join" +
                "dbo.seccion on dbo.detalleMatricula.id_Seccion = dbo.seccion.id_Seccion" +
                "" +
                "where dbo.datosEstudiante.identidadEstudiante = '"+identidad+"' and dbo.cursos.nombreCurso = '"+curso+"' and dbo.seccion.nombreSeccion = '"+seccion+"'");

             dbConn.obtenerVariableEntera(id_detalleMatricula);
        
        }
    }
}
