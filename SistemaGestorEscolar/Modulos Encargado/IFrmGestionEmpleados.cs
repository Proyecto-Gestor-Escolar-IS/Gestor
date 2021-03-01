using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Modulos_Encargado
{
    public partial class IFrmGestionEmpleados : Form
    {
        public IFrmGestionEmpleados()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hoolg");
            //pnlSelector.Hide();
            grpRegistroEmpleado.Show();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            pnlSelector.Hide();
            grpRegistroEmpleado.Show();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hoolg");
        }

        private void altoButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hoolg");
        }
    }
}
