using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6_POO
{
    internal class Aeronave
    {

        private int codigo;
        private string nome = "";
        private int capacidade;
        private int pesoMaximo;
        private string empresa = "";

        public int GetCodigo()
        {
            return this.codigo;
        }

        public void SetCodigo(int codigoAeronave)
        {
            this.codigo = codigoAeronave;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetNome(string nomeAeronave)
        {
            this.nome = nomeAeronave;
        }

        public int GetCapacidade()
        {
            return this.capacidade;
        }

        public void SetCapacidade(int capacidadeAeronave)
        {
            this.capacidade = capacidadeAeronave;
        }

        public int GetPesoMaximo()
        {
            return this.pesoMaximo;
        }

        public void SetPesoMaximo(int pesoMaximoAeronave)
        {
            this.pesoMaximo = pesoMaximoAeronave;
        }

        public string GetEmpresa()
        {
            return this.empresa;
        }

        public void SetEmpresa(string empresaAeronave)
        {
            this.empresa = empresaAeronave;
        }

    }
}
