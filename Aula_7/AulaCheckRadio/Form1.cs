using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaCheckRadio
{
    public partial class FrmCheckRadio : Form
    {
        public FrmCheckRadio()
        {
            InitializeComponent();
        }

        private void chkInteligente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInteligente.Checked)
            {
                lblQualidades.Text = chkInteligente.Text;
            }
            else
            {
                lblQualidades.Text = "Nenhuma item selecionado";
            }
            
        }

        private void chkAmavel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAmavel.Checked)
            {
                lblQualidades.Text = chkAmavel.Text;
            }
            else
            {
                lblQualidades.Text = "Nenhuma item selecionado";
            }
        }

        private void chkSabio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSabio.Checked)
            {
                lblQualidades.Text = chkSabio.Text;
            }
            else
            {
                lblQualidades.Text = "Nenhuma item selecionado";
            }
        }

        private void chkPaciente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPaciente.Checked)
            {
                lblQualidades.Text = chkPaciente.Text;
            }
            else
            {
                lblQualidades.Text = "Nenhuma item selecionado";
            }
        }

        private void chkTolerante_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTolerante.Checked)
            {
                lblQualidades.Text = chkTolerante.Text;
            }
            else
            {
                lblQualidades.Text = "Nenhuma item selecionado";
            }
        }

        private void chkModesto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModesto.Checked)
            {
                lblQualidades.Text = chkModesto.Text;
            }
            else
            {
                lblQualidades.Text = "Nenhuma item selecionado";
            }
        }

        private void chkTranquilo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTranquilo.Checked)
            {
                lblQualidades.Text = chkTranquilo.Text;
            }
            else
            {
                lblQualidades.Text = "Nenhuma item selecionado";
            }
        }

        private void chkCalmo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCalmo.Checked)
            {
                lblQualidades.Text = chkCalmo.Text;
            }
            else
            {
                lblQualidades.Text = "Nenhuma item selecionado";
            }
        }

        private void chkComunicativo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkComunicativo.Checked)
            {
                lblQualidades.Text = chkComunicativo.Text;
            }
            else
            {
                lblQualidades.Text = "Nenhuma item selecionado";
            }
        }

        private void chkExuberante_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExuberante.Checked)
            {
                lblQualidades.Text = chkExuberante.Text;
            }
            else
            {
                lblQualidades.Text = "Nenhuma item selecionado";
            }
        }

        private void chkBonito_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBonito.Checked)
            {
                lblQualidades.Text = chkBonito.Text;
            }
            else
            {
                lblQualidades.Text = "Nenhuma item selecionado";
            }
        }

        private void chkAlegre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlegre.Checked)
            {
                lblQualidades.Text = chkAlegre.Text;
            }
            else
            {
                lblQualidades.Text = "Nenhuma item selecionado";
            }
        }

        private void btnQualidades_Click(object sender, EventArgs e)
        {
            lblTodas.Text = "Todas: ";
            if (chkInteligente.Checked)
            {
                lblTodas.Text += chkInteligente.Text + " ";
            }
            if (chkAmavel.Checked)
            {
                lblTodas.Text += chkAmavel.Text + " ";
            }
            if (chkSabio.Checked)
            {
                lblTodas.Text += chkSabio.Text + " ";
            }
            if (chkPaciente.Checked)
            {
                lblTodas.Text += chkPaciente.Text + " ";
            }
            if (chkTolerante.Checked)
            {
                lblTodas.Text += chkTolerante.Text + " ";
            }
            if (chkModesto.Checked)
            {
                lblTodas.Text += chkModesto.Text + " ";
            }
            if (chkTranquilo.Checked)
            {
                lblTodas.Text += chkTranquilo.Text + " ";
            }
            if (chkCalmo.Checked)
            {
                lblTodas.Text += chkCalmo.Text + " ";
            }
            if (chkComunicativo.Checked)
            {
                lblTodas.Text += chkComunicativo.Text + " ";
            }
            if (chkExuberante.Checked)
            {
                lblTodas.Text += chkExuberante.Text + " ";
            }
            if (chkBonito.Checked)
            {
                lblTodas.Text += chkBonito.Text + " ";
            }
            if (chkAlegre.Checked)
            {
                lblTodas.Text += chkAlegre.Text + " ";
            }

        }

        private void rdbAzul_CheckedChanged(object sender, EventArgs e)
        {
            grpCor.BackColor = Color.Blue;
        }

        private void rdbVermelho_CheckedChanged(object sender, EventArgs e)
        {
            grpCor.BackColor = Color.Red;
        }

        private void rdbVerde_CheckedChanged(object sender, EventArgs e)
        {
            grpCor.BackColor = Color.Green;
        }

        private void FrmCheckRadio_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Boa Noite", "Boas Vindas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
        }
    }
}
