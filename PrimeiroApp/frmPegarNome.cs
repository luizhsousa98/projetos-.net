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
    public partial class frmPegarNome : Form
    {
        public frmPegarNome()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nome;
            nome = txtDigiteseuNome.Text;
            lblMostrarNome.Text = nome;

        }

        private void frmPegarNome_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDigiteseuNome.Clear();
            lblMostrarNome.Text = "";
        }
    }
}
