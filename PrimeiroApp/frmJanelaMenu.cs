﻿using System;
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
    public partial class frmJanelaMenu : Form
    {
        public frmJanelaMenu()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmArquivo abrir = new frmArquivo();
            abrir.ShowDialog();
        }
    }
}
