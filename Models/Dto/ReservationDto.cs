using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto
{
    public class ReservationDto
    {
        public DateTime date_depart { get; set; }
        public DateTime date_retour { get; set; }
        public int id_vehicule { get; set; }
    }
}