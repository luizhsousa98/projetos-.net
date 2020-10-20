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
    public partial class frmRaio2 : Form
    {
        public frmRaio2()
        {
            InitializeComponent();
        }
        const double pi = 3.14159;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRaio2_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double volume;
            Double pi = 3.14;
            Double r;
            Double altura;
            r = Convert.ToDouble(txtVRaio.Text);
            volume = pi *r *r* altura;
            lblVVolume.Text = volume.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblVVolume.Text = "";
            txtVRaio.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblRaio_Click(object sender, EventArgs e)
        {

        }
    }
}
