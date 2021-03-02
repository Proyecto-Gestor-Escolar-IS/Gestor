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
    public partial class IMatriculaIndividual : Form
    {
        public IMatriculaIndividual()
        {
            InitializeComponent();
        }

        private databaseConnection dbConn = new databaseConnection();
        IMessageBoxCheck message = new IMessageBoxCheck();
        private void IMatriculaIndividual_Load(object sender, EventArgs e)
        {
            dbConn.llenarComboBox(cmbCurso, "SELECT nombreCurso FROM cursos");


            grpMatriculaPrimerIngreso.Visible = false;
            grpReingreso.Visible = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnPrimerIngreso_Click(object sender, EventArgs e)
        {
            grpMatriculaPrimerIngreso.Visible = true;
            label1.Visible = false;
            btnPrimerIngreso.Visible = false;
            btnReingreso.Visible = false;
        }

        private void btnReingreso_Click(object sender, EventArgs e)
        {
            grpReingreso.Visible = true;
            grpListaEstudiantes.Visible = true;
            btnPrimerIngreso.Visible = false;
            label1.Visible = false;
            btnReingreso.Visible = false;
        }

        private void txtNmbreEstudiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dbConn.PARegistrarMatricula("1010202000034", txtIdentidadEncargado.Text, txtIdentidadEstudiante.Text, 1, 1, float.Parse(txtTotalPagar.Text), 1, 12, 1, 1))
                {

                    message.lblCheck.Text = "MATRICULA REGISTRADA";
                    message.ShowDialog();
                    //MessageBox.Show("EXITO");

                }
                else
                {
                    MessageBox.Show("errro");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConn.llenarComboBox(cmbSeccion, "SELECT nombreSeccion FROM seccion INNER JOIN cursos ON seccion.id_Curso = cursos.id_Curso WHERE cursos.nombreCurso = '" + cmbCurso.SelectedItem + "'");
            MessageBox.Show((cmbCurso.SelectedIndex).ToString());
            dbConn.llenarTextBox(txtTotalPagar, "SELECT precioCompleto FROM cursos WHERE nombreCurso = '" + cmbCurso.SelectedItem + "'");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            grpMatriculaPrimerIngreso.Visible = false;
            label1.Visible = true;
            btnPrimerIngreso.Visible = true;
            btnReingreso.Visible = true;
        }

        private void txtIdentidadEncargado_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
 
        }

        private void txtIdentidadEstudiante_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtIdentidadEncargado_TextChanged(object sender, EventArgs e)
        {
            string encargado;
            if (txtIdentidadEncargado.MaskCompleted == true)
            {
                encargado = dbConn.obtenerVariableString("SELECT primerNombre FROM datosEncargado WHERE identidadEncargado = '" + txtIdentidadEncargado.Text +"'");
                if (!string.IsNullOrEmpty(encargado))
                {
                    dbConn.llenarTextBox(txtNombreEncargado, "SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM datosEncargado INNER JOIN detalleEncargado ON datosEncargado.identidadEncargado = detalleEncargado.id_encargadoAlumno WHERE detalleEncargado.id_Estudiante = '" + txtIdentidadEstudiante.Text + "'");

                }
            }
        }

        private void txtIdentidadEstudiante_TextChanged(object sender, EventArgs e)
        {
            string estudiante;
            if (txtIdentidadEstudiante.MaskCompleted == true)
            {
                estudiante = dbConn.obtenerVariableString("SELECT primerNombre FROM datosEstudiante WHERE identidadEstudiante = '" + txtIdentidadEstudiante.Text + "'");
                if (!string.IsNullOrEmpty(estudiante))
                {
                    dbConn.llenarTextBox(txtNombreEstudiante, "SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM datosEstudiante WHERE identidadEstudiante = '" + txtIdentidadEstudiante.Text + "'");

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtRegistarR_Click(object sender, EventArgs e)
        {
            try
            {

                if (dbConn.PARegistrarMatricula("1010202000034", txtIdentidadEncargado.Text, txtIdentidadEstudiante.Text, 1, 1, float.Parse(txtTotalPagar.Text), 1, 12, 1, 2))
                {

                    //message.lblCheck.Text = "MATRICULA REGISTRADA";
                    //message.ShowDialog();
                    MessageBox.Show("EXITO");

                }
                else
                {
                    MessageBox.Show("errro");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
