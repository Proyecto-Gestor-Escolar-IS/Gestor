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
        IMessageBoxError messageError = new IMessageBoxError();
        IMessageBoxWarning messageWarning = new IMessageBoxWarning();

        int ultimaMatricula;
        string identidadEncargado;
        int mesesDePago;
        int idMatriculaEstudiante;
        string identidadReingreso = "";
        
        private void IMatriculaIndividual_Load(object sender, EventArgs e)
        {
            dbConn.llenarComboBoxValorInicial(cmbCurso, "SELECT nombreCurso FROM cursos");
            dbConn.llenarComboBoxValorInicial(cmbCursoR, "SELECT nombreCurso FROM cursos");
            cmbCurso.SelectedIndex = 0;
            cmbCursoR.SelectedIndex = 0;
            cmbSeccion.SelectedIndex = 0;
            cmbModoPago.SelectedIndex = 0;
            dbConn.llenarDGV(dgvEstudiantes, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero', estado as 'Estado'  FROM datosEstudiante");

            recuperarMatricula();

            grpMatriculaPrimerIngreso.Visible = false;
            grpReingreso.Visible = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void recuperarMatricula()
        {
            ultimaMatricula = dbConn.obtenerVariableEntera("SELECT max(id_RegistroMatricula) FROM matricula");
            if (ultimaMatricula > 0)
            {
                ultimaMatricula += 1;
                txtNoMatricula.Text = "" + ultimaMatricula;

            }
            else
            {
                ultimaMatricula = 1;
                txtNoMatricula.Text = "" + ultimaMatricula;
            }
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

                if(txtNombreEstudiante.Text != string.Empty)
                {
                    if(txtNombreEncargado.Text != string.Empty)
                    {
                        if(cmbCurso.SelectedIndex != 0)
                        {
                            if(cmbSeccion.SelectedIndex != 0)
                            {
                                if (cmbModoPago.SelectedIndex == 0)
                                {
                                    mesesDePago = 12;
                                }
                                else if (cmbModoPago.SelectedIndex == 1)
                                {
                                    mesesDePago = 10;
                                }

                                if (dbConn.PARegistrarMatricula("1010202000034", identidadEncargado, txtIdentidadEstudiante.Text, cmbCurso.SelectedIndex, cmbSeccion.SelectedIndex, float.Parse(txtTotalPagar.Text), 1, mesesDePago, 1, 1))
                                {
                                    message.lblCheck.Text = "MATRICULA REGISTRADA";
                                    message.ShowDialog();
                                    recuperarMatricula();
                                    limpiarPantalla();
                                }
                                else
                                {
                                    messageError.lblError.Text = "ERROR INESPERADO";
                                    messageError.ShowDialog();
                                }
                            }
                            else
                            {
                                messageWarning.lblError.Text = "SELECCIONE UNA SECCION";
                                messageWarning.ShowDialog();
                            }
                        }
                        else
                        {
                            messageWarning.lblError.Text = "SELECCIONE UN CURSO";
                            messageWarning.ShowDialog();
                        }
                    }
                    else
                    {
                        messageWarning.lblError.Text = "INGRESE UN ID DE ENCARGADO";
                        messageWarning.ShowDialog();
                    }
                }
                else
                {
                    messageWarning.lblError.Text = "INGRESE UN ID DE ESTUDIANTE";
                    messageWarning.ShowDialog();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSeccion.Items.Clear();
            
            dbConn.llenarComboBoxValorInicial(cmbSeccion, "SELECT nombreSeccion FROM seccion INNER JOIN cursos ON seccion.id_Curso = cursos.id_Curso WHERE cursos.nombreCurso = '" + cmbCurso.SelectedItem + "'");
            cmbSeccion.SelectedIndex = 0;
          
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
                    dbConn.llenarComboBoxValorInicial(cmbIdentidadEncargado, "SELECT id_encargadoAlumno FROM detalleEncargado WHERE id_Estudiante = '" + txtIdentidadEstudiante.Text + "'");
                    cmbIdentidadEncargado.SelectedIndex = 0;
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
                if (txtNombreEstudianteR.Text != string.Empty)
                {
                    if (txtNombreEncargadoR.Text != string.Empty)
                    {
                        if (cmbCursoR.SelectedIndex != 0)
                        {
                            if (cmbSeccionR.SelectedIndex != 0)
                            {
                                   if (cmbModoPagoR.SelectedIndex == 0)
                                   {
                                        mesesDePago = 12;
                                   }
                                   else if (cmbModoPagoR.SelectedIndex == 1)
                                   {
                                        mesesDePago = 10;
                                   }
                                   if (dbConn.PARegistrarMatricula("1010202000034", txtIdentidadEncargadoR.Text, txtIdentidadEstudianteR.Text, cmbCursoR.SelectedIndex, cmbSeccionR.SelectedIndex, float.Parse(txtTotalR.Text), 1, mesesDePago, 1, 2))
                                   {
                                   message.lblCheck.Text = "MATRICULA REGISTRADA";
                                   message.ShowDialog();
                                   limpiarPantalla();
                                   }
                                   else
                                   {
                                       messageError.lblError.Text = "ERROR INESPERADO";
                                       messageError.ShowDialog();
                                   }
                            }
                            else
                            {
                                messageWarning.lblError.Text = "SELECCIONE UNA SECCION";
                                messageWarning.ShowDialog();
                            }
                        }
                        else
                        {
                            messageWarning.lblError.Text = "SELECCIONE UN CURSO";
                            messageWarning.ShowDialog();
                        }
                    }
                    else
                    {
                        messageWarning.lblError.Text = "INGRESE UN ID DE ENCARGADO";
                        messageWarning.ShowDialog();
                    }
                }
                else
                {
                    messageWarning.lblError.Text = "INGRESE UN ID DE ESTUDIANTE";
                    messageWarning.ShowDialog();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarPantalla();

        }

        private void limpiarPantalla()
        {
            
            txtNombreEncargado.Clear();
            txtIdentidadEstudiante.Clear();
            txtNombreEstudiante.Clear();
            cmbCurso.SelectedIndex = 0;
            cmbSeccion.SelectedIndex = 0;
            cmbModoPago.SelectedIndex = 0;
            cmbIdentidadEncargado.Items.Clear();
            txtDescuento.Text = "0.00";
            txtTotalPagar.Clear();

            txtNombreEncargadoR.Clear();
            txtIdentidadEstudianteR.Clear();
            txtNombreEstudianteR.Clear();
            cmbCursoR.SelectedIndex = 0;
            cmbSeccionR.SelectedIndex = 0;
            cmbModoPagoR.SelectedIndex = 0;
            txtIdentidadEncargadoR.Clear();
            txtDescuentoR.Text = "0.00";
            txtTotalR.Clear();
        }

        private void grpMatriculaPrimerIngreso_Enter(object sender, EventArgs e)
        {

        }

        private void cmbModoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbIdentidadEncargado_SelectedIndexChanged(object sender, EventArgs e)
        {
            identidadEncargado = cmbIdentidadEncargado.SelectedItem.ToString();
            if(cmbIdentidadEncargado.SelectedIndex > 0)
            {
                dbConn.llenarTextBox(txtNombreEncargado, "SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM datosEncargado WHERE identidadEncargado = '" + identidadEncargado + "'");

            }
            else
            {
                txtNombreEncargado.Clear();
            }

        }

        private void txtIdentidadEstudianteR_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label41_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdentidadEstudianteR_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpReingreso_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombreEncargadoR_TextChanged(object sender, EventArgs e)
        {

        }

        private void altoButton12_Click(object sender, EventArgs e)
        {
            grpReingreso.Visible = false;
            label1.Visible = true;
            btnPrimerIngreso.Visible = true;
            btnReingreso.Visible = true;
            identidadReingreso = "";
        }

        private void txtBusquedaIdentidad_TextChanged(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvEstudiantes, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero', estado as 'Estado' FROM datosEstudiante WHERE identidadEstudiante LIKE '" + txtBusquedaIdentidad.Text + "%'");
        }

        private void txtBusquedaNombre_TextChanged(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvEstudiantes, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero', estado as 'Estado' FROM datosEstudiante WHERE CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) LIKE '" + txtBusquedaNombre.Text + "%'");
        }

        private void btnSiguienteDGVAct_Click(object sender, EventArgs e)
        {
            if (identidadReingreso != "")
            {
               
                txtIdentidadEstudianteR.Text = identidadReingreso;
                grpListaEstudiantes.Visible = false;
            }
            else
            {
                messageWarning.lblError.Text = "SELECCIONE UN ESTUDIANTE";
                messageWarning.ShowDialog();
            }
        }

        private void txtRegresarR_Click(object sender, EventArgs e)
        {
            grpListaEstudiantes.Visible = true;
        }

        private void grpListaEstudiantes_Enter(object sender, EventArgs e)
        {
        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            identidadReingreso = dgvEstudiantes.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void txtIdentidadEstudianteR_TextChanged_1(object sender, EventArgs e)
        {
            string estudiante; 
                estudiante = dbConn.obtenerVariableString("SELECT primerNombre FROM datosEstudiante WHERE identidadEstudiante = '" + txtIdentidadEstudianteR.Text + "'");
                if (!string.IsNullOrEmpty(estudiante))
                {
                    dbConn.llenarTextBox(txtNombreEstudianteR, "SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM datosEstudiante WHERE identidadEstudiante = '" + txtIdentidadEstudianteR.Text + "'");

                    idMatriculaEstudiante = dbConn.obtenerVariableEntera("SELECT id_RegistroMatricula FROM matricula WHERE id_Estudiante = '" + txtIdentidadEstudianteR.Text + "'");
                    txtNoMatriculaR.Text = "" + idMatriculaEstudiante;
                    dbConn.llenarTextBox(txtIdentidadEncargadoR, "SELECT id_encargadoAlumno FROM matricula WHERE id_RegistroMatricula = '" + idMatriculaEstudiante + "'");
                    dbConn.llenarTextBox(txtNombreEncargadoR, "SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM datosEncargado WHERE identidadEncargado = '" + txtIdentidadEncargadoR.Text + "'");
                }
            
        }

        private void cmbCursoR_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSeccionR.Items.Clear();
            dbConn.llenarComboBoxValorInicial(cmbSeccionR, "SELECT nombreSeccion FROM seccion INNER JOIN cursos ON seccion.id_Curso = cursos.id_Curso WHERE cursos.nombreCurso = '" + cmbCursoR.SelectedItem + "'");
            cmbSeccionR.SelectedIndex = 0;

           
            dbConn.llenarTextBox(txtTotalR, "SELECT precioCompleto FROM cursos WHERE nombreCurso = '" + cmbCursoR.SelectedItem + "'");
        }

        private void txtLimpiarR_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }

        private void txtRegistarR_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (txtNombreEstudianteR.Text != string.Empty)
                {
                    if (txtNombreEncargadoR.Text != string.Empty)
                    {
                        if (cmbCursoR.SelectedIndex != 0)
                        {
                            if (cmbSeccionR.SelectedIndex != 0)
                            {
                                if (cmbModoPagoR.SelectedIndex == 0)
                                {
                                    mesesDePago = 12;
                                }
                                else if (cmbModoPagoR.SelectedIndex == 1)
                                {
                                    mesesDePago = 10;
                                }
                                if (dbConn.PARegistrarMatricula("1010202000034", txtIdentidadEncargadoR.Text, txtIdentidadEstudianteR.Text, cmbCursoR.SelectedIndex, cmbSeccionR.SelectedIndex, float.Parse(txtTotalR.Text), 1, mesesDePago, 1, 2))
                                {
                                    message.lblCheck.Text = "MATRICULA REGISTRADA";
                                    message.ShowDialog();
                                    limpiarPantalla();
                                }
                                else
                                {
                                    messageError.lblError.Text = "ERROR INESPERADO";
                                    messageError.ShowDialog();
                                }
                            }
                            else
                            {
                                messageWarning.lblError.Text = "SELECCIONE UNA SECCION";
                                messageWarning.ShowDialog();
                            }
                        }
                        else
                        {
                            messageWarning.lblError.Text = "SELECCIONE UN CURSO";
                            messageWarning.ShowDialog();
                        }
                    }
                    else
                    {
                        messageWarning.lblError.Text = "INGRESE UN ID DE ENCARGADO";
                        messageWarning.ShowDialog();
                    }
                }
                else
                {
                    messageWarning.lblError.Text = "INGRESE UN ID DE ESTUDIANTE";
                    messageWarning.ShowDialog();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
