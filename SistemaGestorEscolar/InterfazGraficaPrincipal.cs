using SistemaGestorEscolar.Utilidades;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaGestorEscolar
{
    public partial class InterfazGraficaPrincipal : Form
    {
        public InterfazGraficaPrincipal()
        {
            InitializeComponent();
        }

        private MessageBox_Personalizados.IMessageBoxSiNo siNo = new MessageBox_Personalizados.IMessageBoxSiNo();

        private Modulos_de_Arranque.verficacionArranque actualizarModulos = new Modulos_de_Arranque.verficacionArranque();
        public static Form formulario = new Form();
        private int posicionX;
        private bool windowMove = false;
        private int codigoColor = 1;

        private void InterfazGraficaPrincipal_Load(object sender, EventArgs e)
        {

            clsVariablesGlobales.CodigoAcceso = 2;
            Properties.Settings.Default.Reset();
            try
            {
                actualizarModulos.verificarFecha();
                panelMostrador.Visible = false;
                panSubMenuPersonal.Visible = false;
                panSubMenuPagos.Visible = false;
                panSubMenuEstudiante.Visible = false;

                if (clsVariablesGlobales.CodigoAcceso == 0)
                {
                    btnEstudiante.Enabled = false;
                    btnIngresarNotas.Enabled = false;
                    btnPersonal.Enabled = true;
                    btnVistaMatriculas.Enabled = false;
                    btnCursos.Enabled = false;
                    btnPagos.Enabled = false;
                    btnMatricularEstudiante.Enabled = false;

                    btnMenuIngresoNotas.Enabled = false;
                    btnMenuPersonal.Enabled = true;
                    btnMenuVistaMatricula.Enabled = false;
                    btnMenuCursosDisponibles.Enabled = false;
                    btnMenuRegistroPago.Enabled = false;
                    btnMenuMatriculaEstudiante.Enabled = false;

                    btnMenuIngresoNotas.BackColor = Color.DarkGray;
                    btnMenuVistaMatricula.BackColor = Color.DarkGray;
                    btnMenuCursosDisponibles.BackColor = Color.DarkGray;
                    btnMenuRegistroPago.BackColor = Color.DarkGray;
                    btnMenuMatriculaEstudiante.BackColor = Color.DarkGray;

                    btnEstudiante.BackColor = Color.DarkGray;
                    btnIngresarNotas.BackColor = Color.DarkGray;
                    btnVistaMatriculas.BackColor = Color.DarkGray;
                    btnCursos.BackColor = Color.DarkGray;
                    btnPagos.BackColor = Color.DarkGray;
                    btnMatricularEstudiante.BackColor = Color.DarkGray;

                    btnEstudiante.BorderColor = Color.Silver;
                    btnIngresarNotas.BorderColor = Color.Silver;
                    btnVistaMatriculas.BorderColor = Color.Silver;
                    btnCursos.BorderColor = Color.Silver;
                    btnPagos.BorderColor = Color.Silver;
                    btnMatricularEstudiante.BorderColor = Color.Silver;
                }
                else if (clsVariablesGlobales.CodigoAcceso == 1)
                {
                    btnEstudiante.Enabled = true;
                    btnIngresarNotas.Enabled = false;
                    btnPersonal.Enabled = false;
                    btnVistaMatriculas.Enabled = true;
                    btnCursos.Enabled = true;
                    btnPagos.Enabled = true;
                    btnMatricularEstudiante.Enabled = true;

                    btnMenuIngresoNotas.Enabled = false;
                    btnMenuPersonal.Enabled = false;
                    btnMenuVistaMatricula.Enabled = true;
                    btnMenuCursosDisponibles.Enabled = true;
                    btnMenuRegistroPago.Enabled = true;
                    btnMenuMatriculaEstudiante.Enabled = true;

                    btnMenuPersonal.BackColor = Color.DarkGray;
                    btnMenuIngresoNotas.BackColor = Color.DarkGray;

                    btnPersonal.BackColor = Color.DarkGray;
                    btnIngresarNotas.BackColor = Color.DarkGray;

                    btnPersonal.BorderColor = Color.Silver;
                    btnIngresarNotas.BorderColor = Color.Silver;
                }
                else if (clsVariablesGlobales.CodigoAcceso == 2)
                {
                    btnEstudiante.Enabled = true;
                    btnIngresarNotas.Enabled = true;
                    btnPersonal.Enabled = false;
                    btnVistaMatriculas.Enabled = true;
                    btnCursos.Enabled = false;
                    btnPagos.Enabled = false;
                    btnMatricularEstudiante.Enabled = false;

                    btnMenuIngresoNotas.Enabled = true;
                    btnMenuPersonal.Enabled = false;
                    btnMenuVistaMatricula.Enabled = true;
                    btnMenuCursosDisponibles.Enabled = false;
                    btnMenuRegistroPago.Enabled = false;
                    btnMenuMatriculaEstudiante.Enabled = false;

                    btnMenuPersonal.BackColor = Color.DarkGray;
                    btnMenuRegistroPago.BackColor = Color.DarkGray;
                    btnMenuCursosDisponibles.BackColor = Color.DarkGray;
                    btnMenuMatriculaEstudiante.BackColor = Color.DarkGray;

                    btnPersonal.BackColor = Color.DarkGray;
                    btnPagos.BackColor = Color.DarkGray;
                    btnCursos.BackColor = Color.DarkGray;
                    btnMatricularEstudiante.BackColor = Color.DarkGray;

                    btnPersonal.BorderColor = Color.Silver;
                    btnPagos.BorderColor = Color.Silver;
                    btnCursos.BorderColor = Color.Silver;
                    btnMatricularEstudiante.BorderColor = Color.Silver;
                }
                else if (clsVariablesGlobales.CodigoAcceso == 3)
                {
                    btnEstudiante.Enabled = true;
                    btnIngresarNotas.Enabled = false;
                    btnPersonal.Enabled = false;
                    btnVistaMatriculas.Enabled = true;
                    btnCursos.Enabled = false;
                    btnPagos.Enabled = false;
                    btnMatricularEstudiante.Enabled = false;

                    btnMenuIngresoNotas.Enabled = false;
                    btnMenuPersonal.Enabled = false;
                    btnMenuVistaMatricula.Enabled = true;
                    btnMenuCursosDisponibles.Enabled = false;
                    btnMenuRegistroPago.Enabled = false;
                    btnMenuMatriculaEstudiante.Enabled = false;

                    btnMenuPersonal.BackColor = Color.DarkGray;
                    btnMenuIngresoNotas.BackColor = Color.DarkGray;
                    btnMenuRegistroPago.BackColor = Color.DarkGray;
                    btnMenuCursosDisponibles.BackColor = Color.DarkGray;
                    btnMenuMatriculaEstudiante.BackColor = Color.DarkGray;

                    btnPersonal.BackColor = Color.DarkGray;
                    btnIngresarNotas.BackColor = Color.DarkGray;
                    btnPagos.BackColor = Color.DarkGray;
                    btnCursos.BackColor = Color.DarkGray;
                    btnMatricularEstudiante.BackColor = Color.DarkGray;

                    btnPersonal.BorderColor = Color.Silver;
                    btnIngresarNotas.BorderColor = Color.Silver;
                    btnPagos.BorderColor = Color.Silver;
                    btnCursos.BorderColor = Color.Silver;
                    btnMatricularEstudiante.BorderColor = Color.Silver;
                }
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
            panSubMenuEstudiante.Visible = false;
            panSubMenuPersonal.Visible = false;
            panelMostrador.Controls.Clear();
            formulario.Close();
            mostrarBotones();

            if (clsVariablesGlobales.CodigoAcceso == 0)
            {
                btnEstudiante.Enabled = false;
                btnIngresarNotas.Enabled = false;
                btnPersonal.Enabled = true;
                btnVistaMatriculas.Enabled = false;
                btnCursos.Enabled = false;
                btnPagos.Enabled = false;
                btnMatricularEstudiante.Enabled = false;

                btnMenuIngresoNotas.Enabled = false;
                btnMenuPersonal.Enabled = true;
                btnMenuVistaMatricula.Enabled = false;
                btnMenuCursosDisponibles.Enabled = false;
                btnMenuRegistroPago.Enabled = false;
                btnMenuMatriculaEstudiante.Enabled = false;

                btnMenuIngresoNotas.BackColor = Color.DarkGray;
                btnMenuVistaMatricula.BackColor = Color.DarkGray;
                btnMenuCursosDisponibles.BackColor = Color.DarkGray;
                btnMenuRegistroPago.BackColor = Color.DarkGray;
                btnMenuMatriculaEstudiante.BackColor = Color.DarkGray;

                btnEstudiante.BackColor = Color.DarkGray;
                btnIngresarNotas.BackColor = Color.DarkGray;
                btnVistaMatriculas.BackColor = Color.DarkGray;
                btnCursos.BackColor = Color.DarkGray;
                btnPagos.BackColor = Color.DarkGray;
                btnMatricularEstudiante.BackColor = Color.DarkGray;

                btnEstudiante.BorderColor = Color.Silver;
                btnIngresarNotas.BorderColor = Color.Silver;
                btnVistaMatriculas.BorderColor = Color.Silver;
                btnCursos.BorderColor = Color.Silver;
                btnPagos.BorderColor = Color.Silver;
                btnMatricularEstudiante.BorderColor = Color.Silver;
            }
            else if (clsVariablesGlobales.CodigoAcceso == 1)
            {
                btnEstudiante.Enabled = true;
                btnIngresarNotas.Enabled = false;
                btnPersonal.Enabled = false;
                btnVistaMatriculas.Enabled = true;
                btnCursos.Enabled = true;
                btnPagos.Enabled = true;
                btnMatricularEstudiante.Enabled = true;

                btnMenuIngresoNotas.Enabled = false;
                btnMenuPersonal.Enabled = false;
                btnMenuVistaMatricula.Enabled = true;
                btnMenuCursosDisponibles.Enabled = true;
                btnMenuRegistroPago.Enabled = true;
                btnMenuMatriculaEstudiante.Enabled = true;

                btnMenuPersonal.BackColor = Color.DarkGray;
                btnMenuIngresoNotas.BackColor = Color.DarkGray;

                btnPersonal.BackColor = Color.DarkGray;
                btnIngresarNotas.BackColor = Color.DarkGray;

                btnPersonal.BorderColor = Color.Silver;
                btnIngresarNotas.BorderColor = Color.Silver;
            }
            else if (clsVariablesGlobales.CodigoAcceso == 2)
            {
                btnEstudiante.Enabled = true;
                btnIngresarNotas.Enabled = true;
                btnPersonal.Enabled = false;
                btnVistaMatriculas.Enabled = true;
                btnCursos.Enabled = false;
                btnPagos.Enabled = false;
                btnMatricularEstudiante.Enabled = false;

                btnMenuIngresoNotas.Enabled = true;
                btnMenuPersonal.Enabled = false;
                btnMenuVistaMatricula.Enabled = true;
                btnMenuCursosDisponibles.Enabled = false;
                btnMenuRegistroPago.Enabled = false;
                btnMenuMatriculaEstudiante.Enabled = false;

                btnMenuPersonal.BackColor = Color.DarkGray;
                btnMenuRegistroPago.BackColor = Color.DarkGray;
                btnMenuCursosDisponibles.BackColor = Color.DarkGray;
                btnMenuMatriculaEstudiante.BackColor = Color.DarkGray;

                btnPersonal.BackColor = Color.DarkGray;
                btnPagos.BackColor = Color.DarkGray;
                btnCursos.BackColor = Color.DarkGray;
                btnMatricularEstudiante.BackColor = Color.DarkGray;

                btnPersonal.BorderColor = Color.Silver;
                btnPagos.BorderColor = Color.Silver;
                btnCursos.BorderColor = Color.Silver;
                btnMatricularEstudiante.BorderColor = Color.Silver;
            }
            else if (clsVariablesGlobales.CodigoAcceso == 3)
            {
                btnEstudiante.Enabled = true;
                btnIngresarNotas.Enabled = false;
                btnPersonal.Enabled = false;
                btnVistaMatriculas.Enabled = true;
                btnCursos.Enabled = false;
                btnPagos.Enabled = false;
                btnMatricularEstudiante.Enabled = false;

                btnMenuIngresoNotas.Enabled = false;
                btnMenuPersonal.Enabled = false;
                btnMenuVistaMatricula.Enabled = true;
                btnMenuCursosDisponibles.Enabled = false;
                btnMenuRegistroPago.Enabled = false;
                btnMenuMatriculaEstudiante.Enabled = false;

                btnMenuPersonal.BackColor = Color.DarkGray;
                btnMenuIngresoNotas.BackColor = Color.DarkGray;
                btnMenuRegistroPago.BackColor = Color.DarkGray;
                btnMenuCursosDisponibles.BackColor = Color.DarkGray;
                btnMenuMatriculaEstudiante.BackColor = Color.DarkGray;

                btnPersonal.BackColor = Color.DarkGray;
                btnIngresarNotas.BackColor = Color.DarkGray;
                btnPagos.BackColor = Color.DarkGray;
                btnCursos.BackColor = Color.DarkGray;
                btnMatricularEstudiante.BackColor = Color.DarkGray;

                btnPersonal.BorderColor = Color.Silver;
                btnIngresarNotas.BorderColor = Color.Silver;
                btnPagos.BorderColor = Color.Silver;
                btnCursos.BorderColor = Color.Silver;
                btnMatricularEstudiante.BorderColor = Color.Silver;
            }
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

                    btnPersonal.Location = new Point(205, 483);
                    btnMatricularEstudiante.Location = new Point(205, 209);

                    btnVistaMatriculas.Location = new Point(705, 209);
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

                    btnPersonal.Location = new Point(103, 483);

                    btnMatricularEstudiante.Location = new Point(103, 209);

                    btnVistaMatriculas.Location = new Point(649, 209);
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
            siNo.ShowDialog();
        }

        private void btnMenuMatriculaEstudiante_Click(object sender, EventArgs e)
        {
            ocultarBotones();
            panelMostrador.Visible = true;
            panelMostrador.Dock = DockStyle.Fill;
            panSubMenuPagos.Visible = false;
            panSubMenuPagos.Dock = DockStyle.None;

            AbrirFormulario<Modulos_Estudiante.IMatriculaIndividual>();

            if (codigoColor == 1)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }
            else if (codigoColor == 2)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
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
            if (windowMove == true)
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
            panSubMenuPersonal.Visible = true;
            panSubMenuPersonal.Dock = DockStyle.Fill;
            ocultarBotones();

            if (codigoColor == 1)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }
            else if (codigoColor == 2)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
        }

        private void btnMenuRegistroPago_Click(object sender, EventArgs e)
        {
            panSubMenuPagos.Visible = true;
            panSubMenuPagos.Dock = DockStyle.Fill;
            ocultarBotones();

            if (codigoColor == 1)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }
            else if (codigoColor == 2)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
        }

        private void btnMenuIngresoNotas_Click(object sender, EventArgs e)
        {
            ocultarBotones();
            panelMostrador.Visible = true;
            panelMostrador.Dock = DockStyle.Fill;
            AbrirFormulario<Registro_y_Vista_de_Notas.IfrmIngreso_de_Notas>();

            if (codigoColor == 1)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }
            else if (codigoColor == 2)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
        }

        private void btnMenuCursosDisponibles_Click(object sender, EventArgs e)
        {
            ocultarBotones();
            panelMostrador.Visible = true;
            panelMostrador.Dock = DockStyle.Fill;
            AbrirFormulario<Modulo_de_Cursos.IGestionCursos>();

            if (codigoColor == 1)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }
            else if (codigoColor == 2)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
        }

        private void btnMenuVistaMatricula_Click(object sender, EventArgs e)
        {
            ocultarBotones();
            panelMostrador.Visible = true;
            panelMostrador.Dock = DockStyle.Fill;
            AbrirFormulario<Registro_y_Vista_de_Notas.Alumnos_CursoSeccion>();

            if (codigoColor == 1)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }
            else if (codigoColor == 2)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
        }

        private void panelMostrador_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnMatricularEstudiante_Click(object sender, EventArgs e)
        {
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
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

                Properties.Settings.Default.isModoOscuro = true;
                Properties.Settings.Default.Save();

                ClsCambioTema.cambiarTemaBoton(panelPrincipal);
                ClsCambioTema.cambiarTemaBoton(panLateral);

                btnMenuAtras.BackColor = System.Drawing.Color.FromArgb(249, 212, 69);
                btnMenuAtras.ForeColor = Color.Black;

                /*btnMenuMatriculaEstudiante.BackColor = System.Drawing.Color.FromArgb(254, 236, 172);
                btnMenuVistaMatricula.BackColor = System.Drawing.Color.FromArgb(254, 236, 172);
                btnMenuCursosDisponibles.BackColor = System.Drawing.Color.FromArgb(254, 236, 172);
                btnMenuIngresoNotas.BackColor = System.Drawing.Color.FromArgb(254, 236, 172);
                btnMenuRegistroPago.BackColor = System.Drawing.Color.FromArgb(254, 236, 172);
                btnMenuPersonal.BackColor = System.Drawing.Color.FromArgb(254, 236, 172);
                btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(254, 236, 172);
                btnHistorialPagos.BackColor = System.Drawing.Color.FromArgb(254, 236, 172);

                btnMenuMatriculaEstudiante.ForeColor = Color.Black;
                btnMenuVistaMatricula.ForeColor = Color.Black;
                btnMenuCursosDisponibles.ForeColor = Color.Black;
                btnMenuIngresoNotas.ForeColor = Color.Black;
                btnMenuRegistroPago.ForeColor = Color.Black;
                btnMenuPersonal.ForeColor = Color.Black;
                btnRegistrarPago.ForeColor = Color.Black;
                btnHistorialPagos.ForeColor = Color.Black;

                btnMatricularEstudiante.BackColor = System.Drawing.Color.FromArgb(254, 236, 172);
                btnVistaMatriculas.BackColor = System.Drawing.Color.FromArgb(254, 236, 172);
                btnCursos.BackColor = System.Drawing.Color.FromArgb(254, 236, 172);
                btnPersonal.BackColor = System.Drawing.Color.FromArgb(254, 236, 172);
                btnPagos.BackColor = System.Drawing.Color.FromArgb(254, 236, 172);
                btnIngresarNotas.BackColor = System.Drawing.Color.FromArgb(254, 236, 172);
                btnEstudiante.BackColor = System.Drawing.Color.FromArgb(254, 236, 172);
                btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(254, 236, 172);
                btnHistorialPagos.BackColor = System.Drawing.Color.FromArgb(254, 236, 172);

                btnMatricularEstudiante.BorderColor = System.Drawing.Color.FromArgb(41, 40, 55);
                btnVistaMatriculas.BorderColor = System.Drawing.Color.FromArgb(41, 40, 55);
                btnCursos.BorderColor = System.Drawing.Color.FromArgb(41, 40, 55);
                btnPersonal.BorderColor = System.Drawing.Color.FromArgb(41, 40, 55);
                btnPagos.BorderColor = System.Drawing.Color.FromArgb(41, 40, 55);
                btnIngresarNotas.BorderColor = System.Drawing.Color.FromArgb(41, 40, 55);
                btnEstudiante.BorderColor = System.Drawing.Color.FromArgb(41, 40, 55);
                btnRegistrarPago.BorderColor = System.Drawing.Color.FromArgb(41, 40, 55);
                btnHistorialPagos.BorderColor = System.Drawing.Color.FromArgb(41, 40, 55);

                btnMatricularEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(228, 212, 154);
                btnVistaMatriculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(228, 212, 154);
                btnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(228, 212, 154);
                btnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(228, 212, 154);
                btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(228, 212, 154);
                btnIngresarNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(228, 212, 154);
                btnEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(228, 212, 154);
                btnRegistrarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(228, 212, 154);
                btnHistorialPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(228, 212, 154);

                btnMatricularEstudiante.ForeColor = Color.Black;
                btnVistaMatriculas.ForeColor = Color.Black;
                btnCursos.ForeColor = Color.Black;
                btnPersonal.ForeColor = Color.Black;
                btnPagos.ForeColor = Color.Black;
                btnIngresarNotas.ForeColor = Color.Black;
                btnEstudiante.ForeColor = Color.Black;
                btnRegistrarPago.ForeColor = Color.Black;
                btnHistorialPagos.ForeColor = Color.Black;
                */
                codigoColor = 2;
                
            }
            else if (codigoColor == 2)
            {
                panLateral.BackColor = System.Drawing.Color.FromArgb(0, 97, 169);
                panSuperior.BackColor = System.Drawing.Color.FromArgb(0, 97, 169);
                panelPrincipal.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                panSubMenuPagos.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);

                Properties.Settings.Default.isModoOscuro = false;
                Properties.Settings.Default.Save();

                ClsCambioTema.cambiarTemaBoton(panelPrincipal);
                ClsCambioTema.cambiarTemaBoton(panLateral);

                btnMenuAtras.BackColor = Color.Red;
                btnMenuAtras.ForeColor = Color.Black;


                /*btnMenuMatriculaEstudiante.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnMenuVistaMatricula.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnMenuCursosDisponibles.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnMenuIngresoNotas.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnMenuRegistroPago.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnMenuPersonal.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnHistorialPagos.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);

                btnMenuMatriculaEstudiante.ForeColor = Color.Black;
                btnMenuVistaMatricula.ForeColor = Color.Black;
                btnMenuCursosDisponibles.ForeColor = Color.Black;
                btnMenuIngresoNotas.ForeColor = Color.Black;
                btnMenuRegistroPago.ForeColor = Color.Black;
                btnMenuPersonal.ForeColor = Color.Black;
                btnRegistrarPago.ForeColor = Color.Black;
                btnHistorialPagos.ForeColor = Color.Black;

                btnMatricularEstudiante.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnVistaMatriculas.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnCursos.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnPersonal.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnPagos.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnIngresarNotas.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnEstudiante.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnRegistrarPago.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);
                btnHistorialPagos.BackColor = System.Drawing.Color.FromArgb(159, 197, 248);

                btnMatricularEstudiante.BorderColor = System.Drawing.Color.FromArgb(0, 97, 169);
                btnVistaMatriculas.BorderColor = System.Drawing.Color.FromArgb(0, 97, 169);
                btnCursos.BorderColor = System.Drawing.Color.FromArgb(0, 97, 169);
                btnPersonal.BorderColor = System.Drawing.Color.FromArgb(0, 97, 169);
                btnPagos.BorderColor = System.Drawing.Color.FromArgb(0, 97, 169);
                btnIngresarNotas.BorderColor = System.Drawing.Color.FromArgb(0, 97, 169);
                btnEstudiante.BorderColor = System.Drawing.Color.FromArgb(0, 97, 169);
                btnRegistrarPago.BorderColor = System.Drawing.Color.FromArgb(0, 97, 169);
                btnHistorialPagos.BorderColor = System.Drawing.Color.FromArgb(0, 97, 169);

                btnMatricularEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(143, 177, 223);
                btnVistaMatriculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(143, 177, 223);
                btnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(143, 177, 223);
                btnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(143, 177, 223);
                btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(143, 177, 223);
                btnIngresarNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(143, 177, 223);
                btnEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(143, 177, 223);
                btnRegistrarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(143, 177, 223);
                btnHistorialPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(143, 177, 223);

                btnMatricularEstudiante.ForeColor = Color.Black;
                btnVistaMatriculas.ForeColor = Color.Black;
                btnCursos.ForeColor = Color.Black;
                btnPersonal.ForeColor = Color.Black;
                btnPagos.ForeColor = Color.Black;
                btnIngresarNotas.ForeColor = Color.Black;
                btnEstudiante.ForeColor = Color.Black;
                btnRegistrarPago.ForeColor = Color.Black;
                btnHistorialPagos.ForeColor = Color.Black;*/

                if (clsVariablesGlobales.CodigoAcceso == 0)
                {
                    btnEstudiante.Enabled = false;
                    btnIngresarNotas.Enabled = false;
                    btnPersonal.Enabled = true;
                    btnVistaMatriculas.Enabled = false;
                    btnCursos.Enabled = false;
                    btnPagos.Enabled = false;
                    btnMatricularEstudiante.Enabled = false;

                    btnMenuIngresoNotas.Enabled = false;
                    btnMenuPersonal.Enabled = true;
                    btnMenuVistaMatricula.Enabled = false;
                    btnMenuCursosDisponibles.Enabled = false;
                    btnMenuRegistroPago.Enabled = false;
                    btnMenuMatriculaEstudiante.Enabled = false;

                    btnMenuIngresoNotas.BackColor = Color.DarkGray;
                    btnMenuVistaMatricula.BackColor = Color.DarkGray;
                    btnMenuCursosDisponibles.BackColor = Color.DarkGray;
                    btnMenuRegistroPago.BackColor = Color.DarkGray;
                    btnMenuMatriculaEstudiante.BackColor = Color.DarkGray;

                    btnEstudiante.BackColor = Color.DarkGray;
                    btnIngresarNotas.BackColor = Color.DarkGray;
                    btnVistaMatriculas.BackColor = Color.DarkGray;
                    btnCursos.BackColor = Color.DarkGray;
                    btnPagos.BackColor = Color.DarkGray;
                    btnMatricularEstudiante.BackColor = Color.DarkGray;

                    btnEstudiante.BorderColor = Color.Silver;
                    btnIngresarNotas.BorderColor = Color.Silver;
                    btnVistaMatriculas.BorderColor = Color.Silver;
                    btnCursos.BorderColor = Color.Silver;
                    btnPagos.BorderColor = Color.Silver;
                    btnMatricularEstudiante.BorderColor = Color.Silver;
                }
                else if (clsVariablesGlobales.CodigoAcceso == 1)
                {
                    btnEstudiante.Enabled = true;
                    btnIngresarNotas.Enabled = false;
                    btnPersonal.Enabled = false;
                    btnVistaMatriculas.Enabled = true;
                    btnCursos.Enabled = true;
                    btnPagos.Enabled = true;
                    btnMatricularEstudiante.Enabled = true;

                    btnMenuIngresoNotas.Enabled = false;
                    btnMenuPersonal.Enabled = false;
                    btnMenuVistaMatricula.Enabled = true;
                    btnMenuCursosDisponibles.Enabled = true;
                    btnMenuRegistroPago.Enabled = true;
                    btnMenuMatriculaEstudiante.Enabled = true;

                    btnMenuPersonal.BackColor = Color.DarkGray;
                    btnMenuIngresoNotas.BackColor = Color.DarkGray;

                    btnPersonal.BackColor = Color.DarkGray;
                    btnIngresarNotas.BackColor = Color.DarkGray;

                    btnPersonal.BorderColor = Color.Silver;
                    btnIngresarNotas.BorderColor = Color.Silver;
                }
                else if (clsVariablesGlobales.CodigoAcceso == 2)
                {
                    btnEstudiante.Enabled = true;
                    btnIngresarNotas.Enabled = true;
                    btnPersonal.Enabled = false;
                    btnVistaMatriculas.Enabled = true;
                    btnCursos.Enabled = false;
                    btnPagos.Enabled = false;
                    btnMatricularEstudiante.Enabled = false;

                    btnMenuIngresoNotas.Enabled = true;
                    btnMenuPersonal.Enabled = false;
                    btnMenuVistaMatricula.Enabled = true;
                    btnMenuCursosDisponibles.Enabled = false;
                    btnMenuRegistroPago.Enabled = false;
                    btnMenuMatriculaEstudiante.Enabled = false;

                    btnMenuPersonal.BackColor = Color.DarkGray;
                    btnMenuRegistroPago.BackColor = Color.DarkGray;
                    btnMenuCursosDisponibles.BackColor = Color.DarkGray;
                    btnMenuMatriculaEstudiante.BackColor = Color.DarkGray;

                    btnPersonal.BackColor = Color.DarkGray;
                    btnPagos.BackColor = Color.DarkGray;
                    btnCursos.BackColor = Color.DarkGray;
                    btnMatricularEstudiante.BackColor = Color.DarkGray;

                    btnPersonal.BorderColor = Color.Silver;
                    btnPagos.BorderColor = Color.Silver;
                    btnCursos.BorderColor = Color.Silver;
                    btnMatricularEstudiante.BorderColor = Color.Silver;
                }
                else if (clsVariablesGlobales.CodigoAcceso == 3)
                {
                    btnEstudiante.Enabled = true;
                    btnIngresarNotas.Enabled = false;
                    btnPersonal.Enabled = false;
                    btnVistaMatriculas.Enabled = true;
                    btnCursos.Enabled = false;
                    btnPagos.Enabled = false;
                    btnMatricularEstudiante.Enabled = false;

                    btnMenuIngresoNotas.Enabled = false;
                    btnMenuPersonal.Enabled = false;
                    btnMenuVistaMatricula.Enabled = true;
                    btnMenuCursosDisponibles.Enabled = false;
                    btnMenuRegistroPago.Enabled = false;
                    btnMenuMatriculaEstudiante.Enabled = false;

                    btnMenuPersonal.BackColor = Color.DarkGray;
                    btnMenuIngresoNotas.BackColor = Color.DarkGray;
                    btnMenuRegistroPago.BackColor = Color.DarkGray;
                    btnMenuCursosDisponibles.BackColor = Color.DarkGray;
                    btnMenuMatriculaEstudiante.BackColor = Color.DarkGray;

                    btnPersonal.BackColor = Color.DarkGray;
                    btnIngresarNotas.BackColor = Color.DarkGray;
                    btnPagos.BackColor = Color.DarkGray;
                    btnCursos.BackColor = Color.DarkGray;
                    btnMatricularEstudiante.BackColor = Color.DarkGray;

                    btnPersonal.BorderColor = Color.Silver;
                    btnIngresarNotas.BorderColor = Color.Silver;
                    btnPagos.BorderColor = Color.Silver;
                    btnCursos.BorderColor = Color.Silver;
                    btnMatricularEstudiante.BorderColor = Color.Silver;
                }

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

        private void btnPagos_Click_1(object sender, EventArgs e)
        {
        }

        private void btnPagos_MouseDown(object sender, MouseEventArgs e)
        {
            panSubMenuPagos.Visible = true;
            panSubMenuPagos.Dock = DockStyle.Fill;
            ocultarBotones();
        }

        private void ocultarBotones()
        {
            btnMatricularEstudiante.Visible = false;
            btnVistaMatriculas.Visible = false;
            btnCursos.Visible = false;
            btnPersonal.Visible = false;
            btnPagos.Visible = false;
            btnIngresarNotas.Visible = false;
            btnEstudiante.Visible = false;
        }

        private void mostrarBotones()
        {
            btnMatricularEstudiante.Visible = true;
            btnVistaMatriculas.Visible = true;
            btnCursos.Visible = true;
            btnPersonal.Visible = true;
            btnPagos.Visible = true;
            btnIngresarNotas.Visible = true;
            btnEstudiante.Visible = true;
        }

        private void btnRegistrarPago_MouseDown(object sender, MouseEventArgs e)
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

        private void btnMatricularEstudiante_Click_1(object sender, EventArgs e)
        {
        }

        private void btnMatricularEstudiante_MouseDown(object sender, MouseEventArgs e)
        {
            ocultarBotones();
            panelMostrador.Visible = true;
            panelMostrador.Dock = DockStyle.Fill;
            panSubMenuPagos.Visible = false;
            panSubMenuPagos.Dock = DockStyle.None;
            AbrirFormulario<Modulos_Estudiante.IMatriculaIndividual>();

            if (codigoColor == 1)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }
            else if (codigoColor == 2)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
        }

        private void btnRegistrarVisitaMedica_Click(object sender, EventArgs e)
        {
        }

        private void btnRegistrarVisitaMedica_MouseDown(object sender, MouseEventArgs e)
        {
            panelMostrador.Visible = true;
            panelMostrador.Dock = DockStyle.Fill;
            panSubMenuEstudiante.Visible = false;
            panSubMenuEstudiante.Dock = DockStyle.None;
            AbrirFormulario<IRegistroVisitaMedica>();

            if (codigoColor == 1)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }
            else if (codigoColor == 2)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
        }

        private void btnEstudiante_Click_1(object sender, EventArgs e)
        {
        }

        private void btnEstudiante_MouseDown(object sender, MouseEventArgs e)
        {
            panSubMenuEstudiante.Visible = true;
            panSubMenuEstudiante.Dock = DockStyle.Fill;
            ocultarBotones();
        }

        private void btnPersonal_MouseDown(object sender, MouseEventArgs e)
        {
            panSubMenuPersonal.Visible = true;
            panSubMenuPersonal.Dock = DockStyle.Fill;
            ocultarBotones();
        }

        private void btnIngresarNuevoUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            panelMostrador.Visible = true;
            panelMostrador.Dock = DockStyle.Fill;
            panSubMenuPersonal.Visible = false;
            panSubMenuPersonal.Dock = DockStyle.None;
            AbrirFormulario<Modulos_de_Empleados.IFrmGestionEmpleados>();

            if (codigoColor == 1)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }
            else if (codigoColor == 2)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
        }

        private void btnIngresarNotas_MouseDown(object sender, MouseEventArgs e)
        {
            /* ocultarBotones();
             panelMostrador.Visible = true;
             panelMostrador.Dock = DockStyle.Fill;*/
            ocultarBotones();
            panelMostrador.Visible = true;
            panelMostrador.Dock = DockStyle.Fill;
            panSubMenuEstudiante.Visible = false;
            panSubMenuEstudiante.Dock = DockStyle.None;
            AbrirFormulario<Registro_y_Vista_de_Notas.IfrmIngreso_de_Notas>();

            if (codigoColor == 1)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }
            else if (codigoColor == 2)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
        }

        private void btnCursos_MouseDown(object sender, MouseEventArgs e)
        {
            ocultarBotones();
            panelMostrador.Visible = true;
            panelMostrador.Dock = DockStyle.Fill;
            AbrirFormulario<Modulo_de_Cursos.IGestionCursos>();

            if (codigoColor == 1)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }
            else if (codigoColor == 2)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
        }

        private void btnFichaEstudiante_MouseDown(object sender, MouseEventArgs e)
        {
            panelMostrador.Visible = true;
            panelMostrador.Dock = DockStyle.Fill;
            panSubMenuEstudiante.Visible = false;
            panSubMenuEstudiante.Dock = DockStyle.None;
            AbrirFormulario<Modulos_Estudiante.IVistaFichaEstudiante>();

            if (codigoColor == 1)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }
            else if (codigoColor == 2)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
        }

        private void btnVistaMatriculas_MouseDown(object sender, MouseEventArgs e)
        {
            ocultarBotones();
            panelMostrador.Visible = true;
            panelMostrador.Dock = DockStyle.Fill;
            AbrirFormulario<Registro_y_Vista_de_Notas.Alumnos_CursoSeccion>();

            if (codigoColor == 1)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }
            else if (codigoColor == 2)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
        }

        private void btnVistaMatriculas_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            panelMostrador.Visible = true;
            panelMostrador.Dock = DockStyle.Fill;
            panSubMenuEstudiante.Visible = false;
            panSubMenuEstudiante.Dock = DockStyle.None;
            AbrirFormulario<IAperturaExpedienteMedico>();

            if (codigoColor == 1)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }
            else if (codigoColor == 2)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
        }

        //private void btnVistaMatriculas_Click_1(object sender, EventArgs e)
        //{
        //}

        //private void btnVistaMatriculas_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ocultarBotones();
        //    panelMostrador.Visible = true;
        //    panelMostrador.Dock = DockStyle.Fill;
        //    panSubMenuEstudiante.Visible = false;
        //    panSubMenuEstudiante.Dock = DockStyle.None;
        //    AbrirFormulario<Modulos_de_Registro_y_Vista_de_Notas.Seleccion_de_Curso>();

        //    if (codigoColor == 1)
        //    {
        //        formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
        //    }
        //    else if (codigoColor == 2)
        //    {
        //        formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
        //    }
        //}

        private void btnVistaMatriculas_Click_2(object sender, EventArgs e)
        {
        }

        private void btnVistaMatriculas_MouseDown_1(object sender, MouseEventArgs e)
        {
            ocultarBotones();
            panelMostrador.Visible = true;
            panelMostrador.Dock = DockStyle.Fill;
            AbrirFormulario<Registro_y_Vista_de_Notas.Alumnos_CursoSeccion>();

            if (codigoColor == 1)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(9, 141, 216);
            }
            else if (codigoColor == 2)
            {
                formulario.BackColor = System.Drawing.Color.FromArgb(51, 52, 69);
            }
        }
    }
}