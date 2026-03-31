using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Conta batata = new Conta();
        Cliente cli = new Cliente();


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cli.setValor(double.Parse(txtValor.Text));
            // MessageBox.Show("Olá"+ cli.nome);
            cli.recebeNome(textBox1.Text);
            

            switch (cmbOperação.Text)
            {
                case "Depósito":

                    cli.depositar();
                    lblSaldo.Text = cli.getSaldo().ToString();

                    break;

                case "Saque":

                    
                    if(double.Parse(txtValor.Text)>cli.getSaldo())
                    {
                        lblSaldo.Text = cli.saque();
                    }
                    else
                    {
                        cli.saque();
                        lblSaldo.Text = cli.getSaldo().ToString();
                    }
                    
                    break;
                default:
                    lblSaldo.Text = "Operação Inválida:Escolha depósito ou saque";
                    break;
            }

        }
    }
}
