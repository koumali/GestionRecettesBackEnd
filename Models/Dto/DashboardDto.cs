namespace AutomotiveApi.Models.Dto;

public class DashboardDto
{
    public int AgencesVerified { get; set; }    
    public int AgencesNotVerified { get; set; }
    public int Clients { get; set; }
    public int Users { get; set; }
    public int Marques { get; set; }
    public int Modeles { get; set; }
    public int Offres { get; set; }
    public int Vehicules { get; set; }
    public int Reservations { get; set; }
    
    public int Lld { get; set; }
}