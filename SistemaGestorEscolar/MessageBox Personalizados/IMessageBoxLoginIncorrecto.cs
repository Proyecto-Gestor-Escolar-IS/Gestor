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
    public partial class IMessageBoxLoginIncorrecto : Form
    {
        public IMessageBoxLoginIncorrecto()
        {
            InitializeComponent();
        }

        private void IMessageBoxLoginIncorrecto_Load(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
