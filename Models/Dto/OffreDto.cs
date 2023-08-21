using System.ComponentModel.DataAnnotations;
using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Dto;

public class OffreDto
{
    public int? Id { get; set; }
    public int IdVehicule { get; set; }    
    [OffreDateValidation] public DateTime DateDebut { get; set; }
    [OffreDateValidation] public DateTime DateFin { get; set; }
    public double Prix { get; set; }
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