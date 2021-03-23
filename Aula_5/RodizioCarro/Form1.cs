using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RodizioCarro
{
    public partial class frmRodizio : Form
    {
        public frmRodizio()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            byte placa;

            placa = Convert.ToByte(txtPlaca.Text);

            switch (placa)
            {
                case 1:
                case 2:
                    lblSemana.Text = "Proibido Segunda - Feira";
                    break;
                case 3:
                case 4:
                    lblSemana.Text = "Proibido Terça - Feira";
                    break;
                case 5:
                case 6:
                    lblSemana.Text = "Proibido Quarta - Feira";
                    break;
                case 7:
                case 8:
                    lblSemana.Text = "Proibido Quinta - Feira";
                    break;
                case 9:
                case 0:
                    lblSemana.Text = "Proibido Sexta - Feira";
                    break;
                default:
                    break;
            }
        }

        private void btnLicenciar_Click(object sender, EventArgs e)
        {
            byte placa;

            placa = Convert.ToByte(txtPlaca.Text);

            switch (placa)
            {
                case 1:
                    lblSemana.Text = "Licenciar até Abril";
                    break;
                case 2:
                    lblSemana.Text = "Licenciar até Maio";
                    break;
                case 3:
                    lblSemana.Text = "Licenciar até Junho";
                    break;
                case 4:
                    lblSemana.Text = "Licenciar até Julho";
                    break;
                case 5:
                case 6:
                    lblSemana.Text = "Licenciar até Agosto";
                    break;
                case 7:
                    lblSemana.Text = "Licenciar até Setembro";
                    break;
                case 8:
                    lblSemana.Text = "Licenciar até Outubro";
                    break;
                case 9:
                    lblSemana.Text = "Licenciar até Novembro";
                    break;
                case 0:
                    lblSemana.Text = "Licenciar até Dezembro";
                    break;
                default:
                    break;
            }
        }
    }
}
