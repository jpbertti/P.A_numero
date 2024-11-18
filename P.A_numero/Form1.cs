using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.A_numero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRazao.Clear();
            txtRazao.Focus();
            lsbResultado.Items.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lsbResultado.Items.Clear();

            int razao = int.Parse(txtRazao.Text), 
            valor_pa = int.Parse(txtRazao.Text);

            int i = 0;
            while (i < 10)
            {               
                lsbResultado.Items.Add(valor_pa);
                valor_pa += razao;
                i++;
            }
        }
    }
}

/*
 *         private void btnCalcular_Click(object sender, EventArgs e)
        {
            lsbResultado.Items.Clear();

            int razao = int.Parse(txtRazao.Text), valor_pa = 0;

            int i = 0;
            while (i < 10)
            {     
                valor_pa += razao;
                lsbResultado.Items.Add(valor_pa);
                i++;
            }
 */