using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Reportes
{
    public partial class selectorClasesCursoSeccion : Form
    {
        databaseConnection dbConn = new databaseConnection();
        IMessageBoxError messageError = new IMessageBoxError();
        public selectorClasesCursoSeccion()
        {
            InitializeComponent();
        }

        private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSeccion.SelectedIndex != 0)
            {

                clsVariablesGlobales.idSeccionNotas = dbConn.obtenerVariableEntera("SELECT [id_Seccion] from seccion WHERE [nombreSeccion] = '" + cmbSeccion.SelectedItem.ToString() + "' AND id_Curso = " + clsVariablesGlobales.idCursoNotas);
    
            }
            else {
                clsVariablesGlobales.idSeccionNotas = 0;
            }
        }

        private void selectorClasesCursoSeccion_Load(object sender, EventArgs e)
        {
            dbConn.llenarComboBoxValorInicial(cmbCursos, "SELECT [nombreCurso] FROM cursos WHERE [estadoCurso] = 1");
            cmbCursos.SelectedIndex = 0;
        }

        private void cmbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClase.Items.Clear();
            cmbSeccion.Items.Clear();

            if (cmbCursos.SelectedIndex != 0)
            {
                clsVariablesGlobales.idCursoNotas = dbConn.obtenerVariableEntera("SELECT id_Curso FROM cursos WHERE [nombreCurso] = '" + cmbCursos.SelectedItem.ToString() +"'");
                clsVariablesGlobales.formaEvaluacion = dbConn.obtenerVariableEntera("SELECT [tipoCalificacion] FROM cursos WHERE [nombreCurso] = '" + cmbCursos.SelectedItem.ToString() + "'");


                dbConn.llenarComboBoxValorInicial(cmbSeccion, "SELECT [nombreSeccion] FROM seccion INNER JOIN cursos ON seccion.id_Curso = cursos.id_Curso WHERE seccion.estado = 1 AND cursos.nombreCurso = '" + cmbCursos.SelectedItem.ToString() + "'");
                dbConn.llenarComboBoxValorInicial(cmbClase, "SELECT [nombreClase] FROM clases INNER JOIN clasesCurso ON clases.id_Clase = clasesCurso.id_Clase WHERE clases.estado = 1 AND clasesCurso.id_Curso = " + clsVariablesGlobales.idCursoNotas);
                cmbSeccion.SelectedIndex = 0;
                cmbClase.SelectedIndex = 0;

            }
            else {
                cmbSeccion.Items.Clear();
                clsVariablesGlobales.idCursoNotas = 0;
                clsVariablesGlobales.idClaseNotas = 0;
                clsVariablesGlobales.idSeccionNotas = 0;
                clsVariablesGlobales.formaEvaluacion = 0;
            }
        }

        private void cmbClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClase.SelectedIndex != 0)
            {
                clsVariablesGlobales.idClaseNotas = dbConn.obtenerVariableEntera("SELECT [id_Clase] FROM clases WHERE nombreClase = '" + cmbClase.SelectedItem.ToString() + "'");
            }
            else {
                clsVariablesGlobales.idClaseNotas = 0;
            }
        }

        private void btnMostrarNotas_Click(object sender, EventArgs e)
        {
            if(clsVariablesGlobales.idCursoNotas != 0 && clsVariablesGlobales.idSeccionNotas != 0 && clsVariablesGlobales.idClaseNotas != 0)
            {
                Reportes.boletaNotas notas = new Reportes.boletaNotas();
                notas.Show();
            }
            else
            {
                messageError.lblError.Text = "SELECCION LOS DATOS NECESARIOS";
                messageError.lblError.TextAlign = ContentAlignment.MiddleCenter;
                messageError.ShowDialog();

            }
        }
    }
}
