using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Utility;
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
        private readonly IFileHelper _fileHelper;


        public VehiculesController(IVehicule vehiculeService, IMapper mapper, IFileHelper fileHelper)
        {
            _vehiculeService = vehiculeService;
            _mapper = mapper;
            _fileHelper = fileHelper;
        }

        [HttpGet("marque/{name}")]
        public async Task<ActionResult<IEnumerable<Vehicule>>> GetVehiculesByMarque(string name)
        {
            return Ok(await _vehiculeService.GetVehiculesByMarque(name));
        }

        [HttpGet("reserved/{number}")]
        public ActionResult<IEnumerable<Vehicule>> GetTopReservedVehicules(int number)
        {
            return Ok(_vehiculeService.GetTopReservedVehicules(number));
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<Vehicule>>> GetVehicules()
        {
            var vehicules = await _vehiculeService.GetAllAsync();
            return Ok(vehicules);
        }

        [HttpGet("agence/{idAgence}")]
        [Authorize(Roles = "Commercial, Agent, Gerant")]
        [ValidatIdAgence("idAgence")]
        public async Task<ActionResult<IEnumerable<Vehicule>>> GetVehiculesAgence(int idAgence)
        {
            var vehicules = await _vehiculeService.GetVehiculesAgence(idAgence);
            return Ok(vehicules);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin, Commercial, Agent, Gerant")]
        public async Task<ActionResult<Vehicule>> GetVehiculeById(int id)
        {
            var vehicule = await _vehiculeService.GetByIdAsync(id);
            return Ok(vehicule);
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Commercial, Agent, Gerant")]
        public async Task<ActionResult<Vehicule>> AddVehicule([FromForm] VehiculeDto request)
        {
            var vehicule = _mapper.Map<Vehicule>(request);
            if (request.Image != null)
            {
                vehicule.Image = await _fileHelper.UploadImage(request.Image, "vehicules");
            }

            var addedVehicule = await _vehiculeService.CreateAsync(vehicule);
            return Ok(addedVehicule);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin, Commercial, Agent, Gerant")]
        public async Task<ActionResult> DeleteVehicule(int id)
        {
            await _vehiculeService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin, Commercial, Agent, Gerant")]
        public async Task<ActionResult<Vehicule>> UpdateVehicule(int id, [FromForm] VehiculeDto request)
        {
            if (id != request.Id)
            {
                return BadRequest(new { errors = "Id incoherent" });
            }

            var vehicule = await _vehiculeService.GetByIdAsync(id);

            if (request.Image != null)
            {
                vehicule.Image = await _fileHelper.UploadImage(request.Image, "vehicules");
            }

            vehicule.Name = request.Name;
            vehicule.Matricule = request.Matricule;
            vehicule.Prix = request.Prix;
            vehicule.NbPort = request.NbPort;
            vehicule.NbPassager = request.NbPassager;
            vehicule.Km = request.Km;
            vehicule.Climat = request.Climat;
            vehicule.Airbag = request.Airbag;
            vehicule.Gearbox = request.Gearbox;
            vehicule.Moteur = request.Moteur;
            vehicule.IdAgence = request.IdAgence;
            vehicule.IdModele = request.IdModele;


            var updatedVehicule = await _vehiculeService.UpdateAsync(vehicule);
            return Ok(updatedVehicule);
        }
    }
}