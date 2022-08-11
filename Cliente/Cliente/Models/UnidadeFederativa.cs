using System.ComponentModel.DataAnnotations;

namespace Cliente.Models
{
    public class UnidadeFederativa
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Sigla { get; set; }

        /*Acrescentar FK*/

    }
}
