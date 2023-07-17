﻿using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AgencesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAgence _agenceService;

        public AgencesController(IAgence agenceService, IMapper mapper)
        {
            _agenceService = agenceService;
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

        [HttpPost]
        [Authorize(Roles = "Admin")]
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
            return CreatedAtAction(nameof(GetAgenceById), new { id = addedAgence.Id }, addedAgence);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin, Commercial, Agent, Gerant")]
        public async Task<ActionResult<Agence>> GetAgenceById(int id)
        {
            var agence = await _agenceService.GetByIdAsync(id);
            return Ok(agence);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteAgence(int id)
        {
            await _agenceService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
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

            var updatedAgence = await _agenceService.UpdateAsync(agence);
            return Ok(updatedAgence);
        }
    }
}