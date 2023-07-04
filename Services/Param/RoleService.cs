using AutomotiveApi.DAL;
using AutomotiveApi.Models.Entities.Param;

namespace AutomotiveApi.Services.Param
{
    public class RoleService : IRole
    {
        private readonly AppDbContext _context;

        public RoleService(AppDbContext context)
        {
            _context = context;
        }

        public Role? add(Role role)
        {
            try
            {
                _context.Roles.Add(role);
                _context.SaveChanges();
                return role;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public Role? findById(int id)
        {
            var role = _context.Roles.Where(u => u.Id == id).FirstOrDefault();
            return role;
        }

        public Role? findByName(string name)
        {
            var role = _context.Roles.Where(u => u.Name == name).FirstOrDefault();
            return role;
        }

        public IEnumerable<Role> getRoles()
        {
            return _context.Roles.ToList();
        }

        public void delete(int id)
        {
            var role = _context.Roles.Find(id);
            if (role != null)
            {
                _context.Roles.Remove(role);
                _context.SaveChanges();
            }
        }

        public Role update(Role updatedRole)
        {
            try
            {
                _context.Roles.Update(updatedRole);
                _context.SaveChanges();
                return updatedRole;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}