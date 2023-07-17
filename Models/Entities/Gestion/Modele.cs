using System.ComponentModel.DataAnnotations.Schema;
using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Entities.Gestion
{
    public partial class Modele : ModelBase
    {
        public Modele()
        {
            Vehicules = new HashSet<Vehicule>();
        }

        public string Name { get; set; }
        public int IdMarque { get; set; }        
        // [ForeignKey("IdMarque")]
        public virtual Marque Marque { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Vehicule> Vehicules { get; set; }
    }
}