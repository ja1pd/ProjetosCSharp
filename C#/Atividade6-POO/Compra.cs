using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6_POO
{
    internal class Compra
    {

        private int codigo;
        private string passagem = "";
        private string cliente = "";
        private string pagamento = "";
        private double valorTotal;

        public int GetCodigo()
        {
            return this.codigo;
        }

        public void SetCodigo(int codigoCompra)
        {
            this.codigo = codigoCompra;
        }

        public string GetPassagem()
        {
            return this.passagem;
        }

        public void SetPassagem(string passagemCompra)
        {
            this.passagem = passagemCompra;
        }

        public string GetCliente()
        {
            return this.cliente;
        }

        public void SetCliente(string clienteCompra)
        {
            this.cliente = clienteCompra;
        }

        public string GetPagamento()
        {
            return this.pagamento;
        }

        public void SetPagamento(string tipoPagamento)
        {
            this.pagamento = tipoPagamento;
        }

        public double GetValorTotal()
        {
            return this.valorTotal;
        }

        public void SetValorTotal(double valorCompra)
        {
            this.valorTotal = valorCompra;
        }

    }
}
