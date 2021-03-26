using SistemaGestorEscolar.Login;
using SistemaGestorEscolar.Modulo_de_Pagos;
using SistemaGestorEscolar.Modulos_de_Empleados;

using SistemaGestorEscolar.Modulos_Encargado;
using SistemaGestorEscolar.Modulos_Estudiante;
using SistemaGestorEscolar.Registro_y_Vista_de_Notas;
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
            Application.Run(new IFrmVista_de_Matricula());
        }
    }
}
