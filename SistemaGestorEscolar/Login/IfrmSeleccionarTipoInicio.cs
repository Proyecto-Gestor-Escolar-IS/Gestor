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
        InterfazGraficaPrincipal interfazPrincipal = new InterfazGraficaPrincipal();
        private void IfrmSeleccionarTipoInicio_Load(object sender, EventArgs e)
        {
            int codigoTipos = 0;
            dbConn.llenarDGV(dgvTiposCargos, "SELECT descripcionCargo FROM datosEmpleados de INNER JOIN detalleCargos dc ON de.identidadPersona = dc.identidadEmpleado " +
                "INNER JOIN cargos c ON dc.idCargoAsociado = c.id_Cargo WHERE de.identidadPersona = '" + clsVariablesGlobales.NumIdentidad + "' ");
            string nombre = dbConn.obtenerVariableString("SELECT CONCAT(primerNombre, ' ', segundoNombre) FROM datosEmpleados WHERE identidadPersona = '" + clsVariablesGlobales.NumIdentidad + "' ");
            lblSaludo.Text = "BUEN DÍA " + nombre.ToUpper() + ", ESPERAMOS QUE TENGAS UN EXCELENTE DÍA.";
            foreach (DataGridViewRow Datarow in dgvTiposCargos.Rows)
            {
                if(Datarow.Cells[0].Value.ToString() == "Super Usuario")
                {
                    codigoTipos = -1;
                }
                else if(Datarow.Cells[0].Value.ToString() == "Administrador")
                {
                    codigoTipos +=1;
                }
                else if(Datarow.Cells[0].Value.ToString() == "Docente")
                {
                    codigoTipos += 2;
                }
                else if(Datarow.Cells[0].Value.ToString() == "Medico")
                {
                    codigoTipos +=5;
                }
            }

            switch (codigoTipos)
            {
                case -1:
                    btnSuperUsuario.Visible = true;
                    break;
                case 1:
                    btnAdmin.Visible = true;
                    break;
                case 2:
                    btnDocenteSolo.Visible = true;
                    break;
                case 3:
                    btnDocenteMasAdmin.Visible = true;
                    btnAdmin.Visible = true;
                    break;
                case 5:
                    btnMedico.Visible = true;
                    break;
                case 6:
                    btnAdmin.Visible = true;
                    btnMedico.Visible = true;
                    break;
                case 7:
                    btnDocenteMasAdmin.Visible = true;
                    btnMedico.Visible = true;
                    break;
                case 8:
                    btnAdmin.Visible = true;
                    btnDocenteMasAdmin.Visible = true;
                    btnMedico.Visible = true;
                    break;
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

            interfazPrincipal.Show();
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            
            clsVariablesGlobales.CodigoAcceso = 1;

            interfazPrincipal.Show();
            this.Hide();
        }

        private void btnDocenteMasAdmin_Click(object sender, EventArgs e)
        {
            clsVariablesGlobales.CodigoAcceso = 2;

            interfazPrincipal.Show();
            this.Close();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            clsVariablesGlobales.CodigoAcceso = 3;

            interfazPrincipal.Show();
            this.Close();
        }

        private void btnDocenteSolo_Click(object sender, EventArgs e)
        {
            clsVariablesGlobales.CodigoAcceso = 2;
            interfazPrincipal.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
