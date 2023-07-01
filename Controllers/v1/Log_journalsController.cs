using automotiveApi.Models;
using automotiveApi.Services.Gestion;
using automotiveApi.Services.Param;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace automotiveApi.Controllers.v1
{

    [ApiController]

    [Route("api/v1/[controller]")]

    public class Log_journalsController : ControllerBase
    {
        private readonly ILog_journal _Log_journalService;

        public Log_journalsController(ILog_journal Log_journalService)
        {
            _Log_journalService = Log_journalService;
        }


        [HttpGet("")]
        [Authorize(Roles = "Admin")]
        public ActionResult<IEnumerable<Log_journal>> GetLog_journals()
        {
            var Log_journals = _Log_journalService.getLog_journals();
            return Ok(Log_journals);
        }
        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Client> GetClientById(int id)
        {
            var Client = _Log_journalService.findById(id);
            return Ok(Client);
        }

    }


}