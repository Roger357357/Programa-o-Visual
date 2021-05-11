using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFuncao
{
    public partial class frmFuncao : Form
    {
        //int valorA, valorB;

        public frmFuncao()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparControles();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            int valorA = Convert.ToInt16(txtvalorA.Text);
            int valorB = Convert.ToInt16(txtvalorB.Text);

            txtMaior.Text = verificaMaior(valorA, valorB).ToString();
        }


        void limparControles()
        {
            txtMaior.Clear();
            txtvalorA.Clear();
            txtvalorB.Clear();

            txtvalorA.Focus();
        }

        int verificaMaior(int valorA, int valorB)
        {
            if(valorA > valorB)
            {
                return valorA;
            }
            else
            {
                return valorB;
            }
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            double reajuste = 0, novoSalario = 0;

            double salario = double.Parse(txtSalario.Text);
            calculaSalario(salario, ref reajuste, ref novoSalario);

            txtReajuste.Text = reajuste.ToString();
            txtNovoSalario.Text = novoSalario.ToString();
        }

        void calculaSalario(double salario, ref double reajuste, ref double novoSalario)
        {
            reajuste = salario * 10;
            novoSalario = salario + reajuste;
            
        }

        private void btnCalcularIMC_Click(object sender, EventArgs e)
        {
            double altura = 0, peso = 0, imc;
            altura = double.Parse(txtAltura.Text);
            peso = double.Parse(txtPeso.Text);

            imc = calculaIMC(peso, altura);
            txtIMC.Text = imc.ToString();

            mostraSituacao(imc);
        }

        double calculaIMC(double peso, double altura)
        {
            double imc = peso / (altura * altura);

            imc = Math.Round(imc, 2);

            return imc;
        }

        void mostraSituacao(double imc)
        {
            if (imc < 17)
            {
                txtSituacao.Text = "Muito abaixo do Peso";
            }
            else if (imc <= 18.49)
            {
                txtSituacao.Text = "Abaixo do Peso";
            }
            else if (imc <= 24.99)
            {
                txtSituacao.Text = "Peso Normal";
            }
            else if (imc <= 29.99)
            {
                txtSituacao.Text = "Acima do Peso";
            }
            else if (imc <= 34.99)
            {
                txtSituacao.Text = "Obesidade I";
            }
            else if (imc <= 39.99)
            {
                txtSituacao.Text = "Obesidade II (Severa)";
            }
            else
            {
                txtSituacao.Text = "Obesidade III (Mórbida)";
            }
        }
    }
}
