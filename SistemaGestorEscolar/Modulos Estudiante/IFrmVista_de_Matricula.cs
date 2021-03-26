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

namespace SistemaGestorEscolar.Modulos_Estudiante
{
    public partial class IFrmVista_de_Matricula : Form
    {

        databaseConnection dbConn = new databaseConnection();
        IMessageBoxCheck messageOk = new IMessageBoxCheck();
        IMessageBoxError message = new IMessageBoxError();


        public IFrmVista_de_Matricula()
        {
            InitializeComponent();
        }

        public string CursoElegido;
        public string SeccionElegida;


        private void IFrmVista_de_Matricula_Load(object sender, EventArgs e)
        {
            gpVistaM.Visible = false;

            ClsCambioTema.cambiarTemaBoton(gpSeleccionCS);

        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbCurso.Items.Count > 0)
            {
                switch (cmbCurso.SelectedItem.ToString())
                {
                    case "Nursery":
                        cmbSeccion.Items.Clear();
                        dbConn.llenarComboBox(cmbSeccion, "SELECT dbo.seccion.nombreSeccion FROM     dbo.cursos INNER JOIN dbo.seccion ON " +
                            "dbo.cursos.id_Curso = dbo.seccion.id_Curso Where dbo.cursos.nombreCurso = '" + cmbCurso.SelectedItem + "' ");
                        break;

                    case "Pre-Kinder":
                        cmbSeccion.Items.Clear();
                        dbConn.llenarComboBox(cmbSeccion, "SELECT dbo.seccion.nombreSeccion FROM     dbo.cursos INNER JOIN dbo.seccion ON " +
                            "dbo.cursos.id_Curso = dbo.seccion.id_Curso Where dbo.cursos.nombreCurso = '" + cmbCurso.SelectedItem + "' ");
                        break;

                    case "Kinder":
                        cmbSeccion.Items.Clear();
                        dbConn.llenarComboBox(cmbSeccion, "SELECT dbo.seccion.nombreSeccion FROM     dbo.cursos INNER JOIN dbo.seccion ON " +
                            "dbo.cursos.id_Curso = dbo.seccion.id_Curso Where dbo.cursos.nombreCurso = '" + cmbCurso.SelectedItem + "' ");
                        break;

                    case "Primer Grado":
                        cmbSeccion.Items.Clear();
                        dbConn.llenarComboBox(cmbSeccion, "SELECT dbo.seccion.nombreSeccion FROM     dbo.cursos INNER JOIN dbo.seccion ON " +
                            "dbo.cursos.id_Curso = dbo.seccion.id_Curso Where dbo.cursos.nombreCurso = '" + cmbCurso.SelectedItem + "' ");
                        break;
                }
            }


            CursoElegido = cmbCurso.Text;

        }

        private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {

            SeccionElegida = cmbSeccion.Text;

        }

        private void abContinuar_Click_1(object sender, EventArgs e)
        {

            if (cmbCurso.SelectedIndex == -1 && cmbSeccion.SelectedIndex == -1)
            {
                message.lblError.Text = "Seleccione un Curso y Sección";
                message.ShowDialog();

            }
            else if (cmbSeccion.Text != SeccionElegida)
            {
                message.lblError.Text = "Seleccione una Sección";
                message.ShowDialog();
            }
            else
            {
                gpSeleccionCS.Visible = false;
                gpVistaM.Visible = true;
            }

        }

        //------------------gpVistaM-----------------------
    
        private void gpVistaM_VisibleChanged(object sender, EventArgs e)
        {

            dbConn.llenarDGV(dgvVistaMatricula, "SELECT dbo.datosEstudiante.identidadEstudiante as 'Identidad del Estudiante', CONCAT(dbo.datosEstudiante.primerNombre,' ', dbo.datosEstudiante.segundoNombre,' ', dbo.datosEstudiante.primerApellido,' ', dbo.datosEstudiante.segundoApellido) as 'Nobre del Estudiante'," +
                         " dbo.cursos.nombreCurso as Curso, dbo.seccion.nombreSeccion as Sección FROM     dbo.datosEstudiante INNER JOIN" +
                         " dbo.matricula ON dbo.datosEstudiante.identidadEstudiante = dbo.matricula.id_Estudiante INNER JOIN " +
                         "dbo.detalleMatricula ON dbo.matricula.id_RegistroMatricula = dbo.detalleMatricula.id_RegistroMatricula INNER JOIN " +
                         "dbo.cursos ON dbo.detalleMatricula.id_Curso = dbo.cursos.id_Curso INNER JOIN dbo.seccion ON" +
                         " dbo.detalleMatricula.id_Seccion = dbo.seccion.id_Seccion AND dbo.cursos.id_Curso = dbo.seccion.id_Curso Where" +
                         " dbo.cursos.nombreCurso = '" + CursoElegido + "' and dbo.seccion.nombreSeccion = '" + SeccionElegida + "' ");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            gpVistaM.Visible = false;
            gpSeleccionCS.Visible = true;
            cmbCurso.SelectedItem = 0;
            cmbSeccion.ResetText();


        }


    }
}
