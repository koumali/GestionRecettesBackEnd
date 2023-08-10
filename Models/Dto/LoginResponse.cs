using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Models.Entities.Param;

namespace AutomotiveApi.Models.Dto;

public class LoginResponse
{
    public string? Token { get; set; }
    public User? User { get; set; }
}

public class ClientLoginResponse
{
    public string? Token { get; set; }
    public Client? Client { get; set; }
}