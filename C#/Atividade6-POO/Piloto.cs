using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6_POO
{
    internal class Piloto
    {

        private int codigo;
        private string nome = "";
        private string dataAdmissao = "";

        public int GetCodigo()
        {
            return this.codigo;
        }

        public void SetCodigo(int codigoPiloto)
        {
            this.codigo = codigoPiloto;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetNome(string nomePiloto)
        {
            this.nome = nomePiloto;
        }

        public string GetDataAdmissao()
        {
            return this.dataAdmissao;
        }

        public void SetDataAdmissao(string dataAdmissaoPiloto)
        {
            this.dataAdmissao = dataAdmissaoPiloto;
        }

    }
}
