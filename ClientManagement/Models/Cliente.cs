using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientManagement.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefone { get; set; }
        public DateOnly DataCadastro { get; set; }
        [ForeignKey(nameof(Id))]
        [Required]
        public int TipoPessoa { get; set; }
        [Required]
        public string Documento { get; set; }
        public string InscricaoEstadual { get; set; }
        [Required]
        public bool Isento { get; set; }
        [Required]
        private string HashSenha { get; set; }
        [Required]
        public bool Bloqueado { get; set; }
    }

    public class PessoaFisica
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey(nameof(Id))]
        [Required]
        public string Cliente { get; set; }
        [ForeignKey(nameof(Id))]
        public int Genero { get; set; }
        public DateOnly Nascimento { get; set; }

    }

    public class Genero
    {
        [Key]
        public int Id { get; set; }
        public int NomeGenero { get; set; }
    }

    public class TipoPessoa
    {
        [Key]
        public int Id { get; set; }
        public int NomeTipo { get; set; }
    }
}
