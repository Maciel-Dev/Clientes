using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cliente.Models
{
    public class Cons
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [ForeignKey("Endereço")]
        public int EnderecoId { get; set; }
        public virtual Endereço Endereço { get; set; }

        [ForeignKey("Genero")]
        public int GeneroId { get; set; }
        public virtual Genero Genero { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string? Cpf { get; set; }
    }
}
