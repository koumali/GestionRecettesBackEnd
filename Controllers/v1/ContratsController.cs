using automotiveApi.Models;
using automotiveApi.Models.Dto;
using automotiveApi.Services.Gestion;
using automotiveApi.Services.Jwt;
using automotiveApi.Services.Param;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace automotiveApi.Controllers.v1
{

    [ApiController]

    [Route("api/v1/[controller]")]

    public class ContratsController : ControllerBase
    {

        private readonly IJwt _jwtService;
        private readonly IContrat _ContratService;


        public ContratsController(IUser userService, IJwt jwtService, IContrat ContratService)
        {
            _jwtService = jwtService;
            _ContratService = ContratService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult<IEnumerable<Contrat>> GetContrats()
        {
            var Contrats = _ContratService.getContrats();
            return Ok(Contrats);
        }
        //<summary>
        //Add Contrat
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Contrat> AddContrat(ContratDto request)
        {
            var Contrat = new Contrat()
            {
            };
            Contrat.id_client = request.id_client;
            Contrat.id_reservation = request.id_reservation;

        var addedContrat = _ContratService.add(Contrat);
            return Ok(addedContrat);
        }
        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Contrat> GetContratById(int id)
        {
            var Contrat = _ContratService.findById(id);
            return Ok(Contrat);
        }
        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteContrat(int id)
        {
            _ContratService.delete(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Contrat> UpdateContrat(int id, ContratDto request)
        {
            var Contrat = _ContratService.findById(id);
            if (Contrat == null)
            {
                return NotFound();
            }

            // Update the Contrat properties
            Contrat.id_client = request.id_client;
            Contrat.id_reservation = request.id_reservation;

            var updatedContrat = _ContratService.update(Contrat);
            return Ok(updatedContrat);
        }
    }

}