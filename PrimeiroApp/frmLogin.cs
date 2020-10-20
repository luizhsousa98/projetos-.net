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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            string message = "DESEJA SAIR DO SISTEMA ?";
            string titulo = "Sistema de Cadastro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;

            result = MessageBox.Show(message, titulo, buttons,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "senac")
            {
                MessageBox.Show("Usuário Invalido");
                txtUsuario.Focus();
            }
            else
            {
                if (txtSenha.Text != "senac")
                {
                    MessageBox.Show("Senha Invalida");
                    txtSenha.Focus();



                }


                else
                {
                    MessageBox.Show("Bem Vindo ao Sistema ABC!");
                    frmPrincipal abrir = new frmPrincipal();
                    abrir.ShowDialog();
                    this.Hide();

                    
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
if(e.KeyCode == Keys.Enter)
            {
                if (txtUsuario.Text != "senac")
                {
                    MessageBox.Show("Usuário Invalido");
                    txtUsuario.Focus();
                }
                else
                {
                    txtSenha.Focus();
                }
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSenha.Text != "senac")
                {
                    MessageBox.Show("Senha Invalida");
                    txtSenha.Focus();



                }
                else
                {
                    btnEntrar.Focus();
                }
            }
        }
    }
}
