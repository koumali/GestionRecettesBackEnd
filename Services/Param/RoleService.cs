using AutomotiveApi.DAL;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Gestion;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

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

        public new async Task<IEnumerable<Role>> GetAllAsync()
        {
            var listRoles = await _context.Roles
            .Include(r => r.Permissions)
            .ToListAsync();

            return listRoles;
        }

        public new async Task<Role?> GetByIdAsync(int id)
        {
            var role = await _context.Roles
            .Where(r => r.Id == id)
            .Include(r => r.Permissions)
            .FirstOrDefaultAsync();

            return role;
        }

        public async Task<Role?> CreateWithPermissionsAsync(RoleDto roleDto)
        {
            var role = new Role()
            {
                Name = roleDto.Name,
                IdAgence = roleDto.IdAgence
            };



            if (roleDto.SelectedPermissionIds.Count == 0)
            {
                throw new Exception("You must select at least one permission");
            }

            await base.CreateAsync(role);

            var selectedPermissions = await _context.Permissions
            .Where(p => roleDto.SelectedPermissionIds
            .Contains(p.Id))
            .ToListAsync();



            foreach (var permission in selectedPermissions)
            {
                var rolePermission = new RolePermission()
                {
                    IdRole = role.Id,
                    IdPermission = permission.Id
                };

                await _context.RolePermissions.AddAsync(rolePermission);
            }

            await _context.SaveChangesAsync();

            return _context.Roles.Where(r => r.Id == role.Id)
            .Include(r => r.Permissions).FirstOrDefault();
        }

        public async Task<Role?> UpdateWithPermissionsAsync(RoleDto roleDto)
        {
            var role = await _context.Roles
            .Where(r => r.Id == roleDto.Id)
            .Include(r => r.Permissions)
            .FirstOrDefaultAsync();

            if (role == null)
            {
                throw new Exception("Role not found");
            }

            role.Name = roleDto.Name;
            role.IdAgence = roleDto.IdAgence;

            if (roleDto.SelectedPermissionIds.Count == 0)
            {
                throw new Exception("You must select at least one permission");
            }
            

            var selectedPermissions = await _context.RolePermissions
            .Where(rp => rp.IdRole == role.Id)

            .ToListAsync();

            _context.RolePermissions.RemoveRange(selectedPermissions);

            var newSelectedPermissions = await _context.Permissions
            .Where(p => roleDto.SelectedPermissionIds
            .Contains(p.Id))
            .ToListAsync();

            foreach (var permission in newSelectedPermissions)
            {
                var rolePermission = new RolePermission()
                {
                    IdRole = role.Id,
                    IdPermission = permission.Id
                };

                await _context.RolePermissions.AddAsync(rolePermission);
            }

            await _context.SaveChangesAsync();

            return await _context.Roles.Where(r => r.Id == role.Id)
            .Include(r => r.Permissions).FirstOrDefaultAsync();
        }
    }
}