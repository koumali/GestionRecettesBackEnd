using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto
{
    public class ChangePasswordDto
    {
        [Required (ErrorMessage = "le mot de passe actuel est obligatoire")]
        public string CurrentPassword { get; set; }
        
        [Required (ErrorMessage = "le nouveau mot de passe est obligatoire")]
        public string NewPassword { get; set; }

        [Compare("NewPassword", ErrorMessage = "les mots de passe ne correspondent pas")]
        public string ConfirmPassword { get; set; }
    }
}