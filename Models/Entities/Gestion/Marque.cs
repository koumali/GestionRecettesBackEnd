using System;
using System.Collections.Generic;

namespace automotiveApi.Models
{
    public partial class Marque:ModelBase
    {
        public Marque()
        {
            Vehicules = new HashSet<Vehicule>();
        }
        public string name { get; set; }

        public virtual ICollection<Vehicule> Vehicules { get; set; }
    }
}
