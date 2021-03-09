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
        string txtIdentid = "0000000000000";

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            string txtNum = txtTel.Text;
            if (txtIdentid.Trim() != string.Empty && txtNombre1.Text != string.Empty && txtApellido1.Text != string.Empty && txtNum != string.Empty &&
                txtCorreo.Text != string.Empty && txtContra.Text != string.Empty && txtConfirmContra.Text != string.Empty && txtFechaNa.Text != string.Empty && txtIdentid.Trim().Length == 13 && txtNum.Trim().Length == 8)
            {
                if (utilidad.verificarCorreo(txtCorreo.Text))
                {
                    if (txtConfirmContra.TextLength >= 6 && txtContra.TextLength >= 6)
                    {
                        if (txtContra.Text == txtConfirmContra.Text)
                        {
                            if (utilidad.isDate(txtFechaNa.Text))
                            {
                                pnlPrincipal.Visible = false;
                                pnlRecuperacion.Visible = true;
                            }
                            else
                            {
                                message.lblError.Text = "INGRESE UNA FECHA VALIDA";
                                message.lblError.Location = new Point(120, 82);
                                message.ShowDialog();
                            }

                        }
                        else
                        {
                            message.lblError.Text = "CONTRASEÑAS NO COINCIDEN";
                            message.lblError.Location = new Point(120, 82);
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
                    message.lblError.Text = "VERIFIQUE CORREO \n\rELECTRÓNICO";
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

        private void txtConfirmContra_TextChanged(object sender, EventArgs e)
        {
            if (txtContra.Text == txtConfirmContra.Text)
            {
                btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(204)))), ((int)(((byte)(221)))));
                btnSiguiente.Enabled = true;
            }
            else
            {
                btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                btnSiguiente.Enabled = false;
            }
        }

        private void frmIngresoAdmin_Load(object sender, EventArgs e)
        {
            btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            btnSiguiente.Enabled = false;
            txtIdentidad.Text = txtIdentid;
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
            if (txtCorreoRecuperacion.Text != string.Empty && txtContraseRecuperacion.Text != string.Empty && txtHost.Text != string.Empty && txtPuerto.Text != string.Empty && utilidad.isNumeric(txtPuerto.Text))
            {
                if (utilidad.verificarCorreo(txtCorreoRecuperacion.Text))
                {
                    messageYesNo.lblError.Text = "¿HA REVISADO SUS DATOS \r\nY DESEA CONTINUAR?";
                    messageYesNo.lblError.TextAlign = ContentAlignment.MiddleCenter;
                    messageYesNo.ShowDialog();

                    if ( IMessageBoxYesCancel.isCodigoForm == true )
                    {
             
                        if(utilidad.enviarCorreo(" < h1 > VERIFICACI & Oacute; N DE CORREO ELECTR&Oacute; NICO </ h1 > ",txtCorreoRecuperacion.Text,txtCorreoRecuperacion.Text,txtContraseRecuperacion.Text, txtHost.Text, Convert.ToInt32(txtPuerto.Text)) == true)
                        {
                            if (dbConn.PAOperacionEmpleado(txtIdentid, txtNombre1.Text, txtNombre2.Text, txtApellido1.Text, txtApellido2.Text, Convert.ToInt32(txtTel.Text), txtFechaNa.Text,
                            txtCorreo.Text, 1, utilidad.EncriptarTexto(txtConfirmContra.Text), 1, -1, 1))
                            {
                                try
                                {
                                    dbConn.ejecutarComandoSQL("INSERT INTO informacionCorreoRecuperacion VALUES('" + txtCorreoRecuperacion.Text + "', '" + utilidad.EncriptarTexto(txtContraseRecuperacion.Text) + "' " +
                                        ", '"+txtHost.Text+"', '"+Convert.ToInt32(txtPuerto.Text)+"')");
                                    messageOk.lblCheck.Text = "REGISTRADO CORRECTAMENTE";
                                    messageOk.ShowDialog();
                                    this.Close();
                                }
                                catch
                                {
                                    message.lblError.Text = "ERROR";
                                    message.lblError.Location = new Point(140, 85);
                                    message.lblError.TextAlign = ContentAlignment.MiddleCenter;
                                    message.ShowDialog();
                                }
                                
                                
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Visible = true;
            pnlRecuperacion.Visible = false;
        }
    }
}
