using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class VehiculesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IVehicule _vehiculeService;


        public VehiculesController(IVehicule vehiculeService, IMapper mapper)
        {
            _vehiculeService = vehiculeService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<Vehicule>>> GetVehicules()
        {
            var vehicules = await _vehiculeService.GetAllAsync();
            return Ok(vehicules);
        }

        [HttpGet("{idAgence}")]
        [Authorize(Roles = "Commercial, Agent, Gerant")]
        public async Task<ActionResult<IEnumerable<Vehicule>>> GetVehiculesAgence(int idAgence)
        {
            var vehicules = await _vehiculeService.GetVehiculesAgence(idAgence);
            return Ok(vehicules);
        }

        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Vehicule>> GetRoleById(int id)
        {
            var vehicule = await _vehiculeService.GetByIdAsync(id);
            return Ok(vehicule);
        }
        //<summary>
        //Add Vehicule
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Vehicule>> AddVehicule(VehiculeDto request)
        {
            var vehicule = _mapper.Map<Vehicule>(request);
            var addedVehicule = await _vehiculeService.CreateAsync(vehicule);
            return Ok(addedVehicule);
        }

        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteVehicule(int id)
        {
            await _vehiculeService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Vehicule>> UpdateVehicule(int id, VehiculeDto request)
        {
            var vehicule = await _vehiculeService.GetByIdAsync(id);
            if (vehicule == null)
            {
                return NotFound();
            }

            vehicule.Name = request.Name;
            vehicule.Matricule = request.Matricule;
            vehicule.Prix = request.Prix;
            vehicule.NbPort = request.NbPort;
            vehicule.NbPassager = request.NbPassager;
            vehicule.Km = request.Km;
            vehicule.Climat = request.Climat;
            vehicule.Airbag = request.Airbag;
            vehicule.Image = request.Image;
            vehicule.Gearbox = request.Gearbox;
            vehicule.Moteur = request.Moteur;
            vehicule.IdAgence = request.IdAgence;
            vehicule.IdModele = request.IdModele;
            var updatedVehicule = await _vehiculeService.UpdateAsync(vehicule);
            return Ok(updatedVehicule);
        }
    }
}