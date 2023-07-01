using automotiveApi.DAL;
using automotiveApi.Models;
using automotiveApi.Models.Dto;
using automotiveApi.Services.Auth;
using Microsoft.AspNetCore.Mvc;

namespace automotiveApi.Controllers.v1
{

    [ApiController]

    [Route("api/v1/[controller]")]

    public class AuthController : ControllerBase
    {
        private readonly IAuth _authService;


        public AuthController(AppDbContext context, IAuth authService)
        {
            _authService = authService;
        }


        [HttpPost("register")]
        public ActionResult<User> Register(UserDto request)
        {
            var user = new User
            {
                email = request.email,
                password = request.password,
                first_name = request.first_name,
                last_name = request.last_name,
                is_active = request.is_active,
                id_role = request.id_role,
                id_agence = request.id_agence
            };

            try
            {
                var newUser = _authService.register(user);
                return Ok(newUser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        [HttpPost("login")]
        public async Task<ActionResult<LoginResponse>> Login(LoginDto request)
        {
            var email = request.Email;
            var password = request.Password;

            var loginResponse = _authService.login(email, password);
            if (loginResponse == null)
            {
                return Unauthorized(new { message = "Invalid Credentials" });
            }

            return Ok(loginResponse);
        }


    }


}