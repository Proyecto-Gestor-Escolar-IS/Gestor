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

        Modulos_de_Arranque.verficacionArranque actualizarModulos = new Modulos_de_Arranque.verficacionArranque();
        public static Form formulario = new Form();
        int posicionX;
        bool windowMove = false;
        int codigoColor = 1;

        private void InterfazGraficaPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                actualizarModulos.verificarFecha();
                panelMostrador.Visible = false;
                panSubMenuPagos.Visible = false;
                panSubMenuEstudiante.Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void AbrirFormulario<T>() where T : Form, new()
        {
            panelMostrador.Controls.Clear();
            formulario = panelMostrador.Controls.OfType<T>().FirstOrDefault();
            if (formulario != null)
            {
                //Si la instancia esta minimizada la dejamos en su estado normal
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
                //Si la instancia existe la pongo en primer plano
                formulario.BringToFront();
                return;
            }
            //Se abre el form
            formulario = new T();
            formulario.TopLevel = false;
            panelMostrador.Controls.Add(formulario);
            panelMostrador.Tag = formulario;
            formulario.Show();
            
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnMenuAtras_Click(object sender, EventArgs e)
        {
            panelMostrador.Visible = false;
            panSubMenuPagos.Visible = false;
            panelMostrador.Controls.Clear();
            formulario.Close();
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
                    posicionX = 0;
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


                    //formulario.Location = new Point(90, 0);
                }
                else
                {
                    posicionX += posicionX + 27;
                    formulario.Location = new Point(posicionX, 0);
                    this.panLateral.Width = panLateral.Width - 70;

                    btnMatriEstudiante.Location = new Point(205, 209);
                    btnPersonal.Location = new Point(205, 483);

                    btnVistaMatriculas1.Location = new Point(705, 209);
                    btnPagos.Location = new Point(705, 483);

                    btnCursos.Location = new Point(1205, 209);
                    btnIngresarNotas.Location = new Point(1205, 483);

                    btnEstudiante.Location = new Point(705, 751);
                    lblMenuTitle.Location = new Point(730, 98);
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
                posicionX = 0;
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

                    formulario.Location = new Point(0, 0);

                    btnMatriEstudiante.Location = new Point(103, 209);
                    btnPersonal.Location = new Point(103, 483);


                    btnVistaMatriculas1.Location = new Point(649, 209);
                    btnPagos.Location = new Point(649, 483);

                    btnCursos.Location = new Point(1178, 209);
                    btnIngresarNotas.Location = new Point(1178, 483);

                    btnEstudiante.Location = new Point(649, 751);
                    lblMenuTitle.Location = new Point(682, 98);
                }
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

        private void btnMenuPersonal_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuRegistroPago_Click(object sender, EventArgs e)
        {
            panSubMenuPagos.Visible = true;
        }

        private void btnMenuIngresoNotas_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuCursosDisponibles_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuVistaMatricula_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            panSubMenuPagos.Visible = true;
            panSubMenuPagos.Dock = DockStyle.Fill;
    
        }

        private void panelMostrador_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMatricularEstudiante_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            panelMostrador.Visible = true;
            panelMostrador.Dock = DockStyle.Fill;
            panSubMenuPagos.Visible = false;
            panSubMenuPagos.Dock = DockStyle.None;
            AbrirFormulario<IRegistroPago>();

            if (codigoColor == 1)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }
            else if (codigoColor == 2)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }

        }

        private void btnHistorialPagos_Click(object sender, EventArgs e)
        {
            panelMostrador.Visible = true;
            panelMostrador.Dock = DockStyle.Fill;
            panSubMenuPagos.Visible = false;
            panSubMenuPagos.Dock = DockStyle.None;
            AbrirFormulario<Modulo_de_Pagos.IHistorialPagos>();
            if (codigoColor == 1)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }
            else if (codigoColor == 2)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            panSubMenuEstudiante.Visible = true;
            panSubMenuEstudiante.Dock = DockStyle.Fill;
        }

        private void btnCambioTema_Click(object sender, EventArgs e)
        {
            if (codigoColor == 1)
            {
                panLateral.BackColor = System.Drawing.Color.FromArgb(41, 40, 55);
                panSuperior.BackColor = System.Drawing.Color.FromArgb(41, 40, 55);
                panelPrincipal.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                panSubMenuPagos.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);

                btnMenuAtras.BackColor = System.Drawing.Color.FromArgb(9, 158, 181);
                btnMenuAtras.ForeColor = Color.Black;
                
                
                btnMenuMatriculaEstudiante.BackColor = System.Drawing.Color.FromArgb(34, 58, 72);
                btnMenuVistaMatricula.BackColor = System.Drawing.Color.FromArgb(34, 58, 72);
                btnMenuCursosDisponibles.BackColor = System.Drawing.Color.FromArgb(34, 58, 72);
                btnMenuIngresoNotas.BackColor = System.Drawing.Color.FromArgb(34, 58, 72);
                btnMenuRegistroPago.BackColor = System.Drawing.Color.FromArgb(34, 58, 72);
                btnMenuPersonal.BackColor = System.Drawing.Color.FromArgb(34, 58, 72);


                btnMenuMatriculaEstudiante.ForeColor = System.Drawing.Color.FromArgb(130, 204, 221);
                btnMenuVistaMatricula.ForeColor = System.Drawing.Color.FromArgb(130, 204, 221);
                btnMenuCursosDisponibles.ForeColor = System.Drawing.Color.FromArgb(130, 204, 221);
                btnMenuIngresoNotas.ForeColor = System.Drawing.Color.FromArgb(130, 204, 221);
                btnMenuRegistroPago.ForeColor = System.Drawing.Color.FromArgb(130, 204, 221);
                btnMenuPersonal.ForeColor = System.Drawing.Color.FromArgb(130, 204, 221);

                btnMatriEstudiante.BackColor = System.Drawing.Color.FromArgb(34, 58, 72);
                btnVistaMatriculas1.BackColor = System.Drawing.Color.FromArgb(34, 58, 72);
                btnCursos.BackColor = System.Drawing.Color.FromArgb(34, 58, 72);
                btnPersonal.BackColor = System.Drawing.Color.FromArgb(34, 58, 72);
                btnPagos.BackColor = System.Drawing.Color.FromArgb(34, 58, 72);
                btnIngresarNotas.BackColor = System.Drawing.Color.FromArgb(34, 58, 72);
                btnEstudiante.BackColor = System.Drawing.Color.FromArgb(34, 58, 72);

                btnMatriEstudiante.BorderColor = System.Drawing.Color.FromArgb(9, 158, 181);
                btnVistaMatriculas.BorderColor = System.Drawing.Color.FromArgb(9, 158, 181);
                btnCursos.BorderColor = System.Drawing.Color.FromArgb(9, 158, 181);
                btnPersonal.BorderColor = System.Drawing.Color.FromArgb(9, 158, 181);
                btnPagos.BorderColor = System.Drawing.Color.FromArgb(9, 158, 181);
                btnIngresarNotas.BorderColor = System.Drawing.Color.FromArgb(9, 158, 181);
                btnEstudiante.BorderColor = System.Drawing.Color.FromArgb(9, 158, 181);

                btnMatriEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40,69,86);
                btnVistaMatriculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 69, 86);
                btnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 69, 86);
                btnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 69, 86);
                btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 69, 86);
                btnIngresarNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 69, 86);
                btnEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 69, 86);

                btnMatriEstudiante.ForeColor = System.Drawing.Color.FromArgb(130, 204, 221);
                btnVistaMatriculas.ForeColor = System.Drawing.Color.FromArgb(130, 204, 221);
                btnCursos.ForeColor = System.Drawing.Color.FromArgb(130, 204, 221);
                btnPersonal.ForeColor = System.Drawing.Color.FromArgb(130, 204, 221);
                btnPagos.ForeColor = System.Drawing.Color.FromArgb(130, 204, 221);
                btnIngresarNotas.ForeColor = System.Drawing.Color.FromArgb(130, 204, 221);
                btnEstudiante.ForeColor = System.Drawing.Color.FromArgb(130, 204, 221);

                codigoColor = 2;

            }
            else if (codigoColor == 2)
            {
                panLateral.BackColor = System.Drawing.Color.FromArgb(0, 97, 169);
                panSuperior.BackColor = System.Drawing.Color.FromArgb(0, 97, 169);
                panelPrincipal.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                panSubMenuPagos.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);

                btnMenuAtras.BackColor = Color.Red;
                btnMenuAtras.ForeColor = Color.Black;

                btnMenuMatriculaEstudiante.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnMenuVistaMatricula.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnMenuCursosDisponibles.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnMenuIngresoNotas.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnMenuRegistroPago.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnMenuPersonal.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);

                btnMenuMatriculaEstudiante.ForeColor = Color.Black;
                btnMenuVistaMatricula.ForeColor = Color.Black;
                btnMenuCursosDisponibles.ForeColor = Color.Black;
                btnMenuIngresoNotas.ForeColor = Color.Black;
                btnMenuRegistroPago.ForeColor = Color.Black;
                btnMenuPersonal.ForeColor = Color.Black;

                btnMatriEstudiante.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnVistaMatriculas.BackgroundImage = Properties.Resources.button2;
                btnCursos.BackgroundImage = Properties.Resources.button2;
                btnPersonal.BackgroundImage = Properties.Resources.button2;
                btnPagos.BackgroundImage = Properties.Resources.button2;
                btnIngresarNotas.BackgroundImage = Properties.Resources.button2;
                btnEstudiante.BackgroundImage = Properties.Resources.button2;

                btnMatriEstudiante.ForeColor = Color.Black;
                btnVistaMatriculas.ForeColor = Color.Black;
                btnCursos.ForeColor = Color.Black;
                btnPersonal.ForeColor = Color.Black;
                btnPagos.ForeColor = Color.Black;
                btnIngresarNotas.ForeColor = Color.Black;
                btnEstudiante.ForeColor = Color.Black;

                codigoColor = 1;
            }
        }

        private void btnMatriEstudiante_Click(object sender, EventArgs e)
        {
            

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVistaMatriculas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVistaMatriculas_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnVistaMatriculas_MouseLeave(object sender, EventArgs e)
        {
        
            
        }

        private void btnMatriEstudiante_Click_1(object sender, EventArgs e)
        {
           

        }

        private void btnMatriEstudiante_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnMatriEstudiante_MouseLeave(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void roundedButton1_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btnMatriEstudiante_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
