using System;
using System.Collections.Generic;

namespace automotiveApi.Models
{
    public partial class Log_journal:ModelBase
    {
        public string name_controller { get; set; }
        public string name_fonction { get; set; }
        public string description_message { get; set; }
    }
}
