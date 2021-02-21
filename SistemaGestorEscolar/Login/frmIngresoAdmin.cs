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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (txtIdentidad.Text!= string.Empty && txtNombre1.Text != string.Empty && txtNombre2.Text != string.Empty && txtApellido1.Text != string.Empty && txtApellido2.Text != string.Empty &&
                txtCorreo.Text != string.Empty && txtContra.Text != string.Empty && txtConfirmContra.Text != string.Empty && txtFechaNa.Text != string.Empty)
            {
                if (utilidad.verificarCorreo(txtCorreo.Text))
                {
                    pnlPrincipal.Visible = false;
                    pnlRecuperacion.Visible = true;
                }
                else
                {
                    MessageBox.Show("Verifique su correo electronico!", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Verifique los Valores!", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    DialogResult result =  MessageBox.Show("¿Ha revisado sus datos y desea continuar?", "Continuar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if ( result == DialogResult.Yes )
                    {
                        if (dbConn.PAOperacionEmpleado(txtIdentidad.Text, txtNombre1.Text, txtNombre2.Text, txtApellido1.Text, txtApellido2.Text, Convert.ToInt32(txtTel.Text), txtFechaNa.Text,
                        txtCorreo.Text, "Activo", utilidad.EncriptarTexto(txtConfirmContra.Text), 1, -1, 1))
                        {
                            MessageBox.Show("Registro Realizado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Verifique su correo electronico!", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show("Verifique los Valores!", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
