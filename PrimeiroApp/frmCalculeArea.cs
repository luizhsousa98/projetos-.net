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
    public partial class frmCalculeArea : Form
    {
        public frmCalculeArea()
        {
            InitializeComponent();
        }

        const double pi = 3.14159265;
       
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double area, r;
            r = Convert.ToDouble(txtVRaio.Text);
            area = pi * r * r;
            lblRArea.Text = area.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblVolume.Text = "";
            txtVRaio.Text = "";
        }

        private void lblRArea_Click(object sender, EventArgs e)
        {

        }
    }
}
