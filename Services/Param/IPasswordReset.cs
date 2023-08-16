using AutomotiveApi.Models.Dto;

namespace AutomotiveApi.Services.Param
{
    public interface IPasswordReset
    {
        Task<string> GeneratePasswordResetToken(string email);
        Task<bool> ResetPassword(PasswordResetDto passwordResetDto);
        
    }
}