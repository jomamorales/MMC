using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Helpers;

namespace MyProject
{
    public partial class GenerarMensaje : Form
    {
        int cont = 0;

        public GenerarMensaje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Por cada elemento enviado se debe incrementar el contador, se debe
             * guardar en algun lado para que cuente todos los mensajes enviados 
             * desde el TD*/
            this.cont = this.cont+1;
            nrocontrol.Text = (this.cont).ToString();
            Helpers.Mailer mailer = new Helpers.Mailer();
            if (mailer.enviar((Form)this))
            {
                MessageBox.Show("Mensaje enviado");

                /* El formulario enviado se deberá guaradar en el 
                 * dataGridView1_CellContent de la clase "administrarmensaje"
                 */
                administrarmensaje newmessage = new administrarmensaje();
                Helpers.Agregadora agrega = new Helpers.Agregadora();
                

            }
            else {
                MessageBox.Show("Error de mensaje");
            };
            /*Completar el Atributo	"Entrada a la Central de Tráfico – GFH"
             * textBox4.Text = DateTime.Now.ToString("dhhmmMMMyy").ToUpper();
             * this.Select();
             * base.OnClick(e);*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Muestra el contador de mensajes enviados
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            /*Esta caja debe contar la cantidad de palabras del mensaje 
             * en "richTextBox1_TextChanged"*/
            grupo.Text = Convert.ToString(texto.Text.Split());
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Aca se escribe el mensaje
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            //toma la hora del sistema con formato "dhhmmMMMMyy"
            clickgfh.Text = DateTime.Now.ToString("dhhmmMMMyy").ToUpper();
            this.Select();
            base.OnClick(e);
        }

        private void GenerarMensaje_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            /*Este campo será completado al ingresar el 
             * Mensaje Militar al Terminal de Datos*/
        }

        private void richTextBox1_KeyUp_1(object sender, KeyEventArgs e)
        {
            /* Suma la cantidad de palabras (boton "Grupo")*/
            string excp = @"\b(\w+?)\b";
            grupo.Text = System.Text.RegularExpressions.Regex.Matches(texto.Text.Trim(),excp).Count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /* Abrir un archivo*/
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "PDF|*.pdf|Documento de Word 97-2003|*.doc|Documento de Word|*.wordx";
            openFileDialog1.Title = "Abrir";
            openFileDialog1.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /* Guardar un archivo*/
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF|*.pdf|Documento de Word 97-2003|*.doc|Documento de Word|*.wordx";
            saveFileDialog1.Title = "Guardar";
            saveFileDialog1.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            /*Agregar un archivo adjunto al mensaje */
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Todos *.*|*.*|Documento de Texto *.txt|*.txt|Documento de Word 97-2003 *.doc|*.doc|Documento PDF *.pdf|*.pdf";
            openFileDialog1.Title = "Adjuntar";
            openFileDialog1.ShowDialog();
        }

        public string getPromotor() 
        {
            return this.promotor.SelectedValue.ToString();
        }
    }
}
