using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Entities.Gestion
{
    public partial class Contrat : ModelBase
    {
        public int id_client { get; set; }
        public int id_reservation { get; set; }
        public virtual Reservation Reservation { get; set; }
        public virtual Client Client { get; set; }
    }
}