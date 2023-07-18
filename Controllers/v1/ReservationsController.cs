using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Attributes;
using AutomotiveApi.Services.Gestion.Interfaces;
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


        public ReservationsController(IReservation reservationService, IMapper mapper, IClient clientService, IContrat contratService)
        {
            _reservationService = reservationService;
            _mapper = mapper;
            _clientService = clientService;
            _contratService = contratService;
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

        [HttpPost("public")]
        public async Task<ActionResult<Reservation>> AddReservationPublic([FromForm] FullReservationDto request)
        {
            Reservation newReservation = new Reservation
            {
                DateDepart = request.DateDepart,
                DateRetour = request.DateRetour,
                IdVehicule = request.IdVehicule
            };

            Reservation createdRes = await _reservationService.CreateAsync(newReservation);

            ClientDto client = request.Conducteurs.First();
            Client createdClient = await _clientService.AddAsync(client);

            ClientDto conducteur = request.Conducteurs.Last();
            Client createdConducteur = await _clientService.AddAsync(conducteur);

            Contrat newContrat1 = new Contrat
            {
                IdClient = createdClient.Id,
                IdReservation = createdRes.Id,
                IsConducteur = false
            };


            Contrat newContrat2 = new Contrat
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
             return BadRequest(new {errors = e.Message});
            }

            return CreatedAtAction(nameof(GetReservationById), new {id = createdRes.Id}, createdRes);

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