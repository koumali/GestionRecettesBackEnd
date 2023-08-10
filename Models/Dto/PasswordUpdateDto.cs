using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto;

public class PasswordUpdateDto
{
    [Required] public int Id { get; set; }

    [Required] [MinLength(8)] public string NewPassword { get; set; }

    [Required]
    [Compare("newPassword", ErrorMessage = "The new password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }
}