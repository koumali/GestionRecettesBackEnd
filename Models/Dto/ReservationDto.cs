using System.ComponentModel.DataAnnotations;
using AutomotiveApi.Utility;

namespace AutomotiveApi.Models.Dto;

public class ReservationDto
{

    
    public int Id { get; set; }

    [Required(ErrorMessage = "la date de départ est obligatoire")]
    [ResDateValidation]
    public DateTime DateDepart { get; set; }

    [Required(ErrorMessage = "la date de retour est obligatoire")]
    [ResDateValidation]
    public DateTime DateRetour { get; set; }        

    [Required(ErrorMessage = "le statut est obligatoire")]
    [EnumDataType(typeof(ReservationStatus), ErrorMessage = "le statut n'est pas valide")]
    public string Status { get; set; }

    [Required(ErrorMessage = "le montant total est obligatoire")]
    [Range(0, double.MaxValue, ErrorMessage = "le montant total doit être supérieur à 0")]
    public double MontantTotal { get; set; }
}


public class ResDateValidation : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        ReservationDto reservation = (ReservationDto)validationContext.ObjectInstance;
        if (reservation.DateDepart > reservation.DateRetour)
        {
            return new ValidationResult("La date de départ doit être inférieure à la date de retour");
        }

        return ValidationResult.Success;
    }
}