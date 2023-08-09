using AutoMapper;
using AutomotiveApi.DAL;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Auth;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1
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
        public async Task<ActionResult<User>> Register(UserDto request)
        {
            var user = _mapper.Map<User>(request);

            try
            {
                var newUser = await _authService.register(user);
                return Ok(newUser);
            }
            catch (Exception ex)
            {
                return BadRequest(new { errors = ex.Message });
            }


        }

        [HttpPost("login")]
        public async Task<ActionResult<LoginResponse>> Login(LoginDto request)
        {
            var email = request.Email;
            var password = request.Password;

            var loginResponse = await _authService.login(email, password);
            if (loginResponse == null)
            {
                return Unauthorized(new { errors = "Email ou mot de passe incorrect" });
            }

            return Ok(loginResponse);
        }


    }


}