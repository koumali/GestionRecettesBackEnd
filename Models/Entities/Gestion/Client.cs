using AutomotiveApi.Models.Entities.Core;
using AutomotiveApi.Models.Entities.Param;
using Newtonsoft.Json;

namespace AutomotiveApi.Models.Entities.Gestion;

public partial class Client : ModelBase
{
    public Client()
    {
        Contrats = new HashSet<Contrat>();
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Tel { get; set; }
    public string Email { get; set; }
    public string Ville { get; set; }

    [JsonIgnore] public string? Password { get; set; }
    public string? ZipCode { get; set; }
    public string? Adresse { get; set; }
    public string? Adresse2 { get; set; }
    public string? PermisRecto { get; set; }
    public string? PermisVerso { get; set; }
    public bool? IsVerified { get; set; } = false;

    public virtual ICollection<Contrat> Contrats { get; set; }
}