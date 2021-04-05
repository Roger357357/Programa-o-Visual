using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstacoes
{
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
        }

        private void FrmCombo_Load(object sender, EventArgs e)
        {
            cboEstacoes.Items.Add("Verao 1");
            cboEstacoes.Items.Add("Inverno 1");
            cboEstacoes.Items.Add("Outono 1");
            cboEstacoes.Items.Add("Primavera 1");

        }

        private void cboEstacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEscolhida.Text = cboEstacoes.SelectedIndex + " - " + cboEstacoes.Text;

            switch (cboEstacoes.SelectedIndex)
            {
                case 0:
                case 1:
                    picEstacao.Load("images/inverno.jpeg");
                    break;
                case 2:
                case 3:
                    picEstacao.Load("images/outono.jpg");
                    break;
                case 4:
                case 5:
                    picEstacao.Load("images/primavera.jpg");
                    break;
                case 6:
                case 7:
                    picEstacao.Load("images/verao.jpg");
                    break;
            }
        }
    }
}
