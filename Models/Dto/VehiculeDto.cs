namespace AutomotiveApi.Models.Dto;

public class VehiculeDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Matricule { get; set; }
    public double Prix { get; set; }
    public int NbPort { get; set; }
    public int NbPassager { get; set; }
    public int Km { get; set; }
    public bool Climat { get; set; }
    public bool Airbag { get; set; }
    public string Gearbox { get; set; }
    public string Moteur { get; set; }
    public int IdAgence { get; set; }
    public int IdModele { get; set; }
    public string Type { get; set; }
}