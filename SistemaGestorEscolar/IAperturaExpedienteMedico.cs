using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar
{
    public partial class IAperturaExpedienteMedico : Form
    {
        
        public IAperturaExpedienteMedico()
        {
            InitializeComponent();
        }
        IMessageBoxCheck messageOk = new IMessageBoxCheck();
        IMessageBoxError message = new IMessageBoxError();
       


        databaseConnection dbConn = new databaseConnection();

        private int ultimoIdExpediente;

        private void IAperturaExpedienteMedico_Load(object sender, EventArgs e)
        {
            if ((dbConn.retornarIdExpediente()) > 0)
            {
                ultimoIdExpediente = dbConn.retornarIdExpediente() + 1;
                txtNoExpediente.Text = (ultimoIdExpediente.ToString());
            }
            else
            {
                ultimoIdExpediente = 1;
                txtNoExpediente.Text = (ultimoIdExpediente.ToString());
            }
            
            txtFechaCreacion.Text = DateTime.Now.ToString();

        }

        private void limpiarPantalla()
        {
            txtNombreEstudiante.Clear();
            txtAntecedenteMedico.Clear();
        }

        private void txtNumeroIdentidad_TextChanged(object sender, EventArgs e)
        {
            String idEstudiante;
            String idExpediente;
            long number = 0;
            try
            {
                if (txtNumeroIdentidad.Text != String.Empty)
                {
                    txtNumeroIdentidad.ForeColor = Color.Black;
                    errorIdentidad.Clear();
                    if (long.TryParse(txtNumeroIdentidad.Text, out number))
                    {
                        txtNumeroIdentidad.ForeColor = Color.Black;
                        errorIdentidad.Clear();

                        if (txtNumeroIdentidad.TextLength == 13)
                        {
                            txtNumeroIdentidad.ForeColor = Color.Green;
                            errorIdentidad.Clear();

                            idEstudiante = dbConn.obtenerVariableString("SELECT id_Registro FROM datosEstudiante WHERE identidadEstudiante = " + txtNumeroIdentidad.Text);
                            idExpediente = dbConn.obtenerVariableString("SELECT id_expediente FROM expedienteMedico WHERE id_Estudiante = " + txtNumeroIdentidad.Text);

                            if (!string.IsNullOrEmpty(idEstudiante))
                            {
                                if (string.IsNullOrEmpty(idExpediente))
                                {
                                    dbConn.llenarTextBox(txtNombreEstudiante, "SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM datosEstudiante WHERE identidadEstudiante = " + txtNumeroIdentidad.Text);
                                }
                                else 
                                {
                                    txtNumeroIdentidad.ForeColor = Color.Red;
                                    errorIdentidad.SetError(this.txtNumeroIdentidad, "Este estudiante ya tiene un Expediente Médico");
                                }

                            }
                            else
                            {
                                txtNumeroIdentidad.ForeColor = Color.Red;
                                errorIdentidad.SetError(this.txtNumeroIdentidad, "Este estudiante no está registrado!");
                            }
                        }
                        else if (txtNumeroIdentidad.TextLength > 13 || txtNumeroIdentidad.TextLength < 13)
                        {
                            txtNumeroIdentidad.ForeColor = Color.Red;
                            errorIdentidad.SetError(this.txtNumeroIdentidad, "El Número de Identidad es Incorrecto!");
                            limpiarPantalla();      
                        }
                    }
                    else
                    {
                        txtNumeroIdentidad.ForeColor = Color.Red;
                        errorIdentidad.SetError(this.txtNumeroIdentidad, "Solo se Permiten Numeros!");
                        limpiarPantalla();
                       
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

        private void btnRegistrarAntecedente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbConn.abrirExpediente(txtNumeroIdentidad.Text, txtAntecedenteMedico.Text))

                {
                    messageOk.lblCheck.Text = "REGISTRADO CORRECTAMENTE";
                    messageOk.ShowDialog();
                    txtNumeroIdentidad.Clear();
                    txtNombreEstudiante.Clear();
                    ultimoIdExpediente = dbConn.retornarIdExpediente() + 1;
                    txtNoExpediente.Text = ultimoIdExpediente.ToString();
                    txtAntecedenteMedico.Clear();
                    txtFechaCreacion.Text = DateTime.Now.ToString();

                }
                else
                {
                    message.lblError.Text = "VERIFIQUE LOS DATOS";
                    message.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       
        private void txtNoExpediente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreEstudiante_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreEstudiante.Text != string.Empty)
            {

                txtAntecedenteMedico.Enabled = true;

            }
            else
            {
                txtAntecedenteMedico.Enabled = false;
                txtAntecedenteMedico.Clear();
            }
        }

        private void txtAntecedenteMedico_TextChanged(object sender, EventArgs e)
        {
            if(txtAntecedenteMedico.Text != string.Empty)
            {
                btnRegistrarAntecedente.Enabled = true;

            }
            else
            {
                btnRegistrarAntecedente.Enabled = false;
            }
        }

        private void txtNumeroIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                message.lblError.Text = "VALOR INCORRECTO!  \r\nSOLO SE PERMITEN NÚMEROS";
                message.lblError.Location = new Point(105, 75);
                message.lblError.TextAlign = ContentAlignment.MiddleCenter;
                message.ShowDialog();
                e.Handled = true;
                return;
            }
        }

        private void txtFechaCreacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
