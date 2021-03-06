using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using SistemaGestorEscolar.Utilidades;

namespace SistemaGestorEscolar.Login
{
    public partial class frmRecuperacionContrasenia : Form
    {
        public frmRecuperacionContrasenia()
        {
            InitializeComponent();
        }

        databaseConnection dbConn = new databaseConnection();
        clsUtilidades utilidad = new clsUtilidades();

        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if (mtxtIdentidad.Text != string.Empty)
            {
                if (dbConn.obtenerVariableString("SELECT identidadPersona FROM datosEmpleados WHERE identidadPersona = '" + mtxtIdentidad.Text + "' AND estadoEmpleado <> 2") != null)
                {
                    string correo = dbConn.obtenerVariableString("SELECT correoElectronico FROM datosEmpleados WHERE identidadPersona = '" + mtxtIdentidad.Text + "'");
                    string nombre = dbConn.obtenerVariableString("SELECT CONCAT(primerNombre, ' ', segundoNombre) FROM datosEmpleados WHERE identidadPersona = '" + mtxtIdentidad.Text + "'");
                    string contra = utilidad.DesEncriptar(dbConn.obtenerVariableString("SELECT contraseniaEmpleado FROM datosEmpleados WHERE identidadPersona = '" + mtxtIdentidad.Text + "'"));
                    string corr = correo.Substring(0, 5);
                    rtxtHtml.Text = rtxtHtml.Text.Replace("@contra", " " + contra);
                    rtxtHtml.Text = rtxtHtml.Text.Replace("@nombre", " " + nombre);
                    string correoRecu = "";
                    string contraRecu = "";
                    string host = "";
                    int port = 0;
                    try
                    {
                        correoRecu = dbConn.obtenerVariableString("SELECT TOP 1 correo FROM informacionCorreoRecuperacion");
                        contraRecu = utilidad.DesEncriptar(dbConn.obtenerVariableString("SELECT TOP 1 contra FROM informacionCorreoRecuperacion"));
                        host = dbConn.obtenerVariableString("SELECT TOP 1 host FROM informacionCorreoRecuperacion");
                        port = dbConn.obtenerVariableEntera("SELECT TOP 1 puerto FROM informacionCorreoRecuperacion");
                    }
                    catch
                    {
                        MessageBox.Show("ERROR AL OBTENER CREDENCIALES DE RECUPERACION");
                    }
                    if (utilidad.enviarCorreo(mensaje: rtxtHtml.Text, destinatario: correo, correoRecu, contraRecu, host, port))
                    {
                        MessageBox.Show("Revise la bandeja de entrada, spam de su correo: " + corr + "********", "Recuperacion de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Si la informacion que ingreso es correcta, recibira en su correo electronico la contraseña de su cuenta.", "Recuperacion de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un correo electronico", "Error de recuperacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRecuperacionContrasenia_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isModoOscuro)
            {
                this.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                ClsCambioTema.cambiarTemaBoton(this);
            }
            btnCerrarPrograma.BackColor = Color.Red;
        }
    }
}
