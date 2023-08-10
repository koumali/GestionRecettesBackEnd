using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Param;
using AutomotiveApi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace AutomotiveApi.Controllers.v1;

[ApiController]
[Route("api/v1/[controller]")]
[HasPermission(PredefinedPermissions.Permissions)]
public class PermissionsController : ControllerBase
{
    private readonly IPermissionService _permissionService;


    public PermissionsController(IPermissionService permissionService)
    {
        _permissionService = permissionService;
    }


    [HttpGet]
    [Authorize(Roles = nameof(predefinedRoles.SuperAdmin))]
    public async Task<ActionResult<IEnumerable<Permission>>> GetPermissions()
    {
        var permissions = await _permissionService.GetAllAsync();
        return Ok(permissions);
    }

    [HttpGet("agence")]
    public async Task<ActionResult<IEnumerable<Permission>>> GetPermissionsAgence()
    {
        var permissions = await _permissionService.GetPermissionsAgence();
        return Ok(permissions);
    }
}