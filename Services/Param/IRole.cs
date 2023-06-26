using automotiveApi.Models;

namespace automotiveApi.Services.Param
{
    public interface IRole
    {
        Task<IEnumerable<Role>> getRoles();
        Task<Role?> findById(int id);
        Task<Role?> findByName(string name);
        Task<Role?> add(Role role);


    }
}