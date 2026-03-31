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
    public partial class Ex12Pag16 : Form
    {
        public Ex12Pag16()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double questoes = double.Parse(txtQuestoes.Text);
            double acertos = double.Parse(txtAcertos.Text);
            double erros = questoes - acertos;
            double pacertos = acertos / questoes * 100;
            double perros = erros / questoes * 100;

            MessageBox.Show("O total de erros; " + erros);
            MessageBox.Show("A porcentagem de acertos foi de " + pacertos +"%");
            MessageBox.Show("A porcentagem de erros foi de " + perros + "%");



        }
    }
}
