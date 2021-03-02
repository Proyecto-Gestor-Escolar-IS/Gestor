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

            if(dgvEmpleados.CurrentCell != null && dgvEmpleados.DataSource != null)
            {
                /**/
                cmbActCargo.Items.Clear();
                pnldgv.Hide();
                grpActualizar.Show();
                txtActIdent.Text = identidad;
                dbConn.llenarTextBox(txtActNombre1, "SELECT primerNombre FROM datosEmpleados WHERE identidadPersona = '" +identidad+ "' ");
                dbConn.llenarTextBox(txtActNombre2, "SELECT segundoNombre FROM datosEmpleados WHERE identidadPersona = '" + identidad + "' ");
                dbConn.llenarTextBox(txtActApellido1, "SELECT primerApellido FROM datosEmpleados WHERE identidadPersona = '" + identidad + "' ");
                dbConn.llenarTextBox(txtActApellido2, "SELECT segundoApellido FROM datosEmpleados WHERE identidadPersona = '" + identidad + "' ");
                dbConn.llenarTextBox(txtActMail, "SELECT correoElectronico FROM datosEmpleados WHERE identidadPersona = '" + identidad + "' ");

                txtActTelef.Text = dbConn.obtenerVariableString("SELECT numeroTelefono FROM datosEmpleados WHERE identidadPersona = '" + identidad + "' ");
                txtActFechaNac.Text = dbConn.obtenerVariableString("SELECT correoElectronico FROM datosEmpleados WHERE identidadPersona = '" + identidad + "' ");
                string contra = utilidades.DesEncriptar(dbConn.obtenerVariableString("SELECT contraseniaEmpleado FROM datosEmpleados WHERE identidadPersona = '" + identidad + "' "));
                txtActContra.Text = contra;
                txtActConfContra.Text = contra;
                txtActFechaNac.Text = dbConn.obtenerVariableDate("SELECT fechaNacimiento FROM datosEmpleados WHERE identidadPersona = '" + identidad + "' ").ToShortDateString();
                lblActEstado.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();

                switch (codigoCargo)
                {
                    case 1:
                        lblActCargoActual.Text = "Super Usuario";
                        dbConn.llenarComboBox(cmbActCargo, "SELECT descripcionCargo FROM cargos");
                        break;
                    case 2:
                        lblActCargoActual.Text = "Administrador";
                        dbConn.llenarComboBox(cmbActCargo, "SELECT descripcionCargo FROM cargos WHERE descripcionCargo <> 'Super Usuario'");
                        break;
                    case 3:
                        lblActCargoActual.Text = "Docente";
                        dbConn.llenarComboBox(cmbActCargo, "SELECT descripcionCargo FROM cargos WHERE descripcionCargo <> 'Super Usuario'");
                        break;
                    case 4:
                        lblActCargoActual.Text = "Medico";
                        dbConn.llenarComboBox(cmbActCargo, "SELECT descripcionCargo FROM cargos WHERE descripcionCargo <> 'Super Usuario'");
                        break;
                    default:
                        lblActCargoActual.Text = dbConn.obtenerVariableString("SELECT TOP 1(descripcionCargo) FROM datosEmpleados de INNER JOIN detalleCargos det ON de.identidadPersona = det.identidadEmpleado " +
                            "INNER JOIN cargos ca ON det.idCargoAsociado = ca.id_Cargo where de.identidadPersona = '" + identidad + "' ");
                        dbConn.llenarComboBox(cmbActCargo, "SELECT descripcionCargo FROM cargos WHERE descripcionCargo <> 'Super Usuario'");
                        break;
                }
                cmbActCargo.Text = "SELECCIONE";
                cmbActCargo.Items.Add("NO ACTUALIZAR");

            }
            else
            {
                boxError.lblError.Location = new Point(118, 68);
                boxError.lblError.Text = "SELECCIONE UNA CELDA\nPARA CONTINUAR";
                boxError.lblError.TextAlign = ContentAlignment.MiddleCenter;
                boxError.ShowDialog();
            }

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            identidad = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnInactivos_Click(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvEmpleados, "SELECT id_Registro as 'ID', identidadPersona as 'N° IDENTIDAD', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'NOMBRE'," +
                " numeroTelefono as 'TELÉFONO', fechaNacimiento as 'FECHA DE NACIMIENTO', c.descripcionCargo as 'CARGO', descripcionEstado as 'ESTADO' " +
                "FROM datosEmpleados de INNER JOIN estados es ON de.estadoEmpleado = es.id_Estado " +
                "INNER JOIN detalleCargos dc on de.identidadPersona = dc.identidadEmpleado INNER JOIN cargos c on dc.idCargoAsociado = c.id_Cargo WHERE es.id_Estado = 2");
        }

        private void chkActVerContra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActVerContra.Checked)
            {
                txtActConfContra.PasswordChar = '\0';
                txtActContra.PasswordChar = '\0';
                
            }
            else
            {
                txtActContra.PasswordChar = '●';
                txtActConfContra.PasswordChar = '●';
            }   
        }

        private void btnActBorrar_Click(object sender, EventArgs e)//btnActLimpiar
        {
            actReset();
        }

        private void actReset()
        {
            utilidades.limpiarTextBox(grpActualizar);
            cmbActCargo.Items.Clear();
            lblActEstado.Text = "Elija un Empleado";
            lblActCargoActual.Text = "Elija un Empleado";
        }

        private void txtLikeIdentidad_TextChanged(object sender, EventArgs e)
        {
            iniciarDGV(txtLikeIdentidad.Text);
            codigoCargo = -1;
        }

        private void iniciarDGV(string text)
        {
            dbConn.llenarDGV(dgvEmpleados, "SELECT id_Registro as 'ID', identidadPersona as 'N° IDENTIDAD', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'NOMBRE'," +
                " numeroTelefono as 'TELÉFONO', fechaNacimiento as 'FECHA DE NACIMIENTO', descripcionEstado as 'ESTADO' " +
                "FROM datosEmpleados de INNER JOIN estados es ON de.estadoEmpleado = es.id_Estado " +
                "INNER JOIN detalleCargos dc on de.identidadPersona = dc.identidadEmpleado INNER JOIN cargos c on dc.idCargoAsociado = c.id_Cargo WHERE es.id_Estado <> 2 AND identidadEmpleado like '"+text+"%' ");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int vaActualizar;
            if (comprobaciones())
            {
                if(cmbActCargo.Text == "NO ACTUALIZAR")
                {
                    vaActualizar = -1;
                }
                else
                {
                    vaActualizar = dbConn.obtenerVariableEntera("SELECT id_Cargo FROM cargos WHERE descripcionCargo = '"+cmbActCargo.Text+"' ");
                }

                if (dbConn.PAOperacionEmpleado(txtActIdent.Text, txtActNombre1.Text, txtActNombre2.Text, txtActApellido1.Text, txtActApellido2.Text, Convert.ToInt32(txtActTelef.Text), txtActFechaNac.Text,
                            txtActMail.Text, 1, utilidades.EncriptarTexto(txtActConfContra.Text), vaActualizar, codigoCargo, 2))
                {
                    messageOk.ShowDialog();
                    grpActualizar.Hide();
                    pnldgv.Show();
                    txtLikeIdentidad.Clear();
                    actReset();
                }
            }
            dgvEmpleados.DataSource = null;
        }

        private bool comprobaciones()
        {
            string txtIdentid = txtActIdent.Text;
            string txtNum = txtActTelef.Text;
            if (txtIdentid.Trim() != string.Empty && txtActNombre1.Text != string.Empty && txtActApellido1.Text != string.Empty && txtNum != string.Empty &&
                txtActMail.Text != string.Empty && txtActContra.Text != string.Empty && txtActConfContra.Text != string.Empty && txtActFechaNac.Text != string.Empty &&
                txtIdentid.Trim().Length == 13 && txtNum.Trim().Length == 8 && cmbActCargo.Text != string.Empty && cmbActCargo.Text != "SELECCIONE")
            {
                if (txtActConfContra.TextLength >= 6)
                {
                    if (utilidades.verificarCorreo(txtActMail.Text))
                    {
                        messageYesNo.lblError.Text = "¿HA REVISADO SUS DATOS \r\nY DESEA CONTINUAR?";
                        messageYesNo.lblError.TextAlign = ContentAlignment.MiddleCenter;
                        messageYesNo.ShowDialog();
                        if (IMessageBoxYesCancel.isCodigoForm)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        boxError.lblError.Text = "VERIFIQUE CORREO \n\rELECTRÓNICO";
                        boxError.lblError.TextAlign = ContentAlignment.MiddleCenter;
                        boxError.lblError.Location = new Point(130, 75);
                        boxError.ShowDialog();
                    }
                }
                else
                {
                    boxWarning.ShowDialog();
                    txtContra.Focus();
                }

            }
            else
            {
                boxError.lblError.Text = "VERIFIQUE LOS VALORES";
                boxError.lblError.Location = new Point(130, 82);
                boxError.ShowDialog();
            }
            return false;
        }
    }
}
