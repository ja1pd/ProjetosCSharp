using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4Pag34
{
    class Cachorro:Animal
    {

        public void Latir()
        {
            emitirSom("Au Au");
        }

        public void Dados()
        {
            nome = "Bolinha";
            idade = "4";
            exibirInformacao();
        }

    }
}
