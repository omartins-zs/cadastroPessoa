using System;
using System.Threading;

namespace cadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine($@"
===============================================
|    Bem Vindo ao Sistema de Cadastro de      |
|         Pessoas Fisica e Juridica           |
===============================================
");

            // Usando Function Da Barra de Carregamento | Adicionando "."
            AdicionarDot("Iniciando");

            // Criaçao da Variavel opcao
            string opcao;

            do
            {
                Console.WriteLine($@"
|================================================|
|       Escolha uma das opções abaixo            |
|------------------------------------------------|
|       1 - Pessoa Fisica                        |
|       2 - Pessoa Juridica                      |
|                                                |
|       0 - Sair                                 |
|================================================|
                ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "0":
                        break;

                    default:
                        break;
                }

            } while (opcao != "0");

        }
        static void AdicionarDot(string textoCarregamento)
        {
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(textoCarregamento);

            Thread.Sleep(500);
            for (var i = 0; i < 10; i++)
            {
                Console.Write($".");
                Thread.Sleep(250);
            }
            Console.ResetColor();
        }
    }
}
