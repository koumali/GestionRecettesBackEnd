using automotiveApi.Models.Dto;
using automotiveApi.Models;
using automotiveApi.Services.Jwt;
using AutomotiveApi.Services.Auth;
using automotiveApi.Services.Param;

namespace automotiveApi.Services.Auth
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

            if (!BCrypt.Net.BCrypt.Verify(password, user.password))
            {
                return null;
            }        

            var genToken = _jwtService.generateToken(user);

            return new LoginResponse
            {
                token = genToken,
                user = user
            };
        }

        public User? register(User user)
        {
           return _UserService.add(user);

        }
    }
}