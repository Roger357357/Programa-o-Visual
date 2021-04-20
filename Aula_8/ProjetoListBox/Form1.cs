using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoListBox
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 5; i++)
            {
                lstNumeros.Items.Add(i);
            }
            for (int i = 10; i > 0; i-- )
            {
                lstNumeros.Items.Add("* " + i);
            }

            char j;
            for(j='a'; j < 'z'; j++)
            {
                lstNumeros.Items.Add("* " + j);
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i=0;
            while(i < 5)
            {
                lstNumeros.Items.Add("* " + i);
                i++;
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int i = 0;

            do
            {
                lstNumeros.Items.Add("* " + i);
                i++;
            } while (i < 5);
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            String placa;
            placa = txtPlaca.Text;
            txtTamanho.Text = placa.Length.ToString();

            txtPosicao.Text = placa.Substring(0, placa.Length);
            txtAsteristico.Text = placa.IndexOf("*").ToString();
        }
    }
}
