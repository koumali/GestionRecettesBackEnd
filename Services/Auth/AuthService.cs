using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Jwt;
using AutomotiveApi.Services.Param;

namespace AutomotiveApi.Services.Auth
{
    public class AuthService : IAuth
    {
        private readonly IUser _userService;
        private readonly IJwt _jwtService;

        public AuthService(IUser userService, IJwt jwtService)
        {
            _userService = userService;
            _jwtService = jwtService;
        }

        public LoginResponse? login(string email, string password)
        {
            var user = _userService.findByEmail(email);
            if (user == null)
            {
                return null;
            }

            if (!BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                return null;
            }

            var genToken = _jwtService.generateToken(user);

            return new LoginResponse
            {
                Token = genToken,
                User = user
            };
        }

        public async Task<User?> register(User user)
        {
            return await _userService.CreateAsync(user);
        }
    }
}