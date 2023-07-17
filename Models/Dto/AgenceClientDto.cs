using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto;

public class AgenceClientDto
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    public string Tel { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
}