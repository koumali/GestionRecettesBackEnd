using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Entities.Param
{
    public partial class Role : ModelBase
    {
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}