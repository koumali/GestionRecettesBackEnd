using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Param;

namespace AutomotiveApi.Services.Auth
{
    public interface IAuth
    {
        public LoginResponse login(string email, string password);
        public User? register(User user);
    }
}