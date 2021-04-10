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
using SistemaGestorEscolar.Utilidades;

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
        IMessageBoxSiNo siNo = new IMessageBoxSiNo();
        private Modulos_de_Arranque.verficacionArranque actualizarModulos = new Modulos_de_Arranque.verficacionArranque();


        private bool windowMove = false;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            dbConn.establecerConexion();
            actualizarModulos.verificarFecha();
            ClsCambioTema.cambiarTemaBoton(panelPrincipal);
      

            ClsCambioTema.cambiarTemaBoton(panel1);
            if (Properties.Settings.Default.isModoOscuro == true)
            {
   

                panelPrincipal.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                panel1.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);

            }
            else
            {


                panelPrincipal.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                panel1.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);

            }

            btnSalir.ForeColor = Color.White;
            btnSalir.Active1 = Color.Red;
            btnSalir.Active2 = Color.Red;
            btnSalir.Inactive1 = Color.Red;
            btnSalir.Inactive2 = Color.Red;
            btnSalir.StrokeColor = Color.Red;
            picImagotipo.BackColor = Color.FromArgb(0, 97, 169);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int primerInicio = dbConn.obtenerVariableEntera("SELECT COUNT(*) FROM datosEmpleados");

            if (primerInicio == 0)
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
            siNo.ShowDialog();
        }

        private void btnCerrarPrograma_Click_1(object sender, EventArgs e)
        {
            siNo.ShowDialog();
            //Application.Exit();
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            windowMove = true;
        }

        private void panSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (windowMove == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void panSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            windowMove = false;
        }

        private void picImagotipo_Click(object sender, EventArgs e)
        {

        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            siNo.ShowDialog();
        }
    }
}
