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
            nota1 = 0;
            nota2 = 0;
            nota3 = 0;
            nota4 = 0;
            notaFinal = 0;
            notaA = "";
            notaB = "";
            notaC = "";
            notaD = "";
            notaE = "";
            cmbClasesCS.Items.Clear();
            Limpiar();
            dbConn.llenarComboBox(cmbCursos, "SELECT nombreCurso FROM cursos c INNER JOIN seccion s ON c.id_Curso = s.id_Curso WHERE id_Docente = '"+ clsVariablesGlobales.numIdentidad + "' AND c.tipoCalificacion <> 3");

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
                    dbConn.llenarComboBox(cmbSeccion, "SELECT secc.nombreSeccion FROM cursos cur INNER JOIN seccion secc ON cur.id_Curso = secc.id_Curso Where cur.nombreCurso = '"+cmbCursos.SelectedItem.ToString()+"' " +
                        "AND secc.id_Docente = '"+clsVariablesGlobales.numIdentidad+"' ");

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


            if (cmbCursos.SelectedIndex == -1 && (cmbSeccion.SelectedIndex == -1 || cmbSeccion.Text == "<Seleccione>"))

                {
                    message.lblError.Location = new Point(130, 75);
                message.lblError.Text = "SELECCIONE UN CURSO";
                message.lblError.TextAlign = ContentAlignment.MiddleCenter;
                message.ShowDialog();

            }
            else if (cmbSeccion.Text != seccionElegida)
            {
                message.lblError.Location = new Point(130, 75);
                message.lblError.Text = "SELECCIONE UNA SECCION";
                message.lblError.TextAlign = ContentAlignment.MiddleCenter;
                message.ShowDialog();
            }
            else
            {
                if (formaEvaluacion == 3)
                {
                    messageWarning.lblError.Location = new Point(130, 68);
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
                message.lblError.Location = new Point(135, 68);
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
            nota1 = 0;
            nota2 = 0;
            nota3 = 0;
            nota4 = 0;
            notaFinal = 0;
            notaA = "";
            notaB = "";
            notaC = "";
            notaD = "";
            notaE = "";
            cmbClasesCS.Items.Clear();


            if (identidadA == null || nombre == null)
            {

                message.lblError.Location = new Point(135, 68);
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

        private void gpxIngreso_Notas_VisibleChanged(object sender, EventArgs e)
        {
            
        }
        private void gpxIngreso_Notas_VisibleChanged_1(object sender, EventArgs e)
        {

            if(formaEvaluacion == 1)
            {
                mktNotaA.Visible = false;
                mktNotaB.Visible = false;
                mktNotaC.Visible = false;
                mktNotaD.Visible = false;
                mktNotaE.Visible = false;
                txtNota1.Visible = true;
                txtNota2.Visible = true;
                txtNota3.Visible = true;
                txtNota4.Visible = true;
                txtNotaProm.Visible = true;
            }
            else
            {
                txtNota1.Visible = false;
                txtNota2.Visible = false;
                txtNota3.Visible = false;
                txtNota4.Visible = false;
                txtNotaProm.Visible = false;
                mktNotaA.Visible = true;
                mktNotaB.Visible = true;
                mktNotaC.Visible = true;
                mktNotaD.Visible = true;
                mktNotaE.Visible = true;
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
            mktNotaC.Text = NotaC;
            mktNotaD.Text = NotaD;
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
                        message.lblError.Location = new Point(145, 68);
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
                    txtNotaProm.Text = "0";
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
                        message.lblError.Location = new Point(145, 68);
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
                    txtNotaProm.Text = "0";
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
                        message.lblError.Location = new Point(145, 68);
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
                    txtNotaProm.Text = "0";
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
                        message.lblError.Location = new Point(145, 68);
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
                    txtNotaProm.Text = "0";
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
                                message.lblError.Location = new Point(145, 68);
                                messageOk.lblCheck.Text = "SE AGREGARON CORRECTAMENTE";
                                messageOk.ShowDialog();

                                id_detalleMatricula2 = 0;

                            }
                            else
                            {
                                message.lblError.Location = new Point(145, 68);
                                message.lblError.Text = "ERROR AL INGRESAR NOTAS";
                                message.ShowDialog();
                            }
                        }
                        else
                        {
                            message.lblError.Location = new Point(145, 68);
                            message.lblError.Text = "INGRESE TODAS LAS NOTAS";
                            message.ShowDialog();
                        }
                    }
                    else
                    {
                        message.lblError.Location = new Point(145, 68);
                        message.lblError.Text = "NOTA 1 DEBE SER\n DIFERENTE DE 0";
                        message.ShowDialog();
                    }
                }
                else if (formaEvaluacion == 2)
                {
                    nota1 = 0;
                    nota2 = 0;
                    nota3 = 0;
                    nota4 = 0;
                    notaFinal = 0;
                    notaA = mktNotaA.Text;
                    notaB = mktNotaB.Text;
                    notaC = mktNotaC.Text;
                    notaD = mktNotaD.Text;
                    notaE = mktNotaE.Text;

                    if(mktNotaA.Text != string.Empty)
                    {
                        if (dbConn.PAModificarNota(id_detalleMatricula2, Id_Clase, nota1, nota2, nota3, nota4, notaFinal, notaA, notaB, notaC, notaD, notaE))
                        {
                            message.lblError.Location = new Point(145, 68);
                            messageOk.lblCheck.Text = "SE AGREGARON CORRECTAMENTE";
                            messageOk.ShowDialog();

                            id_detalleMatricula2 = 0;

                        }
                        else
                        {
                            message.lblError.Location = new Point(145, 68);
                            message.lblError.Text = "ERROR AL INGRESAR NOTAS";
                            message.ShowDialog();
                        }
                    }
                    else
                    {
                        message.lblError.Location = new Point(145, 68);
                        message.lblError.Text = "INGRESE\n LA PRIMERA NOTA";
                        message.ShowDialog();
                    }
                }

            }
            else
            {
                message.lblError.Location = new Point(145, 68);
                message.lblError.Text = "DEBE SELECCIONAR UNA CLASE";
                message.ShowDialog();
            }

        }

        private void mktNotaB_TextChanged(object sender, EventArgs e)
        {
            formatoNota(mktNotaB);
        }

        private void mktNotaA_TextChanged(object sender, EventArgs e)
        {
            formatoNota(mktNotaA);
        }

        private void mktNotaD_TextChanged(object sender, EventArgs e)
        {
            formatoNota(mktNotaD);
        }

        private void mktNotaC_TextChanged(object sender, EventArgs e)
        {
            formatoNota(mktNotaC);
        }

        private void mktNotaE_TextChanged(object sender, EventArgs e)
        {
            formatoNota(mktNotaE);
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
                if (!dbConn.llenarMaskedTextBox(mktNotaA, "SELECT notas.notaA FROM detalleMatricula dm INNER JOIN matricula matr ON dm.id_RegistroMatricula = matr.id_RegistroMatricula INNER JOIN datosEstudiante estu on matr.id_Estudiante = estu.identidadEstudiante INNER JOIN detalleNotas notas ON dm.id_DetalleMatricula = notas.id_DetalleMatricula INNER JOIN clasesCurso cCurs ON notas.id_Clase = cCurs.id_Clase INNER JOIN clases cls ON cCurs.id_Clase = cls.id_Clase INNER JOIN cursos cur ON cCurs.id_Curso = cur.id_Curso INNER JOIN seccion sec On cur.id_Curso = sec.id_Curso AND sec.id_Seccion = dm.id_Seccion WHERE dm.estado = 1 AND cur.nombreCurso = '" + txtCurso.Text.Trim() + "' AND sec.nombreSeccion = '" + txtSeccion.Text + "' AND estu.identidadEstudiante = '" + txtIdentidadAE.Text + "' AND cls.nombreClase = '" + cmbClasesCS.Text + "'"))
                {
                    mktNotaA.ResetText();
                }
                if (!dbConn.llenarMaskedTextBox(mktNotaB, "SELECT notas.notaB FROM detalleMatricula dm INNER JOIN matricula matr ON dm.id_RegistroMatricula = matr.id_RegistroMatricula INNER JOIN datosEstudiante estu on matr.id_Estudiante = estu.identidadEstudiante INNER JOIN detalleNotas notas ON dm.id_DetalleMatricula = notas.id_DetalleMatricula INNER JOIN clasesCurso cCurs ON notas.id_Clase = cCurs.id_Clase INNER JOIN clases cls ON cCurs.id_Clase = cls.id_Clase INNER JOIN cursos cur ON cCurs.id_Curso = cur.id_Curso INNER JOIN seccion sec On cur.id_Curso = sec.id_Curso AND sec.id_Seccion = dm.id_Seccion WHERE dm.estado = 1 AND cur.nombreCurso = '" + txtCurso.Text.Trim() + "' AND sec.nombreSeccion = '" + txtSeccion.Text + "' AND estu.identidadEstudiante = '" + txtIdentidadAE.Text + "' AND cls.nombreClase = '" + cmbClasesCS.Text + "'"))
                {
                    mktNotaB.ResetText();
                }
                if (!dbConn.llenarMaskedTextBox(mktNotaC, "SELECT notas.notaC FROM detalleMatricula dm INNER JOIN matricula matr ON dm.id_RegistroMatricula = matr.id_RegistroMatricula INNER JOIN datosEstudiante estu on matr.id_Estudiante = estu.identidadEstudiante INNER JOIN detalleNotas notas ON dm.id_DetalleMatricula = notas.id_DetalleMatricula INNER JOIN clasesCurso cCurs ON notas.id_Clase = cCurs.id_Clase INNER JOIN clases cls ON cCurs.id_Clase = cls.id_Clase INNER JOIN cursos cur ON cCurs.id_Curso = cur.id_Curso INNER JOIN seccion sec On cur.id_Curso = sec.id_Curso AND sec.id_Seccion = dm.id_Seccion WHERE dm.estado = 1 AND cur.nombreCurso = '" + txtCurso.Text.Trim() + "' AND sec.nombreSeccion = '" + txtSeccion.Text + "' AND estu.identidadEstudiante = '" + txtIdentidadAE.Text + "' AND cls.nombreClase = '" + cmbClasesCS.Text + "'"))
                {
                    mktNotaC.ResetText();
                }
                if (!dbConn.llenarMaskedTextBox(mktNotaD, "SELECT notas.notaD FROM detalleMatricula dm INNER JOIN matricula matr ON dm.id_RegistroMatricula = matr.id_RegistroMatricula INNER JOIN datosEstudiante estu on matr.id_Estudiante = estu.identidadEstudiante INNER JOIN detalleNotas notas ON dm.id_DetalleMatricula = notas.id_DetalleMatricula INNER JOIN clasesCurso cCurs ON notas.id_Clase = cCurs.id_Clase INNER JOIN clases cls ON cCurs.id_Clase = cls.id_Clase INNER JOIN cursos cur ON cCurs.id_Curso = cur.id_Curso INNER JOIN seccion sec On cur.id_Curso = sec.id_Curso AND sec.id_Seccion = dm.id_Seccion WHERE dm.estado = 1 AND cur.nombreCurso = '" + txtCurso.Text.Trim() + "' AND sec.nombreSeccion = '" + txtSeccion.Text + "' AND estu.identidadEstudiante = '" + txtIdentidadAE.Text + "' AND cls.nombreClase = '" + cmbClasesCS.Text + "'"))
                {
                    mktNotaD.ResetText();
                }
                if (!dbConn.llenarMaskedTextBox(mktNotaE, "SELECT notas.notaE FROM detalleMatricula dm INNER JOIN matricula matr ON dm.id_RegistroMatricula = matr.id_RegistroMatricula INNER JOIN datosEstudiante estu on matr.id_Estudiante = estu.identidadEstudiante INNER JOIN detalleNotas notas ON dm.id_DetalleMatricula = notas.id_DetalleMatricula INNER JOIN clasesCurso cCurs ON notas.id_Clase = cCurs.id_Clase INNER JOIN clases cls ON cCurs.id_Clase = cls.id_Clase INNER JOIN cursos cur ON cCurs.id_Curso = cur.id_Curso INNER JOIN seccion sec On cur.id_Curso = sec.id_Curso AND sec.id_Seccion = dm.id_Seccion WHERE dm.estado = 1 AND cur.nombreCurso = '" + txtCurso.Text.Trim() + "' AND sec.nombreSeccion = '" + txtSeccion.Text + "' AND estu.identidadEstudiante = '" + txtIdentidadAE.Text + "' AND cls.nombreClase = '" + cmbClasesCS.Text + "'"))
                {
                    mktNotaE.ResetText();
                }

            }
        }

        private void formatoNota(MaskedTextBox msk)
        {
            if (msk.Text == "A" || msk.Text == "B" || msk.Text == "C" || msk.Text == "D" || msk.Text == "a" || msk.Text == "b" || msk.Text == "c" || msk.Text == "d")
            {
                msk.Text = msk.Text.ToUpper();
            }
            else
            {
                msk.ResetText();
            }
            
        }

        private void txtIdentidadAE_TextChanged(object sender, EventArgs e)
        {

        }

        private void abRegresar2_Click(object sender, EventArgs e)
        {
            gpxCuadroNotas.Visible = false;
            Limpiar();
            gpxSeleccionAlumno.Visible = true;
        }

        private void abRegresar1_Click(object sender, EventArgs e)
        {
            nota1 = 0;
            nota2 = 0;
            nota3 = 0;
            nota4 = 0;
            notaFinal = 0;
            notaA = "";
            notaB = "";
            notaC = "";
            notaD = "";
            notaE = "";
            cmbClasesCS.Items.Clear();

            gpxIngreso_Notas.Visible = false;
            gpxSeleccionAlumno.Visible = true;
            txtIdentidadAE.Visible = true;
            txtNombreAE.Visible = true;
            txtIdentidadAE.Clear();
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
                dbConn.llenarDGV(dgvCuadroNotas, "SELECT estu.identidadEstudiante as 'Identidad', CONCAT(estu.primerNombre,' ', estu.segundoNombre,' ', estu.primerApellido,' ', estu.segundoApellido)as 'Nombre Estudiante', cls.nombreClase as 'Clase', cur.nombreCurso as 'Curso', sec.nombreSeccion as 'Sección', notas.nota1erParcial as 'Primer Parcial', notas.nota2doParcial as 'Segundo Parcial', notas.nota3erParcial as 'Tercer Parcial', notas.nota4toParcial as 'Cuarto Parcial', notas.notaFinal as 'Promedio' FROM detalleMatricula dm INNER JOIN matricula matr ON dm.id_RegistroMatricula = matr.id_RegistroMatricula INNER JOIN datosEstudiante estu on matr.id_Estudiante = estu.identidadEstudiante INNER JOIN detalleNotas notas ON dm.id_DetalleMatricula = notas.id_DetalleMatricula INNER JOIN clasesCurso cCurs ON notas.id_Clase = cCurs.id_Clase INNER JOIN clases cls ON cCurs.id_Clase = cls.id_Clase INNER JOIN cursos cur ON cCurs.id_Curso = cur.id_Curso INNER JOIN seccion sec On cur.id_Curso = sec.id_Curso AND sec.id_Seccion = dm.id_Seccion WHERE dm.estado = 1 AND cur.nombreCurso = '"+Herencia_de_Variables.CursoG+"' AND sec.nombreSeccion = '"+Herencia_de_Variables.SeccionG+"'");
            }
            else if(formaEvaluacion == 2)
            {
                dbConn.llenarDGV(dgvCuadroNotas, "SELECT estu.identidadEstudiante as 'Identidad', CONCAT(estu.primerNombre,' ', estu.segundoNombre,' ', estu.primerApellido,' ', estu.segundoApellido)as 'Nombre Estudiante', cls.nombreClase as 'Clase', cur.nombreCurso as 'Curso', sec.nombreSeccion as 'Sección', notas.notaA as 'Primer Parcial', notas.notaB as 'Segundo Parcial', notas.notaC as 'Tercer Parcial', notas.notaD as 'Cuarto Parcial', notas.notaE as 'Promedio' FROM detalleMatricula dm INNER JOIN matricula matr ON dm.id_RegistroMatricula = matr.id_RegistroMatricula INNER JOIN datosEstudiante estu on matr.id_Estudiante = estu.identidadEstudiante INNER JOIN detalleNotas notas ON dm.id_DetalleMatricula = notas.id_DetalleMatricula INNER JOIN clasesCurso cCurs ON notas.id_Clase = cCurs.id_Clase INNER JOIN clases cls ON cCurs.id_Clase = cls.id_Clase INNER JOIN cursos cur ON cCurs.id_Curso = cur.id_Curso INNER JOIN seccion sec On cur.id_Curso = sec.id_Curso AND sec.id_Seccion = dm.id_Seccion WHERE dm.estado = 1 AND cur.nombreCurso = '" + Herencia_de_Variables.CursoG + "' AND sec.nombreSeccion = '" + Herencia_de_Variables.SeccionG + "'");
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
                dbConn.llenarDGV(dgvCuadroNotas, "SELECT estu.identidadEstudiante as 'Identidad', CONCAT(estu.primerNombre,' ', estu.segundoNombre,' ', estu.primerApellido,' ', estu.segundoApellido)as 'Nombre Estudiante', cls.nombreClase as 'Clase', cur.nombreCurso as 'Curso', sec.nombreSeccion as 'Sección', notas.nota1erParcial as 'Nota Primer Parcial', notas.nota2doParcial as 'Segundo Parcial', notas.nota3erParcial as 'Tercer Parcial', notas.nota4toParcial as 'Cuarto Parcial', notas.notaFinal as 'Promedio' FROM detalleMatricula dm INNER JOIN matricula matr ON dm.id_RegistroMatricula = matr.id_RegistroMatricula INNER JOIN datosEstudiante estu on matr.id_Estudiante = estu.identidadEstudiante INNER JOIN detalleNotas notas ON dm.id_DetalleMatricula = notas.id_DetalleMatricula INNER JOIN clasesCurso cCurs ON notas.id_Clase = cCurs.id_Clase INNER JOIN clases cls ON cCurs.id_Clase = cls.id_Clase INNER JOIN cursos cur ON cCurs.id_Curso = cur.id_Curso INNER JOIN seccion sec On cur.id_Curso = sec.id_Curso AND sec.id_Seccion = dm.id_Seccion " +
                    "WHERE dm.estado = 1 AND cur.nombreCurso = '"+Herencia_de_Variables.CursoG+"' AND sec.nombreSeccion = '"+Herencia_de_Variables.SeccionG+"' AND (estu.identidadEstudiante like '" + text + "%' OR estu.primerNombre like '" + text + "%' OR cls.nombreClase like '"+text+"%')");
            }
            else if (formaEvaluacion == 2)
            {
                dbConn.llenarDGV(dgvCuadroNotas, "SELECT estu.identidadEstudiante as 'Identidad', CONCAT(estu.primerNombre,' ', estu.segundoNombre,' ', estu.primerApellido,' ', estu.segundoApellido)as 'Nombre Estudiante', cls.nombreClase as 'Clase', cur.nombreCurso as 'Curso', sec.nombreSeccion as 'Sección', notas.notaA as 'Primer Parcial', notas.notaB as 'Segundo Parcial', notas.notaC as 'Tercer Parcial', notas.notaD as 'Cuarto Parcial', notas.notaD as 'Promedio' FROM detalleMatricula dm INNER JOIN matricula matr ON dm.id_RegistroMatricula = matr.id_RegistroMatricula INNER JOIN datosEstudiante estu on matr.id_Estudiante = estu.identidadEstudiante INNER JOIN detalleNotas notas ON dm.id_DetalleMatricula = notas.id_DetalleMatricula INNER JOIN clasesCurso cCurs ON notas.id_Clase = cCurs.id_Clase INNER JOIN clases cls ON cCurs.id_Clase = cls.id_Clase INNER JOIN cursos cur ON cCurs.id_Curso = cur.id_Curso INNER JOIN seccion sec On cur.id_Curso = sec.id_Curso AND sec.id_Seccion = dm.id_Seccion " +
                    "WHERE dm.estado = 1 AND cur.nombreCurso = '" + Herencia_de_Variables.CursoG + "' AND sec.nombreSeccion = '" + Herencia_de_Variables.SeccionG + "' AND (estu.identidadEstudiante like '" + text + "%' OR estu.primerNombre like '" + text + "%' OR cls.nombreClase like '" + text + "%')");
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
                    message.lblError.Location = new Point(135, 68);
                    message.lblError.Text = "SELECCIONE UNA CELDA\nPARA CONTINUAR";
                    message.lblError.TextAlign = ContentAlignment.MiddleCenter;
                    message.ShowDialog();
                }
                else
                {
                    gpxCuadroNotas.Visible = false;
                    gpxIngreso_Notas.Visible = true;
                    txtIdentidadAE.Clear();
                    txtIdentidadAE.Text = IDcn;
                    txtNombreAE.Text = nombreCN;
                }
            }
            else if(formaEvaluacion == 2)
            {
                if (ID == null || NameA == null)
                {
                    message.lblError.Location = new Point(135, 68);
                    message.lblError.Text = "SELECCIONE UNA CELDA\nPARA CONTINUAR";
                    message.lblError.TextAlign = ContentAlignment.MiddleCenter;
                    message.ShowDialog();
                }
                else
                {
                    gpxCuadroNotas.Visible = false;
                    gpxIngreso_Notas.Visible = true;
                    txtIdentidadAE.Clear();
                    txtIdentidadAE.Text = ID;
                    txtNombreAE.Text = NameA;
                }
            }

        }

    }
}
