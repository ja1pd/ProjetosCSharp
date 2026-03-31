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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void rbtnAzul_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void rbtnAmarelo_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void rbtnVermelho_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
