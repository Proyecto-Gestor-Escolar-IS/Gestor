using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorEscolar
{
    class clsUtilidades
    {

        //Se le envia una cadena a desencriptar [ENVIAR STRING]
        public string EncriptarTexto(string textoEncriptar)
        {
            byte[] llave; //Arreglo donde guardaremos la llave para el cifrado 3DES.
            byte[] arreglo = UTF8Encoding.UTF8.GetBytes(textoEncriptar); //Arreglo donde guardaremos la cadena descifrada.
            // Ciframos utilizando el Algoritmo MD5.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            llave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("[-}23rñWD3*/D<%4"));
            md5.Clear();
            //Ciframos utilizando el Algoritmo 3DES.
            TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
            tripledes.Key = llave;
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7;
            ICryptoTransform convertir = tripledes.CreateEncryptor(); // Iniciamos la conversión de la cadena
            byte[] resultado = convertir.TransformFinalBlock(arreglo, 0, arreglo.Length); //Arreglo de bytes donde guardaremos la cadena cifrada.
            tripledes.Clear();
            return Convert.ToBase64String(resultado, 0, resultado.Length); // Convertimos la cadena y la regresamos.
        }

        //Se le envia una cadena a desencriptar [ENVIAR STRING]
        public string DesEncriptar(string textoDesencriptar)
        {
            byte[] llave;
            byte[] arreglo = Convert.FromBase64String(textoDesencriptar); // Arreglo donde guardaremos la cadena descovertida.
                                                                          // Ciframos utilizando el Algoritmo MD5.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            llave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("[-}23rñWD3*/D<%4"));
            md5.Clear();
            //Ciframos utilizando el Algoritmo 3DES.
            TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
            tripledes.Key = llave;
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7;
            ICryptoTransform convertir = tripledes.CreateDecryptor();
            byte[] resultado = convertir.TransformFinalBlock(arreglo, 0, arreglo.Length);
            tripledes.Clear();
            string cadena_descifrada = UTF8Encoding.UTF8.GetString(resultado); // Obtenemos la cadena
            return cadena_descifrada; // Devolvemos la cadena
        }

        //Se le envia un STRING y verifica que el correo ingresado cumpla el formato especifico
        public bool verificarCorreo(string correo)
        {
            try
            {
                MailAddress mail = new MailAddress(correo);
                bool isCorreoValido = mail.Host.Contains(".");
                if (isCorreoValido)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }


        }

        //FUNCION QUE SE LE ENVIA UN STRING Y DETERMINA SI ES NUMERO
        public bool isNumeric(string texto)
        {

            if (Regex.IsMatch(texto, @"^\d+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool enviarCorreo(string mensaje, string asunto, string destinatario, string ruta)
        {
            System.Net.Mail.MailMessage _Message = new System.Net.Mail.MailMessage();
            System.Net.Mail.SmtpClient _SMTP = new System.Net.Mail.SmtpClient();

            _SMTP.UseDefaultCredentials = false;
            _SMTP.Credentials = new System.Net.NetworkCredential("sigua.netco@gmail.com", "Siguanet2020");
            _SMTP.Host = "smtp.gmail.com";
            _SMTP.Port = 587;
            _SMTP.EnableSsl = true;

            // 
            _Message.To.Add(destinatario.ToString());
            _Message.From = new System.Net.Mail.MailAddress("sigua.netco@gmail.com", "Santa Maria de Nazareth No Reply", System.Text.Encoding.UTF8);
            _Message.Subject = asunto.ToString();
            _Message.SubjectEncoding = System.Text.Encoding.UTF8;
            _Message.Body = mensaje;
            _Message.BodyEncoding = System.Text.Encoding.UTF8;
            _Message.Priority = System.Net.Mail.MailPriority.Normal;
            _Message.IsBodyHtml = true;

            try
            {
                _SMTP.Send(_Message);
                return true;
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK);
                return false;
            }
        }


    }
}
