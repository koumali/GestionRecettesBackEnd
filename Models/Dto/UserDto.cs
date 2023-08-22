using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto;

public class UserDto
{
    [Required(ErrorMessage = "le prénom est obligatoire")]
    [MaxLength(50, ErrorMessage = "le prénom ne doit pas dépasser 50 caractères")]
    public string FirstName { get; set; }



    [Required(ErrorMessage = "le nom est obligatoire")]
    [MaxLength(50, ErrorMessage = "le nom ne doit pas dépasser 50 caractères")]
    public string LastName { get; set; }


    [Required(ErrorMessage = "l'email est obligatoire")]
    [EmailAddress(ErrorMessage = "l'email n'est pas valide")]
    public string Email { get; set; }

    [Required(ErrorMessage = "le mot de passe est obligatoire")]
    [MinLength(6, ErrorMessage = "le mot de passe doit contenir au moins 6 caractères")]
    public string Password { get; set; }


    public bool? IsActive { get; set; }

    [Required(ErrorMessage = "le rôle est obligatoire")]
    public int IdRole { get; set; }

    public int? IdAgence { get; set; }
}