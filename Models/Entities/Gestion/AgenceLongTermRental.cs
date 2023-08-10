namespace AutomotiveApi.Models.Entities.Gestion;

public class AgenceLongTermRental
{
    public int AgenceId { get; set; }
    public int LongTermRentalId { get; set; }

    public Agence Agence { get; set; }
    public LongTermRental LongTermRental { get; set; }
}