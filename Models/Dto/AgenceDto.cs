using System.ComponentModel.DataAnnotations;
using AutomotiveApi.Utility.Validators;

namespace AutomotiveApi.Models.Dto;

public class AgenceDto
{
    public int Id { get; set; }
    
    public string Name { get; set; }

    [Required(ErrorMessage = "le numéro de téléphone est obligatoire")]
    public string Tel { get; set; }

    [Required(ErrorMessage = "l'email est obligatoire")]
    [EmailAddress(ErrorMessage = "l'email n'est pas valide")]
    public string Email { get; set; }

    [Required(ErrorMessage = "l'adresse est obligatoire")]
    [MaxLength(100, ErrorMessage = "l'adresse ne doit pas dépasser 100 caractères")]
    public string Address { get; set; }

    [Required(ErrorMessage = "la ville est obligatoire")]
    [MaxLength(100, ErrorMessage = "la ville ne doit pas dépasser 100 caractères")]
    public string City { get; set; }

    [Required(ErrorMessage = "le code postal est obligatoire")]
    [MaxLength(50, ErrorMessage = "le code postal ne doit pas dépasser 50 caractères")]
    public string ZipCode { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }

    [Required(ErrorMessage = "la verification est obligatoire")]
    public bool IsVerified { get; set; }
    public int? ParentId { get; set; }

    [AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
    [MaxFileSize(1 * 1024 * 1024)]
    public IFormFile? Logo { get; set; }
}