using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Param;
using Microsoft.IdentityModel.Tokens;

namespace AutomotiveApi.Services.Jwt;

public class JwtService : IJwt
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IConfiguration _configuration;
    private readonly IPermissionService _permissionService;


    public JwtService(IHttpContextAccessor httpContextAccessor, IConfiguration configuration,
        IPermissionService permissionService)
    {
        _httpContextAccessor = httpContextAccessor;
        _configuration = configuration;
        _permissionService = permissionService;
    }

    public int getUserId()
    {
        var userId = _httpContextAccessor?.HttpContext?.User.FindFirst("id")?.Value;
        return int.Parse(userId ?? "0");
    }

    public string getRole()
    {
        var role = _httpContextAccessor?.HttpContext?.User.FindFirst(ClaimTypes.Role)?.Value ?? "No Role";
        return role;
    }

    public int getIdAgence()
    {
        var idAgence = int.Parse(_httpContextAccessor.HttpContext?.User.FindFirst("idAgence")?.Value ?? "0");
        return idAgence;
    }

    public int getClientId()
    {
        var clientId = int.Parse(_httpContextAccessor.HttpContext?.User.FindFirst("clientId")?.Value ?? "0");
        return clientId;
    }

    public string generateToken(User user)
    {
        List<Claim> claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
            new Claim("id", user.Id.ToString()),
            new Claim("fullname", user.FirstName + " " + user.LastName),
            new Claim(ClaimTypes.Role, user.Role.Name),
            new Claim("idAgence", string.IsNullOrEmpty(user.IdAgence.ToString()) ? "0" : user.IdAgence.ToString()),
        };

        var permissions = _permissionService.GetPermissionsAsync(user.Id);
        foreach (var permission in permissions)
        {
            claims.Add(new("permissions", permission));
        }

        return JwtTokenFromClaims(claims);
    }

    public string generateClientToken(Client client)
    {
        List<Claim> claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
            new Claim("clientId", client.Id.ToString()),
            new Claim("fullname", client.FirstName + " " + client.LastName),
            new Claim(ClaimTypes.Role, "Client"),
        };

        return JwtTokenFromClaims(claims);
    }

    public string JwtTokenFromClaims(List<Claim> claims)
    {
        var expirationTime = _configuration.GetValue<int>("Jwt:DurationInMinutes");
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]) ??
                                           throw new InvalidOperationException());
        var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(
            _configuration["Jwt:Issuer"],
            _configuration["Jwt:Audience"],
            claims,
            expires: DateTime.UtcNow.AddMinutes(expirationTime),
            signingCredentials: signIn);


        var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
        return jwtToken;
    }
}