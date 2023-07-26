using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutomotiveApi.Models.Entities.Param;
using Microsoft.IdentityModel.Tokens;

namespace AutomotiveApi.Services.Jwt
{
    public class JwtService : IJwt
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;


        public JwtService(IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
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
                new Claim("clientId", user.clientId.ToString() ?? "0"),
                new Claim("fullname", user.FirstName + " " + user.LastName),
                new Claim(ClaimTypes.Role, user.Role.Name),
                new Claim("idAgence", user.IdAgence.ToString() ?? "0")
            };


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
}