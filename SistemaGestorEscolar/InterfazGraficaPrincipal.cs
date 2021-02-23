using System;
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
    public partial class InterfazGraficaPrincipal : Form
    {

        public InterfazGraficaPrincipal()
        {
            InitializeComponent();
        }

        bool windowMove = false;
        private void InterfazGraficaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenuAtras_Click(object sender, EventArgs e)
        {
   
        }

        private void panLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmrOcultarMenu_Tick(object sender, EventArgs e)
        {
            try
            {
                if (panLateral.Width <= 160)
                {
                    this.tmrOcultarMenu.Enabled = false;
                    btnMenuAtras.Width = 145;
                    btnMenuMatriculaEstudiante.Width = 145;
                    btnMenuVistaMatricula.Width = 145;
                    btnMenuCursosDisponibles.Width = 145;
                    btnMenuIngresoNotas.Width = 145;
                    btnMenuRegistroPago.Width = 145;
                    btnMenuPersonal.Width = 145;

                    btnMenuAtras.BackgroundImageLayout = ImageLayout.Center;
                    btnMenuAtras.BackgroundImage = Properties.Resources.iconBackResized;

                    btnMenuMatriculaEstudiante.BackgroundImageLayout = ImageLayout.Center;
                    btnMenuMatriculaEstudiante.BackgroundImage = Properties.Resources.iconAddEstudianteRedimensionado;

                    btnMenuVistaMatricula.BackgroundImageLayout = ImageLayout.Center;
                    btnMenuVistaMatricula.BackgroundImage = Properties.Resources.iconMatriculaResized;

                    btnMenuCursosDisponibles.BackgroundImageLayout = ImageLayout.Center;
                    btnMenuCursosDisponibles.BackgroundImage = Properties.Resources.iconCursosResized;

                    btnMenuIngresoNotas.BackgroundImageLayout = ImageLayout.Center;
                    btnMenuIngresoNotas.BackgroundImage = Properties.Resources.iconNotasResized;

                    btnMenuRegistroPago.BackgroundImageLayout = ImageLayout.Center;
                    btnMenuRegistroPago.BackgroundImage = Properties.Resources.iconMoneyResized;

                    btnMenuPersonal.BackgroundImageLayout = ImageLayout.Center;
                    btnMenuPersonal.BackgroundImage = Properties.Resources.iconPersonalResized;
                }
                else
                {
                    this.panLateral.Width = panLateral.Width - 70;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private void tmrMostrarMenu_Tick(object sender, EventArgs e)
        {
            if (panLateral.Width >= 285)
            {
                this.tmrMostrarMenu.Enabled = false;

            }
            else
            {
                this.panLateral.Width = panLateral.Width + 70;
            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (panLateral.Width == 285)
                {
                    tmrOcultarMenu.Enabled = true;
                    btnMenuAtras.Text = "";
                    btnMenuMatriculaEstudiante.Text = "";
                    btnMenuVistaMatricula.Text = "";
                    btnMenuCursosDisponibles.Text = "";
                    btnMenuIngresoNotas.Text = "";
                    btnMenuRegistroPago.Text = "";
                    btnMenuPersonal.Text = "";


                }
                else if (panLateral.Width == 145)
                {
                    tmrMostrarMenu.Enabled = true;

                    btnMenuAtras.Width = 285;
                    btnMenuMatriculaEstudiante.Width = 285;
                    btnMenuVistaMatricula.Width = 285;
                    btnMenuCursosDisponibles.Width = 285;
                    btnMenuIngresoNotas.Width = 285;
                    btnMenuRegistroPago.Width = 285;
                    btnMenuPersonal.Width = 285;


                    btnMenuAtras.Text = "ATRAS";
                    btnMenuMatriculaEstudiante.Text = "MATRICULAR ESTUDIANTE";
                    btnMenuVistaMatricula.Text = "VISTA DE MATRICULAS";
                    btnMenuCursosDisponibles.Text = "CURSOS DISPONIBLES";
                    btnMenuIngresoNotas.Text = "INGRESO DE NOTAS";
                    btnMenuRegistroPago.Text = "REGISTRAR PAGO";
                    btnMenuPersonal.Text = "PERSONAL";

                    btnMenuAtras.BackgroundImage = null;
                    btnMenuMatriculaEstudiante.BackgroundImage = null;
                    btnMenuVistaMatricula.BackgroundImage = null;
                    btnMenuCursosDisponibles.BackgroundImage = null;
                    btnMenuIngresoNotas.BackgroundImage = null;
                    btnMenuRegistroPago.BackgroundImage = null;
                    btnMenuPersonal.BackgroundImage = null;

                }
                //MessageBox.Show("" + panLateral.Width);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            string message = "Esta seguro que desea salir?";
            string caption = "Cerrar Aplicación";
            DialogResult result;

            result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMenuMatriculaEstudiante_Click(object sender, EventArgs e)
        {

        }

        private void panSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            windowMove = true;
        }

        private void panSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if(windowMove == true)
            {
                this.Location = Cursor.Position;

            }
        }

        private void panSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            windowMove = false;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
