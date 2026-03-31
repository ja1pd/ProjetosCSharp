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
    public partial class Questao2 : Form
    {
        public Questao2()
        {
            InitializeComponent();
        }

        string[] produto = new string[3];
        int[] qtd = new int[3];
        double[] valor = new double[3];
        double[] desconto = new double[3];
        double[] total = new double[3];

        int contador = 0;


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text == "" || txtQuantidade.Text == "" || txtValor.Text == "" || txtDesconto.Text == "")
            {
                MessageBox.Show("Preencha os campos com todas as informações! Não Deixe espaços vazios!");
            }
            else
            {
                bool tq = int.TryParse(txtQuantidade.Text, out qtd[contador]);
                bool td = double.TryParse(txtDesconto.Text, out desconto[contador]);
                bool tv = double.TryParse(txtValor.Text, out valor[contador]);

                if (tq == false || td == false || tv == false)
                {
                    MessageBox.Show("Insira valores válidos nos campos!");
                }
                else
                {
                    if (int.Parse(txtQuantidade.Text) < 0 || double.Parse(txtDesconto.Text) < 0 || double.Parse(txtValor.Text) < 0)
                        MessageBox.Show("Insira valores válidos nos campos! Não são aceitos valores negativos!");
                    else
                    {
                        contador++;
                        if (contador == 3)
                        {
                            for (int i = 0; i < produto.Length; i++)
                            {
                                total[i] = (qtd[i] * valor[i]) - desconto[i];
                                listBox1.Items.Add("Nome: " + produto[i] + " Quantidade: " + qtd[i] + " Valor: " + valor[i] + " Desconto: " + desconto[i] + " Total: " + total[i]);
                            }
                            btnCadastrar.Enabled = false;
                        }
                        txtDesconto.Clear();
                        txtProduto.Clear();
                        txtQuantidade.Clear();
                        txtValor.Clear();
                    }
                }
            }
        }
    }
}
