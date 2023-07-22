using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto
{
    public class AgenceDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsVerified { get; set; }
    }
}