using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto
{
    public class PasswordResetDto
    {


        public string Token { get; set; }
        public string NewPassword { get; set; }

        [Compare("NewPassword", ErrorMessage = "les mots de passe ne correspondent pas")]
        public string ConfirmPassword { get; set; }
    }

    public class PasswordRestTokenRequest
    {
        public string Email { get; set; }
    }
}