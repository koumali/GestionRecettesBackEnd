using AutomotiveApi.Utility.Validators;
using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto;

public class AgenceClientDto
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    public string Tel { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    [AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
    [MaxFileSize(1 * 1024 * 1024)]
    public IFormFile? Logo { get; set; }

}