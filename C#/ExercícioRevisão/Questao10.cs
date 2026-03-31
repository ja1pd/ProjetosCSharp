using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercícioRevisão
{
    public partial class Questao10 : Form
    {
        public Questao10()
        {
            InitializeComponent();
        }

        private void Questao10_Load(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 10 == 0)
                {
                    soma += i;
                }
            }
            lblTotal.Text = "A soma total dos números divisíveis por 10 de 0 até 1000 é: " + soma;
        }
    }
}
