using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto
{
    public class ClientDto
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Ville { get; set; }
        public string ZipCode { get; set; }
        public string Adresse { get; set; }
        public string Adresse2 { get; set; }
        public string PermisRecto { get; set; }
        public string PermisVerso { get; set; }
    }
}