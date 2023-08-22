using System.ComponentModel.DataAnnotations;
using AutomotiveApi.Utility;

namespace AutomotiveApi.Models.Dto;

public class VehiculeDto
{
    public int Id { get; set; }

    public string? Name { get; set; }

    [Required(ErrorMessage = "la matricule est obligatoire")]
    public string Matricule { get; set; }

    [Required(ErrorMessage = "le prix est obligatoire")]
    public double Prix { get; set; }

    [Required(ErrorMessage = "le nombre de portes est obligatoire")]
    public int NbPort { get; set; }

    [Required(ErrorMessage = "le nombre de passagers est obligatoire")]
    public int NbPassager { get; set; }

    [Required(ErrorMessage = "le kilométrage est obligatoire")]
    public int Km { get; set; }

    [Required(ErrorMessage = "l'état de climatisation est obligatoire")]
    public bool Climat { get; set; }

    [Required(ErrorMessage = "l'état de airbag est obligatoire")]
    public bool Airbag { get; set; }

    [Required(ErrorMessage = "le type de boite de vitesse est obligatoire")]
    [EnumDataType(typeof(VehiculeGearbox), ErrorMessage = "ce type de boite de vitesse n'existe pas")]
    public string Gearbox { get; set; }

    [Required(ErrorMessage = "le type de carburant est obligatoire")]
    [EnumDataType(typeof(VehiculeMoteur), ErrorMessage = "ce type de carburant n'existe pas")]
    public string Moteur { get; set; }

    [Required(ErrorMessage = "l'agency est obligatoire")]
    public int IdAgence { get; set; }

    [Required(ErrorMessage = "le modèle est obligatoire")]
    public int IdModele { get; set; }

    [Required(ErrorMessage = "le type est obligatoire")]

    [EnumDataType(typeof(VehiculeTypes), ErrorMessage = "ce type de vehicule n'existe pas")]
    public string Type { get; set; }
}