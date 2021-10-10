using System;

namespace cadastroPessoa
{
    public class PessoaFisica : Pessoa
    {
        public string cpf { get; set; }

        public DateTime dataNascimento { get; set; }

        // Adicionando Polimorfismo
        public override void pagarImposto(float salario)
        {

        }
    }
}
