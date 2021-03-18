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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvCursos, "select [id_Curso] as 'Id Curso', [nombreCurso] as 'Nombre Curso', [precioCompleto] as 'Precio', es.[descripcionEstado] as 'Estado' from [dbo].[cursos]c join[dbo].[estados]es on c.[estadoCurso] = es.[id_Estado]");
        }

        private void IGestionCursos_Load(object sender, EventArgs e)
        {
            dbConn.llenarDGV(dgvCursos, "select [id_Curso] as 'Id Curso', [nombreCurso] as 'Nombre Curso', [precioCompleto] as 'Precio', es.[descripcionEstado] as 'Estado' from [dbo].[cursos]c join[dbo].[estados]es on c.[estadoCurso] = es.[id_Estado]");
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            int estadoCurso;
            String nombreCurso;
            double precio;          

            if(dbConn.ComprobarExistencia("select [estadoCurso] from [dbo].[cursos] where [estadoCurso] = 1 and [nombreCurso] = '" + txtNombreCurso.Text + "'"))
            {
                messageError.lblError.Text = "EL CURSO YA EXISTE";
                messageError.ShowDialog();

                txtNombreCurso.Clear();
                txtPrecio.Clear();

            }
            else if (Regex.IsMatch(txtNombreCurso.Text, "^[a-zA-Z]") || Regex.IsMatch(txtPrecio.Text, @"^\d+$"))
            {
                nombreCurso = txtNombreCurso.Text;
                precio = double.Parse(txtPrecio.Text);
                estadoCurso = 1;

                dbConn.PARegistroCursos(nombreCurso, precio, estadoCurso);

                message.lblCheck.Text = "CURSO REGISTRADO";
                message.ShowDialog();

                txtNombreCurso.Clear();
                txtPrecio.Clear();

            }
            else
            {
                messageError.lblError.Text = "INGRESE CORRECTAMENTE LOS DATOS";
                messageError.ShowDialog();

                txtNombreCurso.Clear();
                txtPrecio.Clear();
            }      

        }

        private void btnActualización_Click(object sender, EventArgs e)
        {
            int idCurso;
            String nombreCurso;
            double precio;

            if (Regex.IsMatch(txtNombreCurso.Text, "^[a-zA-Z]") || Regex.IsMatch(txtPrecio.Text, @"^\d+$"))
            {
                
                idCurso = Int32.Parse(dgvCursos.CurrentRow.Cells[0].Value.ToString());
                nombreCurso = txtNombreCurso.Text;
                precio = double.Parse(txtPrecio.Text);

                dbConn.PAActualizarCursos(idCurso, nombreCurso, precio);

                message.lblCheck.Text = "CURSO ACTUALIZADO";
                message.ShowDialog();

                txtNombreCurso.Clear();
                txtPrecio.Clear();
            }
            else
            {
                messageError.lblError.Text = "INGRESE CORRECTAMENTE LOS CAMPOS SOLICITADOS";
                messageError.ShowDialog();
            }
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreCurso.Text = dgvCursos.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dgvCursos.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            int idCurso, Vid;
            idCurso = Int32.Parse(dgvCursos.CurrentRow.Cells[0].Value.ToString());
            Vid = dbConn.obtenerVariableEntera("select [estadoCurso] from [dbo].[cursos] where [id_Curso] = '" + idCurso + "'");
            if (Vid != 2)
            {
                dbConn.ejecutarComandoSQL("update [dbo].[cursos] set [estadoCurso] = 2 where [id_Curso] = '" + idCurso + "'");

                message.lblCheck.Text = "CURSO ELIMINADO";
                message.ShowDialog();

                txtNombreCurso.Clear();
                txtPrecio.Clear();

            }
            else
            {
                messageError.lblError.Text = "EL CURSO YA ESTÁ ELIMINADO";
                messageError.ShowDialog();

                txtNombreCurso.Clear();
                txtPrecio.Clear();

            }
        }
    }
}
