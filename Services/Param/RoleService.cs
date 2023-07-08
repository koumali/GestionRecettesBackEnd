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

        public async Task<IEnumerable<Role>> GetRolesAgence(int idAgence)
        {
            var listUers = await _context.Users
                .Include(u => u.Role)
                .Where(u => u.IdAgence == idAgence && u.IdAgence != null)
                .ToListAsync();
            var listRoles = new List<Role>();
            listUers.ForEach(u => listRoles.Add(new Role
            {
                Id = u.Role.Id,
                Name = u.Role.Name
            }));
            return listRoles.DistinctBy(r => r.Name);
        }
    }
}