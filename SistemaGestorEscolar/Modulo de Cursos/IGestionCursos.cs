using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using SistemaGestorEscolar.MessageBox_Personalizados;
using SistemaGestorEscolar.Utilidades;

namespace SistemaGestorEscolar.Modulo_de_Cursos
{
    public partial class IGestionCursos : Form
    {
        public IGestionCursos()
        {
            InitializeComponent();
        }

        databaseConnection dbConn = new databaseConnection();
        IMessageBoxCheck message = new IMessageBoxCheck();
        IMessageBoxError messageError = new IMessageBoxError();
        IMessageBoxWarning messageWarning = new IMessageBoxWarning();
        IMessageBoxYesCancel messageQuestion = new IMessageBoxYesCancel();
        clsUtilidades utilidad = new clsUtilidades();

        private void IGestionCursos_Load(object sender, EventArgs e)
        {
            lblCursos.Visible = true;
            actualizarDGV();
            actualizarDGVInac();
            ClsCambioTema.cambiarTemaBoton(grbPrincipal);
            ClsCambioTema.cambiarTemaBoton(grbDgv);
        }

        private void actualizarDGV()
        {
            dbConn.llenarDGV(dgvCursos, "select [nombreCurso] as 'Nombre Curso', [precioCompleto] as 'Precio', es.[descripcionEstado] as 'Estado' from [dbo].[cursos]c join[dbo].[estados]es on c.[estadoCurso] = es.[id_Estado] where es.[descripcionEstado] = 'Activo'");
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreCurso.Text = dgvCursos.CurrentRow.Cells[0].Value.ToString();
            txtPrecio.Text = dgvCursos.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnRegistrarCurso_Click(object sender, EventArgs e)
        {
            int estadoCurso;
            String nombreCurso;
            double precio;

            if (txtNombreCurso.Text == String.Empty)
            {
                messageError.lblError.Text = "INGRESE UN NOMBRE DE CURSO";
                messageError.ShowDialog();
            }
            else if(txtPrecio.Text == String.Empty)
            {
                messageError.lblError.Text = "INGRESE UN PRECIO";
                messageError.ShowDialog();
            }
            else if (utilidad.isNumeric(txtPrecio.Text))
            {
                nombreCurso = txtNombreCurso.Text;
                precio = double.Parse(txtPrecio.Text);
                estadoCurso = 1;

                dbConn.PARegistroCursos(nombreCurso, precio, estadoCurso);

                message.lblCheck.Text = "CURSO REGISTRADO";
                message.ShowDialog();

                txtNombreCurso.Clear();
                txtPrecio.Clear();

                actualizarDGV(); 
             }
            else if (dbConn.obtenerVariableEntera("select [estadoCurso] from [dbo].[cursos]c inner join [dbo].[estados]e on c.estadoCurso = e.id_Estado where [estadoCurso] = 1 and [nombreCurso] = '" + txtNombreCurso.Text + "'") == 1)
                {
                    messageError.lblError.Text = "EL CURSO YA EXISTE";
                    messageError.ShowDialog();

                utilidad.limpiarTextBox(grbPrincipal);

            }
            else if (dbConn.obtenerVariableEntera("select [estadoCurso] from [dbo].[cursos]c inner join [dbo].[estados]e on c.estadoCurso = e.id_Estado where [estadoCurso] = 2 and [nombreCurso] = '" + txtNombreCurso.Text + "'") == 2)
            {
                estadoCurso = 1;

                dbConn.ejecutarComandoSQL("update [dbo].[cursos] set [estadoCurso] = '" + estadoCurso + "' where [nombreCurso] = '" + txtNombreCurso.Text + "'");

                message.lblCheck.Text = "CURSO REGISTRADO";
                message.ShowDialog();

                utilidad.limpiarTextBox(grbPrincipal);

                actualizarDGVInac();

            }
            else 
            {
                messageError.lblError.Text = "INGRESE CORRECTAMENTE LOS DATOS SOLICITADOS";
                messageError.ShowDialog();
            }
        }

        private void btnActualizarCurso_Click(object sender, EventArgs e)
        {
            int idCurso;
            String nombreCurso;
            double precio;

            if (txtNombreCurso.Text == String.Empty)
            {
                messageError.lblError.Text = "INGRESE UN NOMBRE DE CURSO";
                messageError.ShowDialog();
            }
            else if (txtPrecio.Text == String.Empty)
            {
                messageError.lblError.Text = "INGRESE UN PRECIO";
                messageError.ShowDialog();

            }
            else if (dbConn.obtenerVariableEntera("select [estadoCurso] from [dbo].[cursos]c inner join [dbo].[estados]e on c.estadoCurso = e.id_Estado where [estadoCurso] = 2 and [nombreCurso] = '" + txtNombreCurso.Text + "'") == 2)
            {
                messageError.lblError.Text = "SELECCIONE UN CURSO ACTIVO";
                messageError.ShowDialog();

            }
            else if (utilidad.isNumeric(txtPrecio.Text)) { 

                idCurso = Int32.Parse(txtIdCurso.Text);
                nombreCurso = txtNombreCurso.Text;
                precio = double.Parse(txtPrecio.Text);

                dbConn.PAActualizarCursos(idCurso, nombreCurso, precio);

                message.lblCheck.Text = "CURSO ACTUALIZADO";
                message.ShowDialog();

                utilidad.limpiarTextBox(grbPrincipal);

                actualizarDGV();

            }
            else
            {
                messageError.lblError.Text = "INGRESE CORRECTAMENTE LOS DATOS SOLICITADOS";
                messageError.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int Vid;
            Vid = dbConn.obtenerVariableEntera("select [estadoCurso] from [dbo].[cursos] where [id_Curso] = '" + txtIdCurso.Text + "'");
            if (txtNombreCurso.Text == String.Empty)
            {
                messageError.lblError.Text = "INGRESE UN NOMBRE DE CURSO";
                messageError.ShowDialog();
            }
            else if (Vid != 2)
            {
                dbConn.ejecutarComandoSQL("update [dbo].[cursos] set [estadoCurso] = 2 where [id_Curso] = '" + txtIdCurso.Text + "'");

                message.lblCheck.Text = "CURSO ELIMINADO";
                message.ShowDialog();

                utilidad.limpiarTextBox(grbPrincipal);

                actualizarDGV();

            }
            else
            {
                messageError.lblError.Text = "EL CURSO YA ESTÁ ELIMINADO";
                messageError.ShowDialog();

                utilidad.limpiarTextBox(grbPrincipal);

            }
        }

        private void btnActualizarDgv_Click(object sender, EventArgs e)
        {
            actualizarDGV();
        }

        private void actualizarDGVInac()
        {
            dbConn.llenarDGV(dgvCursosInactivos, "select [nombreCurso] as 'Nombre Curso', [precioCompleto] as 'Precio', es.[descripcionEstado] as 'Estado' from [dbo].[cursos]c join[dbo].[estados]es on c.[estadoCurso] = es.[id_Estado] where es.[descripcionEstado] = 'Inactivo'");
        }

        private void dgvCursosInactivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreCurso.Text = dgvCursosInactivos.CurrentRow.Cells[0].Value.ToString();
            txtPrecio.Text = dgvCursosInactivos.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnInactivos_Click(object sender, EventArgs e)
        {
            actualizarDGVInac();
            btnInactivos.Visible = false;
            btnActivos.Visible = true;
            dgvCursos.Visible = false;
            dgvCursosInactivos.Visible = true;

        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            actualizarDGV();
            btnActivos.Visible = false;
            btnInactivos.Visible = true;
            dgvCursos.Visible = true;
            dgvCursosInactivos.Visible = false;
        }

        private void txtNombreCurso_TextChanged(object sender, EventArgs e)
        {
            txtIdCurso.Text = dbConn.obtenerVariableEntera("select [id_Curso] from [dbo].[cursos] where [nombreCurso] = '" + txtNombreCurso.Text + "'").ToString();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAgregarSeccion_Click(object sender, EventArgs e)
        {
            if ((dbConn.obtenerVariableString("select [nombreCurso] from [dbo].[cursos] where [id_Curso] = '" + txtIdCurso.Text + "' and [estadoCurso] = 1") == txtNombreCurso.Text))
            {
                grbSeccionesCont.Visible = true;
                grbPrincipal.Visible = false;
                grbDgv.Visible = false;
                lblSecciones.Visible = true;
                lblCursos.Visible = false;
                grbDgvSecciones.Visible = true;
                lblSecciones.Visible = true;

                actualizarDGVSecciones();

                dbConn.llenarComboBox(cmbCursos, "SELECT nombreCurso FROM dbo.cursos where [estadoCurso] = 1");
                dbConn.llenarComboBox(cmbDocentes, "SELECT concat(de.[primerNombre], ' ', de.[primerApellido]) as 'Docente' from [dbo].[datosEmpleados]de inner join [dbo].[detalleCargos]dc on dc.identidadEmpleado = de.identidadPersona inner join [dbo].[cargos]c on c.id_Cargo = dc.idCargoAsociado where de.[estadoEmpleado] = 1");

            }
            else if (dbConn.obtenerVariableEntera("select [estadoCurso] from [dbo].[cursos]c inner join [dbo].[estados]e on c.estadoCurso = e.id_Estado where [estadoCurso] = 2 and [nombreCurso] = '" + txtNombreCurso.Text + "'") == 2)
            {
                messageError.lblError.Text = "SELECCIONE UN CURSO ACTIVO";
                messageError.ShowDialog();
            }
            else
            {
                messageError.lblError.Text = "SELECCIONE UN CURSO";
                messageError.ShowDialog();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            grbSeccionesCont.Visible = false;
            grbPrincipal.Visible = true;
            grbDgv.Visible = true;
            lblSecciones.Visible = false;
            lblCursos.Visible = true;
            grbDgvSecciones.Visible = true;
            lblCursos.Visible = true;
        }

        private void actualizarDGVSecciones()
        {
            dbConn.llenarDGV(dgvSecciones, "SELECT c.nombreCurso as 'Curso', concat(de.primerNombre,' ', de.primerApellido) as 'Docente', s.nombreSeccion as 'Nombre sección' FROM dbo.cursos c INNER JOIN dbo.seccion s ON c.id_Curso = s.id_Curso INNER JOIN dbo.datosEmpleados de ON s.id_Docente = de.identidadPersona");
        }

        private void dgvSecciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSeccion.Text = dgvSecciones.CurrentRow.Cells[2].Value.ToString();
        }
        private void btnRegistrarSecc_Click(object sender, EventArgs e)
        {
            if(cmbCursos.SelectedIndex == -1)
            {
                messageError.lblError.Text = "SELECCIONE UN CURSO";
                messageError.ShowDialog();

            }else if (cmbDocentes.SelectedIndex == -1)
            {
                messageError.lblError.Text = "SELECCIONE UNA SECCIÓN";
                messageError.ShowDialog();
            }
            else if (dbConn.ComprobarExistencia("SELECT [nombreSeccion] from [dbo].[seccion] WHERE [nombreSeccion] = '" + txtSeccion.Text + "'")){

                String seccion, estado;
                int curso, docente;
                /*
                seccion = txtSeccion.Text
                
                dbConn.PARegistroSeccion(seccion, curso, docente, estado);
                */
            }
            else
            {
                messageError.lblError.Text = "INGRESE CORRECTAMENTE LOS DATOS SOLICITADOS";
                messageError.ShowDialog();
            }
        }
    }
}
