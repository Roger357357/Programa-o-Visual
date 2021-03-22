using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_5
{
    public partial class frmSwitch : Form
    {
        public frmSwitch()
        {
            InitializeComponent();
        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {
            //Faz a mesma função que o switch do evento btnSwitch_Click

            /*if (!String.IsNullOrEmpty(txtDia.Text))
            {
                byte dia;

                dia = Convert.ToByte(txtDia.Text);

                if (dia == 1)
                {
                    lblDiaSemana.Text = "Domingo";
                    picSemana.Load("D:/Users/roger/OneDrive/Imagens/Protetor de Tela/Bart_Simpsons.jpg");
                }
                else if (dia == 2)
                {
                    lblDiaSemana.Text = "Segunda - feira";
                    picSemana.Load("D:/Users/roger/OneDrive/Imagens/Protetor de Tela/Coringa.jpg");
                }
                else if (dia == 3)
                {
                    lblDiaSemana.Text = "Terça - feira";
                    picSemana.Load("D:/Users/roger/OneDrive/Imagens/Protetor de Tela/Fases_Lua.jpg");
                }
                else if (dia == 4)
                {
                    lblDiaSemana.Text = "Quarta - feira";
                    picSemana.Load("D:/Users/roger/OneDrive/Imagens/Protetor de Tela/Friends.jpg");
                }
                else if (dia == 5)
                {
                    lblDiaSemana.Text = "Quinta - feira";
                    picSemana.Load("D:/Users/roger/OneDrive/Imagens/Protetor de Tela/Homer_ Simpsons1.jpg");
                }
                else if (dia == 6)
                {
                    lblDiaSemana.Text = "Sexta - feira";
                    picSemana.Load("D:/Users/roger/OneDrive/Imagens/Protetor de Tela/HomerSimpsons.jpg");
                }
                else if (dia == 7)
                {
                    lblDiaSemana.Text = "Sábado";
                    picSemana.Load("D:/Users/roger/OneDrive/Imagens/Imagens da Câmera/20170219_110803.jpg");
                }
                else
                {
                    lblDiaSemana.Text = "Número Inválido";
                    picSemana.Image = null;
                }
            }
            else
            {
                lblDiaSemana.Text = "-";
                picSemana.Image = null;
            }*/
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            byte dia;

            if (!String.IsNullOrEmpty(txtDia.Text))
            {

                dia = Convert.ToByte(txtDia.Text);

                switch (dia)
                {
                    case 1:
                {
                    lblDiaSemana.Text = "Domingo";
                    picSemana.Load("D:/Users/roger/OneDrive/Imagens/Protetor de Tela/Bart_Simpsons.jpg");
                            break;
                }
                    case 2:
                {
                    lblDiaSemana.Text = "Segunda - feira";
                    picSemana.Load("D:/Users/roger/OneDrive/Imagens/Protetor de Tela/Coringa.jpg");
                            break;
                }
                    case 3:
                {
                    lblDiaSemana.Text = "Terça - feira";
                    picSemana.Load("D:/Users/roger/OneDrive/Imagens/Protetor de Tela/Fases_Lua.jpg");
                            break;
                }
                    case 4:
                {
                    lblDiaSemana.Text = "Quarta - feira";
                    picSemana.Load("D:/Users/roger/OneDrive/Imagens/Protetor de Tela/Friends.jpg");
                            break;
                }
                    case 5:
                {
                    lblDiaSemana.Text = "Quinta - feira";
                    picSemana.Load("D:/Users/roger/OneDrive/Imagens/Protetor de Tela/Homer_ Simpsons1.jpg");
                            break;
                }
                    case 6:
                {
                    lblDiaSemana.Text = "Sexta - feira";
                    picSemana.Load("D:/Users/roger/OneDrive/Imagens/Protetor de Tela/HomerSimpsons.jpg");
                            break;
                }
                    case 7:
                {
                    lblDiaSemana.Text = "Sábado";
                    picSemana.Load("D:/Users/roger/OneDrive/Imagens/Imagens da Câmera/20170219_110803.jpg");
                            break;
                }
                    default:
                {
                    lblDiaSemana.Text = "Número Inválido";
                    picSemana.Image = null;
                            break;
                }
            }
            }
        }
    }
}
