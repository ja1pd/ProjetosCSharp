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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio1 ex1 = new Exercicio1();
            ex1.ShowDialog();
        }

        private void exercício1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Exercicio2 ex1 = new Exercicio2();
            ex1.ShowDialog();
        }

        private void exercício1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Exercicio3 ex1 = new Exercicio3();
            ex1.ShowDialog();
        }

        private void exercício1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Exercicio4 ex1 = new Exercicio4();
            ex1.ShowDialog();
        }

        private void desafioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Desafio ex1 = new Desafio();
            ex1.ShowDialog();
        }
    }
}
