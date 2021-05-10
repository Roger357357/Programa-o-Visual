using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAbacaxi
{
    public partial class frmAbacaxi : Form
    {
        public frmAbacaxi()
        {
            InitializeComponent();
        }

        private void frmAbacaxi_Load(object sender, EventArgs e)
        {
            cmbFrutas.Items.Add("Abacaxi");
            cmbFrutas.Items.Add("Limão");
            cmbFrutas.Items.Add("Amora");

            cmbPrecos.Items.Add("3,56");
            cmbPrecos.Items.Add("4,56");
            cmbPrecos.Items.Add("7,99");
        }

        private void cmbFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPrecos.SelectedIndex = cmbFrutas.SelectedIndex;
            lstSelecionados.Items.Add(txtQuantidade.Text + "-" + cmbFrutas.Text + "-" + cmbPrecos.Text);

            double total = Convert.ToInt16(txtQuantidade.Text) * Convert.ToDouble(cmbPrecos.Text);

            total += Convert.ToDouble(lblMensagem.Text);
            lblMensagem.Text = total.ToString();
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtQuantidade.Text, out id) == false)
            {
                MessageBox.Show("Digite um número", "Campo Quantidade");
                txtQuantidade.Focus();
                return;
            }

            if (Convert.ToInt16(txtQuantidade.Text) < 0)
            {
                MessageBox.Show("Quantidade deve ser maior que 0", "Campo Quantidade");
                txtQuantidade.Focus();
                return;
            }
        }

        private void lstSelecionados_MouseClick(object sender, MouseEventArgs e)
        {
            int tamanhoString, pos1, pos2;
            double quant,valor;
            String itemSelecionado = lstSelecionados.Text;

            lstSelecionados.Items.RemoveAt(lstSelecionados.SelectedIndex);
            
            lstSelecionados.Refresh();

            tamanhoString = itemSelecionado.Length;

            pos1 = itemSelecionado.IndexOf("-");
            pos2 = itemSelecionado.LastIndexOf("-");

            quant = double.Parse(itemSelecionado.Substring(0, pos1));
            valor = double.Parse(itemSelecionado.Substring(pos2++, tamanhoString - (pos2 - 1)));

            lblMensagem.Text = (double.Parse(lblMensagem.Text) - (quant * valor)).ToString();


        }
    }
}
