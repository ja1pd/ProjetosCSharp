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
    public partial class Questao3 : Form
    {
        public Questao3()
        {
            InitializeComponent();
        }

        private void Questao3_Load(object sender, EventArgs e)
        {
            rbnDeposito.Checked = true;
        }

        float saldo = 0;
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float valor;
            if (txtConta.Text == "" || txtNome.Text == "" || txtValor.Text == "")
            {
                MessageBox.Show("Preencha os campos com todas as informações! Não Deixe espaços vazios!");
            }
            else
            {
                bool tv = float.TryParse(txtValor.Text, out valor);
                if (tv == false)
                {
                    MessageBox.Show("Insira valores válidos nos campos!");
                }
                else if (valor < 0)
                {
                    MessageBox.Show("Insira valores válidos nos campos! Não são aceitos valores negativos!");
                }
                else
                {
                    string nome = txtNome.Text;
                    string conta = txtConta.Text;
                    if (rbnDeposito.Checked == true)
                    {
                        saldo += valor;
                        lblSaldo.Text = saldo.ToString("F2");
                    }
                    else
                    {
                        saldo -= valor;
                        lblSaldo.Text = saldo.ToString("F2");
                    }
                }


            }
        }

        
    }
}
