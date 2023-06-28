using System.ComponentModel.DataAnnotations;

namespace automotiveApi.Models.Dto
{
    public class ModeleDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}