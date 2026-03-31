using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6Pag34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Pagamento paga = new Pagamento();

        Cartao c = new Cartao();
        Paypal p = new Paypal();

        private void button1_Click(object sender, EventArgs e)
        {
            c.juros = double.Parse(txtJuros.Text);
        }
    }
}
