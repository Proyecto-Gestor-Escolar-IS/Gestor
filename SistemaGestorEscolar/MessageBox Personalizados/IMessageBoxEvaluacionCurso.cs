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
    public partial class IMessageBoxEvaluacionCurso : Form
    {
        public IMessageBoxEvaluacionCurso()
        {
            InitializeComponent();
        }

        //Cuando se presione el boton ACEPTAR el valor retornara verdadero, cuando se presione CANCELAR falso 
        public static bool formaEva = false;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            formaEva = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formaEva = false;
            this.Close();
        }
    }
}
