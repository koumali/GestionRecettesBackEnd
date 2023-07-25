using AutomotiveApi.Utility;
using Microsoft.AspNetCore.Authorization;

namespace AutomotiveApi.Services.Attributes;

public sealed class HasPermissionAttribute : AuthorizeAttribute
{
    public HasPermissionAttribute(Permission permission)
        : base(policy: permission.ToString())
    {
    }
}