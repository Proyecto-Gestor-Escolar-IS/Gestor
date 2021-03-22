using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Modulos_de_Registro_y_Vista_de_Notas
{
    public partial class Seleccion_de_Curso : Form
    {
        databaseConnection dbConn = new databaseConnection();
        public string cursoElegido;
        public string seccionElegida;

        public Seleccion_de_Curso()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Seleccion_de_Curso_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cmbCursos.Items.Count > 0)
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
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("El curso es: " + cursoElegido);
            //MessageBox.Show("La Seccion es: " + seccionElegida);

            Registro_y_Vista_de_Notas.Herencia_de_Variables.CursoG = cmbCursos.Text;
            Registro_y_Vista_de_Notas.Herencia_de_Variables.SeccionG = cmbSeccion.Text;

            this.Hide();
            Registro_y_Vista_de_Notas.Alumnos_CursoSeccion form = new  Registro_y_Vista_de_Notas.Alumnos_CursoSeccion();
            form.Show(this);

        }




    }
}
