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
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageError.lblError.Text = "INGRESE CORRECTAMENTE LOS DATOS";
                messageError.ShowDialog();
                e.Handled = true;
                return;
            }
        }

        private void txtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageError.lblError.Text = "INGRESE CORRECTAMENTE LOS DATOS";
                messageError.ShowDialog();
                e.Handled = true;
                return;
            }
        }

        private void txtprimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageError.lblError.Text = "INGRESE CORRECTAMENTE LOS DATOS";
                messageError.ShowDialog();
                e.Handled = true;
                return;
            }
        }

        private void txtsegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageError.lblError.Text = "INGRESE CORRECTAMENTE LOS DATOS";
                messageError.ShowDialog();
                e.Handled = true;
                return;
            }
        }

        private void txtprimerTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageError.lblError.Text = "INGRESE CORRECTAMENTE LOS DATOS";
                messageError.ShowDialog();
                e.Handled = true;
                return;
            }
        }

        private void txtsegundoTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageError.lblError.Text = "INGRESE CORRECTAMENTE LOS DATOS";
                messageError.ShowDialog();
                e.Handled = true;
                return;
            }
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
            btnEstudiantes.Visible = false;
            btnEncargados.Visible = false;
            lblGestionEncargadosEstudiantes.Visible = false;
            gbListadoEncargado.Visible = true;
        }

        private void btnRegresarEncargado_Click(object sender, EventArgs e)
        {
            gbListadoEncargado.Visible = false;
            gbEncargados.Visible = false;
            btnEstudiantes.Visible = true;
            btnEncargados.Visible = true;
            lblGestionEncargadosEstudiantes.Visible = true;
            limpiarPantalla();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentidad.TextLength > 13 || txtIdentidad.TextLength < 13)
                {
                    messageError.lblError.Text = "INGRESE CORRECTAMENTE LA IDENTIDAD";
                    messageError.ShowDialog();
                    limpiarPantalla();
                }
                else
                {

                    if (txtprimerNombre.Text == "" || txtsegundoNombre.Text == "" || txtprimerApellido.Text == "" || txtsegundoApellido.Text == "" ||
                                       txtCorreoElectronico.Text == "" || txtprimerTelefono.Text == "" || txtsegundoTelefono.Text == "" || txtDireccion.Text == "")
                    {
                   
                        messageError.lblError.Text = "LLENE LOS CAMPOS SOLICITADOS";
                        messageError.ShowDialog();
                    }
                    else
                    {
                        ActualizarEncargado();
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
                if (txtIdentidad.TextLength > 13 || txtIdentidad.TextLength < 13)
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

        private void dgvBusquedaEncargado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            identidadEncargado = dgvBusquedaEncargado.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnSiguienteEncargado_Click(object sender, EventArgs e)
        {
            if (identidadEncargado != "")
            {

                txtIdentidad.Text = identidadEncargado;
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
            dbConn.llenarTextBox(txtprimerNombre, "select primerNombre from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'");
            dbConn.llenarTextBox(txtsegundoNombre, "select segundoNombre from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'");
            dbConn.llenarTextBox(txtprimerApellido, "select primerApellido from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'");
            dbConn.llenarTextBox(txtsegundoApellido, "select segundoApellido from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'");
            dbConn.llenarTextBox(txtCorreoElectronico, "select correoElectronico from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'");
            txtfechaNacimiento.Text = dbConn.obtenerVariableDate("select fechaNacimiento from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'").ToString("dd/MM/yyyy");
            dbConn.llenarTextBox(txtprimerTelefono, "select numeroTelefono from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'");
            dbConn.llenarTextBox(txtsegundoTelefono, "select numeroTelefonoAlt from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'");
            dbConn.llenarTextBox(txtDireccion, "select direccionTrabajo from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'");

        }

        private void txtLikeIdentidad_TextChanged(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvBusquedaEncargado, "SELECT id_encargadoAlumno as 'ID', identidadEncargado as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ' , segundoApellido)as 'Nombre', numeroTelefono as 'Teléfono 1', numeroTelefonoAlt as 'Teléfono 2', correoElectronico as 'Correo Electronico', direccionTrabajo as 'Dirección', fechaNacimiento as 'Fecha de Nacimiento' FROM datosEncargado WHERE CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) LIKE '" + txtLikeIdentidad.Text + "%' and estado = 1 or identidadEncargado LIKE '" + txtLikeIdentidad.Text + "%' and estado = 1");

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            gbListadoEncargado.Visible = false;
            gbEncargados.Visible = false;
            btnEstudiantes.Visible = true;
            btnEncargados.Visible = true;
            lblGestionEncargadosEstudiantes.Visible = true;
            limpiarPantalla();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            gbListadoEstudiantes.Visible = true;
            btnEstudiantes.Visible = false;
            btnEncargados.Visible = false;
            lblGestionEncargadosEstudiantes.Visible = false;

        }

        private void txtLikeidentidadEstud_TextChanged(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvListadoEstudiantes, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero', estado as 'Estado' FROM datosEstudiante WHERE CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ' , segundoApellido) LIKE '" + txtLikeidentidadEstud.Text + "%' and estado = 1 or identidadEstudiante LIKE '" + txtLikeidentidadEstud.Text + "%' and estado = 1");
        }

        private void btnRegresarEstud_Click(object sender, EventArgs e)
        {
            gbListadoEstudiantes.Visible = false;
            gbEncargados.Visible = false;
            btnEstudiantes.Visible = true;
            btnEncargados.Visible = true;
            lblGestionEncargadosEstudiantes.Visible = true;
            limpiarPantalla();
        }

        private void btnRegresarEstudiante_Click(object sender, EventArgs e)
        {
            gbEstudiantes.Visible = false;
            gbListadoEstudiantes.Visible = false;
            btnEstudiantes.Visible = true;
            btnEncargados.Visible = true;
            lblGestionEncargadosEstudiantes.Visible = true;
            limpiarPantalla();
        }
        private void dgvListadoEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            identidadEstudiante = dgvListadoEstudiantes.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnSiguienteEstud_Click(object sender, EventArgs e)
        {
            if (identidadEstudiante != "")
            {

                txtIdentidadEstud.Text = identidadEstudiante;
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
                if (txtIdentidadEstud.TextLength > 13 || txtIdentidadEstud.TextLength < 13)
                {
                    messageError.lblError.Text = "INGRESE CORRECTAMENTE LA IDENTIDAD";
                    messageError.ShowDialog();
                    limpiarPantalla();
                }
                else
                {
                    if (txtprimerNombreEstud.Text == "" && txtsegundoNombreEstud.Text == "" && txtprimerApellidoEstud.Text == "" && txtsegundoApellidoEstud.Text == "")
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

        private void btnEliminarEstud_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentidadEstud.TextLength > 13 || txtIdentidadEstud.TextLength < 13)
                {

                    messageError.lblError.Text = "INGRESE CORRECTAMENTE LA IDENTIDAD";
                    messageError.ShowDialog(); 
                    limpiarPantalla();
                }
                else
                {
                    EliminarEstudiante();
                }
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
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageError.lblError.Text = "INGRESE CORRECTAMENTE LOS DATOS";
                messageError.ShowDialog();
                e.Handled = true;
                return;
            }
        }

        private void txtprimerNombreEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageError.lblError.Text = "INGRESE CORRECTAMENTE LOS DATOS";
                messageError.ShowDialog(); 
                e.Handled = true;
                return;
            }
        }

        private void txtsegundoNombreEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageError.lblError.Text = "INGRESE CORRECTAMENTE LOS DATOS";
                messageError.ShowDialog(); 
                e.Handled = true;
                return;
            }
        }

        private void txtprimerApellidoEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageError.lblError.Text = "INGRESE CORRECTAMENTE LOS DATOS";
                messageError.ShowDialog(); 
                e.Handled = true;
                return;
            }
        }

        private void txtsegundoApellidoEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                messageError.lblError.Text = "INGRESE CORRECTAMENTE LOS DATOS";
                messageError.ShowDialog(); 
                e.Handled = true;
                return;
            }
        }

        private void txtIdentidadEstud_TextChanged(object sender, EventArgs e)
        {
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
            else if(genero == "F")
            {
                cmbgeneroEstudiante.SelectedItem = "F";
            }
            else
            {
                cmbgeneroEstudiante.SelectedIndex = -1;
            }
        }
    }
}