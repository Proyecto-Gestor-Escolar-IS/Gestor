using SistemaGestorEscolar.MessageBox_Personalizados;
using SistemaGestorEscolar.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Modulos_de_Empleados
{
    public partial class IFrmGestionEmpleados : Form
    {
        public IFrmGestionEmpleados()
        {
            InitializeComponent();
        }

        databaseConnection dbConn = new databaseConnection();
        IMessageBoxError boxError = new IMessageBoxError();
        clsUtilidades utilidades = new clsUtilidades();
        IMessageBoxWarning boxWarning = new IMessageBoxWarning();
        IMessageBoxCheck messageOk = new IMessageBoxCheck();
        IMessageBoxYesCancel messageYesNo = new IMessageBoxYesCancel();

        int codigoCargo;
        string identidad;
        bool isInactivo = false;
        bool isSuper = false;

        private void IFrmGestionEmpleados_Load(object sender, EventArgs e)
        {
            dbConn.establecerConexion();
            ClsCambioTema.cambiarTemaBoton(pnlSelector);
            ClsCambioTema.cambiarTemaBoton(pnldgv);
            ClsCambioTema.cambiarTemaBoton(grpActualizar);
            ClsCambioTema.cambiarTemaBoton(grpRegistroEmpleado);
        }


        private void altoButton1_Click(object sender, EventArgs e)
        {
            pnlSelector.Hide();
            grpRegistroEmpleado.Show();
            identidad = "0";
            utilidades.limpiarTextBox(grpRegistroEmpleado);
            cmbCargosSec.Items.Clear();
            dbConn.llenarComboBoxValorInicial(cmbCargosSec, "SELECT descripcionCargo FROM cargos WHERE descripcionCargo <> 'Super Usuario'");
            cmbCargosSec.SelectedItem = "<SELECCIONE>";
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
            iniciarDGV(2);
            codigoCargo = 2;
            isInactivo = false;
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "DOCENTES";
            iniciarDGV(3);
            codigoCargo = 3;
            isInactivo = false;
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "MEDICOS";
            iniciarDGV(4);
            codigoCargo = 4;
            isInactivo = false;
        }

        private void iniciarDGV(int idC)
        {
            dbConn.llenarDGV(dgvEmpleados, "SELECT id_Registro as 'ID', identidadPersona as 'N° IDENTIDAD', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'NOMBRE'," +
                " numeroTelefono as 'TELÉFONO', fechaNacimiento as 'FECHA DE NACIMIENTO', descripcionEstado as 'ESTADO' " +
                "FROM datosEmpleados de INNER JOIN estados es ON de.estadoEmpleado = es.id_Estado " +
                "INNER JOIN detalleCargos dc on de.identidadPersona = dc.identidadEmpleado INNER JOIN cargos c on dc.idCargoAsociado = c.id_Cargo WHERE c.id_Cargo = '"+idC+"' AND es.id_Estado <> 2");
        }

        private void btnActRegresar_Click(object sender, EventArgs e)
        {
            identidad = null;
                lblTitulo.Text = "EMPLEADOS";
                isInactivo = false;
            isSuper = false;
                dgvEmpleados.DataSource = null;
                actReset();
                grpActualizar.Hide();
                pnldgv.Show();
                txtLikeIdentidad.Clear();
        }

        private void btnSiguienteDGVAct_Click(object sender, EventArgs e)
        {
            isSuper = false;
            if (isInactivo)
            {
                btnActualizar.Enabled = false;
                btnEliminarCargo.Enabled = false;
                btnBorrar.Enabled = false;
            }
            else
            {
                btnActualizar.Enabled = true;
                btnEliminarCargo.Enabled = true;
                btnBorrar.Enabled = true;
            }

            btnEliminarCargo.Visible = true;
            btnBorrar.Visible = true;
            btnAgregarCargo.Visible = true;
            btnActualizar.Visible = true;
            btnSiguiente.Visible = true;
            btnActLimpiar.Visible = false;
            btnSiguiente.Visible = false;
            btnRecuActualizar.Visible = false;
            btnLimpiarRecu.Visible = false;

            if (dgvEmpleados.CurrentCell != null && dgvEmpleados.DataSource != null && identidad != null)
            {
                chkActVerContra.Checked = false;
                cmbActCargo.Enabled = true;
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
                txtActFechaNac.Text = dbConn.obtenerVariableDate("SELECT fechaNacimiento FROM datosEmpleados WHERE identidadPersona = '" + identidad + "' ").ToString("dd/MM/yyyy");
                lblActEstado.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();

                dbConn.llenarComboBoxValorInicial(cmbActCargo, "SELECT descripcionCargo FROM cargos WHERE descripcionCargo <> 'Super Usuario'");
                switch (codigoCargo)
                {
                    case 1:
                        lblActCargoActual.Text = "Super Usuario";
                        cmbActCargo.Items.Clear();
                        dbConn.llenarComboBoxValorInicial(cmbActCargo, "SELECT descripcionCargo FROM cargos");
                        break;
                    case 2:
                        lblActCargoActual.Text = "Administrador";
                        break;
                    case 3:
                        lblActCargoActual.Text = "Docente";
                        break;
                    case 4:
                        lblActCargoActual.Text = "Medico";
                        break;
                    default:
                        lblActCargoActual.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
                        break;
                }
                //cmbActCargo.Text = "SELECCIONE";
                cmbActCargo.Items.Add("<NO ACTUALIZAR>");
                cmbActCargo.SelectedItem = "<SELECCIONE>";

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
            
            if(dgvEmpleados.CurrentRow is null)
            {
                boxError.lblError.Location = new Point(118, 68);
                boxError.lblError.Text = "SELECCIONE UNA CELDA\nPARA CONTINUAR";
                boxError.lblError.TextAlign = ContentAlignment.MiddleCenter;
                boxError.ShowDialog();
            }
            else
            {
                identidad = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            }
    
        }

        private void btnInactivos_Click(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvEmpleados, "SELECT id_Registro as 'ID', identidadPersona as 'N° IDENTIDAD', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'NOMBRE'," +
                " numeroTelefono as 'TELÉFONO', fechaNacimiento as 'FECHA DE NACIMIENTO', descripcionEstado as 'ESTADO' " +
                "FROM datosEmpleados de INNER JOIN estados es ON de.estadoEmpleado = es.id_Estado WHERE es.id_Estado = 2");
            isInactivo = true;
            codigoCargo = -1;
            lblTitulo.Text = "INACTIVOS";
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

        
        private void actReset()//Limpia los valores que esten en el groupBox Actualizar
        {
            utilidades.limpiarTextBox(grpActualizar);
            cmbActCargo.Items.Clear();
            cmbActCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            lblActEstado.Text = "Elija un Empleado";
            lblActCargoActual.Text = "Elija un Empleado";
            if (isSuper)
            {
                txtActIdent.Text = identidadAdmin;
                cmbActCargo.DropDownStyle = ComboBoxStyle.DropDown;
                cmbActCargo.Text = "NO APLICA";
                lblActEstado.Text = "Activo";
                lblActCargoActual.Text = "Super Usuario";
            }
            else
            {
                txtActIdent.Text = identidad;
            }
           
        }

        private void txtLikeIdentidad_TextChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = "EMPLEADOS";
            iniciarDGV(txtLikeIdentidad.Text);
            codigoCargo = -1;
        }

        private void iniciarDGV(string text)
        {
            dbConn.llenarDGV(dgvEmpleados, "SELECT id_Registro as 'ID', identidadPersona as 'N° IDENTIDAD', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'NOMBRE'," +
                " numeroTelefono as 'TELÉFONO', fechaNacimiento as 'FECHA DE NACIMIENTO', c.descripcionCargo as 'CARGO', descripcionEstado as 'ESTADO' " +
                "FROM datosEmpleados de INNER JOIN estados es ON de.estadoEmpleado = es.id_Estado " +
                "INNER JOIN detalleCargos dc on de.identidadPersona = dc.identidadEmpleado INNER JOIN cargos c on dc.idCargoAsociado = c.id_Cargo WHERE es.id_Estado <> 2 AND (identidadEmpleado like '"+text+"%' OR primerNombre like '"+text+"%') ");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int vaActualizar;
            if (comprobaciones())
            {
                if (cmbActCargo.Text == "<NO ACTUALIZAR>" || cmbActCargo.SelectedItem is "<SELECCIONE>")
                {
                    vaActualizar = -1;
                    dbConn.PAOperacionEmpleado(txtActIdent.Text, txtActNombre1.Text, txtActNombre2.Text, txtActApellido1.Text, txtActApellido2.Text, Convert.ToInt32(txtActTelef.Text), txtActFechaNac.Text,
                            txtActMail.Text, 1, utilidades.EncriptarTexto(txtActConfContra.Text), codigoCargo, vaActualizar, 2);
                    messageOk.lblCheck.Text = "ACTUALIZADO CORRECTAMENTE";
                    messageOk.ShowDialog();
                    grpActualizar.Hide();
                    pnldgv.Show();
                    txtLikeIdentidad.Clear();
                    actReset();
                }
                else
                {
                     if (codigoCargo == -1)
                     {
                         codigoCargo = dbConn.obtenerVariableEntera("SELECT id_Cargo FROM cargos WHERE descripcionCargo = '" + lblActCargoActual.Text + "' ");
                     }
                     vaActualizar = dbConn.obtenerVariableEntera("SELECT id_Cargo FROM cargos WHERE descripcionCargo = '"+cmbActCargo.Text+"' ");
       
                    if (dbConn.PAAgregarYComprobarCargo(identidad, vaActualizar, 2) == false)
                    {
                        dbConn.PAOperacionEmpleado(txtActIdent.Text, txtActNombre1.Text, txtActNombre2.Text, txtActApellido1.Text, txtActApellido2.Text, Convert.ToInt32(txtActTelef.Text), txtActFechaNac.Text,
                             txtActMail.Text, 1, utilidades.EncriptarTexto(txtActConfContra.Text), vaActualizar, codigoCargo, 2);
                        messageOk.lblCheck.Text = "ACTUALIZADO CORRECTAMENTE";
                        messageOk.ShowDialog();
                        grpActualizar.Hide();
                        pnldgv.Show();
                        txtLikeIdentidad.Clear();
                        actReset();
                    }
                    else
                    {
                        boxError.lblError.Text = "ESTA PERSONA \n\rYA TIENE ESTE CARGO\n\r REGISTRADO";
                        boxError.lblError.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        boxError.lblError.TextAlign = ContentAlignment.MiddleCenter;
                        boxError.lblError.Location = new Point(125, 60);
                        boxError.ShowDialog();
                    }
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
                txtIdentid.Trim().Length == 13 && txtNum.Trim().Length == 8 && cmbActCargo.Text != string.Empty/* && cmbActCargo.Text != "<SELECCIONE>"*/)
            {
                if (utilidades.isDate(txtActFechaNac.Text))
                {
                    if (txtActContra.TextLength >= 6)
                    {
                        if(txtActConfContra.Text == txtActContra.Text)
                        {
                            if (utilidades.verificarCorreo(txtActMail.Text))
                            {
                                messageYesNo.lblError.Text = "¿HA REVISADO SUS DATOS \r\nY DESEA CONTINUAR?";
                                messageYesNo.lblError.Location = new Point(96, 67);
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
                            boxError.lblError.Text = "CONTRASEÑAS NO COINCIDEN";
                            boxError.lblError.Location = new Point(120, 82);
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
                    boxError.lblError.Text = "INGRESE UNA FECHA VALIDA";
                    boxError.lblError.Location = new Point(120, 82);
                    boxError.ShowDialog();
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

        private void cmbActCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnEliminarCargo_Click(object sender, EventArgs e)
        {
            cmbActCargo.SelectedItem = "<NO ACTUALIZAR>";
            cmbActCargo.Enabled = false;
            if (comprobaciones())
            {
                if(dbConn.obtenerVariableEntera("SELECT COUNT(*) FROM detalleCargos WHERE identidadEmpleado = '"+identidad+"' ") > 1)
                {
                    codigoCargo = dbConn.obtenerVariableEntera("SELECT id_Cargo FROM cargos WHERE descripcionCargo = '" + lblActCargoActual.Text + "' ");
                    if (dbConn.ejecutarComandoSQL("DELETE FROM detalleCargos WHERE idCargoAsociado = '" + codigoCargo + "' AND identidadEmpleado = '" + identidad + "' "))
                    {
                        messageOk.lblCheck.Text = "ELIMINADO CORRECTAMENTE";
                        messageOk.ShowDialog();
                        grpActualizar.Hide();
                        pnldgv.Show();
                        txtLikeIdentidad.Clear();
                        actReset();
                    }
                }
                else
                {
                    boxError.lblError.Text = "NO SE PUEDE ELMINAR ESTE CARGO.\n\rESTA PERSONA SOLO TIENE 1 CARGO.\n\r SI DESEA ELIMINAR A UN EMPLEADO\r\nUTILICE LA OPCION INHABILITAR";
                    boxError.lblError.Font = new System.Drawing.Font("Balsamiq Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    boxError.lblError.TextAlign = ContentAlignment.MiddleCenter;
                    boxError.lblError.Location = new Point(95, 45);
                    boxError.ShowDialog();
                    cmbActCargo.Enabled = true;
                }   
            }
            dgvEmpleados.DataSource = null;
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            if (comprobaciones())
            {
                if (cmbActCargo.Text != "<SELECCIONE>" && cmbActCargo.Text != "<NO ACTUALIZAR>")
                {
                    codigoCargo = dbConn.obtenerVariableEntera("SELECT id_Cargo FROM cargos WHERE descripcionCargo = '" + cmbActCargo.Text + "' ");
                    if (isInactivo && dbConn.PAOperacionEmpleado(txtActIdent.Text, txtActNombre1.Text, txtActNombre2.Text, txtActApellido1.Text, txtActApellido2.Text, Convert.ToInt32(txtActTelef.Text), txtActFechaNac.Text,
                             txtActMail.Text, 1, utilidades.EncriptarTexto(txtActConfContra.Text), codigoCargo, -1, 2) && dbConn.ejecutarComandoSQL("INSERT INTO detalleCargos VALUES ('"+identidad+"', '"+codigoCargo+"')"))
                    {
                        messageOk.lblCheck.Text = "REHABILITADO CORRECTAMENTE";
                        messageOk.lblCheck.Location = new Point(115, 83);
                        messageOk.ShowDialog();
                        grpActualizar.Hide();
                        pnldgv.Show();
                        txtLikeIdentidad.Clear();
                        actReset();
                    }
                    else
                    {
                        if (dbConn.PAAgregarYComprobarCargo(identidad, codigoCargo, 1))
                        {
                            messageOk.lblCheck.Text = "AGREGADO CORRECTAMENTE";
                            messageOk.ShowDialog();
                            grpActualizar.Hide();
                            pnldgv.Show();
                            txtLikeIdentidad.Clear();
                            actReset();
                        }
                        else
                        {
                            boxError.lblError.Text = "ESTA PERSONA \n\rYA TIENE ESTE CARGO\n\r REGISTRADO";
                            boxError.lblError.Font = new System.Drawing.Font("Balsamiq Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            boxError.lblError.TextAlign = ContentAlignment.MiddleCenter;
                            boxError.lblError.Location = new Point(125, 60);
                            boxError.ShowDialog();
                        }
                    }
                }
                else
                {
                    boxError.lblError.Text = "NO PUEDE INGRESAR\n\r ESTE CARGO";
                    boxError.lblError.Font = new System.Drawing.Font("Balsamiq Sans", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    boxError.lblError.TextAlign = ContentAlignment.MiddleCenter;
                    boxError.lblError.Location = new Point(125, 64);
                    boxError.ShowDialog();
                }
            }
            dgvEmpleados.DataSource = null;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            cmbActCargo.SelectedItem = "<NO ACTUALIZAR>";
            cmbActCargo.Enabled = false;
            if (comprobaciones())
            {
                messageYesNo.lblError.Text = "ESTO ELIMINARÁ LOS CARGOS\r\n ASOCIADOS A ESTA PERSONA\r\nY PASARÁ A MODO INACTIVO \r\n ¿DESEA CONTINUAR?";
                messageYesNo.lblError.Font = new System.Drawing.Font("Balsamiq Sans", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                messageYesNo.lblError.Location = new Point(94, 40);
                messageYesNo.lblError.TextAlign = ContentAlignment.MiddleCenter;
                messageYesNo.ShowDialog();
                if (IMessageBoxYesCancel.isCodigoForm)
                {
                    if(dbConn.ejecutarComandoSQL("DELETE FROM detalleCargos WHERE identidadEmpleado = '" + identidad + "' ") && dbConn.ejecutarComandoSQL("UPDATE datosEmpleados SET estadoEmpleado = 2 WHERE identidadPersona = '"+identidad+"' "))
                    {
                        messageOk.lblCheck.Text = "ELIMINADO CORRECTAMENTE";
                        messageOk.lblCheck.Location = new Point(120, 83);
                        messageOk.ShowDialog();
                        grpActualizar.Hide();
                        pnldgv.Show();
                        txtLikeIdentidad.Clear();
                        actReset();
                    }
                }
            }
            dgvEmpleados.DataSource = null;
        }

        string identidadAdmin = "0000000000000";

        private void btnEditarSuperUser_Click(object sender, EventArgs e)
        {
            pnldgv.Hide();
            grpActualizar.Show();
            btnEliminarCargo.Visible = false;
            btnBorrar.Visible = false;
            btnAgregarCargo.Visible = false;
            btnActualizar.Visible = false;
            btnSiguiente.Visible = true;
            btnActLimpiar.Visible = true;
            isSuper = true;

            

            txtActIdent.Text = identidadAdmin;
            dbConn.llenarTextBox(txtActNombre1, "SELECT primerNombre FROM datosEmpleados WHERE identidadPersona = '" + identidadAdmin + "' ");
            dbConn.llenarTextBox(txtActNombre2, "SELECT segundoNombre FROM datosEmpleados WHERE identidadPersona = '" + identidadAdmin + "' ");
            dbConn.llenarTextBox(txtActApellido1, "SELECT primerApellido FROM datosEmpleados WHERE identidadPersona = '" + identidadAdmin + "' ");
            dbConn.llenarTextBox(txtActApellido2, "SELECT segundoApellido FROM datosEmpleados WHERE identidadPersona = '" + identidadAdmin + "' ");
            dbConn.llenarTextBox(txtActMail, "SELECT correoElectronico FROM datosEmpleados WHERE identidadPersona = '" + identidadAdmin + "' ");

            txtActTelef.Text = dbConn.obtenerVariableString("SELECT numeroTelefono FROM datosEmpleados WHERE identidadPersona = '" + identidadAdmin + "' ");
            txtActFechaNac.Text = dbConn.obtenerVariableString("SELECT correoElectronico FROM datosEmpleados WHERE identidadPersona = '" + identidadAdmin + "' ");
            string contra = utilidades.DesEncriptar(dbConn.obtenerVariableString("SELECT contraseniaEmpleado FROM datosEmpleados WHERE identidadPersona = '" + identidadAdmin + "' "));
            txtActContra.Text = contra;
            txtActConfContra.Text = contra;
            txtActFechaNac.Text = dbConn.obtenerVariableDate("SELECT fechaNacimiento FROM datosEmpleados WHERE identidadPersona = '" + identidadAdmin + "' ").ToString("dd/MM/yyyy");
            lblActEstado.Text = "Activo";
            cmbActCargo.DropDownStyle = ComboBoxStyle.DropDown;
            cmbActCargo.Text = "NO APLICA";
            cmbActCargo.Enabled = false;
            lblActCargoActual.Text = "Super Usuario";

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (comprobaciones())
            {
                btnRecuAtras.Visible = true;
                btnSiguiente.Visible = false;
                pnlRecuperacion.Visible = true;
                btnRecuActualizar.Visible = true;
                btnActLimpiar.Visible = false;
                btnLimpiarRecu.Visible = true;
                string contra = utilidades.DesEncriptar(dbConn.obtenerVariableString("SELECT TOP 1 contra FROM informacionCorreoRecuperacion"));
                dbConn.llenarTextBox(txtCorreoRecuperacion, "SELECT TOP 1 correo FROM informacionCorreoRecuperacion");
                txtContraseRecuperacion.Text = contra;
                dbConn.llenarTextBox(txtHost, "SELECT TOP 1 host FROM informacionCorreoRecuperacion");
                txtPuerto.Text = dbConn.obtenerVariableEntera("SELECT TOP 1 puerto FROM informacionCorreoRecuperacion").ToString();
            }
        }

        private void btnRecuActualizar_Click(object sender, EventArgs e)
        {
            if (txtCorreoRecuperacion.Text != string.Empty && txtContraseRecuperacion.Text != string.Empty & txtHost.Text != string.Empty && txtPuerto.Text != string.Empty && utilidades.isNumeric(txtPuerto.Text))
            {
                if (utilidades.verificarCorreo(txtCorreoRecuperacion.Text))
                {
                    messageYesNo.lblError.Text = "¿HA REVISADO SUS DATOS \r\nY DESEA CONTINUAR?";
                    messageYesNo.lblError.TextAlign = ContentAlignment.MiddleCenter;
                    messageYesNo.ShowDialog();

                    //DialogResult result =  MessageBox.Show("¿Ha revisado sus datos y desea continuar?", "Continuar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (IMessageBoxYesCancel.isCodigoForm == true)
                    {
                        if (utilidades.enviarCorreo("<h1>VERIFICACI&Oacute;N DE CORREO ELECTR&Oacute;NICO</h1>", txtCorreoRecuperacion.Text, txtCorreoRecuperacion.Text, txtContraseRecuperacion.Text, txtHost.Text, Convert.ToInt32(txtPuerto.Text)) == true)
                        {
                            if (dbConn.PAOperacionEmpleado(identidadAdmin, txtActNombre1.Text, txtActNombre2.Text, txtActApellido1.Text, txtActApellido2.Text, Convert.ToInt32(txtActTelef.Text), txtActFechaNac.Text,
                            txtActMail.Text, 1, utilidades.EncriptarTexto(txtActConfContra.Text), 1, -1, 2))
                            {
                                dbConn.ejecutarComandoSQL("UPDATE informacionCorreoRecuperacion SET correo = '" + txtCorreoRecuperacion.Text + "', contra = '" + utilidades.EncriptarTexto(txtContraseRecuperacion.Text) + "' " +
                                    ", host = '"+txtHost.Text+"', puerto = '"+Convert.ToInt32(txtPuerto.Text)+"' ");
                                messageOk.lblCheck.Text = "ACTUALIZADO CORRECTAMENTE";
                                messageOk.ShowDialog();
                                pnlRecuperacion.Visible = false;
                                utilidades.limpiarTextBox(pnlRecuperacion);
                                grpActualizar.Hide();
                                pnldgv.Show();
                                txtLikeIdentidad.Clear();
                                actReset();
                            }
                        }
                        else
                        {
                            boxError.lblError.Text = "CREDENCIALES DE CORREO \r\nELECTRONICO INCORRECTAS";
                            boxError.lblError.Location = new Point(105, 75);
                            boxError.lblError.TextAlign = ContentAlignment.MiddleCenter;
                            boxError.ShowDialog();
                        }

                    }
                }
                else
                {
                    boxError.lblError.Text = "VERIFIQUE\n\r CORREO ELECTRÓNICO";
                    boxError.lblError.TextAlign = ContentAlignment.MiddleCenter;
                    boxError.lblError.Location = new Point(130, 75);
                    boxError.ShowDialog();
                }

            }
            else
            {
                boxError.lblError.Text = "VERIFIQUE LOS VALORES";
                boxError.lblError.Location = new Point(130, 82);
                boxError.ShowDialog();
            }
        }

        private void btnLimpiarRecu_Click(object sender, EventArgs e)
        {
            txtContraseRecuperacion.Clear();
            txtCorreoRecuperacion.Clear();
            txtHost.Clear();
            txtPuerto.Clear();
            chkVerContraRecuperacion.Checked = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            chkActVerContra.Checked = false;
            string txtIdentid = "0";
            txtIdentid = txtIdentidad.Text;
            string txtNum = txtTel.Text;
            if (txtIdentid.Trim() != string.Empty && txtNombre1.Text != string.Empty && txtApellido1.Text != string.Empty && txtNum != string.Empty &&
                txtCorreo.Text != string.Empty && txtContra.Text != string.Empty && txtConfirmContra.Text != string.Empty && txtFechaNa.Text != string.Empty &&
                txtIdentid.Trim().Length == 13 && txtNum.Trim().Length == 8 && cmbCargosSec.Text != string.Empty && cmbCargosSec.Text != "<SELECCIONE>")
            {
                if (utilidades.verificarCorreo(txtCorreo.Text))
                {
                    if (txtContra.TextLength >= 6)
                    {
                        if (txtContra.Text == txtConfirmContra.Text)
                        {
                            if (utilidades.isDate(txtFechaNa.Text))
                            {
                                messageYesNo.lblError.Text = "¿HA REVISADO SUS DATOS \r\nY DESEA CONTINUAR?";
                                messageYesNo.lblError.Location = new Point(96, 67);
                                messageYesNo.lblError.TextAlign = ContentAlignment.MiddleCenter;
                                messageYesNo.ShowDialog();
                                if (IMessageBoxYesCancel.isCodigoForm)
                                {
                                    int codigoCargoI = dbConn.obtenerVariableEntera("SELECT id_Cargo FROM cargos WHERE descripcionCargo = '" + cmbCargosSec.Text + "' ");
                                    if(dbConn.PAOperacionEmpleado(txtIdentid, txtNombre1.Text, txtNombre2.Text, txtApellido1.Text, txtApellido2.Text, Convert.ToInt32(txtTel.Text), txtFechaNa.Text,
                                        txtCorreo.Text, 1, utilidades.EncriptarTexto(txtConfirmContra.Text), codigoCargoI, -1, 1))
                                    {
                                        messageOk.lblCheck.Text = "REGISTRADO CORRECTAMENTE";
                                        messageOk.lblCheck.Location = new Point(114, 82);
                                        messageOk.ShowDialog();
                                        dgvEmpleados.DataSource = null;
                                        grpRegistroEmpleado.Hide();
                                        pnlSelector.Show();
                                    }
                                    else
                                    {
                                        boxError.lblError.Text = "YA EXISTE UN REGISTRO\n CON ESTA IDENTIDAD";
                                        boxError.lblError.Location = new Point(120, 70);
                                        boxError.ShowDialog();
                                    }
                                }
                            }
                            else
                            {
                                boxError.lblError.Text = "INGRESE UNA FECHA VALIDA";
                                boxError.lblError.Location = new Point(120, 82);
                                boxError.ShowDialog();
                            }

                        }
                        else
                        {
                            boxError.lblError.Text = "CONTRASEÑAS NO COINCIDEN";
                            boxError.lblError.Location = new Point(120, 82);
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
                    boxError.lblError.Text = "VERIFIQUE CORREO \n\rELECTRÓNICO";
                    boxError.lblError.TextAlign = ContentAlignment.MiddleCenter;
                    boxError.lblError.Location = new Point(130, 75);
                    boxError.ShowDialog();
                }

            }
            else
            {
                boxError.lblError.Text = "VERIFIQUE LOS VALORES";
                boxError.lblError.Location = new Point(130, 82);
                boxError.ShowDialog();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            utilidades.limpiarTextBox(grpRegistroEmpleado);
            cmbCargosSec.SelectedItem = "<SELECCIONE>";
        }

        private void chkVerContras_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVerContras.Checked)
            {
                txtContra.PasswordChar = '\0';
                txtConfirmContra.PasswordChar = '\0';

            }
            else
            {
                txtContra.PasswordChar = '●';
                txtConfirmContra.PasswordChar = '●';
            }
        }

        private void chkVerContraRecuperacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVerContraRecuperacion.Checked)
            {
                txtContraseRecuperacion.PasswordChar = '\0';

            }
            else
            {
                txtContraseRecuperacion.PasswordChar = '●';
            }
        }

        private void btnRecuAtras_Click(object sender, EventArgs e)
        {
            btnRecuAtras.Visible = false;
            pnlRecuperacion.Visible = false;
            btnSiguiente.Visible = true;
            btnLimpiarRecu.Visible = false;
            btnActLimpiar.Visible = true;
        }
    }
}
