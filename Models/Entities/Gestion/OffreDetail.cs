using AutomotiveApi.Models.Entities.Gestion;

namespace AutomotiveApi.Models.Entities.Core;

public class OffreDetail {
    public int Id { get; set; }
    public int IdOffre { get; set; }
    public string Titre { get; set; }
    public string Description { get; set; }
    public Offre Offre { get; set; }      
}

