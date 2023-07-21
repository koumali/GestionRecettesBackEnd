using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Gestion;
using Microsoft.EntityFrameworkCore;

namespace AutomotiveApi.Services.Param
{
    public class RoleService : GenericDataService<Role>, IRole
    {
        private readonly AppDbContext _context;

        public RoleService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Role>> GetRolesAgence()
        {
            var listRoles = await _context.Roles
                .Where(u => u.Id != 0 && u.Name.ToLower() != "admin")
                .Distinct()
                .ToListAsync();
            return listRoles;
        }
    }
}