using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Gestion.Interfaces;

namespace AutomotiveApi.Services.Param
{
    public interface IRole : IGenericData<Role>
    {
        Task<IEnumerable<Role>> GetRolesAgence(int idAgence);
        Task<Role> CreateWithPermissionsAsync(RoleDto entity);
        Task<Role> UpdateWithPermissionsAsync(RoleDto entity);

        // Role? findById(int id);
        // Role? add(Role role);
        // void delete(int id);
        // Role? update(Role role);
    }
}