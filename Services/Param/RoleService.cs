using automotiveApi.DAL;
using automotiveApi.Models;
using Microsoft.EntityFrameworkCore;

namespace automotiveApi.Services.Param
{
    public class RoleService : IRole
    {
        private readonly AppDbContext _context;

        public RoleService(AppDbContext context)
        {
            _context = context;
        }

        public Task<Role?> add(Role role)
        {
            throw new NotImplementedException();
        }

        public Task<Role?> findById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Role?> findByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Role>> getRoles()
        {
            return await _context.Roles.ToListAsync();
        }
    }

}