using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Services.Mail;
using AutomotiveApi.Services.Param;
using AutomotiveApi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1;

[ApiController]
[Route("api/v1/[controller]")]
[HasPermission(PredefinedPermissions.Reservations)]
public class ReservationsController : ControllerBase
{
    private readonly IReservation _reservationService;
    private readonly IMapper _mapper;
    private readonly IClient _clientService;
    private readonly IContrat _contratService;
    private readonly IUser _userService;
    private readonly IMailService _emailService;
    private readonly INotification _notification;

    public ReservationsController(IReservation reservationService, IMapper mapper, IClient clientService,
        IUser userService,
        IMailService emailService,
        IContrat contratService, INotification notification)
    {
        _reservationService = reservationService;
        _mapper = mapper;
        _clientService = clientService;
        _contratService = contratService;
        _userService = userService;
        _emailService = emailService;
        _notification = notification;
    }


    [HttpGet("agence/{idAgence}")]
    public async Task<ActionResult<IEnumerable<Reservation>>> GetReservationsAgence(int idAgence)
    {
        var reservations = await _reservationService.GetReservationsAgence(idAgence);
        return Ok(reservations);
    }

    [HttpPost]
    public async Task<ActionResult<Reservation>> AddReservation(ReservationDto request)
    {
        // generate number of reservation
        var numeroReservation = ReservationNumberGenerator.GenerateReservationNumber();
        var newReservation = new Reservation
        {
            DateDepart = request.DateDepart,
            DateRetour = request.DateRetour,
            Status = request.Status,
            NumeroReservation = numeroReservation            
        };
        var addedReservation = await _reservationService.CreateAsync(newReservation);
        return Ok(addedReservation);
    }

    [HttpGet("maReservation")]
    [AllowAnonymous]
    public async Task<ActionResult<MaReservationDto>> GererMaReservation(string numero, string email)
    {
        // verify client
        var client = await _clientService.GetClientByEmail(email);
        if (client is null) return BadRequest(new { error = "Client n'existe pas" });
        // verify reservation
        try
        {
            var reservation = await _reservationService.GererMaReservation(numero, email);
            return reservation;

        }catch (Exception ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }

    [HttpPost("public")]
    [AllowAnonymous]
    public async Task<ActionResult<Reservation>> AddReservationPublic([FromForm] FullReservationDto request)
    {
        // generate number of reservation
        var numeroReservation = ReservationNumberGenerator.GenerateReservationNumber();
        var newReservation = new Reservation
        {
            DateDepart = request.DateDepart,
            DateRetour = request.DateRetour,
            IdVehicule = request.IdVehicule,
            Status = ReservationStatus.Enattente.ToString(),
            NumeroReservation = numeroReservation,            
            MontantTotal = request.MontantTotal
        };

        

        var createdRes = await _reservationService.CreateAsync(newReservation);

        var client = request.Conducteurs.First();

        client.Id = client.Id == 0 ? 0 : int.Parse(User.FindFirst("clientId")?.Value ?? "0");
        Client newClient = client.Id == 0
            ? await _clientService.AddAsync(client)
            : await _clientService.UpdateAsync(client);

        try
        {
            MailReservData mailData = new MailReservData
            {
                To = client.Email,
                Subject = "Votre reservation a été bien enregistrée",
                CodeReservation =createdRes.NumeroReservation,
                ClientNom=client.LastName+""+client.FirstName,
                DateDebut= createdRes.DateDepart,
                DateFin= createdRes.DateRetour,
                //Modele= createdRes.Vehicule.Modele.Name,
                //AgenceTel=createdRes.Vehicule.Agence.Tel,
                //AgenceEmail=createdRes.Vehicule.Agence.Email,
                //AgenceNom=createdRes.Vehicule.Agence.Name,
                MontantTotal=createdRes.MontantTotal.ToString(),
            };

            await _emailService.SendReservAsync(mailData);
        }
        catch (Exception e)
        {
        }

        var newContrat1 = new Contrat
        {
            IdClient = newClient.Id,
            IdReservation = createdRes.Id,
            IsConducteur = false
        };


        if (request.Conducteurs.Count > 1)
        {
            var conducteur = request.Conducteurs.ElementAt(1);
            var createdConducteur = await _clientService.AddAsync(conducteur);
            var newContrat2 = new Contrat
            {
                IdClient = createdConducteur.Id,
                IdReservation = createdRes.Id,
                IsConducteur = true
            };

            await _contratService.CreateAsync(newContrat2);
        }

        await _contratService.CreateAsync(newContrat1);

        //notify the agence
        await _notification.CreateNotifForAgency(createdRes.Id, "Reservation");

        return CreatedAtAction(nameof(GetReservationById), new { id = createdRes.Id }, createdRes);
    }

    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<Reservation>> GetReservationById(int id)
    {
        var reservation = await _reservationService.GetByIdAsync(id);
        return Ok(reservation);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteReservation(int id)
    {
        await _reservationService.DeleteAsync(id);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Reservation>> UpdateReservation(int id, ReservationDto request)
    {
        if (id != request.Id) return BadRequest(new { errors = "les id ne sont pas identiques" });
        var reservation = _mapper.Map<Reservation>(request);

        var updatedReservation = await _reservationService.UpdateAsync(reservation);

        return Ok(updatedReservation);
    }
}