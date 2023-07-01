using AutoMapper;
using automotiveApi.DAL;
using automotiveApi.Models;
using automotiveApi.Models.Dto;
using AutomotiveApi.Services.Auth;
using Microsoft.AspNetCore.Mvc;

namespace automotiveApi.Controllers.v1
{

    [ApiController]

    [Route("api/v1/[controller]")]

    public class AuthController : ControllerBase
    {
        private readonly IAuth _authService;
        protected readonly IMapper _mapper;


        public AuthController(AppDbContext context, IAuth authService, IMapper mapper)
        {
            _authService = authService;
            _mapper = mapper;
        }


        [HttpPost("register")]
        public ActionResult<User> Register(UserDto request)
        {
            var user = _mapper.Map<User>(request);

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