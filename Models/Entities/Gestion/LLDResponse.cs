using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Entities.Gestion
{
    public class LLDResponse : ModelBase
    {
        public int prix { get; set; }
        public string description { get; set; }
        public int idAgence { get; set; }
        public int idLongTermRental { get; set; }
        public virtual LongTermRental LongTermRental { get; set; }

    }
}
