using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1;

[Route("api/v1/[controller]")]
[ApiController]
[HasPermission(PredefinedPermissions.Vehicles)]
public class VehiculesController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IVehicule _vehiculeService;

    public VehiculesController(IVehicule vehiculeService, IMapper mapper)
    {
        _vehiculeService = vehiculeService;
        _mapper = mapper;
    }

    [HttpGet("marque/{name}")]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<Vehicule>>> GetVehiculesByMarque(string name)
    {
        return Ok(await _vehiculeService.GetVehiculesByMarque(name));
    }

    [HttpGet("reserved/{number}")]
    [AllowAnonymous]
    public ActionResult<IEnumerable<Vehicule>> GetTopReservedVehicules(int number)
    {
        return Ok(_vehiculeService.GetTopReservedVehicules(number));
    }


    [HttpGet("agence/{idAgence}")]
    [ValidatIdAgence("idAgence")]
    public async Task<ActionResult<IEnumerable<Vehicule>>> GetVehiculesAgence(int idAgence)
    {
        var vehicules = await _vehiculeService.GetVehiculesAgence(idAgence);
        return Ok(vehicules);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Vehicule>> GetVehiculeById(int id)
    {
        var vehicule = await _vehiculeService.GetByIdAsync(id);
        return Ok(vehicule);
    }

    [HttpPost]
    public async Task<ActionResult<Vehicule>> AddVehicule(VehiculeDto request)
    {
        var vehicule = _mapper.Map<Vehicule>(request);
        var addedVehicule = await _vehiculeService.CreateAsync(vehicule);
        return Ok(addedVehicule);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteVehicule(int id)
    {
        await _vehiculeService.DeleteAsync(id);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Vehicule>> UpdateVehicule(int id, VehiculeDto request)
    {
        if (id != request.Id)
        {
            return BadRequest(new { errors = "id non valide" });
        }

        var vehicule = await _vehiculeService.GetByIdAsync(id);

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
        vehicule.Type = request.Type;


        var updatedVehicule = await _vehiculeService.UpdateAsync(vehicule);
        return Ok(updatedVehicule);
    }
}