using AutomotiveApi.Models.Entities.Param;

namespace AutomotiveApi.Services.Param;

public interface IPermissionService
{
    HashSet<string> GetPermissionsAsync(int idUser);
    Task<IEnumerable<Permission>> GetAllAsync();
}