using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Entities.Param;

public partial class Log_journal : ModelBase
{
    public string NameController { get; set; }
    public string NameFonction { get; set; }
    public string DescriptionMessage { get; set; }
}