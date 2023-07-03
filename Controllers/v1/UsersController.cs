using AutoMapper;
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
    public class UsersController : ControllerBase
    {
        private readonly IUser _userService;
        private readonly IJwt _jwtService;
        private readonly IMapper _mapper;


        public UsersController(IUser userService, IJwt jwtService, IMapper mapper)
        {
            _jwtService = jwtService;
            _userService = userService;
            _mapper = mapper;
        }


        [HttpGet("")]
        [Authorize(Roles = "Admin")]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _userService.getUsers();
            return Ok(users);
        }

        //<summary>
        //Get user by id
        //testing
        //</summary>

        //get user by id
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<User> GetUserById(int id)
        {
            var user = _userService.findById(id);
            return Ok(user);
        }

        //add user
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult<User> Add(UserDto userRequest)
        {
            var user = _mapper.Map<User>(userRequest);
            try
            {
                var newUser = _userService.add(user);
                return CreatedAtAction(nameof(GetUserById), new { id = newUser.id }, newUser);
            }
            catch (System.Exception ex)
            {
                // add message to errors list
                return BadRequest(new { message = ex.Message });
            }
        }

        //update user

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public ActionResult<User> Update(UserUpdateDto userRequest)
        {
            var user = _mapper.Map<User>(userRequest);

            try
            {
                var updatedUser = _userService.update(user);
                return Ok(updatedUser);
            }
            catch (System.Exception ex)
            {
                // add message to errors list
                return BadRequest(new { message = ex.Message });
            }
        }

        //delete user

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<User> Delete(int id)
        {
            try
            {
                var user = _userService.delete(id);
                return user;
            }
            catch (System.Exception ex)
            {
                // add message to errors list
                return BadRequest(new { message = ex.Message });
            }
        }

        //change password
        [HttpPut("updatepassword")]
        [Authorize(Roles = "Admin")]
        public ActionResult<User> ChangePassword(PasswordUpdateDto changePasswordDto)
        {
            try
            {
                var user = _userService.changePassword(changePasswordDto.id, changePasswordDto.newPassword);
                return Ok(user);
            }
            catch (System.Exception ex)
            {
                // add message to errors list
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}