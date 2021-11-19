using System.IO;

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

        // Adicionando Verificacao de Criar arquivo
        public void VerificarArquiuvo(string caminho)
        {
            string pasta = caminho.Split("/")[0];

            // Verifica se existe a Pasta | "!" muda a condicao para false
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            // Verifica se existe o arquivo
            if (!File.Exists(caminho))
            {
                File.Create(caminho);
            }
        }
    }
}