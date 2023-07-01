using automotiveApi.Models;
using automotiveApi.Models.Dto;

namespace AutomotiveApi.Services.Auth
{
    public interface IAuth
    {
        public LoginResponse login(string email, string password);
        public User? register(User user);
    }
}