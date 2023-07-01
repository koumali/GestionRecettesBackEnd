using automotiveApi.DAL;
using automotiveApi.Models;
using Microsoft.EntityFrameworkCore;

namespace automotiveApi.Services.Param
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
            var user = _context.Users.Where(u => u.email == email).Include(u => u.Role).FirstOrDefault();
            return user;
        }

        public User? add(User user)
        {
            User? userExists = findByEmail(user.email);
            if (userExists != null)
            {
                throw new Exception("User already exists");
            }

            try
            {
                user.password = BCrypt.Net.BCrypt.HashPassword(user.password);

                _context.Users.Add(user);
                _context.SaveChanges();
                // return user with role
                user.Role = _context.Roles.Where(r => r.id == user.id_role).FirstOrDefault();
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public IEnumerable<User> getUsers()
        {
            var users = _context.Users.Where(u => u.deleted_at == null).Include(u => u.Role).ToList();
            return users;
        }

        public User? findById(int id)
        {
            var user = _context.Users.Where(u => u.id == id).Include(u => u.Role).FirstOrDefault();
            return user;
        }

        public User? update(User user)

        {

            Console.WriteLine("user id: " + user.id);
            var userExists = findById(user.id);
            if (userExists == null)
            {
                throw new Exception("User not found");
            }

            try
            {
                userExists.first_name = user.first_name;
                userExists.last_name = user.last_name;
                userExists.email = user.email;
                userExists.is_active = user.is_active;
                userExists.id_role = user.id_role;
                userExists.id_agence = user.id_agence;


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
            var user = _context.Users.Where(u => u.id == id).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("User not found");
            }

            try
            {
                user.deleted_at = DateTime.Now;
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
            var user = _context.Users.Where(u => u.id == id).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("User not found");
            }

            try
            {
                user.password = BCrypt.Net.BCrypt.HashPassword(newPassword);
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