using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
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


        public ReservationsController(IReservation reservationService, IMapper mapper)
        {
            _reservationService = reservationService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetReservations()
        {
            var reservations = await _reservationService.GetAllAsync();
            return Ok(reservations);
        }

        [HttpGet("{idAgence}")]
        [Authorize(Roles = "Commercial, Gerant")]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetReservationsAgence(int idAgence)
        {
            var reservations = await _reservationService.GetReservationsAgence(idAgence);
            return Ok(reservations);
        }
        //<summary>
        //Add Reservation
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin, Commercial, Gerant")]
        public async Task<ActionResult<Reservation>> AddReservation(ReservationDto request)
        {
            var reservation = _mapper.Map<Reservation>(request);
            var addedReservation = await _reservationService.CreateAsync(reservation);
            return Ok(addedReservation);
        }

        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin, Commercial, Gerant")]
        public async Task<ActionResult<Reservation>> GetReservationById(int id)
        {
            var reservation = await _reservationService.GetByIdAsync(id);
            return Ok(reservation);
        }

        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin, Commercial, Gerant")]
        public async Task<ActionResult> DeleteReservation(int id)
        {
            await _reservationService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
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