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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            string message = "DESEJA SAIR  ?";
            string titulo = "Informação";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;

            result = MessageBox.Show(message, titulo, buttons,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                this.Close();
                frmLogin abrir = new frmLogin();
                abrir.Show();
                
            }
        }

        private void btnDadosPessoais_Click(object sender, EventArgs e)
        {
            frmSegApp abrir = new frmSegApp();
            abrir.ShowDialog();
            
        }

        private void btnImprimeNome_Click(object sender, EventArgs e)
        {
            frmPegarNome abrir = new frmPegarNome();
            abrir.ShowDialog();

        }

        private void btnTesteVaravel_Click(object sender, EventArgs e)
        {
            frmTestVariavel abrir = new frmTestVariavel();
            abrir.ShowDialog();

        }

        private void btnCalculaArea_Click(object sender, EventArgs e)
        {
            frmCalculeArea abrir = new frmCalculeArea();
            abrir.ShowDialog();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            frmCalculadora abrir = new frmCalculadora();
            abrir.ShowDialog();
        }

        private void btnMostrarConstante_Click(object sender, EventArgs e)
        {
            frmMostrarConstante abrir = new frmMostrarConstante();
            abrir.ShowDialog();
        }

        private void btnMostrarInicializaçao_Click(object sender, EventArgs e)
        {
            frmMostrarInicializaçao abrir = new frmMostrarInicializaçao();
            abrir.ShowDialog();
            
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadForm abrir = new frmCadForm();
            abrir.ShowDialog();
        }
    }
}
