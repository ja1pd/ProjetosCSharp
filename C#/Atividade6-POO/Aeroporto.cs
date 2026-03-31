using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6_POO
{
    internal class Aeroporto
    {

        private int codigo;
        private string nome = "";
        private string cidade = "";
        private string estado = "";
        private string pais = "";

        public int GetCodigo()
        {
            return this.codigo;
        }

        public void SetCodigo(int codigoAeroporto)
        {
            this.codigo = codigoAeroporto;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetNome(string nomeAeroporto)
        {
            this.nome = nomeAeroporto;
        }

        public string GetCidade()
        {
            return this.cidade;
        }

        public void SetCidade(string cidadeAeroporto)
        {
            this.cidade = cidadeAeroporto;
        }

        public string GetEstado()
        {
            return this.estado;
        }

        public void SetEstado(string estadoAeroporto)
        {
            this.estado = estadoAeroporto;
        }

        public string GetPais()
        {
            return this.pais;
        }

        public void SetPais(string paisAeroporto)
        {
            this.pais = paisAeroporto;
        }

    }
}
