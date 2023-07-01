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
    public class ModelesController : ControllerBase
    {

        private readonly IJwt _jwtService;
        private readonly IModele _ModeleService;


        public ModelesController(IUser userService, IJwt jwtService, IModele ModeleService)
        {
            _jwtService = jwtService;
            _ModeleService = ModeleService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult<IEnumerable<Modele>> GetModeles()
        {
            var modeles = _ModeleService.getModeles();
            return Ok(modeles);
        }
        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Modele> GetRoleById(int id)
        {
            var modele = _ModeleService.findById(id);
            return Ok(modele);
        }
        //<summary>
        //Add Modele
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Modele> AddModele(ModeleDto request)
        {
            var Modele = new Modele()
            {
                name = request.Name,
                id_marque = request.id_marque
            };
            var addedModele = _ModeleService.add(Modele);
            return Ok(addedModele);
        }
        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteModele(int id)
        {
            _ModeleService.delete(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Modele> UpdateModele(int id, ModeleDto request)
        {
            var Modele = _ModeleService.findById(id);
            if (Modele == null)
            {
                return NotFound();
            }

            // Update the Modele properties
            Modele.name = request.Name;
            Modele.id_marque = request.id_marque;


            var updatedModele = _ModeleService.update(Modele);
            return Ok(updatedModele);
        }
    }

}