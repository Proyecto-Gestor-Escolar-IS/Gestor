using SistemaGestorEscolar.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Registro_y_Vista_de_Notas
{
    public partial class IfrmIngreso_de_Notas : Form
    {

        databaseConnection dbConn = new databaseConnection();
        IMessageBoxCheck messageOk = new IMessageBoxCheck();
        IMessageBoxError message = new IMessageBoxError();
        IMessageBoxWarning messageWarning = new IMessageBoxWarning();

        public string cursoElegido;
        public string seccionElegida;
        public string identidadA;
        public string nombre;

        //Ingreso de Notas.Variables

        public int id_detalleMatricula;
        public string Identidad;
        public int Id_Clase;
        public string nombreClase;
        int notaProm;
        public string curso;
        public string seccion;
        public string nombreAlumno;
        public float nota1, nota2, nota3, nota4, notaFinal;

        //Cuadro de Notas.Variables
        public string identidad2;
        public string nombre2;
        public string Clase;
        public string estado;
        public float Nota1;
        public float Nota2;
        public float Nota3;
        public float Nota4;
        public float NotaProm;


        public IfrmIngreso_de_Notas()
        {
            InitializeComponent();
        }

        private void cmbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCursos.Items.Count > 0)
            {
                switch (cmbCursos.SelectedItem.ToString())
                {
                    case "Nursery":
                        cmbSeccion.Items.Clear();
                        dbConn.llenarComboBox(cmbSeccion, "SELECT dbo.seccion.nombreSeccion FROM     dbo.cursos INNER JOIN dbo.seccion ON " +
                            "dbo.cursos.id_Curso = dbo.seccion.id_Curso Where dbo.cursos.nombreCurso = '" + cmbCursos.SelectedItem + "' ");
                        break;

                    case "Pre-Kinder":
                        cmbSeccion.Items.Clear();
                        dbConn.llenarComboBox(cmbSeccion, "SELECT dbo.seccion.nombreSeccion FROM     dbo.cursos INNER JOIN dbo.seccion ON " +
                            "dbo.cursos.id_Curso = dbo.seccion.id_Curso Where dbo.cursos.nombreCurso = '" + cmbCursos.SelectedItem + "' ");
                        break;

                    case "Kinder":
                        cmbSeccion.Items.Clear();
                        dbConn.llenarComboBox(cmbSeccion, "SELECT dbo.seccion.nombreSeccion FROM     dbo.cursos INNER JOIN dbo.seccion ON " +
                            "dbo.cursos.id_Curso = dbo.seccion.id_Curso Where dbo.cursos.nombreCurso = '" + cmbCursos.SelectedItem + "' ");
                        break;

                    case "Primer Grado":
                        cmbSeccion.Items.Clear();
                        dbConn.llenarComboBox(cmbSeccion, "SELECT dbo.seccion.nombreSeccion FROM     dbo.cursos INNER JOIN dbo.seccion ON " +
                            "dbo.cursos.id_Curso = dbo.seccion.id_Curso Where dbo.cursos.nombreCurso = '" + cmbCursos.SelectedItem + "' ");
                        break;
                }
            }


            cursoElegido = cmbCursos.Text;
        }

        private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            seccionElegida = cmbSeccion.Text;
        }

        private void abContinuar_Click(object sender, EventArgs e)
        {

            Registro_y_Vista_de_Notas.Herencia_de_Variables.CursoG = cursoElegido;
            Registro_y_Vista_de_Notas.Herencia_de_Variables.SeccionG = seccionElegida;

            if (cmbCursos.SelectedIndex == -1 && cmbSeccion.SelectedIndex == -1)
            {
                message.lblError.Text = "Seleccione un Curso y Sección";
                message.ShowDialog();

            }
            else if (cmbSeccion.Text != seccionElegida)
            {
                message.lblError.Text = "Seleccione una Sección";
                message.ShowDialog();
            }
            else
            {
                gpxSeleccionCurso.Visible = false;
                gpxSeleccionAlumno.Visible = true;
            }

        }

        //--------------------------Grupbox Seleccion Alumno-------------------------------------

        private void dgvSeleccionAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(dgvSeleccionAlumno.CurrentRow is null)
            {
                message.lblError.Location = new Point(118, 68);
                message.lblError.Text = "SELECCIONE UNA CELDA\nPARA CONTINUAR";
                message.lblError.TextAlign = ContentAlignment.MiddleCenter;
                message.ShowDialog();
            }
            else
            {
                identidadA = dgvSeleccionAlumno.CurrentRow.Cells[0].Value.ToString();
                nombre = dgvSeleccionAlumno.CurrentRow.Cells[1].Value.ToString();
            }

            Registro_y_Vista_de_Notas.Herencia_de_Variables.identidadG = identidadA;
            Registro_y_Vista_de_Notas.Herencia_de_Variables.nombreG = nombre;

            //MessageBox.Show(Herencia_de_Variables.identidadG);

        }

        private void IfrmIngreso_de_Notas_Load(object sender, EventArgs e)
        {

            gpxSeleccionAlumno.Visible = false;
            gpxIngreso_Notas.Visible = false;
            gpxCuadroNotas.Visible = false;

            cmbCursos.SelectedItem = 0;
            cmbSeccion.SelectedItem = 0;

            ClsCambioTema.cambiarTemaBoton(gpxSeleccionCurso);
            ClsCambioTema.cambiarTemaBoton(gpxSeleccionAlumno);
            ClsCambioTema.cambiarTemaBoton(gpxIngreso_Notas);
            ClsCambioTema.cambiarTemaBoton(gpxCuadroNotas);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvSeleccionAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gpxSeleccionAlumno_VisibleChanged(object sender, EventArgs e)
        {

            dbConn.llenarDGV(dgvSeleccionAlumno, "SELECT dbo.datosEstudiante.identidadEstudiante as 'Identidad del Estudiante', CONCAT(dbo.datosEstudiante.primerNombre,' ', dbo.datosEstudiante.segundoNombre,' ', dbo.datosEstudiante.primerApellido,' ', dbo.datosEstudiante.segundoApellido) as 'Nobre del Estudiante'," +
                " dbo.cursos.nombreCurso as Curso, dbo.seccion.nombreSeccion as Sección FROM     dbo.datosEstudiante INNER JOIN" +
                " dbo.matricula ON dbo.datosEstudiante.identidadEstudiante = dbo.matricula.id_Estudiante INNER JOIN " +
                "dbo.detalleMatricula ON dbo.matricula.id_RegistroMatricula = dbo.detalleMatricula.id_RegistroMatricula INNER JOIN " +
                "dbo.cursos ON dbo.detalleMatricula.id_Curso = dbo.cursos.id_Curso INNER JOIN dbo.seccion ON" +
                " dbo.detalleMatricula.id_Seccion = dbo.seccion.id_Seccion AND dbo.cursos.id_Curso = dbo.seccion.id_Curso Where" +
                " dbo.cursos.nombreCurso = '" + Herencia_de_Variables.CursoG + "' and dbo.seccion.nombreSeccion = '" + Herencia_de_Variables.SeccionG + "' ");

        }

        private void abContinuar2_Click(object sender, EventArgs e)
        {

            if(identidadA == null)
            {

                message.lblError.Location = new Point(118, 68);
                message.lblError.Text = "SELECCIONE UNA CELDA\nPARA CONTINUAR";
                message.lblError.TextAlign = ContentAlignment.MiddleCenter;
                message.ShowDialog();

            }
            else
            {
                gpxSeleccionAlumno.Visible = false;
                gpxIngreso_Notas.Visible = true;
            }

        }



        //---------------------------Grupbox Ingreso de Notas----------------------------------------

        private void txtIdentidad_TextChanged(object sender, EventArgs e)
        {

            string idEstudiante;
            long number = 0;

            try
            {
                if (txtIdentidad.Text != string.Empty)
                {
                    txtIdentidad.ForeColor = Color.Black;
                    errorPvIdentidad.Clear();
                    if (long.TryParse(txtIdentidad.Text, out number))
                    {
                        txtIdentidad.ForeColor = Color.Black;
                        errorPvIdentidad.Clear();

                        if (txtIdentidad.TextLength == 13)
                        {
                            txtIdentidad.ForeColor = Color.Green;
                            errorPvIdentidad.Clear();

                            idEstudiante = dbConn.obtenerVariableString("SELECT id_Registro FROM datosEstudiante WHERE identidadEstudiante = " + txtIdentidad.Text);

                            if (!string.IsNullOrEmpty(idEstudiante))
                            {
                                dbConn.llenarTextBox(txtNombreAlumno, "SELECT CONCAT(primerNombre,' ',segundoNombre,' ',primerApellido,' ',segundoApellido) as 'Nombre Estudiante' " +
                                    "FROM  dbo.datosEstudiante Where identidadEstudiante = " + txtIdentidad.Text);
                            }
                            else
                            {
                                txtIdentidad.ForeColor = Color.Red;
                                errorPvIdentidad.SetError(this.txtIdentidad, "El Alumno ya tiene un registro de notas");
                            }
                        }
                        else
                        {
                            txtIdentidad.ForeColor = Color.Red;
                            errorPvIdentidad.SetError(this.txtIdentidad, "No se encontró el alumno especificado");
                        }
                    }
                    else if (txtIdentidad.TextLength > 13 || txtIdentidad.TextLength < 13)
                    {
                        txtIdentidad.ForeColor = Color.Red;
                        errorPvIdentidad.SetError(this.txtIdentidad, "El numero de indentidad ingresado es invalido!");
                        txtIdentidad.ResetText();
                        txtNombreAlumno.ResetText();
                    }
                }
                else
                {
                    errorPvIdentidad.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void gpxIngreso_Notas_VisibleChanged(object sender, EventArgs e)
        {

            //txtCurso.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.CursoG;
            //txtSeccion.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.SeccionG;
            //txtIdentidad.Text = Herencia_de_Variables.identidadG;

            //dbConn.llenarComboBox(cmbClasesCS, "SELECT dbo.clasesCurso.nombreClase FROM     dbo.clasesCurso INNER JOIN dbo.cursos ON " +
            //                      "dbo.clasesCurso.id_Curso = dbo.cursos.id_Curso INNER JOIN dbo.seccion ON dbo.cursos.id_Curso = dbo.seccion.id_Curso Where " +
            //                      "dbo.cursos.nombreCurso = '" + txtCurso.Text + "' and dbo.seccion.nombreSeccion = '" + txtSeccion.Text + "' ");
        }
        private void gpxIngreso_Notas_VisibleChanged_1(object sender, EventArgs e)
        {
            //txtIdentidad.Visible = false;
            //txtNombreAlumno.Visible = false;
            Limpiar();
            txtCurso.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.CursoG;
            txtSeccion.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.SeccionG;
            txtIdentidadAE.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.identidadG;
            txtIdentidad.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.identidadG2;
            txtNombreAE.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.nombreG;
            txtNombreAlumno.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.nombreG2;
            cmbClasesCS.SelectedItem = Clase;
            txtNota1.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.nota1G2.ToString();
            txtNota2.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.nota2G2.ToString();
            txtNota3.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.nota3G2.ToString();
            txtNota4.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.nota4G2.ToString();

        }

        private void chkVerClases_CheckedChanged(object sender, EventArgs e)
        {

            if (chkVerClases.Checked)
            {
                dbConn.llenarComboBox(cmbClasesCS, "SELECT dbo.clasesCurso.nombreClase FROM     dbo.clasesCurso INNER JOIN dbo.cursos ON " +
                              "dbo.clasesCurso.id_Curso = dbo.cursos.id_Curso INNER JOIN dbo.seccion ON dbo.cursos.id_Curso = dbo.seccion.id_Curso Where " +
                              "dbo.cursos.nombreCurso = '" + txtCurso.Text + "' and dbo.seccion.nombreSeccion = '" + txtSeccion.Text + "' ");
            }
            else
            {
                cmbClasesCS.Items.Clear();
            }

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

        private void abAgregarNotas_Click(object sender, EventArgs e)
        {

            Identidad = txtIdentidad.Text;
            curso = txtCurso.Text;
            seccion = txtSeccion.Text;
            nombreAlumno = txtNombreAlumno.Text;
            nota1 = float.Parse(txtNota1.Text);
            nota2 = float.Parse(txtNota2.Text);
            nota3 = float.Parse(txtNota3.Text);
            nota4 = float.Parse(txtNota4.Text);
            notaFinal = float.Parse(txtNotaProm.Text);

            if (cmbClasesCS.SelectedItem == null)
            {
                message.lblError.Text = "Debe seleccionar una Clase\n";
                message.ShowDialog();
            }
            else
            {
                id_detalleMatricula = dbConn.obtenerVariableEntera("SELECT dbo.detalleMatricula.id_DetalleMatricula FROM     dbo.datosEstudiante INNER JOIN dbo.matricula ON dbo.datosEstudiante.identidadEstudiante = dbo.matricula.id_Estudiante INNER JOIN dbo.detalleMatricula ON dbo.matricula.id_RegistroMatricula = dbo.detalleMatricula.id_RegistroMatricula " +
                                     "inner join dbo.cursos on dbo.detalleMatricula.id_Curso = dbo.cursos.id_Curso inner join dbo.seccion on dbo.detalleMatricula.id_Seccion = dbo.seccion.id_Seccion where dbo.datosEstudiante.identidadEstudiante = '" + txtIdentidad.Text + "' OR dbo.datosEstudiante.identidadEstudiante = '" + txtIdentidadAE.Text + "' and" +
                                     " dbo.cursos.nombreCurso = '" + txtCurso.Text + "' and dbo.seccion.nombreSeccion = '" + txtSeccion.Text + "' ");

                Id_Clase = dbConn.obtenerVariableEntera("SELECT dbo.clasesCurso.id_Clase FROM     dbo.cursos INNER JOIN dbo.seccion ON " +
                           "dbo.cursos.id_Curso = dbo.seccion.id_Curso INNER JOIN dbo.clasesCurso ON dbo.cursos.id_Curso = dbo.clasesCurso.id_Curso Where" +
                           " dbo.clasesCurso.nombreClase = '" + cmbClasesCS.SelectedItem.ToString() + "' ");

                if (dbConn.PAAgregarNota(id_detalleMatricula, Id_Clase, nota1, nota2, nota3, nota4, notaFinal))
                {
                    messageOk.lblCheck.Text = "Se Agregaron correctamente";
                    messageOk.ShowDialog();
                    gpxIngreso_Notas.Visible = false;
                    gpxCuadroNotas.Visible = true;

                }
                else
                {
                    message.lblError.Text = "Error al Ingresar las Notas\n";
                    message.ShowDialog();
                }

            }

        }

        private void abModificarNota_Click(object sender, EventArgs e)
        {

            identidad2 = txtIdentidad.Text;
            curso = txtCurso.Text;
            seccion = txtSeccion.Text;
            nombre2 = txtNombreAlumno.Text;
            Nota1 = float.Parse(txtNota1.Text);
            Nota2 = float.Parse(txtNota2.Text);
            Nota3 = float.Parse(txtNota3.Text);
            Nota4 = float.Parse(txtNota4.Text);
            NotaProm = float.Parse(txtNotaProm.Text);


            if (cmbClasesCS.SelectedItem == null)
            {
                message.lblError.Text = "Debe seleccionar una Clase\n";
                message.ShowDialog();
            }
            else
            {
                id_detalleMatricula = dbConn.obtenerVariableEntera("SELECT dbo.detalleMatricula.id_DetalleMatricula FROM     dbo.datosEstudiante INNER JOIN dbo.matricula ON dbo.datosEstudiante.identidadEstudiante = dbo.matricula.id_Estudiante INNER JOIN dbo.detalleMatricula ON dbo.matricula.id_RegistroMatricula = dbo.detalleMatricula.id_RegistroMatricula " +
                                     "inner join dbo.cursos on dbo.detalleMatricula.id_Curso = dbo.cursos.id_Curso inner join dbo.seccion on dbo.detalleMatricula.id_Seccion = dbo.seccion.id_Seccion where dbo.datosEstudiante.identidadEstudiante = '" + txtIdentidad.Text + "' OR dbo.datosEstudiante.identidadEstudiante = '" + txtIdentidadAE.Text + "' and" +
                                     " dbo.cursos.nombreCurso = '" + txtCurso.Text + "' and dbo.seccion.nombreSeccion = '" + txtSeccion.Text + "' ");

                Id_Clase = dbConn.obtenerVariableEntera("SELECT dbo.clasesCurso.id_Clase FROM     dbo.cursos INNER JOIN dbo.seccion ON " +
                           "dbo.cursos.id_Curso = dbo.seccion.id_Curso INNER JOIN dbo.clasesCurso ON dbo.cursos.id_Curso = dbo.clasesCurso.id_Curso Where" +
                           " dbo.clasesCurso.nombreClase = '" + cmbClasesCS.SelectedItem.ToString() + "' ");

                if (dbConn.PAModificarNota(id_detalleMatricula, Id_Clase, Nota1, Nota2, Nota3, Nota4, NotaProm))
                {
                    messageOk.lblCheck.Text = "Se Modificaron correctamente";
                    messageOk.ShowDialog();
                    gpxIngreso_Notas.Visible = false;
                    gpxCuadroNotas.Visible = true;

                }
                else
                {
                    message.lblError.Text = "Error al Modificar las Notas";
                    message.ShowDialog();
                }

            }

        }

        private void Limpiar()
        {
                txtIdentidad.Clear();
                txtIdentidadAE.Clear();
                txtNombreAE.Clear();
                txtNombreAlumno.Clear();
                txtCurso.Clear();
                txtSeccion.Clear();
                cmbClasesCS.ResetText();
                txtNota1.Text = "0";
                txtNota2.Text = "0";
                txtNota3.Text = "0";
                txtNota4.Text = "0";
                txtNotaProm.Text = "0";
           
        }

        private void abLimpiar_Click(object sender, EventArgs e)
        {

            if (chkLimpDatos.Checked)
            {
                txtIdentidad.ResetText();
                txtIdentidadAE.ResetText();
                txtNombreAE.ResetText();
                txtNombreAlumno.ResetText();
                txtCurso.ResetText();
                txtSeccion.ResetText();
                cmbClasesCS.ResetText();
            }
            else
            {
                txtNota1.Text = "0";
                txtNota2.Text = "0";
                txtNota3.Text = "0";
                txtNota4.Text = "0";
                txtNotaProm.Text = "0";
            }

        }

        private void abCuadroNotas_Click(object sender, EventArgs e)
        {

            Limpiar();
            gpxIngreso_Notas.Visible = false;
            gpxCuadroNotas.Visible = true;

        }


        private void gpxCuadroNotas_VisibleChanged(object sender, EventArgs e)
        {

            dbConn.llenarDGV(dgvCuadroNotas, "SELECT dbo.datosEstudiante.identidadEstudiante as 'Identidad del Estudiante', CONCAT(dbo.datosEstudiante.primerNombre,' ', dbo.datosEstudiante.segundoNombre,' ', dbo.datosEstudiante.primerApellido,' ', dbo.datosEstudiante.segundoApellido) as 'Nombre Estudiante'," +
                " dbo.clasesCurso.nombreClase as 'Clase', dbo.cursos.nombreCurso as 'Curso', dbo.seccion.nombreSeccion as 'Sección'," +
                " dbo.detalleNotas.nota1erParcial as 'Nota Primer Parcial', dbo.detalleNotas.nota2doParcial as 'Segundo Parcial', " +
                "dbo.detalleNotas.nota3erParcial as 'Tercer Parcial', dbo.detalleNotas.nota4toParcial as 'Cuarto Parcial', dbo.detalleNotas.notaFinal as 'Nota Promedio'" +
                " FROM     dbo.seccion INNER JOIN dbo.cursos ON dbo.seccion.id_Curso = dbo.cursos.id_Curso INNER JOIN" +
                " dbo.clasesCurso ON dbo.cursos.id_Curso = dbo.clasesCurso.id_Curso INNER JOIN dbo.detalleNotas ON dbo.clasesCurso.id_Clase = dbo.detalleNotas.id_Clase INNER JOIN" +
                " dbo.detalleMatricula ON dbo.seccion.id_Seccion = dbo.detalleMatricula.id_Seccion AND dbo.cursos.id_Curso = dbo.detalleMatricula.id_Curso AND" +
                " dbo.detalleNotas.id_DetalleMatricula = dbo.detalleMatricula.id_DetalleMatricula INNER JOIN dbo.matricula ON dbo.detalleMatricula.id_RegistroMatricula = dbo.matricula.id_RegistroMatricula INNER JOIN " +
                "dbo.datosEstudiante ON dbo.matricula.id_Estudiante = dbo.datosEstudiante.identidadEstudiante");

        }

        private void pbRegresar3_Click(object sender, EventArgs e)
        {

            gpxCuadroNotas.Visible = false;
            Limpiar();
            gpxIngreso_Notas.Visible = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Limpiar();
            gpxIngreso_Notas.Visible = false;
            gpxSeleccionAlumno.Visible = true;
            txtIdentidad.Visible = false;
            txtIdentidadAE.Visible = true;
            txtNombreAlumno.Visible = false;
            txtNombreAE.Visible = true;
            
        }

        private void pbRegresar1_Click(object sender, EventArgs e)
        {
            gpxSeleccionAlumno.Visible = false;

            cmbCursos.SelectedItem = 0;
            cmbSeccion.ResetText();
            gpxSeleccionCurso.Visible = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void dgvCuadroNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            identidad2 = dgvCuadroNotas.CurrentRow.Cells[0].Value.ToString();
            nombre2 = dgvCuadroNotas.CurrentRow.Cells[1].Value.ToString();
            Clase = dgvCuadroNotas.CurrentRow.Cells[2].Value.ToString();
            Nota1 = float.Parse(dgvCuadroNotas.CurrentRow.Cells[5].Value.ToString());
            Nota2 = float.Parse(dgvCuadroNotas.CurrentRow.Cells[6].Value.ToString());
            Nota3 = float.Parse(dgvCuadroNotas.CurrentRow.Cells[7].Value.ToString());
            Nota4 = float.Parse(dgvCuadroNotas.CurrentRow.Cells[8].Value.ToString());
            NotaProm = float.Parse(dgvCuadroNotas.CurrentRow.Cells[9].Value.ToString());



            Registro_y_Vista_de_Notas.Herencia_de_Variables.identidadG2 = identidad2;
            Registro_y_Vista_de_Notas.Herencia_de_Variables.nombreG2 = nombre2;
            Registro_y_Vista_de_Notas.Herencia_de_Variables.clase = Clase;
            Registro_y_Vista_de_Notas.Herencia_de_Variables.nota1G2 = Nota1;
            Registro_y_Vista_de_Notas.Herencia_de_Variables.nota2G2 = Nota2;
            Registro_y_Vista_de_Notas.Herencia_de_Variables.nota3G2 = Nota3;
            Registro_y_Vista_de_Notas.Herencia_de_Variables.nota4G2 = Nota4;


        }

        private void iniciarDGV(string text)
        {

            dbConn.llenarDGV(dgvCuadroNotas, "SELECT dbo.datosEstudiante.identidadEstudiante as 'Identidad del Estudiante', CONCAT(dbo.datosEstudiante.primerNombre,' ', dbo.datosEstudiante.segundoNombre,' ', dbo.datosEstudiante.primerApellido,' ', dbo.datosEstudiante.segundoApellido) as 'Nombre Estudiante'," +
                " dbo.clasesCurso.nombreClase as 'Clase', dbo.cursos.nombreCurso as 'Curso', dbo.seccion.nombreSeccion as 'Sección'," +
                " dbo.detalleNotas.nota1erParcial as 'Nota Primer Parcial', dbo.detalleNotas.nota2doParcial as 'Segundo Parcial', " +
                "dbo.detalleNotas.nota3erParcial as 'Tercer Parcial', dbo.detalleNotas.nota4toParcial as 'Cuarto Parcial', dbo.detalleNotas.notaFinal as 'Nota Promedio'" +
                " FROM     dbo.seccion INNER JOIN dbo.cursos ON dbo.seccion.id_Curso = dbo.cursos.id_Curso INNER JOIN" +
                " dbo.clasesCurso ON dbo.cursos.id_Curso = dbo.clasesCurso.id_Curso INNER JOIN dbo.detalleNotas ON dbo.clasesCurso.id_Clase = dbo.detalleNotas.id_Clase INNER JOIN" +
                " dbo.detalleMatricula ON dbo.seccion.id_Seccion = dbo.detalleMatricula.id_Seccion AND dbo.cursos.id_Curso = dbo.detalleMatricula.id_Curso AND" +
                " dbo.detalleNotas.id_DetalleMatricula = dbo.detalleMatricula.id_DetalleMatricula INNER JOIN dbo.matricula ON dbo.detalleMatricula.id_RegistroMatricula = dbo.matricula.id_RegistroMatricula INNER JOIN " +
                "dbo.datosEstudiante ON dbo.matricula.id_Estudiante = dbo.datosEstudiante.identidadEstudiante Where (identidadEstudiante like '" + text + "%' OR primerNombre like '" + text + "%')");

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            iniciarDGV(txtBuscar.Text);

        }

        private void abSiguiente_Click(object sender, EventArgs e)
        {

            if (identidad2 == null || nombre2 == null)
            {
                message.lblError.Location = new Point(118, 68);
                message.lblError.Text = "SELECCIONE UNA CELDA\nPARA CONTINUAR";
                message.lblError.TextAlign = ContentAlignment.MiddleCenter;
                message.ShowDialog();
            }
            else
            {

                txtIdentidadAE.Visible = false;
                txtIdentidad.Visible = true;
                txtNombreAE.Visible = false;
                txtNombreAlumno.Visible = true;
                gpxCuadroNotas.Visible = false;
                gpxIngreso_Notas.Visible = true;

            }

        }

    }
}
