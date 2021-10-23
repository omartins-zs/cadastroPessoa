using System;

namespace cadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usado apenas para chamar os objetos
            //     PessoaFisica pf = new PessoaFisica();

            //     // Para criar novo Endereço e Pessoa
            //     PessoaFisica novaPf = new PessoaFisica();
            //     Endereco end = new Endereco();

            //     // Instanciando Endereco
            //     end.logradouro = "Z";
            //     end.numero = 34;
            //     end.complemento = "Proximo ao Senai Presidente Dutra";
            //     end.enderecoComercial = false;

            //     // Instanciando Pessoa
            //     novaPf.endereco = end;
            //     novaPf.cpf = "32442342198";
            //     novaPf.nome = "Pessoa Fisica";
            //     novaPf.dataNascimento = new DateTime(2000, 06, 15);

            //     // // Mostrar no terminal
            //     // Console.WriteLine(novaPf.endereco.logradouro);

            //     // // Interpolação
            //     // Console.WriteLine($"Rua: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}");

            //     // // Concatenaçao
            //     // Console.WriteLine("Rua:" + novaPf.endereco.logradouro + ", " + novaPf.endereco.numero);

            //     // // Sem pular linha
            //     // Console.WriteLine(novaPf.endereco.logradouro);

            //     // // Mostrar varios comandos no mesmo console (Mostra como voce deixa no codigo)
            //     // Console.WriteLine($@"Rua: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}");

            //     // Usando a funçao de validar data | Passo a Passo
            //     bool idadeValida = novaPf.ValidarDataNascimento(novaPf.dataNascimento);
            //     // Console.WriteLine(idadeValida);

            //     // // Usando a funçao de validar data | Metodo Direto
            //     // Console.WriteLine(novaPf.ValidarDataNascimento(novaPf.dataNascimento));

            //     if (idadeValida == true)
            //     {
            //         Console.WriteLine($"Cadastro Aprovado!");
            //     }
            //     else
            //     {
            //         Console.WriteLine($"Cadastro Reprovado!");
            //     } 

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // Instancia a Pessoa Juridica e Chama Metodo
            PessoaJuridica pj = new PessoaJuridica();

            // Para Receber valor / Atributos
            PessoaJuridica novaPj = new PessoaJuridica();

            Endereco end = new Endereco();

            // Instanciando Endereco
            end.logradouro = "Z";
            end.numero = 34;
            end.complemento = "Proximo ao Senai Presidente Dutra";
            end.enderecoComercial = true;

            novaPj.endereco = end;
            novaPj.cnpj = "31235623000179";
            novaPj.RazaoSocial = "Pessoa Juridica";

            // No Pessoa Fisica guardando no bool | Exemplo a baixo realizado direto
            // Se for condiçao true nao precisa adiconar return true | Se for false no inicio da comparação adicionar o "!"
            if (pj.ValidarCNPJ(novaPj.cnpj))
            {
                Console.WriteLine($"CNPJ Válido");
            }
            else
            {
                Console.WriteLine($"CNPJ iNVALIDO");
            };
        }
    }
}
