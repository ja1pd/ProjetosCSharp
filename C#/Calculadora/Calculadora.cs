namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            int escolha = int.Parse(cmbEscolha.Text);

            if (num2 == 0 && escolha == 4)
            {
                MessageBox.Show("Não é possível dividir um número por 0, selecione outro divisor ou outra operação");
                lblResultado.Text = "Não é possível dividir um número por 0, selecione outro divisor ou outra operação";
            }
            else
            {
                switch (escolha)
                {
                    case 1:
                        MessageBox.Show("A soma é " + (num1 + num2));
                        lblResultado.Text = ("A soma é " + (num1 + num2));
                        break;

                    case 2:
                        MessageBox.Show("A subtração é " + (num1 - num2));
                        lblResultado.Text = ("A subtração é " + (num1 - num2));
                        break;

                    case 3:
                        MessageBox.Show("A multiplicação é " + (num1 * num2));
                        lblResultado.Text = ("A multiplicação é " + (num1 * num2));
                        break;

                    case 4:
                        MessageBox.Show("A divisão é " + (num1 / num2));
                        lblResultado.Text = ("A divisão é " + (num1 / num2));
                        break;

                    default:
                        MessageBox.Show("Selecione uma operação!");
                        lblResultado.Text = ("Selecione uma operação!");
                        break;

                }
            }


        }

       
    }
}
