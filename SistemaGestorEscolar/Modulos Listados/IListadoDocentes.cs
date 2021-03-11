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

            dbConn.llenarDGV(dgvListadoDocentes, "select concat(de.[primerNombre],' ', de.[segundoNombre], ' ', de.[primerApellido], ' ', de.[segundoApellido]) as 'Nombre del docente', de.[identidadPersona] as 'Identidad', de.[numeroTelefono] as 'Numero teléfonico', de.[correoElectronico] as 'Correo', de.[fechaNacimiento] as 'Fecha Nacimiento', de.[estadoEmpleado] as 'Estado' from[dbo].[datosEmpleados]de inner join[dbo].[detalleCargos] det on de.[identidadPersona] = det.[identidadEmpleado] where det.[idCargoAsociado] = 1 and (de.[identidadPersona] like '" + busqueda + "%' or de.[primerNombre] like '" + busqueda + "%')");
            
            txtBusqueda.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvListadoDocentes, "select concat(de.[primerNombre],' ', de.[segundoNombre], ' ', de.[primerApellido], ' ', de.[segundoApellido]) as 'Nombre del docente'," +
                "de.[identidadPersona] as 'Identidad', de.[numeroTelefono] as 'Numero teléfonico', de.[correoElectronico] as 'Correo'," +
                    "de.[fechaNacimiento] as 'Fecha Nacimiento', de.[estadoEmpleado] as 'Estado' from [dbo].[datosEmpleados]de" +
                    " inner join[dbo].[detalleCargos] det on de.[identidadPersona] = det.[identidadEmpleado] where det.[idCargoAsociado] = 1");
        }

        private void IListadoDocentes_Load(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvListadoDocentes, "select concat(de.[primerNombre],' ', de.[segundoNombre], ' ', de.[primerApellido], ' ', de.[segundoApellido]) as 'Nombre del docente'," +
                "de.[identidadPersona] as 'Identidad', de.[numeroTelefono] as 'Numero teléfonico', de.[correoElectronico] as 'Correo'," +
                    "de.[fechaNacimiento] as 'Fecha Nacimiento', de.[estadoEmpleado] as 'Estado' from [dbo].[datosEmpleados]de" +
                    " inner join[dbo].[detalleCargos] det on de.[identidadPersona] = det.[identidadEmpleado] where det.[idCargoAsociado] = 1");
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string busqueda;
            busqueda = txtBusqueda.Text;

            dbConn.llenarDGV(dgvListadoDocentes, "select concat(de.[primerNombre],' ', de.[segundoNombre], ' ', de.[primerApellido], ' ', de.[segundoApellido]) as 'Nombre del docente', de.[identidadPersona] as 'Identidad', de.[numeroTelefono] as 'Numero teléfonico', de.[correoElectronico] as 'Correo', de.[fechaNacimiento] as 'Fecha Nacimiento', de.[estadoEmpleado] as 'Estado' from[dbo].[datosEmpleados]de inner join[dbo].[detalleCargos] det on de.[identidadPersona] = det.[identidadEmpleado] where det.[idCargoAsociado] = 1 and (de.[identidadPersona] like '" + busqueda + "%' or de.[primerNombre] like '" + busqueda + "%')");

        }
    }
}
