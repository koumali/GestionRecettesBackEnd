using System.IdentityModel.Tokens.Jwt;

namespace automotiveApi.Models.Dto
{
    public class LoginResponse
    {
        public string? token { get; set; }
        public User? user { get; set; }
    }
}