using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6_POO
{
    internal class Empresa
    {

        private int codigo;
        private string nome = "";

        public int GetCodigo()
        {
            return this.codigo;
        }

        public void SetCodigo(int codigoEmpresa)
        {
            this.codigo = codigoEmpresa;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetNome(string nomeEmpresa)
        {
            this.nome = nomeEmpresa;
        }

    }
}
