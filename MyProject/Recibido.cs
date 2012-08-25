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
    public partial class Recibido : Form
    {
        public Recibido()
        {
            InitializeComponent();
        }

        private void recibir_Load(object sender, EventArgs e)
        {
            Helpers.Mailer mailer = new Helpers.Mailer();
            OpenPop.Mime.Message[] mensajes = mailer.recibir();
            int i = 0;
            while (i < mensajes.Length)
            {  
               int col =0;
               OpenPop.Mime.Message mensaje = mensajes[i];
               this.dataGridView1.Rows.AddCopy(i);
               DataGridViewRow fila = this.dataGridView1.Rows[i];
                string algo =mensaje.Headers.UnknownHeaders[(col++)].ToString();
                fila.Cells[col++].Value = algo;
                i++;
               
            }
            //this.dataGridView1.Rows.Add("3","4");
        }
    }
}
