﻿using SistemaGestorEscolar.Login;
using SistemaGestorEscolar.Modulo_de_Pagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Modulos_Estudiante.ICrudEstudiante());
        }
    }
}
