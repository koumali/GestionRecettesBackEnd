using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Gestion;
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
            var user = _context.Users.Where(u => u.Email == email).Include(u => u.Role).FirstOrDefaultAsync();
            return user;
        }

        public new async Task<User> CreateAsync(User user)
        {
            User? userExists = await findByEmail(user.Email);
            if (userExists != null)
            {
                throw new Exception("User already exists");
            }

            try
            {
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                // return user with role
                // user.Role = await _context.Roles.FirstOrDefaultAsync(r => r.Id == user.IdRole);
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public new async Task<IEnumerable<User>> GetAllAsync()
        {
            var users = await _context.Users.Where(u => u.DeletedAt == null).Include(u => u.Role).ToListAsync();
            return users;
        }


        public new async Task<User?> GetByIdAsync(int id)
        {
            var user = await _context.Users.Where(u => u.Id == id).Include(u => u.Role).FirstOrDefaultAsync();
            return user;
        }

        public async Task<bool> changePassword(int id, string newPassword)
        {
            var user = await _context.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
            if (user == null)
            {
                throw new Exception("User not found");
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
    }
}