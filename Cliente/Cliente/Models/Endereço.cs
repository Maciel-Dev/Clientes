using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cliente.Models
{
    public class Endereço
    {
        [Required]
        public int Id { get; set; }

        [MaxLength(128)]
        public string Logradouro { get; set; }

        [MaxLength(125)]
        public string Bairro { get; set; }

        [MaxLength(128)]
        public string Localidade { get; set; }

        [MaxLength(128)]
        public string Numero { get; set; }

        [MaxLength(128)]
        public string Cep { get; set; }
        /*Add FK*/

        [ForeignKey("UnidadeFederativa")]
        public int UfId { get; set; }
        public virtual UnidadeFederativa UnidadeFederativa { get; set; }
        
    }
}
