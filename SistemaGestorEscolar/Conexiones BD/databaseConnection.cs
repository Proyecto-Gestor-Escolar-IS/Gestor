using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SistemaGestorEscolar
{
    class databaseConnection
    {
        /*Conexion a la base de datos*/
        //SqlConnection databaseIntermediary = new SqlConnection("server = 192.168.1.105,1433; database = StaMariaNazarethDatabaseService; User ID = mejiasoc; Password=paockyksyp1");
        SqlConnection databaseIntermediary = new SqlConnection("server=HACKNEL; database = StaMariaNazarethDatabaseService; Integrated Security=True");
        public SqlDataAdapter adaptador;
        public DataTable tablaDatos1;
        public SqlDataReader lectorVariables;
        public SqlCommand comando;

        public void establecerConexion()
        {
            try
            {
                databaseIntermediary.Open();
                databaseIntermediary.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar, error: " + ex.ToString());
                databaseIntermediary.Close();
            }
        }

        //Comprueba la existencia de los usuarios en la base de datos
        public Boolean comprobarUsuario(string usuario, string contra)
        {
            databaseIntermediary.Open();
            string comandoSql = "SELECT COUNT(*) FROM datosEmpleados WHERE identidadPersona = '" + usuario + "' AND contraseniaEmpleado = '" + contra + "'";
            comando = databaseIntermediary.CreateCommand();
            comando.CommandText = comandoSql;

            var t = Convert.ToInt32(comando.ExecuteScalar());
            databaseIntermediary.Close();

            if (t != 0)
            {
                return true;
            }
            return false;
        }

        //Metodo para llenar combobox (se envia el combobox a llenar) e (instruccion sql)
        public void llenarComboBox(ComboBox cmb, string instruccion)
        {
            try
            {
                databaseIntermediary.Open();
                comando = new SqlCommand(instruccion, databaseIntermediary);
                lectorVariables = comando.ExecuteReader();
                while (lectorVariables.Read())
                {
                    cmb.Items.Add(lectorVariables.GetValue(0).ToString());
                }
                lectorVariables.Close();
                databaseIntermediary.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de base de datos! \n" + ex.ToString());
            }
        }

        //Metodo para llenar combobox (se envia el TextBox a llenar) e (instruccion sql)
        public void llenarTextBox(TextBox text, string instruccion)
        {
            try
            {
                databaseIntermediary.Open();
                comando = new SqlCommand(instruccion, databaseIntermediary);
                lectorVariables = comando.ExecuteReader();
                while (lectorVariables.Read())
                {
                    text.Text = lectorVariables.GetValue(0).ToString();
                }
                lectorVariables.Close();
                databaseIntermediary.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de base de datos! \n" + ex.ToString());
            }
        }

        //Metodo para obtener variables INT de la base de datos. (Se envia el comando sql) de donde se quiere obtener la variable [RETORNA -1 SI NO ENCUENTRA UN VALOR]
        public int obtenerVariableEntera(string instruccion)
        {
            try
            {
                databaseIntermediary.Open();
                int valor = 0;
                comando = new SqlCommand(instruccion, databaseIntermediary);
                lectorVariables = comando.ExecuteReader();
                if(lectorVariables.Read())
                {
                    valor = Convert.ToInt16(lectorVariables.GetValue(0));
                }
                lectorVariables.Close();
                databaseIntermediary.Close();
                return valor;
            }
            catch (Exception ex)
            {
                databaseIntermediary.Close();
                MessageBox.Show("Error de base de datos! \n" + ex.ToString());
                return -1;
            }
            
        }

        //Metodo para obtener variables DOUBLE de la base de datos. (Se envia el comando sql) de donde se quiere obtener la variable [RETORNA -1 SI NO ENCUENTRA UN VALOR]
        public double obtenerVariableDouble(string instruccion)
        {
            try
            {
                databaseIntermediary.Open();
                double valor = 0;
                comando = new SqlCommand(instruccion, databaseIntermediary);
                lectorVariables = comando.ExecuteReader();
                if (lectorVariables.Read())
                {
                    valor = Convert.ToDouble(lectorVariables.GetValue(0));
                }
                lectorVariables.Close();
                databaseIntermediary.Close();
                return valor;
            }
            catch (Exception ex)
            {
                databaseIntermediary.Close();
                MessageBox.Show("Error de base de datos! \n" + ex.ToString());
                return -1;
            }

        }

        //Metodo para obtener variables STRING de la base de datos. (Se envia el comando sql) de donde se quiere obtener la variable [RETORNA null SI NO ENCUENTRA UN VALOR]
        public string obtenerVariableString(string instruccion)
        {
            try
            {
                databaseIntermediary.Open();
                string valor = "";
                comando = new SqlCommand(instruccion, databaseIntermediary);
                lectorVariables = comando.ExecuteReader();
                if (lectorVariables.Read())
                {
                    valor = Convert.ToString(lectorVariables.GetValue(0));
                }
                else
                {
                    lectorVariables.Close();
                    databaseIntermediary.Close();
                    return null;
                }
                lectorVariables.Close();
                databaseIntermediary.Close();
                return valor;
            }
            catch (Exception ex)
            {
                databaseIntermediary.Close();
                MessageBox.Show("Error de base de datos! \n" + ex.ToString());
                return null;
            }

        }

        //Metodo enviar COMANDOS SQL donde se quiera hacer operaciones de DELETE, UPDATE, (se envia comando SQL)     [RETORNA null SI HAY UN ERROR DE EJECUCION]
        public Boolean ejecutarComandoSQL(string instruccion)
        {
            try
            {
                databaseIntermediary.Open();
                comando = new SqlCommand(instruccion, databaseIntermediary);
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                databaseIntermediary.Close();
                MessageBox.Show("Error de base de datos! \n" + ex.ToString());
                return false;
            }

        }


    }
}
