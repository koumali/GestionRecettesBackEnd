using AutomotiveApi.Utility;
using Microsoft.AspNetCore.Authorization;

namespace AutomotiveApi.Services.Attributes;

public sealed class HasPermissionAttribute : AuthorizeAttribute
{
    public HasPermissionAttribute(PredefinedPermissions permission)
        : base(policy: permission.ToString())
    {
    }
}