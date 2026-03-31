using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4Pag34
{
    abstract class Animal
    {

        protected string nome;
        protected string idade;

        protected string emitirSom(string som)
        {
            return som;
        }

        protected string exibirInformacao()
        {
            return $"O seu pet chama {nome} e tem {idade} anosA";
        }

    }
}
