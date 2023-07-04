using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Services.Param;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class OffresController : ControllerBase
    {
        private readonly IOffre _offreservice;
        private readonly IMapper _mapper;


        public OffresController(IUser userService, IOffre Offreservice, IMapper mapper)
        {
            _offreservice = Offreservice;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<Offre>>> GetOffres()
        {
            var offres = await _offreservice.GetAllAsync();
            return Ok(offres);
        }
        //<summary>
        //Add Offre
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Offre>> AddOffre(OffreDto request)
        {
            var offre = _mapper.Map<Offre>(request);
            var addedOffre = await _offreservice.CreateAsync(offre);
            return Ok(addedOffre);
        }

        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Offre>> GetOffreById(int id)
        {
            var offre = await _offreservice.GetByIdAsync(id);
            return Ok(offre);
        }

        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteOffre(int id)
        {
            await _offreservice.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Offre>> UpdateOffre(int id, OffreDto request)
        {
            var result = await _offreservice.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            // Update the Offre properties
            var offre = _mapper.Map<Offre>(request);
            // offre.id_vehicule = request.id_vehicule;
            // offre.date_debut = request.date_debut;
            // offre.date_fin = request.date_fin;
            // offre.prix = request.prix;

            var updatedOffre = await _offreservice.UpdateAsync(offre);
            return Ok(updatedOffre);
        }
    }
}