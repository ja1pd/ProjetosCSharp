using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag35
{
    internal class Pedido
    {
        public int Numero { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Status { get; set; } = string.Empty;
        public int IdCliente { get; set; }
    }
}
