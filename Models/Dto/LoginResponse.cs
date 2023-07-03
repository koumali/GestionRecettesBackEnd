using AutomotiveApi.Models.Entities.Param;

namespace AutomotiveApi.Models.Dto
{
    public class LoginResponse
    {
        public string? token { get; set; }
        public User? user { get; set; }
    }
}