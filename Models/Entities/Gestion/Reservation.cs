using System.ComponentModel.DataAnnotations.Schema;
using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Entities.Gestion;

public partial class Reservation : ModelBase
{
    public Reservation()
    {
        Contrats = new HashSet<Contrat>();
    }

    public DateTime DateDepart { get; set; }
    public DateTime DateRetour { get; set; }
    public int IdVehicule { get; set; }
    public string NumeroReservation { get; set; }
    public string Status { get; set; }
    public virtual Vehicule Vehicule { get; set; }
    public virtual ICollection<Contrat> Contrats { get; set; }
    public virtual ICollection<Notification> Notifications { get; set; }
}