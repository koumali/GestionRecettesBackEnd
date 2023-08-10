using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto;

public class MarqueDto
{
    [Required] [MaxLength(50)] public string Name { get; set; }
}