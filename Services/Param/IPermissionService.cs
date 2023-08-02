namespace AutomotiveApi.Services.Param;

public interface IPermissionService
{
    HashSet<string> GetPermissionsAsync(int idUser);
}