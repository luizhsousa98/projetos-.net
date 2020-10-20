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
    public partial class CoddeAlmento : Form
    {
        public CoddeAlmento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double v1, resp = 0;

            /* string porcentagem = Console.ReadLine();

            switch (porcentagem)
            {
                case "Codigo 1":
                    Console.WriteLine("Aumento de 10%");
                    break;
                case "Codigo 3":
                    Console.WriteLine("Aumento de 25%");
                    break;
                case "Codigo 4":
                    Console.WriteLine("Aumento de 30%");
                    break;
                case "Codigo 8":
                    Console.WriteLine("Aumento de 50%");
                    break;
                default:
                    Console.WriteLine("Informe uns dos Codigos");
                    break;
        }*/
            v1 = Convert.ToDouble(txtSalario.Text);

              if (rdb1.Checked)
                            {
                resp = v1+(v1 * 10) / 100;

            }
            lblRes.Text = resp.ToString();
        }

        private void lblRes_Click(object sender, EventArgs e)
        {

        }
    }
}
