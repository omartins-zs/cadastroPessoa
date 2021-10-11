using System;

namespace cadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usado apenas para chamar os objetos
            PessoaFisica pf = new PessoaFisica();

            // Para criar novo Endereço e Pessoa
            PessoaFisica novaPf = new PessoaFisica();
            Endereco end = new Endereco();

            // Instanciando Endereco
            end.logradouro = "Z";
            end.numero = 34;
            end.complemento = "Proximo ao Senai Presidente Dutra";
            end.enderecoComercial = false;
        
            // Instanciando Pessoa
            novaPf.endereco = end;
            novaPf.cpf = "32442342198";
            novaPf.nome = "Pessoa Fisica";
            novaPf.dataNascimento = new DateTime(2000, 06, 15);
        }
    }
}
