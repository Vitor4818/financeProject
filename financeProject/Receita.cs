using financeProject;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace financeProject
{
    public class Receita : Transacao
    {
        public Receita(double valor, DateTime data, string descricao)
        : base(valor, data, descricao) { }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"[RECEITA] {Data.ToShortDateString()} - {Descricao}: +R$ {Valor:F2}");
        }
    }
}