using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Param;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class RolesController : ControllerBase
    {
        private readonly IRole _roleService;


        public RolesController(IRole roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<Role>>> GetRoles()
        {
            var roles = await _roleService.GetAllAsync();
            return Ok(roles);
        }
        
        [HttpGet("agence/{idAgence}")]
        [Authorize(Roles = "Gerant")]
        public async Task<ActionResult<IEnumerable<Role>>> GetRolesAgence(int idAgence)
        {
            var roles = await _roleService.GetRolesAgence(idAgence);
            return Ok(roles);
        }
        //<summary>
        //Add role
        //</summary>

        [HttpPost]
        [Authorize(Roles = "Admin, Gerant")]
        public async Task<ActionResult<Role>> AddRole(RoleDto request)
        {
            var role = new Role()
            {
                Name = request.Name
            };
            var addedRole = await _roleService.CreateAsync(role);
            return Ok(addedRole);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin, Gerant")]
        public async Task<ActionResult<Role>> GetRoleById(int id)
        {
            var role = await _roleService.GetByIdAsync(id);
            return Ok(role);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin, Gerant")]
        public async Task<ActionResult> DeleteRole(int id)
        {
            await _roleService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin, Gerant")]
        public async Task<ActionResult<Role>> UpdateRole(int id, RoleDto request)
        {
            var role = await _roleService.GetByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }

            // Update the role properties
            role.Name = request.Name;
            role.Id = id;
            var updatedRole = await _roleService.UpdateAsync(role);
            return Ok(updatedRole);
        }
    }
}