using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6Pag34
{
    abstract class Pagamento
    {

        protected double Valor;

        virtual public double Pagar(double valor)
        {
            this.Valor = valor;
            return this.Valor;
        }

    }
}
