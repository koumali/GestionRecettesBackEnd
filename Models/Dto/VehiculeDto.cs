using System.ComponentModel.DataAnnotations;

namespace automotiveApi.Models.Dto
{
    public class VehiculeDto
    {
        [Required]
        [MaxLength(50)]
        public string name { get; set; }
        public string matricule { get; set; }
        public double prix { get; set; }
        public int nb_port { get; set; }
        public int nb_passager { get; set; }
        public int km { get; set; }
        public bool climat { get; set; }
        public bool airbag { get; set; }
        public string image { get; set; }
        public string gearbox { get; set; }
        public string moteur { get; set; }
        public int id_agence { get; set; }
        public int id_marque { get; set; }
        public int id_modele { get; set; }
    }
}