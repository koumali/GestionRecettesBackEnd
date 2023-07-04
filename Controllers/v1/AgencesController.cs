using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
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
        private readonly IMapper _mapper;
        private readonly IAgence _agenceService;

        public AgencesController(IUser userService, IJwt jwtService, IAgence AgenceService, IMapper mapper)
        {
            _jwtService = jwtService;
            _agenceService = AgenceService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<Agence>>> GetAgences()
        {
            return Ok(await _agenceService.GetAllAsync());
        }
        //<summary>
        //Add Agence
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Agence>> AddAgence(AgenceDto request)
        {
            // var agence = new Agence()
            // {
            // };
            // agence.name = request.name;
            // agence.tel = request.tel;
            // agence.email = request.email;
            // agence.address = request.address;
            // agence.city = request.city;
            // agence.zip_code = request.zip_code;
            // agence.latitude = request.latitude;
            // agence.longitude = request.longitude;
            var agence = _mapper.Map<Agence>(request);

            var addedAgence = await _agenceService.CreateAsync(agence);
            return Ok(addedAgence);
        }

        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Agence>> GetAgenceById(int id)
        {
            var agence = await _agenceService.GetByIdAsync(id);
            return Ok(agence);
        }

        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteAgence(int id)
        {
            await _agenceService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Agence>> UpdateAgence(int id, AgenceDto request)
        {
            var result = await _agenceService.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            // Update the Agence properties
            // agence.name = request.name;
            // agence.tel = request.tel;
            // agence.email = request.email;
            // agence.address = request.address;
            // agence.city = request.city;
            // agence.zip_code = request.zip_code;
            // agence.latitude = request.latitude;
            // agence.longitude = request.longitude;
            var agence = _mapper.Map<Agence>(request);

            var updatedAgence = await _agenceService.UpdateAsync(agence);
            return Ok(updatedAgence);
        }
    }
}