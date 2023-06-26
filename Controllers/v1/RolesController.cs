using automotiveApi.Models;
using automotiveApi.Services.Jwt;
using automotiveApi.Services.Param;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace automotiveApi.Controllers.v1
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
        public async Task<ActionResult<IEnumerable<Role>>> GetRoles()
        {
            var roles = await _roleService.getRoles();
            return Ok(roles);
        }
    }

}