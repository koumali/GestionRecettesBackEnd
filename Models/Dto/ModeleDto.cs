using System.ComponentModel.DataAnnotations;
using AutomotiveApi.Utility.Validators;

namespace AutomotiveApi.Models.Dto;

public class ModeleDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "le nom est obligatoire")]    
    public string Name { get; set; }

    [Required(ErrorMessage = "la marque est obligatoire")]
    public int IdMarque { get; set; }

    [AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
    [MaxFileSize(1 * 1024 * 1024)]
    public IFormFile? Image { get; set; }
}