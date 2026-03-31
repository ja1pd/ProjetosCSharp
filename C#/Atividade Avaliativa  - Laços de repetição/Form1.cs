namespace Atividade_Avaliativa____Laços_de_repetição
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            double somatorio = 0;
            double media = 0;
            int Menor75 = 0;
            int Entre20e23 = 0;
            Random r = new Random();
            txtIdade.Clear();
            txtPesos.Clear();

            while (contador < 40)
            {
                int peso = r.Next(40, 120);
                txtPesos.Text += " " + peso;
                if (peso < 75)
                {
                    Menor75++;
                }
                int idade = r.Next(15, 45);
                txtIdade.Text += " " + idade;
                if (idade < 23 && idade > 20)
                {
                    Entre20e23++;
                }
                somatorio += idade;
                contador++;
            }
            media = somatorio / contador;
            lblMenor75kg.Text = "Quantidade de atletas com peso abaixo de 75kg: " + Menor75;
            lblEntre20e23.Text = "Quantidade de atletas com idade entre 20 e 23 anos: " + Entre20e23;
            lblMediaIdades.Text = "Idade média da equipe: " + media;
            
        }
    }
}
