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
            if (panLateral.Width <= 160)
            {
                this.tmrOcultarMenu.Enabled = false;
                btnMenuAtras.Width = 145;
                btnMenuAtras.BackgroundImageLayout = ImageLayout.Zoom;
                btnMenuAtras.BackgroundImage = Properties.Resources.exitButton;
            }
            else 
            {
                this.panLateral.Width = panLateral.Width - 70;
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
            if (panLateral.Width == 285)
            {
                tmrOcultarMenu.Enabled = true;
                btnMenuAtras.Text = "";



            }
            else if (panLateral.Width == 145)
            {
                tmrMostrarMenu.Enabled = true;

                btnMenuAtras.Width = 285;
                btnMenuAtras.Text = "ATRAS";
                btnMenuAtras.BackgroundImage = null;

            }
            MessageBox.Show(""+panLateral.Width);
            


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
    }
}
