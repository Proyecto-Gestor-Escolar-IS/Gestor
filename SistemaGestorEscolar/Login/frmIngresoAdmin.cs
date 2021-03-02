using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using SistemaGestorEscolar.MessageBox_Personalizados;

namespace SistemaGestorEscolar.Login
{
    public partial class frmIngresoAdmin : Form
    {
        public frmIngresoAdmin()
        {
            InitializeComponent();
        }

        databaseConnection dbConn = new databaseConnection();
        clsUtilidades utilidad = new clsUtilidades();
        IMessageBoxError message = new IMessageBoxError();
        IMessageBoxCheck messageOk = new IMessageBoxCheck();
        IMessageBoxYesCancel messageYesNo = new IMessageBoxYesCancel();
        IMessageBoxWarning messageWarning = new IMessageBoxWarning();

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string txtIdentid = txtIdentidad.Text;
            string txtNum = txtTel.Text;
            if (txtIdentid.Trim() != string.Empty && txtNombre1.Text != string.Empty && txtApellido1.Text != string.Empty && txtNum != string.Empty &&
                txtCorreo.Text != string.Empty && txtContra.Text != string.Empty && txtConfirmContra.Text != string.Empty && txtFechaNa.Text != string.Empty && txtIdentid.Trim().Length == 13 && txtNum.Trim().Length == 8)
            {
                if (txtConfirmContra.TextLength >= 6)
                {
                    if (utilidad.verificarCorreo(txtCorreo.Text))
                    {
                        pnlPrincipal.Visible = false;
                        pnlRecuperacion.Visible = true;
                    }
                    else
                    {
                        message.lblError.Text = "VERIFIQUE CORREO \n\rELECTRÓNICO";
                        message.lblError.TextAlign = ContentAlignment.MiddleCenter;
                        message.lblError.Location = new Point(130, 75);
                        message.ShowDialog();
                    }
                }
                else
                {
                    messageWarning.ShowDialog();
                    txtContra.Focus();
                }
                    
            }
            else
            {
                message.lblError.Text = "VERIFIQUE LOS VALORES";
                message.lblError.Location = new Point(130, 82);
                message.ShowDialog();
            }

            

        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            pnlPrincipal.Visible = true;
            pnlRecuperacion.Visible = false;
        }

        private void txtConfirmContra_TextChanged(object sender, EventArgs e)
        {
            if (txtContra.Text == txtConfirmContra.Text)
            {
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
            }
        }

        private void frmIngresoAdmin_Load(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = false;
        }

        private void chkVerContras_CheckedChanged(object sender, EventArgs e)
        {
            if(chkVerContras.Checked == true)
            {
                txtContra.PasswordChar = '\0';
                txtConfirmContra.PasswordChar = '\0';
            }
            else
            {
                txtContra.PasswordChar = '●';
                txtConfirmContra.PasswordChar = '●';
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (txtCorreoRecuperacion.Text != string.Empty && txtContraseRecuperacion.Text != string.Empty)
            {
                if (utilidad.verificarCorreo(txtCorreoRecuperacion.Text))
                {
                    messageYesNo.lblError.Text = "¿HA REVISADO SUS DATOS \r\nY DESEA CONTINUAR?";
                    messageYesNo.lblError.TextAlign = ContentAlignment.MiddleCenter;
                    messageYesNo.ShowDialog();

                    //DialogResult result =  MessageBox.Show("¿Ha revisado sus datos y desea continuar?", "Continuar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if ( IMessageBoxYesCancel.isCodigoForm == true )
                    {
                        if(utilidad.enviarCorreo("","",txtCorreoRecuperacion.Text,"",txtCorreoRecuperacion.Text,txtContraseRecuperacion.Text) == true)
                        {
                            if (dbConn.PAOperacionEmpleado(txtIdentidad.Text, txtNombre1.Text, txtNombre2.Text, txtApellido1.Text, txtApellido2.Text, Convert.ToInt32(txtTel.Text), txtFechaNa.Text,
                            txtCorreo.Text, "Activo", utilidad.EncriptarTexto(txtConfirmContra.Text), 1, -1, 1))
                            {
                                messageOk.lblCheck.Text = "REGISTRADO CORRECTAMENTE";
                                messageOk.ShowDialog();
                                Properties.Settings.Default.correoRecu = txtCorreoRecuperacion.Text;
                                Properties.Settings.Default.contraRecu = txtContraseRecuperacion.Text;
                                Properties.Settings.Default.Save();
                                this.Close();
                            }
                        }
                        else
                        {
                            message.lblError.Text = "CREDENCIALES DE CORREO \r\nELECTRONICO INCORRECTAS";
                            message.lblError.Location = new Point(105, 75);
                            message.lblError.TextAlign = ContentAlignment.MiddleCenter;
                            message.ShowDialog();
                        }
                            
                    }
                }
                else
                {
                    message.lblError.Text = "VERIFIQUE\n\r CORREO ELECTRÓNICO";
                    message.lblError.TextAlign = ContentAlignment.MiddleCenter;
                    message.lblError.Location = new Point(130, 75);
                    message.ShowDialog();
                }
               
            }
            else
            {
                message.lblError.Text = "VERIFIQUE LOS VALORES";
                message.lblError.Location = new Point(130, 82);
                message.ShowDialog();
            }
        }

        private void chkVerContraRecuperacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVerContraRecuperacion.Checked == true)
            {
                txtContraseRecuperacion.PasswordChar = '\0';
            }
            else
            {
                txtContraseRecuperacion.PasswordChar = '●';
            }
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            if (txtContra.Text == txtConfirmContra.Text)
            {
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.Enabled = false;
            }
        }
    }
}
