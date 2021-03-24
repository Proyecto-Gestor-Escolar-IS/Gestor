using AltoControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Utilidades
{
    class ClsCambioTema : AltoButton
    {

        public void cambiarTemaBoton(Control cont)
        {
            List<Object> listaBtn = new List<Object>();

            foreach(Control control1 in cont.Controls){
                if (control1.GetType() == typeof(AltoButton))
                {
                    listaBtn.Add(control1);
                }
            }

            foreach (AltoButton btn in listaBtn)
            {
                btn.Inactive1 = System.Drawing.Color.FromArgb(159, 197, 248);
                btn.Inactive2 = System.Drawing.Color.FromArgb(159, 197, 248);
                btn.ForeColor = Color.Black;
                btn.StrokeColor = System.Drawing.Color.FromArgb(41, 40, 55);
                cont.Invalidate();
            }
            /*if (clsVariablesGlobales.isTemaOscuro == false)
            {
                foreach (AltoButton btn in cont.Controls)
                {
                    btn.Inactive1 = System.Drawing.Color.FromArgb(159, 197, 248);
                    btn.Inactive2 = System.Drawing.Color.FromArgb(159, 197, 248);
                    btn.ForeColor = Color.Black;
                    btn.StrokeColor = System.Drawing.Color.FromArgb(41, 40, 55);
                    cont.Invalidate();
                }
            }

            /*Control cont = new Control();
            if (clsVariablesGlobales.isTemaOscuro == false)
            {
                btn.Inactive1 = System.Drawing.Color.FromArgb(159, 197, 248);
                btn.Inactive2 = System.Drawing.Color.FromArgb(159, 197, 248);
                btn.ForeColor = Color.Black;
                btn.StrokeColor = System.Drawing.Color.FromArgb(41, 40, 55);

            }
            cont.Invalidate();*/
        }

        private void GetAllControls(Control c, List<Control> list)
        {
            foreach (Control control in c.Controls)
            {
                list.Add(control);

                if (control.GetType() == typeof(AltoButton))
                    GetAllControls(control, list);
            }

        }
    }
}
