using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SistemaGestorEscolar.MessageBox_Personalizados;

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
        IMessageBoxYesCancel messageQuestion = new IMessageBoxYesCancel();
        clsUtilidades utilidad = new clsUtilidades();

        int ultimaMatricula;
        int mesesDePago;
        int idMatriculaEstudiante;
        string identidadReingreso = "";
        string identidadActualizacion = "";
        int ultimoDetalleMatricula;
        string identidadEstudiante;
        string identidadEncargado;
        string identidadEncargadoReingreso;
        string identidadEstudianteModDatos;
        string identidadEncargadoModDatos;

        private void IMatriculaIndividual_Load(object sender, EventArgs e)
        {
            dbConn.llenarComboBoxValorInicial(cmbCurso, "SELECT nombreCurso FROM cursos");
            dbConn.llenarComboBoxValorInicial(cmbCursoR, "SELECT nombreCurso FROM cursos");
            cmbCurso.SelectedIndex = 0;
            cmbCursoR.SelectedIndex = 0;
            cmbSeccion.SelectedIndex = 0;
            cmbModoPago.SelectedIndex = 0;
            dbConn.llenarDGV(dgvEstudiantes, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero', estado as 'Estado'  FROM datosEstudiante");
            dbConn.llenarDGV(dgvBusquedaEstado, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero', estado as 'Estado'  FROM datosEstudiante");

            recuperarMatricula();

            grpMatriculaPrimerIngreso.Visible = false;
            grpReingreso.Visible = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void recuperarMatricula()
        {
            if (Convert.IsDBNull(dbConn.obtenerVariableString("SELECT max(id_RegistroMatricula) FROM matricula")))
            {
                ultimaMatricula = 1;
                txtNoMatricula.Text = "" + ultimaMatricula;
            }
            else
            {
                ultimaMatricula += 1;
                txtNoMatricula.Text = "" + ultimaMatricula;
            }
        }

        private void btnPrimerIngreso_Click(object sender, EventArgs e)
        {

            grpRegistroEstudiante.Visible = true;
            grpMatriculaPrimerIngreso.Visible = false;
            label1.Visible = false;
            btnPrimerIngreso.Visible = false;
            btnReingreso.Visible = false;
            btnActualizarMatricula.Visible = false;
        }

        private void btnReingreso_Click(object sender, EventArgs e)
        {
            grpListaEstudiantes.Visible = true;
            btnPrimerIngreso.Visible = false;
            label1.Visible = false;
            btnReingreso.Visible = false;
            btnActualizarMatricula.Visible = false;
            dbConn.llenarDGV(dgvEstudiantes, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero', estado as 'Estado'  FROM datosEstudiante");



        }

        private void txtNmbreEstudiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombreEstudiante.Text != string.Empty)
                {
                    if (txtNombreEncargado.Text != string.Empty)
                    {
                        if (cmbCurso.SelectedIndex != 0)
                        {
                            if (cmbSeccion.SelectedIndex != 0)
                            {
                                if (cmbModoPago.SelectedIndex == 0)
                                {
                                    mesesDePago = 12;
                                }
                                else if (cmbModoPago.SelectedIndex == 1)
                                {
                                    mesesDePago = 10;
                                }

                                if (dbConn.PARegistrarMatricula("1010202000034", txtNombreEncargado.Text, txtIdentidadEstudiante.Text, cmbCurso.SelectedIndex, cmbSeccion.SelectedIndex, float.Parse(txtTotalPagar.Text), 1, mesesDePago, 1, 1))
                                {
                                    dbConn.PAGeneracionPrimerPago(txtIdentidadEstudiante.Text);
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
            btnActualizarMatricula.Visible = true;
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
                    dbConn.llenarComboBoxValorInicial(cmbIdentidadEncargado, "SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM datosEncargado INNER JOIN detalleEncargado ON detalleEncargado.id_encargadoAlumno = datosEncargado.identidadEncargado WHERE detalleEncargado.id_Estudiante = '" + txtIdentidadEstudiante.Text + "'");
                    cmbIdentidadEncargado.SelectedIndex = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtRegistarR_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtNombreEstudianteR.Text != string.Empty)
            //    {
            //        if (txtNombreEncargadoR.Text != string.Empty)
            //        {
            //            if (cmbCursoR.SelectedIndex != 0)
            //            {
            //                if (cmbSeccionR.SelectedIndex != 0)
            //                {
            //                       if (cmbModoPagoR.SelectedIndex == 0)
            //                       {
            //                            mesesDePago = 12;
            //                       }
            //                       else if (cmbModoPagoR.SelectedIndex == 1)
            //                       {
            //                            mesesDePago = 10;
            //                       }
            //                       if (dbConn.PARegistrarMatricula("1010202000034", txtIdentidadEncargadoR.Text, txtIdentidadEstudianteR.Text, cmbCursoR.SelectedIndex, cmbSeccionR.SelectedIndex, float.Parse(txtTotalR.Text), 1, mesesDePago, 1, 2))
            //                       {

            //                        message.lblCheck.Text = "MATRICULA REGISTRADA";
            //                       message.ShowDialog();
            //                       limpiarPantalla();
            //                       }
            //                       else
            //                       {
            //                           messageError.lblError.Text = "ERROR INESPERADO";
            //                           messageError.ShowDialog();
            //                       }
            //                }
            //                else
            //                {
            //                    messageWarning.lblError.Text = "SELECCIONE UNA SECCION";
            //                    messageWarning.ShowDialog();
            //                }
            //            }
            //            else
            //            {
            //                messageWarning.lblError.Text = "SELECCIONE UN CURSO";
            //                messageWarning.ShowDialog();
            //            }
            //        }
            //        else
            //        {
            //            messageWarning.lblError.Text = "INGRESE UN ID DE ENCARGADO";
            //            messageWarning.ShowDialog();
            //        }
            //    }
            //    else
            //    {
            //        messageWarning.lblError.Text = "INGRESE UN ID DE ESTUDIANTE";
            //        messageWarning.ShowDialog();
            //    }
            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
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

            txtIdentidadEncargadoR.Clear();
            txtIdentidadEstudianteR.Clear();
            txtNombreEstudianteR.Clear();
            cmbCursoR.SelectedIndex = 0;
            cmbSeccionR.SelectedIndex = 0;
            cmbModoPagoR.SelectedIndex = 0;
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
            if (cmbIdentidadEncargado.SelectedIndex > 0)
            {
                dbConn.llenarTextBox(txtNombreEncargado, "SELECT identidadEncargado FROM datosEncargado WHERE concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) = '" + cmbIdentidadEncargado.SelectedItem.ToString() + "'");
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
            grpListaEstudiantes.Visible = false;
            grpReingreso.Visible = false;
            label1.Visible = true;
            btnPrimerIngreso.Visible = true;
            btnReingreso.Visible = true;
            identidadReingreso = "";
            btnActualizarMatricula.Visible = true;
            cmbEncargadosReingreso.Items.Clear();
        }

        private void txtBusquedaIdentidad_TextChanged(object sender, EventArgs e)
        {



        }


        private void btnSiguienteDGVAct_Click(object sender, EventArgs e)
        {
            if (identidadReingreso != "")
            {

                txtIdentidadEstudianteR.Text = identidadReingreso;
                grpListaEstudiantes.Visible = false;
                grpReingreso.Visible = true;
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
            grpReingreso.Visible = false;
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
                dbConn.llenarComboBoxValorInicial(cmbEncargadosReingreso, "SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM datosEncargado INNER JOIN detalleEncargado ON detalleEncargado.id_encargadoAlumno = datosEncargado.identidadEncargado WHERE detalleEncargado.id_Estudiante = '" + txtIdentidadEstudianteR.Text + "'");
                cmbEncargadosReingreso.SelectedIndex = 0; 
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
                    if (txtIdentidadEncargadoR.Text != string.Empty)
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
                                    dbConn.PAGeneracionPrimerPago(txtIdentidadEstudianteR.Text);
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

        private void btnActualizarMatricula_Click(object sender, EventArgs e)
        {

        }

        private void altoButton2_Click(object sender, EventArgs e)
        {

            label1.Visible = true;
            btnPrimerIngreso.Visible = true;
            btnReingreso.Visible = true;
            btnActualizarMatricula.Visible = true;
            identidadReingreso = "";
            grpActualizarEstado.Visible = false;
            grpListadoEstado.Visible = false;
        }

        private void btnActualizarMatricula_Click_1(object sender, EventArgs e)
        {
            grpListadoEstado.Visible = true;
            btnPrimerIngreso.Visible = false;
            label1.Visible = false;
            btnReingreso.Visible = false;

            btnActualizarMatricula.Visible = false;

            dbConn.llenarDGV(dgvBusquedaEstado, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero', estado as 'Estado'  FROM datosEstudiante");

        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            if (identidadActualizacion != "")
            {

                txtIdentidadEstado.Text = identidadActualizacion;
                grpListadoEstado.Visible = false;
                grpActualizarEstado.Visible = true;
            }
            else
            {
                messageWarning.lblError.Text = "SELECCIONE UN ESTUDIANTE";
                messageWarning.ShowDialog();
            }
        }

        private void dgvBusquedaEstado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            identidadActualizacion = dgvEstudiantes.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void txtIdentidadEstado_TextChanged(object sender, EventArgs e)
        {
            int estadoMatricula;

            dbConn.llenarTextBox(txtNombreEstudianteEstado, "SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM datosEstudiante WHERE identidadEstudiante = '" + identidadActualizacion + "'");
            idMatriculaEstudiante = dbConn.obtenerVariableEntera("SELECT id_RegistroMatricula FROM matricula WHERE id_Estudiante = '" + identidadActualizacion + "'");
            txtMatriculaEstado.Text = "" + idMatriculaEstudiante;


            ultimoDetalleMatricula = dbConn.obtenerVariableEntera("SELECT MAX(id_DetalleMatricula) FROM detalleMatricula WHERE id_RegistroMatricula = " + idMatriculaEstudiante);
            dbConn.llenarTextBox(txtNombreCurso, "SELECT nombreCurso FROM cursos INNER JOIN detalleMatricula ON detalleMatricula.id_Curso = cursos.id_Curso WHERE id_DetalleMatricula = " + ultimoDetalleMatricula);
            dbConn.llenarTextBox(txtSeccionEstado, "SELECT nombreSeccion FROM seccion INNER JOIN detalleMatricula ON detalleMatricula.id_Seccion = seccion.id_Seccion WHERE id_DetalleMatricula = " + ultimoDetalleMatricula);

            estadoMatricula = dbConn.obtenerVariableEntera("SELECT estado FROM detalleMatricula WHERE id_DetalleMatricula = " + ultimoDetalleMatricula);

            switch (estadoMatricula)
            {
                case 1:
                    cmbEstadoMatri.SelectedIndex = 0;
                    break;

                case 2:
                    cmbEstadoMatri.SelectedIndex = 1;
                    break;
                case 3:
                    cmbEstadoMatri.SelectedIndex = 2;
                    break;
            }


        }

        private void altoButton3_Click(object sender, EventArgs e)
        {
            int estadoActualizado = 1;

            switch (cmbEstadoMatri.SelectedIndex)
            {
                case 0:
                    estadoActualizado = 1;
                    break;
                case 1:
                    estadoActualizado = 2;
                    break;
                case 2:
                    estadoActualizado = 3;
                    break;
            }


            if (dbConn.PARegistrarMatricula("000000000000", "000000000000", txtIdentidadEstado.Text, 1, 1, 1, 1, 1, estadoActualizado, 3))
            {
                message.lblCheck.Text = "CAMBIO REGISTRADO";
                message.ShowDialog();
                limpiarPantalla();
            }

            else
            {
                messageError.lblError.Text = "ERROR INESPERADO";
                messageError.ShowDialog();
            }
        }

        private void btnRegresarEstado_Click(object sender, EventArgs e)
        {
            grpListadoEstado.Visible = true;
            grpActualizarEstado.Visible = false;
            identidadActualizacion = "";
        }

     
        //Metodos y validaciones De registro de  estudiante
        private void btnRegresarEstud_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            btnPrimerIngreso.Visible = true;
            btnReingreso.Visible = true;
            btnActualizarMatricula.Visible = true;
            identidadReingreso = "";
            grpRegistroEstudiante.Visible = false;
            
        }

        private void btnEstSiguiente_Click(object sender, EventArgs e)
        {

            try
            {
                if (mktIdentidadEstud.TextLength > 13 || mktIdentidadEstud.TextLength < 13)
                {
                    messageError.lblError.Text = "Error en la identidad";
                    messageError.ShowDialog();

          
                }
                else
                {

                    if (mktIdentidadEstud.Text == "" || txtprimerNombreEstud.Text == "" || txtprimerApellidoEstud.Text == "" ||
                         txtfechaNacimientoEstud.Text == "")
                    {
                        messageError.lblError.Text = "Debe llenar los campos necesarios";
                        messageError.ShowDialog();

                    }
                    else
                    {
                        if (cmbGeneroEstud.SelectedIndex.Equals(-1))
                        {
                            messageError.lblError.Text = "DEBE SELECCIONAR EL GÉNERO";
                            messageError.ShowDialog();
                        }
                        else
                        {
                            if (utilidad.isDate(txtfechaNacimientoEstud.Text))
                            {
                                messageQuestion.lblError.Text = "¿Esta seguro de los datos ingresados?";
                                messageQuestion.ShowDialog();
                                if (IMessageBoxYesCancel.isCodigoForm)
                                {
                                    RegistrarEstudiante();
                                }
                            }
                            else
                            {
                                messageError.lblError.Text = "INGRESE UNA FECHA VALIDA";
                                messageError.lblError.Location = new Point(120, 82);
                                messageError.ShowDialog();
                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

        public void LimpiarEstudiante()
        {
            mktIdentidadEstud.Clear();
            txtprimerNombreEstud.Clear();
            txtsegundoNombreEstud.Clear();
            txtprimerApellidoEstud.Clear();
            txtsegundoApellidoEstud.Clear();
            txtfechaNacimientoEstud.Clear();
            cmbGeneroEstud.SelectedItem = -1;
        }
        private void mktIdentidadEstud_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {              

            long number = 0;
            try
            {
                if (mktIdentidadEstud.Text != String.Empty)
                {
                    mktIdentidadEstud.ForeColor = Color.Red;
                    errorIdentidad.Clear();
                    if (long.TryParse(mktIdentidadEstud.Text, out number))
                    {
                        mktIdentidadEstud.ForeColor = Color.Red;
                        errorIdentidad.Clear();

                        if (mktIdentidadEstud.TextLength == 13)
                        {
                            mktIdentidadEstud.ForeColor = Color.Green;
                            errorIdentidad.Clear();


                        }
                        else if (mktIdentidadEstud.TextLength > 13 || mktIdentidadEstud.TextLength < 13)
                        {
                            mktIdentidadEstud.ForeColor = Color.Red;
                            errorIdentidad.SetError(this.mktIdentidadEstud, "El numero de Identidad no es Correcto!");

                        }
                    }
                    else
                    {
                        mktIdentidadEstud.ForeColor = Color.Red;
                        errorIdentidad.SetError(this.mktIdentidadEstud, "Solo se Permiten Numeros!");
                    }
                }
                else
                {
                    errorIdentidad.Clear();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void RegistrarEstudiante()
         {
            string genero;
            identidadEstudiante = mktIdentidadEstud.Text;
            genero = Genero(cmbGeneroEstud);

            try
            {
                if(dbConn.obtenerVariableEntera("select estado from datosEstudiante where identidadEstudiante = '"+mktIdentidadEstud.Text +"'") != 1)
                {
                    if (dbConn.PARegistrarEstudiante(mktIdentidadEstud.Text, txtprimerNombreEstud.Text,
                        txtsegundoNombreEstud.Text, txtprimerApellidoEstud.Text, txtsegundoApellidoEstud.Text,
                        txtfechaNacimientoEstud.Text, genero))
                    {

                        message.lblCheck.Text = "Estudiante Registrado";
                        message.ShowDialog();

                        LimpiarEstudiante();
                        grpRegistroEstudiante.Visible = false;
                        grpRegistroEncargados.Visible = true;
                    }
                    else
                    {
                        messageError.lblError.Text = "Error al Registrar";
                        messageError.ShowDialog();

                    }
                }
                else
                {
                    messageError.lblError.Text = "EL ESTUDIANTE YA EXISTE";
                    messageError.lblError.Location = new Point(120, 82);
                    messageError.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public string Genero(ComboBox CMB)
         {
            if(CMB.SelectedItem.ToString() == "Masculino")
            {
                return "M";
            }
            else
            {
                return "F";
            }
         }

        private void txtprimerNombreEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageWarning.lblError.Text = "Ingrese correctamente el primer nombre";
                messageWarning.ShowDialog();

                e.Handled = true;
                return;
            }
        }

        private void txtsegundoNombreEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageWarning.lblError.Text = "Ingrese correctamente el segundo nombre";
                messageWarning.ShowDialog();

                e.Handled = true;
                return;
            }
        }

        private void txtprimerApellidoEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageWarning.lblError.Text = "Ingrese correctamente el primer apellido";
                messageWarning.ShowDialog();
                e.Handled = true;
                return;
            }
        }

        private void txtsegundoApellidoEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageWarning.lblError.Text = "Ingrese correctamente el segundo apellido";
                messageWarning.ShowDialog();

                e.Handled = true;
                return;
            }
        }
        //Metodos y validaciones De registro de  Encargado
        private void txtPrimerNombreEncarg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageWarning.lblError.Text = "Ingrese correctamente el primer nombre";
                messageWarning.ShowDialog();

                e.Handled = true;
                return;
            }
        }

        private void txtSegundoNombreEncarg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageWarning.lblError.Text = "Ingrese correctamente el segundo nombre";
                messageWarning.ShowDialog();

                e.Handled = true;
                return;
            }
        }

        private void txtPrimerApellidoEncarg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageWarning.lblError.Text = "Ingrese correctamente el primer apellido";
                messageWarning.ShowDialog();
                e.Handled = true;
                return;
            }
        }

        private void txtSegundoApellidoEncarg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageWarning.lblError.Text = "Ingrese correctamente el segundo apellido";
                messageWarning.ShowDialog();
                e.Handled = true;
                return;
            }
        }

        private void txtprimerTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageWarning.lblError.Text = "Ingrese correctamente el número de teléfono";
                messageWarning.ShowDialog();
                e.Handled = true;
                return;
            }
        }

        private void txtTelefonoAlternativo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageWarning.lblError.Text = "Ingrese correctamente el número de teléfono";
                messageWarning.ShowDialog();
                e.Handled = true;
                return;
            }
        }

        private void mktIdentidadEncargado_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            long number = 0;
            try
            {
                if (mktIdentidadEstud.Text != String.Empty)
                {
                    mktIdentidadEstud.ForeColor = Color.Red;
                    errorIdentidad.Clear();
                    if (long.TryParse(mktIdentidadEstud.Text, out number))
                    {
                        mktIdentidadEstud.ForeColor = Color.Red;
                        errorIdentidad.Clear();

                        if (mktIdentidadEstud.TextLength == 13)
                        {
                            mktIdentidadEstud.ForeColor = Color.Green;
                            errorIdentidad.Clear();


                        }
                        else if (mktIdentidadEstud.TextLength > 13 || mktIdentidadEstud.TextLength < 13)
                        {
                            mktIdentidadEstud.ForeColor = Color.Red;
                            errorIdentidad.SetError(this.mktIdentidadEstud, "El numero de Identidad no es Correcto!");

                        }
                    }
                    else
                    {
                        mktIdentidadEstud.ForeColor = Color.Red;
                        errorIdentidad.SetError(this.mktIdentidadEstud, "Solo se Permiten Numeros!");
                    }
                }
                else
                {
                    errorIdentidad.Clear();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void limpiarEncargado()
        {
            mktIdentidadEncargado.Clear();
            txtPrimerNombreEncarg.Clear();
            txtSegundoNombreEncarg.Clear();
            txtPrimerApellidoEncarg.Clear();
            txtSegundoApellidoEncarg.Clear();
            txtprimerTelefono.Clear();
            txtTelefonoAlternativo.Clear();
            txtcorreoElectronico.Clear();
            mskFechaNacimientoEncarg.Clear();
            txtDireccion.Clear();

        }

        private void btnRegresarEncarg_Click(object sender, EventArgs e)
        {
            grpRegistroEstudiante.Visible = true;
            grpRegistroEncargados.Visible = false;

        }

        private void btnAgregarEncarg_Click(object sender, EventArgs e)
        {
            try
            {
                if (mktIdentidadEncargado.TextLength > 13 || mktIdentidadEncargado.TextLength < 13)
                {
                    messageError.lblError.Text = "Error en la identidad";
                    messageError.ShowDialog();
                    
                }
                else
                {
                        if (txtPrimerNombreEncarg.Text == "" && txtPrimerApellidoEncarg.Text == "" &&
                         txtcorreoElectronico.Text == "" && txtprimerTelefono.Text == "" &&
                         txtTelefonoAlternativo.Text == "" && txtDireccion.Text == "" && "2001/12/22" == "")
                        {
                            messageError.lblError.Text = "Debe llenar los campos necesarios";
                            messageError.lblError.Location = new Point(120, 82);
                            messageError.ShowDialog();
                        }
                        else
                        {
                        if (utilidad.verificarCorreo(txtcorreoElectronico.Text))
                        {
                            if (utilidad.isDate(mskFechaNacimientoEncarg.Text))
                            {
                                RegistrarEncargado();
                                limpiarEncargado();
                            }
                            else
                            {
                                messageError.lblError.Text = "INGRESE UNA FECHA VALIDA";
                                messageError.lblError.Location = new Point(120, 82);
                                messageError.ShowDialog();
                            }

                        }
                        else
                        {
                            messageError.lblError.Text = "INGRESE UN CORREO VÁLIDO";
                            messageError.lblError.Location = new Point(120, 82);
                            messageError.ShowDialog();

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RegistrarEncargado()
        {

            try
            {
                if (dbConn.PARegistroEncargado(identidadEstudiante ,mktIdentidadEncargado.Text,
                    txtPrimerNombreEncarg.Text, txtSegundoApellidoEncarg.Text, txtPrimerApellidoEncarg.Text,
                    txtSegundoApellidoEncarg.Text, txtcorreoElectronico.Text, txtprimerTelefono.Text,
                    txtTelefonoAlternativo.Text, txtDireccion.Text, mskFechaNacimientoEncarg.Text))
                {
              
                    message.lblCheck.Text = "Encargado Registrado";
                    message.ShowDialog();

                    limpiarPantalla();
                }
                else
                {
                    messageError.lblError.Text = "Error al Registrar Encargado";
                    messageError.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        private void btnSiguienteEncarg_Click_1(object sender, EventArgs e)
        {    
            if (dbConn.obtenerVariableEntera("select count(*) from detalleEncargado where id_Estudiante = '"+ identidadEstudiante +"'") > 0)
            {
                messageQuestion.lblError.Text = "¿Esta seguro de continuar?";
                messageQuestion.ShowDialog();
                if (IMessageBoxYesCancel.isCodigoForm)
                {
                    limpiarEncargado();
                    grpRegistroEncargados.Visible = false;
                    grpMatriculaPrimerIngreso.Visible = true;
                    txtIdentidadEstudiante.Text = identidadEstudiante;
                }
            }
            else
            {
                  messageError.lblError.Text = "Ingrese al menos un encargado";
                  messageError.ShowDialog();
                
            }
        }

        private void grpActualizarEstado_Enter(object sender, EventArgs e)
        {

        }

        private void txtIdentidadActMat_TextChanged(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvBusquedaEstado, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero', estado as 'Estado' FROM datosEstudiante WHERE CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ' , segundoApellido) LIKE '" + txtIdentidadActMat.Text + "%' and estado = 1 or identidadEstudiante LIKE '" + txtIdentidadActMat.Text + "%' and estado = 1");

        }

        private void txtLikeIdentidadReingreso_TextChanged(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvEstudiantes, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero', estado as 'Estado' FROM datosEstudiante WHERE CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ' , segundoApellido) LIKE '" + txtLikeIdentidadReingreso.Text + "%' and estado = 1 or identidadEstudiante LIKE '" + txtLikeIdentidadReingreso.Text + "%' and estado = 1");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            identidadEncargadoReingreso = cmbEncargadosReingreso.SelectedItem.ToString();
            if (cmbEncargadosReingreso.SelectedIndex > 0)
            {
                dbConn.llenarTextBox(txtIdentidadEncargadoR, "SELECT identidadEncargado FROM datosEncargado WHERE concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) = '" + cmbEncargadosReingreso.SelectedItem.ToString() + "'");
            }
            else
            {
                txtIdentidadEncargadoR.Clear();
            }
        }

        private void btnModificarEstud_Click(object sender, EventArgs e)
        {

            gbEstudiantes.Visible = true;
            grpReingreso.Visible = false;
            identidadEstudianteModDatos = txtIdentidadEstudianteR.Text;
            txtIdentidadEstudianteR.Clear();
            txtIdentidadEstudMod.Text = identidadEstudianteModDatos;
        }

        public void ActualizarEstudiante()
        {

            try
            {
                if (dbConn.PAActualizarEstudiante(txtIdentidadEstudMod.Text, txtPrimerNombreEstudMod.Text, txtSegundoNombreEstudMod.Text, txtPrimerApellidoEstudMod.Text, txtSegundoApellidoEstudMod.Text))
                {
                    message.lblCheck.Text = "ESTUDIANTE ACTUALIZADO";
                    message.ShowDialog();
                    limpiarPantalla();
                }
                else
                {
                    messageError.lblError.Text = "ERROR AL ACTUALIZAR";
                    messageError.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void btnActualizarEliminarEncargado_Click(object sender, EventArgs e)
        {
            if(txtIdentidadEncargadoR.Text == "")
            {
                messageError.lblError.Text = "SELECCIONES UN ENCARGADO";
                messageError.ShowDialog();
            }
            else
            {
            gbEncargados.Visible = true;
            grpReingreso.Visible = false;
            identidadEstudianteModDatos = txtIdentidadEstudianteR.Text;
            identidadEncargadoModDatos = txtIdentidadEncargadoR.Text;
            txtIdentidadEstudianteR.Clear();
            txtIdentidadEncargadoMod.Text = identidadEncargadoModDatos;

            dbConn.llenarTextBox(txtprimerNombreEncargadoMod, "select primerNombre from datosEncargado where identidadEncargado = '" + txtIdentidadEncargadoMod.Text + "'");
            dbConn.llenarTextBox(txtsegundoNombreEncargadoMod, "select segundoNombre from datosEncargado where identidadEncargado = '" + txtIdentidadEncargadoMod.Text + "'");
            dbConn.llenarTextBox(txtprimerApellidoEncargadoMod, "select primerApellido from datosEncargado where identidadEncargado = '" + txtIdentidadEncargadoMod.Text + "'");
            dbConn.llenarTextBox(txtsegundoApellidoEncargadoMod, "select segundoApellido from datosEncargado where identidadEncargado = '" + txtIdentidadEncargadoMod.Text + "'");
            dbConn.llenarTextBox(txtCorreoElectronicoEncargadoMod, "select correoElectronico from datosEncargado where identidadEncargado = '" + txtIdentidadEncargadoMod.Text + "'");
            txtfechaNacimientoEncargadoMod.Text = dbConn.obtenerVariableDate("select fechaNacimiento from datosEncargado where identidadEncargado = '" + txtIdentidadEncargadoMod.Text + "'").ToString("dd/MM/yyyy");
            dbConn.llenarTextBox(txtTelefonoEncargadoMod, "select numeroTelefono from datosEncargado where identidadEncargado = '" + txtIdentidadEncargadoMod.Text + "'");
            dbConn.llenarTextBox(txtsegundoTelefonoEncargadoMod, "select numeroTelefonoAlt from datosEncargado where identidadEncargado = '" + txtIdentidadEncargadoMod.Text + "'");
            dbConn.llenarTextBox(txtDireccionEncargadoMod, "select direccionTrabajo from datosEncargado where identidadEncargado = '" + txtIdentidadEncargadoMod.Text + "'");
            }
        }

        private void btnActualizarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentidadEstudMod.TextLength > 13 || txtIdentidadEstudMod.TextLength < 13)
                {
                    messageError.lblError.Text = "INGRESE CORRECTAMENTE LA IDENTIDAD";
                    messageError.ShowDialog();
                    limpiarPantalla();
                }
                else
                {
                    if (txtPrimerNombreEstudMod.Text == "" && txtPrimerApellidoEstudMod.Text == "")
                    {
                        messageError.lblError.Text = "INGRESE TODOS LOS DATOS NECESARIOS";
                        messageError.ShowDialog();
                    }
                    else
                    {
                        messageQuestion.lblError.Text = "¿Esta seguro de los datos ingresados?";
                        messageQuestion.ShowDialog();
                        if (IMessageBoxYesCancel.isCodigoForm)
                        {
                            ActualizarEstudiante();
                            cmbEncargadosReingreso.Items.Clear();
                            txtIdentidadEstudianteR.Text = identidadEstudianteModDatos;
                            limpiarModificaciones();
                            grpReingreso.Visible = true;
                            gbEstudiantes.Visible = false;
                           
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void txtIdentidadEstudMod_TextChanged(object sender, EventArgs e)
        {
            string genero;
            txtFechaNacimientoEstudMod.Text = dbConn.obtenerVariableDate("select fechaNacimiento from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstudMod.Text + "'").ToString("dd/MM/yyyy");
            dbConn.llenarTextBox(txtPrimerNombreEstudMod, "select primerNombre from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstudMod.Text + "'");
            dbConn.llenarTextBox(txtSegundoNombreEstudMod, "select segundoNombre from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstudMod.Text + "'");
            dbConn.llenarTextBox(txtPrimerApellidoEstudMod, "select primerApellido from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstudMod.Text + "'");
            dbConn.llenarTextBox(txtSegundoApellidoEstudMod, "select segundoApellido from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstudMod.Text + "'");
            genero = dbConn.obtenerVariableString("select genero from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstudMod.Text + "'");

            if (genero == "M")
            {
                cmbgeneroEstudMod.SelectedItem = "M";
            }
            else if (genero == "F")
            {
                cmbgeneroEstudMod.SelectedItem = "F";
            }
            else
            {
                cmbgeneroEstudMod.SelectedIndex = -1;
            }
        }

        private void btnEliminarEncargado_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentidadEncargadoMod.TextLength > 13 || txtIdentidadEncargadoMod.TextLength < 13)
                {
                    messageError.lblError.Text = "INGRESE CORRECTAMENTE LA IDENTIDAD";
                    messageError.ShowDialog();
                    limpiarPantalla();
                }
                else
                {
                    EliminarEncargado();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void EliminarEncargado()
        {
            if (dbConn.ComprobarExistencia("select estado from datosEncargado where identidadEncargado = '" + txtIdentidadEncargadoMod.Text + "'"))
            {
                dbConn.ejecutarComandoSQL("DELETE FROM detalleEncargado WHERE id_encargadoAlumno = '"+ txtIdentidadEncargadoMod.Text +"' and id_Estudiante = '"+identidadEstudianteModDatos+"'");
                dbConn.ejecutarComandoSQL("update datosEncargado set estado = 2 where identidadEncargado = '" + txtIdentidadEncargadoMod.Text + "'");

                message.lblCheck.Text = "ENCARGADO ELIMINADO";
                message.ShowDialog();

                cmbEncargadosReingreso.Items.Clear();
                txtIdentidadEstudianteR.Text = identidadEstudianteModDatos;
                limpiarModificaciones();
                grpReingreso.Visible = true;
                gbEncargados.Visible = false;

            }
            else
            {
                dbConn.ejecutarComandoSQL("DELETE FROM detalleEncargado WHERE id_encargadoAlumno = '" + txtIdentidadEncargadoMod.Text + "' and id_Estudiante = '" + identidadEstudianteModDatos + "'");
                messageWarning.lblError.Text = "SE HA ELIMINADO DE ESTE ALUMNO";
                messageWarning.ShowDialog();
            }
        }

        private void btnActualizarEncargado_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentidadEncargadoMod.TextLength > 13 || txtIdentidadEncargadoMod.TextLength < 13)
                {
                    messageError.lblError.Text = "INGRESE CORRECTAMENTE LA IDENTIDAD";
                    messageError.ShowDialog();
                    limpiarPantalla();
                }
                else
                {

                    if (txtprimerNombreEncargadoMod.Text == "" || txtprimerApellidoEncargadoMod.Text == "" || txtCorreoElectronicoEncargadoMod.Text == "" || txtTelefonoEncargadoMod.Text == "" || txtsegundoTelefonoEncargadoMod.Text == "" || txtDireccionEncargadoMod.Text == "")
                    {

                        messageError.lblError.Text = "LLENE LOS CAMPOS SOLICITADOS";
                        messageError.ShowDialog();
                    }
                    else
                    {

                        if (utilidad.verificarCorreo(txtCorreoElectronicoEncargadoMod.Text))
                        {
                            messageQuestion.lblError.Text = "¿Esta seguro de los datos ingresados?";
                            messageQuestion.ShowDialog();
                            if (IMessageBoxYesCancel.isCodigoForm)
                            {
                                ActualizarEncargado();
                                cmbEncargadosReingreso.Items.Clear();
                                txtIdentidadEstudianteR.Text = identidadEstudianteModDatos;
                                limpiarModificaciones();
                                grpReingreso.Visible = true;
                                gbEncargados.Visible = false;

                            }
                        }
                        else
                        {
                            messageError.lblError.Text = "INGRESE UN CORREO VÁLIDO";
                            messageError.lblError.Location = new Point(120, 82);
                            messageError.ShowDialog();

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnRegresarEncargado_Click(object sender, EventArgs e)
        {
            gbEncargados.Visible = false;
            grpReingreso.Visible = true;
            cmbEncargadosReingreso.Items.Clear();
            txtIdentidadEstudianteR.Text = identidadEstudianteModDatos;
            identidadEncargadoModDatos = "";
            identidadEstudianteModDatos = "";
            limpiarModificaciones();
        }

        private void limpiarModificaciones()
        {
            txtPrimerNombreEstudMod.Clear();
            txtSegundoNombreEstudMod.Clear();
            txtPrimerApellidoEstudMod.Clear();
            txtSegundoApellidoEstudMod.Clear();
            txtFechaNacimientoEstudMod.Clear();
            cmbgeneroEstudMod.SelectedIndex = -1;
        }



        public void ActualizarEncargado()
        {

            try
            {
                if (dbConn.PAActualizarEncargado(txtIdentidadEncargadoMod.Text, txtprimerNombreEncargadoMod.Text, txtsegundoNombreEncargadoMod.Text, txtprimerApellidoEncargadoMod.Text, txtsegundoApellidoEncargadoMod.Text, txtCorreoElectronicoEncargadoMod.Text, txtTelefonoEncargadoMod.Text, txtsegundoTelefonoEncargadoMod.Text, txtDireccionEncargadoMod.Text))
                {
                    message.lblCheck.Text = "ENCARGADO ACTUALIZADO";
                    message.ShowDialog();
                    limpiarPantalla();
                }
                else
                {
                    messageError.lblError.Text = "ERROR AL ACTUALIZAR";
                    messageError.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
