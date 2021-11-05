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
                        // Usado apenas para chamar os objetos
                        PessoaFisica pf = new PessoaFisica();

                        // Para criar novo Endereço e Pessoa
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco endPf = new Endereco();

                        // Instanciando Endereco
                        endPf.logradouro = "Z";
                        endPf.numero = 34;
                        endPf.complemento = "Proximo ao Senai Presidente Dutra";
                        endPf.enderecoComercial = false;

                        // Instanciando Pessoa
                        novaPf.endereco = endPf;
                        novaPf.cpf = "32442342198";
                        novaPf.nome = "Pessoa Fisica";
                        // Instanciando o rendimento
                        novaPf.rendimento = 1500;
                        novaPf.dataNascimento = new DateTime(2000, 06, 15);

                        // Usando a funçao de validar data | Passo a Passo
                        bool idadeValida = novaPf.ValidarDataNascimento(novaPf.dataNascimento);
                        // Console.WriteLine(idadeValida);

                        if (idadeValida == true)
                        {
                            Console.WriteLine($"Cadastro Aprovado!");
                        }
                        else
                        {
                            Console.WriteLine($"Cadastro Reprovado!");
                        }

                        Console.WriteLine(pf.pagarImposto(novaPf.rendimento).ToString("N2"));

                        break;

                    case "2":
                        // Instancia a Pessoa Juridica e Chama Metodo
                        PessoaJuridica pj = new PessoaJuridica();

                        // Para Receber valor / Atributos
                        PessoaJuridica novaPj = new PessoaJuridica();

                        Endereco endPj = new Endereco();

                        // Instanciando Endereco
                        endPj.logradouro = "Z";
                        endPj.numero = 34;
                        endPj.complemento = "Proximo ao Senai Presidente Dutra";
                        endPj.enderecoComercial = true;

                        novaPj.endereco = endPj;
                        novaPj.cnpj = "31235679230001";
                        novaPj.RazaoSocial = "Pessoa Juridica";
                        novaPj.rendimento = 5000;

                        // No Pessoa Fisica guardando no bool | Exemplo a baixo realizado direto
                        // Se for condiçao true nao precisa adiconar return true | Se for false no inicio da comparação adicionar o "!"
                        if (pj.ValidarCNPJ(novaPj.cnpj))
                        {
                            Console.WriteLine($"CNPJ iNVALIDO");
                        }
                        else
                        {
                            Console.WriteLine($"CNPJ Cadastrado com Sucesso");
                        };
                        Console.WriteLine(pj.pagarImposto(novaPj.rendimento).ToString("N2"));

                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine($"Obrigado Por Utilizar nosso sistema");

                        Console.ForegroundColor = ConsoleColor.DarkBlue;

                        Console.WriteLine($"Finalizando");
                        Thread.Sleep(500);

                        for (var adicionarDot = 0; adicionarDot < 10; adicionarDot++)
                        {
                            Console.Write($".");
                            Thread.Sleep(250);
                        }
                        Console.ResetColor();

                        break;

                    default:
                        Console.ResetColor();
                        Console.WriteLine($"Opção Inválida, por favor digite uma opção válida");
                        break;
                }

            } while (opcao != "0");

        }
        static void AdicionarDot(string textoCarregamento)
        {
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
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
