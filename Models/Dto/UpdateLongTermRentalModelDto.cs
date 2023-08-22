using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto;

public class UpdateLongTermRentalModelDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "l'agence est obligatoire")]
    public int IdAgence { get; set; }

    [Required(ErrorMessage = "le montant total est obligatoire")]
    [Range(0, double.MaxValue, ErrorMessage = "le montant total doit être supérieur à 0")]
    public double MontantTotal { get; set; }
}