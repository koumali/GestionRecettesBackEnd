namespace AutomotiveApi.Models.Dto;

public class ReservationDto
{
    public DateTime DateDepart { get; set; }
    public DateTime DateRetour { get; set; }
    public int IdVehicule { get; set; }
    public string Status { get; set; }
}