using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto
{
    public class OffreDto
    {
        public int id_vehicule { get; set; }
        public DateTime date_debut { get; set; }
        public DateTime date_fin { get; set; }
        public double prix { get; set; }
    }
}