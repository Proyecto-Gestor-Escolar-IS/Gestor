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

namespace SistemaGestorEscolar
{
    public partial class IMessageBoxInformation : Form
    {
        public IMessageBoxInformation()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IMessageBoxInformation_Load(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }
    }
}
