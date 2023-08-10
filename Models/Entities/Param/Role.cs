using System.ComponentModel.DataAnnotations.Schema;
using AutomotiveApi.Models.Entities.Core;
using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Models.Entities.Param;

public partial class Role : ModelBase
{
    public string Name { get; set; }
    public int? IdAgence { get; set; }
    public Agence? Agence { get; set; }
    public virtual ICollection<User> Users { get; set; }

    public virtual ICollection<Permission> Permissions { get; set; }
    public virtual ICollection<RolePermission> RolePermissions { get; set; }
}