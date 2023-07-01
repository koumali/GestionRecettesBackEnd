
namespace automotiveApi.Models
{
    public partial class Reservation : ModelBase
    {
        public Reservation() 
        {
            Contrats = new HashSet<Contrat>();
        }
        public DateTime date_depart { get; set; }
        public DateTime date_retour { get; set; }
        public int id_vehicule { get; set; }
        public virtual Vehicule Vehicule { get; set; }
        public virtual ICollection<Contrat> Contrats { get; set; }

    }
}
