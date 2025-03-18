using System;
using System.Collections.Generic;
using financeProject;

class Program
{
    static Usuario usuario = new Usuario("Vitor");

    static void Main()
    {
        
        bool sair = false;
        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Cadastrar Receita");
            Console.WriteLine("2 - Cadastrar Despesa");
            Console.WriteLine("3 - Exibir Resumo");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarReceita();
                    break;
                case "2":
                    CadastrarDespesa();
                    break;
                case "3":
                    ExibirResumo();
                    break;
                case "4":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }

            if (!sair)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static void CadastrarReceita()
    {
        Console.Clear();
        Console.WriteLine("Cadastrar Receita:");

        Console.Write("Digite o valor da receita: ");
        double valor = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a descrição da receita: ");
        string descricao = Console.ReadLine();

        DateTime data;
        while (true)
        {
            Console.Write("Digite a data (dd/MM/yyyy): ");
            string dataEntrada = Console.ReadLine();

            
            if (DateTime.TryParseExact(dataEntrada, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data))
            {
                break; 
            }
            else
            {
                Console.WriteLine("Data inválida, tente novamente.");
            }
        }

        Receita receita = new Receita(valor, data, descricao);
        usuario.AdicionarTransacao(receita);

        Console.WriteLine("Receita cadastrada com sucesso!");
    }

    static void CadastrarDespesa()
    {
        Console.Clear();
        Console.WriteLine("Cadastrar Despesa:");

        Console.Write("Digite o valor da despesa: ");
        double valor = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a descrição da despesa: ");
        string descricao = Console.ReadLine();

        DateTime data;
        while (true)
        {
            Console.Write("Digite a data (dd/MM/yyyy): ");
            string dataEntrada = Console.ReadLine();

            if (DateTime.TryParseExact(dataEntrada, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data))
            {
                break; 
            }
            else
            {
                Console.WriteLine("Data inválida, tente novamente.");
            }
        }

        Despesa despesa = new Despesa(valor, data, descricao);
        usuario.AdicionarTransacao(despesa);

        Console.WriteLine("Despesa cadastrada com sucesso!");
    }

    static void ExibirResumo()
    {
        Console.Clear();
        Console.WriteLine("Resumo financeiro:");

        usuario.ExibirResumo();
    }
}
