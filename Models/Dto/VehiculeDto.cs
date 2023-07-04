using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto
{
    public class VehiculeDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Matricule { get; set; }
        public double Prix { get; set; }
        public int NbPort { get; set; }
        public int NbPassager { get; set; }
        public int Km { get; set; }
        public bool Climat { get; set; }
        public bool Airbag { get; set; }
        public string Image { get; set; }
        public string Gearbox { get; set; }
        public string Moteur { get; set; }
        public int IdAgence { get; set; }
        public int IdMarque { get; set; }
        public int IdModele { get; set; }
    }
}