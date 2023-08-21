namespace AutomotiveApi.Models.Dto;

public class FullReservationDto
{
    public int Id { get; set; }
    public DateTime DateDepart { get; set; }
    public DateTime DateRetour { get; set; }
    public int IdVehicule { get; set; }
    public double MontantTotal { get; set; }

    // array of clientdto
    public ICollection<ClientDto> Conducteurs { get; set; }
}