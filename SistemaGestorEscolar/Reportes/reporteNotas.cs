using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace SistemaGestorEscolar.Reportes
{
    public partial class reporteNotas : DevExpress.XtraReports.UI.XtraReport
    {
        databaseConnection dbConn = new databaseConnection();
        public reporteNotas()
        {
            InitializeComponent();
            IDCURSO.Visible = false;
            IDSECCION.Visible = false;
            FORMAEVALUACION.Visible = false;
            IDCLASE.Visible = false;

            IDCURSO.Value = clsVariablesGlobales.idCursoNotas ;
            IDSECCION.Value = clsVariablesGlobales.idSeccionNotas;
            FORMAEVALUACION.Value = clsVariablesGlobales.formaEvaluacion;
            IDCLASE.Value = clsVariablesGlobales.idClaseNotas;
            
            etiquetaCurso.Text = "Curso: " + dbConn.obtenerVariableString("SELECT[nombreCurso] FROM cursos WHERE id_Curso = " + clsVariablesGlobales.idCursoNotas);
            etiquetaSeccion.Text = "Seccion: " + dbConn.obtenerVariableString("SELECT [nombreSeccion] FROM seccion WHERE [id_Seccion] = " + clsVariablesGlobales.idSeccionNotas);
            etiquetaClase.Text = "Clase: " + dbConn.obtenerVariableString("SELECT [nombreClase] FROM clases WHERE id_Clase = " + clsVariablesGlobales.idClaseNotas);
        }

    }
}
