using System.ComponentModel.DataAnnotations;

namespace AutomotiveApi.Models.Dto
{
    public class ContratDto
    {
        public int id_client { get; set; }
        public int id_reservation { get; set; }
    }
}