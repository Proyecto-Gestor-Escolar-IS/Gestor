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
using System.Globalization;

namespace SistemaGestorEscolar
{
    class databaseConnection
    {
        clsUtilidades utilidades = new clsUtilidades();

        /*Conexion a la base de datos*/
        //SqlConnection databaseIntermediary = new SqlConnection("server = 192.168.1.105,1433; database = StaMariaNazarethDatabaseService; User ID = mejiasoc; Password=paockyksyp1");


        //SqlConnection databaseIntermediary = new SqlConnection("server = tcp:mejiasoc4.database.windows.net,1433;Database=staMariaAzure;User ID = mejiaazu2001;Password=paockyksyp12!;Trusted_Connection=False;Encrypt=True;");

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
                MessageBox.Show("Si se pudo conectar ");
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
            try
            {
                databaseIntermediary.Open();
                string comandoSql = "SELECT COUNT(*) FROM datosEmpleados WHERE identidadPersona = '" + usuario + "' AND contraseniaEmpleado = '" + contra + "' AND estadoEmpleado <> 2";
                comando = databaseIntermediary.CreateCommand();
                comando.CommandText = comandoSql;

                //ERROR FATAL AQUI ! - AL INSERTAR EL CARACTER <'> EL PROGRAMA CRASHEA
                var t = Convert.ToInt32(comando.ExecuteScalar());
                databaseIntermediary.Close();

                if (t != 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                databaseIntermediary.Close();
                return false;
            }

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

        public void llenarComboBoxValorInicial(ComboBox cmb, string instruccion)
        {
            try
            {
                databaseIntermediary.Open();
                comando = new SqlCommand(instruccion, databaseIntermediary);
                lectorVariables = comando.ExecuteReader();
                cmb.Items.Add("<SELECCIONE>");
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

        //Metodo para obtener variables INT de la base de datos. (Se envia el comando sql) de donde se quiere obtener la variable [RETORNA -1 SI NO ENCUENTRA UN VALOR]
        public int obtenerVariableEntera(string instruccion)
        {
            try
            {
                databaseIntermediary.Open();
                int valor = 0;
                comando = new SqlCommand(instruccion, databaseIntermediary);
                lectorVariables = comando.ExecuteReader();
                if (lectorVariables.Read())
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
            string mail, int estado, string contra, int idCargo, int cargoAnterior, int codigo)
        {
            try
            {

                DateTime dt = DateTime.ParseExact(fechaN, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "PAOperacionEmpleados";
                comando.CommandType = CommandType.StoredProcedure;


                comando.Parameters.AddWithValue("@idPersona", idPerona);
                comando.Parameters.AddWithValue("@prNombre", nombre1);
                comando.Parameters.AddWithValue("@sgNombre", nombre2);
                comando.Parameters.AddWithValue("@prApellido", apellido1);
                comando.Parameters.AddWithValue("@sgApellido", apellido2);
                comando.Parameters.AddWithValue("@numTelefono", tel);
                comando.Parameters.AddWithValue("@fNacimiento", dt);
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
                    comando.Parameters.AddWithValue("@idCargoAnterior", cargoAnterior);
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
                    //MessageBox.Show("Error de Insercion Usuario", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //  1 para agregar y comprobar, 2 para solo comprobar si ya tiene ese cargo
        public bool PAAgregarYComprobarCargo(string idPersona, int cargo, int codigo)
        {
            try
            {

                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "PAAgregaYComprobarCargo";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@identidad", idPersona);
                comando.Parameters.AddWithValue("@cCargo", Convert.ToInt32(cargo));
                comando.Parameters.AddWithValue("@CODIGO", Convert.ToInt32(codigo));

                databaseIntermediary.Open();
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
                return false;
            }
        }

        public int retornarIdExpediente()
        {
            try
            {
                int valorARetornar;
                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = ("SELECT MAX(id_Expediente) FROM expedienteMedico");

                databaseIntermediary.Open();

                object value = comando.ExecuteScalar();
                if (value != DBNull.Value) {
                    valorARetornar = Convert.ToInt32(value);
                }
                else
                {
                  valorARetornar = 0;
                }
                databaseIntermediary.Close();

                return valorARetornar;
           }

            catch (Exception ex)
            {
                MessageBox.Show("Error de base de datos! \n" + ex.ToString());
                databaseIntermediary.Close();
                return default;
            }
           
        }

        /*MEJIASOC-------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
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

        public bool PAGeneracionPrimerPago(string identidadEstudiante)
        {
            try
            {

                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "PAFacturacionPrimerPago";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@identidadEstudiante", identidadEstudiante);

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

        public bool PARegistrarMatricula(string identidadEmpleado, string identidadEncargado, string identidadEstudiante, int idCurso, int idSeccion, float totalMatricula, int tipoMatricula, int mesesPago, int estado, int codigoOperacion)
        {
            try
            {
                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "PARegistroMatricula";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@identidadAdministracion", identidadEmpleado);
                comando.Parameters.AddWithValue("@identidadEncargado", identidadEncargado);
                comando.Parameters.AddWithValue("@identidadEstudiante", identidadEstudiante);
                comando.Parameters.AddWithValue("@idCurso", idCurso);
                comando.Parameters.AddWithValue("@idSeccion", idSeccion);
                comando.Parameters.AddWithValue("@totalMatricula", totalMatricula);
                comando.Parameters.AddWithValue("@tipoMatricula", tipoMatricula);
                comando.Parameters.AddWithValue("@mesesPago", mesesPago);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@codigoOperacion", codigoOperacion);

                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error de Registro de Matricula", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        /*MEJIASOC-------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

        public bool PARegistroEncargado(string NumidentidadEstud, string Numidentidad, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string correoElectronico,
            string numeroTelefono, string numeroTelefonoAlt, string direccionTrabajo, string fechaNacimiento)
        {
            try
            {
                SqlCommand comando = databaseIntermediary.CreateCommand();

                DateTime dt = DateTime.ParseExact(fechaNacimiento, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                comando.CommandText = "RegistrarEncargado";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@NumidentidadEstudiante", NumidentidadEstud);
                comando.Parameters.AddWithValue("@Numidentidad", Numidentidad);
                comando.Parameters.AddWithValue("@primerNombre", primerNombre);
                comando.Parameters.AddWithValue("@segundoNombre", segundoNombre);
                comando.Parameters.AddWithValue("@primerApellido", primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", segundoApellido);
                comando.Parameters.AddWithValue("@correoElectronico", correoElectronico);
                comando.Parameters.AddWithValue("@numeroTelefono", int.Parse(numeroTelefono));
                comando.Parameters.AddWithValue("@numeroTelefonoAlt", int.Parse(numeroTelefonoAlt));
                comando.Parameters.AddWithValue("@direccionTrabajo", direccionTrabajo);
                comando.Parameters.AddWithValue("@fechaNacimiento", dt);

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

        //Registro de Notas

        public bool PAAgregarNota(int id_detalleMatricula, int id_Clase, float nota1, float nota2, float nota3, float nota4, float notaProm, string notaA, string notaB, string notaC, string notaD, string notaE)
        {

            try
            {
                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "agregarNota";
                comando.Parameters.AddWithValue("@id_DetalleMatricula", id_detalleMatricula);
                comando.Parameters.AddWithValue("@id_Clase", id_Clase);
                comando.Parameters.AddWithValue("@nota1erParcial", nota1);
                comando.Parameters.AddWithValue("@nota2doParcial", nota2);
                comando.Parameters.AddWithValue("@nota3erParcial", nota3);
                comando.Parameters.AddWithValue("@nota4toParcial", nota4);
                comando.Parameters.AddWithValue("@notaFinal", notaProm);
                comando.Parameters.AddWithValue("@notaA", notaA);
                comando.Parameters.AddWithValue("@notaB", notaB);
                comando.Parameters.AddWithValue("@notaC", notaC);
                comando.Parameters.AddWithValue("@notaD", notaD);
                comando.Parameters.AddWithValue("@notaE", notaE);

                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    Console.WriteLine("Error de Registro de las Notas", "Error de Insercion");
                    return false;
                }

            }
            catch (Exception ex)
            {
                databaseIntermediary.Close();
                Console.WriteLine("Error de base de datos! \n" + ex.ToString());
                return false;
            }

        }

        //Modificar una Nota 

        public bool PAModificarNota(int id_detalleMatricula, int id_Clase, float nota1, float nota2, float nota3, float nota4, float notaProm, string notaA, string notaB, string notaC, string notaD, string notaE)
        {
            try
            {
                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "modificarNota";
                comando.Parameters.AddWithValue("@id_DetalleMatricula", id_detalleMatricula);
                comando.Parameters.AddWithValue("@id_Clase", id_Clase);
                comando.Parameters.AddWithValue("@nota1erParcial", nota1);
                comando.Parameters.AddWithValue("@nota2doParcial", nota2);
                comando.Parameters.AddWithValue("@nota3erParcial", nota3);
                comando.Parameters.AddWithValue("@nota4toParcial", nota4);
                comando.Parameters.AddWithValue("@notaFinal", notaProm);
                comando.Parameters.AddWithValue("@notaA", notaA);
                comando.Parameters.AddWithValue("@notaB", notaB);
                comando.Parameters.AddWithValue("@notaC", notaC);
                comando.Parameters.AddWithValue("@notaD", notaD);
                comando.Parameters.AddWithValue("@notaE", notaE);

                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    Console.WriteLine("Error de Registro de las Notas", "Error de Insercion");
                    return false;
                }

            }
            catch (Exception ex)
            {
                databaseIntermediary.Close();
                Console.WriteLine("Error de base de datos! \n" + ex.ToString());
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

            if (t == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        public bool PAActualizarEstudiante(string Numidentidad, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido)
        {
            try
            {

                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "ActualizarEstudiante";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@identidadEstudiante", Numidentidad);
                comando.Parameters.AddWithValue("@primerNombre", primerNombre);
                comando.Parameters.AddWithValue("@segundoNombre", segundoNombre);
                comando.Parameters.AddWithValue("@primerApellido", primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", segundoApellido);



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

        public bool abrirExpediente(string id_Estudiante, string antecedentesMedicos)
        {
            try
            {

                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "abrirExpediente";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id_Estudiante", id_Estudiante);
                comando.Parameters.AddWithValue("@antecedentesMedicos", antecedentesMedicos);

                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error al abrir Expediente Médico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool registroVisitaMedica(int id_expediente, string id_DoctorEncargado, string sintomas, string posibleEnfermedad, string medicamentos)
        {
            try
            {

                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "registroVisitaMedica";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id_expediente", id_expediente);
                comando.Parameters.AddWithValue("@id_DoctorEncargado", id_DoctorEncargado);
                comando.Parameters.AddWithValue("@sintomas", sintomas);
                comando.Parameters.AddWithValue("@posibleEnfermedad", posibleEnfermedad);
                comando.Parameters.AddWithValue("@medicamentos", medicamentos);

                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error al Registrar la Visita Médica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool PARegistrarEstudiante(string Numidentidad, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string fechaNacimiento,string genero)
        {
            try
            {
                DateTime dt = DateTime.ParseExact(fechaNacimiento, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "RegistrarEstudiante";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@identidadEstudiante", Numidentidad);
                comando.Parameters.AddWithValue("@primerNombre", primerNombre);
                comando.Parameters.AddWithValue("@segundoNombre", segundoNombre);
                comando.Parameters.AddWithValue("@primerApellido", primerApellido);
                comando.Parameters.AddWithValue("@segundoApellido", segundoApellido);
                comando.Parameters.AddWithValue("@fechaNacimiento", dt);
                comando.Parameters.AddWithValue("@genero", genero);
                
                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error de Registro del Estudiante", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool PAActualizarCursos(int idCurso, String nombreCurso, double precioCurso)
        {
            try
            {
                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "PAActualizarCurso";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@id_Curso", idCurso);
                comando.Parameters.AddWithValue("@nombreCurso", nombreCurso);
                comando.Parameters.AddWithValue("@precioCompleto", precioCurso);

                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error de Gestión cursos", "Error de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool PARegistroCursos(String nombreCurso, double precioCurso, int estadoCurso)
        {
            try
            {
                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "PARegistrarCurso";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@nombreCurso", nombreCurso);
                comando.Parameters.AddWithValue("@precioCompleto", precioCurso);
                comando.Parameters.AddWithValue("@estadoCurso", estadoCurso);

                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error de Gestión cursos", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        /*CRUD CURSOS*/
        public bool PAInsertarCurso(String nombreCurso, float precioMensual, int tipoCalificacion, int estado)
        {
            try
            {
                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "registrarCurso";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@nombreCurso", nombreCurso);
                comando.Parameters.AddWithValue("@precio", precioMensual);
                comando.Parameters.AddWithValue("@tipoCalificacion", tipoCalificacion);
                comando.Parameters.AddWithValue("@estadoCurso", estado);

                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error al registrar un Curso", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public bool PAInsertarDetalleClases(int idClase, int idCurso)
        {
            try
            {
                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "registrarDetalleClases";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idClase", idClase);
                comando.Parameters.AddWithValue("@idCurso", idCurso);


                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error al registrar un Curso", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool PAActualizarCurso(int idCurso, float precio)
        {
            try
            {
                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "actualizarCurso";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idCurso", idCurso);
                comando.Parameters.AddWithValue("@precioCurso", precio);


                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error al actualizar un Curso", "Error de Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool PAEliminarDetallesClases(int idCurso)
        {
            try
            {
                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "eliminarDetalleClases";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idCurso", idCurso);

                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error Fatal al Registrar nuevas clases", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool PAActualizarSeccion(int idSeccion, String docente, int estado)
        {
            try
            {
                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "actualizarSeccion";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idSeccion", idSeccion);
                comando.Parameters.AddWithValue("@docente", docente);
                comando.Parameters.AddWithValue("@estado", estado);

                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error al actualizar una Seccion", "Error de Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        public bool PARegistrarSeccion(int idCurso, String docente, char seccion)
        {
            try
            {
                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "insertarSeccion";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idCurso", idCurso);
                comando.Parameters.AddWithValue("@identidadDocente", docente);
                comando.Parameters.AddWithValue("@seccion", seccion);

                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error al registrar una Seccion", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /*CLASES*/
        public bool PAActualizarClase(int idClase, int estado)
        {
            try
            {
                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "actualizarClase";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idClase", idClase);
                comando.Parameters.AddWithValue("@estado", estado);


                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error al registrar una Seccion", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool PARegistrarClase(String nombreClase)
        {
            try
            {
                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "registrarClase";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@nombreClase", nombreClase);


                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error al registrar una Seccion", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool PACambiarEstadoCurso(int idCurso, int estado)
        {
            try
            {
                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "cambiarEstadoCurso";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idCurso", idCurso);
                comando.Parameters.AddWithValue("@estado", estado);


                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error al cambiar un curso", "Error de Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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






        /*
        public bool PARegistroSeccion(String seccion, int curso, int docente, int estado)
        {
            try
            {
                SqlCommand comando = databaseIntermediary.CreateCommand();
                comando.CommandText = "PARegistrarSeccion";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@idCurso", IdCurso);
                comando.Parameters.AddWithValue("@idDocente", IdDocente);
                comando.Parameters.AddWithValue("@nombreSeccion", nombreSeccion);
                comando.Parameters.AddWithValue("@estado", estado);

                databaseIntermediary.Open();
                if (comando.ExecuteNonQuery() != -1)
                {
                    databaseIntermediary.Close();
                    return true;
                }
                else
                {
                    databaseIntermediary.Close();
                    MessageBox.Show("Error de Gestión cursos", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception ex)
            {
                databaseIntermediary.Close();
                MessageBox.Show("Error de base de datos! \n" + ex.ToString());
                return false;
            }
        }*/

    }

}

