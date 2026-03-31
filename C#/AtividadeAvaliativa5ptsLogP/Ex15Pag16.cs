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
    public partial class Ex15Pag16 : Form
    {
        public Ex15Pag16()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        { 
            int valor = int.Parse(txtValor.Text);
            int nota200 = valor / 200;
            int nota100 = (valor % 200) / 100;
            int nota50 = (valor % 100) / 50;
            int nota10 = (valor % 50) / 10;
            int nota5 = (valor % 10) / 5;
            int nota2 = (valor % 5) / 2;
            int moeda1 = (valor % 2) / 1;
            MessageBox.Show("Notas de R$200,00: " + nota200 
                + "\nNotas de R$100,00: " + nota100 
                + "\nNotas de R$50,00: " + nota50
                + "\nNotas de R$10,00: " + nota10
                + "\nNotas de R$5,00: " + nota5
                + "\nNotas de R$2,00: " + nota2
                + "\nMoedas de R$1,00: " + moeda1);
        }
    }
}
