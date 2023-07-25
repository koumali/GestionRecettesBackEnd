using AutomotiveApi.DAL;
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
            .Include(u => u.Role)
            .ThenInclude(u => u.Permissions)
            .Where(u => u.Id == idUser)
            .Select(u => u.Role.Permissions)
            .SelectMany(x => x)
            .Select(p => p.Name)
            .ToHashSet();
    }
}