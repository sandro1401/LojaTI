using System.ComponentModel.DataAnnotations;

namespace LojaTI.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Display(Name = "Nome Completo")]
        [Required]
        [MinLength(2), MaxLength(30)]
        public string Nome { get; set; }
        [Display(Name = "Data de Aniversário")]
        public DateTime DataAniv { get; set; }
        [EmailAddress]
        [MinLength(6, ErrorMessage = "Insira um email com mais caracteres")]
        [MaxLength(30, ErrorMessage = "Email muito lomgo")]
        public string Email { get; set; }
        public int Telefone { get; set; }
        public string Endereco { get; set; }
        public int Cpf { get; set; }
    }
}
