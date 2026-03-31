using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercícioRevisão
{
    public partial class Questao1 : Form
    {
        public Questao1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string senha = txtSenha.Text;
            if (senha == "1234")
            {
                MessageBox.Show("Acesso Permitido");
            }
            else if (senha == "")
            {
                MessageBox.Show("Por favor preencha uma senha.");
            }
            else
            {
                MessageBox.Show("Acesso Negado");
            }
        }
    }
}
