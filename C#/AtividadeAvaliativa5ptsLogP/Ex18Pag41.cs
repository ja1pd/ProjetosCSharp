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
    public partial class Ex18Pag41 : Form
    {
        public Ex18Pag41()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double la = double.Parse(txtLadoa.Text);
            double lb = double.Parse(txtLadob.Text);
            double lc = double.Parse(txtLadoc.Text);
            if (lb - lc < la && lb + lc > la) 
            {
                if (la == lb && la == lc)
                {
                    MessageBox.Show("O triângulo é equilátero");
                }
                else if (la != lb && la != lc && lc != lb)
                {
                    MessageBox.Show("O triângulo é escaleno");
                }
                else if (la == lc && la != lb || la == lb && la != lc || lc == lb && lc != la)
                {
                    MessageBox.Show("O triângulo é isósceles");
                }
                else
                {
                    MessageBox.Show("O triângulo existe");
                }
            }
            else
            {
                MessageBox.Show("Os valores informados não podem formam um triângulo!");
            }

        }
    }
}
