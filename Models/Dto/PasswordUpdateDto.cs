using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto;

public class PasswordUpdateDto
{
    [Required(ErrorMessage = "l'id est obligatoire")]
    public int Id { get; set; }

    [Required(ErrorMessage = "le mot de passe est obligatoire")]
    [MinLength(8, ErrorMessage = "le mot de passe doit contenir au moins 8 caractères")]
    public string NewPassword { get; set; }

    [Required(ErrorMessage = "le mot de passe est obligatoire")]
    [Compare("NewPassword", ErrorMessage = "les mots de passe ne correspondent pas")]
    public string ConfirmPassword { get; set; }
}