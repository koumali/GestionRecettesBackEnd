using automotiveApi.Models.Dto;
using automotiveApi.Models;
using automotiveApi.Services.Jwt;
using automotiveApi.Services.Param;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using automotiveApi.Services.Gestion;

namespace automotive_api.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MarquesController : ControllerBase
    {

        private readonly IJwt _jwtService;
        private readonly IMarque _marqueService;


        public MarquesController(IUser userService, IJwt jwtService, IMarque marqueService)
        {
            _jwtService = jwtService;
            _marqueService = marqueService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult<IEnumerable<Marque>> GetMarques()
        {
            var Marques = _marqueService.getMarques();
            return Ok(Marques);
        }
        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Marque> GetRoleById(int id)
        {
            var marque = _marqueService.findById(id);
            return Ok(marque);
        }
        //<summary>
        //Add Marque
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Marque> AddMarque(MarqueDto request)
        {
            var Marque = new Marque()
            {
                name = request.Name
            };
            var addedMarque = _marqueService.add(Marque);
            return Ok(addedMarque);
        }
        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteMarque(int id)
        {
            _marqueService.delete(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Marque> UpdateMarque(int id, MarqueDto request)
        {
            var Marque = _marqueService.findById(id);
            if (Marque == null)
            {
                return NotFound();
            }

            // Update the Marque properties
            Marque.name = request.Name;

            var updatedMarque = _marqueService.update(Marque);
            return Ok(updatedMarque);
        }
    }

}