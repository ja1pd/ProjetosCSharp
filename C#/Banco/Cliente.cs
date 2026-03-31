using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cliente:Conta
    {

       public void recebeNome(string nome)
        {
            this.nome = nome;
            //this.valor = setValor();
        }

    }
}
