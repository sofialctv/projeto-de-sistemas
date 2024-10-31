using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroPessoas.Models
{
    public class Endereco
    {
        public int EnderecoId { get; private set; }
        public string? Logradouro { get; set; }
        public int Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }

        // Chave estrangeira para Pessoa
        public int PessoaId { get; set; }
        public Pessoa? Pessoa { get; set; }
    }
}
