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
            lstSelecionados.Items.Add(cmbFrutas.Text + " - " + cmbPrecos.Text + " - " + txtQuantidade.Text);

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
    }
}
