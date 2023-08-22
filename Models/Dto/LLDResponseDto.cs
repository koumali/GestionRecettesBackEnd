using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto;

public class LLDResponseDto
{

    [Required(ErrorMessage = "le prix est obligatoire")]
    public int prix { get; set; }
    
    public string? title { get; set; }

    [Required(ErrorMessage = "la description est obligatoire")]
    public string description { get; set; }    
    public int idAgence { get; set; }
    public int idLongTermRental { get; set; }
    public bool isAgence { get; set; }
    public IFormFile?[] files { get; set; }
}