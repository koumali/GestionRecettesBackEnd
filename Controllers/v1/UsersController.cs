using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Jwt;
using AutomotiveApi.Services.Param;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Permission = AutomotiveApi.Utility.Permission;

namespace AutomotiveApi.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUser _userService;
        private readonly IMapper _mapper;
        public static IJwt _jwt;

        public UsersController(IUser userService, IMapper mapper, IJwt jwt)
        {
            _userService = userService;
            _mapper = mapper;
            _jwt = jwt;
        }


        [HttpGet]
        [HasPermission(Permission.PlatformTopLevelPermission)]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _userService.GetAllAsync();
            return Ok(users);
        }

        [HttpGet("agence/{idAgence}")]
        [HasPermission(Permission.AgencyFirstLevelPermission)]
        [ValidatIdAgence("idAgence")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsersAgence(int idAgence)
        {
            var users = await _userService.GetUsersAgence(idAgence);
            return Ok(users);
        }

        //<summary>
        //Get user by id
        //testing
        //</summary>

        //get user by id
        [HttpGet("{id}")]
        // [Authorize(Roles = "Admin, Gerant")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            return Ok(user);
        }

        //add user
        [HttpPost]
        [HasPermission(Permission.AgencyFirstLevelPermission)]
        public async Task<ActionResult<User>> Add(UserDto userRequest)
        {
            var user = _mapper.Map<User>(userRequest);
            try
            {
                var newUser = await _userService.CreateAsync(user);
                return CreatedAtAction(nameof(GetUserById), new { id = newUser.Id }, newUser);
            }
            catch (Exception ex)
            {
                // add message to errors list
                return BadRequest(new { errors = ex.Message });
            }
        }

        //update user
        [HttpPut("{id}")]
        [HasPermission(Permission.AgencyFirstLevelPermission)]
        public async Task<ActionResult<User>> Update(int id, UserUpdateDto userRequest)
        {
            if (id != userRequest.Id)
            {
                return BadRequest(new { errors = "Invalid user id" });
            }

            var user = _mapper.Map<User>(userRequest);

            try
            {
                var updatedUser = await _userService.UpdateAsync(user);
                return Ok(updatedUser);
            }
            catch (Exception ex)
            {
                // add message to errors list
                return BadRequest(new { errors = ex.Message });
            }
        }

        //delete user

        [HttpDelete("{id}")]
        [HasPermission(Permission.AgencyFirstLevelPermission)]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            try
            {
                var user = await _userService.DeleteAsync(id);
                return user;
            }
            catch (Exception ex)
            {
                // add message to errors list
                return BadRequest(new { errors = ex.Message });
            }
        }

        //change password
        [HttpPut("{id}/password")]
        [HasPermission(Permission.AgencyFirstLevelPermission)]
        public async Task<ActionResult> ChangePassword(int id,PasswordUpdateDto changePasswordDto)
        {
            if (id != changePasswordDto.Id)
            {
                return BadRequest(new { errors = "Invalid user id" });
            }
            
            try
            {
                var isChanged = await _userService.changePassword(changePasswordDto.Id, changePasswordDto.NewPassword);
                if (isChanged)
                {
                    return Ok(new { message = "Password changed successfully" });
                }

                return BadRequest(new { message = "Password not changed" });
            }
            catch (Exception ex)
            {
                // add message to errors list
                return BadRequest(new { errors = ex.Message });
            }
        }
    }
}