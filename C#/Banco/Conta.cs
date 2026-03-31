using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        private double valor;
        private double saldo = 0;
        protected string nome { get; set; }


        public void setValor(double valor)
        {
            this.valor = valor;
        }

        /* public double getValor()
         {
             return valor;
         }*/
        /*public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }*/

        public double getSaldo()
        {
            return this.saldo;
        }

        public void depositar()
        {
            this.saldo = this.saldo + valor;
        }

        public string saque()
        {
            if (saldo >= valor)
            {
                this.saldo = this.saldo - valor;
            }
            else
            {
                return "Saldo Insuficiente";
            }
            return "";

        }





    }
}
