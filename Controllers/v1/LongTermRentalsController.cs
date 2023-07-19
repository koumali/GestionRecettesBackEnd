using AutoMapper;
using AutomotiveApi.Models.Dto;
using AutomotiveApi.Models.Entities.Gestion;
using AutomotiveApi.Services.Attributes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AutomotiveApi.Services.Gestion.Interfaces;

namespace AutomotiveApi.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LongTermRentalsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ILongTermRental _LongTermRentalService;


        public LongTermRentalsController(ILongTermRental LongTermRentalService, IMapper mapper)
        {
            _LongTermRentalService = LongTermRentalService;
            _mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<LongTermRental>>> GetLongTermRentals()
        {
            var LongTermRentals = await _LongTermRentalService.GetAllAsync();
            return Ok(LongTermRentals);
        }
       

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<LongTermRental>> GetLongTermRentalById(int id)
        {
            var LongTermRental = await _LongTermRentalService.GetByIdAsync(id);
            return Ok(LongTermRental);
        }

        [HttpPost]
        public async Task<ActionResult<LongTermRental>> AddLongTermRental(LongTermRentalDto request)
        {
            var LongTermRental = _mapper.Map<LongTermRental>(request);
            var addedLongTermRental = await _LongTermRentalService.CreateAsync(LongTermRental);
            return Ok(addedLongTermRental);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteLongTermRental(int id)
        {
            await _LongTermRentalService.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<LongTermRental>> UpdateLongTermRental(int id, LongTermRentalDto request)
        {
            var LongTermRental = await _LongTermRentalService.GetByIdAsync(id);
            if (LongTermRental == null)
            {
                return NotFound();
            }

            // Update the LongTermRental properties
            LongTermRental.prenom = request.prenom;
            LongTermRental.nom = request.nom;
            LongTermRental.phone = request.phone;
            LongTermRental.zip = request.zip;
            LongTermRental.email = request.email;
            LongTermRental.type_vehicule = request.type_vehicule;
            LongTermRental.duree = request.duree;
            LongTermRental.entreprise = request.entreprise;
            LongTermRental.ville = request.ville;
            LongTermRental.description = request.description;

            var updatedLongTermRental = await _LongTermRentalService.UpdateAsync(LongTermRental);
            return Ok(updatedLongTermRental);
        }
    }
}