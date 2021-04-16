using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace SistemaGestorEscolar.Reportes
{
    public partial class reporteBoleta : DevExpress.XtraReports.UI.XtraReport
    {

        databaseConnection dbConn = new databaseConnection();

        public reporteBoleta()
        {
            InitializeComponent();
            SECCION.Visible = false;
            CURSO.Visible = false;

            SECCION.Value = clsVariablesGlobales.idSeccionImprimir;
            CURSO.Value = clsVariablesGlobales.idCursoImprimir;

            etiquetaCurso.Text = "Curso: " + dbConn.obtenerVariableString("SELECT[nombreCurso] FROM cursos WHERE id_Curso = " + clsVariablesGlobales.idCursoImprimir);
            etiquetaSeccion.Text = "Seccion: " + dbConn.obtenerVariableString("SELECT [nombreSeccion] FROM seccion WHERE [id_Seccion] = " + clsVariablesGlobales.idCursoImprimir);

        }

    }
}
