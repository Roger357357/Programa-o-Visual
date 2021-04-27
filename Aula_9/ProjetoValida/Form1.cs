using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoValida
{
    public partial class frmValida : Form
    {
        public frmValida()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            int saidaIdade;
            double saidaSalario;
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Informar Nome Válido", "Campo Nome");
                txtNome.Focus();
                return;
            }

            if(int.TryParse(txtIdade.Text, out saidaIdade) == false)
            {
                MessageBox.Show("Digitar número inteiro", "Campo Idade");
                txtIdade.Focus();
                return;
            }

            if (double.TryParse(txtSalario.Text, out saidaSalario) == false)
            {
                MessageBox.Show("Digitar número double", "Campo Salário");
                txtSalario.Focus();
                return;
            }

            MessageBox.Show("Gravdo com sucesso ......", "Salvando");
        }
    }
}
