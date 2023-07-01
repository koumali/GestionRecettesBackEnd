using automotiveApi.Models;

namespace automotiveApi.Services.Param
{
    public interface IUser
    {        
       User? findByEmail(string email);
       User? add(User user);  
       User? findById(int id);
       IEnumerable<User> getUsers();
       User? update(User user);

       User? delete(int id);

       bool changePassword(int id, string newPassword);
    }
}