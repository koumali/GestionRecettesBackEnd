using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Param;

namespace AutomotiveApi.Services.Auth;

public interface IAuth
{
    Task<LoginResponse?> login(string email, string password);
    Task<User?> register(User user);
}