using financeProject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace financeProject
{
    public class Usuario
    {
        public string Nome { get; set; }
        public List<Transacao> Transacoes { get; set; }
        public List<Categoria> Categorias { get; set; }

        public Usuario(string nome)
        {
            Nome = nome;
            Transacoes = new List<Transacao>();
            Categorias = new List<Categoria>();
        }

        public void AdicionarCategoria(string nome, double limite)
        {
            Categoria categoria = new Categoria(nome, limite);
            Categorias.Add(categoria);
        }

        public void AdicionarTransacao(Transacao transacao)
        {
            Transacoes.Add(transacao);
        }

        public void ExibirResumo()
        {
            double saldo = CalcularSaldo();
            Console.WriteLine($"Resumo financeiro de {Nome}:");
            Console.WriteLine($"Saldo atual: {saldo:C}");

            Console.WriteLine("\nTransações:");
            foreach (var transacao in Transacoes)
            {
                Console.WriteLine($"- {transacao.Tipo} de {transacao.Valor:C} em {transacao.Data.ToString("dd/MM/yyyy")} | Descrição: {transacao.Descricao}");
            }
        }

        public double CalcularSaldo()
        {
            double saldoReceitas = Transacoes.OfType<Receita>().Sum(r => r.Valor);
            double saldoDespesas = Transacoes.OfType<Despesa>().Sum(d => d.Valor);
            return saldoReceitas - saldoDespesas;
        }
    }
}
