using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto;

public class PasswordUpdateDto
{
    [Required] public int Id { get; set; }

    [Required] [MinLength(8)] public string NewPassword { get; set; }

    [Required]
    [Compare("NewPassword", ErrorMessage = "les mots de passe ne correspondent pas")]
    public string ConfirmPassword { get; set; }
}