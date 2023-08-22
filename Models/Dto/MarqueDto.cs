using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto;

public class MarqueDto
{
    [Required(ErrorMessage = "le nom est obligatoire")]
    [MaxLength(50, ErrorMessage = "le nom ne doit pas dépasser 50 caractères")]
    public string Name { get; set; }
}