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
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ContratsController : ControllerBase
    {
        private readonly IJwt _jwtService;
        private readonly IMapper _mapper;
        private readonly IContrat _contratService;


        public ContratsController(IUser userService, IJwt jwtService, IContrat ContratService, IMapper mapper)
        {
            _jwtService = jwtService;
            _contratService = ContratService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<Contrat>>> GetContrats()
        {
            var contrats = await _contratService.GetAllAsync();
            return Ok(contrats);
        }
        //<summary>
        //Add Contrat
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Contrat>> AddContrat(ContratDto request)
        {
            // var Contrat = new Contrat()
            // {
            // };
            // Contrat.id_client = request.id_client;
            // Contrat.id_reservation = request.id_reservation;

            var contrat = _mapper.Map<Contrat>(request);

            var addedContrat = await _contratService.CreateAsync(contrat);
            return Ok(addedContrat);
        }

        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Contrat>> GetContratById(int id)
        {
            var contrat = await _contratService.GetByIdAsync(id);
            return Ok(contrat);
        }

        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteContrat(int id)
        {
            await _contratService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Contrat>> UpdateContrat(int id, ContratDto request)
        {
            var result = await _contratService.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            // Update the Contrat properties
            // contrat.id_client = request.id_client;
            // contrat.id_reservation = request.id_reservation;

            var contrat = _mapper.Map<Contrat>(request);

            var updatedContrat = await _contratService.UpdateAsync(contrat);
            return Ok(updatedContrat);
        }
    }
}