using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto;

public class OffreDto
{
    public int IdVehicule { get; set; }


    [OffreDateValidation] public DateTime DateDebut { get; set; }
    [OffreDateValidation] public DateTime DateFin { get; set; }
    public double Prix { get; set; }
    public bool isPublic { get; set; }
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