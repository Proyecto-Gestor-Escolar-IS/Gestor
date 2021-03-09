using System;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using MailKit.Security;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Util.Store;
using System.Threading;

namespace SistemaGestorEscolar
{
    internal class clsUtilidades
    {
        //Se le envia una cadena a desencriptar [ENVIAR STRING]
        public string EncriptarTexto(string textoEncriptar)
        {
            try
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
            catch
            {
                return null;
            }
        }

        //Se le envia una cadena a desencriptar [ENVIAR STRING]
        public string DesEncriptar(string textoDesencriptar)
        {
            try
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
            catch
            {
                return null;
            }
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

        public bool isDate(string fecha)
        {
            try
            {
                DateTime dt;
                DateTime.TryParseExact(fecha, "dd/MM/yyyy", CultureInfo.GetCultureInfo("es-HN"), DateTimeStyles.None, out dt);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /*public bool enviarCorreo(string mensaje, string asunto, string destinatario, string correo, string contra)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Santa Maria Password Recovery Service", correo));
                message.To.Add(new MailboxAddress(destinatario, destinatario));
                message.Subject = "Santa Maria de Nazareth Admin No Reply";

                message.Body = new TextPart("html")
                {
                    Text = mensaje
                };

            
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp-relay.sendinblue.com", 587, true);
                    client.Authenticate("santamaria_escp@keemail.me", "jHXzTAx4vZmhD9Bw");
                    MessageBox.Show("hola");
                    client.Send(message);
                    client.Disconnect(true);
                    return true;
                }
            }
            catch
            {
                return false;
            }


        }*/

        /*public async System.Threading.Tasks.Task<bool> enviarCorreoAsync(string mensaje, string asunto, string destinatario, string correo, string contra)
        {
            try
            {


                var clientSecrets = new ClientSecrets
                {
                    ClientId = "1015480394760-jemn35dudij769tg5aed8bpood04k8lt.apps.googleusercontent.com",
                    ClientSecret = "yAEwq57dfKkvg-FbdRZ6Vebo"
                };

                var codeFlow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer { 
                    DataStore = new FileDataStore("CredentialCacheFolder", false),
                    Scopes = new[] { "https://mail.google.com/" },
                    ClientSecrets = clientSecrets
                });

                var codeReceiver = new LocalServerCodeReceiver();
                var authCode = new AuthorizationCodeInstalledApp(codeFlow, codeReceiver);

                var credential = await authCode.AuthorizeAsync(correo, CancellationToken.None);

                if (credential.Token.IsExpired(SystemClock.Default))
                    await credential.RefreshTokenAsync(CancellationToken.None);

                var oauth2 = new SaslMechanismOAuth2(credential.UserId, credential.Token.AccessToken);

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Santa Maria Password Recovery Service", correo));
                message.To.Add(new MailboxAddress(destinatario, destinatario));
                message.Subject = "Santa Maria de Nazareth Admin No Reply";

                message.Body = new TextPart("html")
                {
                    Text = mensaje
                };

            
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                    await client.AuthenticateAsync(oauth2);
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                    return true;
                }
            }
            catch
            {
                return false;
            }
            

        }*/
        
        public bool enviarCorreo(string mensaje, string asunto, string destinatario, string ruta, string correo, string contra)
        {
            System.Net.Mail.MailMessage _Message = new System.Net.Mail.MailMessage();
            System.Net.Mail.SmtpClient _SMTP = new System.Net.Mail.SmtpClient();

            _SMTP.UseDefaultCredentials = false;
            _SMTP.Credentials = new System.Net.NetworkCredential("santamaria_escp@keemail.me", "jHXzTAx4vZmhD9Bw");
            //_SMTP.Credentials = new System.Net.NetworkCredential("sigua.netco@gmail.com", "Siguanet2020");
            _SMTP.Host = "smtp-relay.sendinblue.com";
            _SMTP.Port = 587;
            _SMTP.EnableSsl = true;

            //
            _Message.To.Add(destinatario.ToString());
            _Message.From = new System.Net.Mail.MailAddress(correo, "Santa Maria de Nazareth Admin No Reply", System.Text.Encoding.UTF8);
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
            catch
            {
                return false;
            }
        }

        public byte[] imagenAByte(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }

        /*public Image ByteAImagen(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }*/

        public void limpiarTextBox(Control cont)
        {
            foreach (Control control in cont.Controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;
                if (control is MaskedTextBox)
                    control.Text = string.Empty;
            }
        }
    }
}