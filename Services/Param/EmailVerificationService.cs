using AutomotiveApi.DAL;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Param;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Param
{
    public class EmailVerificationService : IEmailVerification
    {

        private readonly AppDbContext _context;
        public EmailVerificationService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<string> GenerateVerificationToken(string email)
        {
            bool exists = await _context.Users.AnyAsync(x => x.Email.ToLower() == email && x.IsVerified == false)
            || await _context.Clients.AnyAsync(x => x.Email.ToLower() == email && x.IsVerified == false && x.Password != null);


            if (!exists)
            {
                throw new Exception("utilisateur n'existe pas");
            }

            try
            {
                var token = Guid.NewGuid().ToString();
                var emailVerificationToken = new EmailVerificationToken
                {
                    Token = token,
                    Email = email,
                    ExpirationDate = DateTime.Now.AddMinutes(30)
                };

                _context.EmailVerificationTokens.Add(emailVerificationToken);
                _context.SaveChanges();

                return token;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<bool> VerifyEmail(string token)

        {
            var emailVerificationToken = await _context.EmailVerificationTokens.FirstOrDefaultAsync(x => x.Token == token);
            string? email = emailVerificationToken?.Email?.ToLower();

            if (emailVerificationToken == null)
            {
                throw new Exception("jeton invalide");
            }

            if (emailVerificationToken.ExpirationDate < DateTime.Now)
            {
                throw new Exception("jeton expiré");
            }

            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.Email.ToLower() == email);
                var client = await _context.Clients.FirstOrDefaultAsync(x => x.Email.ToLower() == email);

                if (user != null)
                {
                    user.IsVerified = true;
                    _context.Users.Update(user);
                    _context.SaveChanges();
                }
                else if (client != null)
                {
                    client.IsVerified = true;
                    _context.Clients.Update(client);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("utilisateur n'existe pas");
                }

                _context.EmailVerificationTokens.Remove(emailVerificationToken);
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