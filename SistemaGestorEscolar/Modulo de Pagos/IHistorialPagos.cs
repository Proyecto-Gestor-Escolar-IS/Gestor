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

namespace SistemaGestorEscolar.Modulo_de_Pagos
{
    public partial class IHistorialPagos : Form
    {
        public IHistorialPagos()
        {
            InitializeComponent();
        }

        databaseConnection dbConn = new databaseConnection();
        clsUtilidades utilidades = new clsUtilidades();
        IMessageBoxError boxError = new IMessageBoxError();

        private void IHistorialPagos_Load(object sender, EventArgs e)
        {
            dbConn.establecerConexion();

            if (Properties.Settings.Default.isModoOscuro == true)
            {
                this.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
            else
            {
                this.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }

            ClsCambioTema.cambiarTemaBoton(this);
            lblFechaActual.Text = "Fecha Actual: " + DateTime.Now.ToShortDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNoIdentidadEstudiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNoIdentidadEstudiante.Clear();
            txtNombreEstudiante.Clear();
            txtNombrePadre.Clear();
            txtNoIdentidadEstudiante.Focus();
            dgvHistorialPagos.DataSource = null;
        }

        private void dgvHistorialPagos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idMensualidad = Convert.ToInt32(dgvHistorialPagos.CurrentRow.Cells[0].Value);
            frmMostrarImagenEvidencia frmImagen = new frmMostrarImagenEvidencia();
            frmImagen.pictureBox1.Image = dbConn.obtenerImagen("SELECT comprobantePago FROM detalleMensualidades WHERE id_Estudiante = '" + txtNoIdentidadEstudiante.Text + "' " +
                "AND id_Mensualidad = '"+ idMensualidad + "' ");

            var fecha = dgvHistorialPagos.CurrentRow.Cells[2].Value.ToString();
            if( fecha != "" )
            {
                DateTime f = dbConn.obtenerVariableDate("SELECT fechaPago FROM detalleMensualidades WHERE" + " id_Estudiante = '" + txtNoIdentidadEstudiante.Text + "' AND id_Mensualidad = '" + idMensualidad + "' ");
                frmImagen.label2.Text = "Fecha de Ingreso: " + f.ToString("dd/MM/yyyy");
            }
            else
            {
                frmImagen.label2.Text = "Fecha de Ingreso: Pendiente de Pago";
            }
            
            
            frmImagen.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            frmImagen.Show();
        }

        private void btnConsultarID_Click_1(object sender, EventArgs e)
        {
            if (txtNoIdentidadEstudiante.Text != string.Empty && txtNoIdentidadEstudiante.TextLength == 13 && utilidades.isNumeric(txtNoIdentidadEstudiante.Text) == true)
            {
                if (dbConn.obtenerVariableString("SELECT id_Estudiante FROM detalleMensualidades WHERE id_Estudiante = '" + txtNoIdentidadEstudiante.Text + "'") != null)
                {
                    dbConn.llenarDGV(dgvHistorialPagos, "Select id_Mensualidad as 'ID', fechaFacturacion as 'FECHA DE FACTURACION', fechaPago as 'FECHA DE PAGO', deudaPendiente as 'DEUDA', " +
                    "saldoDisponible as 'SALDO', descuentoMensualidad as 'DESCUENTO' from detalleMensualidades WHERE id_Estudiante = '" + txtNoIdentidadEstudiante.Text + "'");
                    dbConn.llenarTextBox(txtNombreEstudiante, "SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM datosEstudiante WHERE identidadEstudiante = " + txtNoIdentidadEstudiante.Text);
                    dbConn.llenarTextBox(txtNombrePadre, "SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) " +
                        "FROM datosEncargado de inner join matricula m on de.identidadEncargado = m.id_EncargadoAlumno WHERE m.id_Estudiante = " + txtNoIdentidadEstudiante.Text);
                    lblPendientePago.Text = "Pendiente de Pago: Lps. " + dbConn.obtenerVariableDouble("SELECT TOP 1(deudaPendiente) FROM detalleMensualidades WHERE id_Estudiante = '" + txtNoIdentidadEstudiante.Text + "' ORDER BY id_Mensualidad DESC");
                }
                else
                {
                    boxError.lblError.Text = "NUMERO DE IDENTIDAD \r\n INEXISTENTE";
                    boxError.lblError.Location = new Point(115, 74);
                    boxError.lblError.TextAlign = ContentAlignment.MiddleCenter;
                    boxError.ShowDialog();
                    txtNoIdentidadEstudiante.Focus();
                }

            }
            else
            {
                boxError.lblError.Text = "VERIFIQUE LOS VALORES";
                boxError.lblError.Location = new Point(130, 82);
                boxError.ShowDialog();
                txtNoIdentidadEstudiante.Focus();
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtNoIdentidadEstudiante.Clear();
            txtNombreEstudiante.Clear();
            txtNombrePadre.Clear();
            txtNoIdentidadEstudiante.Focus();
            dgvHistorialPagos.DataSource = null;
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (txtNoIdentidadEstudiante.Text != string.Empty && txtNoIdentidadEstudiante.TextLength == 13 && utilidades.isNumeric(txtNoIdentidadEstudiante.Text) == true)
            {
                if (dbConn.obtenerVariableString("SELECT id_Estudiante FROM detalleMensualidades WHERE id_Estudiante = '" + txtNoIdentidadEstudiante.Text + "'") != null)
                {
                    dbConn.llenarDGV(dgvHistorialPagos, "Select id_Mensualidad as 'ID', fechaFacturacion as 'FECHA DE FACTURACION', fechaPago as 'FECHA DE PAGO', deudaPendiente as 'DEUDA', " +
                    "saldoDisponible as 'SALDO', descuentoMensualidad as 'DESCUENTO' from detalleMensualidades WHERE id_Estudiante = '" + txtNoIdentidadEstudiante.Text + "'");
                    dbConn.llenarTextBox(txtNombreEstudiante, "SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) FROM datosEstudiante WHERE identidadEstudiante = " + txtNoIdentidadEstudiante.Text);
                    dbConn.llenarTextBox(txtNombrePadre, "SELECT concat(primerNombre, ' ', segundoNombre, ' ', primerApellido, ' ', segundoApellido) " +
                        "FROM datosEncargado de inner join matricula m on de.identidadEncargado = m.id_EncargadoAlumno WHERE m.id_Estudiante = " + txtNoIdentidadEstudiante.Text);
                    lblPendientePago.Text = "Pendiente de Pago: Lps. " + dbConn.obtenerVariableDouble("SELECT TOP 1(deudaPendiente) FROM detalleMensualidades WHERE id_Estudiante = '" + txtNoIdentidadEstudiante.Text + "' ORDER BY id_Mensualidad DESC");
                }
                else
                {
                    boxError.lblError.Text = "NUMERO DE IDENTIDAD \r\n INEXISTENTE";
                    boxError.lblError.Location = new Point(115, 74);
                    boxError.lblError.TextAlign = ContentAlignment.MiddleCenter;
                    boxError.ShowDialog();
                    txtNoIdentidadEstudiante.Focus();
                }

            }
            else
            {
                boxError.lblError.Text = "VERIFIQUE LOS VALORES";
                boxError.lblError.Location = new Point(130, 82);
                boxError.ShowDialog();
                txtNoIdentidadEstudiante.Focus();
            }
        }
    }
}
