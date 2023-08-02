using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Param;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Param;

public class PermissionService : IPermissionService
{
    private readonly AppDbContext _context;

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
}