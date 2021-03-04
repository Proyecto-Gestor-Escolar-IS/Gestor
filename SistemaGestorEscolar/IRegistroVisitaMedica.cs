﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar
{
    public partial class IRegistroVisitaMedica : Form
    {
        public IRegistroVisitaMedica()
        {
            InitializeComponent();
        }

        IMessageBoxCheck messageOk = new IMessageBoxCheck();
        IMessageBoxError message = new IMessageBoxError();
        databaseConnection dbConn = new databaseConnection();
        private string identidadMedico;


        private void limpiarPantalla()
        {
            txtNombreEstudiante.Clear();
            txtSintomas.Clear();
            txtMedicamentos.Clear();
            txtPosibleEnfermedad.Clear();
            txtNoExpediente.Clear();
            dgvHistorialMedico.DataSource = null;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
            txtFechaRegistro.Text = DateTime.Now.ToString();
            cmbMedicos.Items.Clear();
            txtNumeroIdentidad.Clear();
           
        }

        private void IRegistroVisitaMedica_Load(object sender, EventArgs e)
        {
            txtFechaRegistro.Text = DateTime.Now.ToString();
            dbConn.llenarComboBoxValorInicial(cmbMedicos, "SELECT CONCAT(primerNombre,' ', segundoNombre,' ', primerApellido, ' ', segundoApellido) FROM datosEmpleados INNER JOIN detalleCargos ON datosEmpleados.identidadPersona = detalleCargos.identidadEmpleado INNER JOIN cargos ON cargos.id_Cargo = detalleCargos.idCargoAsociado WHERE id_Cargo = 4");
            cmbMedicos.SelectedIndex = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panPosibleEnfermedad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSintomas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoExpediente_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtNombreEstudiantetxtNombreEstudiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroIdentidad_TextChanged_1(object sender, EventArgs e)
        {
            String idEstudiante;
            

            long number = 0;
            try
            {
                if (txtNumeroIdentidad.Text != String.Empty)
                {
                    txtNumeroIdentidad.ForeColor = Color.Black;
                    errorIdentidad.Clear();


                    if (long.TryParse(txtNumeroIdentidad.Text, out number))
                    {
                        txtNumeroIdentidad.ForeColor = Color.Black;
                        errorIdentidad.Clear();


                        if (txtNumeroIdentidad.TextLength == 13)
                        {
                            txtNumeroIdentidad.ForeColor = Color.Green;
                            errorIdentidad.Clear();

                            idEstudiante = dbConn.obtenerVariableString("SELECT id_Registro FROM datosEstudiante WHERE identidadEstudiante = " + txtNumeroIdentidad.Text);
                           

                            if (!string.IsNullOrEmpty(idEstudiante))
                            {
                                dbConn.llenarTextBox(txtNombreEstudiante, "SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM datosEstudiante WHERE identidadEstudiante = " + txtNumeroIdentidad.Text);
                                dbConn.llenarTextBox(txtNoExpediente, "SELECT id_expediente FROM expedienteMedico WHERE id_Estudiante = " + txtNumeroIdentidad.Text);
                                dbConn.llenarDGV(dgvHistorialMedico, "SELECT id_detalleExpediente AS 'No.DetalleExpediente', id_expediente AS 'No.Expediente', CONCAT(primerNombre,' ', segundoNombre,' ', primerApellido, ' ', segundoApellido) AS  'Nombre Médico', fecha AS 'Fecha', sintomas AS 'Síntomas', posibleEnfermadad as 'Posible Enfermedad', medicamentos AS 'Medicamentos' FROM detalleExpedienteMedico INNER JOIN datosEmpleados ON detalleExpedienteMedico.id_DoctorEncargado = datosEmpleados.identidadPersona WHERE id_expediente = " + txtNoExpediente.Text);
                            }
                            else
                            {
                                txtNumeroIdentidad.ForeColor = Color.Red;
                                errorIdentidad.SetError(this.txtNumeroIdentidad, "Este estudiante No está Registrado!");
                            }
                        }
                        else if (txtNumeroIdentidad.TextLength > 13 || txtNumeroIdentidad.TextLength < 13)
                        {
                            txtNumeroIdentidad.ForeColor = Color.Red;
                            errorIdentidad.SetError(this.txtNumeroIdentidad, "El Número de Identidad es Incorrecto!");
                            limpiarPantalla();
                        }
                    }
                    else
                    {
                        txtNumeroIdentidad.ForeColor = Color.Red;
                        errorIdentidad.SetError(this.txtNumeroIdentidad, "Solo se Permiten Numeros!");
                        limpiarPantalla();

                    }
                }
                else
                {
                    errorIdentidad.Clear();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnRegistrarVisitaMedica_Click(object sender, EventArgs e)
        {
            try
            {   
                if(txtNombreEstudiante.Text != string.Empty && cmbMedicos.SelectedIndex != 0 && txtSintomas.Text != string.Empty && txtPosibleEnfermedad.Text != string.Empty && txtMedicamentos.Text != string.Empty)
                {
                    if (dbConn.registroVisitaMedica(int.Parse(txtNoExpediente.Text), identidadMedico, txtSintomas.Text, txtPosibleEnfermedad.Text, txtMedicamentos.Text))

                    {
                        messageOk.lblCheck.Text = "REGISTRADO CORRECTAMENTE";
                        messageOk.ShowDialog();
                        dbConn.llenarDGV(dgvHistorialMedico, "SELECT id_detalleExpediente AS 'No.DetalleExpediente', id_expediente AS 'No.Expediente', CONCAT(primerNombre,' ', segundoNombre,' ', primerApellido, ' ', segundoApellido) AS  'Nombre Médico', fecha AS 'Fecha', sintomas AS 'Síntomas', posibleEnfermadad as 'Posible Enfermedad', medicamentos AS 'Medicamentos' FROM detalleExpedienteMedico INNER JOIN datosEmpleados ON detalleExpedienteMedico.id_DoctorEncargado = datosEmpleados.identidadPersona WHERE id_expediente = " + txtNoExpediente.Text);

                    }
                    else
                    {
                        message.lblError.Text = "VERIFIQUE LOS DATOS";
                        message.ShowDialog();
                    }
                }
                else
                {
                    message.lblError.Text = "OH NO ";
                    message.ShowDialog();

                }
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cmbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            identidadMedico = dbConn.obtenerVariableString("SELECT identidadPersona FROM datosEmpleados WHERE concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) = '" + cmbMedicos.SelectedItem.ToString() + "'");
         
        }

        private void txtNumeroIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                message.lblError.Text = "VALOR INCORRECTO!  \r\nSOLO SE PERMITEN NÚMEROS";
                message.lblError.Location = new Point(105, 75);
                message.lblError.TextAlign = ContentAlignment.MiddleCenter;
                message.ShowDialog();
                e.Handled = true;
                return;
            }
        }

        private void txtMedicamentos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
