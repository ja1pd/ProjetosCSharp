using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6Pag34
{
    internal class Paypal:Pagamento
    {
        public int juros = 3;

        public override double Pagar(double valor)
        {
            return (valor + juros);
        }
        
    }
}
