using System.ComponentModel.DataAnnotations;

namespace automotiveApi.Models.Dto
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }
    }
}