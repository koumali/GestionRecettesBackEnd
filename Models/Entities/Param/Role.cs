

namespace automotiveApi.Models
{
    public partial class Role:ModelBase
    {        
        public string name { get; set; }

        public virtual ICollection<User> users { get; set; }
    }
}
