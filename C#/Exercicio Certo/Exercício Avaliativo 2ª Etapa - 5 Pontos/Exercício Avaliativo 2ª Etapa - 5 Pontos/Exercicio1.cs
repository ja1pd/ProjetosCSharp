using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_Avaliativo_2ª_Etapa___5_Pontos
{
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void cmbInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();
            int num1 = int.Parse(cmbInicio.Text);
            int num2 = int.Parse(cmbFim.Text);

            if (num1 <= num2 )
            {
                while (num1  <= num2)
                {
                    lstNumeros.Items.Add(num1);
                    num1++;
                }
            }
            else
            {
                while (num1 >= num2)
                {
                    lstNumeros.Items.Add(num1);
                    num1--;
                }
            }
        }

        private void cmbFim_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();
            int num1 = int.Parse(cmbInicio.Text);
            int num2 = int.Parse(cmbFim.Text);

            if (num1 <= num2)
            {
                while (num1 <= num2)
                {
                    lstNumeros.Items.Add(num1);
                    num1++;
                }
            }
            else
            {
                while (num1 >= num2)
                {
                    lstNumeros.Items.Add(num1);
                    num1--;
                }
            }
        }
    }
}
