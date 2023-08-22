using System.ComponentModel.DataAnnotations;
using AutomotiveApi.Utility.Validators;

namespace AutomotiveApi.Models.Dto;

public class ClientDto
{


    public int Id { get; set; }

    [Required(ErrorMessage = "le prénom est obligatoire")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "le nom est obligatoire")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "le numéro de téléphone est obligatoire")]
    public string Tel { get; set; }

    [Required(ErrorMessage = "l'email est obligatoire")]
    [EmailAddress(ErrorMessage = "l'email n'est pas valide")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "la ville est obligatoire")]
    public string Ville { get; set; }

    public string? ZipCode { get; set; }
    public string? Adresse { get; set; }
    public string? Adresse2 { get; set; }

    [AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
    [MaxFileSize(1 * 1024 * 1024)]
    public IFormFile? PermisRecto { get; set; }

    [AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
    [MaxFileSize(1 * 1024 * 1024)]
    public IFormFile? PermisVerso { get; set; }
}