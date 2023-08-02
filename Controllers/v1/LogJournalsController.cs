using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Param;
using Microsoft.AspNetCore.Mvc;
using Permission = AutomotiveApi.Utility.Permission;

namespace AutomotiveApi.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [HasPermission(Permission.PlatformTopLevelPermission)]
    public class LogJournalsController : ControllerBase
    {
        private readonly ILogJournal _logJournalService;

        public LogJournalsController(ILogJournal logJournalService)
        {
            _logJournalService = logJournalService;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Log_journal>> GetLog_journals()
        {
            var logJournals = _logJournalService.getLog_journals();
            return Ok(logJournals);
        }

        [HttpGet("{id}")]
        public ActionResult<Client> GetClientById(int id)
        {
            var client = _logJournalService.findById(id);
            return Ok(client);
        }
    }
}