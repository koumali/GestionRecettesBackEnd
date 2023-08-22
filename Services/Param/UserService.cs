using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Gestion;
using AutomotiveApi.Utility;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Param
{
    public class UserService : GenericDataService<User>, IUser
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public Task<User?> findByEmail(string email)
        {
            var user = _context.Users.Where(u => u.Email == email)
            .Include(u => u.Role)
            .Include(u => u.Agence)
            .FirstOrDefaultAsync();
            return user;
        }

        public async Task<IEnumerable<User>> GetUsersAgence(int idAgence)
        {
            return await _context.Users
                .Include(u => u.Role)
                .Include(u => u.Agence)
                .Where(u => u.IdAgence == idAgence)
                .ToListAsync();
        }

        public new async Task<User?> CreateAsync(User user)
        {

            User? userExists = await findByEmail(user.Email);
            if (userExists != null)
            {
                throw new Exception("utilisateur existe deja");
            }

            try
            {
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
                user.CreatedAt = DateTime.Now;
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                return await GetByIdAsync(user.Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public new async Task<IEnumerable<User>> GetAllAsync()
        {
            var users = await _context.Users.Where(u => u.Role.Name == predefinedRoles.SuperAdmin.ToString() || u.Role.Name == predefinedRoles.Admin.ToString())
            .Include(u => u.Role).Include(u => u.Agence).Select
            (
                u => new User
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email,
                    IsActive = u.IsActive,
                    IdRole = u.IdRole,
                    IdAgence = u.IdAgence,
                    IsVerified = u.IsVerified,
                    Role = new Role
                    {
                        Id = u.Role.Id,
                        Name = u.Role.Name,                      
                    },
                    Agence = new Agence
                    {
                        Id = u.Agence.Id,
                        Name = u.Agence.Name
                    }
                }
            ).ToListAsync();

            return users;
        }


        public new async Task<User?> GetByIdAsync(int id)
        {

            var user = await _context.Users.Where(u => u.Id == id).Include(u => u.Role).Include(u => u.Agence).Select
            (
                u => new User
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email,
                    IsActive = u.IsActive,
                    IdRole = u.IdRole,
                    IdAgence = u.IdAgence,
                    IsVerified = u.IsVerified,
                    Role = new Role
                    {
                        Id = u.Role.Id,
                        Name = u.Role.Name,                        
                    },
                    Agence = new Agence
                    {
                        Id = u.Agence.Id,
                        Name = u.Agence.Name
                    }
                }
            ).FirstOrDefaultAsync();

            return user;
        }

        public async Task<bool> changePassword(int id, string newPassword)
        {
            var user = await _context.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
            if (user == null)
            {
                throw new Exception("utilisateur n'existe pas");
            }

            try
            {
                user.Password = BCrypt.Net.BCrypt.HashPassword(newPassword);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public new async Task<User?> UpdateAsync(User user)
        {
            var userExists = await _context.Users.Where(u => u.Id == user.Id).FirstOrDefaultAsync();
            if (userExists == null)
            {
                throw new Exception("utilisateur n'existe pas");
            }

            //verifier si l'email existe deja
            var emailExists = await _context.Users.Where(u => u.Email == user.Email && u.Id != user.Id).FirstOrDefaultAsync();
            if (emailExists != null)
            {
                throw new Exception("Email existe deja");
            }

            try
            {
                userExists.FirstName = user.FirstName;
                userExists.LastName = user.LastName;
                userExists.Email = user.Email;
                userExists.IdRole = user.IdRole;
                userExists.IdAgence = user.IdAgence;
                userExists.UpdatedAt = DateTime.Now;
                userExists.IsActive = user.IsActive;

                await _context.SaveChangesAsync();
                return await GetByIdAsync(user.Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}