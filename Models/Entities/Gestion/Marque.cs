using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Entities.Gestion
{
    public partial class Marque : ModelBase
    {
        public Marque()
        {
            Modeles = new HashSet<Modele>();
        }

        public string name { get; set; }

        public virtual ICollection<Modele> Modeles { get; set; }
    }
}