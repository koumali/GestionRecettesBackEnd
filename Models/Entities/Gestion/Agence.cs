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

        public string Name { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public virtual ICollection<Vehicule> Vehicules { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}