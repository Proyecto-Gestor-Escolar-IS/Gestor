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

namespace SistemaGestorEscolar.Modulos_Encargado
{
    public partial class IAñadirEncargado : Form
    {
        public IAñadirEncargado()
        {
            InitializeComponent();
        }
        databaseConnection dbConn = new databaseConnection();

        //Validaciones para checkbox(no se activaran dos simultaneamente)
        private void chkregistrarEncargado_Click(object sender, EventArgs e)
        {
            if (chkregistrarEncargado.Checked == true)
            {
                chkactualizarEncargado.Checked = false;
                chkbuscarEncargado.Checked = false;
                chkeliminarEncargado.Checked = false;
 
            }
      
        }

        private void chkactualizarEncargado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkactualizarEncargado.Checked == true)
            {
                chkregistrarEncargado.Checked = false;
                chkbuscarEncargado.Checked = false;
                chkeliminarEncargado.Checked = false;
                txtfechaNacimiento.Enabled = false;
                txtfechaNacimiento.Clear();
            }
            else
                txtfechaNacimiento.Enabled = true;
        }

        private void chkbuscarEncargado_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chkbuscarEncargado.Checked == true)
                {
                    chkregistrarEncargado.Checked = false;
                    chkactualizarEncargado.Checked = false;
                    chkeliminarEncargado.Checked = false;

                  
                    txtprimerNombre.Enabled = false;
                    txtsegundoNombre.Enabled = false;
                    txtprimerApellido.Enabled = false;
                    txtsegundoApellido.Enabled = false;
                    txtcorreoElectronico.Enabled = false;
                    txtprimerTelefono.Enabled = false;
                    txtsegundoTelefono.Enabled = false;
                    txtfechaNacimiento.Enabled = false;
                    txtDireccion.Enabled = false;
                
                }
                else
                {


                    txtprimerNombre.Enabled = true;
                    txtsegundoNombre.Enabled = true;
                    txtprimerApellido.Enabled = true;
                    txtsegundoApellido.Enabled = true;
                    txtcorreoElectronico.Enabled = true;
                    txtprimerTelefono.Enabled = true;
                    txtsegundoTelefono.Enabled = true;
                    txtfechaNacimiento.Enabled = true;
                    txtDireccion.Enabled = true;

                }
            }
        }

        private void chkeliminarEncargado_CheckedChanged(object sender, EventArgs e)
        {
              
                   if (chkeliminarEncargado.Checked == true)
                    {
                        chkregistrarEncargado.Checked = false;
                        chkactualizarEncargado.Checked = false;
                        chkbuscarEncargado.Checked = false;


                        txtprimerNombre.Enabled = false;
                        txtsegundoNombre.Enabled = false;
                        txtprimerApellido.Enabled = false;
                        txtsegundoApellido.Enabled = false;
                        txtcorreoElectronico.Enabled = false;
                        txtprimerTelefono.Enabled = false;
                        txtsegundoTelefono.Enabled = false;
                        txtfechaNacimiento.Enabled = false;
                        txtDireccion.Enabled = false;

                    }
                    else
                    {



                        txtprimerNombre.Enabled = true;
                        txtsegundoNombre.Enabled = true;
                        txtprimerApellido.Enabled = true;
                        txtsegundoApellido.Enabled = true;
                        txtcorreoElectronico.Enabled = true;
                        txtprimerTelefono.Enabled = true;
                        txtsegundoTelefono.Enabled = true;
                        txtfechaNacimiento.Enabled = true;
                        txtDireccion.Enabled = true;
                    }
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtcorreoElectronico_TextChanged(object sender, EventArgs e)
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


        private void btnrealizarOperacion_Click(object sender, EventArgs e)
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
                    if(chkregistrarEncargado.Checked == true)
                    if (txtprimerNombre.Text == "" && txtsegundoNombre.Text == "" && txtprimerApellido.Text == "" && txtsegundoApellido.Text == "" &&
                     txtcorreoElectronico.Text == "" && txtprimerTelefono.Text == "" && txtsegundoTelefono.Text == "" && txtDireccion.Text == "" && txtfechaNacimiento.Text == "")
                    {
                        MessageBox.Show("Debe llenar todos los campos necesarios", "Error Inesperado", MessageBoxButtons.OK);
                    }
                    else
                    {
                        RegistrarEncargado();
                    }
                    else if(chkactualizarEncargado.Checked == true)
                    {
                        if (txtprimerNombre.Text == "" && txtsegundoNombre.Text == "" && txtprimerApellido.Text == "" && txtsegundoApellido.Text == "" &&
                                           txtcorreoElectronico.Text == "" && txtprimerTelefono.Text == "" && txtsegundoTelefono.Text == "" && txtDireccion.Text == "")
                        {
                            MessageBox.Show("Debe llenar todos los campos necesarios", "Error Inesperado", MessageBoxButtons.OK);
                        }
                        else
                        {
                            ActualizarEncargado();
                        }
                    }
                    else if(chkeliminarEncargado.Checked == true)
                    {
                        EliminarEncargado();
                    }
                    else if(chkbuscarEncargado.Checked == true)
                    {
                        BuscarEncargado();
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
                if (dbConn.PARegistroEncargado(txtIdentidad.Text, txtprimerNombre.Text, txtsegundoNombre.Text, txtprimerApellido.Text, txtsegundoApellido.Text, txtcorreoElectronico.Text,txtprimerTelefono.Text, txtsegundoTelefono.Text, txtDireccion.Text, txtfechaNacimiento.Text))
                {
                    MessageBox.Show("Encargado Registrado Exitosamente", "Registro Realizado", MessageBoxButtons.OK);
                    limpiarPantalla();
                }
                else
                {
                    MessageBox.Show("Error al Registrar el Encargado", "Error Inesperado", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }



        public void ActualizarEncargado()
        {
            //string numeroIdentidad, primerNombre, segundoNombre, primerApellido, segundoApellido, correoElectronico, direccion, fechaNacimiento, telefono, telefonoAlter;

            try
            {
                if (dbConn.PAActualizarEncargado(txtIdentidad.Text, txtprimerNombre.Text, txtsegundoNombre.Text, txtprimerApellido.Text, txtsegundoApellido.Text, txtcorreoElectronico.Text, txtprimerTelefono.Text, txtsegundoTelefono.Text, txtDireccion.Text))
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
                txtcorreoElectronico.Text = dbConn.obtenerVariableString("select correoElectronico from datosEncargado where identidadEncargado = '" + txtIdentidad.Text + "' and estado = 1");
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
                dbConn.ejecutarComandoSQL("update datosEncargado set estado = 0 where identidadEncargado = '"+ txtIdentidad.Text +"'");

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
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingrese correctamente el numero de Identidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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

            long number = 0;
            try
            {
                if (txtIdentidad.Text != String.Empty)
                {
                    txtIdentidad.ForeColor = Color.Black;
                    errorIdentidad.Clear();
                    if (long.TryParse(txtIdentidad.Text, out number))
                    {
                        txtIdentidad.ForeColor = Color.Black;
                        errorIdentidad.Clear();

                        if (txtIdentidad.TextLength == 13)
                        {
                            txtIdentidad.ForeColor = Color.Green;
                            errorIdentidad.Clear();

                      
                        }
                        else if (txtIdentidad.TextLength > 13 || txtIdentidad.TextLength < 13)
                        {
                            txtIdentidad.ForeColor = Color.Red;
                            errorIdentidad.SetError(this.txtIdentidad, "El numero de Identidad no es Correcto!"); 
             
                        }
                    }
                    else
                    {
                        txtIdentidad.ForeColor = Color.Red;
                        errorIdentidad.SetError(this.txtIdentidad, "Solo se Permiten Numeros!");
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



        private void limpiarPantalla()
        {
            txtIdentidad.Clear();
            txtprimerNombre.Clear();
            txtsegundoNombre.Clear();
            txtprimerApellido.Clear();
            txtsegundoApellido.Clear();
            txtcorreoElectronico.Clear();
            txtprimerTelefono.Clear();
            txtsegundoTelefono.Clear();
            txtfechaNacimiento.Clear();
            txtDireccion.Clear();

        }





    }
}
