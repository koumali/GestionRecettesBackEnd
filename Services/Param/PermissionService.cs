using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Utility;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Param;

public class PermissionService : IPermissionService
{
    private readonly AppDbContext _context;
    private object predefinedPermissions;

    public PermissionService(AppDbContext context)
    {
        _context = context;
    }

    public HashSet<string> GetPermissionsAsync(int idUser)
    {
        return _context.Users
        .Where(u => u.Id == idUser)
        .Include(u => u.Role)
        .ThenInclude(r => r.RolePermissions)
        .ThenInclude(rp => rp.Permission)
        .SelectMany(u => u.Role.RolePermissions.Select(rp => rp.Permission.Name))
        .ToHashSet();
    }
    public async Task<IEnumerable<Permission>> GetAllAsync()
    {
        return await _context.Permissions.ToListAsync();
    }

    public async Task<IEnumerable<Permission>> GetPermissionsAgence()
    {
        var notAllowed = new List<string> { PredefinedPermissions.Permissions.ToString(),
         PredefinedPermissions.Utilisateurs.ToString(),
          PredefinedPermissions.Roles.ToString(),
          PredefinedPermissions.Agences.ToString() ,
          PredefinedPermissions.Modèles.ToString(),
          PredefinedPermissions.Marques.ToString(),
            PredefinedPermissions.Journalisation.ToString()
          };

        return await _context.Permissions.Where(p => !notAllowed.Contains(p.Name)).ToListAsync();
    }
}