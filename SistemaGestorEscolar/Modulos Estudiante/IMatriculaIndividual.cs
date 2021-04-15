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
using SistemaGestorEscolar.Utilidades;

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
        DataTable encargados = new DataTable();
        public static Image image;

        int Existe = 0;
        string[,] EncargadoMatricula = new string[10,11];
        string[,] EstudianteMatricula = new string[1, 7];
        int Encargados;
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
        int idSeccion;


        private void IMatriculaIndividual_Load(object sender, EventArgs e)
        {
            dbConn.llenarComboBoxValorInicial(cmbCurso, "SELECT nombreCurso FROM cursos where [estadoCurso] = 1");
            dbConn.llenarComboBoxValorInicial(cmbCursoR, "SELECT nombreCurso FROM cursos where [estadoCurso] = 1");
            cmbCurso.SelectedIndex = 0;
            cmbCursoR.SelectedIndex = 0;
            cmbSeccion.SelectedIndex = 0;
            cmbModoPago.SelectedIndex = 0;
            dbConn.llenarDGV(dgvEstudiantes, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero', estado as 'Estado'  FROM datosEstudiante");
            dbConn.llenarDGV(dgvBusquedaEstado, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero', estado as 'Estado'  FROM datosEstudiante");

            recuperarMatricula();

            encargados.Columns.Add("identidadEstudiante");
            encargados.Columns.Add("identEncargado");
            encargados.Columns.Add("PrimerNombreEncarg");
            encargados.Columns.Add("SegundoNombreEncarg");
            encargados.Columns.Add("PrimerApellidoEncarg");
            encargados.Columns.Add("SegundoApellidoEncarg");
            encargados.Columns.Add("CorreoElectronico");
            encargados.Columns.Add("primerTelefono");
            encargados.Columns.Add("TelefonoAlternativo");
            encargados.Columns.Add("Direccion");
            encargados.Columns.Add("FechaNacimientoEncarg");

            grpMatriculaPrimerIngreso.Visible = false;
            grpReingreso.Visible = false;

            ClsCambioTema.cambiarTemaBoton(grpRegistroEncargados);
            ClsCambioTema.cambiarTemaBoton(grpRegistroEstudiante);
            ClsCambioTema.cambiarTemaBoton(grpListadoEstado);
            ClsCambioTema.cambiarTemaBoton(grpActualizarEstado);
            ClsCambioTema.cambiarTemaBoton(gbEncargados);
            ClsCambioTema.cambiarTemaBoton(gbEstudiantes);
            ClsCambioTema.cambiarTemaBoton(grpReingreso);
            ClsCambioTema.cambiarTemaBoton(grpListaEstudiantes);
            ClsCambioTema.cambiarTemaBoton(grpMatriculaPrimerIngreso);
            ClsCambioTema.cambiarTemaBoton(this);
            if (Properties.Settings.Default.isModoOscuro == true)
            {


                grpRegistroEncargados.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                grpRegistroEstudiante.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                grpListadoEstado.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                grpActualizarEstado.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                gbEncargados.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                gbEstudiantes.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                grpReingreso.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                grpListaEstudiantes.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                grpMatriculaPrimerIngreso.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                this.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);

            }
            else
            {


                grpRegistroEncargados.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                grpRegistroEstudiante.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                grpListadoEstado.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                grpActualizarEstado.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                gbEncargados.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                gbEstudiantes.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                grpReingreso.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                grpListaEstudiantes.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                grpMatriculaPrimerIngreso.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                this.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);

            }




        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void recuperarMatricula()
        {
            if (dbConn.obtenerVariableString("SELECT max(id_RegistroMatricula) FROM matricula") != "")
            {
                ultimaMatricula = dbConn.obtenerVariableEntera("SELECT max(id_RegistroMatricula) FROM matricula");
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

            grpRegistroEstudiante.Visible = true;
            grpMatriculaPrimerIngreso.Visible = false;
            label1.Visible = false;
            btnPrimerIngreso.Visible = false;
            btnReingreso.Visible = false;
            btnActualizarMatricula.Visible = false;
            cmbGeneroEstud.SelectedIndex = 0;
        }

        private void btnReingreso_Click(object sender, EventArgs e)
        {
            grpListaEstudiantes.Visible = true;
            btnPrimerIngreso.Visible = false;
            label1.Visible = false;
            btnReingreso.Visible = false;
            btnActualizarMatricula.Visible = false;
            dbConn.llenarDGV(dgvEstudiantes, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero'  FROM datosEstudiante");

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
                            int idCurso = dbConn.obtenerVariableEntera("SELECT id_Curso FROM cursos WHERE nombreCurso = '" + cmbCurso.SelectedItem.ToString() + "'");

                            if (cmbSeccion.SelectedIndex != 0)
                            {
                                RegistrarEstudiante();
                                RegistrarEncargado();


                                if (cmbModoPago.SelectedIndex == 0)
                                {
                                    mesesDePago = 12;
                                }
                                else if (cmbModoPago.SelectedIndex == 1)
                                {
                                    mesesDePago = 10;
                                }

                                if (dbConn.PARegistrarMatricula(clsVariablesGlobales.numIdentidad, cmbIdentidadEncargado.SelectedItem.ToString() , txtIdentidadEstudiante.Text, idCurso, idSeccion, float.Parse(txtTotalPagar.Text), 1, mesesDePago, 1, 1, image))
                                {
                                    dbConn.PAGeneracionPrimerPago(txtIdentidadEstudiante.Text);
                                    message.lblCheck.Text = "MATRICULA REGISTRADA";
                                    message.ShowDialog();

                                    grpMatriculaPrimerIngreso.Visible = false;
                                    label1.Visible = true;
                                    btnPrimerIngreso.Visible = true;
                                    btnReingreso.Visible = true;
                                    btnActualizarMatricula.Visible = true;
                                    limpiarEncargado();
                                    LimpiarEstudiante();                                    
                                    cmbIdentidadEncargado.Items.Clear();
                                    recuperarMatricula();
                                    limpiarPantalla();
                                    image = null;
                                    encargados.Clear();
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

            dbConn.llenarComboBoxValorInicial(cmbSeccion, "SELECT nombreSeccion FROM seccion INNER JOIN cursos ON seccion.id_Curso = cursos.id_Curso WHERE estado = 1 and cursos.nombreCurso = '" + cmbCurso.SelectedItem + "'");
            cmbSeccion.SelectedIndex = 0;
            txtDescuento.Text = "0.00";

            txtTotalPagar.Text = dbConn.obtenerVariableDouble("SELECT precioCompleto FROM cursos WHERE nombreCurso = '" + cmbCurso.SelectedItem + "'").ToString();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            messageQuestion.lblError.Text = "¿Esta seguro de Regresar?\nPerdera todos los datos ingresados.";
            messageQuestion.ShowDialog();
            if (IMessageBoxYesCancel.isCodigoForm)
            {
            grpMatriculaPrimerIngreso.Visible = false;
            label1.Visible = true;
            btnPrimerIngreso.Visible = true;
            btnReingreso.Visible = true;
            btnActualizarMatricula.Visible = true;    
            image = null;
            limpiarEncargado();
            LimpiarEstudiante();
            encargados.Clear();
            cmbIdentidadEncargado.Items.Clear();
            }
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

            if (txtIdentidadEstudiante.MaskCompleted == true)
            {
                txtNombreEstudiante.Text = EstudianteMatricula[0, 1]  + " " + EstudianteMatricula[0, 2] + " " + EstudianteMatricula[0, 3] + " "+ EstudianteMatricula[0, 4];
               
                cmbIdentidadEncargado.Items.Add("<SELECCIONE>");
                
                for (int i = 0; i < encargados.Rows.Count; i++)
                { 
                    cmbIdentidadEncargado.Items.Add(encargados.Rows[i][1].ToString());

                }
                cmbIdentidadEncargado.SelectedIndex = 0;
                          
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
                    if (txtIdentidadEncargadoR.Text != string.Empty)
                    {
                        if (cmbCursoR.SelectedIndex != 0)
                        {
                            int idCurso = dbConn.obtenerVariableEntera("SELECT id_Curso FROM cursos WHERE nombreCurso = '" + cmbCursoR.SelectedItem.ToString() + "'");

                            if (cmbSeccionR.SelectedIndex != 0)
                            {
                                if (cmbModoPagoR.SelectedIndex != -1)
                                { 
                                 if (cmbModoPagoR.SelectedIndex == 0)
                                    {
                                        mesesDePago = 12;
                                    }
                                    else if (cmbModoPagoR.SelectedIndex == 1)
                                    {
                                        mesesDePago = 10;
                                    }

                            if (dbConn.obtenerVariableEntera("select count(*) from detalleMatricula INNER JOIN matricula ON detalleMatricula.id_RegistroMatricula = matricula.id_RegistroMatricula WHERE  id_Curso = " + idCurso + " and id_Seccion = " + idSeccion + " and matricula.id_Estudiante = '" + txtIdentidadEstudianteR.Text + "'") < 1)
                            {
                                if (dbConn.obtenerVariableEntera("SELECT estado FROM  [dbo].[detalleMatricula] E WHERE (SELECT MAX(A.id_DetalleMatricula) FROM[dbo].[detalleMatricula] A INNER JOIN[dbo].[matricula] B ON A.id_RegistroMatricula = b.id_RegistroMatricula WHERE B.id_Estudiante = '" + txtIdentidadEstudianteR.Text + "') = E.id_DetalleMatricula") != 1) 
                                    {

                                        if (dbConn.PARegistrarMatricula(clsVariablesGlobales.numIdentidad, txtIdentidadEncargadoR.Text, txtIdentidadEstudianteR.Text, idCurso, idSeccion, float.Parse(txtTotalR.Text), 2, mesesDePago, 1, 2, image))
                                        {
                                            dbConn.PAGeneracionPrimerPago(txtIdentidadEstudianteR.Text);
                                            message.lblCheck.Text = "MATRICULA REGISTRADA";
                                            message.ShowDialog();


                                            
                                            grpReingreso.Visible = false;
                                            cmbEncargadosReingreso.Items.Clear();
                                            txtNombreEstudianteR.Clear();
                                            identidadReingreso = "";
                                            grpListaEstudiantes.Visible = false;
                                            label1.Visible = true;
                                            btnPrimerIngreso.Visible = true;
                                            btnReingreso.Visible = true;
                                            identidadReingreso = "";
                                            btnActualizarMatricula.Visible = true;
                                            image = null;
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
                                        messageWarning.lblError.Text = "ESTE ESTUDIANTE ESTA EN UN CURSO";
                                        messageWarning.ShowDialog();
                                    }

                                    }
                                    else
                                    {
                                        messageWarning.lblError.Text = "ESTE ALUMNO YA ESTA MATRICULADO!";
                                        messageWarning.ShowDialog();
                                    }
                                }
                            else
                            {
                                    messageWarning.lblError.Text = "SELECCIONE UN MODO PAGO";
                                    messageWarning.ShowDialog();
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
            cmbCurso.SelectedIndex = 0;
            cmbSeccion.SelectedIndex = 0;
            cmbModoPago.SelectedIndex = 0;
            cmbIdentidadEncargado.SelectedIndex = 0;
            txtDescuento.Text = "0.00";
            txtTotalPagar.Clear();
            image = null;
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
            cmbEncargadosReingreso.Items.Clear();
            txtDescuentoR.Text = "0.00";
            txtTotalR.Clear();

            txtSeccionEstado.Clear();
            txtNombreCurso.Clear();
            txtNombreEstudianteEstado.Clear();
            txtIdentidadEstado.Clear();
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
                for (int i = 0; i < encargados.Rows.Count; i++)
                {


                     if (encargados.Rows[i][1].ToString().Equals(identidadEncargado))
                     {
                         txtNombreEncargado.Text = encargados.Rows[i][2].ToString() +" " + encargados.Rows[i][3].ToString() + " "+ encargados.Rows[i][4].ToString() + " "+ encargados.Rows[i][5].ToString();
                     }


                }
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
            txtBusquedaNombre.Clear();
        }

        private void txtBusquedaIdentidad_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtBusquedaNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguienteDGVAct_Click(object sender, EventArgs e)
        {
            if (identidadReingreso != "")
            {

                txtIdentidadEstudianteR.Text = identidadReingreso;
                txtBusquedaNombre.Clear();
                grpListaEstudiantes.Visible = false;
                grpReingreso.Visible = true;
                dbConn.llenarDGV(dgvEstudiantes, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero', estado as 'Estado'  FROM datosEstudiante");

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
            cmbEncargadosReingreso.Items.Clear();
            txtIdentidadEstudianteR.Clear();
            image = null;
            identidadReingreso = "";

            cmbCursoR.SelectedIndex = 0;
            cmbSeccionR.SelectedIndex = 0;
            cmbModoPagoR.SelectedIndex = 0;
            txtDescuentoR.Text = "0.00";
            txtTotalR.Clear();
            image = null;
        }

        private void grpListaEstudiantes_Enter(object sender, EventArgs e)
        {
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
            dbConn.llenarComboBoxValorInicial(cmbSeccionR, "SELECT nombreSeccion FROM seccion INNER JOIN cursos ON seccion.id_Curso = cursos.id_Curso WHERE estado = 1 and cursos.nombreCurso = '" + cmbCursoR.SelectedItem + "'");
            cmbSeccionR.SelectedIndex = 0;
            txtDescuentoR.Text = "0.00";


            txtTotalR.Text = dbConn.obtenerVariableDouble("SELECT precioCompleto FROM cursos WHERE nombreCurso = '" + cmbCursoR.SelectedItem + "'").ToString();
        }

        private void txtLimpiarR_Click(object sender, EventArgs e)
        {
            cmbCursoR.SelectedIndex = 0;
            cmbSeccionR.SelectedIndex = 0;
            cmbModoPagoR.SelectedIndex = 0;
            cmbEncargadosReingreso.SelectedIndex = 0;
            txtDescuentoR.Text = "0.00";
            txtTotalR.Clear();
            image = null;
        }

        private void txtRegistarR_MouseDown(object sender, MouseEventArgs e)
        {
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
            identidadActualizacion = "";
            txtBusquedaIdentidadEstado.Clear();
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

            dbConn.llenarDGV(dgvBusquedaEstado, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero' FROM datosEstudiante");

        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            if (identidadActualizacion != "")
            {

                txtIdentidadEstado.Text = identidadActualizacion;
                grpListadoEstado.Visible = false;
                grpActualizarEstado.Visible = true;
                txtBusquedaIdentidadEstado.Clear();
                dbConn.llenarDGV(dgvBusquedaEstado, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero' FROM datosEstudiante");

            }
            else
            {
                messageWarning.lblError.Text = "SELECCIONE UN ESTUDIANTE";
                messageWarning.ShowDialog();
            }
        }


        private void txtBusquedaNombreEstado_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtIdentidadEstado_TextChanged(object sender, EventArgs e)
        {
            int estadoMatricula;
            if (identidadActualizacion != "")
            {

                dbConn.llenarTextBox(txtNombreEstudianteEstado, "SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM datosEstudiante WHERE identidadEstudiante = '" + identidadActualizacion + "'");      
                idMatriculaEstudiante = dbConn.obtenerVariableEntera("SELECT id_RegistroMatricula FROM matricula WHERE id_Estudiante = '" + identidadActualizacion + "'");      
                txtMatriculaEstado.Text = "" + idMatriculaEstudiante;
        
                ultimoDetalleMatricula = dbConn.obtenerVariableEntera("SELECT MAX(id_DetalleMatricula) FROM detalleMatricula WHERE id_RegistroMatricula = " + idMatriculaEstudiante);         
                dbConn.llenarTextBox(txtNombreCurso, "SELECT nombreCurso FROM cursos INNER JOIN detalleMatricula ON detalleMatricula.id_Curso = cursos.id_Curso WHERE id_DetalleMatricula = " + ultimoDetalleMatricula);
                dbConn.llenarTextBox(txtSeccionEstado, "SELECT nombreSeccion FROM seccion INNER JOIN detalleMatricula ON detalleMatricula.id_Seccion = seccion.id_Seccion WHERE id_DetalleMatricula = " + ultimoDetalleMatricula);

        
                estadoMatricula = dbConn.obtenerVariableEntera("SELECT estado FROM  [dbo].[detalleMatricula] E WHERE (SELECT MAX(A.id_DetalleMatricula) FROM[dbo].[detalleMatricula] A INNER JOIN[dbo].[matricula] B ON A.id_RegistroMatricula = b.id_RegistroMatricula WHERE B.id_Estudiante = '" + identidadActualizacion + "') = E.id_DetalleMatricula");

         
                if(estadoMatricula == 1)
                {
                    cmbEstadoMatri.SelectedIndex = 0;
                }else if(estadoMatricula == 2)
          
                {
                    cmbEstadoMatri.SelectedIndex = 1;
                }
                else if(estadoMatricula == 3)
           
                {
                    cmbEstadoMatri.SelectedIndex = 2;

                }
            
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


            if (dbConn.PARegistrarMatricula("000000000000", "000000000000", txtIdentidadEstado.Text, 1, 1, 1, 1, 1, estadoActualizado, 3, null))
            {
                message.lblCheck.Text = "CAMBIO REGISTRADO";
                message.ShowDialog();

                identidadActualizacion = "";

                label1.Visible = true;
                btnPrimerIngreso.Visible = true;
                btnReingreso.Visible = true;
                btnActualizarMatricula.Visible = true;
                grpActualizarEstado.Visible = false;
                grpListadoEstado.Visible = false;

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
            limpiarPantalla();
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
            LimpiarEstudiante();
            
        }

        private void btnEstSiguiente_Click(object sender, EventArgs e)
        {

            try
            {

                if (mktIdentidadEstud.Text == "" || txtprimerNombreEstud.Text == "" || txtprimerApellidoEstud.Text == "" ||
                     txtfechaNacimientoEstud.Text == "")
                {
                    messageError.lblError.Text = "Debe llenar los campos necesarios";
                    messageError.ShowDialog();

                }
                else
                {


                    if (mktIdentidadEstud.Text.Length > 13 || mktIdentidadEstud.Text.Length < 13)
                    {
                        messageError.lblError.Text = "Error en la identidad";
                        messageError.ShowDialog();


                    }
                    else
                    {
                        if (cmbGeneroEstud.SelectedIndex == -1)
                        {
                            messageError.lblError.Text = "DEBE SELECCIONAR EL GÉNERO";
                            messageError.ShowDialog();
                        }
                        else
                        {
                            if (utilidad.isDate(txtfechaNacimientoEstud.Text))
                            {
                                string genero;
                                identidadEstudiante = mktIdentidadEstud.Text;
                                genero = Genero(cmbGeneroEstud);

                                if (cmbGeneroEstud.SelectedIndex != 0)
                                {
                                    try
                                    {
                                        messageQuestion.lblError.Text = "¿Esta seguro de los datos ingresados?";
                                        messageQuestion.ShowDialog();
                                        if (IMessageBoxYesCancel.isCodigoForm)
                                        {
                                            if (dbConn.obtenerVariableEntera("select estado from datosEstudiante where identidadEstudiante = '" + mktIdentidadEstud.Text + "'") != 1)
                                            {

                                                EstudianteMatricula[0, 0] = mktIdentidadEstud.Text;
                                                EstudianteMatricula[0, 1] = txtprimerNombreEstud.Text;
                                                EstudianteMatricula[0, 2] = txtsegundoNombreEstud.Text;
                                                EstudianteMatricula[0, 3] = txtprimerApellidoEstud.Text;
                                                EstudianteMatricula[0, 4] = txtsegundoApellidoEstud.Text;
                                                EstudianteMatricula[0, 5] = txtfechaNacimientoEstud.Text;
                                                EstudianteMatricula[0, 6] = genero;

                                                message.lblCheck.Text = "ESTUDIANTE REGISTRADO";
                                                message.ShowDialog();

                                                LimpiarEstudiante();
                                                grpRegistroEstudiante.Visible = false;
                                                grpRegistroEncargados.Visible = true;

                                            }
                                            else
                                            {
                                                messageError.lblError.Text = "EL ESTUDIANTE YA EXISTE";
                                                messageError.lblError.Location = new Point(120, 82);
                                                messageError.ShowDialog();
                                            }
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                }
                                else
                                {
                                    messageError.lblError.Text = "SELECCIONE CORRECTAMENTE\n  EL GÉNERO";
                                    messageError.lblError.Location = new Point(120, 82);
                                    messageError.ShowDialog();
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
            cmbGeneroEstud.SelectedIndex = 0;
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

            try
            {
                if (!dbConn.PARegistrarEstudiante(EstudianteMatricula[0, 0], EstudianteMatricula[0, 1],
                   EstudianteMatricula[0, 2], EstudianteMatricula[0, 3], EstudianteMatricula[0, 4],
                    EstudianteMatricula[0, 5], EstudianteMatricula[0, 6]))
                {
                    messageError.lblError.Text = "Error al Registrar";
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
            else if (CMB.SelectedItem.ToString() == "Femenino")
            {
                return "F";
            }
            else
            {
                return "";
            }

         }

        private void txtprimerNombreEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }

        private void txtsegundoNombreEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }

        private void txtprimerApellidoEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }

        private void txtsegundoApellidoEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }

        //Metodos y validaciones De registro de  Encargado
        private void txtPrimerNombreEncarg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }

        private void txtSegundoNombreEncarg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }

        private void txtPrimerApellidoEncarg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }

        private void txtSegundoApellidoEncarg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }

        private void txtprimerTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelefonoAlternativo_KeyPress(object sender, KeyPressEventArgs e)
        {

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
                string identidadComparar;
                int Numfilas = encargados.Rows.Count;


                      
                if (mktIdentidadEncargado.Text == "" || txtPrimerNombreEncarg.Text == "" || txtPrimerApellidoEncarg.Text == "" ||
                         txtcorreoElectronico.Text == "" || txtprimerTelefono.Text == "" ||
                         txtTelefonoAlternativo.Text == "" || txtDireccion.Text == "" || mskFechaNacimientoEncarg.Text == "")
                {
                            messageError.lblError.Text = "DEBE LLENAR LOS CAMPOS NECESARIOS";
                            messageError.lblError.Location = new Point(120, 82);
                            messageError.ShowDialog();
                }    
                else
                {
                    if (mktIdentidadEncargado.Text.Length > 13 || mktIdentidadEncargado.Text.Length < 13)
                    
                    {
                            messageError.lblError.Text = "Error en la identidad";
                            messageError.ShowDialog();

                    
                    }
                    else 
                    { 
                    
                        if (utilidad.verificarCorreo(txtcorreoElectronico.Text))
                        {
                            if (utilidad.isDate(mskFechaNacimientoEncarg.Text))
                            {
                                if (txtprimerTelefono.Text.Length == 8 && txtTelefonoAlternativo.Text.Length == 8)
                                {

                                    messageQuestion.lblError.Text = "¿Esta seguro de los datos ingresados?";
                                    messageQuestion.ShowDialog();
                                    if (IMessageBoxYesCancel.isCodigoForm)
                                    {
                                        if (Numfilas == 0)
                                        {
                                            encargados.Rows.Add(new Object[]{ identidadEstudiante, mktIdentidadEncargado.Text, txtPrimerNombreEncarg.Text,
                                        txtSegundoNombreEncarg.Text, txtPrimerApellidoEncarg.Text, txtSegundoApellidoEncarg.Text, txtcorreoElectronico.Text,
                                        txtprimerTelefono.Text, txtTelefonoAlternativo.Text, txtDireccion.Text, mskFechaNacimientoEncarg.Text });

                                            message.lblCheck.Text = "Encargado Registrado";
                                            message.ShowDialog();
                                            Encargados++;

                                        }
                                        else
                                        {
                                            for (int i = 0; i < Numfilas; i++)
                                            {

                                                identidadComparar = encargados.Rows[i][1].ToString();

                                                if (mktIdentidadEncargado.Text.Equals(identidadComparar))
                                                {
                                                    Existe = 1;
                                                }

                                            }

                                            if (Existe == 1)
                                            {
                                                messageError.lblError.Text = "YA AGREGO ESTE ENCARGADO";
                                                messageError.lblError.Location = new Point(120, 82);
                                                messageError.ShowDialog();
                                                Existe = 0;
                                            }
                                            else
                                            {

                                                encargados.Rows.Add(new Object[]{ identidadEstudiante, mktIdentidadEncargado.Text, txtPrimerNombreEncarg.Text,
                                            txtSegundoNombreEncarg.Text, txtPrimerApellidoEncarg.Text, txtSegundoApellidoEncarg.Text, txtcorreoElectronico.Text,
                                            txtprimerTelefono.Text, txtTelefonoAlternativo.Text, txtDireccion.Text, mskFechaNacimientoEncarg.Text });

                                                message.lblCheck.Text = "Encargado Registrado";
                                                message.ShowDialog();
                                            }
                                        }
                                    }

                                  

                                }
                                else
                                {
                                    messageError.lblError.Text = "INGRESE CORRECTAMENTE LOS\nNUMEROS DE TELÉFONO";
                                    messageError.lblError.Location = new Point(120, 82);
                                    messageError.ShowDialog();
                                }
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
                int Numfilas = encargados.Rows.Count;
                for (int i = 0; i < Numfilas; i++)
                {
                    if(!dbConn.PARegistroEncargado(encargados.Rows[i][0].ToString(), encargados.Rows[i][1].ToString(), encargados.Rows[i][2].ToString(), encargados.Rows[i][3].ToString(),
                        encargados.Rows[i][4].ToString(), encargados.Rows[i][5].ToString(), encargados.Rows[i][6].ToString(), encargados.Rows[i][7].ToString(),
                        encargados.Rows[i][8].ToString(), encargados.Rows[i][9].ToString(), encargados.Rows[i][10].ToString()))
                        {
                        messageError.lblError.Text = "Error al Registrar Encargado";
                        messageError.ShowDialog();
                    }                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        private void btnSiguienteEncarg_Click_1(object sender, EventArgs e)
        {
          
            if (encargados.Rows.Count != 0)  
            {
                    messageQuestion.lblError.Text = "¿Esta seguro de continuar?";
                    messageQuestion.ShowDialog();
                    if (IMessageBoxYesCancel.isCodigoForm)
                    {
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

        private void grpRegistroEncargados_Enter(object sender, EventArgs e)
        {

        }

        private void cmbEncargadosReingreso_SelectedIndexChanged(object sender, EventArgs e)
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

        private void txtIdentidadEstudMod_TextChanged(object sender, EventArgs e)
        {
        }


        private void limpiarModificaciones()
        {
            txtIdentidadEstudMod.Clear();
            txtPrimerNombreEstudMod.Clear();
            txtSegundoNombreEstudMod.Clear();
            txtPrimerApellidoEstudMod.Clear();
            txtSegundoApellidoEstudMod.Clear();
            txtFechaNacimientoEstudMod.Clear();
            cmbgeneroEstudMod.SelectedIndex = -1;
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
                    if (txtPrimerNombreEstudMod.Text == "" || txtPrimerApellidoEstudMod.Text == "")
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

        private void btnEliminarEncargado_Click(object sender, EventArgs e)
        {
            int cantidadEncargados = dbConn.obtenerVariableEntera("select count(*) from detalleEncargado where id_Estudiante = '" + identidadEstudianteModDatos + "'");
            try
            {
               
                    if (cantidadEncargados == 1)
                    {

                        messageWarning.lblError.Text = "No Puede dejar sin encargados\nal estudiante";
                        messageWarning.ShowDialog();
                    }
                    else
                    {
                    messageQuestion.lblError.Text = "¿Esta seguro de los datos ingresados?";
                    messageQuestion.ShowDialog();
                    if (IMessageBoxYesCancel.isCodigoForm)
                    {

                        dbConn.ejecutarComandoSQL("DELETE FROM detalleEncargado WHERE id_encargadoAlumno = '" + txtIdentidadEncargadoMod.Text + "' and id_Estudiante = '" + identidadEstudianteModDatos + "'");
                        message.lblCheck.Text = "ENCARGADO ELIMINADO";
                        message.ShowDialog();

                    }
                    }

                
                cmbEncargadosReingreso.Items.Clear();
                txtIdentidadEstudianteR.Text = identidadEstudianteModDatos;

                limpiarModificaciones();
                grpReingreso.Visible = true;
                gbEncargados.Visible = false;

            

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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

                        messageError.lblError.Text = "LLENE TODOS LOS CAMPOS NECESARIOS";
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

        private void txtprimerNombreEncargadoMod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtsegundoNombreEncargadoMod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtprimerApellidoEncargadoMod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtsegundoApellidoEncargadoMod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelefonoEncargadoMod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtsegundoTelefonoEncargadoMod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPrimerNombreEstudMod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSegundoNombreEstudMod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPrimerApellidoEstudMod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSegundoApellidoEstudMod_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnActualizarEliminarEncargado_Click(object sender, EventArgs e)
        {
            if (txtIdentidadEncargadoR.Text == "")
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
                txtTelefonoEncargadoMod.Text = dbConn.obtenerVariableString("select numeroTelefono from datosEncargado where identidadEncargado = '" + txtIdentidadEncargadoMod.Text + "'");
                txtsegundoTelefonoEncargadoMod.Text = dbConn.obtenerVariableString("select numeroTelefonoAlt from datosEncargado where identidadEncargado = '" + txtIdentidadEncargadoMod.Text + "'");
                dbConn.llenarTextBox(txtDireccionEncargadoMod, "select direccionTrabajo from datosEncargado where identidadEncargado = '" + txtIdentidadEncargadoMod.Text + "'");
            }
        }

        private void limpiarEncargadoAgregado()
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

        private void btnLimpiarEncargadoMat_Click(object sender, EventArgs e)
        {
            limpiarEncargadoAgregado();
        }

        private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSeccion.SelectedIndex != 0)
            {
                idSeccion = dbConn.obtenerVariableEntera("select id_Seccion from seccion inner join cursos on seccion.id_Curso = cursos.id_Curso where estado = 1 and cursos.nombreCurso = '" + cmbCurso.SelectedItem.ToString() + "' and seccion.nombreSeccion = '" + cmbSeccion.SelectedItem.ToString() + "'");


            }
            else {
                idSeccion = 0;
            }

        }

        private void cmbSeccionR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSeccionR.SelectedIndex != 0)
            {
                idSeccion = dbConn.obtenerVariableEntera("select id_Seccion from seccion inner join cursos on seccion.id_Curso = cursos.id_Curso where estado = 1 and cursos.nombreCurso = '" + cmbCursoR.SelectedItem.ToString() + "' and seccion.nombreSeccion = '" + cmbSeccionR.SelectedItem.ToString() + "'");

            }
            else
            {
                idSeccion = 0;
            }
        }

        private void btnRegresarEstudianteMod_Click(object sender, EventArgs e)
        {
            gbEstudiantes.Visible = false;
            grpReingreso.Visible = true;
            cmbEncargadosReingreso.Items.Clear();
            txtIdentidadEstudianteR.Text = identidadEstudianteModDatos;
            identidadEncargadoModDatos = "";
            identidadEstudianteModDatos = "";
            limpiarModificaciones();
        }

        private void txtIdentidadEstudMod_TextChanged_1(object sender, EventArgs e)
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
                cmbgeneroEstudMod.SelectedItem = "Masculino";
            }
            else if (genero == "F")
            {
                cmbgeneroEstudMod.SelectedItem = "Femenino";
            }
            else
            {
                cmbgeneroEstudMod.SelectedIndex = -1;
            }
        }

        private void txtBusquedaIdentidadEstado_TextChanged_1(object sender, EventArgs e)
        {

            long number = 0;

            if (txtBusquedaIdentidadEstado.Text != string.Empty)
            {

                if ((long.TryParse(txtBusquedaIdentidadEstado.Text, out number) && Regex.IsMatch(txtBusquedaIdentidadEstado.Text, @"^[a-z A-Z]+$") == false) || (Regex.IsMatch(txtBusquedaIdentidadEstado.Text, @"^[a-z A-Z]+$") && long.TryParse(txtBusquedaIdentidadEstado.Text, out number) == false))
                {
                    txtBusquedaIdentidadEstado.ForeColor = Color.Green;
                    errorIdentidad.Clear();
                    dbConn.llenarDGV(dgvBusquedaEstado, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero' FROM datosEstudiante WHERE identidadEstudiante LIKE '" + txtBusquedaIdentidadEstado.Text + "%' OR CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) LIKE '" + txtBusquedaIdentidadEstado.Text + "%'");
                }
                else
                {
                    txtBusquedaIdentidadEstado.ForeColor = Color.Red;
                    errorIdentidad.SetError(this.txtBusquedaIdentidadEstado, "Ingrese valores correctos!");
                    dgvBusquedaEstado.DataSource = null;
                }
            }
            else
            {
                dbConn.llenarDGV(dgvBusquedaEstado, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero' FROM datosEstudiante");

            }
        }

        private void txtBusquedaNombre_TextChanged_1(object sender, EventArgs e)
        {

            try
            {
                long number = 0;

                if (txtBusquedaNombre.Text != string.Empty)
                {

                    if ((long.TryParse(txtBusquedaNombre.Text, out number) && Regex.IsMatch(txtBusquedaNombre.Text, @"^[a-z A-Z]+$") == false) || (Regex.IsMatch(txtBusquedaNombre.Text, @"^[a-z A-Z]+$") && long.TryParse(txtBusquedaNombre.Text, out number) == false))
                    {
                        txtBusquedaNombre.ForeColor = Color.Green;
                        errorIdentidad.Clear();
                        dbConn.llenarDGV(dgvEstudiantes, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero' FROM datosEstudiante WHERE CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) LIKE '" + txtBusquedaNombre.Text + "%' OR identidadEstudiante LIKE '" + txtBusquedaNombre.Text + "%'");
                    }
                    else
                    {
                        txtBusquedaNombre.ForeColor = Color.Red;
                        errorIdentidad.SetError(this.txtBusquedaNombre, "Ingrese valores correctos!");
                        dgvBusquedaEstado.DataSource = null;
                    }
                }
                else
                {
                    dbConn.llenarDGV(dgvBusquedaEstado, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre'  FROM datosEstudiante");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cmbGeneroEstud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            try
            {

                decimal total;
                double TotalPagar = dbConn.obtenerVariableDouble("SELECT precioCompleto FROM cursos WHERE nombreCurso = '" + cmbCurso.SelectedItem + "'");

                if (txtDescuento.Text == "" || txtDescuento.Text == "0.00")
                {
                    txtTotalPagar.Text = dbConn.obtenerVariableDouble("SELECT precioCompleto FROM cursos WHERE nombreCurso = '" + cmbCurso.SelectedItem + "'").ToString();

                }
                else
                {
                    total = (decimal.Parse(TotalPagar.ToString()) - decimal.Parse(txtDescuento.Text));
                    total = decimal.Round(total, 3);
 

                    if (total > 100)
                    {
                        txtTotalPagar.Text = total.ToString();
                    }
                    else if (total <= 100)
                    {
                        txtTotalPagar.Text = "" + 100;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void txtDescuentoR_TextChanged(object sender, EventArgs e)
        {
            try
            {
            decimal total;
            double TotalPagar = dbConn.obtenerVariableDouble("SELECT precioCompleto FROM cursos WHERE nombreCurso = '" + cmbCursoR.SelectedItem + "'");

            if (txtDescuentoR.Text == "" || txtDescuentoR.Text == "0.00")
            {
                txtTotalR.Text = dbConn.obtenerVariableDouble("SELECT precioCompleto FROM cursos WHERE nombreCurso = '" + cmbCursoR.SelectedItem + "'").ToString();

            }
            else
            {
                total = (decimal.Parse(TotalPagar.ToString()) - decimal.Parse(txtDescuentoR.Text));
                total = decimal.Round(total, 3);
                
                    if(total > 100)
                    {
                        txtTotalR.Text = total.ToString();
                    }
                    else if(total <= 100)
                    {

                        txtTotalR.Text = "" + 100;
                    }
            }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '.')
                {
                    if (((TextBox)sender).Text.Contains('.'))
                        e.Handled = true;
                    else
                        e.Handled = false;
                }
            }
        }

        private void txtDescuentoR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '.')
                {
                    if (((TextBox)sender).Text.Contains('.'))
                        e.Handled = true;
                    else
                        e.Handled = false;
                }
            }
        }

        private void btnImagenAgregarR_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Imagen JPG|*.JPG|Imagen PNG|*.PNG";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image = Image.FromFile(fileDialog.FileName);
            }
        }

        private void btnVerImagenR_Click(object sender, EventArgs e)
        {
            frmMostrarImagenEvidencia frmImagen = new frmMostrarImagenEvidencia();
            frmImagen.Text = "Boleta de calificaciones";
            if (image != null)
            {
                frmImagen.pictureBox1.Image = image;
            }
            else
            {
                frmImagen.pictureBox1.Image = Properties.Resources.imgComprobantePendiente;
            }
            frmImagen.label2.Text = "BOLETA DE CALIFICACIONES INGRESADA";
            frmImagen.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            frmImagen.Show();
        }

        private void btnAgregarImagenPI_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Imagen JPG|*.JPG|Imagen PNG|*.PNG";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image = Image.FromFile(fileDialog.FileName);
            }
        }

        private void btnVerImagenPI_Click(object sender, EventArgs e)
        {
            frmMostrarImagenEvidencia frmImagen = new frmMostrarImagenEvidencia();
            frmImagen.Text = "Boleta de calificaciones";
            if (image != null)
            {
                frmImagen.pictureBox1.Image = image;
            }
            else
            {
                frmImagen.pictureBox1.Image = Properties.Resources.imgComprobantePendiente;
            }
            frmImagen.label2.Text = "BOLETA DE CALIFICACIONES INGRESADA ";
            frmImagen.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            frmImagen.Show();
        }

        private void btnRegresarAEstud_Click(object sender, EventArgs e)
        {

            messageQuestion.lblError.Text = "¿Esta seguro de Regresar? Los encargados\n agregados y el estudiante se perderan.";
            messageQuestion.ShowDialog();
            if (IMessageBoxYesCancel.isCodigoForm)
            {
                grpRegistroEncargados.Visible = false;
                grpRegistroEstudiante.Visible = true;
                encargados.Clear();
                limpiarEncargadoAgregado();
            }

        }

        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                identidadReingreso = dgvEstudiantes.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dgvBusquedaEstado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                identidadActualizacion = dgvBusquedaEstado.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
