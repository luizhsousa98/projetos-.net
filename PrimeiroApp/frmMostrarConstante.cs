using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroApp
{
    public partial class frmMostrarConstante : Form
    {
        public frmMostrarConstante()
        {
            InitializeComponent();
        }

        //Variável Constante e global
        const double pi = 3.141516;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            lblMostrarConstante.Text = pi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblMostrarConstante.Text = "";
        }
    }
}
