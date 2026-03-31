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
    public partial class Ex10Pag16 : Form
    {
        public Ex10Pag16()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double raio = double.Parse(txtRaio.Text);
            double volume = 4 / 3 * 3.14 * (Math.Pow(raio,3));

            MessageBox.Show("O valor do volume da esfera é: " + volume);
        }
    }
}
