using System.ComponentModel.DataAnnotations;

namespace automotiveApi.Models.Dto
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]        
        public string Password { get; set; }
    }
}