using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIMC
{
    public partial class FrmCalculoIMC : Form
    {
        public FrmCalculoIMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc, minimo, maximo;

            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            
            imc = peso / (altura * altura);

            imc = Math.Round(imc, 2);

            lblResultado.Text = imc.ToString();

            if(imc < 17){
                lblSituacao.Text = "Muito abaixo do Peso";
                lblSituacao.ForeColor = Color.DarkBlue;
            }
            else if(imc >= 17 && imc <= 18.49){
                lblSituacao.Text = "Abaixo do Peso";
                lblSituacao.ForeColor = Color.Turquoise;
            }else if(imc >= 18.50 && imc <= 24.99){
                lblSituacao.Text = "Peso Normal";
                lblSituacao.ForeColor = Color.Lime;
            }
            else if(imc >= 25 && imc <= 29.99){
                lblSituacao.Text = "Acima do Peso";
                lblSituacao.ForeColor = Color.Orange;
            }
            else if(imc >= 30 && imc <= 34.99){
                lblSituacao.Text = "Obesidade I";
                lblSituacao.ForeColor = Color.DarkOrange;
            }
            else if (imc >= 35 && imc <= 39.99){
                lblSituacao.Text = "Obesidade II (Severa)";
                lblSituacao.ForeColor = Color.Red;
            }
            else{
                lblSituacao.Text = "Obesidade III (Mórbida)";
                lblSituacao.ForeColor = Color.DarkMagenta;
            }

            lblResultado.ForeColor = lblSituacao.ForeColor;

            minimo = 18.5 * (altura * altura);
            maximo = 24.99 * (altura * altura);

            minimo = Math.Round(minimo, 2);
            maximo = Math.Round(maximo, 2);

            lblPesoMinimo.Text = minimo.ToString();
            lblPesoMaximo.Text = maximo.ToString();
        }
    }
}
