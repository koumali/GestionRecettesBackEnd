using System;
using System.Collections.Generic;

namespace automotiveApi.Models
{
    public partial class Client : ModelBase
    {
        public Client()
        {
            Contrats = new HashSet<Contrat>();
        }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string ville { get; set; }
        public string zipcode { get; set; }
        public string adresse { get; set; }
        public string adresse2 { get; set; }
        public string permis_recto { get; set; }
        public string permis_verso { get; set; }

        public virtual ICollection<Contrat> Contrats { get; set; }

    }
}
