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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }





        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
                
            double v1, v2, resp = 0;

            
            

                if (txtV1.Text.Equals(""))
                {
                    MessageBox.Show("Inserir variavel l");
                    txtV1.Focus();
                }
                else
                {

                    if (txtV2.Text.Equals(""))
                    {
                        MessageBox.Show("Inserir Variavel 2");
                        txtV2.Focus();


                    }


                    else if ((rdbAdiçao.Checked == false) && (rdbSubtraçao.Checked == false) && (rdbMultiplicaçao.Checked == false) && (rdbDivisao.Checked == false))
                    {
                        MessageBox.Show("Escolha um Operação");
                    }


                    else
                    {
                    try
                    { 
                        v1 = Convert.ToDouble(txtV1.Text);
                        v2 = Convert.ToDouble(txtV2.Text);

                        if (rdbAdiçao.Checked)
                        {
                            resp = Operador.soma(v1, v2);
                        }
                        if (rdbSubtraçao.Checked)
                        {
                            resp = Operador.subtrai(v1, v2);
                        }
                        if (rdbMultiplicaçao.Checked)
                        {
                            resp = Operador.multiplica(v1, v2);
                        }
                        if (rdbDivisao.Checked)
                        {
                            if (v2 == 0)
                            {
                                MessageBox.Show("Imposível Dividir por 0");
                            }
                            else
                            {
                                resp = Operador.divisao(v1, v2);
                            }


                        }
                        lblRes.Text = Convert.ToString(Resposta.resposta(resp));
                        limpar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Inserir valores válidos");
                        txtV1.Focus();
                    }
                }

            }
           
        }
            

        
        public void limpar()
        {
            txtV1.Clear();
            txtV2.Clear();
            rdbAdiçao.Checked = false;
            rdbSubtraçao.Checked = false;
            rdbMultiplicaçao.Checked = false;
            rdbDivisao.Checked = false;
            txtV1.Focus();

        }

        private void rdbMultiplicaçao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            lblRes.Text = "";
            limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por ultilizar nosso sistema ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
      
    }
