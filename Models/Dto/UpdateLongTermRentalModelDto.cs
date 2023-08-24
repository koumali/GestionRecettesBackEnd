using AutomotiveApi.Utility;
using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto;

public class UpdateLongTermRentalModelDto
{
    public int Id { get; set; }

    public int? IdAgence { get; set; }

    [Required(ErrorMessage = "la duree est obligatoire")]
    public int Duree { get; set; }

    [Required(ErrorMessage = "le statut est obligatoire")]
    [EnumDataType(typeof(ReservationStatus), ErrorMessage = "le statut n'est pas valide")]
    public string Status { get; set; }

    [Required(ErrorMessage = "le montant total est obligatoire")]
    [Range(0, double.MaxValue, ErrorMessage = "le montant total doit être supérieur à 0")]
    public double MontantTotal { get; set; }
}