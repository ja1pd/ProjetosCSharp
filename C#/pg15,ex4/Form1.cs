namespace pg15_ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //João Pedro Bastos Neves 22 2A2 
            int lado = int.Parse(txtLado.Text);
            int area = lado * lado;

            MessageBox.Show("A área do quadrado é: " + area);

        }
    }
}
