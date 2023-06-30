using System.ComponentModel.DataAnnotations;

namespace automotiveApi.Models.Dto
{
    public class MarqueDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}