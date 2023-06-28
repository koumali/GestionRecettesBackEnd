using automotiveApi.Models;

namespace automotiveApi.Services.Param
{
    public interface IRole
    {
        IEnumerable<Role> getRoles();
        Role? findById(int id);
        Role? add(Role role);
        void delete(int id);
        Role? update(Role role);



    }
}