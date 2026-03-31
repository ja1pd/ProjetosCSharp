namespace Página_32__Ex_4
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
            int num = int.Parse(txtNum.Text);
            if (num >= 0)
            {
                MessageBox.Show((num * 2).ToString());
            }
            else
            {
                MessageBox.Show((num * 3).ToString());
            }
        }

        
    }
}
