namespace cadastroPessoa
{
    public abstract class Pessoa
    {
        public string nome { get; set; }

        // Adicionando Composição
        public Endereco endereco { get; set; }

        // Adicionando Atributo para o Metodo pagarImposto | Encontro Remoto 6
        public float rendimento { get; set; }

        public abstract double pagarImposto(float salario);

    }
}