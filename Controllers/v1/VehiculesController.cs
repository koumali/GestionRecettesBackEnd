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
    public class VehiculesController : ControllerBase
    {
        private readonly IJwt _jwtService;
        private readonly IMapper _mapper;
        private readonly IVehicule _vehiculeService;


        public VehiculesController(IUser userService, IJwt jwtService, IVehicule VehiculeService, IMapper mapper)
        {
            _jwtService = jwtService;
            _vehiculeService = VehiculeService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<Vehicule>>> GetVehicules()
        {
            var vehicules = await _vehiculeService.GetAllAsync();
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
            // var Vehicule = new Vehicule()
            // {
            //     name = request.name,
            //     matricule = request.matricule,
            //     prix = request.prix,
            //     nb_port = request.nb_port,
            //     nb_passager = request.nb_passager,
            //     km = request.km,
            //     climat = request.climat,
            //     airbag = request.airbag,
            //     image = request.image,
            //     gearbox = request.gearbox,
            //     moteur = request.moteur,
            //     id_agence = request.id_agence,
            //     id_modele = request.id_modele,
            // };
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
            var result = await _vehiculeService.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            // Update the Vehicule properties
            // vehicule.name = request.name;
            // vehicule.matricule = request.matricule;
            // vehicule.prix = request.prix;
            // vehicule.nb_port = request.nb_port;
            // vehicule.nb_passager = request.nb_passager;
            // vehicule.km = request.km;
            // vehicule.climat = request.climat;
            // vehicule.airbag = request.airbag;
            // vehicule.image = request.image;
            // vehicule.gearbox = request.gearbox;
            // vehicule.moteur = request.moteur;
            // vehicule.id_agence = request.id_agence;
            // vehicule.id_modele = request.id_modele;
            var vehicule = _mapper.Map<Vehicule>(request);

            var updatedVehicule = await _vehiculeService.UpdateAsync(vehicule);
            return Ok(updatedVehicule);
        }
    }
}