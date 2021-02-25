using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.MessageBox_Personalizados
{
    public partial class IMessageBoxYesCancel : Form
    {
        public IMessageBoxYesCancel()
        {
            InitializeComponent();
        }

        //Cuando se presione el boton ACEPTAR el valor retornara verdadero, cuando se presione CANCELAR falso 
        public static bool isCodigoForm = false;

        private void IMessageBoxYesCancel_Load(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            isCodigoForm = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            isCodigoForm = false;
            this.Close();
        }
    }
}
