using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Gestion;

namespace AutomotiveApi.Services.Param
{
    public class RoleService : GenericDataService<Role>, IRole
    {
        public RoleService(AppDbContext context) : base(context)
        {
        }

        // public Role? add(Role role)
        // {
        //     try
        //     {
        //         _context.Roles.Add(role);
        //         _context.SaveChanges();
        //         return role;
        //     }
        //     catch (Exception ex)
        //     {
        //         throw new Exception(ex.Message);
        //     }
        // }
        //
        //
        // public Role? findById(int id)
        // {
        //     var role = _context.Roles.FirstOrDefault(u => u.Id == id);
        //     return role;
        // }
        //
        // public Role? findByName(string name)
        // {
        //     var role = _context.Roles.FirstOrDefault(u => u.Name == name);
        //     return role;
        // }
        //
        // public IEnumerable<Role> getRoles()
        // {
        //     return _context.Roles.ToList();
        // }
        //
        // public void delete(int id)
        // {
        //     var role = _context.Roles.Find(id);
        //     if (role != null)
        //     {
        //         _context.Roles.Remove(role);
        //         _context.SaveChanges();
        //     }
        // }
        //
        // public Role update(Role updatedRole)
        // {
        //     try
        //     {
        //         _context.Roles.Update(updatedRole);
        //         _context.SaveChanges();
        //         return updatedRole;
        //     }
        //     catch (Exception ex)
        //     {
        //         throw new Exception(ex.Message);
        //     }
        // }
    }
}