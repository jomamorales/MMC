using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using OpenPop;
using Helpers;
 


namespace Helpers
{
    public class Mailer
    {
        public Mailer()
        {

        }
        
        public bool enviar(Form Formulario){
            //MessageBox.Show(Formulario.Controls["facilidad"].Text);
            MailMessage mensaje = new MailMessage(
                //Formulario.Controls["promotor"].Text,
                //Formulario.Controls["ejecutivo"].Text
                //"test@xeta.com.ar",
                "emgesitm@gmail.com",
                "emgesitm@gmail.com"
                );
            
            //Asignacion de lo que se envía
            //mensaje.Bcc = "aca va el mail de auditoria";
            mensaje.Body = Formulario.Controls["texto"].Text;
            mensaje.Subject = Formulario.Controls["canal"].Text;
                //"Prueba de Envio de MMC";
            
            //metadata en el header
            // problema: SOLO PASA LA KEY => el valor (2parametro no sirve de nada) y no se pueden poner espacios
            mensaje.Headers.Add("facilidad", Formulario.Controls["facilidad"].Text); //facilidad
            mensaje.Headers.Add("canal", Formulario.Controls["canal"].Text); //facilidad
            mensaje.Headers.Add("clasiseguridad", Formulario.Controls["clasiseguridad"].Text); //facilidad
            mensaje.Headers.Add("nrocontrol", Formulario.Controls["nrocontrol"].Text); //facilidad
            mensaje.Headers.Add("procedencia", Formulario.Controls["procedencia"].Text); //facilidad
            mensaje.Headers.Add("instransmision", Formulario.Controls["instransmision"].Text); //facilidad

            SmtpClient client = new SmtpClient();
            /*
            client.Credentials = new System.Net.NetworkCredential("test@xeta.com.ar", "test712as");
            client.Host = "mail.xeta.com.ar";
            client.Port = 26;
            */
            client.Credentials = new System.Net.NetworkCredential("emgesitm@gmail.com", "sitmemge");
            client.Host = "smtp.googlemail.com";
            client.Port = 587;
            //client.EnableSsl = true;

            //IP Servidor maquina virtual
            //client.Credentials = new System.Net.NetworkCredential("test@xeta.com.ar", "test712as");
            //client.Host = "10.90.18.120";

            try
            {
                client.Send(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            return true;
        }

        public OpenPop.Mime.Message[] recibir()
        {
            OpenPop.Pop3.Pop3Client client = new OpenPop.Pop3.Pop3Client();

            

            //client.Connect("mail.xeta.com.ar", 110, false);
            //client.Authenticate("test@xeta.com.ar", "test712as");

            client.Connect("pop.googlemail.com", 110, false);
            client.Authenticate("emgesitm@gmail.com", "sitmemge");

            int messageCount = client.GetMessageCount();
            OpenPop.Mime.Message[] allMessages = new OpenPop.Mime.Message[messageCount];
            MessageBox.Show("mensajes recibidos", messageCount.ToString());
            Form formulario = new Form();
            
            if (client.Connected && messageCount > 0)
            {
                int i = 0;
                for (int j = messageCount; j > 0; j--)
                {
                    OpenPop.Mime.Message TEST = client.GetMessage(j);
                    allMessages[i] = TEST;
                    i++;
                }   
            }
            else {
                MessageBox.Show("no conectado");
            }
            return allMessages;
        }
    }
}
