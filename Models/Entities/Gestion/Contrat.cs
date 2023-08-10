using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Entities.Gestion;

public partial class Contrat : ModelBase
{
    public int IdClient { get; set; }
    public int IdReservation { get; set; }
    public virtual Reservation Reservation { get; set; }

    public bool IsConducteur { get; set; }

    // [ForeignKey("IdClient")]
    public virtual Client Client { get; set; }
}