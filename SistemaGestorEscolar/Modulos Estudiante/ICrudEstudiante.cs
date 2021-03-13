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
    public partial class ICrudEstudiante : Form
    {
        public ICrudEstudiante()
        {
            InitializeComponent();
        }
        databaseConnection dbConn = new databaseConnection();
        
        private void txtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Ingrese correctamente el numero de Identidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
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

        private void txtsegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        //private void chkmodificarEstudiante_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkmodificarEstudiante.Checked == true)
        //    {
           
        //        chkbuscarEstudiante.Checked = false;
        //        chkeliminarEstudiante.Checked = false;
        //        txtfechaNacimiento.Enabled = false;
        //        txtfechaNacimiento.Clear(); 
        //        cmbgeneroEstudiante.Enabled = false;
        //    }
        //    else
        //        txtfechaNacimiento.Enabled = true;
        //        cmbgeneroEstudiante.Enabled = true;
        //}

        //private void chkbuscarEstudiante_CheckedChanged(object sender, EventArgs e)
        //{
        //    {
        //        if (chkbuscarEstudiante.Checked == true)
        //        {
        //            chkmodificarEstudiante.Checked = false;
        //            chkeliminarEstudiante.Checked = false;


        //            txtprimerNombre.Enabled = false;
        //            txtsegundoNombre.Enabled = false;
        //            txtprimerApellido.Enabled = false;
        //            txtsegundoApellido.Enabled = false;
        //            txtfechaNacimiento.Enabled = false;
        //            cmbgeneroEstudiante.Enabled = false;

        //        }
        //        else
        //        {


        //            txtprimerNombre.Enabled = true;
        //            txtsegundoNombre.Enabled = true;
        //            txtprimerApellido.Enabled = true;
        //            txtsegundoApellido.Enabled = true;
        //            txtfechaNacimiento.Enabled = true;
        //            cmbgeneroEstudiante.Enabled = true;
                
        //        }
        //    }
        //}

        //private void chkeliminarEstudiante_CheckedChanged(object sender, EventArgs e)
        //{

        //    if (chkeliminarEstudiante.Checked == true)
        //    {
        //        chkmodificarEstudiante.Checked = false;
        //        chkbuscarEstudiante.Checked = false;


        //        txtprimerNombre.Enabled = false;
        //        txtsegundoNombre.Enabled = false;
        //        txtprimerApellido.Enabled = false;
        //        txtsegundoApellido.Enabled = false;
        //        txtfechaNacimiento.Enabled = false;
        //        cmbgeneroEstudiante.Enabled = false;
               
        //    }
        //    else
        //    {



        //        txtprimerNombre.Enabled = true;
        //        txtsegundoNombre.Enabled = true;
        //        txtprimerApellido.Enabled = true;
        //        txtsegundoApellido.Enabled = true;
        //        txtfechaNacimiento.Enabled = true;
        //        cmbgeneroEstudiante.Enabled = true;
        //    }
        //}

        private void limpiarPantalla()
        {
            txtIdentidadEstud.Clear();
            txtprimerNombreEstud.Clear();
            txtsegundoNombreEstud.Clear();
            txtprimerApellidoEstud.Clear();
            txtsegundoApellidoEstud.Clear();
            txtfechaNacimientoEstud.Clear();
            cmbgeneroEstudiante.SelectedItem = -1;


        }



        //private void btnrealizarOperacion_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (txtIdentidad.TextLength > 13 || txtIdentidad.TextLength < 13)
        //        {
        //            MessageBox.Show("Ingrese un numero de Identidad Correcta", "Error Inesperado", MessageBoxButtons.OK);
        //            limpiarPantalla();
        //        }
        //        else
        //        {
        //            if (chkmodificarEstudiante.Checked == true)
        //                if (txtprimerNombre.Text == "" && txtsegundoNombre.Text == "" && txtprimerApellido.Text == "" && txtsegundoApellido.Text == "" &&
        //                  txtfechaNacimiento.Text == "")
        //                {
        //                    MessageBox.Show("Debe llenar todos los campos necesarios", "Error Inesperado", MessageBoxButtons.OK);
        //                }
        //                else
        //                {
        //                    ActualizarEstudiante();
        //                }
        //            else if (chkeliminarEstudiante.Checked == true)
        //            {
        //                EliminarEstudiante();
        //            }
        //            else if (chkbuscarEstudiante.Checked == true)
        //            {
        //                BuscarEstudiante();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}




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


        public void BuscarEstudiante()
        {
           string fechaNacimiento;


            if (dbConn.ComprobarExistencia("select estado from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstud.Text + "'"))
            {
                txtprimerNombreEstud.Text = dbConn.obtenerVariableString("select primerNombre from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstud.Text + "' and estado = 1");
                txtsegundoNombreEstud.Text = dbConn.obtenerVariableString("select segundoNombre from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstud.Text + "' and estado = 1");
                txtprimerApellidoEstud.Text = dbConn.obtenerVariableString("select primerApellido from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstud.Text + "' and estado = 1");
                txtsegundoApellidoEstud.Text = dbConn.obtenerVariableString("select segundoApellido from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstud.Text + "' and estado = 1");
                fechaNacimiento = dbConn.obtenerVariableString("select fechaNacimiento from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstud.Text + "' and estado = 1");
               cmbgeneroEstudiante.SelectedItem = dbConn.obtenerVariableString("select genero from datosEstudiante where identidadEstudiante = '" + txtIdentidadEstud.Text + "' and estado = 1");
                txtfechaNacimientoEstud.Text = fechaNacimiento;
                //MessageBox.Show( estado, "Error Inesperado", MessageBoxButtons.OK);

                MessageBox.Show("Estudiante Encontrado Exitosamente", "Buscar Realizado", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado", "Error Inesperado", MessageBoxButtons.OK);
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

        private void txtIdentidad_TextChanged(object sender, EventArgs e)
        {

            long number = 0;
            try
            {
                if (txtIdentidadEstud.Text != String.Empty)
                {
                    txtIdentidadEstud.ForeColor = Color.Black;
                    errorIdentidad.Clear();
                    if (long.TryParse(txtIdentidadEstud.Text, out number))
                    {
                        txtIdentidadEstud.ForeColor = Color.Black;
                        errorIdentidad.Clear();

                        if (txtIdentidadEstud.TextLength == 13)
                        {
                            txtIdentidadEstud.ForeColor = Color.Green;
                            errorIdentidad.Clear();


                        }
                        else if (txtIdentidadEstud.TextLength > 13 || txtIdentidadEstud.TextLength < 13)
                        {
                            txtIdentidadEstud.ForeColor = Color.Red;
                            errorIdentidad.SetError(this.txtIdentidadEstud, "El numero de Identidad no es Correcto!");

                        }
                    }
                    else
                    {
                        txtIdentidadEstud.ForeColor = Color.Red;
                        errorIdentidad.SetError(this.txtIdentidadEstud, "Solo se Permiten Numeros!");
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

        private void PanregistroEncargado_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
