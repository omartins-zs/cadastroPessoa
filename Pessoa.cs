namespace cadastroPessoa
{
    public abstract class Pessoa
    {
        public string nome { get; set; }

        // Adicionando Composição
        public Endereco endereco { get; set; }

        public abstract void pagarImposto(float salario);

    }
}