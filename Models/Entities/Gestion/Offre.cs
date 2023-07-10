using System.ComponentModel.DataAnnotations.Schema;
using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Entities.Gestion
{
    public partial class Offre : ModelBase
    {
        public int IdVehicule { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public double Prix { get; set; }
        // [ForeignKey("IdVehicule")]
        public virtual Vehicule Vehicule { get; set; }
    }
}