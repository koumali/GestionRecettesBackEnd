
using System;

namespace automotiveApi.Models
{
    public partial class Offre : ModelBase
    {
        public int id_vehicule { get; set; }
        public DateTime date_debut { get; set; }
        public DateTime date_fin { get; set; }
        public double prix { get; set; }
        public virtual Vehicule Vehicule { get; set; }
    }
}
