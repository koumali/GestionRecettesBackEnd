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
        private readonly IReservation _reservationservice;
        private readonly IMapper _mapper;


        public ReservationsController(IReservation Reservationservice)
        {
            _reservationservice = Reservationservice;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetReservations()
        {
            var reservations = await _reservationservice.GetAllAsync();
            return Ok(reservations);
        }
        //<summary>
        //Add Reservation
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Reservation>> AddReservation(ReservationDto request)
        {
            var reservation = _mapper.Map<Reservation>(request);
            var addedReservation = await _reservationservice.CreateAsync(reservation);
            return Ok(addedReservation);
        }

        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Reservation>> GetReservationById(int id)
        {
            var reservation = await _reservationservice.GetByIdAsync(id);
            return Ok(reservation);
        }

        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteReservation(int id)
        {
            await _reservationservice.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Reservation>> UpdateReservation(int id, ReservationDto request)
        {
            var result = await _reservationservice.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            // Update the Reservation properties
            var reservation = _mapper.Map<Reservation>(request);
            // reservation.id_vehicule = request.id_vehicule;
            // reservation.date_depart = request.date_depart;
            // reservation.date_retour = request.date_retour;

            var updatedReservation = await _reservationservice.UpdateAsync(reservation);
            return Ok(updatedReservation);
        }
    }
}