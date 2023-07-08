using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Param;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUser _userService;
        private readonly IMapper _mapper;


        public UsersController(IUser userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }


        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _userService.GetAllAsync();
            return Ok(users);
        }

        [HttpGet("{idAgence}")]
        [Authorize(Roles = "Gerant")]
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
        [HttpGet("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            return Ok(user);
        }

        //add user
        [HttpPost("")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<User>> Add(UserDto userRequest)
        {
            var user = _mapper.Map<User>(userRequest);
            try
            {
                var newUser = await _userService.CreateAsync(user);
                return Ok(newUser);
            }
            catch (Exception ex)
            {
                // add message to errors list
                return BadRequest(new { errors = ex.Message });
            }
        }

        //update user
        [HttpPut("")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<User>> Update(UserUpdateDto userRequest)
        {
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
        [Authorize(Roles = "Admin")]
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
        [HttpPut("updatepassword")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> ChangePassword(PasswordUpdateDto changePasswordDto)
        {
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