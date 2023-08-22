using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto;

public class ContratDto
{
    [Required(ErrorMessage = "un client est requis")]
    public int IdClient { get; set; }

    [Required(ErrorMessage = "une réservation est requise")]
    public int IdReservation { get; set; }

    [Required(ErrorMessage = "une etat est requise")]
    public bool IsConducteur { get; set; }
}