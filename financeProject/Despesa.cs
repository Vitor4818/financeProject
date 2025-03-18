using financeProject;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace financeProject
{
    public class Despesa : Transacao
    {
        public Despesa(double valor, DateTime data, string descricao)
        : base(valor, data, descricao) { }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"[DESPESA] {Data.ToShortDateString()} - {Descricao}: -R$ {Valor:F2}");
        }
    }
}