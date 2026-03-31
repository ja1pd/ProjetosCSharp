using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace MinhaCalculadora
{
    public class Calculadora
    {
        private double num1, num2;
        
        public void setNum(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double getNum()
        {
            return this.num1 + this.num2;
        }

        public double soma()
        {
            double result = this.num1 + this.num2;
            return result;
        }

        public double sub()
        {
            double result = this.num1 - this.num2;
            return result;
        }

        public double mult()
        {
            double result = this.num1;
            for (int i = 1; i < this.num2; i++)
            { 
                result += this.num1;
            }
            //double result = this.num1 * this.num2;
            return result; 
        }

        public double div()
        {

            if (this.num1 == 0 || this.num2 == 0)
            {
                MessageBox.Show("Insira valores válidos para calcular a divisão!");
                return 0;
            }
            else
            {
                double result = this.num1 / this.num2;
                return result;
            }
        }

        
        
    }
}