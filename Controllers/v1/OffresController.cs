using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1;

[ApiController]
[Route("api/v1/[controller]")]
[HasPermission(PredefinedPermissions.Offres)]
public class OffresController : ControllerBase
{
    private readonly IOffre _offreservice;
    private readonly IMapper _mapper;


    public OffresController(IOffre offreservice, IMapper mapper)
    {
        _offreservice = offreservice;
        _mapper = mapper;
    }


    [HttpGet("public")]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<Offre>>> GetPublicOffres(string type, string name, string startDate,
        string endDate)
    {
        var date1 = (new DateTime(1970, 1, 1)).AddMilliseconds(double.Parse(startDate));
        var date2 = (new DateTime(1970, 1, 1)).AddMilliseconds(double.Parse(endDate));
        var offres = await _offreservice.GetPublicOffres(type, name, datedebut: date2, datefin: date1);

        return Ok(offres);
    }

    [HttpGet("public/{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<Offre>> GetPublicOffreById(int id)
    {
        var offre = await _offreservice.GetPublicByIdAsync(id);
        return Ok(offre);
    }

    [HttpGet("agence/{idAgence}")]
    /*[ValidatIdAgence("idAgence")]*/
    public async Task<ActionResult<IEnumerable<Offre>>> GetOffresAgence(int idAgence)
    {
        var offres = await _offreservice.GetOffresAgence(idAgence);
        return Ok(offres);
    }

    [HttpPost]
    public async Task<ActionResult<Offre>> AddOffre(OffreDto request)
    {

        var addedOffre = await _offreservice.CreateWithDetailsAsync(request);
        return Ok(addedOffre);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Offre>> GetOffreById(int id)
    {
        var offre = await _offreservice.GetByIdAsync(id);
        return Ok(offre);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteOffre(int id)
    {
        await _offreservice.DeleteAsync(id);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Offre>> UpdateOffre(int id, OffreDto request)
    {
        var updatedOffre = await _offreservice.UpdateWithDetailsAsync(request);
        return Ok(updatedOffre);
    }
}