using System;
using System.Collections.Generic;

namespace automotiveApi.Models
{
    public partial class Modele:ModelBase
    {
        public Modele()
        {
            Vehicules = new HashSet<Vehicule>();
        }
        public string name { get; set; }

        public virtual ICollection<Vehicule> Vehicules { get; set; }
    }
}
