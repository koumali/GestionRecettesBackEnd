using AutomotiveApi.Models.Entities.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomotiveApi.Models.Entities.Gestion;

public class PieceJointes : ModelBase
{
    public string FileName { get; set; }
    public LLDResponse LLDReponse { get; set; }
    [ForeignKey("LLDReponse")]
    public int IdLLDReponse { get; set; }
}
