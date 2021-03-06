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
                    try
                    {
                        correoRecu = dbConn.obtenerVariableString("SELECT correo FROM informacionCorreoRecuperacion");
                        contraRecu = utilidad.DesEncriptar(dbConn.obtenerVariableString("SELECT contra FROM informacionCorreoRecuperacion"));
                    }
                    catch
                    {
                        MessageBox.Show("ERROR AL OBTENER CREDENCIALES DE RECUPERACION");
                    }
                    if (utilidad.enviarCorreo(mensaje: rtxtHtml.Text, asunto: "Recuperación de Contraseña", destinatario: correo, ruta: "", correoRecu, contraRecu))
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
    }
}
