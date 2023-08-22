using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Gestion;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Services.Mail;
using AutomotiveApi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace AutomotiveApi.Controllers.v1;

[Route("api/v1/[controller]")]
[ApiController]
[HasPermission(PredefinedPermissions.Agences)]
public class AgencesController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IAgence _agenceService;
    private readonly IMailService _mailService;

    public AgencesController(IAgence agenceService, IMapper mapper, IMailService mailService)
    {
        _agenceService = agenceService;
        _mapper = mapper;
        _mailService = mailService;
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<Agence>>> GetVerifiedAgences()
    {
        return Ok(await _agenceService.GetAllAsync());
    }

    [HttpGet("agences")]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<dynamic>>> GetAllAgences()
    {
        return Ok(await _agenceService.GetAllAgencesAsync());
    }

    [HttpGet("notVerified")]
    public async Task<ActionResult<IEnumerable<Agence>>> GetNotVerifiedAgences()
    {
        return Ok(await _agenceService.GetAllNotVerifiedAsync());
    }

    [HttpGet("Villes")]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<string>>> GetAgencesVilles()
    {
        return Ok(await _agenceService.GetAllVilleAsync());
    }
    [HttpGet("Partenaires")]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<string>>> GetAgencesLogos()
    {
        return Ok(await _agenceService.GetAllLogosAsync());
    }

    [HttpPost]
    public async Task<ActionResult<Agence>> AddAgence([FromForm] AgenceDto request)
    {
       
        var addedAgence = await _agenceService.AddAsync(request);

        return CreatedAtAction(nameof(GetAgenceById), new { id = addedAgence.Id }, addedAgence);
    }

    [HttpPost("client")]
    [AllowAnonymous]
    public async Task<ActionResult<Agence>> AddClientAgence([FromForm] AgenceClientDto request)
    {
        
        try
        {
            var addedAgence = await _agenceService.AddAbonAsync(request);
            MailAbonData mailData = new MailAbonData
            {
                Subject = "Agence ajoutée",
                Nom = request.Name,
                To = request.Email,
                Adresse=request.Address,
                Tel=request.Tel
            };

            await _mailService.SendAbonAsync(mailData);


            return CreatedAtAction(nameof(GetAgenceById), new { id = addedAgence.Id }, addedAgence);

        }
        catch (Exception ex)
        {
            return BadRequest(new { errors = ex.Message });
        }
    }

    [HttpGet("checkIsParent/{id}")]
    [AllowAnonymous]
    public ActionResult<bool> CheckIsParentAgence(int id)
    {
        var isParent = _agenceService.CheckIfParentAgence(id);
        return Ok(isParent);
    }

    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<Agence>> GetAgenceById(int id)
    {
        var agence = await _agenceService.GetByIdAsync(id);
        return Ok(agence);
    }

    [HttpGet("hisAgences/{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<List<Agence>>> GetAgenceWithHisSubAgences(int id)
    {
        return Ok(await _agenceService.GetAgenceWithHisSubAgences(id));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteAgence(int id)
    {
        await _agenceService.DeleteAsync(id);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Agence>> UpdateAgence(int id, [FromForm]  AgenceDto request)
    {
        var agence = await _agenceService.GetByIdAsync(id);
        if (agence == null)
            return NotFound(new { errors = "Agence non trouvée" });

        /*agence.Name = request.Name;
        agence.Tel = request.Tel;
        agence.Email = request.Email;
        agence.Address = request.Address;
        agence.City = request.City;
        agence.ZipCode = request.ZipCode;
        agence.Latitude = request.Latitude;
        agence.Longitude = request.Longitude;
        agence.IsVerified = request.IsVerified;*/
        //agence.Logo = request.Logo;

        var updatedAgence = await _agenceService.UpdateAsync(request);
        return Ok(updatedAgence);
    }
}