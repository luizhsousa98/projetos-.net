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
    public partial class frmTestVariavel : Form
    {
        public frmTestVariavel()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string SobreNome;
            SobreNome = "Guilherme";
            lblMostrar.Text = SobreNome;

            SobreNome = "Ribeiro ";
            lblNCompleto.Text = SobreNome;
        }
    }
}
