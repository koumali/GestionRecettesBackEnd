using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto;

public class UserDto
{
    [Required] [MaxLength(50)] public string FirstName { get; set; }

    [Required] [MaxLength(50)] public string LastName { get; set; }

    [Required] [EmailAddress] public string Email { get; set; }

    [Required] [MinLength(6)] public string Password { get; set; }


    [Required] public bool? IsActive { get; set; }

    [Required] public int IdRole { get; set; }

    public int? IdAgence { get; set; }
}