using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Param;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Param
{
    public class UserService : IUser
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public User? findByEmail(string email)
        {
            var user = _context.Users.Where(u => u.Email == email).Include(u => u.Role).FirstOrDefault();
            return user;
        }

        public User? add(User user)
        {
            User? userExists = findByEmail(user.Email);
            if (userExists != null)
            {
                throw new Exception("User already exists");
            }

            try
            {
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

                _context.Users.Add(user);
                _context.SaveChanges();
                // return user with role
                user.Role = _context.Roles.Where(r => r.Id == user.IdRole).FirstOrDefault();
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<User> getUsers()
        {
            var users = _context.Users.Where(u => u.DeletedAt == null).Include(u => u.Role).ToList();
            return users;
        }

        public User? findById(int id)
        {
            var user = _context.Users.Where(u => u.Id == id).Include(u => u.Role).FirstOrDefault();
            return user;
        }

        public User? update(User user)

        {
            Console.WriteLine("user id: " + user.Id);
            var userExists = findById(user.Id);
            if (userExists == null)
            {
                throw new Exception("User not found");
            }

            try
            {
                userExists.FirstName = user.FirstName;
                userExists.LastName = user.LastName;
                userExists.Email = user.Email;
                userExists.IsActive = user.IsActive;
                userExists.IdRole = user.IdRole;
                userExists.IdAgence = user.IdAgence;

                _context.SaveChanges();

                return userExists;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public User? delete(int id)
        {
            var user = _context.Users.Where(u => u.Id == id).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("User not found");
            }

            try
            {
                user.DeletedAt = DateTime.Now;
                _context.SaveChanges();
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool changePassword(int id, string newPassword)
        {
            var user = _context.Users.Where(u => u.Id == id).FirstOrDefault();
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