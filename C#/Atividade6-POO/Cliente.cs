using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6_POO
{
    internal class Cliente
    {

        private int codigo;
        private string nome = "";
        private string cpf = "";
        private string endereco = "";
            
        public int GetCodigo()
        {
            return this.codigo;
        }

        public void SetCodigo(int codigoCliente)
        {
            this.codigo = codigoCliente;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public void SetNome(string nomeCliente)
        {
            this.nome = nomeCliente;
        }

        public string GetCpf()
        {
            return this.cpf;
        }

        public void SetCpf(string cpfCliente)
        {
            this.cpf = cpfCliente;
        }

        public string GetEndereco()
        {
            return this.endereco;
        }

        public void SetEndereco(string enderecoCliente)
        {
            this.endereco = enderecoCliente;
        }

    }
}
