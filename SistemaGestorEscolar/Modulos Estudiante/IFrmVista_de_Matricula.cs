using SistemaGestorEscolar.Reportes;
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
        IMessageBoxError messageError = new IMessageBoxError();

        public IFrmVista_de_Matricula()
        {
            InitializeComponent();
        }

        public string CursoElegido;
        public string SeccionElegida;

        private void IFrmVista_de_Matricula_Load(object sender, EventArgs e)
        {
            gpVistaM.Visible = false;

            btnAtras.Visible = false;
            btnImprimir.Visible = false;

     
            ClsCambioTema.cambiarTemaBoton(gpSeleccionCS);

            if(Properties.Settings.Default.isModoOscuro == true)
            {
                gpSeleccionCS.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
            else
            {
                gpSeleccionCS.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }

            dbConn.llenarComboBoxValorInicial(cmbCurso, "Select nombreCurso from [dbo].[cursos]");
            cmbCurso.SelectedIndex = 0;
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

            clsVariablesGlobales.idCursoImprimir = dbConn.obtenerVariableEntera("SELECT id_Curso FROM cursos WHERE nombreCurso = '" + cmbCurso.SelectedItem.ToString() + "'");

            if (cmbCurso.Items.Count > 0)
            {
                dbConn.llenarDGV(dgvSecciones, "SELECT A.id_Seccion as 'ID', FORMAT(A.fechaCreacion, 'dd/MM/yyyy') as 'Fecha de Registro', A.nombreSeccion as 'Seccion', CONCAT(B.primerNombre, ' ',B.segundoNombre, ' ',B.primerApellido, ' ', B.segundoApellido) as 'Docente', descripcionEstado as 'Estado' FROM seccion A INNER JOIN datosEmpleados B ON A.id_Docente = B.identidadPersona INNER JOIN estados C ON C.id_Estado = A.estado WHERE A.id_Curso = " + clsVariablesGlobales.idCursoImprimir);
            }
        }

        private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {

   

        }

        private void abContinuar_Click_1(object sender, EventArgs e)
        {

            if(clsVariablesGlobales.idSeccionImprimir != 0 && clsVariablesGlobales.idCursoImprimir != 0)
            {
                gpSeleccionCS.Visible = false;
                gpVistaM.Visible = true;
                btnAtras.Visible = true;
                btnImprimir.Visible = true;
                cargarMatricula();
            }
            else
            {
                messageError.lblError.Text = "SELECCIONE UN CURSO Y SECCION";
                messageError.ShowDialog();
            }



        }

        //------------------gpVistaM-----------------------
    
        private void gpVistaM_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void cargarMatricula()
        {
            dbConn.llenarDGV(dgvVistaMatricula, "SELECT A.identidadEstudiante AS 'Identidad', CONCAT(A.primerNombre, ' ', A.segundoNombre, ' ', A.primerApellido, ' ', A.segundoApellido) as 'Nombre del Estudiante' FROM[dbo].[datosEstudiante] A INNER JOIN[dbo].[matricula] B ON A.identidadEstudiante = B.id_Estudiante INNER JOIN[dbo].[detalleMatricula] C ON C.id_RegistroMatricula = B.id_RegistroMatricula WHERE C.id_Curso = " + clsVariablesGlobales.idCursoImprimir + " AND C.id_Seccion = "+ clsVariablesGlobales.idSeccionImprimir);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gpVistaM.Visible = false;
            gpSeleccionCS.Visible = true;
            cmbCurso.SelectedItem = 0;
        }

        private void gpSeleccionCS_Enter(object sender, EventArgs e)
        {

        }

        private void gpVistaM_Enter(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            btnAtras.Visible = false;
            gpVistaM.Visible = false;
            gpSeleccionCS.Visible = true;
            btnImprimir.Visible = false;
            clsVariablesGlobales.idSeccionImprimir = 0;
            clsVariablesGlobales.idCursoImprimir = 0;
            cmbCurso.SelectedIndex = 0;
        }

        private void dgvSecciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                clsVariablesGlobales.idSeccionImprimir = int.Parse(dgvSecciones.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
     
            boletaMatricula matricula = new boletaMatricula();
            matricula.Show();

        }

        private void btnGuardarPDF_Click(object sender, EventArgs e)
        {
   
        }
    }
}
