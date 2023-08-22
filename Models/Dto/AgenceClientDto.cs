using AutomotiveApi.Utility.Validators;
using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto;

public class AgenceClientDto
{
    [Required(ErrorMessage = "le nom est obligatoire")]
    [MaxLength(50)]
    public string Name { get; set; }

    [Required(ErrorMessage = "le numéro de téléphone est obligatoire")]
    public string Tel { get; set; }

    [Required(ErrorMessage = "l'email est obligatoire")]
    [EmailAddress(ErrorMessage = "l'email n'est pas valide")]
    public string Email { get; set; }

    [Required(ErrorMessage = "l'adresse est obligatoire")]
    [MaxLength(100, ErrorMessage = "l'adresse ne doit pas dépasser 100 caractères")]

    public string Address { get; set; }
    
    [AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
    [MaxFileSize(1 * 1024 * 1024)]
    public IFormFile? Logo { get; set; }

}