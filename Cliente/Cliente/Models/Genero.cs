using System.ComponentModel.DataAnnotations;

namespace Cliente.Models
{
    public class Genero
    {
        [Required]
        [Key]
        public int Id { get; set; }


        [MaxLength(5)]
        public string Gender { get; set; }
    }
}
