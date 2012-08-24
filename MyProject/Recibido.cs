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
            mailer.recibir();
            //this.dataGridView1.Rows.Add("3","4");
        }
    }
}
