using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDiaSemana
{
    public partial class FrmDiaSemana : Form
    {
        public FrmDiaSemana()
        {
            InitializeComponent();
        }

        private void FrmDiaSemana_Load(object sender, EventArgs e)
        {
            cbmDiaSemana.Items.Add("Segunda - Feira");
            cbmDiaSemana.Items.Add("Terça - Feira");
            cbmDiaSemana.Items.Add("Quarta - Feira");
            cbmDiaSemana.Items.Add("Quinta - Feira");
            cbmDiaSemana.Items.Add("Sexta - Feira");
            cbmDiaSemana.Items.Add("Sábado");
            cbmDiaSemana.Items.Add("Domingo");
        }

        private void cbmDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDiaSemana.Text = cbmDiaSemana.SelectedIndex + " - " + cbmDiaSemana.Text;

            switch (cbmDiaSemana.SelectedIndex)
            {
                case 0:
                    picDiaSemana.Load("images/segunda-feira.jpg");
                    break;
                case 1:
                    picDiaSemana.Load("images/terça-feira.jpg");
                    break;
                case 2:
                    picDiaSemana.Load("images/quarta-feira.jpg");
                    break;
                case 3:
                    picDiaSemana.Load("images/quinta-feira.jpg");
                    break;
                case 4:
                    picDiaSemana.Load("images/sexta-feira.jpeg");
                    break;
                case 5:
                    picDiaSemana.Load("images/sabado.png");
                    break;
                case 6:
                    picDiaSemana.Load("images/domingo.jpeg");
                    break;
            }
        }
    }
}
