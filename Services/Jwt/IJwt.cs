using AutomotiveApi.Models.Entities.Param;

namespace AutomotiveApi.Services.Jwt
{
    public interface IJwt
    {
        int getUserId();
        string getRole();        
        string generateToken(User user);
        int getIdAgence();
        int getClientId();
    }
}