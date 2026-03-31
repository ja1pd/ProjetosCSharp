using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_Avaliativo_2ª_Etapa___5_Pontos
{
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            string texto = txtTexto.Text;
            lblMaiuscula.Text = texto.ToUpper();
        }
    }
}
