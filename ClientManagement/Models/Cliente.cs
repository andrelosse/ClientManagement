using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientManagement.Models
{
    public class Cliente
    {
        [Key]
        [ScaffoldColumn(false)]
        [HiddenInput]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Nome é um campo obrigatório.")]
        [Display(Name = "Nome Completo")]
        [MaxLength(150, ErrorMessage = "O nome deve conter no máximo 150 caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "E-mail é um campo obrigatório.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        [MaxLength(150, ErrorMessage = "O e-mail deve conter no máximo 150 caracteres.")]
        public string Email { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Telefone é um campo obrigatório")]
        [MaxLength(11, ErrorMessage = "O telefone deve conter no máximo 11 caracteres.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Por favor, insira apenas números.")]
        [DataType(DataType.PhoneNumber)]
        public PhoneAttribute Telefone { get; set; }

        [Required(ErrorMessage = "Data de cadastro é um campo obrigatório.")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateOnly DataCadastro { get; set; }

        [Display(Name = "Tipo de Pessoa")]
        [Required(ErrorMessage = "Tipo de Pessoa é um campo obrigatório.")]
        [ForeignKey("TipoPessoaId")]
        [Range(1, 2)]
        public TipoPessoa TipoPessoaId { get; set; }

        [Display(Name = "CPF ou CNPJ")]
        [Required(ErrorMessage = "Documento é um campo obrigatório.")]
        [MaxLength(14, ErrorMessage = "O documento deve conter no máximo 14 caracteres.")]
        public string Documento { get; set; }

        [Display(Name = "Inscrição Estadual")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Por favor, insira apenas números.")]
        [MaxLength(12, ErrorMessage = "A inscrição deve conter no máximo 12 caracteres.")]
        public string InscricaoEstadual { get; set; }

        [Display(Name = "É isento?")]
        [Required(ErrorMessage = "Isenção é um campo obrigatório.")]
        public bool Isento { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Senha é um campo obrigatório.")]
        [MinLength(8, ErrorMessage = "A senha deve conter no mínimo 8 caracteres.")]
        [MaxLength(15, ErrorMessage = "A senha deve conter no máximo 15 caracteres.")]
        [ScaffoldColumn(false)]
        [DataType(DataType.Password)]
        private string Senha { get; set; }

        [Display(Name = "Confirme a senha")]
        [Required(ErrorMessage = "Confirme a senha.")]
        [MinLength(8, ErrorMessage = "A senha deve conter no mínimo 8 caracteres.")]
        [MaxLength(15, ErrorMessage = "A senha deve conter no máximo 15 caracteres.")]
        [Compare("Senha", ErrorMessage = "As senhas não conferem.")]
        [ScaffoldColumn(false)]
        [DataType(DataType.Password)]
        private string ConfirmaSenha { get; set; }

        [Display(Name = "Usuário bloqueado?")]
        [Required(ErrorMessage = "Bloqueado é um campo obrigatório.")]
        public bool Bloqueado { get; set; }

    }

    public class PessoaFisica
    {
        [Key]
        [HiddenInput]
        [ScaffoldColumn(false)]
        public int PessoaFisicaId { get; set; }

        [ForeignKey("ClienteId")]
        [Required]
        [ScaffoldColumn(false)]
        public Cliente ClienteId { get; set; }

        [ForeignKey("GeneroId")]
        [Display(Name = "Gênero")]
        [Range(1, 3)]
        public Genero GeneroId { get; set; }

        [Required(ErrorMessage = "Data de nascimento é um campo obrigatório.")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateOnly Nascimento { get; set; }

    }

    public class Genero
    {
        [Key]
        public int GeneroId { get; set; }
        public int NomeGenero { get; set; }
    }

    public class TipoPessoa
    {
        [Key]
        public int TipoPessoaId { get; set; }
        public int NomeTipo { get; set; }
    }
}
