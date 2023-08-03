using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Jwt;
using AutomotiveApi.Services.Param;
using AutomotiveApi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace AutomotiveApi.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]

    [HasPermission(PredefinedPermissions.Users)]
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
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _userService.GetAllAsync();
            return Ok(users);
        }

        [HttpGet("agence/{idAgence}")]       
        [ValidatIdAgence("idAgence")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsersAgence(int idAgence)
        {
            var users = await _userService.GetUsersAgence(idAgence);
            return Ok(users);
        }

      
        [HttpGet("{id}")]        
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            return Ok(user);
        }

        
        [HttpPost]       
        public async Task<ActionResult<User>> Add(UserDto userRequest)
        {
            var user = _mapper.Map<User>(userRequest);
            try
            {
                var newUser = await _userService.CreateAsync(user);
                return newUser;
            }
            catch (Exception ex)
            {
                // add message to errors list
                return BadRequest(new { errors = ex.Message });
            }
        }

        //update user
        [HttpPut("{id}")]
       
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