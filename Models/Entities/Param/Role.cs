using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Entities.Param
{
    public partial class Role : ModelBase
    {
        public string name { get; set; }

        public virtual ICollection<User> users { get; set; }
    }
}