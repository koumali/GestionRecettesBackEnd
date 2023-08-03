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

    [HasPermission(PredefinedPermissions.Marques)]
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
       [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Marque>>> GetMarques()
        {
            var marques = await _marqueService.GetAllAsync();
            return Ok(marques);
        }
        
 

        [HttpGet("{id}")]          
        public async Task<ActionResult<Marque>> GetMarqueById(int id)
        {
            var marque = await _marqueService.GetByIdAsync(id);
            return Ok(marque);
        }
    
        [HttpPost]
        
        public async Task<ActionResult<Marque>> AddMarque(MarqueDto request)
        {
            var marque = _mapper.Map<Marque>(request);
            var addedMarque = await _marqueService.CreateAsync(marque);
            return Ok(addedMarque);
        }

        [HttpDelete("{id}")]
        
        public async Task<ActionResult> DeleteMarque(int id)
        {
            await _marqueService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        
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