using System.ComponentModel.DataAnnotations;
using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Dto;

public class OffreDto
{
    public int? Id { get; set; }

    [Required(ErrorMessage = "la véhicule est obligatoire")]
    public int IdVehicule { get; set; }

    [Required(ErrorMessage = "la date de début est obligatoire")]
    [OffreDateValidation]
    public DateTime DateDebut { get; set; }
    
    [Required(ErrorMessage = "la date de fin est obligatoire")]
    [OffreDateValidation]
    public DateTime DateFin { get; set; }

    [Required(ErrorMessage = "le prix est obligatoire")]
    [Range(0, double.MaxValue, ErrorMessage = "le prix doit être supérieur à 0")]
    public double Prix { get; set; }

    [Required(ErrorMessage = "le statut est obligatoire")]    
    public bool isPublic { get; set; }
    public OffreDetailDto[]? OffreDetails { get; set; }
}

public class OffreDetailDto
{
    public int? Id { get; set; }
    public int IdOffre { get; set; }
    public string Titre { get; set; }
    public string Description { get; set; }
}

public class OffreDateValidation : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        OffreDto offre = (OffreDto)validationContext.ObjectInstance;
        if (offre.DateDebut > offre.DateFin)
        {
            return new ValidationResult("La date de début doit être inférieure à la date de fin");
        }

        return ValidationResult.Success;
    }
}