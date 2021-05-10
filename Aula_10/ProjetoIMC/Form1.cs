using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIMC
{
    public partial class frmCalculaImc : Form
    {
        double[] vetorPeso = new double[10];
        double[] vetorAltura = new double[10];
        double[] vetorImc = new double[10];

        int indice = 0;
        int tamanhoMaximo = 10;

        public frmCalculaImc()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            vetorAltura[indice] = double.Parse(txtAltura.Text);
            vetorPeso[indice] = double.Parse(txtPeso.Text);
            vetorImc[indice] = vetorPeso[indice] / (vetorAltura[indice] * vetorAltura[indice]);

            vetorAltura[indice] = Math.Round(vetorAltura[indice], 2);
            vetorPeso[indice] = Math.Round(vetorPeso[indice], 2);
            vetorImc[indice] = Math.Round(vetorImc[indice], 2);

            txtImc.Text = vetorImc[indice].ToString();

            if (vetorImc[indice] < 17)
            {
                lblSituacao.Text = "Muito abaixo do Peso";
                lblSituacao.ForeColor = Color.DarkBlue;
            }
            else if (vetorImc[indice] >= 17 && vetorImc[indice] <= 18.49)
            {
                lblSituacao.Text = "Abaixo do Peso";
                lblSituacao.ForeColor = Color.Turquoise;
            }
            else if (vetorImc[indice] >= 18.50 && vetorImc[indice] <= 24.99)
            {
                lblSituacao.Text = "Peso Normal";
                lblSituacao.ForeColor = Color.Lime;
            }
            else if (vetorImc[indice] >= 25 && vetorImc[indice] <= 29.99)
            {
                lblSituacao.Text = "Acima do Peso";
                lblSituacao.ForeColor = Color.Orange;
            }
            else if (vetorImc[indice] >= 30 && vetorImc[indice] <= 34.99)
            {
                lblSituacao.Text = "Obesidade I";
                lblSituacao.ForeColor = Color.DarkOrange;
            }
            else if (vetorImc[indice] >= 35 && vetorImc[indice] <= 39.99)
            {
                lblSituacao.Text = "Obesidade II (Severa)";
                lblSituacao.ForeColor = Color.Red;
            }
            else
            {
                lblSituacao.Text = "Obesidade III (Mórbida)";
                lblSituacao.ForeColor = Color.DarkMagenta;
            }

            indice++;
        }

        private void btnVetor_Click(object sender, EventArgs e)
        {
            lstVetores.Items.Clear();
            for(int i = 0; i < indice; i++)
            {
                lstVetores.Items.Add("Altura: " + vetorAltura[i].ToString() + " Peso: " + vetorPeso[i].ToString() + " IMC: " + vetorImc[i].ToString());
            }
        }
    }
}
