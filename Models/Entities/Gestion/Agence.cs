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
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public bool IsVerified { get; set; }
        public ICollection<Vehicule> Vehicules { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<LLDResponse> LLDResponses { get; set; }
        public ICollection<LongTermRental> LongTermRentals { get; set; }
    }
}