using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2
{
    public partial class frmFormulario : Form
    {
        public frmFormulario()
        {
            InitializeComponent();
        }

        private void BtnMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá " + txtNome.Text + " que mora em " + txtCidade.Text, "Mensagem");
        }

        private void frmFormulario_Load(object sender, EventArgs e)
        {
            txtNome.Text = "Roger Felipe";

        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            txtCopiaNome.Text = txtNome.Text;
            txtCopiaEndereco.Text = txtEndereco.Text;
            txtCopiaCidade.Text = txtCidade.Text;
            txtCopiaIdade.Text = txtIdade.Text;

            txtCopiaNome.ReadOnly = true;
            txtCopiaEndereco.ReadOnly = true;
            txtCopiaCidade.ReadOnly = true;
            txtCopiaIdade.ReadOnly = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCopiaNome.Clear();
            txtCopiaEndereco.Clear();
            txtCopiaCidade.Clear();
            txtCopiaIdade.Clear();

            txtCopiaNome.ReadOnly = false;
            txtCopiaEndereco.ReadOnly = false;
            txtCopiaCidade.ReadOnly = false;
            txtCopiaIdade.ReadOnly = false;
        }
    }
}
