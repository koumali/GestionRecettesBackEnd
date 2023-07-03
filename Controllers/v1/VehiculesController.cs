using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Gestion;
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
        private readonly IVehicule _VehiculeService;


        public VehiculesController(IUser userService, IJwt jwtService, IVehicule VehiculeService)
        {
            _jwtService = jwtService;
            _VehiculeService = VehiculeService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult<IEnumerable<Vehicule>> GetVehicules()
        {
            var Vehicules = _VehiculeService.getVehicules();
            return Ok(Vehicules);
        }

        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Vehicule> GetRoleById(int id)
        {
            var Vehicule = _VehiculeService.findById(id);
            return Ok(Vehicule);
        }
        //<summary>
        //Add Vehicule
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Vehicule> AddVehicule(VehiculeDto request)
        {
            var Vehicule = new Vehicule()
            {
                name = request.name,
                matricule = request.matricule,
                prix = request.prix,
                nb_port = request.nb_port,
                nb_passager = request.nb_passager,
                km = request.km,
                climat = request.climat,
                airbag = request.airbag,
                image = request.image,
                gearbox = request.gearbox,
                moteur = request.moteur,
                id_agence = request.id_agence,
                id_modele = request.id_modele,
            };
            var addedVehicule = _VehiculeService.add(Vehicule);
            return Ok(addedVehicule);
        }

        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteVehicule(int id)
        {
            _VehiculeService.delete(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Vehicule> UpdateVehicule(int id, VehiculeDto request)
        {
            var vehicule = _VehiculeService.findById(id);
            if (vehicule == null)
            {
                return NotFound();
            }

            // Update the Vehicule properties
            vehicule.name = request.name;
            vehicule.matricule = request.matricule;
            vehicule.prix = request.prix;
            vehicule.nb_port = request.nb_port;
            vehicule.nb_passager = request.nb_passager;
            vehicule.km = request.km;
            vehicule.climat = request.climat;
            vehicule.airbag = request.airbag;
            vehicule.image = request.image;
            vehicule.gearbox = request.gearbox;
            vehicule.moteur = request.moteur;
            vehicule.id_agence = request.id_agence;
            vehicule.id_modele = request.id_modele;

            var updatedVehicule = _VehiculeService.update(vehicule);
            return Ok(updatedVehicule);
        }
    }
}