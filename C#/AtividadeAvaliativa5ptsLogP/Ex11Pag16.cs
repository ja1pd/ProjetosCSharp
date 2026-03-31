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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double c = double.Parse(txtCelsius.Text);
            double f = (9 / 5 * c) + 32;
            double k = c + 273;
            MessageBox.Show("A temperatura inserida convertida em Fahrenheit é " + f);
            MessageBox.Show("A temperatura inserida convertida em Kelvin é " + k);


        }
    }
}
