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
            mensaje.Headers.Add("testmetadataUNO", "metadata");
            mensaje.Headers.Add("testmetadataDOS", "metadata numero 2");
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

        public void recibir()
        {
            OpenPop.Pop3.Pop3Client client = new OpenPop.Pop3.Pop3Client();
            
            //client.Connect("mail.xeta.com.ar", 110, false);
            //client.Authenticate("test@xeta.com.ar", "test712as");

            client.Connect("pop.googlemail.com", 110, false);
            client.Authenticate("emgesitm@gmail.com", "sitmemge");

            int messageCount = client.GetMessageCount();


            
            Form formulario = new Form();

            if (client.Connected)
            {
                MessageBox.Show("conectado - " + messageCount);
                Helpers.Cargador carga = new Helpers.Cargador();
                List<Message> allMessages = new List<Message>(messageCount);
                for (int i = messageCount; i > 0; i--)
                {
                    var mensaje = client.GetMessage(i).Headers.UnknownHeaders[0].ToString(); //trae "testmetadataUNO"
                    var mensajBIS = client.GetMessage(i).Headers.UnknownHeaders[1].ToString(); //trae "testmetadataDOS"
                    MessageBox.Show
                        (
                        client.GetMessage(i).FindFirstPlainTextVersion().GetBodyAsText(),
                        client.GetMessage(i).Headers.Subject.ToString()
                        //client.GetMessage(i).Headers.From.ToString(),
                        );
                    //carga.carga(formulario, client);
                    //formulario.Controls["promotor"].Text = client.GetMessage(i).Headers.To.ToString();
                }
            }
            else {
                MessageBox.Show("no conectado");
            }
        }
    }
}
