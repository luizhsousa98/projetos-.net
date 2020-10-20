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
    public partial class frmCadForm : Form
    {
        public frmCadForm()
        {
            InitializeComponent();
            CarregarCombo();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CarregarCombo()
        {
            cbbEstado.Items.Add("SP");
            cbbEstado.Items.Add("BA");
            cbbEstado.Items.Add("MG");
            cbbEstado.Items.Add("RJ");
            cbbEstado.Items.Add("PR");
            cbbEstado.Items.Add("SC");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmPesquisa abrir = new frmPesquisa();
            abrir.ShowDialog();
        }
    }
}
