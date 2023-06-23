using System.IdentityModel.Tokens.Jwt;
using automotiveApi.Models;

namespace automotiveApi.Services.Jwt
{
    public interface IJwt
    {
        int getUserId();
        string getRole();
        string generateToken(User user);

    }
}