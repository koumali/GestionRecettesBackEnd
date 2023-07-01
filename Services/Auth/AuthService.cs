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

        public User register(User user)
        {
            var email = user.email;

            var userFromDb = _UserService.findByEmail(email);
            if (userFromDb != null)
            {
                throw new Exception("User with this email already exists");
            }

            User newUser = new User
            {
                email = email,
                password = BCrypt.Net.BCrypt.HashPassword(user.password),
                first_name = user.first_name,
                last_name = user.last_name,
                is_active = user.is_active,
                id_role = user.id_role,
                id_agence = user.id_agence,
                created_at = DateTime.Now
            };
            try
            {
                var createdUser = _UserService.add(newUser);
                return createdUser;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}