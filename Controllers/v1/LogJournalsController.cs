using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Param;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1
{

    [ApiController]

    [Route("api/v1/[controller]")]

    public class LogJournalsController : ControllerBase
    {
        private readonly ILogJournal _logJournalService;

        public LogJournalsController(ILogJournal logJournalService)
        {
            _logJournalService = logJournalService;
        }


        [HttpGet("")]
        [Authorize(Roles = "Admin")]
        public ActionResult<IEnumerable<Log_journal>> GetLog_journals()
        {
            var logJournals = _logJournalService.getLog_journals();
            return Ok(logJournals);
        }
        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Client> GetClientById(int id)
        {
            var client = _logJournalService.findById(id);
            return Ok(client);
        }

    }


}