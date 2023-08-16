using AutomotiveApi.Models.Dto;

namespace AutomotiveApi.Services.Param
{
    public interface IEmailVerification
    {
        Task<string> GenerateVerificationToken(string email);
        Task<bool> VerifyEmail(string token);
        
    }
}