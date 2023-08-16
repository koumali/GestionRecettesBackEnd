using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Utility;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1;

[ApiController]
[Route("api/v1/[controller]")]
[HasPermission(PredefinedPermissions.Reservations)]
public class ContratsController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IContrat _contratService;


    public ContratsController(IContrat contratService, IMapper mapper)
    {
        _contratService = contratService;
        _mapper = mapper;
    }

    [HttpGet]
    // // [Authorize(Roles = "Admin")]
    public async Task<ActionResult<IEnumerable<Contrat>>> GetContrats()
    {
        var contrats = await _contratService.GetAllAsync();
        return Ok(contrats);
    }
    //<summary>
    //Add Contrat
    //</summary>

    [HttpPost]
    // // [Authorize(Roles = "Admin")]
    public async Task<ActionResult<Contrat>> AddContrat(ContratDto request)
    {
        var contrat = _mapper.Map<Contrat>(request);

        var addedContrat = await _contratService.CreateAsync(contrat);
        return Ok(addedContrat);
    }

    [HttpGet("{id}")]
    // // [Authorize(Roles = "Admin")]
    public async Task<ActionResult<Contrat>> GetContratById(int id)
    {
        var contrat = await _contratService.GetByIdAsync(id);
        return Ok(contrat);
    }

    [HttpDelete("{id}")]
    // // [Authorize(Roles = "Admin")]
    public async Task<ActionResult> DeleteContrat(int id)
    {
        Contrat contrat = await _contratService.DeleteContrat(id);
        return Ok(contrat);
    }

    [HttpPut("{id}")]
    // // [Authorize(Roles = "Admin")]
    public async Task<ActionResult<Contrat>> UpdateContrat(int id, ContratDto request)
    {
        var contrat = await _contratService.GetByIdAsync(id);
        if (contrat == null)
        {
            return NotFound();
        }

        contrat.IdClient = request.IdClient;
        contrat.IdReservation = request.IdReservation;
        contrat.IsConducteur = request.IsConducteur;
        var updatedContrat = await _contratService.UpdateAsync(contrat);
        return Ok(updatedContrat);
    }
}