using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Modulos_Estudiante
{
    public partial class IVistaFichaEstudiante : Form
    {
        public IVistaFichaEstudiante()
        {
            InitializeComponent();
        }


        private databaseConnection dbConn = new databaseConnection();
        IMessageBoxWarning messageWarning = new IMessageBoxWarning();
        string identidadEstudiante = "";
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelVistaEncargardos.Visible = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCurso.SelectedIndex != 0)
            { 
                dbConn.llenarDGV(dgvNotas, "SELECT C.[nombreCurso] as 'Curso', B.[nombreClase] as 'Nombre Clase', A.[nota1erParcial] as 'I Parcial', A.[nota2doParcial] as 'II Parcial', A.[nota3erParcial] as 'III Parcial', A.[nota4toParcial] as 'IV Parcial', A.[notaFinal] AS 'Promedio' FROM[dbo].[detalleNotas] A INNER JOIN[dbo].[clasesCurso] B ON A.id_Clase = B.id_Clase INNER JOIN[dbo].[cursos] C ON B.id_Curso = C.id_Curso INNER JOIN[dbo].[detalleMatricula] D ON A.id_DetalleMatricula = D.id_DetalleMatricula INNER JOIN[dbo].[matricula] E ON D.id_RegistroMatricula = E.id_RegistroMatricula WHERE E.id_Estudiante = '" + identidadEstudiante + "' AND C.nombreCurso = '" + cmbCurso.SelectedItem.ToString() + "'");
            }
            else {
                dgvNotas.DataSource = "";
            }
        }

        private void panelPantallaSeleccion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IVistaFichaEstudiante_Load(object sender, EventArgs e)
        {
            panelNotas.Visible = false;
            panelVistaEncargardos.Visible = false;
            panelHistorialMedico.Visible = false;
            panelDatosGenerales.Visible = false;
            dbConn.llenarDGV(dgvBusquedaEstado, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre' FROM datosEstudiante");
    
        }

        private void btnSiguienteDGV_Click(object sender, EventArgs e)
        {
            
            Char genero;

            if (identidadEstudiante != "")
            {

                panelDatosGenerales.Visible = true;
                txtNoRegistro.Text = dbConn.obtenerVariableString("SELECT id_Registro FROM datosEstudiante WHERE identidadEstudiante = '" + identidadEstudiante + "'");
                txtNombreEstudiante.Text = dbConn.obtenerVariableString("SELECT CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM datosEstudiante WHERE identidadEstudiante = '" + identidadEstudiante + "'");
                txtIdentidadEstudiante.Text = identidadEstudiante;

                genero = Char.Parse(dbConn.obtenerVariableString("SELECT genero FROM datosEstudiante WHERE identidadEstudiante = '" + identidadEstudiante + "'"));

                if (genero == 'M')
                {
                    txtGenero.Text = "Masculino";

                }
                else if (genero == 'F')
                {
                    txtGenero.Text = "Femenino";
                }


                txtFechaNacimiento.Text = dbConn.obtenerVariableString("SELECT FORMAT (fechaNacimiento, 'dd-MM-yyyy')  FROM datosEstudiante WHERE identidadEstudiante = '" + identidadEstudiante + "'");
                dbConn.llenarDGV(dgvEncargados, "SELECT identidadEncargado as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre del Encargado', numeroTelefono as 'Telefono Primario', numeroTelefonoAlt as 'Telefono Secundario', direccionTrabajo as 'Direccion de Trabajo' FROM datosEncargado INNER JOIN detalleEncargado ON datosEncargado.identidadEncargado = detalleEncargado.id_encargadoAlumno WHERE  detalleEncargado.id_Estudiante = '" + identidadEstudiante + "'");
                txtDireccion.Text = dbConn.obtenerVariableString("SELECT direccionTrabajo FROM datosEncargado INNER JOIN detalleEncargado ON datosEncargado.identidadEncargado = detalleEncargado.id_encargadoAlumno WHERE  detalleEncargado.id_Estudiante = '" + identidadEstudiante + "'");
                
                dbConn.llenarDGV(dgvHistorialMedico, "SELECT fecha AS 'Fecha', CONCAT(B.primerNombre,' ', B.segundoNombre,' ', B.primerApellido, ' ', B.segundoApellido) AS  'Nombre Médico', sintomas AS 'Síntomas', posibleEnfermadad as 'Posible Enfermedad', medicamentos AS 'Medicamentos' FROM[dbo].[detalleExpedienteMedico] A INNER JOIN[dbo].[datosEmpleados] B ON A.id_DoctorEncargado = B.identidadPersona INNER JOIN[dbo].[expedienteMedico] C ON A.id_expediente = C.id_expediente WHERE C.id_Estudiante = '" + identidadEstudiante + "'");
                txtAntecedentesMedicos.Text = dbConn.obtenerVariableString("SELECT A.[antecedentesMedicos] FROM [dbo].[expedienteMedico] A WHERE A.[id_Estudiante] = '" + identidadEstudiante +"'");
                lblIdentidadEstudiante.Text = txtIdentidadEstudiante.Text;
                lblNombreEstudiante.Text = txtNombreEstudiante.Text;

                lblIdentidadExpMedico.Text = txtIdentidadEstudiante.Text;
                lblNombreExpMedico.Text = txtNombreEstudiante.Text;

                lblIdentidadNotas.Text = txtIdentidadEstudiante.Text;
                lblNombreNotas.Text = txtNombreEstudiante.Text;

                cmbCurso.Items.Clear();
                dbConn.llenarComboBoxValorInicial(cmbCurso, "SELECT A.[nombreCurso] FROM [dbo].[cursos] A INNER JOIN[dbo].[detalleMatricula] B ON A.id_Curso = B.id_Curso INNER JOIN[dbo].[matricula] C ON B.id_RegistroMatricula = C.id_RegistroMatricula WHERE C.id_Estudiante = '" + identidadEstudiante + "'");
                cmbCurso.SelectedIndex = 0;
            }
            else {
                messageWarning.lblError.Text = "SELECCIONE UN ESTUDIANTE";
                messageWarning.ShowDialog();
            }
  


        }

        private void txtBusquedaIdentidadEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBusquedaNombreEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvBusquedaEstado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnAtrasGenerales_Click(object sender, EventArgs e)
        {
            identidadEstudiante = "";
            txtLikeIdentidad.Clear();
            panelDatosGenerales.Visible = false;
        }

        private void btnAtrasEncargados_Click(object sender, EventArgs e)
        {
            panelVistaEncargardos.Visible = false;
        }

        private void btnSiguienteEncargados_Click(object sender, EventArgs e)
        {
            panelHistorialMedico.Visible = true;
        }

        private void btnAtrasExpMedico_Click(object sender, EventArgs e)
        {
            panelHistorialMedico.Visible = false;
        }

        private void btnSiguienteExpMedico_Click(object sender, EventArgs e)
        {
            panelNotas.Visible = true;
        }

        private void btnAtrasNotas_Click(object sender, EventArgs e)
        {
            panelNotas.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtLikeIdentidad_TextChanged(object sender, EventArgs e)
        {

            long number = 0;

            if (txtLikeIdentidad.Text != string.Empty)
            {

                if ((long.TryParse(txtLikeIdentidad.Text, out number) && Regex.IsMatch(txtLikeIdentidad.Text, @"^[a-z A-Z]+$") == false) || (Regex.IsMatch(txtLikeIdentidad.Text, @"^[a-z A-Z]+$") && long.TryParse(txtLikeIdentidad.Text, out number) == false))
                {
                    txtLikeIdentidad.ForeColor = Color.Green;
                    errorIdentidad.Clear();
                    dbConn.llenarDGV(dgvBusquedaEstado, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre'  FROM datosEstudiante WHERE (identidadEstudiante LIKE '" + txtLikeIdentidad.Text + "%') OR (CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) like '" + txtLikeIdentidad.Text + "%')");
                }
                else
                {
                    txtLikeIdentidad.ForeColor = Color.Red;
                    errorIdentidad.SetError(this.txtLikeIdentidad, "Ingrese valores correctos!");
                    dgvBusquedaEstado.DataSource = null;
                }
            }
            else
            {
                dbConn.llenarDGV(dgvBusquedaEstado, "SELECT id_Registro as 'ID', identidadEstudiante as 'Identidad', CONCAT(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) as 'Nombre'  FROM datosEstudiante");

            }
        }

        private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvBusquedaEstado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1){
                identidadEstudiante = dgvBusquedaEstado.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void panelNotas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
