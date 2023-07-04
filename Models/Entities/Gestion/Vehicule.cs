using System.ComponentModel.DataAnnotations.Schema;
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

        public string Name { get; set; }
        public string Matricule { get; set; }
        public double Prix { get; set; }
        public int NbPort { get; set; }
        public int NbPassager { get; set; }
        public int Km { get; set; }
        public bool Climat { get; set; }
        public bool Airbag { get; set; }
        public string Image { get; set; }
        public string Gearbox { get; set; }
        public string Moteur { get; set; }
        public int IdAgence { get; set; }
        public int IdModele { get; set; }
        [ForeignKey("IdAgence")] public virtual Agence Agence { get; set; }
        [ForeignKey("IdModele")] public virtual Modele Modele { get; set; }

        public virtual ICollection<Reservation> Reservation { get; set; }
        public virtual ICollection<Offre> Offre { get; set; }
    }
}