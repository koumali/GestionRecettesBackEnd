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
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservation _reservationService;
        private readonly IMapper _mapper;
        private readonly IClient _clientService;
        private readonly IContrat _contratService;
        private readonly IClient _client;


        public ReservationsController(IReservation reservationService, IMapper mapper, IClient clientService,
            IContrat contratService, IClient client)
        {
            _reservationService = reservationService;
            _mapper = mapper;
            _clientService = clientService;
            _contratService = contratService;
            _client = client;
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
            var reservation = _mapper.Map<Reservation>(request);
            var addedReservation = await _reservationService.CreateAsync(reservation);
            return Ok(addedReservation);
        }

        [HttpGet("maReservation")]
        public async Task<ActionResult<Reservation>> GererMaReservation(string numero, string email)
        {
            // verify client
            var client = await _client.GetClientByEmail(email);
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
            var createdClient = await _clientService.AddAsync(client);

            var conducteur = request.Conducteurs.Last();
            var createdConducteur = await _clientService.AddAsync(conducteur);

            var newContrat1 = new Contrat
            {
                IdClient = createdClient.Id,
                IdReservation = createdRes.Id,
                IsConducteur = false
            };


            var newContrat2 = new Contrat
            {
                IdClient = createdConducteur.Id,
                IdReservation = createdRes.Id,
                IsConducteur = true
            };

            try
            {
                await _contratService.CreateAsync(newContrat1);
                await _contratService.CreateAsync(newContrat2);
            }
            catch (Exception e)
            {
                return BadRequest(new { errors = e.Message });
            }

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
            var updatedReservation = await _reservationService.UpdateAsync(reservation);
            return Ok(updatedReservation);
        }
    }
}