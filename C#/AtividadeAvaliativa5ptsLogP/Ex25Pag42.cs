using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativa5ptsLogP
{
    public partial class Ex25Pag42 : Form
    {
        public Ex25Pag42()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int ano = int.Parse(txtAno.Text);
            if (ano % 4 == 0)
            {
                if (ano % 100 == 0) 
                { 
                    if (ano % 400 == 0)
                    {
                        MessageBox.Show("O ano é bissexto!");
                    }
                    else
                    {
                        MessageBox.Show("O ano não é bissexto!");
                    }
                }
                else
                {
                    MessageBox.Show("O ano é bissexto!");
                }
            }
            else
            {
                MessageBox.Show("O ano não é bissexto!");
            }
        }
    }
}
