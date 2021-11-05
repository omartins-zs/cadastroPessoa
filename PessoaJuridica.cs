namespace cadastroPessoa
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj { get; set; }

        public string RazaoSocial { get; set; }

        // Adicionando Polimorfismo
        public override double pagarImposto(float rendimento)
        {
            if (rendimento <= 5000)
            {
                return rendimento * .06;
            }
            else if (rendimento > 5000 && rendimento <= 10000) // ou (rendimento <= 5000)
            {
                return rendimento * 0.08; // 1° Exemplo Para realizar calculo da porcentagem 
            }
            else
            {
                return (rendimento / 100) * 10; // 2° Exemplo
            }
        }
        public bool ValidarCNPJ(string cnpj)
        {
            if (cnpj.Length == 14 && cnpj.Substring(cnpj.Length - 6, 4) == "0001")
            {
                return true;
            }
            return false;
        }
    }
}