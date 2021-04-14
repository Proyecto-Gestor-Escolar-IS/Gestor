using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using SistemaGestorEscolar.MessageBox_Personalizados;
using SistemaGestorEscolar.Utilidades;

namespace SistemaGestorEscolar.Modulos_Encargado
{
    public partial class CrudEstudianteEncargado : Form
    {
        public CrudEstudianteEncargado()
        {
            InitializeComponent();
        }
        databaseConnection dbConn = new databaseConnection();
        IMessageBoxCheck message = new IMessageBoxCheck();
        IMessageBoxError messageError = new IMessageBoxError();
        IMessageBoxWarning messageWarning = new IMessageBoxWarning();
        IMessageBoxYesCancel messageQuestion = new IMessageBoxYesCancel();
        clsUtilidades utilidad = new clsUtilidades();

        string identidadEncargado = "";
        string identidadEstudiante = "";

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbldireccion_Click(object sender, EventArgs e)
        {

        }

        private void lblfechaNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void txtfechaNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprimerTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsegundoTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbltelefonos_Click(object sender, EventArgs e)
        {

        }

        public void ActualizarEncargado()
        {
           
            try
            {
                if (dbConn.PAActualizarEncargado(txtIdentidad.Text, txtprimerNombre.Text, txtsegundoNombre.Text, txtprimerApellido.Text, txtsegundoApellido.Text, txtCorreoElectronico.Text, txtprimerTelefono.Text, txtsegundoTelefono.Text, txtDireccion.Text))
                {
                    message.lblCheck.Text = "ENCARGADO ACTUALIZADO";
                    message.ShowDialog();
               
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


        public void EliminarEncargado()
        {
            if (dbConn.ComprobarExistencia("select estado from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'"))
            {
                dbConn.ejecutarComandoSQL("update datosEncargado set estado = 2 where identidadEncargado = '" + txtIdentidad.Text + "'");

                message.lblCheck.Text = "ENCARGADO ELIMINADO";
                message.ShowDialog();
            }
            else
            {
                 messageError.lblError.Text = "ENCARGADO NO ENCONTRADO";
                 messageError.ShowDialog();
            }
        }

        private void txtprimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
 
        }

        private void txtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtprimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtsegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtprimerTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtsegundoTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtIdentidad_TextChanged(object sender, EventArgs e)
        {

        }



        private void limpiarPantalla()
        {
            txtLikeidentidadEstud.Clear();
            txtLikeIdentidad.Clear();
            txtIdentidad.Clear();
            txtprimerNombre.Clear();
            txtsegundoNombre.Clear();
            txtprimerApellido.Clear();
            txtsegundoApellido.Clear();
            txtCorreoElectronico.Clear();
            txtprimerTelefono.Clear();
            txtsegundoTelefono.Clear();
            txtfechaNacimiento.Clear();
            txtDireccion.Clear();
            dgvBusquedaEncargado.DataSource = null;
            dgvListadoEstudiantes.DataSource = null;
            txtIdentidadEstud.Clear();
            txtprimerNombreEstud.Clear();
            txtsegundoNombreEstud.Clear();
            txtprimerApellidoEstud.Clear();
            txtsegundoApellidoEstud.Clear();
            txtFechaNacimientocEstud.Clear();
            cmbgeneroEstudiante.SelectedItem = -1;

        }

        private void btnEncargados_Click(object sender, EventArgs e)
        {
            gbListadoEncargado.Visible = true;
            pnlGestionEstudianteEncargado.Visible = false;
            dbConn.llenarDGV(dgvBusquedaEncargado, "SELECT identidadEncargado as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ' , segundoApellido)as 'Nombre', numeroTelefono as 'Teléfono 1', numeroTelefonoAlt as 'Teléfono 2', correoElectronico as 'Correo Electronico', direccionTrabajo as 'Dirección', fechaNacimiento as 'Fecha de Nacimiento' FROM datosEncargado WHERE CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) LIKE '" + txtLikeIdentidad.Text + "%' and estado = 1 or identidadEncargado LIKE '" + txtLikeIdentidad.Text + "%' and estado = 1");

        }

        private void btnRegresarEncargado_Click(object sender, EventArgs e)
        {
            gbListadoEncargado.Visible = false;
            gbEncargados.Visible = false;
            pnlGestionEstudianteEncargado.Visible = true;
            txtIdentidad.ReadOnly = true;
            txtfechaNacimiento.ReadOnly = true;
            btnAgregarNuevoEncargado.Visible = false;
            btnAgregarNuevoEncargado.Enabled = false;
            btnLimpiar.Visible = false;
            btnLimpiar.Enabled = false;
            btnActualizar.Visible = true;
            btnEliminar.Visible = true;
            limpiarPantalla();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentidad.Text.Length > 13 || txtIdentidad.Text.Length < 13)
                {
                    messageError.lblError.Text = "INGRESE CORRECTAMENTE LA IDENTIDAD";
                    messageError.ShowDialog();
             
                }
                else
                {

                    if (txtprimerNombre.Text == "" || txtprimerApellido.Text == "" || txtCorreoElectronico.Text == "" || txtprimerTelefono.Text == "" || txtsegundoTelefono.Text == "" || txtDireccion.Text == "")
                    {
                   
                        messageError.lblError.Text = "LLENE LOS CAMPOS SOLICITADOS";
                        messageError.ShowDialog();
                    }
                    else
                    {

                        if (utilidad.verificarCorreo(txtCorreoElectronico.Text))
                        {

                            ActualizarEncargado();

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentidad.Text.Length > 13 || txtIdentidad.Text.Length < 13)
                {
                    messageError.lblError.Text = "INGRESE CORRECTAMENTE LA IDENTIDAD";
                    messageError.ShowDialog();
                 
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

        private void dgvBusquedaEncargado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                identidadEncargado = dgvBusquedaEncargado.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



        private void btnSiguienteEncargado_Click(object sender, EventArgs e)
        {
            if (identidadEncargado != "")
            {

                txtIdentidad.Text = identidadEncargado;
                dbConn.llenarTextBox(txtprimerNombre, "select primerNombre from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'");
                dbConn.llenarTextBox(txtsegundoNombre, "select segundoNombre from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'");
                dbConn.llenarTextBox(txtprimerApellido, "select primerApellido from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'");
                dbConn.llenarTextBox(txtsegundoApellido, "select segundoApellido from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'");
                dbConn.llenarTextBox(txtCorreoElectronico, "select correoElectronico from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'");
                txtfechaNacimiento.Text = dbConn.obtenerVariableDate("select fechaNacimiento from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'").ToString("dd/MM/yyyy");
                txtprimerTelefono.Text = dbConn.obtenerVariableString("select numeroTelefono from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'");
                txtsegundoTelefono.Text = dbConn.obtenerVariableString("select numeroTelefonoAlt from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'");
                dbConn.llenarTextBox(txtDireccion, "select direccionTrabajo from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'");

                gbListadoEncargado.Visible = false;
                gbEncargados.Visible = true;
            }
            else
            {
                messageWarning.lblError.Text = "SELECCIONE UN ENCARGADO";
                messageWarning.ShowDialog();
            }
        }

        private void txtIdentidad_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtLikeIdentidad_TextChanged(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvBusquedaEncargado, "SELECT identidadEncargado as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ' , segundoApellido)as 'Nombre', numeroTelefono as 'Teléfono 1', numeroTelefonoAlt as 'Teléfono 2', correoElectronico as 'Correo Electronico', direccionTrabajo as 'Dirección', fechaNacimiento as 'Fecha de Nacimiento' FROM datosEncargado WHERE CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) LIKE '" + txtLikeIdentidad.Text + "%' and estado = 1 or identidadEncargado LIKE '" + txtLikeIdentidad.Text + "%' and estado = 1");

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            gbListadoEncargado.Visible = false;
            gbEncargados.Visible = false;
            pnlGestionEstudianteEncargado.Visible = true;
            limpiarPantalla();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            gbListadoEstudiantes.Visible = true;
            pnlGestionEstudianteEncargado.Visible = false;
            dbConn.llenarDGV(dgvListadoEstudiantes, "SELECT identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero' FROM datosEstudiante WHERE CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ' , segundoApellido) LIKE '" + txtLikeidentidadEstud.Text + "%' and estado = 1 or identidadEstudiante LIKE '" + txtLikeidentidadEstud.Text + "%' and estado = 1");


        }

        private void txtLikeidentidadEstud_TextChanged(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvListadoEstudiantes, "SELECT identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero' FROM datosEstudiante WHERE CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ' , segundoApellido) LIKE '" + txtLikeidentidadEstud.Text + "%' and estado = 1 or identidadEstudiante LIKE '" + txtLikeidentidadEstud.Text + "%' and estado = 1");
        }

        private void btnRegresarEstud_Click(object sender, EventArgs e)
        {
            gbListadoEstudiantes.Visible = false;
            gbEncargados.Visible = false;
            pnlGestionEstudianteEncargado.Visible = true;
            limpiarPantalla();
        }

        private void btnRegresarEstudiante_Click(object sender, EventArgs e)
        {
            gbEstudiantes.Visible = false;
            gbListadoEstudiantes.Visible = false;
            pnlGestionEstudianteEncargado.Visible = true;
            limpiarPantalla();
        }
        private void dgvListadoEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            identidadEstudiante = dgvListadoEstudiantes.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnSiguienteEstud_Click(object sender, EventArgs e)
        {
            if (identidadEstudiante != "")
            {

                txtIdentidadEstud.Text = identidadEstudiante;
                string genero;
                txtFechaNacimientocEstud.Text = dbConn.obtenerVariableDate("select fechaNacimiento from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstud.Text + "'").ToString("dd/MM/yyyy");
                dbConn.llenarTextBox(txtprimerNombreEstud, "select primerNombre from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstud.Text + "'");
                dbConn.llenarTextBox(txtsegundoNombreEstud, "select segundoNombre from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstud.Text + "'");
                dbConn.llenarTextBox(txtprimerApellidoEstud, "select primerApellido from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstud.Text + "'");
                dbConn.llenarTextBox(txtsegundoApellidoEstud, "select segundoApellido from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstud.Text + "'");
                genero = dbConn.obtenerVariableString("select genero from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstud.Text + "'");

                if (genero == "M")
                {
                    cmbgeneroEstudiante.SelectedItem = "M";
                }
                else if (genero == "F")
                {
                    cmbgeneroEstudiante.SelectedItem = "F";
                }
                else
                {
                    cmbgeneroEstudiante.SelectedIndex = -1;
                }

                gbListadoEstudiantes.Visible = false;
                gbEstudiantes.Visible = true;
            }
            else
            {
                messageWarning.lblError.Text = "SELECCIONE UN ESTUDIANTE";
                messageWarning.ShowDialog();
            }
        }



        private void btnActualizarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentidadEstud.Text.Length > 13 || txtIdentidadEstud.Text.Length < 13)
                {
                    messageError.lblError.Text = "INGRESE CORRECTAMENTE LA IDENTIDAD";
                    messageError.ShowDialog();
                 
                }
                else
                {
                    if (txtprimerNombreEstud.Text == "" || txtsegundoNombreEstud.Text == "" || txtprimerApellidoEstud.Text == "" || txtsegundoApellidoEstud.Text == "")
                        {
                        messageError.lblError.Text = "INGRESE TODOS LOS DATOS NECESARIOS";
                        messageError.ShowDialog();
                    }
                        else
                        {
                        ActualizarEstudiante();
                        }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ActualizarEstudiante()
        {

            try
            {
                if (dbConn.PAActualizarEstudiante(txtIdentidadEstud.Text, txtprimerNombreEstud.Text, txtsegundoNombreEstud.Text, txtprimerApellidoEstud.Text, txtsegundoApellidoEstud.Text))
                {
                    message.lblCheck.Text = "ESTUDIANTE ACTUALIZADO";
                    message.ShowDialog();
               
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

        private void btnEliminarEstud_Click(object sender, EventArgs e)
        {
            try
            {
                    EliminarEstudiante();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void EliminarEstudiante()
        {
            if (dbConn.ComprobarExistencia("select estado from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstud.Text + "'"))
            {
                dbConn.ejecutarComandoSQL("update datosEstudiante set estado = 2 where identidadEstudiante = '" + txtIdentidadEstud.Text + "'");

                message.lblCheck.Text = "ESTUDIANTE ELIMINADO";
                message.ShowDialog();
            }
            else
            {
                messageError.lblError.Text = "ESTUDIANTE NO ENCONTRADO";
                messageError.ShowDialog();
            }
        }

        private void txtIdentidadEstud_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtprimerNombreEstud_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtsegundoNombreEstud_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtprimerApellidoEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
 
        }

        private void txtsegundoApellidoEstud_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtIdentidadEstud_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrudEstudianteEncargado_Load(object sender, EventArgs e)
        {
            ClsCambioTema.cambiarTemaBoton(gbEstudiantes);
            ClsCambioTema.cambiarTemaBoton(gbEncargados);
            ClsCambioTema.cambiarTemaBoton(gbListadoEstudiantes);
            ClsCambioTema.cambiarTemaBoton(gbListadoEncargado);
            ClsCambioTema.cambiarTemaBoton(pnlGestionEstudianteEncargado);
            ClsCambioTema.cambiarTemaBoton(gbEncargadosEstudiante);

            if (Properties.Settings.Default.isModoOscuro == true)
            {


                gbEstudiantes.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                gbEncargados.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                gbListadoEstudiantes.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                gbListadoEncargado.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                pnlGestionEstudianteEncargado.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                gbEncargadosEstudiante.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);

            }
            else
            {


                gbEstudiantes.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                gbEncargados.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                gbListadoEstudiantes.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                gbListadoEncargado.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                pnlGestionEstudianteEncargado.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                gbEncargadosEstudiante.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
 

            }


        }

        private void btnEncargadosEstudiante_Click(object sender, EventArgs e)
        {
            gbEncargadosEstudiante.Visible = true;
            pnlGestionEstudianteEncargado.Visible = false;
            dbConn.llenarDGV(dgvEstudiantesDetalle, "SELECT identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero' FROM datosEstudiante WHERE estado = 1");
            dbConn.llenarDGV(dgvEncargadosDetalle, "SELECT identidadEncargado as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ' , segundoApellido)as 'Nombre', direccionTrabajo as 'Dirección', fechaNacimiento as 'Fecha de Nacimiento' FROM datosEncargado WHERE estado = 1");

        }

        private void dgvEncargadosDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdentidadEncargadoDetalle.Text = dgvEncargadosDetalle.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombreEncargadoDetalle.Text = dgvEncargadosDetalle.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void dgvEstudiantesDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdentidadEstudianteDetalle.Text = dgvEstudiantesDetalle.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombreEstudianteDetalle.Text = dgvEstudiantesDetalle.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void txtIdentidadEncargadoDetalle_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtIdentidadEstudianteDetalle_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnRegresarDetalleEncargados_Click(object sender, EventArgs e)
        {
            gbEncargadosEstudiante.Visible = false;
            pnlGestionEstudianteEncargado.Visible = true;
            txtIdentidadEncargadoDetalle.Clear();
            txtIdentidadEstudianteDetalle.Clear();
            txtNombreEncargadoDetalle.Clear();
            txtNombreEstudianteDetalle.Clear();
        }

        private void btnAgregarDetalleEncargados_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentidadEncargadoDetalle.Text == "" || txtIdentidadEstudianteDetalle.Text == "") {
                    messageError.lblError.Text = "DEBE SELECCIONAR UN\nENCARGADO Y ALUMNO";
                    messageError.ShowDialog();
                }
                else
                {
                    if (dbConn.obtenerVariableEntera("select count(*) from detalleEncargado where id_encargadoAlumno = '" + txtIdentidadEncargadoDetalle.Text + "' and  id_Estudiante = '" + txtIdentidadEstudianteDetalle.Text + "'") != 1)
                    {
                        dbConn.ejecutarComandoSQL("INSERT INTO detalleEncargado VALUES('" + txtIdentidadEncargadoDetalle.Text + "','" + txtIdentidadEstudianteDetalle.Text + "')");
                        message.lblCheck.Text = "ENCARGADO AGREGADO\nAL ESTUDIANTE";
                        message.ShowDialog();
                    }
                    else
                    {
                        messageError.lblError.Text = "ESTE ENCARGADO YA EXISTE \nEN ESTE ALUMNO";
                        messageError.ShowDialog();
                    }
                  
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void txtLikeIdentidadEncarDet_TextChanged(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvEncargadosDetalle, "SELECT identidadEncargado as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ' , segundoApellido)as 'Nombre', direccionTrabajo as 'Dirección', fechaNacimiento as 'Fecha de Nacimiento' FROM datosEncargado WHERE CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) LIKE '" + txtLikeIdentidadEncarDet.Text + "%' and estado = 1 or identidadEncargado LIKE '" + txtLikeIdentidadEncarDet.Text + "%' and estado = 1");

        }

        private void txtLikeIdentidadEstudDet_TextChanged(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvEstudiantesDetalle, "SELECT identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero' FROM datosEstudiante WHERE CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ' , segundoApellido) LIKE '" + txtLikeIdentidadEstudDet.Text + "%' and estado = 1 or identidadEstudiante LIKE '" + txtLikeIdentidadEstudDet.Text + "%' and estado = 1");

        }

        private void btnNuevoEncargado_Click(object sender, EventArgs e)
        {
            txtIdentidad.ReadOnly = false;
            txtfechaNacimiento.ReadOnly = false;
            btnActualizar.Visible = false;
            btnEliminar.Visible = false;
            btnAgregarNuevoEncargado.Visible = true;
            btnAgregarNuevoEncargado.Enabled = true;
            btnLimpiar.Visible = true;
            btnLimpiar.Enabled = true;
            gbEncargados.Visible = true;
            gbListadoEncargado.Visible = false;

        }

        private void btnAgregarNuevoEncargado_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentidad.Text.Length > 13 || txtIdentidad.Text.Length < 13)
                {
                    messageError.lblError.Text = "Error en la identidad";
                    messageError.ShowDialog();

                }
                else
                {
                    if (txtprimerNombre.Text == "" || txtprimerApellido.Text == "" ||
                     txtCorreoElectronico.Text == "" || txtprimerTelefono.Text == "" ||
                     txtsegundoTelefono.Text == "" || txtDireccion.Text == "" || txtfechaNacimiento.Text == "")
                    {
                        messageError.lblError.Text = "DEBE LLENAR LOS CAMPOS NECESARIOS";
                        messageError.lblError.Location = new Point(120, 82);
                        messageError.ShowDialog();
                    }
                    else
                    {
                        if (utilidad.verificarCorreo(txtCorreoElectronico.Text))
                        {
                            if (utilidad.isDate(txtfechaNacimiento.Text))
                            {
                                if (txtprimerTelefono.Text.Length == 8 && txtsegundoTelefono.Text.Length == 8)
                                {
                                    RegistrarEncargado();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdentidad.Clear();
            txtprimerNombre.Clear();
            txtsegundoNombre.Clear();
            txtprimerApellido.Clear();
            txtsegundoApellido.Clear();
            txtCorreoElectronico.Clear();
            txtfechaNacimiento.Clear();
            txtprimerTelefono.Clear();
            txtsegundoTelefono.Clear();
            txtDireccion.Clear();
        }

        public void RegistrarEncargado()
        {
            try
            {
                if (dbConn.obtenerVariableEntera("  select count(*) from datosEncargado where identidadEncargado = '"+txtIdentidad.Text+"' and estado = 1") == 0)
                {
                    if (dbConn.ejecutarComandoSQL("INSERT INTO datosEncargado VALUES('"+ txtIdentidad.Text + "', '"+ txtprimerNombre.Text+ "', '"+ txtsegundoNombre.Text + "', '" + txtprimerApellido.Text + "', '"+ txtsegundoApellido.Text+ "', '"+ txtprimerTelefono.Text+ "', '"+ txtsegundoTelefono.Text+ "', '"+ txtCorreoElectronico.Text+ "', '"+txtDireccion.Text+"', '"+ txtfechaNacimiento.Text+ "', 1)"))
                    {

                        message.lblCheck.Text = "ENCARGADO REGISTRADO";
                        message.ShowDialog();

                    }
                    else
                    {
                        messageError.lblError.Text = "ERROR AL REGISTRAR";
                        messageError.ShowDialog();

                    }
                }
                else if (dbConn.obtenerVariableEntera("select count(*) from datosEncargado where identidadEncargado = '"+txtIdentidad.Text+"' and estado = 2") >= 1)
                {
                    if (dbConn.ejecutarComandoSQL("update datosEncargado set primerNombre = '"+ txtprimerNombre .Text+ "', segundoNombre = '"+ txtsegundoNombre .Text + "', primerApellido = '"+ txtprimerApellido.Text + "', segundoApellido = '"+ txtsegundoApellido .Text+ "',correoElectronico = '"+ txtCorreoElectronico .Text+ "', numeroTelefono = '"+ txtprimerTelefono .Text+ "', numeroTelefonoAlt = '"+ txtsegundoTelefono.Text+ "', direccionTrabajo = '"+txtDireccion.Text+"', estado = 1 where identidadEncargado = '" +txtIdentidad.Text+"'"))
                    {

                        message.lblCheck.Text = "ENCARGADO REGISTRADO";
                        message.ShowDialog();

                    }
                    else
                    {
                        messageError.lblError.Text = "ERROR AL REGISTRAR";
                        messageError.ShowDialog();

                    }
                }
                else
                {
                    messageError.lblError.Text = "EL ENCARGADO YA EXISTE";
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