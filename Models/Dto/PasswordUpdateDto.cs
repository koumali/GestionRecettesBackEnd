using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto
{
    public class PasswordUpdateDto
    {
        [Required]
        public int id { get; set; }

        [Required]
        [MinLength(8)]
        public string newPassword { get; set; }

        [Required]
        [Compare("newPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string confirmPassword { get; set; }

    }
}