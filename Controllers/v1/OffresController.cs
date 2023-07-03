using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion;
using AutomotiveApi.Services.Param;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1
{

    [ApiController]

    [Route("api/v1/[controller]")]

    public class OffresController : ControllerBase
    {
        private readonly IOffre _Offreservice;


        public OffresController(IUser userService,  IOffre Offreservice)
        {
            _Offreservice = Offreservice;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult<IEnumerable<Offre>> GetOffres()
        {
            var Offres = _Offreservice.getOffres();
            return Ok(Offres);
        }
        //<summary>
        //Add Offre
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Offre> AddOffre(OffreDto request)
        {
            var Offre = new Offre()
            {
                id_vehicule= request.id_vehicule,
                date_debut = request.date_debut,
                date_fin = request.date_fin,
                prix = request.prix,
    };
            var addedOffre = _Offreservice.add(Offre);
            return Ok(addedOffre);
        }
        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Offre> GetOffreById(int id)
        {
            var Offre = _Offreservice.findById(id);
            return Ok(Offre);
        }
        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteOffre(int id)
        {
            _Offreservice.delete(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Offre> UpdateOffre(int id, OffreDto request)
        {
            var offre = _Offreservice.findById(id);
            if (offre == null)
            {
                return NotFound();
            }

            // Update the Offre properties
            offre.id_vehicule = request.id_vehicule;
            offre.date_debut = request.date_debut;
            offre.date_fin = request.date_fin;
            offre.prix = request.prix;

            var updatedOffre = _Offreservice.update(offre);
            return Ok(updatedOffre);
        }
    }

}