using AutomotiveApi.Utility.Validators;

namespace AutomotiveApi.Models.Dto;

public class ModeleDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int IdMarque { get; set; }

    [AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
    [MaxFileSize(1 * 1024 * 1024)]
    public IFormFile? Image { get; set; }
}