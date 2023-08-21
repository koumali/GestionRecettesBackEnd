namespace AutomotiveApi.Models.Dto;

public class MaReservationDto
{
    public DateTime CreatedAt { get; set; }
    public DateTime DateDepart { get; set; }
    public DateTime DateRetour { get; set; }
    public string? ModelName { get; set; }
    public string? MarqueName { get; set; }
    public string? Status { get; set; }
    public string? ClientName { get; set; }
    public string? NumeroReservation { get; set; }
}
