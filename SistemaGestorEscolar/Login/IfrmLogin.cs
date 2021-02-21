using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Login
{
    public partial class IfrmLogin : Form
    {
        public IfrmLogin()
        {
            InitializeComponent();
        }

        databaseConnection dbConn = new databaseConnection();
        clsUtilidades utilidad = new clsUtilidades();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            dbConn.establecerConexion();
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.isPrimerInicio = false;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.isPrimerInicio == true && txtdentidad.Text == String.Empty && txtContrase.Text == String.Empty)
            {
                MessageBox.Show("Esta es su primera vez iniciando el sistema, por favor cree un usuario/personal para continuar.", "Requisito de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form frmRegistro = new frmIngresoAdmin();
                frmRegistro.ShowDialog();
                /*Properties.Settings.Default.isPrimerInicio = false;
                Properties.Settings.Default.Save();*/
            }
            else if (txtdentidad.Text != String.Empty && txtContrase.Text != String.Empty && Properties.Settings.Default.isPrimerInicio == false)
            {
                if (dbConn.comprobarUsuario(txtdentidad.Text, utilidad.EncriptarTexto(txtContrase.Text)))
                {
                    MessageBox.Show("HOLA MUNDO");
                }
                else
                {
                      MessageBox.Show("Usuario o Contraseña incorrectos!", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Introduzca Valores!", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenuAtras_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarPrograma_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblOlvideContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmRecu = new frmRecuperacionContrasenia();
            frmRecu.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarContra.Checked == true)
            {
                txtContrase.PasswordChar = '\0';
            }
            else
            {
                txtContrase.PasswordChar = '●';
            }
        }
    }
}
