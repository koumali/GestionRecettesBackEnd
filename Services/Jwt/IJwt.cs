using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Models.Entities.Param;

namespace AutomotiveApi.Services.Jwt
{
    public interface IJwt
    {
        int getUserId();
        string getRole();        
        string generateToken(User user);
        string generateClientToken(Client client);
        int getIdAgence();
        int getClientId();
    }
}