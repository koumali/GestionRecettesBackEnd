using System.ComponentModel.DataAnnotations.Schema;
using AutomotiveApi.Models.Entities.Core;
using Microsoft.IdentityModel.Tokens;

namespace AutomotiveApi.Models.Entities.Gestion
{
    public partial class LongTermRental : ModelBase
    {
        public string prenom { get; set; }
        public string nom { get; set; }
        public string phone { get; set; }
        public string ville { get; set; }
        public string email { get; set; }
        public string zip { get; set; }
        public string entreprise { get; set; }
        public int duree { get; set; }
        public int type_vehicule { get; set; }
        public string description { get; set; }
    }
}