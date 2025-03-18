using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financeProject
{
    public abstract class Transacao
    {
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }

        public Transacao(double valor, DateTime data, string descricao)
        {
            Valor = valor;
            Data = data;
            Descricao = descricao;
        }

        public abstract void ExibirDetalhes();
    }
}