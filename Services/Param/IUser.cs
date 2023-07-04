using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Gestion.Interfaces;

namespace AutomotiveApi.Services.Param
{
    public interface IUser : IGenericData<User>
    {
        User? findByEmail(string email);
        // User? add(User user);
        // User? findById(int id);
        // IEnumerable<User> getUsers();
        // User? update(User user);
        // User? delete(int id);

        bool changePassword(int id, string newPassword);
    }
}