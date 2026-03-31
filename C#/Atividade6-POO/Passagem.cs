using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6_POO
{
    internal class Passagem
    {

        private int codigo;
        private string assento = "";
        private string cpfPassageiro = "";
        private string nomePassageiro = "";
        private double preco;
        private string voo = "";

        public int GetCodigo()
        {
            return this.codigo;
        }

        public void SetCodigo(int codigoPassagem)
        {
            this.codigo = codigoPassagem;
        }

        public string GetAssento()
        {
            return this.assento;
        }

        public void SetAssento(string assentoPassagem)
        {
            this.assento = assentoPassagem;
        }

        public string GetCpfPassageiro()
        {
            return this.cpfPassageiro;
        }

        public void SetCpfPassageiro(string cpfPassageiro)
        {
            this.cpfPassageiro = cpfPassageiro;
        }

        public string GetNomePassageiro()
        {
            return this.nomePassageiro;
        }

        public void SetNomePassageiro(string nomePassageiro)
        {
            this.nomePassageiro = nomePassageiro;
        }

        public double GetPreco()
        {
            return this.preco;
        }

        public void SetPreco(double precoPassagem)
        {
            this.preco = precoPassagem;
        }

        public string GetVoo()
        {
            return this.voo;
        }

        public void SetVoo(string vooPassagem)
        {
            this.voo = vooPassagem;
        }

    }
}
