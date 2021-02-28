using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Drawing;
using System.IO;

namespace SistemaGestorEscolar
{
    class databaseConnection
    {
        clsUtilidades utilidades = new clsUtilidades();

        /*Conexion a la base de datos*/
        //SqlConnection databaseIntermediary = new SqlConnection("server = 192.168.1.105,1433; database = StaMariaNazarethDatabaseService; User ID = mejiasoc; Password=paockyksyp1");
        SqlConnection databaseIntermediary = new SqlConnection("Data Source=DESKTOP-P4A3L4O;Initial Catalog=StaMariaNazarethDatabaseService;Integrated Security=True");
        public SqlDataAdapter adaptador;
        public DataTable tablaDatos;
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

        //Agrega informacion de una consulta SQL a un datagridview
        public bool llenarDGV(DataGridView dgv, string instruccion)
        {
            try
            {
                databaseIntermediary.Open();
                adaptador = new SqlDataAdapter(instruccion, databaseIntermediary);
                tablaDatos = new DataTable();
                adaptador.Fill(tablaDatos);
                dgv.DataSource = tablaDatos;
                databaseIntermediary.Close();
                return true;
            }
            catch (Exception ex)
            {
                databaseIntermediary.Close();
                MessageBox.Show("No se pudo conectar, error: " + ex.ToString());
                return false;
            }
        }

        //Comprueba la existencia de los usuarios en la base de datos
        public bool comprobarUsuario(string usuario, string contra)
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

        //Metodo para llenar textBox (se envia el TextBox a llenar) e (instruccion sql)
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
        public bool ejecutarComandoSQL(string instruccion)
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

        public bool PAOperacionEmpleado(string idPerona, string nombre1, string nombre2, string apellido1, string apellido2, int tel, string fechaN,
            string mail, string estado, string contra, int idCargo, int cargoAnterior, int codigo)
        {
            try
            {
                
                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "PAOperacionEmpleados";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idPersona", idPerona);
                comando.Parameters.AddWithValue("@prNombre", nombre1);
                comando.Parameters.AddWithValue("@sgNombre", nombre2);
                comando.Parameters.AddWithValue("@prApellido", apellido1);
                comando.Parameters.AddWithValue("@sgApellido", apellido2);
                comando.Parameters.AddWithValue("@numTelefono", tel);
                comando.Parameters.AddWithValue("@fNacimiento", fechaN);
                comando.Parameters.AddWithValue("@mail", mail);
                comando.Parameters.AddWithValue("@estEmpleado", estado);
                comando.Parameters.AddWithValue("@contra", contra);
                comando.Parameters.AddWithValue("@idCargo", idCargo);

                if (codigo == 1)
                {
                    comando.Parameters.AddWithValue("@CODIGO", 1);
                    comando.Parameters.AddWithValue("@idCargoAnterior", -1);
                }
                else if (codigo == 2)
                {
                    comando.Parameters.AddWithValue("@CODIGO", 2);
                    comando.Parameters.AddWithValue("@idCargoAnteriora", cargoAnterior);
                }
                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error de Insercion Usuario", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        
        public bool PARegistroPago(string identidadEstudiante, double montoPago, DateTime fechaPago, double descuento, Image img)
        {
            try
            {

                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "PARegistroPago";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@identidadEstudiante", identidadEstudiante);
                comando.Parameters.AddWithValue("@montoPago", montoPago);
                comando.Parameters.AddWithValue("@fechaPago", fechaPago);
                comando.Parameters.AddWithValue("@descuento", descuento);
                comando.Parameters.AddWithValue("@imagen", utilidades.imagenAByte(img));

                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error de Registro de Pago", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public DateTime obtenerVariableDate(string instruccion)
        {
            try
            {
                databaseIntermediary.Open();
                DateTime valor;
                comando = new SqlCommand(instruccion, databaseIntermediary);
                lectorVariables = comando.ExecuteReader();
                if (lectorVariables.Read())
                {
                    valor = Convert.ToDateTime(lectorVariables.GetValue(0));

                }
                else
                {
                    lectorVariables.Close();
                    databaseIntermediary.Close();
                    return default(DateTime);
                }
                lectorVariables.Close();
                databaseIntermediary.Close();
                return valor;
            }
            catch (Exception ex)
            {
                databaseIntermediary.Close();
                MessageBox.Show("Error de base de datos! \n" + ex.ToString());
                return default(DateTime);
            }

        }

        public bool PAGeneracionPagos(DateTime fechaFacturacion)
        {
            try
            {

                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "PAGeneracionPagos";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@fechaFacturacion", fechaFacturacion);
                comando.Parameters.AddWithValue("@imagen", utilidades.imagenAByte(Properties.Resources.imgComprobantePendiente));

                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error de Registro de Pago", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public Image obtenerImagen(string instruccion)
        {
            try
            {
                databaseIntermediary.Open();
                comando = new SqlCommand(instruccion, databaseIntermediary);
                adaptador = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream memoryStream = new MemoryStream((byte[])ds.Tables[0].Rows[0]["comprobantePago"]);
                    databaseIntermediary.Close();
                    return new Bitmap(memoryStream);
                }
                databaseIntermediary.Close();
                return null;
            }
            catch
            {
                databaseIntermediary.Close();
                return null;
            }
        }

        public void llenarDataGridPagos(DataGridView dgv, string idEstudiante)
        {
            SqlCommand cmd = new SqlCommand("Select id_Mensualidad as 'ID', fechaFacturacion as 'FECHA DE FACTURACION', fechaPago as 'FECHA DE PAGO', deudaPendiente as 'DEUDA', saldoDisponible as 'SALDO', descuentoMensualidad as 'DESCUENTO' from detalleMensualidades WHERE id_Estudiante = '" + idEstudiante + "'", databaseIntermediary);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            databaseIntermediary.Close();
        }

        public bool PARegistroEncargado(string Numidentidad, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string correoElectronico,
            string numeroTelefono, string numeroTelefonoAlt, string direccionTrabajo, string fechaNacimiento)
        {
            try
            {

                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "RegistrarEncargado";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Numidentidad", Numidentidad);
                comando.Parameters.AddWithValue("@primerNombre", primerNombre);
                comando.Parameters.AddWithValue("@segundoNombre", segundoNombre);
                comando.Parameters.AddWithValue("@primerApellido", primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", segundoApellido);
                comando.Parameters.AddWithValue("@correoElectronico", correoElectronico);
                comando.Parameters.AddWithValue("@numeroTelefono", numeroTelefono);
                comando.Parameters.AddWithValue("@numeroTelefonoAlt", numeroTelefonoAlt);
                comando.Parameters.AddWithValue("@direccionTrabajo", direccionTrabajo);
                comando.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);


                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error de Registro de Encargado", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool PAActualizarEncargado(string Numidentidad, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string correoElectronico,
      string numeroTelefono, string numeroTelefonoAlt, string direccionTrabajo)
        {
            try
            {

                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "ActualizarEncargado";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Numidentidad", Numidentidad);
                comando.Parameters.AddWithValue("@primerNombre", primerNombre);
                comando.Parameters.AddWithValue("@segundoNombre", segundoNombre);
                comando.Parameters.AddWithValue("@primerApellido", primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", segundoApellido);
                comando.Parameters.AddWithValue("@correoElectronico", correoElectronico);
                comando.Parameters.AddWithValue("@numeroTelefono", numeroTelefono);
                comando.Parameters.AddWithValue("@numeroTelefonoAlt", numeroTelefonoAlt);
                comando.Parameters.AddWithValue("@direccionTrabajo", direccionTrabajo);


                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error de Actualizacion de Encargado", "Error de Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //comprobar Existencia (manda instruccion, si existe retorna true caso contrario false)
        public bool ComprobarExistencia(string instruccion)
        {
            databaseIntermediary.Open();
            comando = new SqlCommand(instruccion, databaseIntermediary);

            var t = Convert.ToInt32(comando.ExecuteScalar());
            databaseIntermediary.Close();

            if (t != 0)
            {
                return true;
            }
            return false;
        }



    }



}
