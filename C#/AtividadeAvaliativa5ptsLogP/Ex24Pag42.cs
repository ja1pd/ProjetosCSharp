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
    public partial class Ex24Pag42 : Form
    {
        public Ex24Pag42()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text);
            if (num % 5 == 0)
            {
                if (num % 3 == 0)
                {
                    MessageBox.Show("O número inserido é divisível por 5 e 3 ao mesmo tempo!");
                }
                else
                {
                    MessageBox.Show("O número inserido é divisível por 5 e não por 3!");

                }
            }
            else
            {
                if (num % 3 == 0)
                {
                    MessageBox.Show("O número inserido é divisível por 3 e não por 5!");
                }
                else
                {
                    MessageBox.Show("O número inserido não é divisível por 5 e nem por 3!");

                }
            }
        }
    }
}
