﻿using SistemaGestorEscolar.Utilidades;
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
        public string identidadA = null;
        public string nombre = null;
        public int formaEvaluacion;
        public string ID;
        public string NameA;
        int exist;
        public string existenciaNota;

        //Ingreso de Notas.Variables
        public int id_detalleMatricula1;
        public int id_detalleMatricula2;
        public string Identidad;
        public int Id_Clase;
        public string nombreClase;
        int notaProm;
        public string curso;
        public string seccion;
        public string nombreAlumno;
        public float nota1, nota2, nota3, nota4, notaFinal;
        string notaA, notaB, notaC, notaD, notaE;

        //Cuadro de Notas.Variables
        public string IDcn;
        public string nombreCN;
        public string Clase;
        public string estado;
        public float Nota1;
        public float Nota2;
        public float Nota3;
        public float Nota4;
        public float NotaProm;
        string NotaA, NotaB, NotaC, NotaD, NotaE;


        public IfrmIngreso_de_Notas()
        {
            InitializeComponent();
        }

        private void IfrmIngreso_de_Notas_Load(object sender, EventArgs e)
        {
            clsVariablesGlobales.numIdentidad = "1001200100364";
            dbConn.llenarComboBox(cmbCursos, "SELECT nombreCurso FROM cursos c INNER JOIN seccion s ON c.id_Curso = s.id_Curso WHERE id_Docente = '" + clsVariablesGlobales.numIdentidad + "'");//" + clsVariablesGlobales.numIdentidad + "

            gpxSeleccionAlumno.Visible = false;
            gpxIngreso_Notas.Visible = false;
            gpxCuadroNotas.Visible = false;

            cmbCursos.SelectedItem = 0;
            cmbSeccion.SelectedItem = 0;

            ClsCambioTema.cambiarTemaBoton(gpxSeleccionCurso);
            ClsCambioTema.cambiarTemaBoton(gpxSeleccionAlumno);
            ClsCambioTema.cambiarTemaBoton(gpxIngreso_Notas);
            ClsCambioTema.cambiarTemaBoton(gpxCuadroNotas);

            if (Properties.Settings.Default.isModoOscuro == true)
            {

                gpxSeleccionCurso.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                gpxSeleccionAlumno.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                gpxIngreso_Notas.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                gpxCuadroNotas.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);

            }
            else
            {

                gpxSeleccionCurso.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                gpxSeleccionAlumno.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                gpxIngreso_Notas.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                gpxCuadroNotas.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);

            }


        }

        private void cmbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCursos.Items.Count > 0)
            {
                 
                if(cmbCursos.Text != null)
                {
                    cmbSeccion.Items.Clear();
                    dbConn.llenarComboBox(cmbSeccion, "SELECT dbo.seccion.nombreSeccion FROM     dbo.cursos INNER JOIN dbo.seccion ON " +
                        "dbo.cursos.id_Curso = dbo.seccion.id_Curso Where dbo.cursos.nombreCurso = '" + cmbCursos.SelectedItem + "' ");
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

            formaEvaluacion = dbConn.obtenerVariableEntera("Select [tipoCalificacion] from [dbo].[cursos] where [nombreCurso] = '" + cursoElegido + "'");


            if (cmbCursos.SelectedIndex == -1 && cmbSeccion.SelectedIndex == -1)
            {
                message.lblError.Location = new Point(118, 68);
                message.lblError.Text = "SELECCIONE UN CURSO Y SECCIÓN";
                message.lblError.TextAlign = ContentAlignment.MiddleCenter;
                message.ShowDialog();

            }
            else if (cmbSeccion.Text != seccionElegida)
            {
                message.lblError.Location = new Point(118, 68);
                message.lblError.Text = "SELECCIONE UNA SECCIÓN";
                message.lblError.TextAlign = ContentAlignment.MiddleCenter;
                message.ShowDialog();
            }
            else
            {
                if (formaEvaluacion == 3)
                {
                    messageWarning.lblError.Location = new Point(118, 68);
                    messageWarning.lblError.Text = "EL CURSO ELEGIDO NO TIENE\n UNA FORMA DE EVALUACIÓN";
                    messageWarning.lblError.TextAlign = ContentAlignment.MiddleCenter;
                    messageWarning.ShowDialog();
                }
                else
                {
                    gpxSeleccionCurso.Visible = false;
                    gpxSeleccionAlumno.Visible = true;
                }
            }

        }

        //--------------------------Grupbox Seleccion Alumno-------------------------------------

        private void gpxSeleccionAlumno_VisibleChanged(object sender, EventArgs e)
        {

            dbConn.llenarDGV(dgvSeleccionAlumno, "SELECT dbo.datosEstudiante.identidadEstudiante as 'Identidad del Estudiante', CONCAT(dbo.datosEstudiante.primerNombre,' ', dbo.datosEstudiante.segundoNombre,' ', dbo.datosEstudiante.primerApellido,' ', dbo.datosEstudiante.segundoApellido) as 'Nobre del Estudiante'," +
                " dbo.cursos.nombreCurso as Curso, dbo.seccion.nombreSeccion as Sección FROM     dbo.datosEstudiante INNER JOIN" +
                " dbo.matricula ON dbo.datosEstudiante.identidadEstudiante = dbo.matricula.id_Estudiante INNER JOIN " +
                "dbo.detalleMatricula ON dbo.matricula.id_RegistroMatricula = dbo.detalleMatricula.id_RegistroMatricula INNER JOIN " +
                "dbo.cursos ON dbo.detalleMatricula.id_Curso = dbo.cursos.id_Curso INNER JOIN dbo.seccion ON" +
                " dbo.detalleMatricula.id_Seccion = dbo.seccion.id_Seccion AND dbo.cursos.id_Curso = dbo.seccion.id_Curso Where" +
                " dbo.cursos.nombreCurso = '" + Herencia_de_Variables.CursoG + "' and dbo.seccion.nombreSeccion = '" + Herencia_de_Variables.SeccionG + "' and [dbo].[detalleMatricula].[estado] = 1"); //and [dbo].[detalleMatricula].[estado] = 2

        }

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
                Registro_y_Vista_de_Notas.Herencia_de_Variables.identidadG = identidadA;
                Registro_y_Vista_de_Notas.Herencia_de_Variables.nombreG = nombre;
            }


        }

        private void abContinuar2_Click(object sender, EventArgs e)
        {

            if (identidadA == null || nombre == null)
            {

                message.lblError.Location = new Point(118, 68);
                message.lblError.Text = "SELECCIONE UNA CELDA\nPARA CONTINUAR";
                message.lblError.TextAlign = ContentAlignment.MiddleCenter;
                message.ShowDialog();

            }
            else
            {
                Limpiar();
                gpxSeleccionAlumno.Visible = false;
                gpxIngreso_Notas.Visible = true;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvSeleccionAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            
        }
        private void gpxIngreso_Notas_VisibleChanged_1(object sender, EventArgs e)
        {

            if(formaEvaluacion == 1)
            {
                txtIdentidad.Text = IDcn;
                txtIdentidad.ForeColor = Color.Green;
                txtNombreAlumno.Text = nombreCN;
                mktNotaA.Visible = false;
                mktNotaB.Visible = false;
                mktNotaC.Visible = false;
                mktNotaD.Visible = false;
                mktNotaE.Visible = false;
            }
            else if(formaEvaluacion == 2)
            {
                txtIdentidad.Text = ID;
                txtIdentidad.ForeColor = Color.Green; 
                txtNombreAlumno.Text = NameA;
                txtNota1.Visible = false;
                txtNota2.Visible = false;
                txtNota3.Visible = false;
                txtNota4.Visible = false;
                txtNotaProm.Visible = false;
            }
            cmbClasesCS.Items.Clear();
            dbConn.llenarComboBox(cmbClasesCS, "SELECT        dbo.clases.nombreClase FROM            dbo.clases INNER JOIN " +
                    "dbo.clasesCurso ON dbo.clases.id_Clase = dbo.clasesCurso.id_Clase INNER JOIN " +
                    "dbo.cursos ON dbo.clasesCurso.id_Curso = dbo.cursos.id_Curso INNER JOIN " +
                    "dbo.seccion ON dbo.cursos.id_Curso = dbo.seccion.id_Curso Where dbo.cursos.[nombreCurso] = '" + Herencia_de_Variables.CursoG + "' and dbo.seccion.[nombreSeccion] = '" + Herencia_de_Variables.SeccionG + "'");
            txtCurso.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.CursoG;
            txtSeccion.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.SeccionG;
            txtIdentidadAE.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.identidadG;
            txtNombreAE.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.nombreG;
            cmbClasesCS.SelectedItem = Clase;
            txtNota1.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.nota1G2.ToString();
            txtNota2.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.nota2G2.ToString();
            txtNota3.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.nota3G2.ToString();
            txtNota4.Text = Registro_y_Vista_de_Notas.Herencia_de_Variables.nota4G2.ToString();

            mktNotaA.Text = NotaA;
            mktNotaB.Text = NotaB;
            mktNotaC.Text = NotaD;
            mktNotaD.Text = NotaC;
            mktNotaE.Text = NotaE;


        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNota1.Text != "")
                {

                    if (Convert.ToInt32(txtNota1.Text) >= 101)
                    {
                        message.lblError.Text = "INGRESE UNA NOTA VÁLIDA";
                        message.ShowDialog();
                        txtNota1.Text = "0";
                    }
                    else if (txtNota2.Text != "0" && txtNota3.Text != "0" && txtNota4.Text != "0")
                    {
                        notaProm = (Convert.ToInt32(txtNota1.Text) + Convert.ToInt32(txtNota2.Text) + Convert.ToInt32(txtNota3.Text) + Convert.ToInt32(txtNota4.Text)) / 4;

                        txtNotaProm.Text = notaProm.ToString();
                    }

                }
                else
                {
                    txtNotaProm.Clear();
                }
            }
            catch
            {

            }

        }

        private void txtNota2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNota2.Text != "")
                {
                    if (Convert.ToInt32(txtNota2.Text) >= 101)
                    {
                        message.lblError.Text = "INGRESE UNA NOTA VÁLIDA";
                        message.ShowDialog();
                        txtNota2.Text = "0";
                    }
                    else if (txtNota2.Text != "0" && txtNota3.Text != "0" && txtNota4.Text != "0")
                    {
                        notaProm = (Convert.ToInt32(txtNota1.Text) + Convert.ToInt32(txtNota2.Text) + Convert.ToInt32(txtNota3.Text) + Convert.ToInt32(txtNota4.Text)) / 4;

                        txtNotaProm.Text = notaProm.ToString();
                    }
                }
                else
                {
                    txtNotaProm.Clear();
                }
            }
            catch
            {

            }
        }

        private void txtNota3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNota3.Text != "")
                {
                    if (Convert.ToInt32(txtNota3.Text) >= 101)
                    {
                        message.lblError.Text = "INGRESE UNA NOTA VÁLIDA";
                        message.ShowDialog();
                        txtNota3.Text = "0";
                    }
                    else if (txtNota2.Text != "0" && txtNota3.Text != "0" && txtNota4.Text != "0")
                    {
                        notaProm = (Convert.ToInt32(txtNota1.Text) + Convert.ToInt32(txtNota2.Text) + Convert.ToInt32(txtNota3.Text) + Convert.ToInt32(txtNota4.Text)) / 4;

                        txtNotaProm.Text = notaProm.ToString();
                    }
                }
                else
                {
                    txtNotaProm.Clear();
                }
            }
            catch
            {

            }
        }

        private void txtNota4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNota4.Text != "")
                {
                    if (Convert.ToInt32(txtNota4.Text) >= 101)
                    {
                        message.lblError.Text = "INGRESE UNA NOTA VÁLIDA";
                        message.ShowDialog();
                        txtNota4.Text = "0";
                    }
                    else if (txtNota2.Text != "0" && txtNota3.Text != "0" && txtNota4.Text != "0")
                    {
                        notaProm = (Convert.ToInt32(txtNota1.Text) + Convert.ToInt32(txtNota2.Text) + Convert.ToInt32(txtNota3.Text) + Convert.ToInt32(txtNota4.Text)) / 4;

                        txtNotaProm.Text = notaProm.ToString();
                    }
                }
                else
                {
                    txtNotaProm.Clear();
                }
            }
            catch
            {

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
            id_detalleMatricula2 = 0;

            if (cmbClasesCS.SelectedItem != null)
            {
                id_detalleMatricula2 = dbConn.obtenerVariableEntera("SELECT dbo.detalleMatricula.id_DetalleMatricula FROM     dbo.datosEstudiante INNER JOIN dbo.matricula ON dbo.datosEstudiante.identidadEstudiante = dbo.matricula.id_Estudiante INNER JOIN dbo.detalleMatricula ON dbo.matricula.id_RegistroMatricula = dbo.detalleMatricula.id_RegistroMatricula inner join dbo.cursos on dbo.detalleMatricula.id_Curso = dbo.cursos.id_Curso inner join dbo.seccion on dbo.detalleMatricula.id_Seccion = dbo.seccion.id_Seccion where dbo.datosEstudiante.identidadEstudiante = '" + txtIdentidadAE.Text + "'  and dbo.cursos.nombreCurso = '" + txtCurso.Text + "' and dbo.seccion.nombreSeccion = '" + txtSeccion.Text + "'");
                Id_Clase = dbConn.obtenerVariableEntera("SELECT        dbo.clasesCurso.id_Clase FROM            dbo.clases INNER JOIN dbo.clasesCurso ON dbo.clases.id_Clase = dbo.clasesCurso.id_Clase INNER JOIN" +
                                      " dbo.cursos ON dbo.clasesCurso.id_Curso = dbo.cursos.id_Curso Where dbo.clases.[nombreClase] = '" + cmbClasesCS.SelectedItem.ToString() + "' ");

                Identidad = txtIdentidad.Text;
                curso = txtCurso.Text;
                seccion = txtSeccion.Text;
                nombreAlumno = txtNombreAlumno.Text;
                if (formaEvaluacion == 1)
                {
                    if (txtNota1.Text != "0")
                    {
                        if(txtNota1.Text != string.Empty && txtNota2.Text != string.Empty && txtNota3.Text != string.Empty && txtNota4.Text != string.Empty && txtNotaProm.Text != string.Empty)
                        {
                            notaA = "";
                            notaB = "";
                            notaC = "";
                            notaD = "";
                            notaE = "";

                            nota1 = float.Parse(txtNota1.Text);
                            nota2 = float.Parse(txtNota2.Text);
                            nota3 = float.Parse(txtNota3.Text);
                            nota4 = float.Parse(txtNota4.Text);
                            notaFinal = float.Parse(txtNotaProm.Text);

                            if (dbConn.PAModificarNota(id_detalleMatricula2, Id_Clase, nota1, nota2, nota3, nota4, notaFinal, notaA, notaB, notaC, notaD, notaE))
                            {
                                messageOk.lblCheck.Text = "Se Agregaron correctamente";
                                messageOk.ShowDialog();

                                id_detalleMatricula2 = 0;

                            }
                            else
                            {
                                message.lblError.Text = "Error al Ingresar las Notas\n";
                                message.ShowDialog();
                            }
                        }
                        else
                        {
                            message.lblError.Text = "Ingrese todas las notas\n";
                            message.ShowDialog();
                        }
                    }
                    else
                    {
                        message.lblError.Text = "Nota 1 debe ser\n diferente de 0";
                        message.ShowDialog();
                    }
                }
                else if (formaEvaluacion == 2)
                {

                    notaA = mktNotaA.Text;
                    notaB = mktNotaB.Text;
                    notaC = mktNotaC.Text;
                    notaD = mktNotaD.Text;
                    notaE = mktNotaE.Text;

                    if (dbConn.PAModificarNota(id_detalleMatricula2, Id_Clase, nota1, nota2, nota3, nota4, notaFinal, notaA, notaB, notaC, notaD, notaE))
                    {
                        messageOk.lblCheck.Text = "Se Agregaron correctamente";
                        messageOk.ShowDialog();
                        gpxIngreso_Notas.Visible = false;
                        gpxCuadroNotas.Visible = true;

                        id_detalleMatricula2 = 0;

                    }
                    else
                    {
                        message.lblError.Text = "Error al Ingresar las Notas\n";
                        message.ShowDialog();
                    }



                }

            }
            else
            {
                message.lblError.Text = "Debe seleccionar una Clase\n";
                message.ShowDialog();
            }

        }

        private void mktNotaB_TextChanged(object sender, EventArgs e)
        {
            mktNotaB.Text = mktNotaB.Text.ToUpper();
        }

        private void mktNotaA_TextChanged(object sender, EventArgs e)
        {
            mktNotaA.Text = mktNotaA.Text.ToUpper();
        }

        private void mktNotaD_TextChanged(object sender, EventArgs e)
        {
            mktNotaD.Text = mktNotaD.Text.ToUpper();
        }

        private void mktNotaC_TextChanged(object sender, EventArgs e)
        {
            mktNotaC.Text = mktNotaC.Text.ToUpper();
        }

        private void mktNotaE_TextChanged(object sender, EventArgs e)
        {
            mktNotaE.Text = mktNotaE.Text.ToUpper();
        }

        private void txtNotaProm_TextChanged(object sender, EventArgs e)
        {

        }

        private void abCuadroNotas_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbClasesCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(formaEvaluacion == 1)
            {
                if(!dbConn.llenarTextBox(txtNota1, "SELECT notas.nota1erParcial as 'Nota Primer Parcial' FROM detalleMatricula dm INNER JOIN matricula matr ON dm.id_RegistroMatricula = matr.id_RegistroMatricula INNER JOIN datosEstudiante estu on matr.id_Estudiante = estu.identidadEstudiante INNER JOIN detalleNotas notas ON dm.id_DetalleMatricula = notas.id_DetalleMatricula INNER JOIN clasesCurso cCurs ON notas.id_Clase = cCurs.id_Clase INNER JOIN clases cls ON cCurs.id_Clase = cls.id_Clase INNER JOIN cursos cur ON cCurs.id_Curso = cur.id_Curso INNER JOIN seccion sec On cur.id_Curso = sec.id_Curso AND sec.id_Seccion = dm.id_Seccion WHERE dm.estado = 1 AND cur.nombreCurso = '" + txtCurso.Text + "' AND sec.nombreSeccion = '" + txtSeccion.Text + "' AND estu.identidadEstudiante = '"+txtIdentidadAE.Text+"' AND cls.nombreClase = '" + cmbClasesCS.Text + "'"))
                {
                    txtNota1.Text = "0";
                }
                if (!dbConn.llenarTextBox(txtNota2, "SELECT notas.nota2doParcial as 'Segundo Parcial' FROM detalleMatricula dm INNER JOIN matricula matr ON dm.id_RegistroMatricula = matr.id_RegistroMatricula INNER JOIN datosEstudiante estu on matr.id_Estudiante = estu.identidadEstudiante INNER JOIN detalleNotas notas ON dm.id_DetalleMatricula = notas.id_DetalleMatricula INNER JOIN clasesCurso cCurs ON notas.id_Clase = cCurs.id_Clase INNER JOIN clases cls ON cCurs.id_Clase = cls.id_Clase INNER JOIN cursos cur ON cCurs.id_Curso = cur.id_Curso INNER JOIN seccion sec On cur.id_Curso = sec.id_Curso AND sec.id_Seccion = dm.id_Seccion WHERE dm.estado = 1 AND cur.nombreCurso = '" + txtCurso.Text + "' AND sec.nombreSeccion = '" + txtSeccion.Text + "' AND estu.identidadEstudiante = '" + txtIdentidadAE.Text + "' AND cls.nombreClase = '" + cmbClasesCS.Text + "'"))
                {
                    txtNota2.Text = "0";
                }
                if (!dbConn.llenarTextBox(txtNota3, "SELECT notas.nota3erParcial as 'Tercer Parcial' FROM detalleMatricula dm INNER JOIN matricula matr ON dm.id_RegistroMatricula = matr.id_RegistroMatricula INNER JOIN datosEstudiante estu on matr.id_Estudiante = estu.identidadEstudiante INNER JOIN detalleNotas notas ON dm.id_DetalleMatricula = notas.id_DetalleMatricula INNER JOIN clasesCurso cCurs ON notas.id_Clase = cCurs.id_Clase INNER JOIN clases cls ON cCurs.id_Clase = cls.id_Clase INNER JOIN cursos cur ON cCurs.id_Curso = cur.id_Curso INNER JOIN seccion sec On cur.id_Curso = sec.id_Curso AND sec.id_Seccion = dm.id_Seccion WHERE dm.estado = 1 AND cur.nombreCurso = '" + txtCurso.Text + "' AND sec.nombreSeccion = '" + txtSeccion.Text + "' AND estu.identidadEstudiante = '" + txtIdentidadAE.Text + "' AND cls.nombreClase = '" + cmbClasesCS.Text + "'"))
                {
                    txtNota3.Text = "0";
                }
                if (!dbConn.llenarTextBox(txtNota4, "SELECT notas.nota4toParcial as 'Cuarto Parcial' FROM detalleMatricula dm INNER JOIN matricula matr ON dm.id_RegistroMatricula = matr.id_RegistroMatricula INNER JOIN datosEstudiante estu on matr.id_Estudiante = estu.identidadEstudiante INNER JOIN detalleNotas notas ON dm.id_DetalleMatricula = notas.id_DetalleMatricula INNER JOIN clasesCurso cCurs ON notas.id_Clase = cCurs.id_Clase INNER JOIN clases cls ON cCurs.id_Clase = cls.id_Clase INNER JOIN cursos cur ON cCurs.id_Curso = cur.id_Curso INNER JOIN seccion sec On cur.id_Curso = sec.id_Curso AND sec.id_Seccion = dm.id_Seccion WHERE dm.estado = 1 AND cur.nombreCurso = '" + txtCurso.Text + "' AND sec.nombreSeccion = '" + txtSeccion.Text + "' AND estu.identidadEstudiante = '" + txtIdentidadAE.Text + "' AND cls.nombreClase = '" + cmbClasesCS.Text + "'"))
                {
                    txtNota4.Text = "0";
                }
                if (!dbConn.llenarTextBox(txtNotaProm, "SELECT notas.notaFinal as 'Nota Promedio' FROM detalleMatricula dm INNER JOIN matricula matr ON dm.id_RegistroMatricula = matr.id_RegistroMatricula INNER JOIN datosEstudiante estu on matr.id_Estudiante = estu.identidadEstudiante INNER JOIN detalleNotas notas ON dm.id_DetalleMatricula = notas.id_DetalleMatricula INNER JOIN clasesCurso cCurs ON notas.id_Clase = cCurs.id_Clase INNER JOIN clases cls ON cCurs.id_Clase = cls.id_Clase INNER JOIN cursos cur ON cCurs.id_Curso = cur.id_Curso INNER JOIN seccion sec On cur.id_Curso = sec.id_Curso AND sec.id_Seccion = dm.id_Seccion WHERE dm.estado = 1 AND cur.nombreCurso = '" + txtCurso.Text + "' AND sec.nombreSeccion = '" + txtSeccion.Text + "' AND estu.identidadEstudiante = '" + txtIdentidadAE.Text + "' AND cls.nombreClase = '" + cmbClasesCS.Text + "'"))
                {
                    txtNotaProm.Text = "0";
                }
               
                
            }
            else
            {

            }
        }

        private void abRegresar2_Click(object sender, EventArgs e)
        {
            gpxCuadroNotas.Visible = false;
            Limpiar();
            gpxSeleccionAlumno.Visible = true;
        }

        private void abRegresar1_Click(object sender, EventArgs e)
        {
            Limpiar();
            gpxIngreso_Notas.Visible = false;
            gpxSeleccionAlumno.Visible = true;
            txtIdentidad.Visible = false;
            txtIdentidadAE.Visible = true;
            txtNombreAlumno.Visible = false;
            txtNombreAE.Visible = true;
            txtIdentidadAE.Clear();
            txtIdentidad.Clear();
            id_detalleMatricula2 = 0;
            id_detalleMatricula1 = 0;
        }

        private void abRegresar_Click(object sender, EventArgs e)
        {
            gpxSeleccionAlumno.Visible = false;
            cmbCursos.SelectedItem = 0;
            cmbSeccion.ResetText();
            gpxSeleccionCurso.Visible = true;
        }

        private void Limpiar()
        {

            cmbClasesCS.Items.Clear() ;
                txtNota1.Text = "0";
                txtNota2.Text = "0";
                txtNota3.Text = "0";
                txtNota4.Text = "0";
                txtNotaProm.Text = "0";
                mktNotaA.ResetText();
                mktNotaB.ResetText();
                mktNotaC.ResetText();
                mktNotaD.ResetText();
                mktNotaE.ResetText();
            cmbClasesCS.Items.Clear();
            dbConn.llenarComboBox(cmbClasesCS, "SELECT        dbo.clases.nombreClase FROM            dbo.clases INNER JOIN " +
                    "dbo.clasesCurso ON dbo.clases.id_Clase = dbo.clasesCurso.id_Clase INNER JOIN " +
                    "dbo.cursos ON dbo.clasesCurso.id_Curso = dbo.cursos.id_Curso INNER JOIN " +
                    "dbo.seccion ON dbo.cursos.id_Curso = dbo.seccion.id_Curso Where dbo.cursos.[nombreCurso] = '" + Herencia_de_Variables.CursoG + "' and dbo.seccion.[nombreSeccion] = '" + Herencia_de_Variables.SeccionG + "'");
        }

        private void abLimpiar_Click(object sender, EventArgs e)
        {

            Limpiar();

        }

        private void abCuadroNotas_Click(object sender, EventArgs e)
        {
            cmbClasesCS.Items.Clear();
            gpxSeleccionAlumno.Visible = false;
            gpxCuadroNotas.Visible = true;

        }


        private void gpxCuadroNotas_VisibleChanged(object sender, EventArgs e)
        {

            if(formaEvaluacion == 1)
            {
                dbConn.llenarDGV(dgvCuadroNotas, "SELECT estu.identidadEstudiante as 'Identidad del Estudiante', CONCAT(estu.primerNombre,' ', estu.segundoNombre,' ', estu.primerApellido,' ', estu.segundoApellido)as 'Nombre Estudiante', cls.nombreClase as 'Clase', cur.nombreCurso as 'Curso', sec.nombreSeccion as 'Sección', notas.nota1erParcial as 'Nota Primer Parcial', notas.nota2doParcial as 'Segundo Parcial', notas.nota3erParcial as 'Tercer Parcial', notas.nota4toParcial as 'Cuarto Parcial', notas.notaFinal as 'Nota Promedio' FROM detalleMatricula dm INNER JOIN matricula matr ON dm.id_RegistroMatricula = matr.id_RegistroMatricula INNER JOIN datosEstudiante estu on matr.id_Estudiante = estu.identidadEstudiante INNER JOIN detalleNotas notas ON dm.id_DetalleMatricula = notas.id_DetalleMatricula INNER JOIN clasesCurso cCurs ON notas.id_Clase = cCurs.id_Clase INNER JOIN clases cls ON cCurs.id_Clase = cls.id_Clase INNER JOIN cursos cur ON cCurs.id_Curso = cur.id_Curso INNER JOIN seccion sec On cur.id_Curso = sec.id_Curso AND sec.id_Seccion = dm.id_Seccion WHERE dm.estado = 1 AND cur.nombreCurso = '"+Herencia_de_Variables.CursoG+"' AND sec.nombreSeccion = '"+Herencia_de_Variables.SeccionG+"'");
            }
            else if(formaEvaluacion == 2)
            {
                dbConn.llenarDGV(dgvCuadroNotas, "SELECT        dbo.datosEstudiante.identidadEstudiante as 'Identidad del Estudiante', CONCAT(dbo.datosEstudiante.primerNombre,' ', dbo.datosEstudiante.segundoNombre,' ', dbo.datosEstudiante.primerApellido,' ', dbo.datosEstudiante.segundoApellido)as 'Nombre Estudiante', " +
                    "dbo.clases.nombreClase as 'Clase', dbo.cursos.nombreCurso as 'Curso', dbo.seccion.nombreSeccion as 'Sección', dbo.detalleNotas.notaA as 'Nota Primer Parcial'," +
                    " dbo.detalleNotas.notaB as 'Segundo Parcial', dbo.detalleNotas.notaC as 'Tercer Parcial', dbo.detalleNotas.notaD as 'Cuarto Parcial'," +
                    " dbo.detalleNotas.notaE as 'Nota Promedio' FROM          dbo.matricula INNER JOIN " +
                    "dbo.datosEstudiante ON dbo.matricula.id_Estudiante = dbo.datosEstudiante.identidadEstudiante INNER JOIN " +
                    "dbo.detalleMatricula ON dbo.matricula.id_RegistroMatricula = dbo.detalleMatricula.id_RegistroMatricula INNER JOIN" +
                    " dbo.detalleNotas INNER JOIN dbo.clasesCurso ON dbo.detalleNotas.id_Clase = dbo.clasesCurso.id_DetalleClase INNER JOIN" +
                    " dbo.clases ON dbo.clasesCurso.id_Clase = dbo.clases.id_Clase ON dbo.detalleMatricula.id_DetalleMatricula = dbo.detalleNotas.id_DetalleMatricula INNER JOIN " +
                    "dbo.cursos ON dbo.detalleMatricula.id_Curso = dbo.cursos.id_Curso AND dbo.clasesCurso.id_Curso = dbo.cursos.id_Curso INNER JOIN" +
                    " dbo.seccion ON dbo.detalleMatricula.id_Seccion = dbo.seccion.id_Seccion AND dbo.cursos.id_Curso = dbo.seccion.id_Curso Where [dbo].[cursos].[tipoCalificacion] = '" + formaEvaluacion + "' and [dbo].[detalleMatricula].[estado] = 1");
            }

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void dgvCuadroNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (formaEvaluacion == 1)
                {
                    IDcn = dgvCuadroNotas.CurrentRow.Cells[0].Value.ToString();
                    nombreCN = dgvCuadroNotas.CurrentRow.Cells[1].Value.ToString();
                    Clase = dgvCuadroNotas.CurrentRow.Cells[2].Value.ToString();
                    Nota1 = float.Parse(dgvCuadroNotas.CurrentRow.Cells[5].Value.ToString());
                    Nota2 = float.Parse(dgvCuadroNotas.CurrentRow.Cells[6].Value.ToString());
                    Nota3 = float.Parse(dgvCuadroNotas.CurrentRow.Cells[7].Value.ToString());
                    Nota4 = float.Parse(dgvCuadroNotas.CurrentRow.Cells[8].Value.ToString());
                    NotaProm = float.Parse(dgvCuadroNotas.CurrentRow.Cells[9].Value.ToString());

                    Registro_y_Vista_de_Notas.Herencia_de_Variables.clase = Clase;
                    Registro_y_Vista_de_Notas.Herencia_de_Variables.nota1G2 = Nota1;
                    Registro_y_Vista_de_Notas.Herencia_de_Variables.nota2G2 = Nota2;
                    Registro_y_Vista_de_Notas.Herencia_de_Variables.nota3G2 = Nota3;
                    Registro_y_Vista_de_Notas.Herencia_de_Variables.nota4G2 = Nota4;
                }
                else if (formaEvaluacion == 2)
                {

                    ID = dgvCuadroNotas.CurrentRow.Cells[0].Value.ToString();
                    NameA = dgvCuadroNotas.CurrentRow.Cells[1].Value.ToString();
                    Clase = dgvCuadroNotas.CurrentRow.Cells[2].Value.ToString();
                    NotaA = dgvCuadroNotas.CurrentRow.Cells[5].Value.ToString();
                    NotaB = dgvCuadroNotas.CurrentRow.Cells[6].Value.ToString();
                    NotaC = dgvCuadroNotas.CurrentRow.Cells[7].Value.ToString();
                    NotaD = dgvCuadroNotas.CurrentRow.Cells[8].Value.ToString();
                    NotaE = dgvCuadroNotas.CurrentRow.Cells[9].Value.ToString();

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }


        }

        private void iniciarDGV(string text)
        {

            if (formaEvaluacion == 1)
            {
                dbConn.llenarDGV(dgvCuadroNotas, "SELECT estu.identidadEstudiante as 'Identidad del Estudiante', CONCAT(estu.primerNombre,' ', estu.segundoNombre,' ', estu.primerApellido,' ', estu.segundoApellido)as 'Nombre Estudiante', cls.nombreClase as 'Clase', cur.nombreCurso as 'Curso', sec.nombreSeccion as 'Sección', notas.nota1erParcial as 'Nota Primer Parcial', notas.nota2doParcial as 'Segundo Parcial', notas.nota3erParcial as 'Tercer Parcial', notas.nota4toParcial as 'Cuarto Parcial', notas.notaFinal as 'Nota Promedio' FROM detalleMatricula dm INNER JOIN matricula matr ON dm.id_RegistroMatricula = matr.id_RegistroMatricula INNER JOIN datosEstudiante estu on matr.id_Estudiante = estu.identidadEstudiante INNER JOIN detalleNotas notas ON dm.id_DetalleMatricula = notas.id_DetalleMatricula INNER JOIN clasesCurso cCurs ON notas.id_Clase = cCurs.id_Clase INNER JOIN clases cls ON cCurs.id_Clase = cls.id_Clase INNER JOIN cursos cur ON cCurs.id_Curso = cur.id_Curso INNER JOIN seccion sec On cur.id_Curso = sec.id_Curso AND sec.id_Seccion = dm.id_Seccion " +
                    "WHERE dm.estado = 1 AND cur.nombreCurso = '"+Herencia_de_Variables.CursoG+"' AND sec.nombreSeccion = '"+Herencia_de_Variables.SeccionG+"' AND (estu.identidadEstudiante like '" + text + "%' OR estu.primerNombre like '" + text + "%')");
            }
            else if (formaEvaluacion == 2)
            {
                dbConn.llenarDGV(dgvCuadroNotas, "SELECT        dbo.datosEstudiante.identidadEstudiante as 'Identidad del Estudiante', CONCAT(dbo.datosEstudiante.primerNombre,' ', dbo.datosEstudiante.segundoNombre,' ', dbo.datosEstudiante.primerApellido,' ', dbo.datosEstudiante.segundoApellido)as 'Nombre Estudiante', " +
                    "dbo.clases.nombreClase as 'Clase', dbo.cursos.nombreCurso as 'Curso', dbo.seccion.nombreSeccion as 'Sección', dbo.detalleNotas.notaA as 'Nota Primer Parcial'," +
                    " dbo.detalleNotas.notaB as 'Segundo Parcial', dbo.detalleNotas.notaC as 'Tercer Parcial', dbo.detalleNotas.notaD as 'Cuarto Parcial'," +
                    " dbo.detalleNotas.notaE as 'Nota Promedio' FROM          dbo.matricula INNER JOIN " +
                    "dbo.datosEstudiante ON dbo.matricula.id_Estudiante = dbo.datosEstudiante.identidadEstudiante INNER JOIN " +
                    "dbo.detalleMatricula ON dbo.matricula.id_RegistroMatricula = dbo.detalleMatricula.id_RegistroMatricula INNER JOIN" +
                    " dbo.detalleNotas INNER JOIN dbo.clasesCurso ON dbo.detalleNotas.id_Clase = dbo.clasesCurso.id_DetalleClase INNER JOIN" +
                    " dbo.clases ON dbo.clasesCurso.id_Clase = dbo.clases.id_Clase ON dbo.detalleMatricula.id_DetalleMatricula = dbo.detalleNotas.id_DetalleMatricula INNER JOIN " +
                    "dbo.cursos ON dbo.detalleMatricula.id_Curso = dbo.cursos.id_Curso AND dbo.clasesCurso.id_Curso = dbo.cursos.id_Curso INNER JOIN" +
                    " dbo.seccion ON dbo.detalleMatricula.id_Seccion = dbo.seccion.id_Seccion AND dbo.cursos.id_Curso = dbo.seccion.id_Curso Where (identidadEstudiante like '" + text + "%' OR primerNombre like '" + text + "%') and [dbo].[cursos].[formaEvaluacion] = '" + formaEvaluacion + "' and [dbo].[detalleMatricula].[estado] = 1");
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            iniciarDGV(txtBuscar.Text);

        }

        private void abSiguiente_Click(object sender, EventArgs e)
        {

            if(formaEvaluacion == 1)
            {
                if (IDcn == null || nombreCN == null)
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
                    txtIdentidadAE.Clear();

                }
            }
            else if(formaEvaluacion == 2)
            {
                if (ID == null || NameA == null)
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
                    txtIdentidadAE.Clear();

                }
            }

        }

    }
}
