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
    public partial class Questao5 : Form
    {
        public Questao5()
        {
            InitializeComponent();
        }

        private void Questao5_Load(object sender, EventArgs e)
        {
            int[] vet = new int[6];
            vet[0] = 100;
            lstVetor.Items.Add(" Índice 0 = " + vet[0]);

            for (int i = 1; i < vet.Length; i++)
            {
                vet[i] = vet[i-1] * 2;
                lstVetor.Items.Add("Índice " + i + " = " + vet[i]);
            }
        }
    }
}
