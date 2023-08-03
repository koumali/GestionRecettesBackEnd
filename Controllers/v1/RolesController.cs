using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Param;
using AutomotiveApi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace AutomotiveApi.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]



    [HasPermission(PredefinedPermissions.Roles)]
    public class RolesController : ControllerBase
    {
        private readonly IRole _roleService;



        public RolesController(IRole roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Role>>> GetRoles()
        {
            
            var roles = await _roleService.GetAllAsync();
            return Ok(roles);
        }

        [HttpGet("agence")]
        
        public async Task<ActionResult<IEnumerable<Role>>> GetRolesAgence()
        {
            int idAgence = int.Parse(User.FindFirst("idAgence")?.Value ?? "0");
            var roles = await _roleService.GetRolesAgence(idAgence);
            return Ok(roles);
        }
        [HttpPost]

        public async Task<ActionResult<Role?>> AddRole(RoleDto request)
        {            
            try
            {
                int idAgence = int.Parse(User.FindFirst("idAgence")?.Value ?? "0");
                request.IdAgence = idAgence;
                var addedRole = await _roleService.CreateWithPermissionsAsync(request);
                return Ok(addedRole);
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }

        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Role>> GetRoleById(int id)
        {
            var role = await _roleService.GetByIdAsync(id);
            return Ok(role);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> DeleteRole(int id)
        {
            await _roleService.DeleteAsync(id);
            return Ok();
        }


        [HttpPut("{id}")]

        public async Task<ActionResult<Role>> UpdateRole(int id, RoleDto request)
        {
            if (id != request.Id)
            {
                return BadRequest(new { errors = "Id's do not match" });
            }

            int idAgence = int.Parse(User.FindFirst("idAgence")?.Value ?? "0");
            request.IdAgence = idAgence;

            var updatedRole = await _roleService.UpdateWithPermissionsAsync(request);

            return Ok(updatedRole);
        }
    }
}