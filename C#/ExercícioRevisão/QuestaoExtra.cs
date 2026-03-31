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
    public partial class QuestaoExtra : Form
    {
        public QuestaoExtra()
        {
            InitializeComponent();
        }

        private void QuestaoExtra_Load(object sender, EventArgs e)
        {
            txtNum1.Enabled = false;
            txtNum2.Enabled = false;
            btnRepetir.Enabled = false;
        }

        string[] vetJogadas = new string[3];
        int cont = 0;

        private void txtNum0_TextChanged(object sender, EventArgs e)
        {
            if (txtNum0.Text != "1" && txtNum0.Text != "2")
            {
                txtNum0.Clear();
            }
            else
            {
                vetJogadas[0] = txtNum0.Text;
                txtNum0.Enabled = false;
                MessageBox.Show("Registrado com Sucesso!");
                txtNum0.Clear();
                txtNum1.Enabled = true;


                txtNum1.Focus();
            }
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            if (txtNum1.Text != "1" && txtNum1.Text != "2")
            {
                txtNum1.Clear();
            }
            else
            {
                vetJogadas[1] = txtNum1.Text;
                txtNum1.Enabled = false;
                MessageBox.Show("Registrado com Sucesso!");
                txtNum1.Clear();
                txtNum2.Enabled = true;


                txtNum2.Focus();
            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            if (txtNum2.Text != "1" && txtNum2.Text != "2")
            {
                txtNum2.Clear();
            }
            else
            {
                vetJogadas[2] = txtNum2.Text;
                txtNum2.Enabled = false;
                MessageBox.Show("Registrado com Sucesso!");
                txtNum2.Clear();
                btnRepetir.Enabled = true;
                cont++;
                jogar();
                btnRepetir.Focus();

            }
        }

        private void btnRepetir_Click(object sender, EventArgs e)
        {
            txtNum0.Enabled = true;
            btnRepetir.Enabled = false;
        }

        private void jogar()
        {
            if (vetJogadas[0] == vetJogadas[1] && vetJogadas[0] != vetJogadas[2])
            {
                lstRodada.Items.Add(" • Na " + cont + "° rodada, o vencedor foi o jogador na posição 2!");
            }
            else if (vetJogadas[0] == vetJogadas[2] && vetJogadas[1] != vetJogadas[2])
            {
                lstRodada.Items.Add(" • Na " + cont + "° rodada, o vencedor foi o jogador na posição 1!");
            }
            else if (vetJogadas[1] == vetJogadas[2] && vetJogadas[0] != vetJogadas[2])
            {
                lstRodada.Items.Add(" • Na " + cont + "° rodada, o vencedor foi o jogador na posição 0!");
            }
            else
            {
                lstRodada.Items.Add(" • Na " + cont + "° rodada, houve um empate!");
            }
        }
    }
}
