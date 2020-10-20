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
    public partial class frmPesquisa : Form
    {
        public frmPesquisa()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescriçao.Clear();
            ltbPesquisar.Items.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescriçao.ReadOnly = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if ((rdbCodigo.Checked == false) && (rdbNome.Checked == false))
            {
                MessageBox.Show("Favor Selecionar um tipo de pesquisa");
            }
            else
            {
                if (txtDescriçao.Text == (""))
                {
                    MessageBox.Show("Insira uma pesquisa na descrisão");
                    txtDescriçao.Focus();
                }



                else
                {
                    ltbPesquisar.Items.Add(txtDescriçao.Text);
                }

            }
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtDescriçao.ReadOnly = false;
            txtDescriçao.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtDescriçao.ReadOnly = false;
            txtDescriçao.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
