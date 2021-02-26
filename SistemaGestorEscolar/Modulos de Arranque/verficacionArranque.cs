using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar.Modulos_de_Arranque
{
    class verficacionArranque
    {
        databaseConnection dbConn = new databaseConnection();
        public void verificarFecha()
        {
            try
            {
                DateTime ultimaFacturacion;
                ultimaFacturacion = dbConn.obtenerVariableDate("SELECT MAX(fechaFacturacion) FROM detalleMensualidades");

                if (ultimaFacturacion.Month > DateTime.Now.Month && (ultimaFacturacion.Year == DateTime.Now.Year || ultimaFacturacion.Year < DateTime.Now.Year))
                {
                    if (dbConn.PAGeneracionPagos(DateTime.Now))
                    {
                        Console.WriteLine("Pagos Mensuales Generados");
                    }
                    else
                    {
                        Console.WriteLine("Error al Facturar");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
