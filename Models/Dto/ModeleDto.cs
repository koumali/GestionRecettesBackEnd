using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto
{
    public class ModeleDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int IdMarque { get; set; }
    }
}