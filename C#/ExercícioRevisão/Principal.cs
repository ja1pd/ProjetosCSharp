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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void questão1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Questao1 q1 = new Questao1();
            q1.ShowDialog();
        }

        private void questão2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Questao2 q2 = new Questao2();
            q2.ShowDialog();
        }

        private void questão3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Questao3 q3 = new Questao3();
            q3.ShowDialog();
        }

        private void questão4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Questao4 q4 = new Questao4();
            q4.ShowDialog();
        }

        private void questão5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Questao5 q5 = new Questao5();
            q5.ShowDialog();
        }

        private void questão6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Questao6 q6 = new Questao6();
            q6.ShowDialog();
        }

        private void questão7ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Questao7 q7 = new Questao7();
            q7.ShowDialog();
        }

        private void questão8ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Questao8 q8 = new Questao8();
            q8.ShowDialog();
        }

        private void questão9ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Questao9 q9 = new Questao9();
            q9.ShowDialog();
        }

        private void questão10ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Questao10 q10 = new Questao10();
            q10.ShowDialog();
        }

        private void questãoExtraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QuestaoExtra qx = new QuestaoExtra();
            qx.ShowDialog();
        }
    }
}
