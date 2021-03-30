using AltoControls;
using SistemaGestorEscolar.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Utilidades
{
    class ClsCambioTema
    {

        public static void cambiarTemaBoton(Control cont)
        {
            try
            {
                List<Object> listaAlto = new List<Object>();
                List<Object> listaRounded = new List<Object>();
                List<Object> listaNormal = new List<Object>();
                List<Object> listaLabels = new List<Object>();
                List<Object> listaDGV = new List<Object>();

                foreach (Control control1 in cont.Controls)
                {
                    if (control1.GetType() == typeof(AltoButton))
                    {
                        listaAlto.Add(control1);
                    }
                    else if (control1.GetType() == typeof(RoundedButton))
                    {
                        listaRounded.Add(control1);
                    }
                    else if(control1.GetType() == typeof(Button))
                    {
                        listaNormal.Add(control1);
                    }
                    else if(control1.GetType() == typeof(Label) || control1.GetType() == typeof(CheckBox))
                    {
                        listaLabels.Add(control1);
                    }
                    else if (control1.GetType() == typeof(DataGridView))
                    {
                        listaDGV.Add(control1);
                    }
                }

                if (!Properties.Settings.Default.isModoOscuro)
                {
                    foreach (Control con in listaLabels)
                    {
                        con.ForeColor = Color.Black;
                        cont.Invalidate();
                    }
                    foreach (DataGridView con in listaDGV)
                    {
                        con.BackgroundColor = Color.FromArgb(9, 141, 216);
                        cont.Invalidate();
                    }
                }
                else
                {
                    foreach (Control con in listaLabels)
                    {
                        con.ForeColor = Color.White;
                        cont.Invalidate();
                    }
                    foreach (DataGridView con in listaDGV)
                    {
                        con.BackgroundColor = Color.FromArgb(51, 52, 69);
                        cont.Invalidate();
                    }
                }

                if (listaAlto.Count != 0)
                {
                    if(!Properties.Settings.Default.isModoOscuro)
                    {
                        foreach (AltoButton btn in listaAlto)
                        {
                            btn.Inactive1 = Color.FromArgb(159, 197, 248);
                            btn.Inactive2 = Color.FromArgb(159, 197, 248);
                            btn.Active1 = Color.FromArgb(143, 177, 223);
                            btn.Active2 = Color.FromArgb(143, 177, 223);
                            btn.ForeColor = Color.Black;
                            btn.StrokeColor = Color.FromArgb(0, 97, 169);
                            cont.Invalidate();
                        }
                    }
                    else
                    {
                        foreach (AltoButton btn in listaAlto)
                        {
                            btn.Inactive1 = Color.FromArgb(254, 236, 172);
                            btn.Inactive2 = Color.FromArgb(254, 236, 172);
                            btn.Active1 = Color.FromArgb(228, 212, 154);
                            btn.Active2 = Color.FromArgb(228, 212, 154);
                            btn.ForeColor = Color.Black;
                            btn.StrokeColor = Color.FromArgb(41, 40, 55);
                            cont.Invalidate();
                        }
                    }
                    
                }else if(listaRounded.Count != 0)
                {
                    if (!Properties.Settings.Default.isModoOscuro)
                    {
                        foreach (RoundedButton btn in listaRounded)
                        {
                            btn.BackColor = Color.FromArgb(159, 197, 248);
                            btn.BorderColor = Color.FromArgb(0, 97, 169);
                            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 177, 223);
                            btn.ForeColor = Color.Black;
                            cont.Invalidate();
                        }
                    }
                    else
                    {
                        foreach (RoundedButton btn in listaRounded)
                        {
                            btn.BackColor = Color.FromArgb(254, 236, 172);
                            btn.BorderColor = Color.FromArgb(41, 40, 55);
                            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 212, 154);
                            btn.ForeColor = Color.Black;
                            cont.Invalidate();
                        }
                    }
                }
                else
                {
                    if (!Properties.Settings.Default.isModoOscuro)
                    {
                        foreach (Button btn in listaNormal)
                        {
                            btn.BackColor = Color.FromArgb(159, 197, 248);
                            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(143, 177, 223);
                            btn.ForeColor = Color.Black;
                            cont.Invalidate();
                        }
                    }
                    else
                    {
                        foreach (Button btn in listaNormal)
                        {
                            btn.BackColor = Color.FromArgb(254, 236, 172);
                            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 212, 154);
                            btn.ForeColor = Color.Black;
                            cont.Invalidate();
                        }
                    }
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

    }
}
