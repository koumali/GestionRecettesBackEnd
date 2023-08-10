using System.ComponentModel.DataAnnotations;
using AutomotiveApi.Utility;

namespace AutomotiveApi.Models.Dto;

public class RoleDto
{
    public int? Id { get; set; }

    [RoleNameValidator] public string Name { get; set; }

    public int? IdAgence { get; set; }

    public List<int>? SelectedPermissionIds { get; set; }
}

// validate name
public class RoleNameValidator : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var roleDto = (RoleDto)validationContext.ObjectInstance;
        if (roleDto.Name == predefinedRoles.SuperAdmin.ToString())
        {
            return new ValidationResult("Le nom du rôle est réservé");
        }

        return ValidationResult.Success;
    }
}