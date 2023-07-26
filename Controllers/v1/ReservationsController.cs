using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Models.Entities.Param;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Services.Mail;
using AutomotiveApi.Services.Param;
using AutomotiveApi.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomotiveApi.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservation _reservationService;
        private readonly IMapper _mapper;
        private readonly IClient _clientService;
        private readonly IContrat _contratService;
        private readonly IUser _userService;
        private readonly IMailService _emailService;

        public ReservationsController(IReservation reservationService, IMapper mapper, IClient clientService, IUser userService, IMailService emailService,
            IContrat contratService)
        {
            _reservationService = reservationService;
            _mapper = mapper;
            _clientService = clientService;
            _contratService = contratService;
            _userService = userService;
            _emailService = emailService;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetReservations()
        {
            var reservations = await _reservationService.GetAllAsync();
            return Ok(reservations);
        }

        [HttpGet("agence/{idAgence}")]
        [Authorize(Roles = "Commercial, Gerant")]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetReservationsAgence(int idAgence)
        {
            var reservations = await _reservationService.GetReservationsAgence(idAgence);
            return Ok(reservations);
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Commercial, Gerant")]
        public async Task<ActionResult<Reservation>> AddReservation(ReservationDto request)
        {
            // generate number of reservation
            var numeroReservation = ReservationNumberGenerator.GenerateReservationNumber();
            var newReservation = new Reservation
            {
                DateDepart = request.DateDepart,
                DateRetour = request.DateRetour,
                IdVehicule = request.IdVehicule,
                Status = request.Status,
                NumeroReservation = numeroReservation
            };
            var addedReservation = await _reservationService.CreateAsync(newReservation);
            return Ok(addedReservation);
        }

        [HttpGet("maReservation")]
        public async Task<ActionResult<Reservation>> GererMaReservation(string numero, string email)
        {
            // verify client
            var client = await _clientService.GetClientByEmail(email);
            if (client is null) return BadRequest(new { error = "Client not found" });
            // verify reservation
            var reservation = await _reservationService.GererMaReservation(numero, email);
            if (reservation is null) return BadRequest(new { error = "Reservation not found" });
            return reservation;
        }

        [HttpPost("public")]
        public async Task<ActionResult<Reservation>> AddReservationPublic([FromForm] FullReservationDto request)
        {
            // generate number of reservation
            var numeroReservation = ReservationNumberGenerator.GenerateReservationNumber();
            var newReservation = new Reservation
            {
                DateDepart = request.DateDepart,
                DateRetour = request.DateRetour,
                IdVehicule = request.IdVehicule,
                Status = ReservationStatus.Pending.ToString(),
                NumeroReservation = numeroReservation
            };

            var createdRes = await _reservationService.CreateAsync(newReservation);

            var client = request.Conducteurs.First();

            client.Id = client.Id == 0 ? 0 : int.Parse(User.FindFirst("clientId")?.Value ?? "0");
            Client newClient = client.Id == 0 ? await _clientService.AddAsync(client) : await _clientService.UpdateAsync(client);

            try
            {
                MailData mailData = new MailData
                {
                    To = client.Email,
                    Subject = "Votre reservation a été bien enregistrée",
                    Body = $"Votre reservation a été bien enregistrée, votre numéro de reservation est {createdRes.NumeroReservation}"
                };

                _emailService.SendFullEmail(mailData);
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

            return CreatedAtAction(nameof(GetReservationById), new { id = createdRes.Id }, createdRes);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin, Commercial, Gerant")]
        [ValidatIdAgence("idAgence")]
        public async Task<ActionResult<Reservation>> GetReservationById(int id)
        {
            var reservation = await _reservationService.GetByIdAsync(id);
            return Ok(reservation);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin, Commercial, Gerant")]
        public async Task<ActionResult> DeleteReservation(int id)
        {
            await _reservationService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin, Commercial, Gerant")]
        public async Task<ActionResult<Reservation>> UpdateReservation(int id, ReservationDto request)
        {
            var reservation = await _reservationService.GetByIdAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }

            reservation.IdVehicule = request.IdVehicule;
            reservation.DateDepart = request.DateDepart;
            reservation.DateRetour = request.DateRetour;
            reservation.Status = request.Status;
            var updatedReservation = await _reservationService.UpdateAsync(reservation);
            return Ok(updatedReservation);
        }
    }
}