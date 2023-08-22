using System.ComponentModel.DataAnnotations;
using AutomotiveApi.Utility;

namespace AutomotiveApi.Models.Dto;

public class LongTermRentalDto
{
    [Required(ErrorMessage = "le prénom est obligatoire")]
    public string prenom { get; set; }

    [Required(ErrorMessage = "le nom est obligatoire")]
    public string nom { get; set; }

    [Required(ErrorMessage = "le téléphone est obligatoire")]
    public string phone { get; set; }

    [Required(ErrorMessage = "la ville est obligatoire")]
    public string ville { get; set; }

    [Required(ErrorMessage = "l'email est obligatoire")]
    [EmailAddress(ErrorMessage = "l'email n'est pas valide")]
    public string email { get; set; }


    [Required(ErrorMessage = "le code postal est obligatoire")]
    public string zip { get; set; }

    [Required(ErrorMessage = "le nom d'estreprise est obligatoire")]
    public string entreprise { get; set; }

    [Required(ErrorMessage = "la durée est obligatoire")]
    [Range(1, 100, ErrorMessage = "la durée doit être comprise entre 1 et 100 mois")]
    public int duree { get; set; }

    [Required(ErrorMessage = "un modèle est requis")]
    public int idModele { get; set; }

    [Required(ErrorMessage = "la description est obligatoire")]
    public string description { get; set; }

    [Required(ErrorMessage = "le type du boite de vitesse est obligatoire")]
    [EnumDataType(typeof(VehiculeGearbox), ErrorMessage = "ce type de boite de vitesse n'existe pas")]
    public string Gearbox { get; set; }

    [Required(ErrorMessage = "le type du moteur est obligatoire")]
    [EnumDataType(typeof(VehiculeMoteur), ErrorMessage = "ce type de moteur n'existe pas")]
    public string Moteur { get; set; }

    [Required(ErrorMessage = "vous devez sélectionner au moins une agence")]
    public List<int> selectedAgences { get; set; }
}