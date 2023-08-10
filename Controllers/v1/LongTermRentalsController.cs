using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Attributes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Utility;


namespace AutomotiveApi.Controllers.v1;

[Route("api/v1/[controller]")]
[ApiController]
[HasPermission(PredefinedPermissions.LongTerm)]
public class LongTermRentalsController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly ILongTermRental _longTermRentalService;
    private readonly INotification _notification;


    public LongTermRentalsController(ILongTermRental longTermRentalService, IMapper mapper,
        INotification notification)
    {
        _longTermRentalService = longTermRentalService;
        _mapper = mapper;
        _notification = notification;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<LongTermRental>>> GetLongTermRentals()
    {
        var longTermRentals = await _longTermRentalService.GetAllAsync();
        return Ok(longTermRentals);
    }

    [HttpGet("requests/agence/{idAgence}")]
    [ValidatIdAgence("idAgence")]
    public async Task<ActionResult<IEnumerable<LongTermRental>>> GetRequestsByAgence(int idAgence)
    {
        var longTermRentals = await _longTermRentalService.GetRequestsByAgence(idAgence);
        return Ok(longTermRentals);
    }

    [HttpGet("agence/{idAgence}")]
    [ValidatIdAgence("idAgence")]
    public async Task<ActionResult<IEnumerable<LongTermRental>>> GetLongTermRentalsByAgence(int idAgence)
    {
        var longTermRentals = await _longTermRentalService.GetLongTermRentalsByAgence(idAgence);
        return Ok(longTermRentals);
    }

    [HttpGet("maReservation")]
    [AllowAnonymous]
    public async Task<ActionResult<LongTermRental>> GererMaReservation(string numero, string email)
    {
        // verify reservation
        var reservation = await _longTermRentalService.GererMaReservation(numero, email);
        if (reservation is null) return BadRequest(new { error = "Reservation not found" });
        return reservation;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<LongTermRental>> GetLongTermRentalById(int id)
    {
        var longTermRental = await _longTermRentalService.GetByIdAsync(id);
        return Ok(longTermRental);
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<ActionResult<LongTermRental>> AddLongTermRental(LongTermRentalDto request)
    {
        var longTermRental = _mapper.Map<LongTermRental>(request);
        var numeroReservation = ReservationNumberGenerator.GenerateReservationNumber();
        longTermRental.status = ReservationStatus.Enattente.ToString();
        longTermRental.NumeroReservation = numeroReservation;
        longTermRental.CreatedAt = DateTime.Now;
        var addedLongTermRental = await _longTermRentalService.CreateAsync(longTermRental, request.selectedAgences);

        return Ok(addedLongTermRental);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteLongTermRental(int id)
    {
        await _longTermRentalService.DeleteAsync(id);
        return Ok();
    }


    [HttpPut("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<LongTermRental>> UpdateLongTermRental(int id,
        UpdateLongTermRentalModelDto request)
    {
        var longTermRental = await _longTermRentalService.GetByIdAsync(id);
        if (longTermRental == null)
        {
            return NotFound();
        }

        if (longTermRental.status == ReservationStatus.Enattente.ToString())
        {
            longTermRental.status = ReservationStatus.Confirmé.ToString();
            longTermRental.idAgence = request.IdAgence;
            var updatedLongTermRental = await _longTermRentalService.UpdateAsync(longTermRental);
            //notify the agence
            await _notification.CreateNotifForAgency(updatedLongTermRental.Id, type: "LongTermRental");
            return Ok(updatedLongTermRental);
        }

        return BadRequest(new { errors = "la reservation est deja confirmé" });
    }
}