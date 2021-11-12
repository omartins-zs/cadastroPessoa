using System;
using System.Collections.Generic;
using System.Threading;

namespace cadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PessoaFisica> listaPf = new List<PessoaFisica>();


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
|==========================================|
|       Escolha uma das opções abaixo      |
|------------------------------------------|
|             Pessoa Fisica                |                   
|    1 - Cadastrar Pessoa Fisica           |
|    2 - Listar Pessoa Fisica              |
|    3 - Remover Pessoa Fisica             |
|__________________________________________|
|             Pessoa Juridica              |
|    4 - Cadastrar Pessoa Juridica         |
|    5 - Listar Pessoa Juridica            |
|    6 - Remover Pessoa Juridica           |
|                                          |
|    0 - Sair                              |
|==========================================|
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

                        Console.WriteLine($"Digite seu Logradouro");
                        endPf.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o numero");
                        endPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite seu complemento (aperte ENTER para vazio)");
                        endPf.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereco é comercial S/N");
                        string enderecoComercial = Console.ReadLine().ToUpper();

                        if (enderecoComercial == "S")
                        {
                            endPf.enderecoComercial = true;
                        }
                        else
                        {
                            endPf.enderecoComercial = false;
                        }


                        // Instanciando Pessoa
                        novaPf.endereco = endPf;

                        Console.WriteLine($"Digite seu CPF (somente numeros)");
                        novaPf.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite seu Nome");
                        novaPf.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite sua data de nascimento EX: AAAA-MM-DD");
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        // Instanciando o rendimento
                        Console.WriteLine($"Digite o valor do seu rendimento mensal (somente numeros)");
                        novaPf.dataNascimento = DateTime.Parse(Console.ReadLine());

                        // Usando a funçao de validar data | Passo a Passo
                        bool idadeValida = novaPf.ValidarDataNascimento(novaPf.dataNascimento);
                        // Console.WriteLine(idadeValida);

                        if (idadeValida == true)
                        {
                            Console.WriteLine($"Cadastro Aprovado!");
                            listaPf.Add(novaPf);
                            Console.WriteLine(pf.pagarImposto(novaPf.rendimento).ToString("N2"));
                        }
                        else
                        {
                            Console.WriteLine($"Cadastro Reprovado!");
                        }

                        break;

                    case "2":
                        foreach (var cadaItem in listaPf)
                        {
                            Console.WriteLine($"{cadaItem.nome}, {cadaItem.cpf},{cadaItem.endereco.logradouro}");
                        }
                        break;

                    case "3":
                        Console.WriteLine($"Digite o CPF que deseja remover");
                        string cpfProcurado = Console.ReadLine();

                        PessoaFisica pessoaEncontrada = listaPf.Find(cadaItem => cadaItem.cpf == cpfProcurado);

                        if (pessoaEncontrada != null)
                        {
                            listaPf.Remove(pessoaEncontrada);
                            Console.WriteLine($"Cadastro Removido");
                        }
                        else
                        {
                            Console.WriteLine($"CPF não encontrado");
                        }
                        break;

                    case "4":
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
