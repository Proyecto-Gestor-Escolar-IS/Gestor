using SistemaGestorEscolar.Registro_y_Vista_de_Notas;
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
        IMessageBoxCheck messageOk = new IMessageBoxCheck();
        IMessageBoxError message = new IMessageBoxError();

        public int id_detalleMatricula;
        public string id_detalleMatriculaTemp;
        public string identidad;
        public int Id_Clase;
        public string nombreClase;
        int notaProm;
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
            string idEstudiante;
            long number = 0; 
            try
            { 
                if (txtIdentidad.Text != string.Empty)
                {
                    txtIdentidad.ForeColor = Color.Black;
                    errorPrvIdentidad.Clear();
                    if (long.TryParse(txtIdentidad.Text, out number))
                    {
                        txtIdentidad.ForeColor = Color.Black;
                        errorPrvIdentidad.Clear();

                        if (txtIdentidad.TextLength == 13)
                        {
                            txtIdentidad.ForeColor = Color.Green;
                            errorPrvIdentidad.Clear();

                            idEstudiante = dbConn.obtenerVariableString("SELECT id_Registro FROM datosEstudiante WHERE identidadEstudiante = " + txtIdentidad.Text);

                            if (!string.IsNullOrEmpty(idEstudiante))
                            {
                                dbConn.llenarTextBox(txtNombreAlumno, "SELECT CONCAT(primerNombre,' ',segundoNombre,' ',primerApellido,' ',segundoApellido) as 'Nombre Estudiante' " +
                                    "FROM  dbo.datosEstudiante Where identidadEstudiante = " + txtIdentidad.Text);
                            }
                            else
                            {
                                txtIdentidad.ForeColor = Color.Red;
                                errorPrvIdentidad.SetError(this.txtIdentidad, "El Alumno ya tiene un registro de notas");
                            }
                        }
                        else
                        {
                            txtIdentidad.ForeColor = Color.Red;
                            errorPrvIdentidad.SetError(this.txtIdentidad, "No se encontró el alumno especificado");
                        }
                    }
                    else if (txtIdentidad.TextLength > 13 || txtIdentidad.TextLength < 13)
                    {
                        txtIdentidad.ForeColor = Color.Red;
                        errorPrvIdentidad.SetError(this.txtIdentidad, "El numero de indentidad ingresado es invalido!");
                        txtIdentidad.ResetText();
                        txtNombreAlumno.ResetText();
                    }
                }
                else
                {
                    errorPrvIdentidad.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
            txtIdentidad.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.identidadG;
            txtNota1.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.nota1G2.ToString();
            txtNota2.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.nota2G2.ToString();
            txtNota3.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.nota3G2.ToString();
            txtNota4.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.nota4G2.ToString();
            //cmbClase.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.clase.ToString();
            txtIdentidad.ForeColor = Color.Green;
            errorPrvIdentidad.Clear();

            dbConn.llenarComboBox(cmbClase, "SELECT dbo.clasesCurso.nombreClase FROM     dbo.clasesCurso INNER JOIN dbo.cursos ON " +
                "dbo.clasesCurso.id_Curso = dbo.cursos.id_Curso INNER JOIN dbo.seccion ON dbo.cursos.id_Curso = dbo.seccion.id_Curso Where " +
                "dbo.cursos.nombreCurso = '" + txtCurso.Text + "' and dbo.seccion.nombreSeccion = '" + txtSeccion.Text + "' ");

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

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {

        }

        private void txtNotaProm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {
            if (txtNota1.Text == "")
            {

            }
            else
            {
                notaProm = (Convert.ToInt32(txtNota1.Text) + Convert.ToInt32(txtNota2.Text) + Convert.ToInt32(txtNota3.Text) + Convert.ToInt32(txtNota4.Text)) / 4;

                txtNotaProm.Text = notaProm.ToString();
            }
            }

        private void txtNota2_TextChanged(object sender, EventArgs e)
        {

            if (txtNota2.Text == "")
            {

            }
            else
            {
                notaProm = (Convert.ToInt32(txtNota1.Text) + Convert.ToInt32(txtNota2.Text) + Convert.ToInt32(txtNota3.Text) + Convert.ToInt32(txtNota4.Text)) / 4;

                txtNotaProm.Text = notaProm.ToString();
            }

        }

        private void txtNota3_TextChanged(object sender, EventArgs e)
        {

            if (txtNota3.Text == "")
            {

            }
            else
            {
                notaProm = (Convert.ToInt32(txtNota1.Text) + Convert.ToInt32(txtNota2.Text) + Convert.ToInt32(txtNota3.Text) + Convert.ToInt32(txtNota4.Text)) / 4;

                txtNotaProm.Text = notaProm.ToString();
            }

        }

        private void txtNota4_TextChanged(object sender, EventArgs e)
        {

            if (txtNota4.Text == "")
            {

            }
            else
            {
                notaProm = (Convert.ToInt32(txtNota1.Text) + Convert.ToInt32(txtNota2.Text) + Convert.ToInt32(txtNota3.Text) + Convert.ToInt32(txtNota4.Text)) / 4;

                txtNotaProm.Text = notaProm.ToString();
            }

        }

        private void pbRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alumnos_CursoSeccion form = new Alumnos_CursoSeccion();
            form.Show(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            cmbClase.ResetText();

        }

        private void btnAgregarNota_Click(object sender, EventArgs e)
        {
            
            identidad = txtIdentidad.Text;
            curso = txtCurso.Text;
            seccion = txtSeccion.Text;
            nombreAlumno = txtNombreAlumno.Text;
            nota1 = float.Parse(txtNota1.Text);
            nota2 = float.Parse(txtNota2.Text);
            nota3 = float.Parse(txtNota3.Text);
            nota4 = float.Parse(txtNota4.Text);
            notaFinal = float.Parse(txtNotaProm.Text);

            id_detalleMatricula = dbConn.obtenerVariableEntera("SELECT dbo.detalleMatricula.id_DetalleMatricula FROM     dbo.datosEstudiante INNER JOIN dbo.matricula ON dbo.datosEstudiante.identidadEstudiante = dbo.matricula.id_Estudiante INNER JOIN" +
                " dbo.detalleMatricula ON dbo.matricula.id_RegistroMatricula = dbo.detalleMatricula.id_RegistroMatricula inner join dbo.cursos on dbo.detalleMatricula.id_Curso = dbo.cursos.id_Curso inner join " +
                "dbo.seccion on dbo.detalleMatricula.id_Seccion = dbo.seccion.id_Seccion where dbo.datosEstudiante.identidadEstudiante = '" + txtIdentidad.Text + "' and" +
                " dbo.cursos.nombreCurso = '" + txtCurso.Text + "' and dbo.seccion.nombreSeccion = '" + txtSeccion.Text + "'");

            Id_Clase = dbConn.obtenerVariableEntera("SELECT dbo.clasesCurso.id_Clase FROM     dbo.cursos INNER JOIN dbo.seccion ON" +
                " dbo.cursos.id_Curso = dbo.seccion.id_Curso INNER JOIN dbo.clasesCurso ON dbo.cursos.id_Curso = dbo.clasesCurso.id_Curso Where " +
                "dbo.clasesCurso.nombreClase = '" + cmbClase.SelectedItem.ToString() + "'");
                  

               if (dbConn.PAAgregarNota(id_detalleMatricula, Id_Clase, nota1, nota2, nota3, nota4, notaFinal))
                {
                //MessageBox.Show("Las Notas del Alumno se ingresaron correctamente", "Nota Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                messageOk.lblCheck.Text = "Se ingresaron correctamente";
                messageOk.ShowDialog();
                }
               else
                {
                //MessageBox.Show("Se produjo un error al ingresar los datos!", "Nota Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                message.lblError.Text = "Error al ingresar las Notas";
                message.ShowDialog();
                }
        
        }

        private void btnModificarNota_Click(object sender, EventArgs e)
        {
            identidad = txtIdentidad.Text;
            curso = txtCurso.Text;
            seccion = txtSeccion.Text;
            nombreAlumno = txtNombreAlumno.Text;
            nota1 = float.Parse(txtNota1.Text);
            nota2 = float.Parse(txtNota2.Text);
            nota3 = float.Parse(txtNota3.Text);
            nota4 = float.Parse(txtNota4.Text);
            notaFinal = float.Parse(txtNotaProm.Text);

            id_detalleMatricula = dbConn.obtenerVariableEntera("SELECT dbo.detalleMatricula.id_DetalleMatricula FROM     dbo.datosEstudiante INNER JOIN dbo.matricula ON dbo.datosEstudiante.identidadEstudiante = dbo.matricula.id_Estudiante INNER JOIN dbo.detalleMatricula ON dbo.matricula.id_RegistroMatricula = dbo.detalleMatricula.id_RegistroMatricula " +
                "inner join dbo.cursos on dbo.detalleMatricula.id_Curso = dbo.cursos.id_Curso inner join dbo.seccion on dbo.detalleMatricula.id_Seccion = dbo.seccion.id_Seccion where dbo.datosEstudiante.identidadEstudiante = '" + txtIdentidad.Text + "' and dbo.cursos.nombreCurso = '" + txtCurso.Text + "' and dbo.seccion.nombreSeccion = '" + txtSeccion.Text + "' ");


            Id_Clase = dbConn.obtenerVariableEntera("SELECT dbo.clasesCurso.id_Clase FROM     dbo.cursos INNER JOIN dbo.seccion ON " +
                "dbo.cursos.id_Curso = dbo.seccion.id_Curso INNER JOIN dbo.clasesCurso ON dbo.cursos.id_Curso = dbo.clasesCurso.id_Curso Where" +
                " dbo.clasesCurso.nombreClase = '" + cmbClase.SelectedItem.ToString() + "' ");


            if (dbConn.PAModificarNota(id_detalleMatricula, Id_Clase, nota1, nota2, nota3, nota4, notaFinal))
            {
                messageOk.lblCheck.Text = "Se Modificaron correctamente";
                messageOk.ShowDialog();
            }
            else
            {
                message.lblError.Text = "Error al Modificar las Notas";
                message.ShowDialog();
            }

        }

    }
}
