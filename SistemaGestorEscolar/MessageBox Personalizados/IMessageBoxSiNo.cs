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
    public partial class IMessageBoxSiNo : Form
    {
        public IMessageBoxSiNo()
        {
            InitializeComponent();
        }

        //Cuando se presione el boton ACEPTAR el valor retornara verdadero, cuando se presione CANCELAR falso 
        public static bool isCodigoForm = false;

        private void btnAceptar_Click(object sender, EventArgs e)
        { 
           Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            isCodigoForm = false;
            this.Close();
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}
