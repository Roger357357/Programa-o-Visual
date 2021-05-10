using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVetor
{
    public partial class FrmVetor : Form
    {
        public FrmVetor()
        {
            InitializeComponent();
        }

        private void FrmVetor_Load(object sender, EventArgs e)
        {
            int[] inteiros;
            inteiros = new int[3];

            inteiros[0] = 10;
            inteiros[1] = 22;
            inteiros[2] = 35;

            for(int i = 0; i <inteiros.Length; i++)
            {
                lstInteiros.Items.Add(inteiros[i]);
            }

            foreach(int var in inteiros)
            {
                lstInteiros.Items.Add(var);
            }
        }
    }
}
