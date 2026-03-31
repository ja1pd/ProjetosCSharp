using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MinhaCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] array = new double[10];
        int contador = 0;
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();

                calc.setNum(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text));
            

            switch (cmbOperacao.Text)
                {
                    case "Soma":
                        lblResultado.Text = calc.soma().ToString();
                        break;
                            
                    case "Subtração":
                        lblResultado.Text = calc.sub().ToString();

                        break;


                    case "Multiplicação":
                        lblResultado.Text = calc.mult().ToString();

                        break;


                    case "Divisão":
                        lblResultado.Text = calc.div().ToString();

                    break;

                }

                
                array[contador] = double.Parse(lblResultado.Text);
                lblHistorico.Text += array[contador] + Environment.NewLine;
                if (contador == 9)
                {
                MessageBox.Show("O Limite de Operações foi atingido! Encerrando o programa.");
                    Close();
                }
                contador++;
        }

        private void txtNum2_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double.Parse(txtNum2.Text);
            }
            catch
            {
                txtNum1.Clear();
            }
        }

        private void txtNum1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double.Parse(txtNum1.Text);
            }
            catch 
            {
                txtNum1.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOperacao.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
