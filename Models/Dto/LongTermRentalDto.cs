namespace AutomotiveApi.Models.Dto
{
    public class LongTermRentalDto
    {
        public string prenom { get; set; }
        public string nom { get; set; }
        public string phone { get; set; }
        public string ville { get; set; }
        public string email { get; set; }
        public string zip { get; set; }
        public string entreprise { get; set; }
        public int duree { get; set; }
        public int idModele { get; set; }
        public string description { get; set; }
    }
}