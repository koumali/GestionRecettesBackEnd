using System;
using System.Collections.Generic;
using AutomotiveApi.Models.Entities.Core;

namespace AutomotiveApi.Models.Entities.Param
{
    public partial class Log_journal : ModelBase
    {
        public string name_controller { get; set; }
        public string name_fonction { get; set; }
        public string description_message { get; set; }
    }
}