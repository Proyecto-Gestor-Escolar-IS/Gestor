using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestorEscolar.MessageBox_Personalizados;

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
        IMessageBoxLoginIncorrecto message = new IMessageBoxLoginIncorrecto();
        IMessageBoxInformation message2 = new IMessageBoxInformation();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            dbConn.establecerConexion();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int primerInicio = dbConn.obtenerVariableEntera("SELECT COUNT(*) FROM datosEmpleados");
            if (primerInicio == 0 && txtdentidad.Text == String.Empty && txtContrase.Text == String.Empty)
            {
                message2.lblError.Text = "ESTA ES SU PRIMERA VEZ INICIANDO \r\nEL SISTEMA, POR FAVOR CREE UN \r\nSUPER USUARIO PARA CONTINUAR.";
                message2.lblError.Font = new System.Drawing.Font("Balsamiq Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                message2.lblError.Location = new Point(100, 60);
                message2.ShowDialog();
                Form frmRegistro = new frmIngresoAdmin();
                frmRegistro.ShowDialog();
            }
            else if (txtdentidad.Text != String.Empty && txtContrase.Text != String.Empty && primerInicio != 0)
            {
                if (dbConn.comprobarUsuario(txtdentidad.Text, utilidad.EncriptarTexto(txtContrase.Text)))
                {
                    clsVariablesGlobales.NumIdentidad = txtdentidad.Text;
                    IfrmSeleccionarTipoInicio frmTipoI = new IfrmSeleccionarTipoInicio();
                    frmTipoI.Show();
                    this.Hide();
                }
                else
                {
                    message.lblError.Location = new Point(118, 65);
                    message.lblError.Text = "USUARIO O CONTRASEÑA \r\nINCORRECTOS";
                    message.ShowDialog();
                }
            }
            else
            {
                message.lblError.Location = new Point(129, 65);
                message.lblError.Text = "INTRODUZCA VALORES";
                message.ShowDialog();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
