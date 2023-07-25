using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Attributes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Utility;

namespace AutomotiveApi.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MarquesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMarque _marqueService;


        public MarquesController(IMarque marqueService, IMapper mapper)
        {
            _marqueService = marqueService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Marque>>> GetMarques()
        {
            var marques = await _marqueService.GetAllAsync();
            return Ok(marques);
        }
        
       // [HttpGet("agence/{idAgence}")]
       //  // [Authorize(Roles = "Commercial, Agent, Gerant")]
       // [ValidatIdAgence("idAgence")]
       //  public async Task<ActionResult<IEnumerable<Marque>>> GetMarquesAgence(int idAgence)
       //  {
       //      var marques = await _marqueService.GetMarquesAgence(idAgence);
       //      return Ok(marques);
       //  }

        [HttpGet("{id}")]
        // [Authorize(Roles = "Admin, Commercial, Agent, Gerant")]
        [HasPermission(Permission.AgencyThirdLevelPermission)]
        public async Task<ActionResult<Marque>> GetMarqueById(int id)
        {
            var marque = await _marqueService.GetByIdAsync(id);
            return Ok(marque);
        }
        //<summary>
        //Add Marque
        //</summary>

        [HttpPost]
        [HasPermission(Permission.PlatformTopLevelPermission)]
        public async Task<ActionResult<Marque>> AddMarque(MarqueDto request)
        {
            var marque = _mapper.Map<Marque>(request);
            var addedMarque = await _marqueService.CreateAsync(marque);
            return Ok(addedMarque);
        }

        [HttpDelete("{id}")]
        [HasPermission(Permission.PlatformTopLevelPermission)]
        public async Task<ActionResult> DeleteMarque(int id)
        {
            await _marqueService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        [HasPermission(Permission.PlatformTopLevelPermission)]
        public async Task<ActionResult<Marque>> UpdateMarque(int id, MarqueDto request)
        {
            var marque = await _marqueService.GetByIdAsync(id);
            if (marque == null)
            {
                return NotFound();
            }

            // Update the Marque properties
            marque.Name = request.Name;
            var updatedMarque = await _marqueService.UpdateAsync(marque);
            return Ok(updatedMarque);
        }
    }
}