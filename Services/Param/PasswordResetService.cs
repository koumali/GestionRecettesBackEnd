using AutomotiveApi.DAL;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Param;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Param
{
    public class PasswordResetService : IPasswordReset
    {
        private readonly AppDbContext _context;

        public PasswordResetService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<string> GeneratePasswordResetToken(string email)
        {
            bool exists = await _context.Users.AnyAsync(u => u.Email.ToLower() == email.ToLower() && u.IsVerified == true)
            || await _context.Clients.AnyAsync(u => u.Email.ToLower() == email.ToLower() && u.IsVerified == true && u.Password != null);


            if (!exists)
            {
                throw new Exception("utilisateur n'existe pas");
            }

            try
            {
                var token = Guid.NewGuid().ToString();
                var passwordResetToken = new PasswordResetToken
                {
                    Token = token,
                    Email = email,
                    ExpirationDate = DateTime.Now.AddMinutes(30)
                };

                _context.PasswordResetTokens.Add(passwordResetToken);
                _context.SaveChanges();

                return token;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> ResetPassword(PasswordResetDto passwordResetDto)
        {
            var passwordResetToken = await _context.PasswordResetTokens.FirstOrDefaultAsync(x => x.Token == passwordResetDto.Token);
            string? email = passwordResetToken?.Email?.ToLower();

            if (passwordResetToken == null)
            {
                throw new Exception("jeton invalide");
            }

            if (passwordResetToken.ExpirationDate < DateTime.Now)
            {
                throw new Exception("jeton expiré");
            }

            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.Email.ToLower() == email);
                var client = await _context.Clients.FirstOrDefaultAsync(x => x.Email.ToLower() == email);

                if (user != null)
                {
                    user.Password = BCrypt.Net.BCrypt.HashPassword(passwordResetDto.NewPassword);
                    _context.Users.Update(user);
                }
                else if (client != null)
                {
                    client.Password = BCrypt.Net.BCrypt.HashPassword(passwordResetDto.NewPassword);
                    _context.Clients.Update(client);
                }

                _context.PasswordResetTokens.Remove(passwordResetToken);
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }


}