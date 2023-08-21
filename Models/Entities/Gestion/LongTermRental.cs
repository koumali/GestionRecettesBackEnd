using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Entities.Gestion;

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
    public string description { get; set; }
    public string NumeroReservation { get; set; }
    public string status { get; set; }
    public int? idAgence { get; set; }
    public int IdModele { get; set; }
    public string Gearbox { get; set; }
    public string Moteur { get; set; }
    public virtual Modele Modele { get; set; }
    public virtual Agence Agence { get; set; }
    public virtual ICollection<LLDResponse> LLDResponses { get; set; }
    public virtual ICollection<Notification> Notifications { get; set; }
    public ICollection<AgenceLongTermRental> AgenceLongTermRentals { get; set; }
}