using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Listados
{
    public partial class IListadoDocentes : Form
    {
        public IListadoDocentes()
        {
            InitializeComponent();
        }

        databaseConnection dbConn = new databaseConnection();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda;
            busqueda = txtBusqueda.Text;

            if (Regex.IsMatch(busqueda, "^[a-zA-Z]"))
            {
                //Busqueda por nombre
                busqueda = busqueda.Substring(0, 1).ToUpper() + busqueda.Substring(1).ToLower();
                dbConn.llenarDGV(dgvListadoDocentes, "select concat(de.[primerNombre],' ', de.[segundoNombre], ' ', de.[primerApellido], ' ', de.[segundoApellido]) as 'Nombre del medico'," +
                    "de.[identidadPersona] as 'Identidad', de.[numeroTelefono] as 'Numero teléfonico', de.[correoElectronico] as 'Correo'," +
                    "de.[fechaNacimiento] as 'Fecha Nacimiento', de.[estadoEmpleado] as 'Estado' from[dbo].[datosEmpleados] de" +
                    " inner join[dbo].[detalleCargos] det on de.[identidadPersona] = det.[identidadEmpleado] and det.[idCargoAsociado] = 3 and [primerNombre] = '" + busqueda + "'");

                txtBusqueda.Clear();
            }

            else if ((Regex.IsMatch(busqueda, @"^\d+$")))
            {
                //Busqueda por identidad
                if (Regex.IsMatch(busqueda, "[0-9]{13,13}"))
                {
                    dbConn.llenarDGV(dgvListadoDocentes, "select concat(de.[primerNombre],' ', de.[segundoNombre], ' ', de.[primerApellido], ' ', de.[segundoApellido]) as 'Nombre del medico'," +
                    "de.[identidadPersona] as 'Identidad', de.[numeroTelefono] as 'Numero teléfonico', de.[correoElectronico] as 'Correo'," +
                    "de.[fechaNacimiento] as 'Fecha Nacimiento', de.[estadoEmpleado] as 'Estado' from[dbo].[datosEmpleados] de" +
                    " inner join[dbo].[detalleCargos] det on de.[identidadPersona] = det.[identidadEmpleado] and det.[idCargoAsociado] = 3 and [identidadPersona] =" + busqueda);
                    txtBusqueda.Clear();
                }
                else
                {
                    string mensaje = "Ingrese correctamente los datos";
                    string titulo = "Error";
                    MessageBoxButtons botones = MessageBoxButtons.OK;
                    MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Error);
                    txtBusqueda.Clear();
                }
            }

            else
            {
                string mensaje = "Ingrese correctamente los datos";
                string titulo = "Error";
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show(mensaje, titulo, botones, MessageBoxIcon.Error);
                txtBusqueda.Clear();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvListadoDocentes, "select concat(de.[primerNombre],' ', de.[segundoNombre], ' ', de.[primerApellido], ' ', de.[segundoApellido]) as 'Nombre del medico'," +
                "de.[identidadPersona] as 'Identidad', de.[numeroTelefono] as 'Numero teléfonico', de.[correoElectronico] as 'Correo'," +
                    "de.[fechaNacimiento] as 'Fecha Nacimiento', de.[estadoEmpleado] as 'Estado' from[dbo].[datosEmpleados] de" +
                    " inner join[dbo].[detalleCargos] det on de.[identidadPersona] = det.[identidadEmpleado] and det.[idCargoAsociado] = 3");
        }

        private void IListadoDocentes_Load(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvListadoDocentes, "select concat(de.[primerNombre],' ', de.[segundoNombre], ' ', de.[primerApellido], ' ', de.[segundoApellido]) as 'Nombre del medico'," +
                "de.[identidadPersona] as 'Identidad', de.[numeroTelefono] as 'Numero teléfonico', de.[correoElectronico] as 'Correo'," +
                    "de.[fechaNacimiento] as 'Fecha Nacimiento', de.[estadoEmpleado] as 'Estado' from[dbo].[datosEmpleados] de" +
                    " inner join[dbo].[detalleCargos] det on de.[identidadPersona] = det.[identidadEmpleado] and det.[idCargoAsociado] = 3");
        }
    }
}
