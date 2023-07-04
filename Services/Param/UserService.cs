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

        public User? findByEmail(string email)
        {
            var user = _context.Users.Where(u => u.Email == email).Include(u => u.Role).FirstOrDefault();
            return user;
        }

        public new async Task<User> CreateAsync(User user)
        {
            User? userExists = findByEmail(user.Email);
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

        // public User? add(User user)
        // {
        //     User? userExists = findByEmail(user.Email);
        //     if (userExists != null)
        //     {
        //         throw new Exception("User already exists");
        //     }
        //
        //     try
        //     {
        //         user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
        //
        //         _context.Users.Add(user);
        //         _context.SaveChanges();
        //         // return user with role
        //         user.Role = _context.Roles.Where(r => r.Id == user.IdRole).FirstOrDefault();
        //         return user;
        //     }
        //     catch (Exception ex)
        //     {
        //         throw new Exception(ex.Message);
        //     }
        // }

        public new async Task<IEnumerable<User>> GetAllAsync()
        {
            var users = await _context.Users.Where(u => u.DeletedAt == null).Include(u => u.Role).ToListAsync();
            return users;
        }

        // public IEnumerable<User> getUsers()
        // {
        //     var users = _context.Users.Where(u => u.DeletedAt == null).Include(u => u.Role).ToList();
        //     return users;
        // }

        public new async Task<User?> GetByIdAsync(int id)
        {
            var user = await _context.Users.Where(u => u.Id == id).Include(u => u.Role).FirstOrDefaultAsync();
            return user;
        }

        // public User? findById(int id)
        // {
        //     var user = _context.Users.Where(u => u.Id == id).Include(u => u.Role).FirstOrDefault();
        //     return user;
        // }

        // public User? update(User user)
        //
        // {
        //     Console.WriteLine("user id: " + user.Id);
        //     var userExists = findById(user.Id);
        //     if (userExists == null)
        //     {
        //         throw new Exception("User not found");
        //     }
        //
        //     try
        //     {
        //         userExists.FirstName = user.FirstName;
        //         userExists.LastName = user.LastName;
        //         userExists.Email = user.Email;
        //         userExists.IsActive = user.IsActive;
        //         userExists.IdRole = user.IdRole;
        //         userExists.IdAgence = user.IdAgence;
        //
        //         _context.SaveChanges();
        //
        //         return userExists;
        //     }
        //     catch (Exception ex)
        //     {
        //         throw new Exception(ex.Message);
        //     }
        // }

        // public User? delete(int id)
        // {
        //     var user = _context.Users.Where(u => u.Id == id).FirstOrDefault();
        //     if (user == null)
        //     {
        //         throw new Exception("User not found");
        //     }
        //
        //     try
        //     {
        //         user.DeletedAt = DateTime.Now;
        //         _context.SaveChanges();
        //         return user;
        //     }
        //     catch (Exception ex)
        //     {
        //         throw new Exception(ex.Message);
        //     }
        // }

        public bool changePassword(int id, string newPassword)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
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