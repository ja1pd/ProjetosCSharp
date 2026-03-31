using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativa5ptsLogP
{
    public partial class Ex21Pag41 : Form
    {
        public Ex21Pag41()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double MulEsc = double.Parse(txtMulEsc.Text);
            double HomEsc = double.Parse(txtHomEsc.Text);
            double MulAna = double.Parse(txtMulAna.Text);
            double HomAna = double.Parse(txtHomAna.Text);
            double TotalEsc = MulEsc + HomEsc;
            double TotalAna = MulAna + HomAna;
            double PorcentagemMulherEsc = MulEsc / TotalEsc * 100;
            double PorcentagemMulherAna = MulAna / TotalAna * 100;


            if (TotalEsc > TotalAna) 
            {
                MessageBox.Show("O número de inscritos em Escritutário é maior do que em Analista de Sistemas");
            }
            else if (TotalEsc < TotalAna)
            {
                MessageBox.Show("O número de inscritos em Analista de Sistemas é maior do que em Escritutário");

            }
                else
                {
                    MessageBox.Show("O número de inscritos em Analista de Sistemas e em Escritutário são iguais");
                }

            if (HomEsc < HomAna)
            {
                MessageBox.Show("O cargo Escriturário teve o menor número de homens");
            }
                else if (HomEsc > HomAna)
                {
                    MessageBox.Show("O cargo Analista de Sistemas teve o menor número de homens");
                }
                else
                {
                MessageBox.Show("Ambos os cargos tiveram o mesmo número de homens");
                }

            MessageBox.Show("No cargo de Escriturário as mulheres representam " + PorcentagemMulherEsc + "%");
            MessageBox.Show("No cargo de Analista de Sistemas as mulheres representam " + PorcentagemMulherAna + "%");

            MessageBox.Show("O total de inscritos para as vagas de Escriturário é: " + TotalEsc);
            MessageBox.Show("O total de inscritos para as vagas de Analista de Sistemas é: " + TotalAna);


        }
    }
}
