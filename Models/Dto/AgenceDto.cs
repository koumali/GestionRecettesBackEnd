using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto
{
    public class AgenceDto
    {
        [Required]
        [MaxLength(50)]
        public string name { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zip_code { get; set; }
        public Double latitude { get; set; }
        public Double longitude { get; set; }
    }
}