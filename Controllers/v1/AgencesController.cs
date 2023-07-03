using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion;
using AutomotiveApi.Services.Jwt;
using AutomotiveApi.Services.Param;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]

    public class AgencesController : ControllerBase
    {
        private readonly IJwt _jwtService;

        private readonly IAgence _AgenceService;

        public AgencesController(IUser userService, IJwt jwtService, IAgence AgenceService)
        {
            _jwtService = jwtService;
            _AgenceService = AgenceService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult<IEnumerable<Agence>> GetAgences()
        {
            var Agences = _AgenceService.getAgences();
            return Ok(Agences);
        }
        //<summary>
        //Add Agence
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin")]

        public ActionResult<Agence> AddAgence(AgenceDto request)
        {
            var agence = new Agence()
            {
            };
            agence.name = request.name;
            agence.tel = request.tel;
            agence.email = request.email;
            agence.address = request.address;
            agence.city = request.city;
            agence.zip_code = request.zip_code;
            agence.latitude = request.latitude;
            agence.longitude = request.longitude;

            var addedAgence = _AgenceService.add(agence);
            return Ok(addedAgence);
        }

        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Agence> GetAgenceById(int id)
        {
            var agence = _AgenceService.findById(id);
            return Ok(agence);
        }

        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteAgence(int id)
        {
            _AgenceService.delete(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Agence> UpdateAgence(int id, AgenceDto request)
        {
            var agence = _AgenceService.findById(id);
            if (agence == null)
            {
                return NotFound();
            }

            // Update the Agence properties
            agence.name = request.name;
            agence.tel = request.tel;
            agence.email = request.email;
            agence.address = request.address;
            agence.city = request.city;
            agence.zip_code = request.zip_code;
            agence.latitude = request.latitude;
            agence.longitude = request.longitude;

            var updatedAgence = _AgenceService.update(agence);
            return Ok(updatedAgence);
        }
    }

}