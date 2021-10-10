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
        }
    }
}
