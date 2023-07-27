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
    public class LLDResponsesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILLDResponse _LLDResponseService;
        private readonly IMarque _marqueService;


        public LLDResponsesController(ILLDResponse LLDResponseService, IMapper mapper, IMarque marqueService)
        {
            _LLDResponseService = LLDResponseService;
            _marqueService = marqueService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Commercial, Agent, Gerant")]
        public async Task<ActionResult<IEnumerable<LLDResponse>>> GetLLDResponses()
        {
            var LLDResponses = await _LLDResponseService.GetAllAsync();
            return Ok(LLDResponses);
        }

        /*[HttpGet("agence/{idAgence}")]
        [Authorize(Roles = "Commercial, Gerant, Agent")]
        [ValidatIdAgence("idAgence")]
        public async Task<ActionResult<IEnumerable<LLDResponse>>> GetLLDResponsesAgence(int idAgence)
        {
            var LLDResponses = await _LLDResponseService.GetLLDResponsesAgence(idAgence);
            return Ok(LLDResponses);
        }*/

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin, Commercial, Agent, Gerant")]
        public async Task<ActionResult<LLDResponse>> GetLLDResponseById(int id)
        {
            var LLDResponse = await _LLDResponseService.GetByIdAsync(id);
            return Ok(LLDResponse);
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Commercial, Agent, Gerant")]
        public async Task<ActionResult<LLDResponse>> AddLLDResponse([FromForm] LLDResponseDto request)
        {
            var LLDResponse = _mapper.Map<LLDResponse>(request);

            var marque = await _marqueService.GetByIdAsync(request.idLongTermRental);

            var addedLLDResponse = await _LLDResponseService.CreateAsync(LLDResponse);
            return Ok(addedLLDResponse);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin, Commercial, Agent, Gerant")]
        public async Task<ActionResult> DeleteLLDResponse(int id)
        {
            await _LLDResponseService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin, Commercial, Agent, Gerant")]
        public async Task<ActionResult<LLDResponse>> UpdateLLDResponse(int id, [FromForm] LLDResponseDto request)
        {
            if (id != request.idLongTermRental)
            {
                return BadRequest(new { errors = "Id in body doesn't match Id in URI" });
            }

            var LLDResponse = await _LLDResponseService.GetByIdAsync(id);

            LLDResponse.description = request.description;
            LLDResponse.prix = request.prix;
            var updatedLLDResponse = await _LLDResponseService.UpdateAsync(LLDResponse);
            return Ok(updatedLLDResponse);
        }
    }
}