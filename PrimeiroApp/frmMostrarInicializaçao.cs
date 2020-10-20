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
    public partial class frmMostrarInicializaçao : Form
    {
        public frmMostrarInicializaçao()
        {
            InitializeComponent();
        }

        private void btnMInic_Click(object sender, EventArgs e)
        {
            //declarando uma variável
            int a, b;
            double c, d;
            string x, f;
            //inicializando variáveis
            a = 0;
            b = 0;
            c = 0.0; d = 0.0;
            x = "Minha";
            f = "Variável";

            ltbMInic.Items.Clear();

            ltbMInic.Items.Add(a);
            ltbMInic.Items.Add(b);
            ltbMInic.Items.Add(c);
            ltbMInic.Items.Add(d);
            ltbMInic.Items.Add(x);
            ltbMInic.Items.Add(f);
           

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ltbMInic.Items.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
