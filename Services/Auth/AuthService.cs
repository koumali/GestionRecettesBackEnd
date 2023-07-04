using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Jwt;
using AutomotiveApi.Services.Param;

namespace AutomotiveApi.Services.Auth
{
    public class AuthService : IAuth
    {
        private readonly IUser _UserService;
        private readonly IJwt _jwtService;

        public AuthService(IUser UserService, IJwt jwtService)
        {
            _UserService = UserService;
            _jwtService = jwtService;
        }

        public LoginResponse? login(string email, string password)
        {
            var user = _UserService.findByEmail(email);
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

        public User? register(User user)
        {
            return _UserService.add(user);
        }
    }
}