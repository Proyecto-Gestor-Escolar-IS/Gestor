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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        databaseConnection dbConn = new databaseConnection();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtdentidad.Text != String.Empty && txtContrase.Text != String.Empty)
            {
                if(dbConn.comprobarUsuario(txtdentidad.Text, txtContrase.Text))
                {
                    MessageBox.Show("Hola Mundo");
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            dbConn.establecerConexion();
        }
    }
}
