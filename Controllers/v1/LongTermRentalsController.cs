using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AutomotiveApi.Services.Gestion.Interfaces;
using AutomotiveApi.Utility;

namespace AutomotiveApi.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LongTermRentalsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILongTermRental _longTermRentalService;


        public LongTermRentalsController(ILongTermRental longTermRentalService, IMapper mapper)
        {
            _longTermRentalService = longTermRentalService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin, Gerant")]
        public async Task<ActionResult<IEnumerable<LongTermRental>>> GetLongTermRentals()
        {
            var longTermRentals = await _longTermRentalService.GetAllAsync();
            return Ok(longTermRentals);
        }

        [HttpGet("maReservation")]
        public async Task<ActionResult<LongTermRental>> GererMaReservation(string numero, string email)
        {
            // verify reservation
            var reservation = await _longTermRentalService.GererMaReservation(numero, email);
            if (reservation is null) return BadRequest(new { error = "Reservation not found" });
            return reservation;
        }
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<LongTermRental>> GetLongTermRentalById(int id)
        {
            var longTermRental = await _longTermRentalService.GetByIdAsync(id);
            return Ok(longTermRental);
        }

        [HttpPost]
        public async Task<ActionResult<LongTermRental>> AddLongTermRental(LongTermRentalDto request)
        {
            var longTermRental = _mapper.Map<LongTermRental>(request);
            var numeroReservation = ReservationNumberGenerator.GenerateReservationNumber();
            longTermRental.status = ReservationStatus.Pending.ToString();
            longTermRental.NumeroReservation = numeroReservation;
            longTermRental.CreatedAt = DateTime.Now;
            var addedLongTermRental = await _longTermRentalService.CreateAsync(longTermRental);
            return Ok(addedLongTermRental);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteLongTermRental(int id)
        {
            await _longTermRentalService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<LongTermRental>> UpdateLongTermRental(int id, UpdateLongTermRentalModelDto request)
        {
            var longTermRental = await _longTermRentalService.GetByIdAsync(id);
            if (longTermRental == null)
            {
                return NotFound();
            }
            longTermRental.idAgence = request.IdAgence;
            longTermRental.status = ReservationStatus.Confirmed.ToString();

            var updatedLongTermRental = await _longTermRentalService.UpdateAsync(longTermRental);
            return Ok(updatedLongTermRental);
        }
    }
}