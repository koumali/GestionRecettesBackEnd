using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Jwt;
using AutomotiveApi.Services.Param;

namespace AutomotiveApi.Services.Auth;

public class AuthService : IAuth
{
    private readonly IUser _userService;
    private readonly IJwt _jwtService;

    public AuthService(IUser userService, IJwt jwtService)
    {
        _userService = userService;
        _jwtService = jwtService;
    }

    public async Task<LoginResponse?> login(string email, string password)
    {
        var user = await _userService.findByEmail(email);
        if (user == null)
        {
            throw new Exception("Email ou mot de passe incorrect");
        }

        if (!BCrypt.Net.BCrypt.Verify(password, user.Password))
        {
            throw new Exception("Email ou mot de passe incorrect");
        }

        if (user.IsActive == false)
        {
            throw new Exception("Votre compte est désactivé");
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