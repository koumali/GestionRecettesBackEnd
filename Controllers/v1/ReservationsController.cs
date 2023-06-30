using automotiveApi.Models;
using automotiveApi.Models.Dto;
using automotiveApi.Services.Gestion;
using automotiveApi.Services.Jwt;
using automotiveApi.Services.Param;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace automotiveApi.Controllers.v1
{

    [ApiController]

    [Route("api/v1/[controller]")]

    public class ReservationsController : ControllerBase
    {

        private readonly IJwt _jwtService;
        private readonly IReservation _Reservationservice;


        public ReservationsController(IUser userService, IJwt jwtService, IReservation Reservationservice)
        {
            _jwtService = jwtService;
            _Reservationservice = Reservationservice;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult<IEnumerable<Reservation>> GetReservations()
        {
            var Reservations = _Reservationservice.getReservations();
            return Ok(Reservations);
        }
        //<summary>
        //Add Reservation
        //</summary>

        [HttpPost("Insert")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Reservation> AddReservation(ReservationDto request)
        {
            var Reservation = new Reservation()
            {
                id_vehicule= request.id_vehicule,
                id_agence = request.id_agence,
                date_depart = request.date_depart,
                date_retour = request.date_retour,
    };
            var addedReservation = _Reservationservice.add(Reservation);
            return Ok(addedReservation);
        }
        [HttpPost("Load/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Reservation> GetReservationById(int id)
        {
            var Reservation = _Reservationservice.findById(id);
            return Ok(Reservation);
        }
        [HttpDelete("Delete/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteReservation(int id)
        {
            _Reservationservice.delete(id);
            return Ok();
        }

        [HttpPut("Update/{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<Reservation> UpdateReservation(int id, ReservationDto request)
        {
            var Reservation = _Reservationservice.findById(id);
            if (Reservation == null)
            {
                return NotFound();
            }

            // Update the Reservation properties
            Reservation.id_vehicule = request.id_vehicule;
            Reservation.id_agence = request.id_agence;
            Reservation.date_depart = request.date_depart;
            Reservation.date_retour = request.date_retour;

            var updatedReservation = _Reservationservice.update(Reservation);
            return Ok(updatedReservation);
        }
    }

}