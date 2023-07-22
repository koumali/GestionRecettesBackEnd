using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Gestion.Interfaces;
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


        public OffresController(IOffre offreservice, IMapper mapper)
        {
            _offreservice = offreservice;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Commercial, Gerant")]
        public async Task<ActionResult<IEnumerable<Offre>>> GetOffres()
        {
            var offres = await _offreservice.GetAllAsync();
            return Ok(offres);
        }

        [HttpGet("public")]
        public async Task<ActionResult<IEnumerable<Offre>>> GetPublicOffres(string name,string startDate, string endDate)
        {
            var date1 = (new DateTime(1970, 1, 1)).AddMilliseconds(double.Parse(startDate));
            var date2 = (new DateTime(1970, 1, 1)).AddMilliseconds(double.Parse(endDate));
            var offres = await _offreservice.GetPublicOffres(name, datedebut: date2, datefin:date1);
            
            return Ok(offres);
        }
        [HttpGet("public/{id}")]
        public async Task<ActionResult<Offre>> GetPublicOffreById(int id)
        {
            var offre = await _offreservice.GetPublicByIdAsync(id);
            return Ok(offre);
        }

        [HttpGet("agence/{idAgence}")]
        [Authorize(Roles = "Commercial, Gerant")]
        [ValidatIdAgence("idAgence")]
        public async Task<ActionResult<IEnumerable<Offre>>> GetOffresAgence(int idAgence)
        {
            var offres = await _offreservice.GetOffresAgence(idAgence);
            return Ok(offres);
        }

        //<summary>
        //Add Offre
        //</summary>

        [HttpPost]
        [Authorize(Roles = "Admin, Commercial, Gerant")]
        public async Task<ActionResult<Offre>> AddOffre(OffreDto request)
        {
            var offre = _mapper.Map<Offre>(request);
            var addedOffre = await _offreservice.CreateAsync(offre);
            return Ok(addedOffre);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Offre>> GetOffreById(int id)
        {
            var offre = await _offreservice.GetByIdAsync(id);
            return Ok(offre);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin, Commercial, Gerant")]
        public async Task<ActionResult> DeleteOffre(int id)
        {
            await _offreservice.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin, Commercial, Gerant")]
        public async Task<ActionResult<Offre>> UpdateOffre(int id, OffreDto request)
        {
            var offre = await _offreservice.GetByIdAsync(id);
            if (offre == null)
            {
                return NotFound();
            }

            offre.IdVehicule = request.IdVehicule;
            offre.DateDebut = request.DateDebut;
            offre.DateFin = request.DateFin;
            offre.Prix = request.Prix;
            offre.isPublic = request.isPublic;
            offre.Id = id;
            var updatedOffre = await _offreservice.UpdateAsync(offre);
            return Ok(updatedOffre);
        }
    }
}
