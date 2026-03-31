using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag35
{
    internal class ItemCardapio
    {
        public int IdItem { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public double Preco { get; set; }
    }
}
