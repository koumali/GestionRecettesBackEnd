﻿using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AutomotiveApi.Services.Gestion.Interfaces;

namespace AutomotiveApi.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ModelesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IModele _modeleService;


        public ModelesController(IModele modeleService, IMapper mapper)
        {
            _modeleService = modeleService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<Modele>>> GetModeles()
        {
            var modeles = await _modeleService.GetAllAsync();
            return Ok(modeles);
        }
        
        [HttpGet("{id}")]
        [Authorize(Roles = "Commercial, Gerant, Agent")]
        public async Task<ActionResult<IEnumerable<Modele>>> GetModelesAgence(int id)
        {
            var modeles = await _modeleService.GetModelesAgence(id);
            return Ok(modeles);
        }

        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Modele>> GetRoleById(int id)
        {
            var modele = await _modeleService.GetByIdAsync(id);
            return Ok(modele);
        }
        //<summary>
        //Add Modele
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Modele>> AddModele(ModeleDto request)
        {
            var modele = _mapper.Map<Modele>(request);
            var addedModele = await _modeleService.CreateAsync(modele);
            return Ok(addedModele);
        }

        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteModele(int id)
        {
            await _modeleService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Modele>> UpdateModele(int id, ModeleDto request)
        {
            var modele = await _modeleService.GetByIdAsync(id);
            if (modele == null)
            {
                return NotFound();
            }

            modele.Name = request.Name;
            modele.IdMarque = request.IdMarque;
            var updatedModele = await _modeleService.UpdateAsync(modele);
            return Ok(updatedModele);
        }
    }
}