namespace automotiveApi.Models
{
    public partial class Modele : ModelBase
    {
        public Modele()
        {
            Vehicules = new HashSet<Vehicule>();
        }

        public string name { get; set; }
        public int id_marque { get; set; }

        public virtual Marque Marque { get; set; }
        public virtual ICollection<Vehicule> Vehicules { get; set; }
    }
}
