using automotiveApi.DAL;
using automotiveApi.Models;
using automotiveApi.Models.Dto;
using automotiveApi.Services.Auth;
using automotiveApi.Services.Jwt;
using automotiveApi.Services.Param;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace automotiveApi.Controllers.v1
{

    [ApiController]

    [Route("api/v1/[controller]")]

    public class UsersController : ControllerBase
    {
        private readonly IUser _userService;
        private readonly IJwt _jwtService;


        public UsersController(IUser userService, IJwt jwtService)
        {
            _jwtService = jwtService;
            _userService = userService;
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

        [HttpGet("myprofile")]
        [Authorize(Roles = "Admin, Client")]
        public ActionResult<User> GetMyProfile()
        {
            var user= _userService.findById(_jwtService.getUserId());
            return Ok(user);
        }


    }


}