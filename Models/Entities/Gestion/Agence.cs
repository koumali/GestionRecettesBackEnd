using AutomotiveApi.Models.Entities.Core;
using AutomotiveApi.Models.Entities.Param;

namespace AutomotiveApi.Models.Entities.Gestion
{
    public partial class Agence : ModelBase
    {
        public Agence()
        {
            Vehicules = new HashSet<Vehicule>();
            Users = new HashSet<User>();
        }

        public string name { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zip_code { get; set; }
        public Double latitude { get; set; }
        public Double longitude { get; set; }
        public virtual ICollection<Vehicule> Vehicules { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}