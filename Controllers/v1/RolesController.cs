using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Jwt;
using AutomotiveApi.Services.Param;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class RolesController : ControllerBase
    {
        private readonly IJwt _jwtService;
        private readonly IRole _roleService;


        public RolesController(IUser userService, IJwt jwtService, IRole roleService)
        {
            _jwtService = jwtService;
            _roleService = roleService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult<IEnumerable<Role>> GetRoles()
        {
            var roles = _roleService.getRoles();
            return Ok(roles);
        }
        //<summary>
        //Add role
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Role> AddRole(RoleDto request)
        {
            var role = new Role()
            {
                Name = request.Name
            };
            var addedRole = _roleService.add(role);
            return Ok(addedRole);
        }

        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Role> GetRoleById(int id)
        {
            var role = _roleService.findById(id);
            return Ok(role);
        }

        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteRole(int id)
        {
            _roleService.delete(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Role> UpdateRole(int id, RoleDto request)
        {
            var role = _roleService.findById(id);
            if (role == null)
            {
                return NotFound();
            }

            // Update the role properties
            role.Name = request.Name;

            var updatedRole = _roleService.update(role);
            return Ok(updatedRole);
        }
    }
}