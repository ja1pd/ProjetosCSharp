using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2Pag27
{
    public class Banco
    {
        private double valor;
        private double saldo = 0;

        public void setValor(double valor)
        {
            this.valor = valor;

        }

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;

        }

        public double getValor()
        {
            return this.valor;
        }
        public double getSaldo()
        {
            return this.saldo;
        }

        public void Sacar()
        {

            if (saldo < valor)
            {
                string msg = "Saldo Insuficiente!";
            }
            else
            {
                saldo = saldo - valor;

            }
        }

        public void Depositar()
        {
            saldo = saldo + valor;
        }

        public double VerificarSaldo()
        {
            return saldo;
        }
    }
}
