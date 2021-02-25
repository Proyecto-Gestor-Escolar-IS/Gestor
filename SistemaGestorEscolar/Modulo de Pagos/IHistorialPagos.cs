using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Modulo_de_Pagos
{
    public partial class IHistorialPagos : Form
    {
        public IHistorialPagos()
        {
            InitializeComponent();
        }
        databaseConnection dbConn = new databaseConnection();
        private void IHistorialPagos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNoIdentidadEstudiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultarID_Click(object sender, EventArgs e)
        {
            dbConn.llenarTextBox(txtNombreEstudiante, "SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM datosEstudiante WHERE identidadEstudiante = " + txtNoIdentidadEstudiante.Text);

            dbConn.llenarDataGridPagos(dgvHistorialPagos, txtNoIdentidadEstudiante.Text);
        }
    }
}
