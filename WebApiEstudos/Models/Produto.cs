using System.ComponentModel.DataAnnotations;

namespace WebApiEstudos.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        [StringLength(70, ErrorMessage = "O nome do produto deve ter no máximo 70 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O preço do produto é obrigatório.")]
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }
}
