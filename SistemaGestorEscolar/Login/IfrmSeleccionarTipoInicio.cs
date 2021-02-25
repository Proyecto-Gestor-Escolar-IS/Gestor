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
    public partial class IfrmSeleccionarTipoInicio : Form
    {
        public IfrmSeleccionarTipoInicio()
        {
            InitializeComponent();
        }

        databaseConnection dbConn = new databaseConnection();

        private void IfrmSeleccionarTipoInicio_Load(object sender, EventArgs e)
        {
            int codigoTipos = 0;
            dbConn.llenarDGV(dgvTiposCargos, "SELECT descripcionCargo FROM datosEmpleados de INNER JOIN detalleCargos dc ON de.identidadPersona = dc.identidadEmpleado " +
                "INNER JOIN cargos c ON dc.idCargoAsociado = c.id_Cargo WHERE de.identidadPersona = '" + clsVariablesGlobales.NumIdentidad + "' ");

            foreach(DataGridViewRow Datarow in dgvTiposCargos.Rows)
            {
                if(Datarow.Cells[0].Value.ToString() == "Super Usuario")
                {
                    codigoTipos = -1;
                }
                else if(Datarow.Cells[0].Value.ToString() == "Administrador")
                {
                    codigoTipos = 1;
                }
                else if(Datarow.Cells[0].Value.ToString() == "Docente")
                {
                    codigoTipos += 2;
                }
                else if(Datarow.Cells[0].Value.ToString() == "Medico")
                {
                    codigoTipos = 5;
                }
            }

            MessageBox.Show(codigoTipos.ToString());
            if (codigoTipos == -1)
            {
                btnSuperUsuario.Visible = true;
            }
            else if(codigoTipos == 1)
            {
                btnAdmin.Visible = true;
            }
            else if(codigoTipos == 2)
            {
                btnDocenteSolo.Visible = true;
            }
            else if(codigoTipos == 3)
            {
                btnDocenteMasAdmin.Visible = true;
                btnAdmin.Visible = true;
            }
            else if(codigoTipos == 5)
            {
                btnMedico.Visible = true;
            }

        }

        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenuAtras_Click(object sender, EventArgs e)
        {
            IfrmLogin frmLogin = new IfrmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void btnSuperUsuario_Click(object sender, EventArgs e)
        {
            clsVariablesGlobales.CodigoAcceso = 0;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            clsVariablesGlobales.CodigoAcceso = 1;
        }

        private void btnDocenteMasAdmin_Click(object sender, EventArgs e)
        {
            clsVariablesGlobales.CodigoAcceso = 2;
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            clsVariablesGlobales.CodigoAcceso = 3;
        }

        
    }
}
