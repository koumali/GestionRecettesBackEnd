using automotiveApi.DAL;
using automotiveApi.Models;
using automotiveApi.Services.Auth;
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
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public IEnumerable<User> getUsers()
        {
            var users = _context.Users.Include(u => u.Role).ToList();
            return users;
        }

        public User? findById(int id)
        {
            var user = _context.Users.Where(u => u.id == id).Include(u => u.Role).FirstOrDefault();
            return user;
        }

    }

}