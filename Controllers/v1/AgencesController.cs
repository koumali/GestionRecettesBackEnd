using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IMailService = AutomotiveApi.Services.Mail.IMailService;

namespace AutomotiveApi.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AgencesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAgence _agenceService;
        private readonly IMailService _mailService;

        public AgencesController(IAgence agenceService, IMapper mapper, IMailService mailService)
        {
            _agenceService = agenceService;
            _mapper = mapper;
            _mailService = mailService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Agence>>> GetVerifiedAgences()
        {
            return Ok(await _agenceService.GetAllAsync());
        }
        [HttpGet("agences")]
        public async Task<ActionResult<IEnumerable<dynamic>>> GetAllAgences()
        {

            return Ok(await _agenceService.GetAllAgencesAsync());
        }

        [HttpGet("notVerified")]
        // 

        public async Task<ActionResult<IEnumerable<Agence>>> GetNotVerifiedAgences()
        {
            return Ok(await _agenceService.GetAllNotVerifiedAsync());
        }

        [HttpGet("Villes")]
        public async Task<ActionResult<IEnumerable<string>>> GetAgencesVilles()
        {
            return Ok(await _agenceService.GetAllVilleAsync());
        }
        //<summary>
        //Add Agence
        //</summary>

        [HttpPost]
        // 
        public async Task<ActionResult<Agence>> AddAgence(AgenceDto request)
        {
            var agence = _mapper.Map<Agence>(request);
            var addedAgence = await _agenceService.CreateAsync(agence);

            return CreatedAtAction(nameof(GetAgenceById), new { id = addedAgence.Id }, addedAgence);
        }

        [HttpPost("client")]
        public async Task<ActionResult<Agence>> AddClientAgence(AgenceClientDto request)
        {
            var agence = _mapper.Map<Agence>(request);

            var addedAgence = await _agenceService.CreateAsync(agence);

            MailData mailData = new MailData
            {
                Subject = "Agence ajoutée",
                Body = "Votre agence a été ajoutée avec succès",
                To = request.Email
            };

            await _mailService.SendAsync(mailData);


            return CreatedAtAction(nameof(GetAgenceById), new { id = addedAgence.Id }, addedAgence);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Agence>> GetAgenceById(int id)
        {
            var agence = await _agenceService.GetByIdAsync(id);
            return Ok(agence);
        }

        [HttpDelete("{id}")]
        // 
        public async Task<ActionResult> DeleteAgence(int id)
        {
            await _agenceService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        // 
        public async Task<ActionResult<Agence>> UpdateAgence(int id, AgenceDto request)
        {
            var agence = await _agenceService.GetByIdAsync(id);
            if (agence == null) return NotFound();

            agence.Name = request.Name;
            agence.Tel = request.Tel;
            agence.Email = request.Email;
            agence.Address = request.Address;
            agence.City = request.City;
            agence.ZipCode = request.ZipCode;
            agence.Latitude = request.Latitude;
            agence.Longitude = request.Longitude;
            agence.IsVerified = request.IsVerified;

            var updatedAgence = await _agenceService.UpdateAsync(agence);
            return Ok(updatedAgence);
        }
    }
}