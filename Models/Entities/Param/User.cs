using System.ComponentModel.DataAnnotations.Schema;

namespace automotiveApi.Models
{
    public partial class User : ModelBase
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool? is_active { get; set; }        
        public int id_role { get; set; }
        public virtual Role Role { get; set; }    
        public int? id_agence { get; set; }
        public virtual Agence agence { get; set; }
    }
}
