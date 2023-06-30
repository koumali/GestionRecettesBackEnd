using System.ComponentModel.DataAnnotations;

namespace automotiveApi.Models.Dto
{
    public class OffreDto
    {
        public int id_vehicule { get; set; }
        public int id_agence { get; set; }
        public DateTime date_debut { get; set; }
        public DateTime date_fin { get; set; }
        public double prix { get; set; }
    }
}