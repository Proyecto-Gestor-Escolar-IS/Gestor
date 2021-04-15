using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.MessageBox_Personalizados
{
    public partial class IMessageBoxCerrarSesion : Form
    {
        public IMessageBoxCerrarSesion()
        {
            InitializeComponent();
        }
        //Cuando se presione el boton ACEPTAR el valor retornara verdadero, cuando se presione CANCELAR falso 
        public static bool isCodigoForm = false;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Login.IfrmLogin login = new Login.IfrmLogin();
            login.Show();
         
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            isCodigoForm = false;
            this.Close();
        }
    }
}
