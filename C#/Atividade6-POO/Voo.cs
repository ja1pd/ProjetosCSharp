using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6_POO
{
    internal class Voo
    {

        private int codigo;
        private string dataHora = "";
        private string origem = "";
        private string destino = "";
        private string piloto = "";
        private string aeronave = "";

        public int GetCodigo()
        {
            return this.codigo;
        }

        public void SetCodigo(int codigoVoo)
        {
            this.codigo = codigoVoo;
        }

        public string GetDataHora()
        {
            return this.dataHora;
        }

        public void SetDataHora(string dataHoraVoo)
        {
            this.dataHora = dataHoraVoo;
        }

        public string GetOrigem()
        {
            return this.origem;
        }

        public void SetOrigem(string origemVoo)
        {
            this.origem = origemVoo;
        }

        public string GetDestino()
        {
            return this.destino;
        }

        public void SetDestino(string destinoVoo)
        {
            this.destino = destinoVoo;
        }

        public string GetPiloto()
        {
            return this.piloto;
        }

        public void SetPiloto(string pilotoVoo)
        {
            this.piloto = pilotoVoo;
        }

        public string GetAeronave()
        {
            return this.aeronave;
        }

        public void SetAeronave(string aeronaveVoo)
        {
            this.aeronave = aeronaveVoo;
        }

    }
}
