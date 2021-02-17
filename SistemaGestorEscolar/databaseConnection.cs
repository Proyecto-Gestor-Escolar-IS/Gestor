using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaGestorEscolar
{
    class databaseConnection
    {
        /*Conexion a la base de datos*/
        //SqlConnection databaseIntermediary = new SqlConnection("server = 192.168.1.105,1433; database = StaMariaNazarethDatabaseService; User ID = mejiasoc; Password=paockyksyp1");
        SqlConnection databaseIntermediary = new SqlConnection("server=DESKTOP-P4A3L4O; database = StaMariaNazarethDatabaseService; Integrated Security=True");
       
        //Prueba de GitHub 3
        //que paso muchacho, yo digo que no se va a poder
        /*pero que ha pasao*/
        /*esto es una prueba de insercion*/

        /*Pero quesn Lorem ipsum he he heh e
         quejn vojn a bueno master te vale licha alexis
        */

        public void establecerConexion()
        {
            try
            {
                databaseIntermediary.Open();
                Console.WriteLine("Conexión con el servidor LAN establecida");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void detenerConexion()
        {
            try
            {
                databaseIntermediary.Close();
                Console.WriteLine("Servidor Desconectado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
