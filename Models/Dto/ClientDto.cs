using AutomotiveApi.Utility.Validators;

namespace AutomotiveApi.Models.Dto
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Ville { get; set; }
        public string ZipCode { get; set; }
        public string Adresse { get; set; }
        public string Adresse2 { get; set; }
        [AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
        [MaxFileSize(1 * 1024 * 1024)]
        public IFormFile? PermisRecto { get; set; }

        [AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
        [MaxFileSize(1 * 1024 * 1024)]
        public IFormFile? PermisVerso { get; set; }
    }
}