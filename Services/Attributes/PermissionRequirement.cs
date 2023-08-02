using Microsoft.AspNetCore.Authorization;

namespace AutomotiveApi.Services.Attributes;

public class PermissionRequirement : IAuthorizationRequirement
{
    public PermissionRequirement(string permission)
    {
        Permission = permission;
    }
    public string Permission { get; set; }
}