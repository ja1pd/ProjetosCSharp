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
    public partial class Questao7 : Form
    {
        public Questao7()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            
            if (txtNum1.Text == "" || txtNum2.Text == "" || txtNum3.Text == "")
            {
                MessageBox.Show("Insira todos os valores!");
            }
            else
            {
                bool t1 = double.TryParse(txtNum1.Text, out double num1);
                bool t2 = double.TryParse(txtNum2.Text, out double num2);
                bool t3 = double.TryParse(txtNum3.Text, out double num3);
                if (t1 == false || t2 == false || t3 == false)
                {
                    MessageBox.Show("Insira apenas números!");
                }
                else
                {
                    if (num1 == num2 || num2 == num3 || num1 == num3)
                    {
                        MessageBox.Show("Insira números diferentes!");
                    }
                    else
                    {
                        if (num1 > num2 && num1 > num3)
                        {
                            lblNum.Text = "O maior número é: " + num1.ToString();
                        }
                        else if (num2 > num3)
                        {
                            lblNum.Text = "O maior número é: " + num2.ToString();
                        }
                        else
                        {
                            lblNum.Text = "O maior número é: " + num3.ToString();
                        }
                    }
                }
            }



        }
    }
}
