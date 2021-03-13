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
    public partial class IAñadirEncargado : Form
    {
        public IAñadirEncargado()
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
                    MessageBox.Show("Encargado Actualizado Exitosamente", "Actualización Realizada", MessageBoxButtons.OK);
                    limpiarPantalla();
                }
                else
                {
                    MessageBox.Show("Error al Actualizar el Encargado", "Error Inesperado", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }


        public void BuscarEncargado()
        {
            CultureInfo Culture = new CultureInfo("es-ES");
            string fechaNacimiento;












            if (dbConn.ComprobarExistencia("select estado from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'"))
            {
                txtprimerNombre.Text = dbConn.obtenerVariableString("select primerNombre from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "' and estado = 1");
                txtsegundoNombre.Text = dbConn.obtenerVariableString("select segundoNombre from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "' and estado = 1");
                txtprimerApellido.Text = dbConn.obtenerVariableString("select primerApellido from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "' and estado = 1");
                txtsegundoApellido.Text = dbConn.obtenerVariableString("select segundoApellido from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "' and estado = 1");
                txtCorreoElectronico.Text = dbConn.obtenerVariableString("select correoElectronico from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "' and estado = 1");
                txtprimerTelefono.Text = dbConn.obtenerVariableString("select numeroTelefono from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "' and estado = 1");
                txtsegundoTelefono.Text = dbConn.obtenerVariableString("select numeroTelefonoAlt from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "' and estado = 1");
                txtDireccion.Text = dbConn.obtenerVariableString("select direccionTrabajo from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "' and estado = 1");
                fechaNacimiento = dbConn.obtenerVariableString("select fechaNacimiento from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "' and estado = 1");

                txtfechaNacimiento.Text = fechaNacimiento;
                //MessageBox.Show( estado, "Error Inesperado", MessageBoxButtons.OK);

                MessageBox.Show("Encargado Encontrado Exitosamente", "Buscar Realizado", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Encargado no encontrado", "Error Inesperado", MessageBoxButtons.OK);
            }
        }

        public void EliminarEncargado()
        {
            if (dbConn.ComprobarExistencia("select estado from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "'"))
            {
                dbConn.ejecutarComandoSQL("update datosEncargado set estado = 0 where identidadEncargado = '" + txtIdentidad.Text + "'");

                MessageBox.Show("Encargado Eliminado Exitosamente", "Eliminar Realizado", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Encargado no encontrado", "Error Inesperado", MessageBoxButtons.OK);
            }
        }

        private void txtprimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingrese correctamente el primer nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Ingrese correctamente el segundo nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtprimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingrese correctamente el primer apellido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtsegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingrese correctamente el segundo apellido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtprimerTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingrese correctamente el numero de teléfono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtsegundoTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingrese correctamente el numero de teléfono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    MessageBox.Show("Ingrese un numero de Identidad Correcta", "Error Inesperado", MessageBoxButtons.OK);
                    limpiarPantalla();
                }
                else
                {

                    if (txtprimerNombre.Text == "" || txtsegundoNombre.Text == "" || txtprimerApellido.Text == "" || txtsegundoApellido.Text == "" ||
                                       txtCorreoElectronico.Text == "" || txtprimerTelefono.Text == "" || txtsegundoTelefono.Text == "" || txtDireccion.Text == "")
                    {
                        MessageBox.Show("Debe llenar todos los campos necesarios", "Error Inesperado", MessageBoxButtons.OK);
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
                    MessageBox.Show("Ingrese un numero de Identidad Correcta", "Error Inesperado", MessageBoxButtons.OK);
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
            dbConn.llenarDGV(dgvBusquedaEncargado, "SELECT id_encargadoAlumno as 'ID', identidadEncargado as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ' ,"+
                " segundoApellido)as 'Nombre', numeroTelefono as 'Teléfono 1', numeroTelefonoAlt as 'Teléfono 2', correoElectronico as 'Correo Electronico', direccionTrabajo as 'Dirección', fechaNacimiento as 'Fecha de Nacimiento' FROM datosEncargado WHERE CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) LIKE '" + txtLikeIdentidad.Text + "%' or identidadEncargado LIKE '" + txtLikeIdentidad.Text + "%' and estado = 1");

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
            dbConn.llenarDGV(dgvListadoEstudiantes, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre', fechaNacimiento as 'Fecha de Nacimiento', genero as 'Genero', estado as 'Estado' FROM datosEstudiante WHERE CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ' , segundoApellido) LIKE '" + txtLikeidentidadEstud.Text + "%' or identidadEstudiante LIKE '" + txtLikeidentidadEstud.Text + "%' and estado = 1");
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
            identidadEstudiante = dgvBusquedaEncargado.Rows[e.RowIndex].Cells[1].Value.ToString();
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
                if (txtIdentidad.TextLength > 13 || txtIdentidad.TextLength < 13)
                {
                    MessageBox.Show("Ingrese un numero de Identidad Correcta", "Error Inesperado", MessageBoxButtons.OK);
                    limpiarPantalla();
                }
                else
                {
                    if (txtprimerNombre.Text == "" && txtsegundoNombre.Text == "" && txtprimerApellido.Text == "" && txtsegundoApellido.Text == "" &&
                          txtfechaNacimiento.Text == "")
                        {
                            MessageBox.Show("Debe llenar todos los campos necesarios", "Error Inesperado", MessageBoxButtons.OK);
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
                    MessageBox.Show("Estudiante Actualizado Exitosamente", "Actualización Realizada", MessageBoxButtons.OK);
                    limpiarPantalla();
                }
                else
                {
                    MessageBox.Show("Error al Actualizar el Estudiante", "Error Inesperado", MessageBoxButtons.OK);
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
                if (txtIdentidad.TextLength > 13 || txtIdentidad.TextLength < 13)
                {
                    MessageBox.Show("Ingrese un numero de Identidad Correcta", "Error Inesperado", MessageBoxButtons.OK);
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
                dbConn.ejecutarComandoSQL("update datosEstudiante set estado = 0 where identidadEstudiante = '" + txtIdentidadEstud.Text + "'");

                MessageBox.Show("Estudiante Eliminado Exitosamente", "Eliminar Realizado", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado", "Error Inesperado", MessageBoxButtons.OK);
            }
        }

        private void txtIdentidadEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingrese correctamente el numero de Identidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtprimerNombreEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingrese correctamente el primer nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtsegundoNombreEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingrese correctamente el segundo nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtprimerApellidoEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingrese correctamente el primer apellido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtsegundoApellidoEstud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingrese correctamente el segundo apellido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}