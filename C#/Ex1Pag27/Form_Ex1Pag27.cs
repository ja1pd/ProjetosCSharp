namespace Ex1Pag27
{
    public partial class Form_Ex1Pag27 : Form
    {
        public Form_Ex1Pag27()
        {
            InitializeComponent();
        }

        Ex1Pag27 ex = new Ex1Pag27();

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                 lblResultado.Text = ex.Divisao(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text)).ToString();
                
            }
            catch (Exception excecao)
            {
                MessageBox.Show("" + excecao.Message);
            }
        }
    }
}
