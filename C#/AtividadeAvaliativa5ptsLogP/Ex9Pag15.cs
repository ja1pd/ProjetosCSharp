using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativa5ptsLogP
{
    public partial class Ex9Pag15 : Form
    {
        public Ex9Pag15()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int nascimento = int.Parse(txtNascimento.Text);
            int atual = int.Parse(txtAtual.Text);
            int idade = atual - nascimento;
            MessageBox.Show("Sua idade em anos é:" + idade);
            MessageBox.Show("Sua idade em meses é:" + (idade * 12));
            MessageBox.Show("Sua idade em dias é:" + (idade * 365));
            MessageBox.Show("Sua idade em semanas é:" + (idade * 52));
        }
    }
}
