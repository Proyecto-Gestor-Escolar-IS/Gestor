using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar
{
    public partial class IRegistroPago : Form
    {
        public IRegistroPago()
        {
            InitializeComponent();
        }
        databaseConnection dbConn = new databaseConnection();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IRegistroPago_Load(object sender, EventArgs e)
        {

        }

  

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void grpDatosPago_Enter(object sender, EventArgs e)
        {

        }

        private void txtIdentidadEstudiante_TextChanged(object sender, EventArgs e)
        {
            int idUltimaMensualidad;
            long number = 0;
            try
            {
                if (txtIdentidadEstudiante.Text != String.Empty)
                {
                    txtIdentidadEstudiante.ForeColor = Color.Black;
                    errorIdentidad.Clear();
                    if (long.TryParse(txtIdentidadEstudiante.Text, out number))
                    {
                        txtIdentidadEstudiante.ForeColor = Color.Black;
                        errorIdentidad.Clear();

                        if (txtIdentidadEstudiante.TextLength == 13)
                        {
                            txtIdentidadEstudiante.ForeColor = Color.Green;
                            errorIdentidad.Clear();
                            //dbConn.llenarTextBox(txtNombreEstudiante, "SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM datosEstudiante WHERE identidadEstudiante = " + txtIdentidadEstudiante.Text);
                            //idUltimaMensualidad = dbConn.obtenerVariableEntera("SELECT MAX(id_Mensualidad) FROM detalleMensualidades WHERE id_Estudiante = " + txtIdentidadEstudiante.Text);

                            //dbConn.llenarTextBox(txtNoFactura, "SELECT count(*) FROM detalleMensualidades WHERE id_Estudiante = " + txtIdentidadEstudiante.Text);
                            //dbConn.llenarTextBox(txtFechaFacturacion, "SELECT fechaFacturacion FROM detalleMensualidades WHERE id_Mensualidad = " + idUltimaMensualidad); dbConn.llenarTextBox(txtFechaFacturacion, "SELECT fechaFacturacion FROM detalleMensualidades WHERE id_Mensualidad = " + idUltimaMensualidad);
                            //dbConn.llenarTextBox(txtTotalPagar, "SELECT deudaPendiente FROM detalleMensualidades WHERE id_Mensualidad = " + idUltimaMensualidad);
                            //dbConn.llenarTextBox(txtSaldoDisponible, "SELECT saldoDisponible FROM detalleMensualidades WHERE id_Mensualidad = " + idUltimaMensualidad);

                        }
                        else if (txtIdentidadEstudiante.TextLength > 13)
                        {
                            txtIdentidadEstudiante.ForeColor = Color.Red;
                            errorIdentidad.SetError(this.txtIdentidadEstudiante, "El numero de Identidad excede el limite!");
                        }
                    }
                    else
                    {
                        txtIdentidadEstudiante.ForeColor = Color.Red;
                        errorIdentidad.SetError(this.txtIdentidadEstudiante, "Solo se Permiten Numeros!");
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

        private void txtNoFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSaldoDisponible_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTotalPagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaFacturacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDescuento.Checked == true)
            {
                txtDescuento.Enabled = true;
            }
            else if (chkDescuento.Checked == false)
            {
                txtDescuento.Clear();
                txtDescuento.Enabled = false;
            }
        }
    }
}
