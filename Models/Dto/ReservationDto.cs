namespace AutomotiveApi.Models.Dto;

public class ReservationDto
{
    public int Id { get; set; }
    public DateTime DateDepart { get; set; }
    public DateTime DateRetour { get; set; }        
    public string Status { get; set; }
    public double MontantTotal { get; set; }
}