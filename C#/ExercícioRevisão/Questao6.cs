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
    public partial class Questao6 : Form
    {
        public Questao6()
        {
            InitializeComponent();
        }

        private void Questao6_Load(object sender, EventArgs e)
        {
            txtValorParcela.Enabled = false;
            txtValorParcela.BackColor = Color.White;
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            if (txtNumP.Text == "" || txtSalario.Text == "" || txtValor.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                bool t1 = double.TryParse(txtValor.Text, out double valor);
                bool t2 = double.TryParse(txtNumP.Text, out double nump);
                bool t3 = double.TryParse(txtSalario.Text, out double salario);
                if (t1 == false || t2 == false || t3 == false)
                {
                    MessageBox.Show("Insira os capos com apenas números!");
                }
                else if (valor < 0 || nump < 0 || salario < 0)
                {
                    MessageBox.Show("Não são aceitos valores negativos!");
                }
                else
                {
                    txtValorParcela.Text = (valor / nump).ToString("F2");
                    double porcentagem = (valor / nump * 100) / salario;
                    lblPorcentagem.Text = porcentagem.ToString("F2") + "%";
                    if ((salario * 0.3) >= (valor / nump))
                    {
                        lblStatus.Text = "Aprovado";
                    }
                    else
                    {
                        lblStatus.Text = "Reprovado";
                        MessageBox.Show("O valor da parcelas deve representar no máximo 30% do salário do solicitante!");
                    }
                }
            }
        }
    }
}
