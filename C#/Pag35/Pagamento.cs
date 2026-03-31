using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag35
{
    internal class Pagamento
    {
        public int NumeroTransacao { get; set; }
        public double Valor { get; set; }
        public string Metodo { get; set; } = string.Empty;
    }
}
