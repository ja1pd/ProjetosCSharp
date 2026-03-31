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
    public partial class Exercicio4 : Form
    {
        public Exercicio4()
        {
            InitializeComponent();
        }

        double total = 0;
       

        private void chkArroz_CheckedChanged(object sender, EventArgs e)
        {
            if (chkArroz.Checked == true)
            {
                total += 20;
                lblTotal.Text = "R$" + total.ToString("f2");
            }
            else
            {
                if (chkArroz.Checked == false)
                {
                    total -= 20;
                    lblTotal.Text = "R$" + total.ToString("f2");
                }
            }
        }

        private void chkFeijao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFeijao.Checked == true)
            {
                total += 15;
                lblTotal.Text = "R$" + total.ToString("f2");
            }
            else
            {
                if (chkFeijao.Checked == false)
                {
                    total -= 15;
                    lblTotal.Text = "R$" + total.ToString("f2");
                }
            }
        }

        private void chkMacarrao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMacarrao.Checked == true)
            {
                total += 25;
                lblTotal.Text = "R$" + total.ToString("f2");
            }
            else
            {
                if (chkMacarrao.Checked == false)
                {
                    total -= 25;
                    lblTotal.Text = "R$" + total.ToString("f2");
                }
            }
        }

        private void chkCarne_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCarne.Checked == true)
            {
                total += 30;
                lblTotal.Text = "R$" + total.ToString("f2");
            }
            else
            {
                if (chkCarne.Checked == false)
                {
                    total -= 30;
                    lblTotal.Text = "R$" + total.ToString("f2");
                }
            }
        }

        private void chkOleo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOleo.Checked == true)
            {
                total += 15.5;
                lblTotal.Text = "R$" + total.ToString("f2");
            }
            else
            {
                if (chkOleo.Checked == false)
                {
                    total -= 15.5;
                    lblTotal.Text = "R$" + total.ToString("f2");
                }
            }
        }

        private void chkLeite_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLeite.Checked == true)
            {
                total += 14.99;
                lblTotal.Text = "R$" + total.ToString("f2");
            }
            else
            {
                if (chkLeite.Checked == false)
                {
                    total -= 14.99;
                    lblTotal.Text = "R$" + total.ToString("f2");
                }
            }
        }

        private void chkOvos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOvos.Checked == true)
            {
                total += 24;
                lblTotal.Text = "R$" + total.ToString("f2");
            }
            else
            {
                if (chkOvos.Checked == false)
                {
                    total -= 24;
                    lblTotal.Text = "R$" + total.ToString("f2");
                }
            }
        }

        private void chkAcucar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAcucar.Checked == true)
            {
                total += 20;
                lblTotal.Text = "R$" + total.ToString("f2");
            }
            else
            {
                if (chkAcucar.Checked == false)
                {
                    total -= 20;
                    lblTotal.Text = "R$" + total.ToString("f2");
                }
            }
        }

        
    }
}
