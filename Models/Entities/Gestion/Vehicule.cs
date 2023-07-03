using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Entities.Gestion
{
    public partial class Vehicule : ModelBase
    {
        public Vehicule()
        {
            Reservation = new HashSet<Reservation>();
            Offre = new HashSet<Offre>();
        }

        public string name { get; set; }
        public string matricule { get; set; }
        public double prix { get; set; }
        public int nb_port { get; set; }
        public int nb_passager { get; set; }
        public int km { get; set; }
        public bool climat { get; set; }
        public bool airbag { get; set; }
        public string image { get; set; }
        public string gearbox { get; set; }
        public string moteur { get; set; }
        public int id_agence { get; set; }
        public int id_modele { get; set; }
        public virtual Agence Agence { get; set; }
        public virtual Modele Modele { get; set; }

        public virtual ICollection<Reservation> Reservation { get; set; }
        public virtual ICollection<Offre> Offre { get; set; }
    }
}