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
    public class ModelesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IModele _modeleService;
        private readonly IMarque _marqueService;
        private readonly IFileHelper _fileHelper;


        public ModelesController(IModele modeleService, IMapper mapper, IFileHelper fileHelper, IMarque marqueService)
        {
            _modeleService = modeleService;
            _marqueService = marqueService;
            _mapper = mapper;
            _fileHelper = fileHelper;
        }

        [HttpGet]
        //[Authorize(Roles = "Admin, Commercial, Agent, Gerant")]
        public async Task<ActionResult<IEnumerable<Modele>>> GetModeles()
        {
            var modeles = await _modeleService.GetAllAsync();
            return Ok(modeles);
        }

        [HttpGet("agence/{idAgence}")]
        [Authorize(Roles = "Commercial, Gerant, Agent")]
        [ValidatIdAgence("idAgence")]
        public async Task<ActionResult<IEnumerable<Modele>>> GetModelesAgence(int idAgence)
        {
            var modeles = await _modeleService.GetModelesAgence(idAgence);
            return Ok(modeles);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin, Commercial, Agent, Gerant")]
        public async Task<ActionResult<Modele>> GetModeleById(int id)
        {
            var modele = await _modeleService.GetByIdAsync(id);
            return Ok(modele);
        }
        //<summary>
        //Add Modele
        //</summary>

        [HttpPost]
        [Authorize(Roles = "Admin, Commercial, Agent, Gerant")]
        public async Task<ActionResult<Modele>> AddModele([FromForm] ModeleDto request)
        {
            var modele = _mapper.Map<Modele>(request);

            if (request.Image != null)
            {
                var marque = await _marqueService.GetByIdAsync(request.IdMarque);
                string folder = marque.Name + "/" + request.Name ?? "";
                modele.Image = await _fileHelper.UploadImage(request.Image, folder);
            }
            else
            {
                return BadRequest(new { errors = "Image is required" });
            }
            
            var addedModele = await _modeleService.CreateAsync(modele);
            return Ok(addedModele);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin, Commercial, Agent, Gerant")]
        public async Task<ActionResult> DeleteModele(int id)
        {
            await _modeleService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin, Commercial, Agent, Gerant")]
        public async Task<ActionResult<Modele>> UpdateModele(int id, [FromForm] ModeleDto request)
        {
            if (id != request.Id)
            {
                return BadRequest(new { errors = "Id in body doesn't match Id in URI" });
            }

            var modele = await _modeleService.GetByIdAsync(id);
            if (request.Image != null)
            {
                string folder = modele.Marque.Name + "/" + request.Name ?? "";
                modele.Image = await _fileHelper.UploadImage(request.Image, folder);
            }

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