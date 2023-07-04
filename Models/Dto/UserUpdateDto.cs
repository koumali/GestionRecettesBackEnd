using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto
{
    public class UserUpdateDto
    {

        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public bool? IsActive { get; set; }

        [Required]
        public int IdRole { get; set; }

        public int? IdAgence { get; set; }
    }
}