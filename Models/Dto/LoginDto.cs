using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto;

public class LoginDto
{
    [Required (ErrorMessage = "l'email est obligatoire")]
    [EmailAddress (ErrorMessage = "l'email n'est pas valide")]
    [MaxLength(50 , ErrorMessage = "l'email ne doit pas dépasser 50 caractères")]
    public string Email { get; set; }

    [Required (ErrorMessage = "le mot de passe est obligatoire")]
    [MaxLength(100 , ErrorMessage = "le mot de passe ne doit pas dépasser 100 caractères")]
    public string Password { get; set; }
}