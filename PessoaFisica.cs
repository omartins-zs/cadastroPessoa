using System;

namespace cadastroPessoa
{
    public class PessoaFisica : Pessoa
    {
        public string cpf { get; set; }

        public DateTime dataNascimento { get; set; }

        // Adicionando Polimorfismo
        public override double pagarImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento > 1500 && rendimento <= 5.000) // ou (rendimento <= 5000)
            {
                return rendimento * 0.03; // 1° Exemplo Para realizar calculo da porcentagem Multiplicação
            }
            else
            {
                return (rendimento / 100) * 5; // 2 Exemplo Divisão
            }
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
