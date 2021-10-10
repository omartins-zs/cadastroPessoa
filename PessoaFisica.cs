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
        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }
            // Pode ser excluido o else e apenas deixar o return false porque se nao entrar no if ja iria para o return 
            else
            {
                return false;
            }
        }
    }
}
