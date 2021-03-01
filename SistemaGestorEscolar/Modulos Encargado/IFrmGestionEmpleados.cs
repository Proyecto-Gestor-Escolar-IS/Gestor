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

        databaseConnection dbConn = new databaseConnection();

        private void IFrmGestionEmpleados_Load(object sender, EventArgs e)
        {
            dbConn.establecerConexion();
        }


        private void altoButton1_Click(object sender, EventArgs e)
        {
            pnlSelector.Hide();
            grpRegistroEmpleado.Show();
        }

        private void btnActualizacion_Click(object sender, EventArgs e)
        {
            pnlSelector.Hide();
            pnldgv.Show();
            dgvEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnRegresarDGVAct_Click(object sender, EventArgs e)
        {
            pnldgv.Hide();
            pnlSelector.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            grpRegistroEmpleado.Hide();
            pnlSelector.Show();
        }

        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "ADMINISTRADORES";
            dbConn.llenarDGV(dgvEmpleados, "SELECT * FROM datosEmpleados");
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "DOCENTES";
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "MEDICOS";
        }

        private void btnActRegresar_Click(object sender, EventArgs e)
        {
            grpActualizar.Hide();
            pnldgv.Show();
        }

        private void btnSiguienteDGVAct_Click(object sender, EventArgs e)
        {
            pnldgv.Hide();
            grpActualizar.Show();
        }
    }
}
