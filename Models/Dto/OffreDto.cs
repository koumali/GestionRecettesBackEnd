using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto
{
    public class OffreDto
    {
        public int IdVehicule { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public double Prix { get; set; }
    }
}