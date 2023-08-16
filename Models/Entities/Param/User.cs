using System.ComponentModel.DataAnnotations.Schema;
using AutomotiveApi.Models.Entities.Core;
using AutomotiveApi.Models.Entities.Gestion;
using Newtonsoft.Json;

namespace AutomotiveApi.Models.Entities.Param;

public partial class User : ModelBase
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    //ignore password when serializing

    [JsonIgnore] public string Password { get; set; }
    public bool? IsActive { get; set; }

    public int IdRole { get; set; }

    // [ForeignKey("IdRole")] 
    public virtual Role Role { get; set; }

    public int? IdAgence { get; set; }

    // [ForeignKey("IdAgence")] 
    public virtual Agence Agence { get; set; }

    public bool? IsVerified { get; set; }=false;
}