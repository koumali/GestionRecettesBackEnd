using System.ComponentModel.DataAnnotations;

namespace automotiveApi.Models.Dto
{
    public class UserUpdateDto
    {

        [Required]
        public int id { get; set; }

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
        public bool? is_active { get; set; }

        [Required]
        public int id_role { get; set; }

        public int? id_agence { get; set; }
    }
}