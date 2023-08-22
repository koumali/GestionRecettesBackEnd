using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto;

public class FullReservationDto
{

    public int Id { get; set; }

    [Required(ErrorMessage = "la date de départ est obligatoire")]
    public DateTime DateDepart { get; set; }

    [Required(ErrorMessage = "la date de retour est obligatoire")]
    public DateTime DateRetour { get; set; }

    [Required(ErrorMessage = "la véhicule est obligatoire")]
    public int IdVehicule { get; set; }

    [Required(ErrorMessage = "le montant total est obligatoire")]
    [Range(0, double.MaxValue, ErrorMessage = "le montant total doit être supérieur à 0")]
    public double MontantTotal { get; set; }

    

    // array of clientdto
    public ICollection<ClientDto> Conducteurs { get; set; }
}