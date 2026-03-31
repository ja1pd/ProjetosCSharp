using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Pag27
{
    public class Ex1Pag27
    {

        public double Divisao(double num1, double num2)
        {
            if (num2 == 0)
            {
                MessageBox.Show("Insira Valores Válidos!");
                return 0;
            }
            else
            {
                return num1/ num2 ;
            }

            
        }

    }
}
