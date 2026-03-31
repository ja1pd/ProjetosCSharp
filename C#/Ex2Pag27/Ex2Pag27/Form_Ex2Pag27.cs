using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2Pag27
{
    public partial class Form_Ex2Pag27 : Form
    {
        public Form_Ex2Pag27()
        {
            InitializeComponent();
        }

        Banco b = new Banco();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            b.setValor(double.Parse(txtValor.Text));

            switch (cmbOperacao.Text) 
            {
                case "Sacar":
                    b.Sacar();
                    lblSaldoAtual.Text = b.getSaldo().ToString();

                    break;

                case "Depositar":
                    b.Depositar();
                    lblSaldoAtual.Text = b.getSaldo().ToString();

                    break;

                default:
                    MessageBox.Show("Opção Inválida!");
                    break;
            }

            lblSaldoAtual.Text = b.VerificarSaldo().ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSaldoAtual.Text = b.VerificarSaldo().ToString();
        }
    }
}
