using System.ComponentModel.DataAnnotations.Schema;
using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Entities.Param;

public partial class RolePermission : ModelBase
{
    public int IdRole { get; set; }
    public int IdPermission { get; set; }
    public Role Role { get; set; }
    public Permission Permission { get; set; }
}