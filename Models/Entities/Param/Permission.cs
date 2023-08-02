using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Entities.Param;

public class Permission : ModelBase
{     
    public string Name { get; set; } = string.Empty;

    public virtual ICollection<Role> Roles { get; set; }
    public virtual ICollection<RolePermission> RolePermissions { get; set; }
}