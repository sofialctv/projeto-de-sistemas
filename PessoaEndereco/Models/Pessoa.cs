using System.Collections.Generic;

namespace CadastroPessoas.Models
{
    public class Pessoa
    {
        public int PessoaId { get; private set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Email { get; set; }

        // Relacionamento com Endereço
        public ICollection<Endereco> Enderecos { get; set; } = new List<Endereco>();
    }
}