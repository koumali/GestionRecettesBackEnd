using System.ComponentModel.DataAnnotations;

namespace automotiveApi.Models.Dto
{
    public class RegisterDto
    {
        [Required]
        [StringLength(50)]
        public string first_name { get; set; }

        [Required]
        [StringLength(50)]
        public string last_name { get; set; }

        [Required]
        [EmailAddress]

        public string email { get; set; }

        [Required]
        [StringLength(100)]
        public string password { get; set; }

        [Required]
        [StringLength(100)]
        public string confirm_password { get; set; }


        public bool? is_active { get; set; }

        [Required]
        public int id_role { get; set; }

        [Required]
        public int? id_agence { get; set; }
    }
}