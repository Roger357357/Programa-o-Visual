using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soma_Variaveis
{
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }

        private void btnInteiros_Click(object sender, EventArgs e)
        {
            int a, b, soma;

            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);

            soma = a + b;

            txtResultado.Text = soma.ToString();
        }

        private void btnReais_Click(object sender, EventArgs e)
        {
            double a, b, soma;

            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);

            soma = a + b;

            txtResultado.Text = soma.ToString();
        }
    }
}
